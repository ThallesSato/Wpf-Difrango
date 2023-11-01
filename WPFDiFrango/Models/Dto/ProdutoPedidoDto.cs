using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDiFrango.Models.Dto
{
    public class ProdutoPedidoDto
    { 
        public ProdutoPedidoDto(int id, float quantidade)
        {
            ProdutoId = id;
            Quantidade = quantidade;
        }
        public ProdutoPedidoDto()
        {
        }

        public int ProdutoId { get; set; }
        public float Quantidade { get; set; }
    }

    
}
