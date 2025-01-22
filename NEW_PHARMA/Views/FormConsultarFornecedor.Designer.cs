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
            label1 = new Label();
            dgvDados = new DataGridView();
            btnLocalizar = new Button();
            txtFornecedor = new TextBox();
            label2 = new Label();
            pbVoltar = new PictureBox();
            btnEliminar = new Button();
            button1 = new Button();
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
            label1.Location = new Point(249, 17);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(305, 21);
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
            dgvDados.Location = new Point(8, 128);
            dgvDados.Margin = new Padding(2);
            dgvDados.Name = "dgvDados";
            dgvDados.ReadOnly = true;
            dgvDados.RowHeadersWidth = 62;
            dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDados.Size = new Size(781, 619);
            dgvDados.TabIndex = 28;
            dgvDados.CellContentClick += dgvDados_CellContentClick;
            dgvDados.CellContentDoubleClick += dgvDados_CellContentDoubleClick;
            dgvDados.CellDoubleClick += dgvDados_CellDoubleClick;
            // 
            // btnLocalizar
            // 
            btnLocalizar.BackColor = SystemColors.Menu;
            btnLocalizar.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            btnLocalizar.Location = new Point(696, 99);
            btnLocalizar.Margin = new Padding(2);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.Size = new Size(93, 24);
            btnLocalizar.TabIndex = 27;
            btnLocalizar.Text = "Localizar";
            btnLocalizar.UseVisualStyleBackColor = false;
            btnLocalizar.Click += btnLocalizar_Click;
            // 
            // txtFornecedor
            // 
            txtFornecedor.BackColor = SystemColors.Menu;
            txtFornecedor.Font = new Font("Century Schoolbook", 10F);
            txtFornecedor.Location = new Point(8, 100);
            txtFornecedor.Margin = new Padding(2);
            txtFornecedor.Name = "txtFornecedor";
            txtFornecedor.Size = new Size(684, 24);
            txtFornecedor.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            label2.Location = new Point(8, 81);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(92, 17);
            label2.TabIndex = 25;
            label2.Text = "Fornecedor";
            // 
            // pbVoltar
            // 
            pbVoltar.Image = Properties.Resources.back_112351;
            pbVoltar.Location = new Point(8, 9);
            pbVoltar.Margin = new Padding(2);
            pbVoltar.Name = "pbVoltar";
            pbVoltar.Size = new Size(35, 29);
            pbVoltar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbVoltar.TabIndex = 34;
            pbVoltar.TabStop = false;
            pbVoltar.Click += pbVoltar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(395, 4);
            btnEliminar.Margin = new Padding(2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(380, 30);
            btnEliminar.TabIndex = 52;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(2, 2);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(380, 30);
            button1.TabIndex = 51;
            button1.Text = "ALTERAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // pnDados
            // 
            pnDados.BorderStyle = BorderStyle.Fixed3D;
            pnDados.Controls.Add(button1);
            pnDados.Controls.Add(btnEliminar);
            pnDados.Location = new Point(8, 751);
            pnDados.Margin = new Padding(2);
            pnDados.Name = "pnDados";
            pnDados.Size = new Size(781, 40);
            pnDados.TabIndex = 71;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Schoolbook", 6F, FontStyle.Bold);
            label9.Location = new Point(719, 72);
            label9.Name = "label9";
            label9.Size = new Size(70, 12);
            label9.TabIndex = 73;
            label9.Text = "NEW_PHARMA";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.medicine_icon_icons_com_66070;
            pictureBox1.Location = new Point(717, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 72;
            pictureBox1.TabStop = false;
            // 
            // FormConsultarFornecedor
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
            Controls.Add(txtFornecedor);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FormConsultarFornecedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormConsultarFornecedor";
            Load += FormConsultarFornecedor_Load;
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
        private TextBox txtFornecedor;
        private Label label2;
        private PictureBox pbVoltar;
        private Button btnEliminar;
        private Button button1;
        private Panel pnDados;
        private Label label9;
        private PictureBox pictureBox1;
    }
}