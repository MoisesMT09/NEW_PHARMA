using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloCliente
    {
        /// <summary>
        /// Construtor padrão que inicializa os valores padrão do cliente.
        /// </summary>
        public ModeloCliente()
        {
            this.ID = 0;
            this.NomeCliente = string.Empty;
            this.EnderecoCliente = string.Empty;
            this.TelefoneCliente = string.Empty;
        }

        /// <summary>
        /// Construtor com parâmetros para inicializar o cliente com valores fornecidos.
        /// </summary>
        /// <param name="clienteID">Identificador único do cliente.</param>
        /// <param name="nomeCliente">Nome completo do cliente.</param>
        /// <param name="enderecoCliente">Endereço do cliente.</param>
        /// <param name="telefoneCliente">Telefone de contato do cliente.</param>
        public ModeloCliente(int clienteID, string nomeCliente, string enderecoCliente, string telefoneCliente)
        {
            this.ID = clienteID;
            this.NomeCliente = nomeCliente;
            this.EnderecoCliente = enderecoCliente;
            this.TelefoneCliente = telefoneCliente;
        }

        /// <summary>
        /// Identificador único do cliente (gerado pelo banco de dados).
        /// </summary>
        public int ID { get; private set; }

        /// <summary>
        /// Nome completo do cliente.
        /// </summary>
        public string NomeCliente { get; set; } = string.Empty;

        /// <summary>
        /// Endereço do cliente (opcional).
        /// </summary>
        public string EnderecoCliente { get; set; } = string.Empty;

        /// <summary>
        /// Telefone de contato do cliente.
        /// </summary>
        public string TelefoneCliente { get; set; } = string.Empty;

        /// <summary>
        /// Define o ID do cliente, permitindo sua atribuição após a criação do objeto.
        /// </summary>
        /// <param name="id">O ID gerado pelo banco de dados.</param>
        public void DefinirID(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("O ID deve ser maior que zero.");
            }

            this.ID = id;
        }


    }
}
