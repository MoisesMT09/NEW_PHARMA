using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Data;
using Modelo;
using Dados;

namespace Negocio
{
    public class NegCliente
    {
        private DadosConexao conexao;

        public NegCliente(DadosConexao cox)
        {
            this.conexao = cox;
        }

        public void Incluir(ModeloCliente modelo)
        {
            if (string.IsNullOrWhiteSpace(modelo.Nome))
                throw new Exception("O nome do cliente é obrigatório.");
            if (string.IsNullOrWhiteSpace(modelo.NBI))
                throw new Exception("O número do BI é obrigatório.");
            if (string.IsNullOrWhiteSpace(modelo.Endereco))
                throw new Exception("O endereço é obrigatório.");
            if (string.IsNullOrWhiteSpace(modelo.Telefone))
                throw new Exception("O telefone é obrigatório.");

            DCliente Dobj = new DCliente(conexao);
            Dobj.Incluir(modelo);
        }

        public void Alterar(ModeloCliente modelo)
        {
            if (modelo.ClienteID <= 0)
                throw new Exception("O código do cliente é obrigatório.");
            if (string.IsNullOrWhiteSpace(modelo.Nome))
                throw new Exception("O nome do cliente é obrigatório.");
            if (string.IsNullOrWhiteSpace(modelo.NBI))
                throw new Exception("O número do BI é obrigatório.");
            if (string.IsNullOrWhiteSpace(modelo.Endereco))
                throw new Exception("O endereço é obrigatório.");
            if (string.IsNullOrWhiteSpace(modelo.Telefone))
                throw new Exception("O telefone é obrigatório.");

            DCliente Dobj = new DCliente(conexao);
            Dobj.Alterar(modelo);
        }

        public void Excluir(int id)
        {
            if (id <= 0)
                throw new Exception("O código do cliente é obrigatório.");

            DCliente Dobj = new DCliente(conexao);
            Dobj.Excluir(id);
        }

        public DataTable Localizar(string valor)
        {
            DCliente Dobj = new DCliente(conexao);
            return Dobj.Localizar(valor);
        }

        public ModeloCliente CarregaModeloCliente(int id)
        {
            DCliente Dobj = new DCliente(conexao);
            return Dobj.CarregaModeloCliente(id);
        }
    }
}
