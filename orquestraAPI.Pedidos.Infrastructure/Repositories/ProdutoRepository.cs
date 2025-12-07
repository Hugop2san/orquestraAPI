using orquestraAPI.Pedidos.Domain.Entities;
using orquestraAPI.Pedidos.Domain.Interfaces;

namespace orquestraAPI.Pedidos.Infrastructure.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private static readonly List<Produto> _produtos = new()
        {
            new Produto { Id = 1, Nome = "Notebook", Preco = 3200, Quantidade = 5 },
            new Produto { Id = 2, Nome = "Mouse Gamer", Preco = 150, Quantidade = 10 },
        };

        public Task<IEnumerable<Produto>> GetAll()
        {
            return Task.FromResult(_produtos.AsEnumerable());
        }

        public Task<Produto?> GetById(int id)
        {
            return Task.FromResult(_produtos.FirstOrDefault(p => p.Id == id));
        }

        public Task Add(Produto produto)
        {
            produto.Id = _produtos.Max(p => p.Id) + 1;
            _produtos.Add(produto);
            return Task.CompletedTask;
        }

        public Task Update(Produto produto)
        {
            var existing = _produtos.First(p => p.Id == produto.Id);
            existing.Nome = produto.Nome;
            existing.Preco = produto.Preco;
            existing.Quantidade = produto.Quantidade;

            return Task.CompletedTask;
        }

        public Task Delete(int id)
        {
            var p = _produtos.FirstOrDefault(x => x.Id == id);
            if (p != null)
                _produtos.Remove(p);

            return Task.CompletedTask;
        }


        // Realizar a logica das analizes depois
        public Task<int> TotalProdutos()
        {
            throw new NotImplementedException();
        }

        public Task<Produto> ProdutoMaisCaro()
        {
            throw new NotImplementedException();
        }
    }
}
