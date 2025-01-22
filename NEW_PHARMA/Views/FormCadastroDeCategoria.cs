using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Dados;
using Negocio;

namespace Views
{
    public partial class FormCadastroDeCategoria : Form
    {
        public FormCadastroDeCategoria()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtNome.Clear();
        }

        public String Operacao = "";

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

        private void FormCadastroDeCategoria_Load(object sender, EventArgs e)
        {
            this.AlterarBotoes(1);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.Operacao = "INSERIR";
            this.AlterarBotoes(2);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.AlterarBotoes(1);
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Criação do modelo e atribuição dos dados
                ModeloCategoria modelo = new ModeloCategoria
                {
                    CategNome = txtNome.Text
                };

                // Instância para manipulação do banco de dados
                DadosConexao cox = new DadosConexao(DConexao.StringConexao);
                NegCategoria negCateg = new NegCategoria(cox);

                // Cadastrar uma nova categoria
                negCateg.Incluir(modelo);

                // Mensagem de sucesso
                MessageBox.Show("Categoria cadastrada com sucesso!");

                // Limpar os campos após o cadastro
                this.LimpaTela();

                // Alterar o estado dos botões para pós-cadastro
                this.AlterarBotoes(1);
            }
            catch (Exception ex)
            {
                // Mensagem de erro
                MessageBox.Show("Erro ao salvar categoria: " + ex.Message);
            }


        }

        private void pbVoltar_Click(object sender, EventArgs e)
        {
            // Retornar ao FormTelaPrincipal
            FormTelaPrincipal telaPrincipal = new FormTelaPrincipal();
            this.Hide();
            telaPrincipal.Show();
            this.Close();
        }

    }
}
