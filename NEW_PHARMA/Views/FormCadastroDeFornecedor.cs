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
    public partial class FormCadastroDeFornecedor : Form
    {
        public FormCadastroDeFornecedor()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtID.Clear();
            txtNome.Clear();
            txtNIF.Clear();
            txtEndereco.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
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

        private void FormCadastroDeFornecedor_Load(object sender, EventArgs e)
        {
            this.AlterarBotoes(1);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Fecha o formulário atual
            this.Close();
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
                ModeloFornecedor modelo = new ModeloFornecedor
                {
                    NomeFornecedor = txtNome.Text,
                    NIFFornecedor = txtNIF.Text,
                    EnderecoFornecedor = txtEndereco.Text,
                    TelefoneFornecedor = txtTelefone.Text,
                    EmailFornecedor = txtEmail.Text
                };

                // Objeto para gravar os dados no banco
                DadosConexao cox = new DadosConexao(DConexao.StringConexao);
                NegFornecedor negForn = new NegFornecedor(cox);

                if (this.Operacao == "INSERIR")
                {
                    // Cadastrar um fornecedor
                    negForn.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado com sucesso! ID: " + modelo.FornecedorID.ToString());

                    // Preenche os campos com os dados inseridos
                    txtID.Text = modelo.FornecedorID.ToString();
                    txtNome.Text = modelo.NomeFornecedor;
                    txtNIF.Text = modelo.NIFFornecedor;
                    txtEndereco.Text = modelo.EnderecoFornecedor;
                    txtTelefone.Text = modelo.TelefoneFornecedor;
                    txtEmail.Text = modelo.EmailFornecedor;

                    AlterarBotoes(1); // Estado de edição
                }
                else
                {
                    // Alterar um fornecedor
                    modelo.FornecedorID = Convert.ToInt32(txtID.Text);
                    negForn.Alterar(modelo);
                    MessageBox.Show("Cadastro Alterado com sucesso!");
                }

                // Limpar tela e ajustar botões
                this.LimpaTela();
                this.AlterarBotoes(1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("Deseja realmente excluir este fornecedor?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Valida se há um ID para exclusão
                    if (string.IsNullOrEmpty(txtID.Text))
                    {
                        MessageBox.Show("Nenhum fornecedor selecionado para exclusão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Converte o ID do fornecedor
                    int fornecedorID = Convert.ToInt32(txtID.Text);

                    // Objeto para comunicação com o banco
                    DadosConexao cox = new DadosConexao(DConexao.StringConexao);
                    NegFornecedor negForn = new NegFornecedor(cox);

                    // Realiza a exclusão
                    negForn.Excluir(fornecedorID);

                    MessageBox.Show("Fornecedor excluído com sucesso!");

                    // Limpa a tela e ajusta os botões
                    this.LimpaTela();
                    this.AlterarBotoes(1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir o fornecedor: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            try
            {
                // Validações iniciais
                if (string.IsNullOrEmpty(txtID.Text))
                {
                    MessageBox.Show("Nenhum fornecedor selecionado para alteração.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(txtNome.Text.Trim()) ||
                    string.IsNullOrEmpty(txtNIF.Text.Trim()) ||
                    string.IsNullOrEmpty(txtEndereco.Text.Trim()) ||
                    string.IsNullOrEmpty(txtTelefone.Text.Trim()) ||
                    string.IsNullOrEmpty(txtEmail.Text.Trim()))
                {
                    MessageBox.Show("Todos os campos são obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Preenchimento do modelo
                ModeloFornecedor modelo = new ModeloFornecedor
                {
                    FornecedorID = Convert.ToInt32(txtID.Text),
                    NomeFornecedor = txtNome.Text.Trim(),
                    NIFFornecedor = txtNIF.Text.Trim(),
                    EnderecoFornecedor = txtEndereco.Text.Trim(),
                    TelefoneFornecedor = txtTelefone.Text.Trim(),
                    EmailFornecedor = txtEmail.Text.Trim()
                };

                // Objeto para comunicação com a camada de negócios
                DadosConexao cox = new DadosConexao(DConexao.StringConexao);
                NegFornecedor negForn = new NegFornecedor(cox);

                // Alteração no banco de dados
                negForn.Alterar(modelo);

                MessageBox.Show("Fornecedor alterado com sucesso!");

                // Atualiza os campos e ajusta os botões
                txtID.Text = modelo.FornecedorID.ToString();
                txtNome.Text = modelo.NomeFornecedor;
                txtNIF.Text = modelo.NIFFornecedor;
                txtEndereco.Text = modelo.EnderecoFornecedor;
                txtTelefone.Text = modelo.TelefoneFornecedor;
                txtEmail.Text = modelo.EmailFornecedor;

                AlterarBotoes(1); // Retorna ao estado de visualização
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar o fornecedor: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {

            using (FormConsultarFornecedor fCFornecedor = new FormConsultarFornecedor())
            {
                DadosConexao cox = new DadosConexao(DConexao.StringConexao);
                NegFornecedor negFornecedor = new NegFornecedor(cox);

                // Exibir o formulário de consulta
                fCFornecedor.ShowDialog();

                if (fCFornecedor.Codigo != 0) // Verifica se um fornecedor foi selecionado
                {
                    ModeloFornecedor modelo = negFornecedor.CarregaModeloFornecedor(fCFornecedor.Codigo);

                    // Preencher os campos com os dados do fornecedor selecionado
                    txtID.Text = modelo.FornecedorID.ToString();
                    txtNome.Text = modelo.NomeFornecedor;
                    txtNIF.Text = modelo.NIFFornecedor;
                    txtEndereco.Text = modelo.EnderecoFornecedor;
                    txtTelefone.Text = modelo.TelefoneFornecedor;
                    txtEmail.Text = modelo.EmailFornecedor;

                    AlterarBotoes(3); // Altera os botões para estado de edição
                }
                else
                {
                    LimpaTela(); // Limpa os campos caso nenhum fornecedor seja selecionado
                    AlterarBotoes(1); // Altera os botões para estado padrão
                }
            }
        }

    }

}





