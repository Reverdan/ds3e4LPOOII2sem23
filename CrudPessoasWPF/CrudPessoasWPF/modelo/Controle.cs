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
                pessoa.nome = listaDadosPessoa[1];
                pessoa.rg = listaDadosPessoa[2];
                pessoa.cpf = listaDadosPessoa[3];
                PessoaDAO pessoaDAO = new PessoaDAO();
                pessoaDAO.cadastrarPessoa(pessoa);
                this.mensagem = pessoaDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }

        }

        public Pessoa pesquisaPessoaPorId(String idPessoa)
        {
            Validacao validacao = new Validacao();
            Pessoa pessoa = new Pessoa();
            validacao.validarIdPessoa(idPessoa);
            if (validacao.mensagem.Equals(""))
            {
                
                PessoaDAO pessoaDAO = new PessoaDAO();
                pessoa.idPessoa = validacao.id;
                pessoa = pessoaDAO.pesquisaPessoaPorId(pessoa);
                this.mensagem = pessoaDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
            return pessoa;
        }

        public List<Pessoa> pesquisaPessoaPorNome(String nome)
        {
            Pessoa pessoa = new Pessoa();
            List<Pessoa> listaPessoas = new List<Pessoa>();
            if (!nome.Equals(""))
            {
                PessoaDAO pessoaDAO = new PessoaDAO();
                pessoa.nome = nome;
                listaPessoas = pessoaDAO.pesquisaPessoaPorNome(pessoa);
                this.mensagem = pessoaDAO.mensagem;
            }
            else
            {
                this.mensagem = "Nome inválido";
            }
            return listaPessoas;
        }

        public void editarPessoa(List<String> listaDadosPessoa)
        {
            Validacao validacao = new Validacao();
            validacao.validarDadosPessoa(listaDadosPessoa);
            if (validacao.mensagem.Equals(""))
            {
                Pessoa pessoa = new Pessoa();
                pessoa.idPessoa = validacao.id;
                pessoa.nome = listaDadosPessoa[1];
                pessoa.rg = listaDadosPessoa[2];
                pessoa.cpf = listaDadosPessoa[3];
                PessoaDAO pessoaDAO = new PessoaDAO();
                pessoaDAO.editarPessoa(pessoa);
                this.mensagem = pessoaDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }

        }

        public void excluirPessoa(String idPessoa)
        {
            Validacao validacao = new Validacao();
            Pessoa pessoa = new Pessoa();
            validacao.validarIdPessoa(idPessoa);
            if (validacao.mensagem.Equals(""))
            {
                PessoaDAO pessoaDAO = new PessoaDAO();
                pessoa.idPessoa = validacao.id;
                pessoaDAO.excluirPessoa(pessoa);
                this.mensagem = pessoaDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }
    }
}
