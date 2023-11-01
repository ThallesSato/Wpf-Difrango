using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDiFrango.Models.Dto
{
    public class PedidoDtoCliente
    {
        public ClienteDto? Cliente { get; set; }
        public DateTime DataHoraPedido { get; set; }
        public List<ProdutoPedidoDto>? Produtos { get; set; }
    }
}
