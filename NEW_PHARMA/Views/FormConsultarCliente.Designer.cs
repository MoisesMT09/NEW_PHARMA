namespace Views
{
    partial class FormConsultarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultarCliente));
            pbVoltar = new PictureBox();
            label2 = new Label();
            dgvDados = new DataGridView();
            btnLocalizar = new Button();
            txtCliente = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbVoltar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            SuspendLayout();
            // 
            // pbVoltar
            // 
            pbVoltar.Image = (Image)resources.GetObject("pbVoltar.Image");
            pbVoltar.Location = new Point(12, 16);
            pbVoltar.Name = "pbVoltar";
            pbVoltar.Size = new Size(39, 35);
            pbVoltar.TabIndex = 41;
            pbVoltar.TabStop = false;
            pbVoltar.Click += pbVoltar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 10F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(249, 16);
            label2.Name = "label2";
            label2.Size = new Size(259, 23);
            label2.TabIndex = 40;
            label2.Text = "CONSULTA DE CLIENTE";
            // 
            // dgvDados
            // 
            dgvDados.AllowUserToAddRows = false;
            dgvDados.AllowUserToDeleteRows = false;
            dgvDados.BackgroundColor = Color.Cyan;
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Location = new Point(12, 131);
            dgvDados.Name = "dgvDados";
            dgvDados.ReadOnly = true;
            dgvDados.RowHeadersWidth = 62;
            dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDados.Size = new Size(776, 454);
            dgvDados.TabIndex = 39;
            dgvDados.CellContentClick += dgvDados_CellContentClick;
            dgvDados.CellDoubleClick += dgvDados_CellDoubleClick;
            // 
            // btnLocalizar
            // 
            btnLocalizar.Font = new Font("Century Schoolbook", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLocalizar.Location = new Point(631, 83);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.Size = new Size(157, 34);
            btnLocalizar.TabIndex = 38;
            btnLocalizar.Text = "Localizar";
            btnLocalizar.UseVisualStyleBackColor = true;
            btnLocalizar.Click += btnLocalizar_Click;
            // 
            // txtCliente
            // 
            txtCliente.Font = new Font("Century Schoolbook", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCliente.Location = new Point(12, 83);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(613, 29);
            txtCliente.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 55);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 36;
            label1.Text = "Cliente";
            // 
            // FormConsultarCliente
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 600);
            Controls.Add(pbVoltar);
            Controls.Add(label2);
            Controls.Add(dgvDados);
            Controls.Add(btnLocalizar);
            Controls.Add(txtCliente);
            Controls.Add(label1);
            Font = new Font("Century Schoolbook", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormConsultarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Consultar Cliente";
            Load += FormConsultarCliente_Load;
            ((System.ComponentModel.ISupportInitialize)pbVoltar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbVoltar;
        private Label label2;
        private DataGridView dgvDados;
        private Button btnLocalizar;
        private TextBox txtCliente;
        private Label label1;
    }
}