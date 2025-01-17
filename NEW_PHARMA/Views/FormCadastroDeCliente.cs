using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dados;
using Modelo;
using Negocio;

namespace Views
{
    public partial class FormCadastroDeCliente : Form
    {
        public FormCadastroDeCliente()
        {
            InitializeComponent();
        }

        private void LimpaTela()
        {
            txtNome.Clear();
            txtEndereco.Clear();
            txtTelefone.Clear();
        }


        public void AlterarBotoes(int op)
        {
            pnDados.Enabled = false;
            btnInserir.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            if (op == 1)
            {
                btnInserir.Enabled = true;
            }
            if (op == 2)
            {
                pnDados.Enabled = true;
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
            }
            if (op == 3)
            {
                btnCancelar.Enabled = true;
            }
        }
        private void FormCadastroDeCliente_Load(object sender, EventArgs e)
        {
            AlterarBotoes(1); // Estado inicial

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            // Botão Incluir
            LimpaTela();
            AlterarBotoes(2); // Liberar botões de preenchimento e salvar/cancelar
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                // Criar modelo e preencher os dados do formulário
                ModeloCliente modelo = new ModeloCliente
                {
                    NomeCliente = txtNome.Text,
                    EnderecoCliente = txtEndereco.Text,
                    TelefoneCliente = txtTelefone.Text
                };

                // Instanciar classes de conexão e negócio
                DadosConexao cox = new DadosConexao(DConexao.StringConexao);
                NegCliente negCliente = new NegCliente(cox);

                // Chamar o método de inclusão da camada de negócio
                negCliente.Incluir(modelo);

                MessageBox.Show("Cliente cadastrado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpar tela e voltar ao estado inicial
                LimpaTela();
                AlterarBotoes(1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar cliente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaTela();
            AlterarBotoes(1); // Voltar ao estado inicial
        }

        private void pbVoltar_Click(object sender, EventArgs e)
        {
            FormTelaDeApresentacao telaApresentacao = new FormTelaDeApresentacao();
            telaApresentacao.Show();
            this.Close(); // Fecha o formulário atual
        }

    }
}

