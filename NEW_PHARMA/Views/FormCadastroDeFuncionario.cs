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
    public partial class FormCadastroDeFuncionario : Form
    {
        public FormCadastroDeFuncionario()
        {
            InitializeComponent();
        }

        private void LimpaTela()
        {
            // Método para limpar os campos da tela
            txtID.Clear();
            txtNome.Clear();
            txtNBI.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtTelefone.Clear();
        }

        public String Operacao;

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


        private void FormCadastroDeFuncionario_Load(object sender, EventArgs e)
        {
            AlterarBotoes(1); // Estado inicial
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.Operacao = "INSERIR";
            this.AlterarBotoes(2);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            try
            {
                ModeloFuncionario modelo = new ModeloFuncionario
                {
                    FuncionarioID = Convert.ToInt32(txtID.Text),
                    NomeFuncionario = txtNome.Text,
                    NumBI = txtNBI.Text,
                    EmailFuncionario = txtEmail.Text,
                    EnderecoFuncionario = txtEndereco.Text,
                    TelefoneFuncionario = txtTelefone.Text
                };

                DadosConexao conexao = new DadosConexao(DConexao.StringConexao);
                NegFuncionario negocio = new NegFuncionario(conexao);

                negocio.Alterar(modelo);

                MessageBox.Show("Cadastro alterado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpaTela();
                AlterarBotoes(1); // Estado inicial
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar funcionário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(txtID.Text);

                DialogResult confirmacao = MessageBox.Show("Deseja realmente excluir este funcionário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacao == DialogResult.Yes)
                {
                    DadosConexao conexao = new DadosConexao(DConexao.StringConexao);
                    NegFuncionario negocio = new NegFuncionario(conexao);

                    negocio.Excluir(codigo);

                    MessageBox.Show("Funcionário excluído com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpaTela();
                    AlterarBotoes(1); // Estado inicial
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir funcionário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                FormConsultarFuncionario consultarFuncionario = new FormConsultarFuncionario();
                consultarFuncionario.ShowDialog();

                if (consultarFuncionario.Codigo != 0)
                {
                    DadosConexao conexao = new DadosConexao(DConexao.StringConexao);
                    NegFuncionario negocio = new NegFuncionario(conexao);

                    ModeloFuncionario modelo = negocio.CarregaModeloFuncionario(consultarFuncionario.Codigo);

                    txtID.Text = modelo.FuncionarioID.ToString();
                    txtNome.Text = modelo.NomeFuncionario;
                    txtNBI.Text = modelo.NumBI;
                    txtEmail.Text = modelo.EmailFuncionario;
                    txtEndereco.Text = modelo.EnderecoFuncionario;
                    txtTelefone.Text = modelo.TelefoneFuncionario;

                    AlterarBotoes(3); // Estado de edição
                }
                else
                {
                    LimpaTela();
                    AlterarBotoes(1); // Estado inicial
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao localizar funcionário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                ModeloFuncionario modelo = new ModeloFuncionario
                {
                    NomeFuncionario = txtNome.Text,
                    NumBI = txtNBI.Text,
                    EmailFuncionario = txtEmail.Text,
                    EnderecoFuncionario = txtEndereco.Text,
                    TelefoneFuncionario = txtTelefone.Text
                };

                DadosConexao conexao = new DadosConexao(DConexao.StringConexao);
                NegFuncionario negocio = new NegFuncionario(conexao);

                if (Operacao == "INSERIR")
                {
                    negocio.Incluir(modelo);
                    MessageBox.Show("Funcionário cadastrado com sucesso! ID: " + modelo.FuncionarioID.ToString(), "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (Operacao == "ALTERAR")
                {
                    modelo.FuncionarioID = Convert.ToInt32(txtID.Text);
                    negocio.Alterar(modelo);
                    MessageBox.Show("Funcionário alterado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LimpaTela();
                AlterarBotoes(1); // Estado inicial
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar funcionário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult confirmacao = MessageBox.Show("Deseja cancelar as alterações?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacao == DialogResult.Yes)
                {
                    LimpaTela();
                    AlterarBotoes(1); // Estado inicial
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cancelar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbVoltar_Click(object sender, EventArgs e)
        {
            // Retornar ao FormTelaPrincipal
            FormTelaPrincipal telaPrincipal = new FormTelaPrincipal();
            this.Hide();
            telaPrincipal.Show();
        }
    }
}

