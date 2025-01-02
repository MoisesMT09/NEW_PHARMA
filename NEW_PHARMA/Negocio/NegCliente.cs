using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Data;
using Modelo;
using Dados;

using System;
using System.Data;
using Dados;
using Modelo;

namespace Negocio
{
    public class NegCliente
    {
        private readonly DadosConexao conexao;

        public NegCliente(DadosConexao conexao)
        {
            this.conexao = conexao;
        }

        public void Incluir(ModeloCliente modelo)
        {
            if (string.IsNullOrWhiteSpace(modelo.NomeCliente))
                throw new Exception("O nome do cliente é obrigatório.");
            if (string.IsNullOrWhiteSpace(modelo.NumBICliente))
                throw new Exception("O número do BI é obrigatório.");
            if (string.IsNullOrWhiteSpace(modelo.EnderecoCliente))
                throw new Exception("O endereço do cliente é obrigatório.");
            if (string.IsNullOrWhiteSpace(modelo.TelefoneCliente))
                throw new Exception("O telefone do cliente é obrigatório.");

            DCliente dCliente = new DCliente(conexao);
            dCliente.Incluir(modelo);
        }

        public void Alterar(ModeloCliente modelo)
        {
            if (modelo.ClienteID <= 0)
                throw new Exception("O código do cliente é obrigatório.");
            if (string.IsNullOrWhiteSpace(modelo.NomeCliente))
                throw new Exception("O nome do cliente é obrigatório.");
            if (string.IsNullOrWhiteSpace(modelo.NumBICliente))
                throw new Exception("O número do BI é obrigatório.");
            if (string.IsNullOrWhiteSpace(modelo.EnderecoCliente))
                throw new Exception("O endereço do cliente é obrigatório.");
            if (string.IsNullOrWhiteSpace(modelo.TelefoneCliente))
                throw new Exception("O telefone do cliente é obrigatório.");

            DCliente dCliente = new DCliente(conexao);
            dCliente.Alterar(modelo);
        }

        public void Excluir(int id)
        {
            DCliente dCliente = new DCliente(conexao);
            dCliente.Excluir(id);
        }

        public DataTable Localizar(string valor)
        {
            DCliente dCliente = new DCliente(conexao);
            return dCliente.Localizar(valor);
        }

        public ModeloCliente CarregarModeloCliente(int id)
        {
            DCliente dCliente = new DCliente(conexao);
            return dCliente.CarregarModeloCliente(id);
        }
    }
}
