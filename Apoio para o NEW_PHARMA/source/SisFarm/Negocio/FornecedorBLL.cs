using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocio
{
    public class FornecedorBLL
    {
        private FornecedorDAL fornecedorDAL = new FornecedorDAL();

        // Método para inserir um fornecedor
        public void InserirFornecedor(string nome, string telefone, string endereco, string nif)
        {
            // Validações antes de chamar o DAL
            if (string.IsNullOrWhiteSpace(nome)) throw new ArgumentException("O nome do fornecedor é obrigatório.");
            if (string.IsNullOrWhiteSpace(nif)) throw new ArgumentException("O NIF do fornecedor é obrigatório.");
            if (nif.Length != 20) throw new ArgumentException("O NIF deve ter 20 caracteres.");

            // Chama o DAL para inserção
            fornecedorDAL.InserirFornecedor(nome, telefone, endereco, nif);
        }

        // Método para listar todos os fornecedores
        public DataTable ListarFornecedores()
        {
            return fornecedorDAL.ListarFornecedores();
        }

        // Método para atualizar um fornecedor existente
        public void AtualizarFornecedor(int fornecedorId, string nome, string telefone, string endereco, string nif)
        {
            if (fornecedorId <= 0) throw new ArgumentException("ID inválido.");
            if (string.IsNullOrWhiteSpace(nome)) throw new ArgumentException("O nome do fornecedor é obrigatório.");
            if (string.IsNullOrWhiteSpace(nif)) throw new ArgumentException("O NIF do fornecedor é obrigatório.");
            if (nif.Length != 20) throw new ArgumentException("O NIF deve ter 20 caracteres.");

            fornecedorDAL.AtualizarFornecedor(fornecedorId, nome, telefone, endereco, nif);
        }

        // Método para deletar um fornecedor
        public void DeletarFornecedor(int fornecedorId)
        {
            if (fornecedorId <= 0) throw new ArgumentException("ID inválido.");
            fornecedorDAL.DeletarFornecedor(fornecedorId);
        }

        // Método para buscar fornecedor por nome
        public DataTable BuscarFornecedorPorNome(string nome)
        {
            return fornecedorDAL.BuscarFornecedorPorNome(nome);
        }

        // Método para buscar fornecedor por NIF
        public DataTable BuscarFornecedorPorNIF(string nif)
        {
            return fornecedorDAL.BuscarFornecedorPorNIF(nif);
        }
    }
}
