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
            pbVoltar = new PictureBox();
            label2 = new Label();
            dgvDados = new DataGridView();
            btnLocalizar = new Button();
            txtCliente = new TextBox();
            label1 = new Label();
            pnDados = new Panel();
            btnAlterar = new Button();
            btnEliminar = new Button();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbVoltar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            pnDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pbVoltar
            // 
            pbVoltar.Image = Properties.Resources.back_112351;
            pbVoltar.Location = new Point(12, 12);
            pbVoltar.Name = "pbVoltar";
            pbVoltar.Size = new Size(35, 32);
            pbVoltar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbVoltar.TabIndex = 41;
            pbVoltar.TabStop = false;
            pbVoltar.Click += pbVoltar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 13F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(292, 16);
            label2.Name = "label2";
            label2.Size = new Size(251, 21);
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
            dgvDados.Location = new Point(12, 139);
            dgvDados.Name = "dgvDados";
            dgvDados.RowHeadersWidth = 62;
            dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDados.Size = new Size(776, 606);
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
            btnLocalizar.Location = new Point(681, 109);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.Size = new Size(93, 24);
            btnLocalizar.TabIndex = 38;
            btnLocalizar.Text = "Localizar";
            btnLocalizar.UseVisualStyleBackColor = false;
            btnLocalizar.Click += btnLocalizar_Click;
            // 
            // txtCliente
            // 
            txtCliente.BackColor = SystemColors.Menu;
            txtCliente.Font = new Font("Century Schoolbook", 10F);
            txtCliente.Location = new Point(12, 109);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(677, 24);
            txtCliente.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            label1.Location = new Point(12, 89);
            label1.Name = "label1";
            label1.Size = new Size(61, 17);
            label1.TabIndex = 36;
            label1.Text = "Cliente";
            // 
            // pnDados
            // 
            pnDados.BorderStyle = BorderStyle.Fixed3D;
            pnDados.Controls.Add(btnAlterar);
            pnDados.Controls.Add(btnEliminar);
            pnDados.Location = new Point(12, 751);
            pnDados.Name = "pnDados";
            pnDados.Size = new Size(776, 37);
            pnDados.TabIndex = 61;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.DarkSlateGray;
            btnAlterar.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlterar.Location = new Point(3, 3);
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
            btnEliminar.Location = new Point(389, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(380, 30);
            btnEliminar.TabIndex = 56;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Schoolbook", 6F, FontStyle.Bold);
            label9.Location = new Point(718, 75);
            label9.Name = "label9";
            label9.Size = new Size(70, 12);
            label9.TabIndex = 63;
            label9.Text = "NEW_PHARMA";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.medicine_icon_icons_com_66070;
            pictureBox1.Location = new Point(716, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 62;
            pictureBox1.TabStop = false;
            // 
            // FormConsultarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
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
            pnDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Panel pnDados;
        private Button btnAlterar;
        private Button btnEliminar;
        private Label label9;
        private PictureBox pictureBox1;
    }
}