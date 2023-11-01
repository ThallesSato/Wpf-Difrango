using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDiFrango.Models
{
    public class ProdutoPedido
    {
        public int PedidoId { get; set; }
        public int ProdutoId { get; set; }
        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }
        public float Quantidade { get; set; }
    }
}
