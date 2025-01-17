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
    public class NegCliente
    {
        private readonly DadosConexao conexao;

        public NegCliente(DadosConexao conexao)
        {
            this.conexao = conexao;
        }

        private void ValidarModeloCliente(ModeloCliente modelo)
        {
            if (string.IsNullOrWhiteSpace(modelo.NomeCliente))
                throw new Exception("O nome do cliente não pode estar vazio. Por favor, informe um nome válido.");
            if (string.IsNullOrWhiteSpace(modelo.EnderecoCliente))
                throw new Exception("O endereço do cliente é obrigatório.");
            if (string.IsNullOrWhiteSpace(modelo.TelefoneCliente))
                throw new Exception("O telefone do cliente é obrigatório.");
            // Sugestão futura: Adicionar validações de comprimento máximo ou formato.
        }

        public void Incluir(ModeloCliente modelo)
        {
            ValidarModeloCliente(modelo);

            DCliente dCliente = new DCliente(conexao);
            dCliente.Incluir(modelo);

            // Certifique-se de que o DefinirID foi corrigido para atribuir o ID retornado pelo banco de dados.
            modelo.DefinirID(dCliente.ObterUltimoID());
        }

        public void Alterar(ModeloCliente modelo)
        {
            if (modelo.ID <= 0)
                throw new Exception("O código do cliente deve ser maior que zero para realizar alterações.");

            ValidarModeloCliente(modelo);

            DCliente dCliente = new DCliente(conexao);
            dCliente.Alterar(modelo);
        }

        public void Excluir(int ID)
        {
            if (ID <= 0)
                throw new Exception("O código do cliente deve ser maior que zero.");

            DCliente dCliente = new DCliente(conexao);
            dCliente.Excluir(ID);
        }

        public DataTable Localizar(string valor)
        {
            DCliente dCliente = new DCliente(conexao);
            return dCliente.Localizar(valor);
        }

        public ModeloCliente CarregarModeloCliente(int ID)
        {
            if (ID <= 0)
                throw new Exception("O código do cliente deve ser maior que zero.");

            DCliente dCliente = new DCliente(conexao);
            return dCliente.CarregarModeloCliente(ID);
        }

        public DataTable ObterClientes()
        {
            DCliente dadosCliente = new DCliente(conexao);
            return dadosCliente.CarregarClientes();
        }

        public int ObterUltimoID()
        {
            DCliente dadosCliente = new DCliente(conexao);
            return dadosCliente.ObterUltimoID();
        }

    }
}
