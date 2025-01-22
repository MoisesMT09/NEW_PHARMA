namespace Views
{
    partial class FormConsultarVenda
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
            btnEliminar = new Button();
            button1 = new Button();
            dgvDados = new DataGridView();
            pbVoltar = new PictureBox();
            btnLocalizar = new Button();
            txtFornecedor = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbVoltar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(389, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(380, 30);
            btnEliminar.TabIndex = 54;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(380, 30);
            button1.TabIndex = 53;
            button1.Text = "ALTERAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // dgvDados
            // 
            dgvDados.AllowUserToAddRows = false;
            dgvDados.AllowUserToDeleteRows = false;
            dgvDados.BackgroundColor = SystemColors.Menu;
            dgvDados.BorderStyle = BorderStyle.Fixed3D;
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Location = new Point(12, 156);
            dgvDados.Name = "dgvDados";
            dgvDados.ReadOnly = true;
            dgvDados.RowHeadersWidth = 62;
            dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDados.Size = new Size(776, 586);
            dgvDados.TabIndex = 55;
            // 
            // pbVoltar
            // 
            pbVoltar.Image = Properties.Resources.back_112351;
            pbVoltar.Location = new Point(12, 15);
            pbVoltar.Name = "pbVoltar";
            pbVoltar.Size = new Size(38, 37);
            pbVoltar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbVoltar.TabIndex = 60;
            pbVoltar.TabStop = false;
            // 
            // btnLocalizar
            // 
            btnLocalizar.BackColor = SystemColors.Menu;
            btnLocalizar.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            btnLocalizar.Location = new Point(695, 126);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.Size = new Size(93, 24);
            btnLocalizar.TabIndex = 59;
            btnLocalizar.Text = "Localizar";
            btnLocalizar.UseVisualStyleBackColor = false;
            // 
            // txtFornecedor
            // 
            txtFornecedor.BackColor = SystemColors.Menu;
            txtFornecedor.Font = new Font("Century Schoolbook", 10F);
            txtFornecedor.Location = new Point(12, 127);
            txtFornecedor.Name = "txtFornecedor";
            txtFornecedor.Size = new Size(677, 24);
            txtFornecedor.TabIndex = 58;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            label2.Location = new Point(12, 107);
            label2.Name = "label2";
            label2.Size = new Size(54, 17);
            label2.TabIndex = 57;
            label2.Text = "Venda";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 13F, FontStyle.Bold | FontStyle.Underline);
            label1.Location = new Point(300, 15);
            label1.Name = "label1";
            label1.Size = new Size(232, 21);
            label1.TabIndex = 56;
            label1.Text = "CONSULTA DE VENDA";
            label1.Click += label1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Schoolbook", 6F, FontStyle.Bold);
            label9.Location = new Point(718, 75);
            label9.Name = "label9";
            label9.Size = new Size(70, 12);
            label9.TabIndex = 64;
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
            pictureBox1.TabIndex = 63;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(12, 748);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 42);
            panel1.TabIndex = 65;
            // 
            // FormConsultarVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSpringGreen;
            ClientSize = new Size(800, 800);
            Controls.Add(panel1);
            Controls.Add(label9);
            Controls.Add(pictureBox1);
            Controls.Add(pbVoltar);
            Controls.Add(btnLocalizar);
            Controls.Add(txtFornecedor);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvDados);
            Font = new Font("Century Schoolbook", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormConsultarVenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormConsultarVenda";
            Load += FormConsultarVenda_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbVoltar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminar;
        private Button button1;
        private DataGridView dgvDados;
        private PictureBox pbVoltar;
        private Button btnLocalizar;
        private TextBox txtFornecedor;
        private Label label2;
        private Label label1;
        private Label label9;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}