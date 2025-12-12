using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orquestraAPI.Pedidos.Infrastructure.ExternalModels
{
    
    public class ProdutoApiModel
    {
        public string id { get; set; }
        public string nome { get; set; }
        public string preco { get; set; }
        public string quantidade { get; set; }
    }
}
