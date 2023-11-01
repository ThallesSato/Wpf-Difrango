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
    /// Lógica interna para BuscarCliente.xaml
    /// </summary>
    public partial class BuscarCliente : Window
    {
        List<Cliente> response = new List<Cliente>();
        public BuscarCliente()
        {
            InitializeComponent();
            combo.ItemsSource = response;
            caixa.Focus();
        }

        private async void Mostrar(string telefone)
        {
            ApiService api = new ApiService();
            response = await api.GetClienteByTelefoneOrNome(telefone);
            if (response != null)
            {
                combo.ItemsSource = response.Select(c => c.ToString);
                combo.Visibility = Visibility.Visible;
            }
            else
            {
                combo.Visibility = Visibility.Hidden;
            }
        }

        private void caixa_TextChanged(object sender, TextChangedEventArgs e)
        {
            string telefone = Regex.Replace(caixa.Text.ToLower(), @"[^\d]", "");
            if (telefone.Length > 1 && telefone.Length % 2 == 0)
            {
                Mostrar(telefone);
            }
            else if(telefone.Length < 2 && telefone.Length > 0)
            {
                combo.ItemsSource = null;
                combo.Visibility = Visibility.Hidden;
            }

        }

        private void TextEnter(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                combo.SelectedItem = combo.Items.GetItemAt(0);
                combo.Focus();
            }
        }
        private void ListEnter(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                var selec = combo.SelectedItem.ToString();
                selec = selec[..11];
                var cliente = response.Find(c => c.Telefone == selec);
                EditarCliente edit = new EditarCliente(cliente);
                edit.Show();

            }
        }

        private void combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selec = combo.SelectedItem.ToString();
            selec = selec[..11];
            var cliente = response.Find(c => c.Telefone == selec);
            EditarCliente edit = new EditarCliente(cliente);
            edit.Show();
        }
    }
}
