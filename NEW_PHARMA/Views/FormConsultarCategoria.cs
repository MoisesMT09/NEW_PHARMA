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
using Views;

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
                DadosConexao conexao = new DadosConexao(DConexao.StringConexao);
                NegCategoria negCategoria = new NegCategoria(conexao);

                // Buscar os dados com base no texto informado
                var resultado = negCategoria.Localizar(txtCategoria.Text.Trim());

                // Configurar DataGridView apenas se houver resultados
                if (resultado != null && resultado.Rows.Count > 0)
                {
                    dgvDados.DataSource = resultado;

                    // Configurar cabeçalhos das colunas
                    dgvDados.Columns[0].HeaderText = "Código";
                    dgvDados.Columns[0].Width = 80;
                    dgvDados.Columns[1].HeaderText = "Categoria";
                    dgvDados.Columns[1].Width = 350;

                    // Exibir mensagem de sucesso
                    MessageBox.Show("Resultados encontrados.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Limpar DataGridView se não houver resultados
                    dgvDados.DataSource = null;
                    MessageBox.Show("Nenhuma categoria encontrada.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao localizar categorias: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica se uma linha válida foi clicada
            {
                this.Codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                MessageBox.Show($"Categoria selecionada: {dgvDados.Rows[e.RowIndex].Cells[1].Value}", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbVoltar_Click(object sender, EventArgs e)
        {

            this.Codigo = 0; // Resetar código ao voltar
            FormTelaPrincipal telaPrincipal = new FormTelaPrincipal();
            this.Hide();
            telaPrincipal.Show();
            this.Close();
        }
    }

}

