using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoWS.modelo
{
    public class Controle
    {
        public String mensagem;

        public Endereco pesquisarCep(String cep)
        {
            this.mensagem = "";
            AtendeClienteClient atendeCliente = new AtendeClienteClient();
            Endereco endereco = new Endereco();
            try
            {
                Task<consultaCEPResponse> consulta =
                    atendeCliente.consultaCEPAsync(cep);
                endereco.logradouro = consulta.Result.@return.end;
                endereco.bairro = consulta.Result.@return.bairro;
                endereco.cidade = consulta.Result.@return.cidade;
                endereco.cep = consulta.Result.@return.cep;
            }
            catch (System.Exception e)
            {
                this.mensagem = "Erro";
            }
            return endereco;
        }
    }
}
