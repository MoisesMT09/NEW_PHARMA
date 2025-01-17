using Guna.UI2.WinForms;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class formProduto : Form
    {

        private ProdutoBLL produtoBLL = new ProdutoBLL();
        private CategoriaBLL categoriaBLL = new CategoriaBLL();
        private FornecedorBLL fornecedorBLL = new FornecedorBLL();
        private bool Editar = false;
        public formProduto()
        {
            InitializeComponent();
        }

        private void AtualizarGrid()
        {
            dgvProdutos.DataSource = produtoBLL.ListarProdutos();
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtDescricao.Clear();
            txtEstoque.Clear();
            txtPreco.Clear();
        }

        private void formProduto_Load(object sender, EventArgs e)
        {
            // Preenche o DataGridView de produtos
            dgvProdutos.DataSource = produtoBLL.ListarProdutos();

            // Preenche o ComboBox de categorias
            PreencherComboBoxCategoria();

            // Preenche o ComboBox de fornecedores
            PreencherComboBoxFornecedor();
        }

        private void OcultarPainel()
        {
            if (guna2PanelNovoRegisto.Height >= 610)
            {
                guna2PanelNovoRegisto.Height = 10;
            }
            else if (guna2PanelNovoRegisto.Height <= 10)
            {
                guna2PanelNovoRegisto.Height = 610;
            }
        }

        private void MostrarPainelAddNovaCategoria()
        {
            if (guna2PanelCategoriaSatutus.Width >= 284)
            {
                guna2PanelCategoriaSatutus.Width = 1;
                guna2PanelAddCategoria.Width = 284;
            }
            else if (guna2PanelCategoriaSatutus.Width <= 284)
            {
                guna2PanelCategoriaSatutus.Width = 284;
                guna2PanelAddCategoria.Width = ~1;
            }
        }

        private void OcultarPainelAddNovaCategoria()
        {
            if (guna2PanelAddCategoria.Width >= 284)
            {
                guna2PanelAddCategoria.Width = 1;
                guna2PanelCategoriaSatutus.Width = 284;
            }
        }
        private void MostrarPainel()
        {
            if (guna2PanelNovoRegisto.Height <= 10)
            {
                guna2PanelNovoRegisto.Height = 610;
            }
            else if (guna2PanelNovoRegisto.Height >= 610)
            {
                guna2PanelNovoRegisto.Height = 10;
            }
        }
        private void btnCriarNovoProduto_Click(object sender, EventArgs e)
        {
            MostrarPainel();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            OcultarPainel();
        }

        private void btnSalvarNovoProduto_Click(object sender, EventArgs e)
        {
            if (!Validar())
                return;

            btnSalvarNovoProduto.Enabled = false;

            try
            {
                if (Editar == false)
                {
                    SalvarProduto();
                    MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    AtualizarProduto();
                    MessageBox.Show("Produto atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                AtualizarGrid();
                LimparCampos();
                OcultarPainel();
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Erro de formatação: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Editar = false;
                btnSalvarNovoProduto.Enabled = true;
            }
        }

        private void SalvarProduto()
        {
            string nome = txtNome.Text.Trim();
            int categoriaId = int.Parse(cbCategoria.SelectedValue.ToString()); // CategoriaID
            int fornecedorId = int.Parse(cbFornecedor.SelectedValue.ToString()); // FornecedorID
            string descricao = txtDescricao.Text.Trim();
            decimal preco = decimal.Parse(txtPreco.Text);
            DateTime dataValidade = dtpPrazo.Value;
            int quantidade = int.Parse(txtEstoque.Text);
            string status = cbStatusAdd.SelectedItem.ToString(); // "Ativo", "Inativo" ou "Esgotado"
            Console.Write(status);
            MessageBox.Show(status);

            produtoBLL.InserirProduto(nome, categoriaId, descricao, preco, dataValidade, quantidade, status, fornecedorId);
        }


        private void AtualizarProduto()
        {
            int id = int.Parse(dgvProdutos.CurrentRow.Cells["ProdutoID"].Value.ToString()); // ProdutoID
            string nome = txtNome.Text.Trim();
            int categoriaId = int.Parse(cbCategoria.SelectedValue.ToString()); // CategoriaID
            int fornecedorId = int.Parse(cbFornecedor.SelectedValue.ToString()); // FornecedorID
            string descricao = txtDescricao.Text.Trim();
            decimal preco = decimal.Parse(txtPreco.Text);
            DateTime prazo = dtpPrazo.Value;
            int estoque = int.Parse(txtEstoque.Text);
            string status = cbStatus.SelectedItem.ToString(); // "Ativo", "Inativo" ou "Esgotado"

            produtoBLL.AtualizarProduto(id, nome, categoriaId, descricao, preco, prazo, estoque, status, fornecedorId);
        }


        private void PreencherComboBoxCategoria()
        {
            // Crie uma instância do CategoriaBLL e busque as categorias
            var categorias = categoriaBLL.ListarCategorias();

            // Crie um DataTable para armazenar as categorias
            DataTable categoriasComPadrao = new DataTable();
            categoriasComPadrao.Columns.Add("CategoriaID", typeof(int));
            categoriasComPadrao.Columns.Add("Nome", typeof(string));

            // Adicione o item padrão "Buscar por categoria"
            categoriasComPadrao.Rows.Add(0, "Buscar por categoria");

            // Adicione as categorias reais
            foreach (var categoria in categorias)
            {
                categoriasComPadrao.Rows.Add(categoria.CategoriaID, categoria.Nome);
            }

            // Preenche o ComboBox com as categorias para busca em filtro
            cbCategoriaBusca.DataSource = categoriasComPadrao;
            cbCategoriaBusca.DisplayMember = "Nome"; // Exibe o nome da categoria
            cbCategoriaBusca.ValueMember = "CategoriaID"; // Usa o CategoriaID como valor

            // Preenche o ComboBox com as categorias para busca em filtro
            cbCategoria.DataSource = categoriasComPadrao;
            cbCategoria.DisplayMember = "Nome"; // Exibe o nome da categoria
            cbCategoria.ValueMember = "CategoriaID"; // Usa o CategoriaID como valor
        }

        private void PreencherComboBoxFornecedor()
        {
            // Supondo que o FornecedorBLL tem um método ListarFornecedores
            var fornecedores = fornecedorBLL.ListarFornecedores();

            // Preenche o ComboBox com os fornecedores
            cbFornecedor.DataSource = fornecedores;
            cbFornecedor.DisplayMember = "Nome"; // Exibe o nome do fornecedor
            cbFornecedor.ValueMember = "FornecedorID"; // Usa o FornecedorID como valor
        }


        private bool Validar()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("O campo Nome é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return false;
            }

            if (cbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("O campo Categoria é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbCategoria.Focus();
                return false;
            }


            if (!decimal.TryParse(txtPreco.Text, out decimal preco) || preco <= 0)
            {
                MessageBox.Show("Preço inválido. Insira um valor numérico positivo.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPreco.Focus();
                return false;
            }

            if (!int.TryParse(txtEstoque.Text, out int estoque) || estoque < 0)
            {
                MessageBox.Show("Estoque inválido. Insira um valor numérico não negativo.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEstoque.Focus();
                return false;
            }

            return true;
        }
        //  método para exibir mensagens personalizadas.
        private void ExibirMensagem(string mensagem, string titulo, MessageBoxIcon icone)
        {
            MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, icone);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja editar os dados selecionados?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (dgvProdutos.SelectedRows.Count > 0)
                {

                    Editar = true;
                    //Preenchendo os campos para editar
                    txtNome.Text = dgvProdutos.CurrentRow.Cells[1].Value.ToString();
                    txtDescricao.Text = dgvProdutos.CurrentRow.Cells[2].Value.ToString();
                    txtPreco.Text = dgvProdutos.CurrentRow.Cells[3].Value.ToString();
                    txtEstoque.Text = dgvProdutos.CurrentRow.Cells[4].Value.ToString();
                    //Gerenciando paines
                    if (guna2PanelNovoRegisto.Height <= 10)
                    {
                        guna2PanelNovoRegisto.Height = 610;
                    }
                    else
                    if (guna2PanelNovoRegisto.Height >= 610)
                    {
                        guna2PanelNovoRegisto.Height = 10;
                    }
                    //Mudando a label
                    lblTitleEditarNovo.Text = "Editar Produto";
                }
                else
                    MessageBox.Show("Seleciona fila");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja eliminar o produto selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (dgvProdutos.SelectedRows.Count > 0)
                {
                    try
                    {
                        // Obtenha o ID do produto da linha selecionada
                        int id = int.Parse(dgvProdutos.CurrentRow.Cells["ProdutoID"].Value.ToString());

                        // Exclua o produto
                        produtoBLL.DeletarProduto(id);

                        MessageBox.Show("Produto eliminado com sucesso!");

                        // Atualize o DataGridView
                        AtualizarGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao eliminar o produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecione um produto para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string nome = txtBuscar.Text.Trim();
            dgvProdutos.DataSource = produtoBLL.BuscarPorNome(nome);
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string status = cbStatus.SelectedItem.ToString(); // "Ativo", "Inativo" ou "Esgotado"
            dgvProdutos.DataSource = produtoBLL.BuscarPorStatus(status);
        }

        private void cbCategoriaBusca_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifique se uma categoria válida foi selecionada
            if (cbCategoriaBusca.SelectedValue != null &&
                int.TryParse(cbCategoriaBusca.SelectedValue.ToString(), out int categoriaId) &&
                categoriaId != 0) // Ignora o item "Buscar por categoria" (ID = 0)
            {
                dgvProdutos.DataSource = produtoBLL.BuscarPorCategoria(categoriaId);
            }
            else
            {
                // Caso o item padrão esteja selecionado, limpe a exibição
                dgvProdutos.DataSource = null;
            }
        }

        private void cbEstoque_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoEstoque = cbEstoque.SelectedItem.ToString(); // O tipo de estoque selecionado
            dgvProdutos.DataSource = produtoBLL.BuscarPorEstoque(tipoEstoque); // Chama a busca com tipo de estoque
        }

        private void btnSalvarCategoria_Click(object sender, EventArgs e)
        {
            string nomeCategoria = txtNomeCategoria.Text.Trim();
            //string descricao = txtDescricao.Text.Trim();

            if (string.IsNullOrEmpty(nomeCategoria))
            {
                MessageBox.Show("O nome da categoria é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                CategoriaBLL categoriaBLL = new CategoriaBLL();
                categoriaBLL.InserirCategoria(nomeCategoria);

                MessageBox.Show("Categoria salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Atualize o ComboBox de categorias
                PreencherComboBoxCategoria();
                OcultarPainelAddNovaCategoria();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar categoria: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFecharPanelAddCategoria_Click(object sender, EventArgs e)
        {
            OcultarPainelAddNovaCategoria();
        }

        private void btnAddCategoria_Click(object sender, EventArgs e)
        {
            MostrarPainelAddNovaCategoria();
        }
    }
}
