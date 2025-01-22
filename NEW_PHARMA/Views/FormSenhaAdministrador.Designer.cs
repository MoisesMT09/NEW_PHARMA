namespace Views
{
    partial class FormSenhaAdministrador
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
            txtSenha = new TextBox();
            label1 = new Label();
            btnCancelar = new Button();
            btnConfirmar = new Button();
            label4 = new Label();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtSenha
            // 
            txtSenha.BackColor = SystemColors.Menu;
            txtSenha.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold);
            txtSenha.Location = new Point(72, 114);
            txtSenha.Margin = new Padding(2);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(274, 27);
            txtSenha.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            label1.Location = new Point(108, 19);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(188, 17);
            label1.TabIndex = 2;
            label1.Text = "Senha Do Administrador";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            btnCancelar.Location = new Point(72, 147);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(91, 25);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.Lime;
            btnConfirmar.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            btnConfirmar.Location = new Point(248, 147);
            btnConfirmar.Margin = new Padding(2);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(96, 25);
            btnConfirmar.TabIndex = 5;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold);
            label4.Location = new Point(72, 100);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(207, 15);
            label4.TabIndex = 7;
            label4.Text = "Digite a senha do Administrador ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Schoolbook", 6F, FontStyle.Bold);
            label9.Location = new Point(352, 61);
            label9.Name = "label9";
            label9.Size = new Size(70, 12);
            label9.TabIndex = 68;
            label9.Text = "NEW_PHARMA";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.medicine_icon_icons_com_66070;
            pictureBox1.Location = new Point(350, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 67;
            pictureBox1.TabStop = false;
            // 
            // FormSenhaAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSpringGreen;
            ClientSize = new Size(434, 270);
            Controls.Add(label9);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(btnConfirmar);
            Controls.Add(btnCancelar);
            Controls.Add(label1);
            Controls.Add(txtSenha);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FormSenhaAdministrador";
            Text = "FormSenhaAdministrador";
            Load += FormSenhaAdministrador_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSenha;
        private Label label1;
        private Button btnCancelar;
        private Button btnConfirmar;
        private Label label4;
        private Label label9;
        private PictureBox pictureBox1;
    }
}