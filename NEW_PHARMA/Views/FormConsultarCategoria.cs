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
    public partial class FormConsultarCategoria : Form
    {
        public int Codigo = 0;

        public FormConsultarCategoria()
        {
            InitializeComponent();
        }

        private void FormConsultarCategoria_Load(object sender, EventArgs e)
        {
            btnLocalizar_Click(sender, e);

            // Verifica se há dados no DataGridView antes de configurar as colunas
            if (dgvDados.DataSource != null && dgvDados.Rows.Count > 0)
            {
                dgvDados.Columns[0].HeaderText = "*Código*";
                dgvDados.Columns[0].Width = 100;
                dgvDados.Columns[1].HeaderText = "Categoria";
                dgvDados.Columns[1].Width = 700;
            }
            else
            {
                MessageBox.Show("Sem dados para configurar o grid.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                DadosConexao cox = new DadosConexao(DConexao.StringConexao);
                NegCategoria negCateg = new NegCategoria(cox);

                // Buscar os dados com base no texto informado
                var resultado = negCateg.Localizar(txtCategoria.Text);

                // Verificar se existem dados no resultado
                if (resultado == null || resultado.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhuma categoria encontrada.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Exibir os dados no DataGridView
                dgvDados.DataSource = resultado;
            }
            catch (Exception ex)
            {
                // Tratamento de erro
                MessageBox.Show($"Erro ao localizar dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                this.Codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
