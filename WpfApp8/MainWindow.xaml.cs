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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp8
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Veiculo_Click(object sender, RoutedEventArgs e)
        {
            VeiculoWindow w = new VeiculoWindow();
            w.ShowDialog();
        }

        private void Modelo_Click(object sender, RoutedEventArgs e)
        {
            ModeloWindow w = new ModeloWindow();
            w.ShowDialog();
        }

        private void Cadastro_Click(object sender, RoutedEventArgs e)
        {
            Cadastro_Modelo_No_Veículo w = new Cadastro_Modelo_No_Veículo();
            w.ShowDialog();
        }

        private void Registrados_Click(object sender, RoutedEventArgs e)
        {
            Registrados w = new Registrados();
            w.ShowDialog();
        }
    }
}
