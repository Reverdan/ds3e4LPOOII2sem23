using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUDPessoas.Modelo;

namespace CRUDPessoas.Apresentacao
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            List<string> listaDadosPessoa = new List<string>();
            listaDadosPessoa.Add(txbNome.Text);
            listaDadosPessoa.Add(txbRg.Text);
            listaDadosPessoa.Add(txbCpf.Text);
            Controle controle = new Controle();
            controle.cadastrarPessoa(listaDadosPessoa);
            MessageBox.Show(controle.mensagem);
        }
    }
}
