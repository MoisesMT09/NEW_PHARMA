namespace Views
{
    partial class FormLogin
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
            label1 = new Label();
            pnDados = new Panel();
            label6 = new Label();
            txtSenha = new TextBox();
            txtLogin = new TextBox();
            label4 = new Label();
            label3 = new Label();
            btnLogin = new Button();
            label8 = new Label();
            linkCadastrar = new LinkLabel();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbVoltar).BeginInit();
            pnDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pbVoltar
            // 
            pbVoltar.Image = Properties.Resources.back_112351;
            pbVoltar.Location = new Point(12, 12);
            pbVoltar.Name = "pbVoltar";
            pbVoltar.Size = new Size(39, 32);
            pbVoltar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbVoltar.TabIndex = 54;
            pbVoltar.TabStop = false;
            pbVoltar.Click += pbVoltar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 13F, FontStyle.Bold);
            label1.Location = new Point(298, 23);
            label1.Name = "label1";
            label1.Size = new Size(76, 21);
            label1.TabIndex = 52;
            label1.Text = "LOGIN";
            // 
            // pnDados
            // 
            pnDados.BorderStyle = BorderStyle.Fixed3D;
            pnDados.Controls.Add(label6);
            pnDados.Controls.Add(txtSenha);
            pnDados.Controls.Add(txtLogin);
            pnDados.Controls.Add(label4);
            pnDados.Controls.Add(label3);
            pnDados.Location = new Point(12, 136);
            pnDados.Name = "pnDados";
            pnDados.Size = new Size(709, 408);
            pnDados.TabIndex = 51;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Schoolbook", 8F, FontStyle.Bold);
            label6.Location = new Point(162, 85);
            label6.Name = "label6";
            label6.Size = new Size(131, 14);
            label6.TabIndex = 8;
            label6.Text = "(exemplo@gmail.com)";
            // 
            // txtSenha
            // 
            txtSenha.BackColor = SystemColors.Menu;
            txtSenha.Location = new Point(87, 240);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(519, 24);
            txtSenha.TabIndex = 5;
            // 
            // txtLogin
            // 
            txtLogin.BackColor = SystemColors.Menu;
            txtLogin.Location = new Point(87, 109);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(519, 24);
            txtLogin.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            label4.Location = new Point(87, 212);
            label4.Name = "label4";
            label4.Size = new Size(54, 17);
            label4.TabIndex = 2;
            label4.Text = "Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            label3.Location = new Point(87, 81);
            label3.Name = "label3";
            label3.Size = new Size(51, 17);
            label3.TabIndex = 1;
            label3.Text = "Login";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DodgerBlue;
            btnLogin.Font = new Font("Century Schoolbook", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(155, 581);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(430, 40);
            btnLogin.TabIndex = 53;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold);
            label8.Location = new Point(227, 664);
            label8.Name = "label8";
            label8.Size = new Size(147, 15);
            label8.TabIndex = 57;
            label8.Text = "Ainda não tem acesso ?";
            // 
            // linkCadastrar
            // 
            linkCadastrar.AutoSize = true;
            linkCadastrar.Font = new Font("Century Schoolbook", 9F);
            linkCadastrar.Location = new Point(380, 663);
            linkCadastrar.Name = "linkCadastrar";
            linkCadastrar.Size = new Size(81, 16);
            linkCadastrar.TabIndex = 56;
            linkCadastrar.TabStop = true;
            linkCadastrar.Text = "Cadastrar-se";
            linkCadastrar.LinkClicked += linkCadastrar_LinkClicked;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Schoolbook", 6F, FontStyle.Bold);
            label9.Location = new Point(649, 75);
            label9.Name = "label9";
            label9.Size = new Size(70, 12);
            label9.TabIndex = 59;
            label9.Text = "NEW_PHARMA";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.medicine_icon_icons_com_66070;
            pictureBox1.Location = new Point(649, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 58;
            pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSpringGreen;
            ClientSize = new Size(733, 720);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(linkCadastrar);
            Controls.Add(pictureBox1);
            Controls.Add(pbVoltar);
            Controls.Add(label1);
            Controls.Add(pnDados);
            Controls.Add(btnLogin);
            Font = new Font("Century Schoolbook", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            Load += FormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pbVoltar).EndInit();
            pnDados.ResumeLayout(false);
            pnDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pbVoltar;
        private Label label1;
        private Panel pnDados;
        private Label label6;
        private TextBox txtSenha;
        private TextBox txtLogin;
        private Label label4;
        private Label label3;
        private Button btnLogin;
        private Label label8;
        private LinkLabel linkCadastrar;
        private Label label9;
        private PictureBox pictureBox1;
    }
}