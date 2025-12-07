using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using orquestraAPI.Pedidos.Domain.Entities;
using orquestraAPI.Pedidos.Domain.Interfaces;
using orquestraAPI.Pedidos.Application.DTOs;

namespace orquestraAPI.Pedidos.Application.Services
{
    public class ProdutoService
    {
       
        private readonly IProdutoRepository _repository;

        public ProdutoService(IProdutoRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Produto>> BuscarTodos()
        {
            return await _repository.GetAll();
        }

        public async Task<Produto?> BuscarPorId(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task Criar(ProdutoDTO dto)
        {
            var produto = new Produto
            {
                Nome = dto.Nome,
                Preco = dto.Preco,
                Quantidade = dto.Quantidade
            };

            await _repository.Add(produto);
        }

        public async Task Atualizar(int id, ProdutoDTO dto)
        {
            var produto = await _repository.GetById(id);
            if (produto == null) return;

            produto.Nome = dto.Nome;
            produto.Preco = dto.Preco;
            produto.Quantidade = dto.Quantidade;

            await _repository.Update(produto);
        }

        public async Task Remover(int id)
        {
            await _repository.Delete(id);
        }
    }
    
}
