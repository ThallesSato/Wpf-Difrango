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
using WPFDiFrango.Models.Dto;
using WPFDiFrango.Models;

namespace WPFDiFrango
{
    /// <summary>
    /// Lógica interna para NovoPedido.xaml
    /// </summary>
    public partial class NovoPedido : Window
    {
        PedidoDtoCliente pedidoDto = new PedidoDtoCliente();
        List<ProdutoPedido> produtos = new List<ProdutoPedido>();
        List<Cliente> clientes = new List<Cliente>();
        public NovoPedido()
        {
            InitializeComponent();
            _ = Mostrar();
            Telefone.Focus();
        }
        private async Task Mostrar()
        {
            Data.Text = DateTime.Now.ToString("dd/MM/yyyy");
            Telefone.Text = "11";
            ApiService apiService = new ApiService();
            clientes = await apiService.GetClientes();
        }

        private void PostClick(object sender, RoutedEventArgs e)
        {
            List<ProdutoPedidoDto> produtosDto = new List<ProdutoPedidoDto>();
            List<ProdutoPedido>? produtos = gridProduto.ItemsSource as List<ProdutoPedido>;
            if (produtos != null)
            {
                foreach (ProdutoPedido produto in produtos)
                {
                    produtosDto.Add(new ProdutoPedidoDto(produto.Produto.Id, produto.Quantidade));
                }
                ClienteDto clienteDto = new ClienteDto();
                clienteDto.Telefone = Regex.Replace(Telefone.Text, @"[^\d]", "");
                clienteDto.Nome = Nome.Text;
                clienteDto.Endereco = Endereco.Text;

                pedidoDto.DataHoraPedido = Convert.ToDateTime(Data.Text + " " + Hora.Text);
                pedidoDto.Produtos = produtosDto;
                pedidoDto.Cliente = clienteDto;
                ApiService apiService = new ApiService();
                var response = apiService.PostPedido(pedidoDto);
                if (response)
                {
                    MessageBox.Show("Pedido criado com sucesso!");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Adicione pelo menos um produto");
            }
        }

        private void AddProdutoClick(object sender, RoutedEventArgs e)
        {
            AddProduto addProduto = new AddProduto();
            addProduto.ShowDialog();
            if (addProduto.ProdutoSelecionado != null)
            {
                ProdutoPedido novo = new ProdutoPedido();
                novo.Produto = addProduto.ProdutoSelecionado;
                novo.Quantidade = 1;
                produtos.Add(novo);
                gridProduto.ItemsSource = "";
                gridProduto.ItemsSource = produtos;
            }
        }

        private void Telefone_TextChanged(object sender, TextChangedEventArgs e)
        {
            string texto = Regex.Replace(Telefone.Text, @"[^\d]", "");
            
            if (texto.Length > 3)
            {
                combotel.Visibility = Visibility.Visible;
                combotel.ItemsSource = clientes.Where(item => item.Telefone.StartsWith(texto)).Select(item => item.ToString);
            }
            else if(texto.Length > 0)
            {
                combotel.Visibility = Visibility.Hidden;
            }
        }

        private void Nome_TextChanged(object sender, TextChangedEventArgs e)
        {
            string texto = Nome.Text.ToLower();
            if (texto.Length > 1)
            {
                combonome.Visibility = Visibility.Visible;
                combonome.ItemsSource = clientes.Where(item => item.Nome.ToLower().StartsWith(texto)).Select(item => item.ToStringNome);
            }
            else if (texto.Length > 0)
            {
                combonome.Visibility = Visibility.Hidden;
            }
        }

        private void combotel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selec = combotel.SelectedItem.ToString();
            selec = selec[..11];
            SelecionarClienteTel(selec);
            combotel.Visibility = Visibility.Hidden;

        }

        private void combonome_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selec = combonome.SelectedItem.ToString();
            var nome = selec.Length - 13;
            selec = selec[..nome];
            SelecionarClienteNome(selec);
            combonome.Visibility = Visibility.Hidden;

        }

        private void SelecionarClienteTel(string telefone)
        {
            MessageBox.Show(telefone);
            Cliente cliente = clientes.Where(item => item.Telefone == telefone).FirstOrDefault();
            if (cliente != null)
            {
                Nome.Text = cliente.Nome;
                Endereco.Text = cliente.Endereco;
                Telefone.Text = telefone;
            }
            combonome.Visibility = Visibility.Hidden;
        }
        private void SelecionarClienteNome(string nome)
        {
            MessageBox.Show(nome);
            Cliente cliente = clientes.Where(item => item.Nome == nome).FirstOrDefault();
            if (cliente != null)
            {
                Nome.Text = cliente.Nome;
                Endereco.Text = cliente.Endereco;
                Telefone.Text = cliente.Telefone;
            }
            combotel.Visibility = Visibility.Hidden;
        }

        private void TextEnterTel(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                combotel.SelectedItem = combotel.Items.GetItemAt(0);
                combotel.Focus();
            }
        }

        private void TextEnterNome(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                combonome.SelectedItem = combonome.Items.GetItemAt(0);
                combonome.Focus();
            }
        }
    }
}
