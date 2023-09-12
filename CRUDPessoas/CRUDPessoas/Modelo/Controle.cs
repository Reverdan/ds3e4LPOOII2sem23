using CRUDPessoas.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDPessoas.Modelo
{
    public class Controle
    {
        public string mensagem;

        public void cadastrarPessoa(List<String> listaDadosPessoa)
        {
            Validacao validacao = new Validacao();
            validacao.validarDadosPessoa(listaDadosPessoa);
            if (validacao.mensagem.Equals(""))
            {
                Pessoa pessoa = new Pessoa();
                pessoa.nome = listaDadosPessoa[0];
                pessoa.rg = listaDadosPessoa[1];
                pessoa.cpf = listaDadosPessoa[2];
                PessoaDAO pessoaDAO = new PessoaDAO();
                pessoaDAO.cadastrarPessoa(pessoa);
                this.mensagem = pessoaDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }

        }
    }
}
