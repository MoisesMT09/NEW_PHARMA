using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;
using Dados;

namespace Negocio
{
    public class NegFornecedor
    {
        private DadosConexao conexao;

        public NegFornecedor(DadosConexao conexao)
        {
            this.conexao = conexao;
        }

        public void Incluir(ModeloFornecedor modelo)
        {
            if (string.IsNullOrWhiteSpace(modelo.NomeFornecedor))
            {
                throw new Exception("O nome do fornecedor é obrigatório.");
            }
            if (string.IsNullOrWhiteSpace(modelo.NIFFornecedor))
            {
                throw new Exception("O NIF do fornecedor é obrigatório.");
            }
            if (string.IsNullOrWhiteSpace(modelo.EnderecoFornecedor))
            {
                throw new Exception("O endereço do fornecedor é obrigatório.");
            }
            if (string.IsNullOrWhiteSpace(modelo.TelefoneFornecedor))
            {
                throw new Exception("O telefone do fornecedor é obrigatório.");
            }
            if (string.IsNullOrWhiteSpace(modelo.EmailFornecedor))
            {
                throw new Exception("O e-mail do fornecedor é obrigatório.");
            }

            DFornecedor dFornecedor = new DFornecedor(conexao);
            dFornecedor.Incluir(modelo);
        }

        public void Alterar(ModeloFornecedor modelo)
        {
            if (modelo.FornecedorID <= 0)
            {
                throw new Exception("O código do fornecedor é obrigatório.");
            }
            Incluir(modelo); // Valida os dados usando as mesmas regras do método Incluir

            DFornecedor dFornecedor = new DFornecedor(conexao);
            dFornecedor.Alterar(modelo);
        }

        public void Excluir(int id)
        {
            if (id <= 0)
            {
                throw new Exception("O código do fornecedor é obrigatório.");
            }

            DFornecedor dFornecedor = new DFornecedor(conexao);
            dFornecedor.Excluir(id);
        }

        public DataTable Localizar(string valor)
        {
            DFornecedor dFornecedor = new DFornecedor(conexao);
            return dFornecedor.Localizar(valor);
        }

        public ModeloFornecedor CarregaModeloFornecedor(int id)
        {
            if (id <= 0)
            {
                throw new Exception("O código do fornecedor é obrigatório.");
            }

            DFornecedor dFornecedor = new DFornecedor(conexao);
            return dFornecedor.CarregaModeloFornecedor(id);
        }
    }
}

