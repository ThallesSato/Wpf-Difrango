using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using WPFDiFrango.Models;

namespace WPFDiFrango
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<DateTime,Pedido> horas = new Dictionary<DateTime, Pedido>();

        public MainWindow()
        {
            InitializeComponent();
            //Estoque();
            StartList();
            Refresh();
        }
        //private void estoque()
        //{
        //    string diretorioatual = appdomain.currentdomain.basedirectory;

        //    //nome da pasta que você deseja criar
        //    string nomedapasta = "estoque";

        //    //combina o diretório atual com o nome da pasta
        //    string caminhopasta = path.combine(diretorioatual, nomedapasta);

        //    //verifica se a pasta já existe antes de criá - la
        //    if (!directory.exists(caminhopasta))
        //    {
        //        directory.createdirectory(caminhopasta);
        //    }
        //    string caminhoarquivo = path.combine(caminhopasta, "estoque.txt");
        //    if (!file.exists(caminhoarquivo))
        //    {
        //        using (streamwriter writer = new streamwriter(caminhoarquivo))
        //        {
        //            writer.writeline("nome,quantidade");
        //        }
        //    }
        //    using (streamreader reader = new streamreader(caminhoarquivo))
        //    {

        //    }
        //}
        private void StartList()
        {
            horas.Clear();
            DateTime hora = DateTime.Today.AddHours(10).AddMinutes(30);
            for (int i = 0; i < 22; i++)
            {
                var pedido = new Pedido();
                pedido.DataHoraPedido = hora;
                horas.Add(hora, pedido);
                hora = hora.AddMinutes(10);
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private async void Refresh()
        {
                
            var apiService = new ApiService();
            try
            {
                var assadosResponse = await apiService.GetAssadosHoje();
                assados.ItemsSource = assadosResponse.OrderBy(d => d.DataHoraPedido).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Assado: Erro ao carregar dados: {ex.Message}");
            }
            try
            {
                StartList();
                var fritosResponse = await apiService.GetFritosHoje();
                foreach (var item in fritosResponse)
                {
                    if (horas.ContainsKey(item.DataHoraPedido))
                    {
                        horas[item.DataHoraPedido] = item;
                    }
                    else
                    {
                        horas.Add(item.DataHoraPedido, item);
                    }
                }
                var tess = horas.OrderBy(a=>a.Key).Select(a => a.Value).ToList();
                fritos.ItemsSource = tess;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Frito: Erro ao carregar dados: {ex.Message}");
            }
        }
        private void EditarButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.Tag is Pedido objetoDeDados)
            {
                var janelaDeEdicao = new JanelaDeEdicao(objetoDeDados);
                janelaDeEdicao.ShowDialog();
                Refresh();
            }
        }
        private void CancelarButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.Tag is Pedido objetoDeDados)
            {
                var confirmationDialog = new ConfirmationDialog("Deseja excluir o pedido do " + objetoDeDados.Cliente.Nome + "?");
                confirmationDialog.ShowDialog();
                bool? dialogResult = confirmationDialog.IsConfirmed;
                if (dialogResult.HasValue && dialogResult.Value)
                {
                    var apiService = new ApiService();
                    apiService.DeletePedido(objetoDeDados);
                    Refresh();
                }
            }
        }
        private void NovoPedido (object sender, RoutedEventArgs e)
        {
            NovoPedido novoPedido = new NovoPedido();

            double leftOffset = (SystemParameters.PrimaryScreenWidth - novoPedido.Width) / 2;
            double topOffset = (SystemParameters.PrimaryScreenHeight - novoPedido.Height) / 2;

            leftOffset -= 150;
            topOffset += 100;

            novoPedido.Left = leftOffset;
            novoPedido.Top = topOffset;

            novoPedido.ShowDialog();
            Refresh();
        }
        private void DataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            if (e.EditAction == DataGridEditAction.Commit)
            {
                var editedItem = e.Row.Item as Pedido; 

                if (e.Column.Header.Equals("Marcado") && editedItem != null)
                {
                    ApiService apiService = new ApiService();
                    apiService.MarcarPedido(editedItem);
                    Refresh();
                }
            }
        }
        private void Buscar_Cliente(object sender, RoutedEventArgs e)
        {
            var BuscarCliente = new BuscarCliente();
            BuscarCliente.ShowDialog();
        }
    }
}