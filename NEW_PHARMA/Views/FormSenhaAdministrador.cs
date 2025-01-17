using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class FormSenhaAdministrador : Form
    {

        public FormSenhaAdministrador()
        {
            InitializeComponent();
        }

        public string Senha { get; private set; }
        private void FormSenhaAdministrador_Load(object sender, EventArgs e)
        {
            // Focar automaticamente no campo de senha quando o formulário for carregado
            txtSenha.Focus();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Verificar se o campo de senha não está vazio
            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Por favor, insira a senha do administrador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Não fecha o formulário caso a senha esteja vazia
            }

            Senha = txtSenha.Text; // Atribui o valor da senha à propriedade
            DialogResult = DialogResult.OK; // Fecha o formulário com resultado OK
            Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            // Fecha o formulário de Senha do Administrador
            this.Close();

            // Exibe o formulário de Login
            var formLogin = new FormLogin();  // Substitua 'FormLogin' pelo nome do seu formulário de login
            formLogin.Show();
        }
    }
}








