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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultarProduto));
            label1 = new Label();
            dgvDados = new DataGridView();
            btnLocalizar = new Button();
            txtProduto = new TextBox();
            label2 = new Label();
            pbVoltar = new PictureBox();
            pictureBox1 = new PictureBox();
            btnEliminar = new Button();
            btnAlterar = new Button();
            label3 = new Label();
            pnDados = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbVoltar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnDados.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold | FontStyle.Underline);
            label1.Location = new Point(203, 12);
            label1.Name = "label1";
            label1.Size = new Size(347, 30);
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
            dgvDados.Location = new Point(12, 162);
            dgvDados.Name = "dgvDados";
            dgvDados.RowHeadersWidth = 62;
            dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDados.Size = new Size(776, 566);
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
            btnLocalizar.Location = new Point(655, 124);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.Size = new Size(133, 32);
            btnLocalizar.TabIndex = 31;
            btnLocalizar.Text = "Localizar";
            btnLocalizar.UseVisualStyleBackColor = false;
            btnLocalizar.Click += btnLocalizar_Click;
            // 
            // txtProduto
            // 
            txtProduto.BackColor = SystemColors.Menu;
            txtProduto.Font = new Font("Century Schoolbook", 10F);
            txtProduto.Location = new Point(12, 124);
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(637, 32);
            txtProduto.TabIndex = 30;
            txtProduto.TextChanged += txtProduto_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            label2.Location = new Point(12, 96);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 29;
            label2.Text = "Produto";
            // 
            // pbVoltar
            // 
            pbVoltar.Image = (Image)resources.GetObject("pbVoltar.Image");
            pbVoltar.Location = new Point(12, 12);
            pbVoltar.Name = "pbVoltar";
            pbVoltar.Size = new Size(39, 35);
            pbVoltar.TabIndex = 33;
            pbVoltar.TabStop = false;
            pbVoltar.Click += pbVoltar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(709, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 79);
            pictureBox1.TabIndex = 54;
            pictureBox1.TabStop = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(389, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(380, 44);
            btnEliminar.TabIndex = 56;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.DarkSlateGray;
            btnAlterar.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlterar.Location = new Point(3, 3);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(380, 44);
            btnAlterar.TabIndex = 55;
            btnAlterar.Text = "ALTERAR";
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 5F, FontStyle.Bold);
            label3.Location = new Point(711, 96);
            label3.Name = "label3";
            label3.Size = new Size(77, 13);
            label3.TabIndex = 59;
            label3.Text = "New_Pharma";
            // 
            // pnDados
            // 
            pnDados.BorderStyle = BorderStyle.Fixed3D;
            pnDados.Controls.Add(btnAlterar);
            pnDados.Controls.Add(btnEliminar);
            pnDados.Location = new Point(12, 734);
            pnDados.Name = "pnDados";
            pnDados.Size = new Size(776, 54);
            pnDados.TabIndex = 60;
            // 
            // FormConsultarProduto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSpringGreen;
            ClientSize = new Size(800, 800);
            Controls.Add(pnDados);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(pbVoltar);
            Controls.Add(dgvDados);
            Controls.Add(btnLocalizar);
            Controls.Add(txtProduto);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormConsultarProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar Produto";
            Load += FormConsultarProduto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbVoltar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnDados.ResumeLayout(false);
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
        private PictureBox pictureBox1;
        private Button btnEliminar;
        private Button btnAlterar;
        private Label label3;
        private Panel pnDados;
    }
}