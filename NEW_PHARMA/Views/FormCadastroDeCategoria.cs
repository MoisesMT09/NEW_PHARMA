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
            txtID.Clear();
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
                // Leitura dos dados
                ModeloCategoria modelo = new ModeloCategoria
                {
                    CategNome = txtNome.Text
                };

                // Objeto para gravar os dados no banco
                DadosConexao cox = new DadosConexao(DConexao.StringConexao);
                NegCategoria negCateg = new NegCategoria(cox);

                if (this.Operacao == "INSERIR")
                {
                    // Cadastrar uma categoria
                    negCateg.Incluir(modelo);
                    MessageBox.Show("Cadastro efectuado ID: " + modelo.CategID.ToString());

                    // Preenche os campos com os dados inseridos
                    txtID.Text = modelo.CategID.ToString();
                    txtNome.Text = modelo.CategNome;

                    AlterarBotoes(1); // Estado de edição
                }
                else
                {
                    // Alterar uma categoria
                    modelo.CategID = Convert.ToInt32(txtID.Text);
                    negCateg.Alterar(modelo);
                    MessageBox.Show("Cadastro Alterado");
                }
                this.LimpaTela();
                this.AlterarBotoes(1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        

        }
        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            using (FormConsultarCategoria fCCategoria = new FormConsultarCategoria())
            {
                DadosConexao cox = new DadosConexao(DConexao.StringConexao);
                NegCategoria negCategoria = new NegCategoria(cox);
                ModeloCategoria modelo = negCategoria.CarregaModeloCategoria(fCCategoria.Codigo);
                fCCategoria.ShowDialog();
                if (fCCategoria.Codigo != 0)
                {
                    
                    txtID.Text = modelo.CategID.ToString();
                    txtNome.Text = modelo.CategNome;
                    AlterarBotoes(3);

                }
                else
                {
                    LimpaTela();
                    AlterarBotoes(1);
                }
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.Operacao = "ALTERAR";
            this.AlterarBotoes(2);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dial = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (dial.ToString() == "Yes")
                {
                    DadosConexao cox = new DadosConexao(DConexao.StringConexao);
                    NegCategoria negCateg = new NegCategoria(cox);
                    negCateg.Excluir(Convert.ToInt32(txtID.Text));
                    this.LimpaTela();
                    this.AlterarBotoes(1);
                }
            }
            catch
            {
                MessageBox.Show("Impossivel excluir o registro. \n o registro está sendo utilizado em outro local");
                this.AlterarBotoes(3);

            }
        }
    }
}
