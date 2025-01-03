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
            txtCategoria = new TextBox();
            btnLocalizar = new Button();
            dgvDados = new DataGridView();
            label2 = new Label();
            pbVoltar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbVoltar).BeginInit();
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
            // txtCategoria
            // 
            txtCategoria.Font = new Font("Century Schoolbook", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCategoria.Location = new Point(12, 86);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(613, 29);
            txtCategoria.TabIndex = 1;
            txtCategoria.TextChanged += txtCategoria_TextChanged;
            // 
            // btnLocalizar
            // 
            btnLocalizar.Font = new Font("Century Schoolbook", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLocalizar.Location = new Point(631, 86);
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
            dgvDados.BackgroundColor = Color.Cyan;
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Location = new Point(12, 134);
            dgvDados.Name = "dgvDados";
            dgvDados.ReadOnly = true;
            dgvDados.RowHeadersWidth = 62;
            dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDados.Size = new Size(776, 454);
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
            // pbVoltar
            // 
            pbVoltar.Image = (Image)resources.GetObject("pbVoltar.Image");
            pbVoltar.Location = new Point(12, 19);
            pbVoltar.Name = "pbVoltar";
            pbVoltar.Size = new Size(39, 35);
            pbVoltar.TabIndex = 35;
            pbVoltar.TabStop = false;
            pbVoltar.Click += pbVoltar_Click;
            // 
            // FormConsultarCategoria
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 600);
            Controls.Add(pbVoltar);
            Controls.Add(label2);
            Controls.Add(dgvDados);
            Controls.Add(btnLocalizar);
            Controls.Add(txtCategoria);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormConsultarCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar Categoria";
            Load += FormConsultarCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbVoltar).EndInit();
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
    }
}