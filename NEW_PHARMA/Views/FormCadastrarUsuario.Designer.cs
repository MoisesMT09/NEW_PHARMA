namespace Views
{
    partial class FormCadastrarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastrarUsuario));
            pnDados = new Panel();
            chekEstado = new CheckBox();
            label7 = new Label();
            cmbNivelAcesso = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            txtSenha = new TextBox();
            txtLogin = new TextBox();
            txtNome = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnCadastrar = new Button();
            linkLogin = new LinkLabel();
            label8 = new Label();
            pbVoltar = new PictureBox();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            pnDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbVoltar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnDados
            // 
            pnDados.BorderStyle = BorderStyle.Fixed3D;
            pnDados.Controls.Add(chekEstado);
            pnDados.Controls.Add(label7);
            pnDados.Controls.Add(cmbNivelAcesso);
            pnDados.Controls.Add(label6);
            pnDados.Controls.Add(label5);
            pnDados.Controls.Add(txtSenha);
            pnDados.Controls.Add(txtLogin);
            pnDados.Controls.Add(txtNome);
            pnDados.Controls.Add(label4);
            pnDados.Controls.Add(label3);
            pnDados.Controls.Add(label2);
            pnDados.Location = new Point(12, 138);
            pnDados.Name = "pnDados";
            pnDados.Size = new Size(776, 519);
            pnDados.TabIndex = 1;
            pnDados.MouseDown += pnDados_MouseDown;
            // 
            // chekEstado
            // 
            chekEstado.AutoSize = true;
            chekEstado.BackColor = SystemColors.Menu;
            chekEstado.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            chekEstado.Location = new Point(169, 443);
            chekEstado.Name = "chekEstado";
            chekEstado.Size = new Size(104, 29);
            chekEstado.TabIndex = 11;
            chekEstado.Text = "Activo";
            chekEstado.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            label7.Location = new Point(169, 415);
            label7.Name = "label7";
            label7.Size = new Size(83, 25);
            label7.TabIndex = 10;
            label7.Text = "Estado";
            // 
            // cmbNivelAcesso
            // 
            cmbNivelAcesso.BackColor = SystemColors.Menu;
            cmbNivelAcesso.FormattingEnabled = true;
            cmbNivelAcesso.Location = new Point(169, 347);
            cmbNivelAcesso.Name = "cmbNivelAcesso";
            cmbNivelAcesso.Size = new Size(430, 31);
            cmbNivelAcesso.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Schoolbook", 8F, FontStyle.Bold);
            label6.Location = new Point(338, 135);
            label6.Name = "label6";
            label6.Size = new Size(202, 19);
            label6.TabIndex = 8;
            label6.Text = "(exemplo@newpharma)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            label5.Location = new Point(169, 321);
            label5.Name = "label5";
            label5.Size = new Size(171, 25);
            label5.TabIndex = 7;
            label5.Text = "Nível de Acesso";
            // 
            // txtSenha
            // 
            txtSenha.BackColor = SystemColors.Menu;
            txtSenha.Location = new Point(169, 250);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(431, 32);
            txtSenha.TabIndex = 5;
            // 
            // txtLogin
            // 
            txtLogin.BackColor = SystemColors.Menu;
            txtLogin.Location = new Point(169, 157);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(430, 32);
            txtLogin.TabIndex = 4;
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.Menu;
            txtNome.Location = new Point(169, 62);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(430, 32);
            txtNome.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            label4.Location = new Point(169, 224);
            label4.Name = "label4";
            label4.Size = new Size(76, 25);
            label4.TabIndex = 2;
            label4.Text = "Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            label3.Location = new Point(169, 131);
            label3.Name = "label3";
            label3.Size = new Size(166, 25);
            label3.TabIndex = 1;
            label3.Text = "Nome de Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            label2.Location = new Point(169, 36);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 0;
            label2.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(243, 31);
            label1.Name = "label1";
            label1.Size = new Size(311, 30);
            label1.TabIndex = 2;
            label1.Text = "CADASTRAR USÚARIO";
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.DodgerBlue;
            btnCadastrar.Font = new Font("Century Schoolbook", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(184, 687);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(430, 40);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // linkLogin
            // 
            linkLogin.AutoSize = true;
            linkLogin.Font = new Font("Century Schoolbook", 9F);
            linkLogin.Location = new Point(428, 749);
            linkLogin.Name = "linkLogin";
            linkLogin.Size = new Size(111, 22);
            linkLogin.TabIndex = 5;
            linkLogin.TabStop = true;
            linkLogin.Text = "Fazer Login";
            linkLogin.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Schoolbook", 9F);
            label8.Location = new Point(262, 749);
            label8.Name = "label8";
            label8.Size = new Size(172, 22);
            label8.TabIndex = 6;
            label8.Text = "Já está cadastrado?";
            // 
            // pbVoltar
            // 
            pbVoltar.Image = (Image)resources.GetObject("pbVoltar.Image");
            pbVoltar.Location = new Point(12, 25);
            pbVoltar.Name = "pbVoltar";
            pbVoltar.Size = new Size(39, 35);
            pbVoltar.TabIndex = 35;
            pbVoltar.TabStop = false;
            pbVoltar.Click += pbVoltar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(709, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 79);
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Schoolbook", 5F, FontStyle.Bold);
            label9.Location = new Point(709, 107);
            label9.Name = "label9";
            label9.Size = new Size(77, 13);
            label9.TabIndex = 59;
            label9.Text = "New_Pharma";
            // 
            // FormCadastrarUsuario
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSpringGreen;
            ClientSize = new Size(800, 800);
            Controls.Add(label9);
            Controls.Add(pictureBox1);
            Controls.Add(pbVoltar);
            Controls.Add(label8);
            Controls.Add(linkLogin);
            Controls.Add(btnCadastrar);
            Controls.Add(label1);
            Controls.Add(pnDados);
            Font = new Font("Century Schoolbook", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormCadastrarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCadastrarUsuario";
            Load += FormCadastrarUsuario_Load;
            MouseDown += FormCadastrarUsuario_MouseDown;
            pnDados.ResumeLayout(false);
            pnDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbVoltar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnDados;
        private Label label2;
        private Label label1;
        private TextBox txtSenha;
        private TextBox txtLogin;
        private TextBox txtNome;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cmbNivelAcesso;
        private CheckBox chekEstado;
        private Button btnCadastrar;
        private LinkLabel linkLogin;
        private Label label8;
        private PictureBox pbVoltar;
        private PictureBox pictureBox1;
        private Label label9;
    }
}