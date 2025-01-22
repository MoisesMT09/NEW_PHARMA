namespace Views
{
    partial class FormConsultarProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dgvDados = new DataGridView();
            btnLocalizar = new Button();
            txtProduto = new TextBox();
            label2 = new Label();
            pbVoltar = new PictureBox();
            btnEliminar = new Button();
            btnAlterar = new Button();
            pnDados = new Panel();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbVoltar).BeginInit();
            pnDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 13F, FontStyle.Bold | FontStyle.Underline);
            label1.Location = new Point(267, 16);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(262, 21);
            label1.TabIndex = 0;
            label1.Text = "CONSULTA DE PRODUTO";
            // 
            // dgvDados
            // 
            dgvDados.AllowUserToAddRows = false;
            dgvDados.AllowUserToDeleteRows = false;
            dgvDados.BackgroundColor = SystemColors.Menu;
            dgvDados.BorderStyle = BorderStyle.Fixed3D;
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Location = new Point(11, 142);
            dgvDados.Margin = new Padding(2);
            dgvDados.Name = "dgvDados";
            dgvDados.RowHeadersWidth = 62;
            dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDados.Size = new Size(781, 601);
            dgvDados.TabIndex = 32;
            dgvDados.CellClick += dgvDados_CellClick;
            dgvDados.CellContentClick += dgvDados_CellContentClick;
            dgvDados.CellDoubleClick += dgvDados_CellDoubleClick;
            dgvDados.CellEndEdit += dgvDados_CellEndEdit;
            // 
            // btnLocalizar
            // 
            btnLocalizar.BackColor = SystemColors.Menu;
            btnLocalizar.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            btnLocalizar.Location = new Point(696, 96);
            btnLocalizar.Margin = new Padding(2);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.Size = new Size(93, 24);
            btnLocalizar.TabIndex = 31;
            btnLocalizar.Text = "Localizar";
            btnLocalizar.UseVisualStyleBackColor = false;
            btnLocalizar.Click += btnLocalizar_Click;
            // 
            // txtProduto
            // 
            txtProduto.BackColor = SystemColors.Menu;
            txtProduto.Font = new Font("Century Schoolbook", 10F);
            txtProduto.Location = new Point(8, 96);
            txtProduto.Margin = new Padding(2);
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(684, 24);
            txtProduto.TabIndex = 30;
            txtProduto.TextChanged += txtProduto_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            label2.Location = new Point(8, 77);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 17);
            label2.TabIndex = 29;
            label2.Text = "Produto";
            // 
            // pbVoltar
            // 
            pbVoltar.Image = Properties.Resources.back_112351;
            pbVoltar.Location = new Point(8, 11);
            pbVoltar.Margin = new Padding(2);
            pbVoltar.Name = "pbVoltar";
            pbVoltar.Size = new Size(33, 28);
            pbVoltar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbVoltar.TabIndex = 33;
            pbVoltar.TabStop = false;
            pbVoltar.Click += pbVoltar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(386, 2);
            btnEliminar.Margin = new Padding(2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(380, 30);
            btnEliminar.TabIndex = 56;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.DarkSlateGray;
            btnAlterar.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlterar.Location = new Point(2, 2);
            btnAlterar.Margin = new Padding(2);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(380, 30);
            btnAlterar.TabIndex = 55;
            btnAlterar.Text = "ALTERAR";
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // pnDados
            // 
            pnDados.BorderStyle = BorderStyle.Fixed3D;
            pnDados.Controls.Add(btnAlterar);
            pnDados.Controls.Add(btnEliminar);
            pnDados.Location = new Point(11, 747);
            pnDados.Margin = new Padding(2);
            pnDados.Name = "pnDados";
            pnDados.Size = new Size(778, 42);
            pnDados.TabIndex = 60;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Schoolbook", 6F, FontStyle.Bold);
            label9.Location = new Point(718, 74);
            label9.Name = "label9";
            label9.Size = new Size(70, 12);
            label9.TabIndex = 62;
            label9.Text = "NEW_PHARMA";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.medicine_icon_icons_com_66070;
            pictureBox1.Location = new Point(716, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 61;
            pictureBox1.TabStop = false;
            // 
            // FormConsultarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSpringGreen;
            ClientSize = new Size(800, 800);
            Controls.Add(label9);
            Controls.Add(pictureBox1);
            Controls.Add(pnDados);
            Controls.Add(pbVoltar);
            Controls.Add(dgvDados);
            Controls.Add(btnLocalizar);
            Controls.Add(txtProduto);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FormConsultarProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar Produto";
            Load += FormConsultarProduto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbVoltar).EndInit();
            pnDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvDados;
        private Button btnLocalizar;
        private TextBox txtProduto;
        private Label label2;
        private PictureBox pbVoltar;
        private Button btnEliminar;
        private Button btnAlterar;
        private Panel pnDados;
        private Label label9;
        private PictureBox pictureBox1;
    }
}