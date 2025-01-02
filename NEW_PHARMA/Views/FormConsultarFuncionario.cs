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
    public partial class FormConsultarFuncionario : Form
    {
        public FormConsultarFuncionario()
        {
            InitializeComponent();
        }

        public int Codigo { get; private set; } = 1;

        private void FormConsultarFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void pbVoltar_Click(object sender, EventArgs e)
        {

            try
            {
                // Criar uma instância da tela principal
                FormTelaPrincipal telaPrincipal = new FormTelaPrincipal();

                // Exibir a tela principal
                telaPrincipal.Show();

                // Ocultar o formulário atual
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao voltar para a tela principal: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                DadosConexao conexao = new DadosConexao(DConexao.StringConexao);
                NegFuncionario negocio = new NegFuncionario(conexao);

                // Buscar os dados
                DataTable resultado = negocio.Localizar(txtFuncionario.Text);

                if (resultado == null || resultado.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum funcionário encontrado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Exibir no DataGridView
                dgvDados.DataSource = resultado;

                // Configurar as colunas do DataGridView
                if (dgvDados.Rows.Count > 0)
                {
                    dgvDados.Columns[0].HeaderText = "Código";
                    dgvDados.Columns[0].Width = 50;
                    dgvDados.Columns[1].HeaderText = "Nome";
                    dgvDados.Columns[1].Width = 150;
                    dgvDados.Columns[2].HeaderText = "Nº BI";
                    dgvDados.Columns[2].Width = 100;
                    dgvDados.Columns[3].HeaderText = "Email";
                    dgvDados.Columns[3].Width = 150;
                    dgvDados.Columns[4].HeaderText = "Endereço";
                    dgvDados.Columns[4].Width = 150;
                    dgvDados.Columns[5].HeaderText = "Telefone";
                    dgvDados.Columns[5].Width = 100;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao localizar funcionários: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Guardar o código do funcionário selecionado
                Codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);

                // Retornar à tela principal sem fechar o formulário
                this.Hide();
            }
        }
    }

}


