namespace Views
{
    partial class FormConsultarCategoria
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
            txtCategoria = new TextBox();
            btnLocalizar = new Button();
            dgvDados = new DataGridView();
            label2 = new Label();
            pbVoltar = new PictureBox();
            btnAlterar = new Button();
            btnEliminar = new Button();
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
            label1.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 79);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(81, 17);
            label1.TabIndex = 0;
            label1.Text = "Categoria";
            // 
            // txtCategoria
            // 
            txtCategoria.BackColor = SystemColors.Menu;
            txtCategoria.Font = new Font("Century Schoolbook", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCategoria.Location = new Point(7, 98);
            txtCategoria.Margin = new Padding(2);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(682, 24);
            txtCategoria.TabIndex = 1;
            txtCategoria.TextChanged += txtCategoria_TextChanged;
            // 
            // btnLocalizar
            // 
            btnLocalizar.BackColor = SystemColors.Menu;
            btnLocalizar.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLocalizar.Location = new Point(693, 98);
            btnLocalizar.Margin = new Padding(2);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.Size = new Size(93, 24);
            btnLocalizar.TabIndex = 2;
            btnLocalizar.Text = "Localizar";
            btnLocalizar.UseVisualStyleBackColor = false;
            btnLocalizar.Click += btnLocalizar_Click;
            // 
            // dgvDados
            // 
            dgvDados.AllowUserToAddRows = false;
            dgvDados.AllowUserToDeleteRows = false;
            dgvDados.BackgroundColor = SystemColors.Menu;
            dgvDados.BorderStyle = BorderStyle.Fixed3D;
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Location = new Point(7, 126);
            dgvDados.Margin = new Padding(2);
            dgvDados.Name = "dgvDados";
            dgvDados.RowHeadersWidth = 62;
            dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDados.Size = new Size(782, 620);
            dgvDados.TabIndex = 3;
            dgvDados.CellClick += dgvDados_CellClick;
            dgvDados.CellDoubleClick += dgvDados_CellDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 13F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(256, 11);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(282, 21);
            label2.TabIndex = 4;
            label2.Text = "CONSULTA DE CATEGORIA";
            // 
            // pbVoltar
            // 
            pbVoltar.Image = Properties.Resources.back_112351;
            pbVoltar.Location = new Point(8, 11);
            pbVoltar.Margin = new Padding(2);
            pbVoltar.Name = "pbVoltar";
            pbVoltar.Size = new Size(34, 29);
            pbVoltar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbVoltar.TabIndex = 35;
            pbVoltar.TabStop = false;
            pbVoltar.Click += pbVoltar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.DarkSlateGray;
            btnAlterar.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlterar.Location = new Point(8, 2);
            btnAlterar.Margin = new Padding(2);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(380, 30);
            btnAlterar.TabIndex = 55;
            btnAlterar.Text = "ALTERAR";
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(392, 2);
            btnEliminar.Margin = new Padding(2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(380, 30);
            btnEliminar.TabIndex = 56;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // pnDados
            // 
            pnDados.BorderStyle = BorderStyle.Fixed3D;
            pnDados.Controls.Add(btnAlterar);
            pnDados.Controls.Add(btnEliminar);
            pnDados.Location = new Point(7, 750);
            pnDados.Margin = new Padding(2);
            pnDados.Name = "pnDados";
            pnDados.Size = new Size(782, 39);
            pnDados.TabIndex = 62;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Schoolbook", 6F, FontStyle.Bold);
            label9.Location = new Point(719, 74);
            label9.Name = "label9";
            label9.Size = new Size(70, 12);
            label9.TabIndex = 65;
            label9.Text = "NEW_PHARMA";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.medicine_icon_icons_com_66070;
            pictureBox1.Location = new Point(717, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 64;
            pictureBox1.TabStop = false;
            // 
            // FormConsultarCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSpringGreen;
            ClientSize = new Size(800, 800);
            Controls.Add(label9);
            Controls.Add(pictureBox1);
            Controls.Add(pnDados);
            Controls.Add(pbVoltar);
            Controls.Add(label2);
            Controls.Add(dgvDados);
            Controls.Add(btnLocalizar);
            Controls.Add(txtCategoria);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FormConsultarCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar Categoria";
            Load += FormConsultarCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbVoltar).EndInit();
            pnDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCategoria;
        private Button btnLocalizar;
        private DataGridView dgvDados;
        private Label label2;
        private PictureBox pbVoltar;
        private Button btnAlterar;
        private Button btnEliminar;
        private Panel pnDados;
        private Label label9;
        private PictureBox pictureBox1;
    }
}