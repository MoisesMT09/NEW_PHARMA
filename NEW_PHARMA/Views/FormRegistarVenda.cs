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
    public partial class FormRegistarVenda : Form
    {
        public FormRegistarVenda()
        {
            InitializeComponent();
        }

        private void ConfigurarEstadoBotoes(bool inserindoOuEditando)
        {
            // Painel de Dados
            pnDados.Enabled = inserindoOuEditando; // Habilita ou desabilita os campos do formulário.

            // Botões de Controle
            btnInserir.Enabled = !inserindoOuEditando; // Habilita botão Inserir apenas quando não está editando
            btnSalvar.Enabled = inserindoOuEditando; // Salvar ativo apenas em edição/inserção.
            btnCancelar.Enabled = inserindoOuEditando; // Cancelar ativo em edição/inserção.
        }


        private void FormRegistarVenda_Load(object sender, EventArgs e)
        {
            //CarregarProdutos();
        }

        //private void CarregarProdutos()
        //{
        //    NegProduto nProduto = new NegProduto();
        //    DataTable produtos = nProduto.ObterTodosProdutos();

        //    chtxtProduto.Items.Clear();
        //    foreach (DataRow row in produtos.Rows)
        //    {
        //        chtxtProduto.Items.Add($"{row["ProdutoID"]} - {row["Nome"]}");
        //    }
        //}

        private void LimparCampos()
        {
            txtValorTotal.Clear();
            cmbClientes.SelectedIndex = -1; // Limpa seleção do ComboBox de clientes.
            dtpData.Value = DateTime.Now; // Reseta a data para hoje.
        }


        private void SalvarVenda()
        {
            try
            {
                // Criação do modelo da venda
                ModeloVenda modelo = new ModeloVenda
                {
                    DataVenda = dtpData.Value,
                    ClienteID = Convert.ToInt32(cmbClientes.SelectedValue),
                    ValorTotal = Convert.ToDecimal(txtValorTotal.Text),
                    FuncionarioID = Convert.ToInt32(cmbClientes.SelectedValue) // Atualize conforme necessário
                };

                // Chama a camada de negócio
                NegVenda negocio = new NegVenda(new DadosConexao("<sua_string_de_conexão>"));

                if (modelo.VendaID == 0)
                {
                    // Inserção
                    negocio.Incluir(modelo);
                    MessageBox.Show("Venda cadastrada com sucesso!");
                }
                else
                {
                    // Atualização
                    negocio.Alterar(modelo);
                    MessageBox.Show("Venda alterada com sucesso!");
                }

                // Atualiza a tela e retorna ao estado padrão
                ConfigurarEstadoBotoes(false);
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar: {ex.Message}");
            }
        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chtxtProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

            LimparCampos(); // Limpa os campos para uma nova inserção.
            ConfigurarEstadoBotoes(true); // Entra no modo de inserção.
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            ConfigurarEstadoBotoes(true); // Habilita edição dos campos.
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validações básicas.
                if (cmbClientes.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecione um cliente e um produto.");
                    return;
                }

                // Chama lógica para salvar dados (inserir ou atualizar).
                SalvarVenda();

                ConfigurarEstadoBotoes(false); // Retorna ao modo de visualização.
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar: {ex.Message}");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ConfigurarEstadoBotoes(false); // Retorna ao estado padrão (visualização).
        }

        private void pbVoltar_Click(object sender, EventArgs e)
        {
            // Retornar ao FormTelaPrincipal
            FormTelaPrincipal telaPrincipal = new FormTelaPrincipal();
            this.Hide();
            telaPrincipal.Show();
            this.Close();
        }

        private void dtpData_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}



