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
            this.AlterarBotoes(2);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloCategoria modelo = new ModeloCategoria();
                modelo.CategNome = txtNome.Text;
                DadosConexao cox = new DadosConexao(DConexao.StringConexao);
                NegCategoria negCateg = new NegCategoria(cox);

                if (this.Operacao == "INSERIR")
                {
                    negCateg.Incluir(modelo);
                    MessageBox.Show("Cadastro efectuado ID :" + modelo.CategID.ToString());
                }
                else
                {
                    modelo.CategID = Convert.ToInt32(txtID.Text);
                    negCateg.Alterar(modelo);
                    MessageBox.Show("Cadastro Altrado");
                }
                this.LimpaTela();
                this.AlterarBotoes(1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnLocalizar_Click(object sender, EventArgs e)
        {

        }
    }
}
