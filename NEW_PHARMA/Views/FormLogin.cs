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
using Negocio;

namespace Views
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string login = txtLogin.Text.Trim();
                string senha = txtSenha.Text.Trim();

                var conexao = new DadosConexao(DConexao.StringConexao);
                var negUsuario = new NegUsuario(conexao);
                bool credenciaisValidas = negUsuario.ValidarCredenciais(login, senha);

                if (credenciaisValidas)
                {
                    MessageBox.Show("Login realizado com sucesso!", "Bem-vindo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Redirecionar para o próximo formulário
                }
                else
                {
                    MessageBox.Show("Login ou senha inválidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCadastrarUsuario cadastrarUsuario = new FormCadastrarUsuario();
            this.Hide();
            cadastrarUsuario.Show();
        }

        private void pbVoltar_Click(object sender, EventArgs e)
        {
            // Ocultar o formulário atual
            this.Hide();

            // Instanciar o formulário de apresentação (se necessário)
            FormTelaDeApresentacao telaApresentacao = new FormTelaDeApresentacao();

            // Exibir o formulário de apresentação
            telaApresentacao.Show();

            // Opcional: Fechar o formulário atual ao voltar à tela inicial
        }
    }
}
