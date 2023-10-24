using ConsumoWS.modelo;

namespace ConsumoWS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            Endereco endereco = controle.pesquisarCep(txbCep.Text);
            if (controle.mensagem.Equals(""))
            {
                txbLogradouro.Text = endereco.logradouro;
                txbBairro.Text = endereco.bairro;
                txbCidade.Text = endereco.cidade;
                txbCep.Text = endereco.cep;
            }
            else
            {
                MessageBox.Show(controle.mensagem);
                txbLogradouro.Text = "";
                txbBairro.Text = "";
                txbCidade.Text = "";
                txbCep.Text = "";
            }
        }
    }
}