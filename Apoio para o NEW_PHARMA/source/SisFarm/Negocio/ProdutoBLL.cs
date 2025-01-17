using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocio
{
    public class ProdutoBLL
    {
        private ProdutoDAL produtoDAL = new ProdutoDAL();

        // Método para inserir um produto
        public void InserirProduto(string nome, int categoriaId, string descricao, decimal preco, DateTime dataValidade, int quantidade, string status, int fornecedorId)
        {
            // Validações antes de chamar o DAL
            if (string.IsNullOrWhiteSpace(nome)) throw new ArgumentException("O nome do produto é obrigatório.");
            if (preco <= 0) throw new ArgumentException("O preço deve ser maior que zero.");
            if (quantidade < 0) throw new ArgumentException("A quantidade não pode ser negativa.");
            if (string.IsNullOrWhiteSpace(status)) throw new ArgumentException("O status do produto é obrigatório.");
            if (fornecedorId <= 0) throw new ArgumentException("Fornecedor inválido.");

            // Chama o DAL para inserção
            produtoDAL.InserirProduto(nome, categoriaId, descricao, preco, dataValidade, quantidade, status, fornecedorId);
        }
        public DataTable BuscarProdutoPorID(int produtoId)
        {
            return produtoDAL.BuscarProdutoPorID(produtoId);
        }

        // Método para listar todos os produtos
        public DataTable ListarProdutos()
        {
            return produtoDAL.ListarProdutos();
        }

        // Método para atualizar um produto existente
        public void AtualizarProduto(int id, string nome, int categoriaId, string descricao, decimal preco, DateTime prazo, int estoque, string status, int fornecedorId)
        {
            if (id <= 0) throw new ArgumentException("ID inválido.");
            if (string.IsNullOrWhiteSpace(nome)) throw new ArgumentException("O nome do produto é obrigatório.");
            if (preco <= 0) throw new ArgumentException("O preço deve ser maior que zero.");
            if (estoque < 0) throw new ArgumentException("O estoque não pode ser negativo.");
            if (string.IsNullOrWhiteSpace(status)) throw new ArgumentException("O status do produto é obrigatório.");
            if (fornecedorId <= 0) throw new ArgumentException("Fornecedor inválido.");

            produtoDAL.AtualizarProduto(id, nome, categoriaId, descricao, preco, prazo, estoque, status, fornecedorId);
        }

        // Método para deletar um produto
        public void DeletarProduto(int id)
        {
            if (id <= 0) throw new ArgumentException("ID inválido.");
            produtoDAL.DeletarProduto(id);
        }

        // Métodos para realizar as diferentes buscas.

        // Buscar por nome
        public DataTable BuscarPorNome(string nome)
        {
            return produtoDAL.BuscarPorNome(nome);
        }

        // Buscar por status (ativo ou inativo)
        public DataTable BuscarPorStatus(string status)
        {
            return produtoDAL.BuscarPorStatus(status);
        }

        // Buscar por estoque (Em estoque, Sem estoque, Estoque baixo)
        public DataTable BuscarPorEstoque(string tipoEstoque)
        {
            return produtoDAL.BuscarPorEstoque(tipoEstoque);
        }

        // Buscar por categoria
        public DataTable BuscarPorCategoria(int categoriaId)
        {
            return produtoDAL.BuscarPorCategoria(categoriaId);
        }

        // Buscar produtos por Fornecedor
        public DataTable BuscarPorFornecedor(int fornecedorId)
        {
            if (fornecedorId <= 0) throw new ArgumentException("Fornecedor inválido.");
            return produtoDAL.BuscarPorFornecedor(fornecedorId);
        }

    }

}
