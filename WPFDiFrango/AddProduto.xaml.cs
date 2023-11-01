using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    /// Lógica interna para AddProduto.xaml
    /// </summary>
    public partial class AddProduto : Window
    {
        List<string> Produtos = new List<string>();
        List<Produto> response = new List<Produto>();
        public Produto ProdutoSelecionado { get; private set; }

        public AddProduto()
        {
            InitializeComponent();
            MostrarProdutos();
            caixa.Focus();
        }

        private async void MostrarProdutos()
        {
            ApiService api = new ApiService();
            response = await api.GetProdutosAsync();
            foreach (Produto produto in response)
            {
                Produtos.Add(produto.Nome);
            }
            combo.ItemsSource = Produtos;
        }
                
        private void caixa_TextChanged(object sender, TextChangedEventArgs e)
        {
            string filtro = caixa.Text.ToLower();
            combo.ItemsSource = Produtos.Where(item => item.ToLower().Contains(filtro)).ToList();
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
                ProdutoSelecionado = response.FirstOrDefault(x => x.Nome == selec);
                Close();
            }
        }

        private void combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selec = combo.SelectedItem.ToString();
            ProdutoSelecionado = response.FirstOrDefault(x => x.Nome == selec);
            Close();
        }
    }
}
