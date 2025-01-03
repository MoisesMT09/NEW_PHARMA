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
            txtID.Clear();
            txtNome.Clear();
            txtDescricao.Clear();
            txtQuantidade.Clear();
            txtPreco.Clear();
            cmbCategoria.SelectedIndex = -1; // Reseta a seleção
            cmbFornecedor.SelectedIndex = -1; // Reseta a seleção
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

        private void FormCadastroDeProduto_Load(object sender, EventArgs e)
        {
            this.AlterarBotoes(1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ptInicial_Click(object sender, EventArgs e)
        {
            // Voltar para o formulário principal

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.Operacao = "INSERIR";
            this.AlterarBotoes(2);
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            using (FormConsultarProduto consultarProduto = new FormConsultarProduto())
            {
                consultarProduto.ShowDialog();
                if (consultarProduto.Codigo != 0)
                {
                    DadosConexao cox = new DadosConexao(DConexao.StringConexao);
                    NegProduto negProduto = new NegProduto(cox);

                    ModeloProduto modelo = negProduto.CarregaModeloProduto(consultarProduto.Codigo);

                    txtID.Text = modelo.ProdutoID.ToString();
                    txtNome.Text = modelo.NomeProduto;
                    txtDescricao.Text = modelo.DescProduto;
                    txtQuantidade.Text = modelo.QuantEstProduto.ToString();
                    txtPreco.Text = modelo.PrecoProduto.ToString();
                    cmbCategoria.SelectedValue = modelo.CategID;
                    cmbFornecedor.SelectedValue = modelo.FornecID;

                    AlterarBotoes(3); // Estado de edição
                }
                else
                {
                    LimpaTela();
                    AlterarBotoes(1);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resposta = MessageBox.Show("Deseja realmente excluir este produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    int codigo = int.Parse(txtID.Text);

                    DadosConexao cox = new DadosConexao(DConexao.StringConexao);
                    NegProduto negProduto = new NegProduto(cox);

                    negProduto.Excluir(codigo);
                    MessageBox.Show("Produto excluído com sucesso!");

                    this.LimpaTela();
                    this.AlterarBotoes(1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir o produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            try
            {
                // Criação do modelo e preenchimento dos dados
                ModeloProduto modelo = new ModeloProduto
                {
                    ProdutoID = int.Parse(txtID.Text),
                    NomeProduto = txtNome.Text,
                    DescProduto = txtDescricao.Text,
                    QuantEstProduto = int.Parse(txtQuantidade.Text),
                    PrecoProduto = decimal.Parse(txtPreco.Text),
                    CategID = int.Parse(cmbCategoria.SelectedValue.ToString()),
                    FornecID = int.Parse(cmbFornecedor.SelectedValue.ToString())
                };

                DadosConexao cox = new DadosConexao(DConexao.StringConexao);
                NegProduto negProduto = new NegProduto(cox);

                negProduto.Alterar(modelo);
                MessageBox.Show("Produto alterado com sucesso!");

                this.LimpaTela();
                this.AlterarBotoes(1); // Estado inicial
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar o produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                };

                DadosConexao cox = new DadosConexao(DConexao.StringConexao);
                NegProduto negProduto = new NegProduto(cox);

                if (this.Operacao == "INSERIR")
                {
                    negProduto.InserirProduto(modelo);
                    MessageBox.Show("Produto inserido com sucesso. ID: " + modelo.ProdutoID.ToString());

                    txtID.Text = modelo.ProdutoID.ToString();
                }
                else if (this.Operacao == "ALTERAR")
                {
                    modelo.ProdutoID = Convert.ToInt32(txtID.Text);
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

