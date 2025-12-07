using orquestraAPI.Pedidos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using orquestraAPI.Pedidos.Domain.Entities;


namespace orquestraAPI.Pedidos.Domain.Interfaces
{
    public interface IProdutoRepository
    {
        public Task<IEnumerable<Produto>> GetAll();
        public Task<Produto> GetById(int id);
        public Task Add(Produto produto);
        public Task Update(Produto produto);
        public Task Delete(int id);

        // análises
        public Task<int> TotalProdutos();
        public Task<Produto> ProdutoMaisCaro();
    }
}
