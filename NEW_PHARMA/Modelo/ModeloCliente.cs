using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloCliente
    {
        public ModeloCliente()
        {
            this.ClienteID = 0;
            this.Nome = "";
            this.NBI = "";
            this.Endereco = "";
            this.Telefone = "";
        }

        public ModeloCliente(int id, string nome, string nbi, string endereco, string telefone)
        {
            this.ClienteID = id;
            this.Nome = nome;
            this.NBI = nbi;
            this.Endereco = endereco;
            this.Telefone = telefone;
        }

        private int clienteID;
        public int ClienteID
        {
            get { return clienteID; }
            set { clienteID = value; }
        }

        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string nbi;
        public string NBI
        {
            get { return nbi; }
            set { nbi = value; }
        }

        private string endereco;
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        private string telefone;
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
    }
}

