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
    public partial class FormConsultarProduto : Form
    {
        public FormConsultarProduto()
        {
            InitializeComponent();
        }

        public int ID { get; private set; } // Alterado para iniciar em 1
        private void FormConsultarProduto_Load(object sender, EventArgs e)
        {

            // Desabilitar botões ao carregar a tela
            pnDados.Enabled = false;
            btnAlterar.Enabled = false;
            btnEliminar.Enabled = false;
            //Carregar Produto
            ConfigurarDataGridView();
            CarregarProdutos();
        }

        private void CarregarProdutos()
        {
            try
            {
                DadosConexao cox = new DadosConexao(DConexao.StringConexao);
                NegProduto negProduto = new NegProduto(cox);

                // Carregar todos os produtos na inicialização
                DataTable produtos = negProduto.Localizar(string.Empty);

                // Exibir os produtos no DataGridView
                dgvDados.DataSource = produtos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar produtos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)  // Verificar se uma linha válida foi selecionada
            {
                // Captura o código do produto da célula selecionada
                this.ID = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);

                // Exibir mensagem com o código do produto selecionado
                MessageBox.Show($"ID do Produto Selecionado: {this.ID}", "Produto Selecionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {

            try
            {
                string pesquisa = txtProduto.Text.Trim();
                if (string.IsNullOrEmpty(pesquisa))
                {
                    MessageBox.Show("Por favor, insira um nome para pesquisa.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Criar conexão e objeto de negócios
                DadosConexao cox = new DadosConexao(DConexao.StringConexao);
                NegProduto negProduto = new NegProduto(cox);

                // Buscar os dados com base no texto informado
                DataTable resultado = negProduto.Localizar(pesquisa);
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
                    dgvDados.Columns[0].HeaderText = "ID";
                    dgvDados.Columns[0].Width = 100;
                    dgvDados.Columns[1].HeaderText = "Nome";
                    dgvDados.Columns[1].Width = 150;
                    dgvDados.Columns[2].HeaderText = "Descrição";
                    dgvDados.Columns[2].Width = 250;
                    dgvDados.Columns[3].HeaderText = "Preço";
                    dgvDados.Columns[3].Width = 100;
                    dgvDados.Columns[4].HeaderText = "Estoque";
                    dgvDados.Columns[4].Width = 100;
                    dgvDados.Columns[5].HeaderText = "DATA DE VALIDADE";
                    dgvDados.Columns[5].Width = 150;
                    dgvDados.Columns[6].HeaderText = "Categoria";
                    dgvDados.Columns[6].Width = 150;
                    dgvDados.Columns[7].HeaderText = "Fornecedor";
                    dgvDados.Columns[7].Width = 150;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao localizar dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ConfigurarDataGridView()
        {
            // Limpar configurações automáticas
            dgvDados.AllowUserToAddRows = false;
            dgvDados.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvDados.AutoGenerateColumns = false;
            dgvDados.Columns.Clear();

            // Coluna ID (Somente Leitura)
            // No DataGridView
            var colId = new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                DataPropertyName = "ID", // Altere conforme o nome no banco
                ReadOnly = true,
                Width = 100
            };
            dgvDados.Columns.Add(colId);


            // Coluna Nome
            var colNome = new DataGridViewTextBoxColumn
            {
                HeaderText = "Nome",
                DataPropertyName = "Nome",
                ReadOnly = false,
                Width = 150
            };
            dgvDados.Columns.Add(colNome);

            // Coluna Descrição
            var colDescricao = new DataGridViewTextBoxColumn
            {
                HeaderText = "Descrição",
                DataPropertyName = "Descricao",
                ReadOnly = false,
                Width = 250
            };
            dgvDados.Columns.Add(colDescricao);

            // Coluna Preço
            var colPreco = new DataGridViewTextBoxColumn
            {
                HeaderText = "Preço",
                DataPropertyName = "Preco",
                ReadOnly = false,
                Width = 100
            };
            dgvDados.Columns.Add(colPreco);

            // Coluna Estoque
            var colEstoque = new DataGridViewTextBoxColumn
            {
                HeaderText = "Estoque",
                DataPropertyName = "Estoque",
                ReadOnly = false,
                Width = 100
            };
            dgvDados.Columns.Add(colEstoque);

            // Coluna Data de Validade
            var colDataValidade = new DataGridViewTextBoxColumn
            {
                HeaderText = "DATA DE VALIDADE",
                DataPropertyName = "DataValidade",
                ReadOnly = false,
                Width = 150
            };
            dgvDados.Columns.Add(colDataValidade);

            // Coluna Categoria
            var colCategoria = new DataGridViewTextBoxColumn
            {
                HeaderText = "Categoria",
                DataPropertyName = "Categoria",
                ReadOnly = true,
                Width = 150
            };
            dgvDados.Columns.Add(colCategoria);

            // Coluna Fornecedor
            var colFornecedor = new DataGridViewTextBoxColumn
            {
                HeaderText = "Fornecedor",
                DataPropertyName = "Fornecedor",
                ReadOnly = true,
                Width = 150
            };
            dgvDados.Columns.Add(colFornecedor);

            // Configuração geral do DataGridView
            dgvDados.AllowUserToAddRows = false;
            dgvDados.AllowUserToDeleteRows = false;
            dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDados.MultiSelect = false;
            dgvDados.EditMode = DataGridViewEditMode.EditOnEnter;
        }


        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pbVoltar_Click(object sender, EventArgs e)
        {
            // Retornar ao FormTelaPrincipal
            FormTelaPrincipal telaPrincipal = new FormTelaPrincipal();
            this.Hide();
            this.Close();
            telaPrincipal.Show();
        }

        private void txtProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (ID > 0)  // Verificar se há um código válido selecionado
            {
                // Confirmação de exclusão
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir este produto?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        // Criar objeto de negócio para eliminar o produto
                        DadosConexao cox = new DadosConexao(DConexao.StringConexao);
                        NegProduto negProduto = new NegProduto(cox);

                        // Chama o método de eliminação de produto
                        negProduto.Excluir(ID);

                        // Recarregar os produtos após a exclusão
                        CarregarProdutos();
                        MessageBox.Show("Produto excluído com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao excluir produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            // Verifique se uma linha foi selecionada no DataGridView
            try
            {

                var dProduto = new DProduto(new DadosConexao(DConexao.StringConexao));

                foreach (DataGridViewRow row in dgvDados.Rows)
                {
                    if (!row.IsNewRow) // Ignorar a linha nova
                    {
                        // Validação básica para evitar erros
                        if (row.Cells["ID"].Value == null || row.Cells["Nome"].Value == null ||
                            row.Cells["Descricao"].Value == null || row.Cells["Preco"].Value == null ||
                            row.Cells["Estoque"].Value == null || row.Cells["DataValidade"].Value == null)
                        {
                            continue; // Ignorar linhas com dados incompletos
                        }

                        ModeloProduto produto = new ModeloProduto
                        {
                            ID = Convert.ToInt32(row.Cells["ID"].Value),
                            NomeProduto = row.Cells["Nome"].Value.ToString(),
                            DescProduto = row.Cells["Descricao"].Value.ToString(),
                            PrecoProduto = Convert.ToDecimal(row.Cells["Preco"].Value),
                            QuantEstProduto = Convert.ToInt32(row.Cells["Estoque"].Value),
                            DataValida = Convert.ToDateTime(row.Cells["DataValidade"].Value)
                        };

                        // Atualizar no banco de dados
                        dProduto.Alterar(produto);

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

        private void dgvDados_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Destacar a célula editada
            dgvDados.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightYellow;
        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Liberar os botões de Alterar e Eliminar
            pnDados.Enabled = true;
            btnAlterar.Enabled = true;  // Habilitar o botão Alterar
            btnEliminar.Enabled = true;  // Habilitar o botão Eliminar
        }
    }

}