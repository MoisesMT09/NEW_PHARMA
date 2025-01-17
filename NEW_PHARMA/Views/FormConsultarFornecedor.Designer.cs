namespace Views
{
    partial class FormConsultarFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultarFornecedor));
            label1 = new Label();
            dgvDados = new DataGridView();
            btnLocalizar = new Button();
            txtFornecedor = new TextBox();
            label2 = new Label();
            pbVoltar = new PictureBox();
            btnEliminar = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbVoltar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold | FontStyle.Underline);
            label1.Location = new Point(185, 15);
            label1.Name = "label1";
            label1.Size = new Size(404, 30);
            label1.TabIndex = 0;
            label1.Text = "CONSULTA DE FORNECEDOR";
            // 
            // dgvDados
            // 
            dgvDados.AllowUserToAddRows = false;
            dgvDados.AllowUserToDeleteRows = false;
            dgvDados.BackgroundColor = SystemColors.Menu;
            dgvDados.BorderStyle = BorderStyle.Fixed3D;
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Location = new Point(12, 164);
            dgvDados.Name = "dgvDados";
            dgvDados.ReadOnly = true;
            dgvDados.RowHeadersWidth = 62;
            dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDados.Size = new Size(776, 578);
            dgvDados.TabIndex = 28;
            dgvDados.CellContentClick += dgvDados_CellContentClick;
            dgvDados.CellContentDoubleClick += dgvDados_CellContentDoubleClick;
            dgvDados.CellDoubleClick += dgvDados_CellDoubleClick;
            // 
            // btnLocalizar
            // 
            btnLocalizar.BackColor = SystemColors.Menu;
            btnLocalizar.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            btnLocalizar.Location = new Point(655, 124);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.Size = new Size(133, 32);
            btnLocalizar.TabIndex = 27;
            btnLocalizar.Text = "Localizar";
            btnLocalizar.UseVisualStyleBackColor = false;
            btnLocalizar.Click += btnLocalizar_Click;
            // 
            // txtFornecedor
            // 
            txtFornecedor.BackColor = SystemColors.Menu;
            txtFornecedor.Font = new Font("Century Schoolbook", 10F);
            txtFornecedor.Location = new Point(12, 126);
            txtFornecedor.Name = "txtFornecedor";
            txtFornecedor.Size = new Size(637, 32);
            txtFornecedor.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            label2.Location = new Point(12, 98);
            label2.Name = "label2";
            label2.Size = new Size(130, 25);
            label2.TabIndex = 25;
            label2.Text = "Fornecedor";
            // 
            // pbVoltar
            // 
            pbVoltar.Image = (Image)resources.GetObject("pbVoltar.Image");
            pbVoltar.Location = new Point(12, 15);
            pbVoltar.Name = "pbVoltar";
            pbVoltar.Size = new Size(39, 35);
            pbVoltar.TabIndex = 34;
            pbVoltar.TabStop = false;
            pbVoltar.Click += pbVoltar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(403, 748);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(385, 40);
            btnEliminar.TabIndex = 52;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 748);
            button1.Name = "button1";
            button1.Size = new Size(385, 40);
            button1.TabIndex = 51;
            button1.Text = "ALTERAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(709, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 79);
            pictureBox1.TabIndex = 53;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 5F, FontStyle.Bold);
            label3.Location = new Point(711, 97);
            label3.Name = "label3";
            label3.Size = new Size(77, 13);
            label3.TabIndex = 59;
            label3.Text = "New_Pharma";
            // 
            // FormConsultarFornecedor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSpringGreen;
            ClientSize = new Size(800, 800);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(btnEliminar);
            Controls.Add(button1);
            Controls.Add(pbVoltar);
            Controls.Add(dgvDados);
            Controls.Add(btnLocalizar);
            Controls.Add(txtFornecedor);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormConsultarFornecedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormConsultarFornecedor";
            Load += FormConsultarFornecedor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbVoltar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvDados;
        private Button btnLocalizar;
        private TextBox txtFornecedor;
        private Label label2;
        private PictureBox pbVoltar;
        private Button btnEliminar;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label3;
    }
}