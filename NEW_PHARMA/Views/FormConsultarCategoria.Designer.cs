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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultarCategoria));
            label1 = new Label();
            txtForncedor = new TextBox();
            btnLocalizar = new Button();
            dgvDados = new DataGridView();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 58);
            label1.Name = "label1";
            label1.Size = new Size(102, 21);
            label1.TabIndex = 0;
            label1.Text = "Categoria";
            // 
            // txtForncedor
            // 
            txtForncedor.Font = new Font("Century Schoolbook", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtForncedor.Location = new Point(12, 86);
            txtForncedor.Name = "txtForncedor";
            txtForncedor.Size = new Size(591, 29);
            txtForncedor.TabIndex = 1;
            txtForncedor.TextChanged += txtCategoria_TextChanged;
            // 
            // btnLocalizar
            // 
            btnLocalizar.Font = new Font("Century Schoolbook", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLocalizar.Location = new Point(609, 84);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.Size = new Size(157, 34);
            btnLocalizar.TabIndex = 2;
            btnLocalizar.Text = "Localizar";
            btnLocalizar.UseVisualStyleBackColor = true;
            btnLocalizar.Click += btnLocalizar_Click;
            // 
            // dgvDados
            // 
            dgvDados.AllowUserToAddRows = false;
            dgvDados.AllowUserToDeleteRows = false;
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Location = new Point(12, 134);
            dgvDados.Name = "dgvDados";
            dgvDados.ReadOnly = true;
            dgvDados.RowHeadersWidth = 62;
            dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDados.Size = new Size(754, 398);
            dgvDados.TabIndex = 3;
            dgvDados.CellContentClick += dgvDados_CellContentClick;
            dgvDados.CellDoubleClick += dgvDados_CellDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 10F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(249, 19);
            label2.Name = "label2";
            label2.Size = new Size(290, 23);
            label2.TabIndex = 4;
            label2.Text = "CONSULTA DE CATEGORIA";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Red;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(733, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 33);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FormConsultarCategoria
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 544);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(dgvDados);
            Controls.Add(btnLocalizar);
            Controls.Add(txtForncedor);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormConsultarCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar Categoria";
            Load += FormConsultarCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtForncedor;
        private Button btnLocalizar;
        private DataGridView dgvDados;
        private Label label2;
        private PictureBox pictureBox1;
    }
}