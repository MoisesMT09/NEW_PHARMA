using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocio
{
    public class VendaBLL
    {
        private VendaDAL vendaDAL = new VendaDAL();

        // Método para registrar uma venda
        public int RegistrarVenda(int clienteId, decimal total, string status)
        {
            if (clienteId <= 0) throw new ArgumentException("ID do cliente inválido.");
            if (total < 0) throw new ArgumentException("O total da venda não pode ser negativo.");
            if (string.IsNullOrWhiteSpace(status)) throw new ArgumentException("O status da venda é obrigatório.");

            // Chama o método DAL para registrar a venda
            return vendaDAL.RegistrarVenda(clienteId, total, status);
        }


        // Método para registrar detalhes de uma venda
        public void RegistrarDetalhesVenda(int vendaId, int produtoId, int quantidade, decimal precoUnitario, decimal totalItem)
        {
            if (vendaId <= 0) throw new ArgumentException("ID da venda inválido.");
            if (produtoId <= 0) throw new ArgumentException("ID do produto inválido.");
            if (quantidade <= 0) throw new ArgumentException("A quantidade deve ser maior que zero.");
            if (precoUnitario <= 0) throw new ArgumentException("O preço unitário deve ser maior que zero.");
            if (totalItem < 0) throw new ArgumentException("O total do item não pode ser negativo.");

            // Chama o DAL para registrar os detalhes da venda
            vendaDAL.RegistrarDetalhesVenda(vendaId, produtoId, quantidade, precoUnitario, totalItem);
        }


        // Método para listar todas as vendas
        public DataTable ListarVendas()
        {
            return vendaDAL.ListarVendas();
        }

        // Método para listar detalhes de uma venda
        public DataTable ListarDetalhesVenda(int vendaId)
        {
            if (vendaId <= 0) throw new ArgumentException("ID da venda inválido.");
            return vendaDAL.ListarDetalhesVenda(vendaId);
        }

        // Método para buscar vendas por cliente
        public DataTable BuscarVendasPorCliente(int clienteId)
        {
            if (clienteId <= 0) throw new ArgumentException("ID do cliente inválido.");
            return vendaDAL.BuscarVendasPorCliente(clienteId);
        }
    }
}
