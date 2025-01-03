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
    public partial class FormConsultarCliente : Form
    {
        public FormConsultarCliente()
        {
            InitializeComponent();
        }

        public int ClienteID { get; set; }


        public int Codigo = 1; // Alterado para iniciar em 1

        private void FormConsultarCliente_Load(object sender, EventArgs e)
        {

        }

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {

            try
            {
                DadosConexao cox = new DadosConexao(DConexao.StringConexao);
                NegCliente negCliente = new NegCliente(cox);

                // Buscar os dados com base no texto informado
                var resultado = negCliente.Localizar(txtCliente.Text);

                // Exibir os dados no DataGridView apenas se houver resultado
                if (resultado == null || resultado.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum cliente encontrado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvDados.DataSource = null;
                    return;
                }

                dgvDados.DataSource = resultado;

                // Configurar as colunas do DataGridView após a carga dos dados
                dgvDados.Columns[0].HeaderText = "Código";
                dgvDados.Columns[0].Width = 80;
                dgvDados.Columns[1].HeaderText = "Nome";
                dgvDados.Columns[1].Width = 200;
                dgvDados.Columns[2].HeaderText = "Nº BI";
                dgvDados.Columns[2].Width = 150;
                dgvDados.Columns[3].HeaderText = "Endereço";
                dgvDados.Columns[3].Width = 250;
                dgvDados.Columns[4].HeaderText = "Telefone";
                dgvDados.Columns[4].Width = 120;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao localizar cliente: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica se a linha clicada é válida
            {
                try
                {
                    // Obtém o ID do cliente selecionado
                    this.Codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells["ClienteID"].Value);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao selecionar o cliente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
