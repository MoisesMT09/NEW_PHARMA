using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloFuncionario
    {
        public ModeloFuncionario()
        {
            this.FuncionarioID = 0;
            this.NomeFuncionario = "";
            this.NumBI = "";
            this.EmailFuncionario = "";
            this.EnderecoFuncionario = "";
            this.TelefoneFuncionario = "";
        }

        public ModeloFuncionario(int id, string nome, string n_bi, string email, string endereco, string telefone)
        {
            this.FuncionarioID = id;
            this.NomeFuncionario = nome;
            this.NumBI = n_bi;
            this.EmailFuncionario = email;
            this.EnderecoFuncionario = endereco;
            this.TelefoneFuncionario = telefone;
        }

        private int id;
        public int FuncionarioID
        {
            get { return id; }
            set { id = value; }
        }

        private string nome;
        public string NomeFuncionario
        {
            get { return nome; }
            set { nome = value; }
        }

        private string n_bi;
        public string NumBI
        {
            get { return n_bi; }
            set { n_bi = value; }
        }

        private string email;
        public string EmailFuncionario
        {
            get { return email; }
            set { email = value; }
        }

        private string endereco;
        public string EnderecoFuncionario
        {
            get { return endereco; }
            set { endereco = value; }
        }

        private string telefone;
        public string TelefoneFuncionario
        {
            get { return telefone; }
            set { telefone = value; }
        }
    }
}
