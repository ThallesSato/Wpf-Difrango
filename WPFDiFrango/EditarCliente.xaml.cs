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

namespace WPFDiFrango
{
    /// <summary>
    /// Lógica interna para EditarCliente.xaml
    /// </summary>
    public partial class EditarCliente : Window
    {
        Cliente cliente = new Cliente();
        public EditarCliente(Cliente cliente)
        {
            this.cliente = cliente;
            InitializeComponent();
            Mostrar();
        }

        private async void Mostrar()
        {
            ApiService apiService = new ApiService();
            List<Pedido> response = await apiService.GetPedidoByCliente(cliente.Id);
            Id.Text = cliente.Id.ToString();
            Nome.Text = cliente.Nome;
            Endereco.Text = cliente.Endereco;
            Telefone.Text = cliente.Telefone;
            pedidos.ItemsSource = response.OrderByDescending(p => p.Id);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            cliente.Nome = Nome.Text;
            cliente.Endereco = Endereco.Text;
            cliente.Telefone = Regex.Replace(Telefone.Text, @"[^\d]", "");
            ApiService apiService = new ApiService();
            var response = apiService.PutCliente(cliente);
            if (response)
            {
                MessageBox.Show("Cliente atualizado com sucesso!");
                this.Close();
            }

        }
    }
}
