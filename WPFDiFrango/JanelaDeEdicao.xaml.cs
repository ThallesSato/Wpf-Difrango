using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPFDiFrango.Models;
using WPFDiFrango.Models.Dto;

namespace WPFDiFrango
{
    /// <summary>
    /// Lógica interna para JanelaDeEdicao.xaml
    /// </summary>
    public partial class JanelaDeEdicao : Window
    {
        Pedido pedido { get; set; }
        public JanelaDeEdicao(Pedido pedido)
        {
            this.pedido = pedido;
            InitializeComponent();
            MostrarTudo();
        }

        private void MostrarTudo()
        {
            Telefone.Text = pedido.Cliente.Telefone;
            Nome.Text = pedido.Cliente.Nome;
            Endereco.Text = pedido.Cliente.Endereco;

            PedidoId.Content = pedido.Id;
            DataCriado.Content = pedido.DataHoraCriado.ToString("dd/MM/yyyy HH:mm");
            Data.Text = pedido.DataHoraPedido.ToString("dd/MM/yyyy");
            Hora.Text = pedido.DataHoraPedido.ToString("HH:mm");
            gridProduto.ItemsSource = pedido.Produtos;
        }

        private void UpdateClick(object sender, RoutedEventArgs e)
        {
            var pedidoId = Convert.ToInt32(PedidoId.Content);  
            List<ProdutoPedidoDto> produtosDto = new List<ProdutoPedidoDto>();
            List<ProdutoPedido>? produtos = gridProduto.ItemsSource as List<ProdutoPedido>;
            if (produtos != null)
            {
                foreach (ProdutoPedido produto in produtos)
                {
                    produtosDto.Add(new ProdutoPedidoDto(produto.Produto.Id, produto.Quantidade));
                }
                PedidoDto pedidoDto = new PedidoDto();
                pedidoDto.DataHoraPedido = Convert.ToDateTime(Data.Text + " " + Hora.Text);
                pedidoDto.Produtos = produtosDto;
                ApiService apiService = new ApiService();
                var response = apiService.PutPedido(pedidoId, pedidoDto);
                if (response) 
                {
                    MessageBox.Show("Pedido atualizado com sucesso!");
                    this.Close();
                }
            }
        }

        private void AddProdutoClick(object sender, RoutedEventArgs e)
        {
            AddProduto addProduto = new AddProduto();
            addProduto.ShowDialog();
            ProdutoPedido novo = new ProdutoPedido();
            novo.Produto = addProduto.ProdutoSelecionado;
            novo.Pedido = pedido;
            novo.Quantidade = 1;
            pedido.Produtos.Add(novo);
            gridProduto.ItemsSource = "";
            gridProduto.ItemsSource = pedido.Produtos;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EditarCliente editarCliente = new EditarCliente(pedido.Cliente);
            editarCliente.ShowDialog();
        }
    }
}
