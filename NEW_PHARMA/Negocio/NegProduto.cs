using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;
using Modelo;

namespace Negocio
{
    public class NegProduto
    {
        private DadosConexao conexao;

        public NegProduto(DadosConexao cox)
        {
            this.conexao = cox;
        }

        public void InserirProduto(ModeloProduto modelo)
        {
            if (modelo.NomeProduto.Trim().Length == 0)
            {
                throw new Exception("O nome do produto é obrigatório");
            }
            if (modelo.CategID <= 0)
            {
                throw new Exception("O código da categoria é obrigatório");
            }
            if (modelo.FornecID <= 0)
            {
                throw new Exception("O código do fornecedor é obrigatório");
            }
            if (modelo.PrecoProduto <= 0)
            {
                throw new Exception("O preço do produto deve ser maior que zero");
            }

            DProduto Dobj = new DProduto(conexao);
            Dobj.InserirProduto(modelo);
        }

        public void Alterar(ModeloProduto modelo)
        {
            if (modelo.ProdutoID <= 0)
            {
                throw new Exception("O código do produto é obrigatório");
            }
            if (modelo.NomeProduto.Trim().Length == 0)
            {
                throw new Exception("O nome do produto é obrigatório");
            }
            if (modelo.CategID <= 0)
            {
                throw new Exception("O código da categoria é obrigatório");
            }
            if (modelo.FornecID <= 0)
            {
                throw new Exception("O código do fornecedor é obrigatório");
            }
            if (modelo.PrecoProduto <= 0)
            {
                throw new Exception("O preço do produto deve ser maior que zero");
            }

            DProduto Dobj = new DProduto(conexao);
            Dobj.Alterar(modelo);
        }

        public void Excluir(int Codigo)
        {
            if (Codigo <= 0)
            {
                throw new Exception("O código do produto é obrigatório");
            }

            DProduto Dobj = new DProduto(conexao);
            Dobj.Excluir(Codigo);
        }

        public DataTable Localizar(string valor)
        {
            DProduto Dobj = new DProduto(conexao);
            return Dobj.Localizar(valor);
        }

        public ModeloProduto CarregaModeloProduto(int Codigo)
        {
            if (Codigo <= 0)
            {
                throw new Exception("O código do produto é obrigatório");
            }

            DProduto Dobj = new DProduto(conexao);
            return Dobj.CarregaModeloProduto(Codigo);
        }

    }
}

