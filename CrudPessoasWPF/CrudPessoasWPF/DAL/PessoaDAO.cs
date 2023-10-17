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

        public Pessoa pesquisaPessoaPorId(Pessoa pessoa)
        {
            this.mensagem = "";
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader dr;
            cmd.CommandText = @"select * from pessoas where idPessoa = @id";
            cmd.Parameters.AddWithValue("@id", pessoa.idPessoa);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    pessoa.nome = dr["nome"].ToString();
                    pessoa.rg = dr["rg"].ToString();
                    pessoa.cpf = dr["cpf"].ToString();
                    dr.Close();
                }
                else
                {
                    this.mensagem = "Não existe este ID";
                }

            }
            catch (Exception e)
            {
                this.mensagem = "Erro de BD";
            }
            finally
            {
                con.desconectar();
            }
            return pessoa;
        }

        public List<Pessoa> pesquisaPessoaPorNome(Pessoa pessoa)
        {
            this.mensagem = "";
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader dr;
            List<Pessoa> listaPessoas = new List<Pessoa>();
            cmd.CommandText = @"select * from pessoas 
                    where nome like @nome";
            cmd.Parameters.AddWithValue("@nome", pessoa.nome + "%");
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Pessoa p = new Pessoa();
                        p.idPessoa = Convert.ToInt32(dr["idPessoa".ToString()]);
                        p.nome = dr["nome"].ToString();
                        p.rg = dr["rg"].ToString();
                        p.cpf = dr["cpf"].ToString();
                        listaPessoas.Add(p);
                    }
                    dr.Close();
                }
                else
                {
                    this.mensagem = "Não existe este Nome";
                }

            }
            catch (Exception e)
            {
                this.mensagem = "Erro de BD";
            }
            finally
            {
                con.desconectar();
            }
            return listaPessoas;
        }

        public void editarPessoa(Pessoa pessoa)
        {
            this.mensagem = "";
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = @"update pessoas set nome = @nome, 
                                rg = @rg, cpf = @cpf 
                                where idPessoa = @id";
            cmd.Parameters.AddWithValue("@nome", pessoa.nome);
            cmd.Parameters.AddWithValue("@rg", pessoa.rg);
            cmd.Parameters.AddWithValue("@cpf", pessoa.cpf);
            cmd.Parameters.AddWithValue("@id", pessoa.idPessoa);
            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                this.mensagem = "Pessoa editada com sucesso!";
            }
            catch (Exception e)
            {
                this.mensagem = "Erro de BD";
            }
        }

        public void excluirPessoa(Pessoa pessoa)
        {
            this.mensagem = "";
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = @"delete from pessoas 
                                where idPessoa = @id";
            cmd.Parameters.AddWithValue("@id", pessoa.idPessoa);
            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                this.mensagem = "Pessoa excluída com sucesso!";
            }
            catch (Exception e)
            {
                this.mensagem = "Erro de BD";
            }
        }
    }
}
