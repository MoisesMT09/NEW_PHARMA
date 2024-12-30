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

namespace Views
{
    public partial class FormConsultarCategoria : Form
    {
        public int Codigo = 0;

        public FormConsultarCategoria()
        {
            InitializeComponent();
        }

        private void FormConsultarCategoria_Load(object sender, EventArgs e)
        {
            btnLocalizar_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 100;
            dgvDados.Columns[1].HeaderText = "Categoria";
            dgvDados.Columns[1].Width = 700;
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            DadosConexao cox = new DadosConexao(DConexao.StringConexao);
            NegCategoria negCateg = new NegCategoria(cox);
            dgvDados.DataSource = negCateg.Localizar(txtCategoria.Text);
        }

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                this.Codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
