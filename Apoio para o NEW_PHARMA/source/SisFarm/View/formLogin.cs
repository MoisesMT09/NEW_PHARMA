using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Negocio;

namespace View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                msgError("Por favor digite o nome.");
            }
            else if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                msgError("Por favor digite a password.");
            }
            else
            {
                UserNegocio user = new UserNegocio();
                bool loginValid = user.LoginUser(textBox1.Text, textBox2.Text);

                if (loginValid)
                {
                    formHome home = new formHome();
                    MessageBox.Show("Bem-vindo/a");
                    home.Show();
                    //formHome.form += Logout;
                    this.Hide();
                }
                else
                {
                    msgError("username ou password incorreta. \nPor favor tente novamente.");
                    textBox2.Clear();
                    textBox2.UseSystemPasswordChar = true;
                    textBox1.Focus();
                }
            }

        }

        private void msgError(string msg)
        {
            label1.Text = "   " + msg;
            label1.Visible = true;
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            textBox2.Text = "Password";
            textBox2.UseSystemPasswordChar = false;
            textBox1.Text = "Username";
            label1.Visible = false;
            this.Show();
        }
    }
}
