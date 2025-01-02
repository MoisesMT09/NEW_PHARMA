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
            txtID.Clear();
            txtNome.Clear();
            txtNumBI.Clear();
            txtEndereco.Clear();
            txtTelefone.Clear();
        }


        public void AlterarBotoes(int op)
        {
            pnDados.Enabled = false;
            btnLocalizar.Enabled = false;
            btnInserir.Enabled = false;
            btnExcluir.Enabled = false;
            btnAlterar.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            if (op == 1)
            {
                btnInserir.Enabled = true;
                btnLocalizar.Enabled = true;
            }
            if (op == 2)
            {
                pnDados.Enabled = true;
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
            }
            if (op == 3)
            {
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
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

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            using (FormConsultarCliente ConsultarCliente = new FormConsultarCliente())
            {
                ConsultarCliente.ShowDialog();

                if (ConsultarCliente.ClienteID != 0)
                {
                    DadosConexao cox = new DadosConexao(DConexao.StringConexao);
                    NegCliente negCliente = new NegCliente(cox);
                    ModeloCliente modelo = negCliente.CarregarModeloCliente(ConsultarCliente.ClienteID);

                    txtID.Text = modelo.ClienteID.ToString();
                    txtNome.Text = modelo.NomeCliente;
                    txtNumBI.Text = modelo.NumBICliente;
                    txtEndereco.Text = modelo.EnderecoCliente;
                    txtTelefone.Text = modelo.TelefoneCliente;

                    AlterarBotoes(3); // Habilitar apenas os botões Alterar/Excluir
                }
                else
                {
                    LimpaTela();
                    AlterarBotoes(1); // Voltar ao estado inicial
                }
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                ModeloCliente modelo = new ModeloCliente
                {
                    NomeCliente = txtNome.Text,
                    NumBICliente = txtNumBI.Text,
                    EnderecoCliente = txtEndereco.Text,
                    TelefoneCliente = txtTelefone.Text
                };

                DadosConexao cox = new DadosConexao(DConexao.StringConexao);
                NegCliente negCliente = new NegCliente(cox);

                if (txtID.Text == "") // Novo cadastro
                {
                    negCliente.Incluir(modelo);
                    MessageBox.Show("Cliente cadastrado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // Alteração de cadastro
                {
                    modelo.ClienteID = Convert.ToInt32(txtID.Text);
                    negCliente.Alterar(modelo);
                    MessageBox.Show("Cadastro atualizado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LimpaTela();
                AlterarBotoes(1); // Voltar ao estado inicial
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja realmente excluir este cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(txtID.Text);
                    DadosConexao cox = new DadosConexao(DConexao.StringConexao);
                    NegCliente negCliente = new NegCliente(cox);
                    negCliente.Excluir(id);

                    MessageBox.Show("Cliente excluído com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpaTela();
                    AlterarBotoes(1); // Voltar ao estado inicial
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir cliente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            // Botão Alterar
            try
            {
                if (!string.IsNullOrWhiteSpace(txtID.Text))
                {
                    ModeloCliente modelo = new ModeloCliente
                    {
                        ClienteID = Convert.ToInt32(txtID.Text),
                        NomeCliente = txtNome.Text,
                        NumBICliente = txtNumBI.Text,
                        EnderecoCliente = txtEndereco.Text,
                        TelefoneCliente = txtTelefone.Text
                    };

                    DadosConexao cox = new DadosConexao(DConexao.StringConexao);
                    NegCliente negCliente = new NegCliente(cox);
                    negCliente.Alterar(modelo);

                    MessageBox.Show("Cadastro atualizado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpaTela();
                    AlterarBotoes(1); // Voltar ao estado inicial
                }
                else
                {
                    MessageBox.Show("Selecione um cliente para alterar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar cliente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

