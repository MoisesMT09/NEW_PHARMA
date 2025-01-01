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
    public partial class FormConsultarFornecedor : Form
    {
        public FormConsultarFornecedor()
        {
            InitializeComponent();
        }

        public int Codigo = 1; // Alterado para iniciar em 1

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Fecha o formulário atual
            this.Close();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {

            try
            {
                DadosConexao cox = new DadosConexao(DConexao.StringConexao);
                NegFornecedor negForn = new NegFornecedor(cox);

                // Buscar os dados com base no texto informado
                var resultado = negForn.Localizar(txtFornecedor.Text);

                // Verificar se o resultado é um DataTable ou outro tipo esperado
                if (resultado == null || (resultado is DataTable && ((DataTable)resultado).Rows.Count == 0))
                {
                    MessageBox.Show("Nenhum fornecedor encontrado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Exibir os dados no DataGridView
                dgvDados.DataSource = resultado;

                // Configurar as colunas após a carga dos dados
                if (dgvDados.Rows.Count > 0)
                {
                    if (dgvDados.Columns.Contains("FornecedorID"))
                        dgvDados.Columns["FornecedorID"].HeaderText = "Código";
                    if (dgvDados.Columns.Contains("FornecedorID"))
                        dgvDados.Columns["FornecedorID"].Width = 100;

                    if (dgvDados.Columns.Contains("NomeFornecedor"))
                        dgvDados.Columns["NomeFornecedor"].HeaderText = "Nome";
                    if (dgvDados.Columns.Contains("NomeFornecedor"))
                        dgvDados.Columns["NomeFornecedor"].Width = 200;

                    if (dgvDados.Columns.Contains("NIFFornecedor"))
                        dgvDados.Columns["NIFFornecedor"].HeaderText = "NIF";
                    if (dgvDados.Columns.Contains("NIFFornecedor"))
                        dgvDados.Columns["NIFFornecedor"].Width = 150;

                    if (dgvDados.Columns.Contains("EnderecoFornecedor"))
                        dgvDados.Columns["EnderecoFornecedor"].HeaderText = "Endereço";
                    if (dgvDados.Columns.Contains("EnderecoFornecedor"))
                        dgvDados.Columns["EnderecoFornecedor"].Width = 200;

                    if (dgvDados.Columns.Contains("TelefoneFornecedor"))
                        dgvDados.Columns["TelefoneFornecedor"].HeaderText = "Telefone";
                    if (dgvDados.Columns.Contains("TelefoneFornecedor"))
                        dgvDados.Columns["TelefoneFornecedor"].Width = 150;

                    if (dgvDados.Columns.Contains("EmailFornecedor"))
                        dgvDados.Columns["EmailFornecedor"].HeaderText = "E-mail";
                    if (dgvDados.Columns.Contains("EmailFornecedor"))
                        dgvDados.Columns["EmailFornecedor"].Width = 200;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao localizar dados: {ex.Message}\n{ex.StackTrace}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void FormConsultarFornecedor_Load(object sender, EventArgs e)
        {
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0) // Verifica se a linha clicada é válida
            {
                try
                {
                    // Obtém o ID do fornecedor selecionado
                    this.Codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells["FornecedorID"].Value);

                    // Fecha o formulário atual (caso seja usado para seleção de fornecedor)
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao selecionar o fornecedor: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

