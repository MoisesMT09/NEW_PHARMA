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
    public partial class FormTelaDeApresentacao : Form
    {
        public FormTelaDeApresentacao()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ocultar o formulário atual
            this.Hide();

            // Instanciar o formulário principal
            FormLogin teladelogin = new FormLogin();

            // Exibir o formulário principal
            teladelogin.Show();

            // Opcional: Fechar o formulário atual ao ir para a tela principal
            // this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
