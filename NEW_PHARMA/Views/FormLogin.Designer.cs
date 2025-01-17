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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            pictureBox1 = new PictureBox();
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
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbVoltar).BeginInit();
            pnDados.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(709, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 79);
            pictureBox1.TabIndex = 55;
            pictureBox1.TabStop = false;
            // 
            // pbVoltar
            // 
            pbVoltar.Image = (Image)resources.GetObject("pbVoltar.Image");
            pbVoltar.Location = new Point(12, 23);
            pbVoltar.Name = "pbVoltar";
            pbVoltar.Size = new Size(39, 35);
            pbVoltar.TabIndex = 54;
            pbVoltar.TabStop = false;
            pbVoltar.Click += pbVoltar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 13F, FontStyle.Bold);
            label1.Location = new Point(328, 28);
            label1.Name = "label1";
            label1.Size = new Size(111, 31);
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
            pnDados.Size = new Size(776, 509);
            pnDados.TabIndex = 51;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Schoolbook", 8F, FontStyle.Bold);
            label6.Location = new Point(306, 151);
            label6.Name = "label6";
            label6.Size = new Size(202, 19);
            label6.TabIndex = 8;
            label6.Text = "(exemplo@newpharma)";
            // 
            // txtSenha
            // 
            txtSenha.BackColor = SystemColors.Menu;
            txtSenha.Location = new Point(134, 301);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(519, 32);
            txtSenha.TabIndex = 5;
            // 
            // txtLogin
            // 
            txtLogin.BackColor = SystemColors.Menu;
            txtLogin.Location = new Point(134, 175);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(519, 32);
            txtLogin.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            label4.Location = new Point(134, 273);
            label4.Name = "label4";
            label4.Size = new Size(76, 25);
            label4.TabIndex = 2;
            label4.Text = "Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            label3.Location = new Point(134, 147);
            label3.Name = "label3";
            label3.Size = new Size(166, 25);
            label3.TabIndex = 1;
            label3.Text = "Nome de Login";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DodgerBlue;
            btnLogin.Font = new Font("Century Schoolbook", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(176, 684);
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
            label8.Location = new Point(215, 738);
            label8.Name = "label8";
            label8.Size = new Size(224, 21);
            label8.TabIndex = 57;
            label8.Text = "Ainda não tem acesso ?";
            // 
            // linkCadastrar
            // 
            linkCadastrar.AutoSize = true;
            linkCadastrar.Font = new Font("Century Schoolbook", 9F);
            linkCadastrar.Location = new Point(434, 738);
            linkCadastrar.Name = "linkCadastrar";
            linkCadastrar.Size = new Size(117, 22);
            linkCadastrar.TabIndex = 56;
            linkCadastrar.TabStop = true;
            linkCadastrar.Text = "Cadastrar-se";
            linkCadastrar.LinkClicked += linkCadastrar_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 5F, FontStyle.Bold);
            label2.Location = new Point(711, 105);
            label2.Name = "label2";
            label2.Size = new Size(77, 13);
            label2.TabIndex = 58;
            label2.Text = "New_Pharma";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSpringGreen;
            ClientSize = new Size(800, 800);
            Controls.Add(label2);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbVoltar).EndInit();
            pnDados.ResumeLayout(false);
            pnDados.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
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
        private Label label2;
    }
}