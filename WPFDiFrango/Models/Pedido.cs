using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDiFrango.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public Cliente? Cliente { get; set; }
        public DateTime DataHoraPedido { get; set; }
        public bool Marcado { get; set; }
        public DateTime DataHoraCriado { get; set; }
        public List<ProdutoPedido>? Produtos { get; set; }
        public bool Deletado { get; set; }

        public string ProdutosToString
        {
            get
            {
                if (Produtos == null){
                    return "";
                }
                else
                {
                    string result = "";
                    foreach (var item in Produtos)
                    {
                        string? Nome = item.Produto.Nome;
                        float Qtd = item.Quantidade;
                        result += Qtd + " " + Nome.ToString() + ", ";
                    }
                    return result;
                }
            }
        }
    }
}
