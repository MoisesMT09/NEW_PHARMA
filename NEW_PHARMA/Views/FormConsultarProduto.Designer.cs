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
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbVoltar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(270, 22);
            label1.Name = "label1";
            label1.Size = new Size(292, 25);
            label1.TabIndex = 0;
            label1.Text = "CONSULTA DE PRODUTO";
            // 
            // dgvDados
            // 
            dgvDados.AllowUserToAddRows = false;
            dgvDados.AllowUserToDeleteRows = false;
            dgvDados.BackgroundColor = Color.Cyan;
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Location = new Point(23, 139);
            dgvDados.Name = "dgvDados";
            dgvDados.ReadOnly = true;
            dgvDados.RowHeadersWidth = 62;
            dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDados.Size = new Size(754, 449);
            dgvDados.TabIndex = 32;
            dgvDados.CellContentClick += dgvDados_CellContentClick;
            dgvDados.CellDoubleClick += dgvDados_CellDoubleClick;
            // 
            // btnLocalizar
            // 
            btnLocalizar.Font = new Font("Century Schoolbook", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLocalizar.Location = new Point(620, 91);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.Size = new Size(157, 29);
            btnLocalizar.TabIndex = 31;
            btnLocalizar.Text = "Localizar";
            btnLocalizar.UseVisualStyleBackColor = true;
            btnLocalizar.Click += btnLocalizar_Click;
            // 
            // txtProduto
            // 
            txtProduto.Font = new Font("Century Schoolbook", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProduto.Location = new Point(23, 91);
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(591, 29);
            txtProduto.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 63);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 29;
            label2.Text = "Produto";
            // 
            // pbVoltar
            // 
            pbVoltar.Image = (Image)resources.GetObject("pbVoltar.Image");
            pbVoltar.Location = new Point(23, 12);
            pbVoltar.Name = "pbVoltar";
            pbVoltar.Size = new Size(39, 35);
            pbVoltar.TabIndex = 33;
            pbVoltar.TabStop = false;
            pbVoltar.Click += pbVoltar_Click;
            // 
            // FormConsultarProduto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 600);
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
    }
}