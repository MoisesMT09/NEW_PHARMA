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
    public partial class FormConsultarProduto : Form
    {
        public FormConsultarProduto()
        {
            InitializeComponent();
        }

        public int Codigo { get; private set; } // Alterado para iniciar em 1
        private void FormConsultarProduto_Load(object sender, EventArgs e)
        {

        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)  // Verificar se uma linha válida foi selecionada
            {
                this.Codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                MessageBox.Show($"Código do Produto Selecionado: {this.Codigo}", "Produto Selecionado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Retornar ao FormTelaPrincipal
                FormTelaPrincipal telaPrincipal = new FormTelaPrincipal();
                this.Hide();
                telaPrincipal.Show();
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Criar conexão e objeto de negócios
                DadosConexao cox = new DadosConexao(DConexao.StringConexao);
                NegProduto negProduto = new NegProduto(cox);

                // Buscar os dados com base no texto informado
                DataTable resultado = negProduto.Localizar(txtProduto.Text);

                // Verificar se existem dados no resultado
                if (resultado == null || resultado.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum produto encontrado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Exibir os dados no DataGridView
                dgvDados.DataSource = resultado;

                // Configurar as colunas após a carga dos dados
                if (dgvDados.Rows.Count > 0)
                {
                    dgvDados.Columns[0].HeaderText = "Código";
                    dgvDados.Columns[0].Width = 100;
                    dgvDados.Columns[1].HeaderText = "Nome";
                    dgvDados.Columns[1].Width = 150;
                    dgvDados.Columns[6].HeaderText = "Categoria";
                    dgvDados.Columns[6].Width = 150;
                    dgvDados.Columns[2].HeaderText = "Descrição";
                    dgvDados.Columns[2].Width = 250;
                    dgvDados.Columns[3].HeaderText = "Preço";
                    dgvDados.Columns[3].Width = 100;
                    dgvDados.Columns[4].HeaderText = "Estoque";
                    dgvDados.Columns[4].Width = 100;
                    dgvDados.Columns[5].HeaderText = "Fornecedor";
                    dgvDados.Columns[5].Width = 150;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao localizar dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

