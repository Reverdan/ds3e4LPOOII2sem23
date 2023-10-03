using CRUDPessoas.Modelo;
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

namespace CrudPessoasWPF.apresentacao
{
    /// <summary>
    /// Interaction logic for frmCadastrar.xaml
    /// </summary>
    public partial class frmCadastrar : Window
    {
        public frmCadastrar()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            Controle controle = new Controle();
            List<String> listaDadosPessoa = new List<string>();
            listaDadosPessoa.Add("0");
            listaDadosPessoa.Add(txbNome.Text);
            listaDadosPessoa.Add(txbRg.Text);
            listaDadosPessoa.Add(txbCpf.Text);
            controle.cadastrarPessoa(listaDadosPessoa);
            MessageBox.Show(controle.mensagem);
        }
    }
}
