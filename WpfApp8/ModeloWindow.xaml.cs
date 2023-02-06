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

namespace WpfApp8
{
    /// <summary>
    /// Lógica interna para ModeloWindow.xaml
    /// </summary>
    public partial class ModeloWindow : Window
    {
        public ModeloWindow()
        {
            InitializeComponent();
        }

        private void InserirClick(object sender, RoutedEventArgs e)
        {
            // Novo objeto com os dados da turma que será inserida
            Modelo t = new Modelo();
            t.Id = int.Parse(txtId.Text);
            t.modelo = txtNome.Text;
            t.Preco = txtPreco.Text;
            // Lista a turma inserida
            ListarClick(sender, e);
        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listmodelos.ItemsSource = null;
            listmodelos.ItemsSource = NModelo.Listar();
        }

        private void AtualizarClick(object sender, RoutedEventArgs e)
        {
            // Novo objeto com os dados da turma que será inserida
            Modelo t = new Modelo();
            t.Id = int.Parse(txtId.Text);
            t.modelo = txtNome.Text;
            t.Preco = txtPreco.Text;
            // Lista as turmas cadastradas
            ListarClick(sender, e);
        }

        private void ExcluirClick(object sender, RoutedEventArgs e)
        {
            // Novo objeto com os dados da turma que será inserida
            Modelo t = new Modelo();
            t.Id = int.Parse(txtId.Text);
            // Inserir a turma na lista de turmas
            NModelo.Excluir(t);
            // Lista as turmas cadastradas
            ListarClick(sender, e);
        }

        private void listAlunos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listAlunos.SelectedItem != null)
            {
                Modelo obj = (Modelo)listModelos.SelectedItem;
                txtId.Text = obj.Id.ToString();
                txtmodelo.Text.Text = obj.Nome;
                txtMatricula.Text = obj.Matricula;
            }
        }
    }
}
