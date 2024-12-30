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
    }
}
