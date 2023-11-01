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

namespace WPFDiFrango
{
    /// <summary>
    /// Lógica interna para ConfirmationDialog.xaml
    /// </summary>
    public partial class ConfirmationDialog : Window
    {
        public bool IsConfirmed { get; private set; } = false;

        public ConfirmationDialog(string message)
        {
            InitializeComponent();
            MostrarMensagem(message);
        }

        private void MostrarMensagem(string message)
        {
            Mensagem.Content = message;
        }

        private void Confirmar_Click(object sender, RoutedEventArgs e)
        {
            IsConfirmed = true;
            Close();
        }

        private void Cancelar_Click(object sender, RoutedEventArgs e)
        {
            IsConfirmed = false;
            Close();
        }
    }
}
