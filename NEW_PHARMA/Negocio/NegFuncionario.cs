using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modelo;
using Dados;

namespace Negocio
{
    public class NegFuncionario
    {
        private DadosConexao conexao;

        public NegFuncionario(DadosConexao cox)
        {
            this.conexao = cox;
        }

        public void Incluir(ModeloFuncionario modelo)
        {
            if (modelo.NomeFuncionario.Trim().Length == 0)
                throw new Exception("O nome do funcionário é obrigatório.");
            if (modelo.NumBI.Trim().Length == 0)
                throw new Exception("O número do BI é obrigatório.");
            if (modelo.EmailFuncionario.Trim().Length == 0)
                throw new Exception("O e-mail do funcionário é obrigatório.");
            if (modelo.EnderecoFuncionario.Trim().Length == 0)
                throw new Exception("O endereço do funcionário é obrigatório.");
            if (modelo.TelefoneFuncionario.Trim().Length == 0)
                throw new Exception("O telefone do funcionário é obrigatório.");

            DFuncionario Dobj = new DFuncionario(conexao);
            Dobj.Incluir(modelo);
        }

        public void Alterar(ModeloFuncionario modelo)
        {
            if (modelo.FuncionarioID <= 0)
                throw new Exception("O código do funcionário é obrigatório.");
            if (modelo.NomeFuncionario.Trim().Length == 0)
                throw new Exception("O nome do funcionário é obrigatório.");

            DFuncionario Dobj = new DFuncionario(conexao);
            Dobj.Alterar(modelo);
        }

        public void Excluir(int id)
        {
            if (id <= 0)
                throw new Exception("O código do funcionário é obrigatório.");

            DFuncionario Dobj = new DFuncionario(conexao);
            Dobj.Excluir(id);
        }

        public DataTable Localizar(string valor)
        {
            DFuncionario Dobj = new DFuncionario(conexao);
            return Dobj.Localizar(valor);
        }

        public ModeloFuncionario CarregaModeloFuncionario(int id)
        {
            DFuncionario Dobj = new DFuncionario(conexao);
            return Dobj.CarregaModeloFuncionario(id);
        }
    }
}
