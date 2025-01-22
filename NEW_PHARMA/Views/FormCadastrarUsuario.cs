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
using static Modelo.ModeloUsuarios;

namespace Views
{
    public partial class FormCadastrarUsuario : Form
    {
        public FormCadastrarUsuario()
        {
            InitializeComponent();
        }

        private void LimparFormulario()
        {
            txtNome.Clear();
            txtLogin.Clear();
            txtSenha.Clear();
            chekEstado.Checked = false; // Resetando o CheckBox
            cmbNivelAcesso.SelectedIndex = 2; // Define como "Funcionário" após o cadastro
        }

        private string GerarHashSenha(string senha)
        {
            // Exemplo de função para gerar hash da senha
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(senha));
                return Convert.ToBase64String(hashBytes);
            }
        }

        private void FormCadastrarUsuario_Load(object sender, EventArgs e)
        {

            // Adiciona os níveis de acesso ao ComboBox
            cmbNivelAcesso.Items.Add("Administrador");
            cmbNivelAcesso.Items.Add("Gestor");
            cmbNivelAcesso.Items.Add("Funcionário");

            // Define o nível padrão como "Funcionário"
            cmbNivelAcesso.SelectedIndex = 2;  // "Funcionário" será o padrão
        }

        private int ObterNivelAcesso(string nivel)
        {
            switch (nivel)
            {
                case "Administrador":
                    return 1;
                case "Gestor":
                    return 2;
                case "Funcionário":
                    return 3;
                default:
                    return 3; // Nível padrão
            }
        }


        private bool VerificarSenhaAdministrador()
        {
            using (var formSenha = new FormSenhaAdministrador())
            {
                if (formSenha.ShowDialog() == DialogResult.OK)
                {
                    string senhaInserida = formSenha.Senha; // Captura a senha digitada
                    // Passando a string de conexão ao criar a instância de DadosConexao
                    var dUsuario = new DUsuario(new DadosConexao(DConexao.StringConexao));
                    return dUsuario.ValidarSenhaAdministradorPrincipal(senhaInserida);
                }

                return false; // O usuário cancelou a operação
            }
        }

        private ComboBox GetCmbNivelAcesso()
        {
            return cmbNivelAcesso;
        }

        private bool ValidarNivelAcessoSelecionado(ComboBox cmbNivelAcesso)
        {
            try
            {
                // Obtem o nível de acesso selecionado no ComboBox
                string nivelAcessoSelecionado = cmbNivelAcesso.SelectedItem.ToString();
                int nivelAcesso = ObterNivelAcesso(nivelAcessoSelecionado);

                string? senhaAdministrador = null;

                // Se for Gestor ou Administrador, exibe o formulário de senha
                if (nivelAcesso == (int)Modelo.NivelAcesso.Gestor || nivelAcesso == (int)Modelo.NivelAcesso.Administrador)
                {
                    using (var formSenha = new FormSenhaAdministrador())
                    {
                        if (formSenha.ShowDialog() == DialogResult.OK)
                        {
                            senhaAdministrador = formSenha.Senha;
                        }
                        else
                        {
                            MessageBox.Show("A operação foi cancelada.");
                            return false;
                        }
                    }
                }

                // Chama o método centralizado da camada de negócio para validar o nível de acesso
                var dUsuario = new DUsuario(new DadosConexao(DConexao.StringConexao));
                return dUsuario.ValidarNivelAcesso(nivelAcesso, senhaAdministrador);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            // Obter os dados do usuário
            if (!ValidarNivelAcessoSelecionado(GetCmbNivelAcesso()))
            {
                return; // Interrompe o cadastro se a validação falhar
            }

            // Prossegue com o cadastro
            try
            {

                var usuario = new ModeloUsuarios.Usuario
                {
                    Nome = txtNome.Text,
                    Login = txtLogin.Text,
                    SenhaHash = GerarHashSenha(txtSenha.Text),
                    NivelAcesso = Convert.ToInt32(cmbNivelAcesso.SelectedValue),
                    Ativo = chekEstado.Checked
                };

                var dUsuario = new DUsuario(new DadosConexao(DConexao.StringConexao));
                bool sucesso = dUsuario.Inserir(usuario);
                if (sucesso)
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparFormulario();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar usuário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar usuário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Retornar ao FormLogin
            FormLogin telalogin = new FormLogin();
            this.Hide();    
            telalogin.Show();

        }
    }


}



