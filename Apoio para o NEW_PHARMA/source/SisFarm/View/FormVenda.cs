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

namespace View
{
    public partial class FormVenda : Form
    {
        private VendaBLL vendaBLL = new VendaBLL();
        private ProdutoBLL produtoBLL = new ProdutoBLL();
        private ClienteBLL clienteBLL = new ClienteBLL();

        private DataTable itensVenda = new DataTable(); // Tabela temporária para armazenar os itens da venda
        private decimal totalVenda = 0;
        public FormVenda()
        {
            InitializeComponent();
            InicializarTabelaItensVenda();
            CarregarClientes();
            CarregarProdutos();
        }
        private void InicializarTabelaItensVenda()
        {
            itensVenda.Columns.Add("ProdutoID", typeof(int));
            itensVenda.Columns.Add("Produto", typeof(string));
            itensVenda.Columns.Add("Quantidade", typeof(int));
            itensVenda.Columns.Add("Preço Unitário", typeof(decimal));
            itensVenda.Columns.Add("Total", typeof(decimal));
            dgvItensVenda.DataSource = itensVenda; // Vincular a tabela ao DataGridView
        }

        private void CarregarClientes()
        {
            // Carrega os clientes no ComboBox
            DataTable clientes = clienteBLL.ListarClientes();
            cmbClientes.DataSource = clientes;
            cmbClientes.DisplayMember = "Nome";
            cmbClientes.ValueMember = "ClienteID";
        }

        private void CarregarProdutos()
        {
            // Carrega os produtos no ComboBox
            DataTable produtos = produtoBLL.ListarProdutos();
            cmbProdutos.DataSource = produtos;
            cmbProdutos.DisplayMember = "Nome";
            cmbProdutos.ValueMember = "ProdutoID";
        }

        private void AtualizarTotal()
        {
            // Calcula o total da venda
            totalVenda = itensVenda.AsEnumerable().Sum(row => row.Field<decimal>("Total"));

            // Define o formato de moeda para Angola (Kwanza)
            var culturaAngola = new System.Globalization.CultureInfo("pt-AO");
            culturaAngola.NumberFormat.CurrencySymbol = "Kz";

            // Atualiza o texto do rótulo com o total formatado
            lblTotalVenda.Text = $"Total: {totalVenda.ToString("C", culturaAngola)}";
        }


        private void AdicionarItem()
        {
            if (cmbProdutos.SelectedValue == null || !int.TryParse(txtQuantidade.Text, out int quantidade) || quantidade <= 0)
            {
                MessageBox.Show("Selecione um produto válido e insira uma quantidade maior que zero.");
                return;
            }

            int produtoId = (int)cmbProdutos.SelectedValue;
            string produtoNome = cmbProdutos.Text;
            decimal precoUnitario = ObterPrecoProduto(produtoId);
            decimal totalItem = quantidade * precoUnitario;

            // Adicionar item à tabela de itens
            itensVenda.Rows.Add(produtoId, produtoNome, quantidade, precoUnitario, totalItem);

            // Atualizar o total da venda
            totalVenda += totalItem;

            // Define o formato de moeda para Angola (Kwanza)
            var culturaAngola = new System.Globalization.CultureInfo("pt-AO");
            culturaAngola.NumberFormat.CurrencySymbol = "Kz";

            // Atualiza o texto do rótulo com o total formatado
            lblTotalVenda.Text = $"Total: {totalVenda.ToString("C", culturaAngola)}";
        }
        private decimal ObterPrecoProduto(int produtoId)
        {
            DataTable produto = produtoBLL.BuscarProdutoPorID(produtoId);
            if (produto.Rows.Count > 0)
                return Convert.ToDecimal(produto.Rows[0]["Preco"]);
            return 0;
        }

        private void ConcluiVenda()
        {
            if (cmbClientes.SelectedValue == null)
            {
                MessageBox.Show("Selecione um cliente para finalizar a venda.");
                return;
            }

            if (itensVenda.Rows.Count == 0)
            {
                MessageBox.Show("Adicione ao menos um item à venda.");
                return;
            }

            try
            {
                // Registrar a venda com o status "Finalizada"
                int clienteId = (int)cmbClientes.SelectedValue;
                int vendaId = vendaBLL.RegistrarVenda(clienteId, totalVenda, "Finalizada"); // Status "Finalizada"

                // Registrar os detalhes da venda
                foreach (DataRow row in itensVenda.Rows)
                {
                    int produtoId = (int)row["ProdutoID"];
                    int quantidade = (int)row["Quantidade"];
                    decimal precoUnitario = (decimal)row["Preço Unitário"];
                    decimal totalItem = (decimal)row["Total"];

                    vendaBLL.RegistrarDetalhesVenda(vendaId, produtoId, quantidade, precoUnitario, totalItem);
                }

                MessageBox.Show("Venda registrada com sucesso!");
                LimparFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao finalizar a venda: {ex.Message}");
            }
        }


        private void LimparFormulario()
        {
            cmbClientes.SelectedIndex = -1;
            cmbProdutos.SelectedIndex = -1;
            txtQuantidade.Clear();
            itensVenda.Clear();
            totalVenda = 0;
            lblTotalVenda.Text = "Total: R$ 0,00";
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            AdicionarItem();
        }

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            ConcluiVenda();
        }
    }
}
