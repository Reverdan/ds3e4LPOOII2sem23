using CRUDPessoas.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDPessoas.DAL
{
    public class PessoaDAO
    {
        Conexao con = new Conexao();
        SqlDataReader dr;
        public string mensagem;

        public void cadastrarPessoa(Pessoa pessoa)
        {
            this.mensagem = "";
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = @"insert into pessoas (nome, rg, cpf) 
                            values (@nome, @rg, @cpf)";
            cmd.Parameters.AddWithValue("@nome", pessoa.nome);
            cmd.Parameters.AddWithValue("@rg", pessoa.rg);
            cmd.Parameters.AddWithValue("@cpf", pessoa.cpf);
            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                this.mensagem = "Pessoa cadastrada com sucesso!";
            }
            catch (Exception e)
            {
                this.mensagem = "Erro de BD";
            }
        }
    }
}
