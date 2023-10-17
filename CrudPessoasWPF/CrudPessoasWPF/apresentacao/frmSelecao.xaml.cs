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
    /// Interaction logic for frmSelecao.xaml
    /// </summary>
    public partial class frmSelecao : Window
    {
        public frmSelecao()
        {
            InitializeComponent();
            inicializarDataGrid();
        }

        private void inicializarDataGrid()
        {
            dgvPessoas.Columns.Clear();
            dgvPessoas.AutoGenerateColumns = false;
            dgvPessoas.Columns.Add(new DataGridTextColumn()
                { Header = "ID", Binding = new Binding("idPessoa") });
            dgvPessoas.Columns.Add(new DataGridTextColumn()
                { Header = "Nome", Binding = new Binding("nome") });
            dgvPessoas.Columns.Add(new DataGridTextColumn()
                { Header = "RG", Binding = new Binding("rg") });
            dgvPessoas.Columns.Add(new DataGridTextColumn()
                { Header = "CPF", Binding = new Binding("cpf") });

            foreach(Pessoa p in Estaticos.listaPessoa)
            {
                var item = new { idPessoa = p.idPessoa, nome = p.nome, rg = p.rg, cpf = p.cpf };
                dgvPessoas.Items.Add(item);
            }
        }

        private void btnPesquisar_Click(object sender, RoutedEventArgs e)
        {
            if (dgvPessoas.SelectedIndex >= 0)
            {
                var item = dgvPessoas.SelectedItem;
                Estaticos.pessoa.idPessoa = Convert.ToInt32
                    ((dgvPessoas.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text);
                Estaticos.pessoa.nome = 
                    (dgvPessoas.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                Estaticos.pessoa.rg = 
                    (dgvPessoas.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
                Estaticos.pessoa.cpf = 
                    (dgvPessoas.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecione uma pessoa");
            }
        }
    }
}
