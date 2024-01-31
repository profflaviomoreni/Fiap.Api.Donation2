﻿using Fiap.Api.Donation2.Models;
using Fiap.Api.Donation2.Repository.Interface;

namespace Fiap.Api.Donation2.Services
{
    public class TrocaService {

        private readonly IProdutoRepository produtoRepository;
        private readonly ITrocaRepository trocaRepository;

        public TrocaService(IProdutoRepository pRepository, ITrocaRepository tRepository  )
        {
            produtoRepository = pRepository;
            trocaRepository = tRepository;
        }

        public async Task<Guid> TrocarProdutos(TrocaModel trocaModel)
        {

            var produto1 = produtoRepository.FindById(trocaModel.ProdutoId1); // Eu quero
            var produto2 = produtoRepository.FindById(trocaModel.ProdutoId2); // Meu produto

            if (produto1.Disponivel == false)
            {
                throw new Exception("Produto selecionado indisponível");
            }

            if (produto2.Disponivel == false)
            {
                throw new Exception("O seu produto já foi trocado");
            }

            if (produto1.UsuarioId == trocaModel.UsuarioId)
            {
                throw new Exception("Esse produto não pode ser escolhido pelo usuário da troca");
            }

            if (produto2.UsuarioId != trocaModel.UsuarioId)
            {
                throw new Exception("Não é possível trocar um produto de outro usuário.");
            }


            if ((produto2.Valor / produto1.Valor) < 0.9)
            {
                throw new Exception("O seu produto tem o valor menor que 90% do produto selecionado");
            }

            produto1.Disponivel = false;
            produtoRepository.Update(produto1);

            produto2.Disponivel = false;
            produtoRepository.Update(produto2);

            trocaModel.Status = TrocaStatus.Iniciado;
            trocaRepository.Insert(trocaModel);

            return trocaModel.TrocaId;
        }


    }
}
