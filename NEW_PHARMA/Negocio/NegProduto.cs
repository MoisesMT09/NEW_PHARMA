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

        // Mensagens padronizadas para validações
        private const string NomeObrigatorio = "O nome do produto é obrigatório.";
        private const string QuantidadeObrigatoria = "A quantidade é obrigatória.";
        private const string PrecoInvalido = "O preço do produto deve ser maior que zero.";
        private const string CategoriaInvalida = "A categoria informada não existe.";
        private const string FornecedorInvalido = "O fornecedor informado não existe.";
        private const string DataInvalida = "A data de validade é inválida.";

        private static readonly DateTime DataPadrao = new DateTime(2025, 1, 1);

        public void InserirProduto(ModeloProduto modelo)
        {
            ValidarProduto(modelo);

            DProduto Dobj = new DProduto(conexao);

            if (!Dobj.CategoriaExiste(modelo.CategID))
            {
                throw new Exception(CategoriaInvalida);
            }
            if (!Dobj.FornecedorExiste(modelo.FornecID))
            {
                throw new Exception(FornecedorInvalido);
            }

            Dobj.InserirProduto(modelo);
        }

        public string Alterar(ModeloProduto modelo)
        {
            try
            {
                ValidarProduto(modelo);

                DProduto Dobj = new DProduto(conexao);

                if (!Dobj.CategoriaExiste(modelo.CategID))
                {
                    throw new Exception(CategoriaInvalida);
                }
                if (!Dobj.FornecedorExiste(modelo.FornecID))
                {
                    throw new Exception(FornecedorInvalido);
                }

                Dobj.Alterar(modelo);
                return "Produto alterado com sucesso!";
            }
            catch (Exception ex)
            {
                return $"Erro ao alterar produto: {ex.Message}";
            }
        }

        public void Excluir(int codigo)
        {
            if (codigo <= 0)
            {
                throw new Exception("O código do produto é obrigatório.");
            }

            DProduto Dobj = new DProduto(conexao);

            var produto = Dobj.CarregaModeloProduto(codigo);
            if (produto == null)
            {
                throw new Exception("Produto não encontrado.");
            }

            Dobj.Excluir(codigo);
        }

        public DataTable Localizar(string valor)
        {
            DProduto Dobj = new DProduto(conexao);
            return Dobj.Localizar(valor);
        }

        public ModeloProduto CarregaModeloProduto(int id)
        {
            if (id <= 0)
            {
                throw new Exception("O código do produto é obrigatório.");
            }

            DProduto Dobj = new DProduto(conexao);
            var produto = Dobj.CarregaModeloProduto(id);
            if (produto == null)
            {
                throw new Exception("Produto não encontrado.");
            }

            return produto;
        }

        private void ValidarProduto(ModeloProduto modelo)
        {
            if (string.IsNullOrWhiteSpace(modelo.NomeProduto))
            {
                throw new Exception(NomeObrigatorio);
            }
            if (modelo.QuantEstProduto <= 0)
            {
                throw new Exception(QuantidadeObrigatoria);
            }
            if (modelo.PrecoProduto <= 0)
            {
                throw new Exception(PrecoInvalido);
            }
            if (modelo.CategID <= 0)
            {
                throw new Exception("O código da categoria é obrigatório.");
            }
            if (modelo.FornecID <= 0)
            {
                throw new Exception("O código do fornecedor é obrigatório.");
            }
            if (modelo.DataValida == DataPadrao)
            {
                throw new Exception(DataInvalida);
            }
        }
    }
}
    


   

