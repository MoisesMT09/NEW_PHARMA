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
            pictureBox1 = new PictureBox();
            label3 = new Label();
            pnDados = new Panel();
            btnAlterar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)pbVoltar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnDados.SuspendLayout();
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
            label2.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(224, 16);
            label2.Name = "label2";
            label2.Size = new Size(332, 30);
            label2.TabIndex = 40;
            label2.Text = "CONSULTA DE CLIENTE";
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
            dgvDados.RowHeadersWidth = 62;
            dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDados.Size = new Size(776, 564);
            dgvDados.TabIndex = 39;
            dgvDados.CellClick += dgvDados_CellClick;
            dgvDados.CellDoubleClick += dgvDados_CellDoubleClick;
            // 
            // btnLocalizar
            // 
            btnLocalizar.BackColor = SystemColors.Menu;
            btnLocalizar.BackgroundImageLayout = ImageLayout.None;
            btnLocalizar.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            btnLocalizar.ForeColor = SystemColors.ControlText;
            btnLocalizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLocalizar.Location = new Point(657, 124);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.Size = new Size(131, 32);
            btnLocalizar.TabIndex = 38;
            btnLocalizar.Text = "Localizar";
            btnLocalizar.UseVisualStyleBackColor = false;
            btnLocalizar.Click += btnLocalizar_Click;
            // 
            // txtCliente
            // 
            txtCliente.BackColor = SystemColors.Menu;
            txtCliente.Font = new Font("Century Schoolbook", 10F);
            txtCliente.Location = new Point(12, 126);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(639, 32);
            txtCliente.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            label1.Location = new Point(12, 98);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 36;
            label1.Text = "Cliente";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(709, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 79);
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 5F, FontStyle.Bold);
            label3.Location = new Point(711, 98);
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
            pnDados.TabIndex = 61;
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
            // FormConsultarCliente
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSpringGreen;
            ClientSize = new Size(800, 800);
            Controls.Add(pnDados);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnDados.ResumeLayout(false);
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
        private PictureBox pictureBox1;
        private Label label3;
        private Panel pnDados;
        private Button btnAlterar;
        private Button btnEliminar;
    }
}