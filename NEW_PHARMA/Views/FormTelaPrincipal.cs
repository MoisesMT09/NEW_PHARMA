using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FormTelaPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
