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
    public partial class FormConsultarCliente : Form
    {
        public FormConsultarCliente()
        {
            InitializeComponent();
        }

        public int ID { get; set; }

        private void FormConsultarCliente_Load(object sender, EventArgs e)
        {
            pnDados.Enabled = btnAlterar.Enabled = btnEliminar.Enabled = false;
            ObterClientes();
            ConfigurarDataGridView();
        }

        private void ObterClientes()
        {
            try
            {
                var cox = new DadosConexao(DConexao.StringConexao);
                var negCliente = new NegCliente(cox);
                var resultado = negCliente.Localizar(string.Empty);
                if (resultado == null || resultado.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum cliente encontrado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvDados.DataSource = null;
                    return;
                }
                dgvDados.DataSource = resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar clientes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLocalizar_Click(object sender, EventArgs e)
        {

            try
            {
                string pesquisa = txtCliente.Text.Trim();
                if (string.IsNullOrWhiteSpace(pesquisa))
                {
                    MessageBox.Show("Informe um nome para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var cox = new DadosConexao(DConexao.StringConexao);
                var negCliente = new NegCliente(cox);
                var resultado = negCliente.Localizar(pesquisa);
                if (resultado == null || resultado.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum cliente encontrado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvDados.DataSource = null;
                    return;
                }
                dgvDados.DataSource = resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao localizar cliente: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarDataGridView()
        {
            dgvDados.AllowUserToAddRows = dgvDados.AllowUserToDeleteRows = false;
            dgvDados.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvDados.AutoGenerateColumns = false;
            dgvDados.Columns.Clear();
            dgvDados.Columns.AddRange(
                new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "ID", ReadOnly = true, Width = 100 },
                new DataGridViewTextBoxColumn { HeaderText = "Nome", DataPropertyName = "Nome", ReadOnly = false, Width = 150 },
                new DataGridViewTextBoxColumn { HeaderText = "Endereço", DataPropertyName = "Endereco", ReadOnly = false, Width = 250 },
                new DataGridViewTextBoxColumn { HeaderText = "Telefone", DataPropertyName = "Telefone", ReadOnly = false, Width = 120 }
            );
            dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDados.MultiSelect = false;
        }

        //private void ConfigurarDataGridView()
        //{
        //    // Limpar configurações automáticas
        //    dgvDados.AllowUserToAddRows = false;
        //    dgvDados.EditMode = DataGridViewEditMode.EditOnEnter;
        //    dgvDados.AutoGenerateColumns = false;
        //    dgvDados.Columns.Clear();

        //    // Coluna ID (Somente Leitura)
        //    var colId = new DataGridViewTextBoxColumn
        //    {
        //        HeaderText = "ID",
        //        DataPropertyName = "ID", // Nome do campo no banco
        //        ReadOnly = true,
        //        Width = 100
        //    };
        //    dgvDados.Columns.Add(colId);

        //    // Coluna Nome
        //    var colNome = new DataGridViewTextBoxColumn
        //    {
        //        HeaderText = "Nome",
        //        DataPropertyName = "Nome", // Nome do campo no banco
        //        ReadOnly = false,
        //        Width = 150
        //    };
        //    dgvDados.Columns.Add(colNome);

        //    // Coluna Endereço
        //    var colEndereco = new DataGridViewTextBoxColumn
        //    {
        //        HeaderText = "Endereço",
        //        DataPropertyName = "Endereco", // Nome do campo no banco
        //        ReadOnly = false,
        //        Width = 250
        //    };
        //    dgvDados.Columns.Add(colEndereco);

        //    // Coluna Telefone
        //    var colTelefone = new DataGridViewTextBoxColumn
        //    {
        //        HeaderText = "Telefone",
        //        DataPropertyName = "Telefone", // Nome do campo no banco
        //        ReadOnly = false,
        //        Width = 120
        //    };
        //    dgvDados.Columns.Add(colTelefone);

        //    // Configuração geral do DataGridView
        //    dgvDados.AllowUserToAddRows = false;
        //    dgvDados.AllowUserToDeleteRows = false;
        //    dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //    dgvDados.MultiSelect = false;
        //    dgvDados.EditMode = DataGridViewEditMode.EditOnEnter;
        //}

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    ID = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                    MessageBox.Show($"ID do Cliente Selecionado: {ID}", "Cliente Selecionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao selecionar o cliente: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            pnDados.Enabled = btnAlterar.Enabled = btnEliminar.Enabled = true;
        }

        private void pbVoltar_Click(object sender, EventArgs e)
        {
            // Retornar ao FormTelaPrincipal
            FormTelaPrincipal telaPrincipal = new FormTelaPrincipal();
            this.Hide();
            telaPrincipal.Show();
            this.Close();
        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ID > 0)
            {
                var confirm = MessageBox.Show("Tem certeza que deseja excluir este cliente?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        var negCliente = new NegCliente(new DadosConexao(DConexao.StringConexao));
                        negCliente.Excluir(ID);
                        ObterClientes();
                        MessageBox.Show("Cliente excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao excluir cliente: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um cliente para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            try
            {
                var dCliente = new DCliente(new DadosConexao(DConexao.StringConexao));
                foreach (DataGridViewRow row in dgvDados.Rows)
                {
                    if (row.IsNewRow) continue;
                    if (row.Cells["ID"].Value == null || row.Cells["Nome"].Value == null || row.Cells["Telefone"].Value == null || row.Cells["Endereco"].Value == null)
                        continue;

                    var cliente = new ModeloCliente
                    {
                        NomeCliente = row.Cells["Nome"].Value.ToString(),
                        TelefoneCliente = row.Cells["Telefone"].Value.ToString(),
                        EnderecoCliente = row.Cells["Endereco"].Value.ToString()
                    };
                    dCliente.Alterar(cliente);
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
                MessageBox.Show("Alterações salvas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar alterações: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}





