using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDPessoas.Modelo
{
    public class Validacao
    {
        public String mensagem;
        public int id;

        public void validarIdPessoa(String idPessoa)
        {
            this.mensagem = "";
            try
            {
                id = Convert.ToInt32(idPessoa);
            }
            catch (Exception e)
            {
                this.mensagem = "ID inválido";
            }
        }

        public void validarDadosPessoa(List<String> listaDadosPessoa)
        {
            this.mensagem = "";
            validarIdPessoa(listaDadosPessoa[0]);
            if (listaDadosPessoa[1].Length < 3)
                this.mensagem += "Nome deve ter mais que 3 caracteres\n";
            if (listaDadosPessoa[1].Length > 50)
                this.mensagem += "Nome deve ter menos que 50 caracteres\n";
            if (listaDadosPessoa[2].Length > 10)
                this.mensagem += "RG deve ter menos que 10 caracteres\n";
            if (listaDadosPessoa[3].Length > 13)
                this.mensagem += "CPF deve ter menos que 13 caracteres\n";
        }
    }
}
