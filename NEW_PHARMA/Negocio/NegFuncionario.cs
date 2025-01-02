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

            // Validação: Nome do Funcionário
            if (string.IsNullOrWhiteSpace(modelo.NomeFuncionario))
                throw new Exception("O nome do funcionário é obrigatório.");

            // Validação: Número do BI
            if (string.IsNullOrWhiteSpace(modelo.NumBI))
                throw new Exception("O número do BI é obrigatório.");

            // Validação: Email do Funcionário
            if (string.IsNullOrWhiteSpace(modelo.EmailFuncionario))
                throw new Exception("O e-mail do funcionário é obrigatório.");
            if (!modelo.EmailFuncionario.Contains("@") || !modelo.EmailFuncionario.Contains("."))
                throw new Exception("O e-mail do funcionário é inválido.");

            // Validação: Endereço do Funcionário
            if (string.IsNullOrWhiteSpace(modelo.EnderecoFuncionario))
                throw new Exception("O endereço do funcionário é obrigatório.");

            // Validação: Telefone do Funcionário
            if (string.IsNullOrWhiteSpace(modelo.TelefoneFuncionario))
                throw new Exception("O telefone do funcionário é obrigatório.");
            if (modelo.TelefoneFuncionario.Length < 9)
                throw new Exception("O telefone do funcionário deve ter ao menos 9 dígitos.");

            // Se todas as validações forem atendidas, chamar o método de inclusão na camada de dados
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
