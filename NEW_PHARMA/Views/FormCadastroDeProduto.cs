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
using Modelo;

namespace Views
{
    public partial class FormCadastroDeProduto : Form
    {
        public FormCadastroDeProduto()
        {
            InitializeComponent();
        }

        private void LimpaTela()
        {
            //txtID.Clear();
            txtNome.Clear();
            txtDescricao.Clear();
            txtQuantidade.Clear();
            txtPreco.Clear();
            cmbCategoria.SelectedIndex = -1; // Reseta a seleção
            cmbFornecedor.SelectedIndex = -1; // Reseta a seleção
            dtpDataValidade.Value = new DateTime(2025, 1, 1);
        }


        public String Operacao;

        public void AlterarBotoes(int op)
        {
            pnDados.Enabled = false;
            //btnLocalizar.Enabled = false;
            btnInserir.Enabled = false;
            //btnExcluir.Enabled = false;
            //btnAlterar.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            if (op == 1)
            {
                btnInserir.Enabled = true;
                //btnLocalizar.Enabled = true;
            }
            if (op == 2)
            {
                pnDados.Enabled = true;
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
            }
            if (op == 3)
            {
                //btnAlterar.Enabled = true;
                //btnExcluir.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        private void FormCadastroDeProduto_Load(object sender, EventArgs e)
        {
            this.AlterarBotoes(1);

            dtpDataValidade.Value = new DateTime(2025, 1, 1); 
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.Operacao = "INSERIR";
            this.AlterarBotoes(2);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Criação do modelo a partir dos dados da tela
                ModeloProduto modelo = new ModeloProduto
                {
                    NomeProduto = txtNome.Text,
                    DescProduto = txtDescricao.Text.Trim(),
                    PrecoProduto = Convert.ToDecimal(txtPreco.Text),
                    QuantEstProduto = Convert.ToInt32(txtQuantidade.Text),
                    CategID = Convert.ToInt32(cmbCategoria.SelectedValue),
                    FornecID = Convert.ToInt32(cmbFornecedor.SelectedValue),
                    DataValida = dtpDataValidade.Value,
                };

                DadosConexao cox = new DadosConexao(DConexao.StringConexao);
                NegProduto negProduto = new NegProduto(cox);

                if (this.Operacao == "INSERIR")
                {
                    negProduto.InserirProduto(modelo);
                    MessageBox.Show("Produto inserido com sucesso.");

                    txtNome.Text = modelo.NomeProduto.ToString();
                }
                else if (this.Operacao == "ALTERAR")
                {
                    modelo.NomeProduto = Convert.ToString(txtNome.Text);
                    negProduto.Alterar(modelo);
                    MessageBox.Show("Produto atualizado com sucesso.");
                }

                this.LimpaTela();
                this.AlterarBotoes(1);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            };
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaTela();
            AlterarBotoes(1); // Retorna ao estado inicial
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

