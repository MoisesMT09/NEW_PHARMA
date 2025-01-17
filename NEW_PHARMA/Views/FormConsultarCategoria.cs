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

        public FormConsultarCategoria()
        {
            InitializeComponent();
        }

        public int ID { get; private set; } // Alterado para iniciar em 1

        private void FormConsultarCategoria_Load(object sender, EventArgs e)
        {
            pnDados.Enabled = false;
            btnAlterar.Enabled = false;
            btnEliminar.Enabled = false;

            CarregarCategorias();
        }
        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                DadosConexao conexao = new DadosConexao(DConexao.StringConexao);
                NegCategoria negCategoria = new NegCategoria(conexao);

                // Buscar os dados com base no texto informado
                var resultado = negCategoria.Localizar(string.Empty);

                // Configurar DataGridView apenas se houver resultados
                if (resultado != null && resultado.Rows.Count > 0)
                {
                    dgvDados.DataSource = resultado;

                    // Configurar cabeçalhos das colunas
                    dgvDados.Columns[0].HeaderText = "ID";
                    dgvDados.Columns[0].Width = 150;
                    dgvDados.Columns[1].HeaderText = "Categoria";
                    dgvDados.Columns[1].Width = 500;

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

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica se uma linha válida foi clicada
            {
                this.ID = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                MessageBox.Show($"ID : {this.ID} da Categoria : {dgvDados.Rows[e.RowIndex].Cells[1].Value}  selecionada: ", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Liberar os botões de Alterar e Eliminar
            pnDados.Enabled = true;
            btnAlterar.Enabled = true;  // Habilitar o botão Alterar
            btnEliminar.Enabled = true;  // Habilitar o botão Eliminar
        }

        private void CarregarCategorias()
        {
            try
            {
                NegCategoria negCateg = new NegCategoria(new DadosConexao(DConexao.StringConexao));
                dgvDados.DataSource = negCateg.CarregarDados();

                // Ajuste o cabeçalho das colunas, se necessário
                dgvDados.Columns["ID"].HeaderText = "Código";
                dgvDados.Columns["Nome"].HeaderText = "Categoria";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar categorias: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbVoltar_Click(object sender, EventArgs e)
        {

            FormTelaPrincipal telaPrincipal = new FormTelaPrincipal();
            this.Hide();
            telaPrincipal.Show();
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDados.SelectedRows.Count > 0) // Verificar se uma linha foi selecionada
            {
                int idSelecionado = Convert.ToInt32(dgvDados.SelectedRows[0].Cells["ID"].Value); // Pegue o ID da linha selecionada

                if (idSelecionado > 0) // Verificar se o ID é válido
                {
                    // Confirmação de exclusão
                    DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir esta categoria?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        try
                        {
                            // Criar objeto de negócio para eliminar a categoria
                            DadosConexao conexao = new DadosConexao(DConexao.StringConexao);
                            NegCategoria negCategoria = new NegCategoria(conexao);

                            // Chama o método de eliminação de categoria
                            negCategoria.Excluir(idSelecionado);

                            // Recarregar as categorias após a exclusão
                            CarregarCategorias();

                            MessageBox.Show("Categoria excluída com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Erro ao excluir categoria: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selecione uma Categoria para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma Categoria para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                var dCategoria = new DCategoria(new DadosConexao(DConexao.StringConexao));

                foreach (DataGridViewRow row in dgvDados.Rows)
                {
                    if (!row.IsNewRow) // Ignorar a linha nova
                    {
                        // Validação básica para evitar erros
                        if (row.Cells["ID"].Value == null || row.Cells["Nome"].Value == null)
                        {
                            continue; // Ignorar linhas com dados incompletos
                        }

                        ModeloCategoria categoria = new ModeloCategoria
                        {
                            CategID = Convert.ToInt32(row.Cells["ID"].Value),
                            CategNome = row.Cells["Nome"].Value.ToString()
                        };

                        // Atualizar no banco de dados
                        dCategoria.Alterar(categoria);

                        // Alterar cor da linha como feedback visual
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                    }
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



