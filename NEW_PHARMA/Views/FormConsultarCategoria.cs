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
    public partial class FormConsultarCategoria : Form
    {
        public int Codigo = 1; // Alterado para iniciar em 1


        public FormConsultarCategoria()
        {
            InitializeComponent();
        }

        private void FormConsultarCategoria_Load(object sender, EventArgs e)
        {
            btnLocalizar_Click(sender, e);

        }


        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                DadosConexao cox = new DadosConexao(DConexao.StringConexao);
                NegCategoria negCateg = new NegCategoria(cox);

                // Buscar os dados com base no texto informado
                var resultado = negCateg.Localizar(txtForncedor.Text);

                // Verificar se existem dados no resultado
                if (resultado == null || resultado.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhuma categoria encontrada.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Exibir os dados no DataGridView
                dgvDados.DataSource = resultado;

                // Configurar as colunas após a carga dos dados
                if (dgvDados.Rows.Count >= 0)
                {
                    dgvDados.Columns[0].HeaderText = "Código";
                    dgvDados.Columns[0].Width = 100;
                    dgvDados.Columns[1].HeaderText = "Categoria";
                    dgvDados.Columns[1].Width = 700;
                }
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
            if (e.RowIndex >= 0)  // Corrigido para verificar que a linha selecionada é válida
            {
                this.Codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }


        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbVoltar_Click(object sender, EventArgs e)
        {

            // Retornar ao FormTelaPrincipal
            FormTelaPrincipal telaPrincipal = new FormTelaPrincipal();
            this.Hide();
            telaPrincipal.Show();
        }
    }
    
}
