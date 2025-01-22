using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class FormTelaPrincipal : Form
    {
        public FormTelaPrincipal()
        {
            InitializeComponent();
        }

        private void FormTelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void CATEGORIAItem_Click(object sender, EventArgs e)
        {
            FormCadastroDeCategoria formCadDeCateg = new FormCadastroDeCategoria();
            formCadDeCateg.ShowDialog();
            formCadDeCateg.Dispose();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultarCategoria consultarCategoria = new FormConsultarCategoria();
            consultarCategoria.ShowDialog();
            consultarCategoria.Dispose();
        }

        private void fORNECEDORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormCadastroDeFornecedor cadastroFornecedor = new FormCadastroDeFornecedor())
            {
                cadastroFornecedor.ShowDialog();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ptInicial_Click(object sender, EventArgs e)
        {

            // Ocultar o formulário atual
            //this.Hide();

            // Instanciar o formulário de apresentação (se necessário)
            FormTelaDeApresentacao telaApresentacao = new FormTelaDeApresentacao();

            // Exibir o formulário de apresentação
            telaApresentacao.Show();

            // Opcional: Fechar o formulário atual ao voltar à tela inicial
            this.Close();
        }

        private void rEGISTRARVENDASToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pRODUTOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (FormConsultarProduto consultarProduto = new FormConsultarProduto())
            {

                consultarProduto.ShowDialog();
            }
        }


        private void cLIENTEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (FormConsultarCliente ConsultarCliente = new FormConsultarCliente())
            {
                ConsultarCliente.ShowDialog();
            }
        }

        private void pRODUTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormCadastroDeProduto cadastroDeProduto = new FormCadastroDeProduto())
            {
                cadastroDeProduto.ShowDialog();
            }
        }


        private void cLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormCadastroDeCliente cadastroDeCliente = new FormCadastroDeCliente())
            {
                cadastroDeCliente.ShowDialog();
            }
        }

        private void vENDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormRegistarVenda registarvendaproduto = new FormRegistarVenda())
            {
                registarvendaproduto.ShowDialog();
            }
        }
    }
}
