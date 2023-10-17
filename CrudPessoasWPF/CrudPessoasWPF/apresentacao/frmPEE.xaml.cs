using CRUDPessoas.Modelo;
using CrudPessoasWPF.modelo;
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
    /// Interaction logic for frmPEE.xaml
    /// </summary>
    public partial class frmPEE : Window
    {
        public frmPEE()
        {
            InitializeComponent();
        }

        private void btnPesquisarId_Click(object sender, RoutedEventArgs e)
        {
            Controle controle = new Controle();
            Pessoa pessoa = controle.pesquisaPessoaPorId(txbId.Text);
            if (controle.mensagem.Equals(""))
            {
                txbNome.Text = pessoa.nome;
                txbRg.Text = pessoa.rg;
                txbCpf.Text = pessoa.cpf;
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            Controle controle = new Controle();
            List<String> listaDadosPessoas = new List<string>();
            listaDadosPessoas.Add(txbId.Text);
            listaDadosPessoas.Add(txbNome.Text);
            listaDadosPessoas.Add(txbRg.Text);
            listaDadosPessoas.Add(txbCpf.Text);
            controle.editarPessoa(listaDadosPessoas);
            MessageBox.Show(controle.mensagem);

        }

        private void btnExcluir_Click(object sender, RoutedEventArgs e)
        {
            Controle controle = new Controle();
            MessageBoxResult resposta = MessageBox.Show("Deseja realmente excluir?",
                "Confirmação", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
            if (resposta == MessageBoxResult.OK)
            {
                controle.excluirPessoa(txbId.Text);
                MessageBox.Show(controle.mensagem);
            }
        }

        private void btnPesquisarNome_Click(object sender, RoutedEventArgs e)
        {
            Controle controle = new Controle();
            List<Pessoa> listaPessoas = controle.pesquisaPessoaPorNome(txbNome.Text);
            if (listaPessoas == null || listaPessoas.Count() == 0)
            {
                MessageBox.Show(controle.mensagem);
            }
            if (listaPessoas.Count() == 1)
            {
                txbId.Text = listaPessoas[0].idPessoa.ToString();
                txbNome.Text = listaPessoas[0].nome;
                txbRg.Text = listaPessoas[0].rg;
                txbCpf.Text = listaPessoas[0].cpf;
            }
            if (listaPessoas.Count() > 1)
            {
                Estaticos.listaPessoa = listaPessoas;
                frmSelecao frmS = new frmSelecao();
                frmS.ShowDialog();
                txbId.Text = Estaticos.pessoa.idPessoa.ToString();
                txbNome.Text = Estaticos.pessoa.nome;
                txbRg.Text = Estaticos.pessoa.rg;
                txbCpf.Text = Estaticos.pessoa.cpf;
            }
        }
    }
}
