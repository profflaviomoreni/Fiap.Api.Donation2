using AutoMapper;
using Fiap.Api.Donation2;
using Fiap.Api.Donation2.Data;
using Fiap.Api.Donation2.Models;
using Fiap.Api.Donation2.Repository;
using Fiap.Api.Donation2.Repository.Interface;
using Fiap.Api.Donation2.ViewModel;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .ConfigureApiBehaviorOptions(options =>
    {
        options.SuppressModelStateInvalidFilter = true;
        options.SuppressMapClientErrors = true;
    });

var connectionString = builder.Configuration.GetConnectionString("databaseUrl");
builder.Services.AddDbContext<DataContext>(
    options => options.UseSqlServer(connectionString).EnableSensitiveDataLogging(true)
);

builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<ICategoriaRepository, CategoriaRepository>();
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();


#region Mapper
var mapperConfig = new AutoMapper.MapperConfiguration(c => { 
    c.AllowNullCollections = true;
    c.AllowNullDestinationValues = true;

    c.CreateMap<UsuarioModel, LoginRequestVM>();
    c.CreateMap<LoginRequestVM, UsuarioModel>();

    c.CreateMap<LoginResponseVM,UsuarioModel>();
    c.CreateMap<UsuarioModel, LoginResponseVM>();

    c.CreateMap<UsuarioModel, UsuarioResponseVM>();

});

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);
#endregion


#region autenticacao
bool CustomLifetimeValidator(DateTime? notBefore, DateTime? expires, SecurityToken tokenToValidate, TokenValidationParameters @param)
{
    if (expires != null)
    {
        return expires > DateTime.UtcNow;
    }
    return false;
}

var key = Encoding.ASCII.GetBytes(Settings.SECRET_TOKEN);

builder.Services.AddAuthentication(a => {
    a.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    a.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}
    ).AddJwtBearer(options => {
        options.RequireHttpsMetadata = false;
        options.SaveToken = true;
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            ValidateIssuer = true,
            ValidIssuer = "fiap",
            IssuerSigningKey = new SymmetricSecurityKey(key),
            LifetimeValidator = CustomLifetimeValidator, // forma de validar se o token está expirado
            ValidateAudience = false,
            ValidateLifetime = true,
            RequireExpirationTime = true
        };
    });


#endregion



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
