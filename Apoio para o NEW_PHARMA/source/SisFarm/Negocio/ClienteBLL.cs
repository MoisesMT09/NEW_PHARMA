using Dados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ClienteBLL
    {
        ClienteDALL clienteDAL = new ClienteDALL();

        public void InserirCliente(string nome, string telefone, string endereco)
        {
            clienteDAL.InserirCliente(nome, telefone, endereco);
        }

        public DataTable ListarClientes()
        {
            return clienteDAL.ListarClientes();
        }

        public void AtualizarCliente(int clienteId, string nome, string telefone, string endereco)
        {
            clienteDAL.AtualizarCliente(clienteId, nome, telefone, endereco);
        }

        public void DeletarCliente(int clienteId)
        {
            clienteDAL.DeletarCliente(clienteId);
        }
    }
}
