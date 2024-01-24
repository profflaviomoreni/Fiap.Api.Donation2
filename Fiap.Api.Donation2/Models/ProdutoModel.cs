﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Fiap.Api.Donation2.Models;

namespace Fiap.Api.Donation2.Models
{
    [Table("Produto")]
    public class ProdutoModel
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProdutoId { get; set; }

        [StringLength(50)]
        public string Nome { get; set; }

        public bool Disponivel { get; set; }

        [StringLength(150)]
        public string Descricao { get; set; }

        [StringLength(200)]
        public string SugestaoTroca { get; set; }

        public double Valor { get; set; }

        public DateTime DataCadastro { get; set; } = DateTime.Now;

        public DateTime DataExpiracao { get; set; }


        //Foreing Key
        public int UsuarioId { get; set; }

        //Navigation Property
        [ForeignKey(nameof(UsuarioId))]
        public UsuarioModel Usuario { get; set; }

        //Foreign Key
        public int CategoriaId { get; set; }

        //Navigation Property
        [ForeignKey(nameof(CategoriaId))]
        public CategoriaModel Categoria { get; set; }


        public ProdutoModel()
        {
                
        }

        public ProdutoModel(int produtoId, string nome, bool disponivel, string descricao, string sugestaoTroca, double valor, int usuarioId, int categoriaId)
        {
            ProdutoId = produtoId;
            Nome = nome;
            Disponivel = disponivel;
            Descricao = descricao;
            SugestaoTroca = sugestaoTroca;
            Valor = valor;
            DataCadastro = DateTime.Now;
            DataExpiracao = DateTime.Now.AddMonths(20);
            UsuarioId = usuarioId;
            CategoriaId = categoriaId;
        }
    }
}
