namespace Views
{
    partial class FormCadastroDeCliente
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
            txtTelefone = new TextBox();
            label7 = new Label();
            combPrefTel = new ComboBox();
            txtNome = new TextBox();
            txtEndereco = new TextBox();
            label5 = new Label();
            label2 = new Label();
            pnDados = new Panel();
            label1 = new Label();
            pnBotao = new Panel();
            btnCancelar = new Button();
            btnSalvar = new Button();
            btnInserir = new Button();
            label9 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbVoltar).BeginInit();
            pnDados.SuspendLayout();
            pnBotao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pbVoltar
            // 
            pbVoltar.Image = Properties.Resources.back_112351;
            pbVoltar.Location = new Point(12, 17);
            pbVoltar.Name = "pbVoltar";
            pbVoltar.Size = new Size(50, 46);
            pbVoltar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbVoltar.TabIndex = 43;
            pbVoltar.TabStop = false;
            pbVoltar.Click += pbVoltar_Click;
            // 
            // txtTelefone
            // 
            txtTelefone.BackColor = SystemColors.Menu;
            txtTelefone.Font = new Font("Century Schoolbook", 10F);
            txtTelefone.Location = new Point(255, 343);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(473, 24);
            txtTelefone.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            label7.Location = new Point(43, 315);
            label7.Name = "label7";
            label7.Size = new Size(95, 17);
            label7.TabIndex = 6;
            label7.Text = "TELEFONE";
            // 
            // combPrefTel
            // 
            combPrefTel.BackColor = SystemColors.Menu;
            combPrefTel.Font = new Font("Century Schoolbook", 10F);
            combPrefTel.FormattingEnabled = true;
            combPrefTel.Items.AddRange(new object[] { "Afeganistão: +93", "", "África do Sul: +27", "", "Albânia: +355", "", "Alemanha: +49", "", "Andorra: +376", "", "Angola: +244", "", "Arábia Saudita: +966", "", "Argentina: +54", "", "Austrália: +61", "", "Áustria: +43", "", "Bangladesh: +880", "", "Bélgica: +32", "", "Bolívia: +591", "", "Brasil: +55", "", "Canadá: +1", "", "Chile: +56", "", "China: +86", "", "Colômbia: +57", "", "Coreia do Sul: +82", "", "Cuba: +53", "", "Dinamarca: +45", "", "Egito: +20", "", "Emirados Árabes Unidos: +971", "", "Espanha: +34", "", "Estados Unidos: +1", "", "França: +33", "", "Grécia: +30", "", "Índia: +91", "", "Indonésia: +62", "", "Irã: +98", "", "Irlanda: +353", "", "Israel: +972", "", "Itália: +39", "", "Japão: +81", "", "México: +52", "", "Nigéria: +234", "", "Noruega: +47", "", "Nova Zelândia: +64", "", "Paquistão: +92", "", "Países Baixos: +31", "", "Peru: +51", "", "Portugal: +351", "Reino Unido: +44", "", "Rússia: +7", "", "Suécia: +46", "", "Suíça: +41", "", "Turquia: +90", "", "Ucrânia: +380", "", "Venezuela: +58", "", "Vietnã: +84" });
            combPrefTel.Location = new Point(43, 343);
            combPrefTel.Name = "combPrefTel";
            combPrefTel.Size = new Size(206, 24);
            combPrefTel.TabIndex = 30;
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.Menu;
            txtNome.Font = new Font("Century Schoolbook", 10F);
            txtNome.Location = new Point(43, 90);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(685, 24);
            txtNome.TabIndex = 29;
            // 
            // txtEndereco
            // 
            txtEndereco.BackColor = SystemColors.Menu;
            txtEndereco.Font = new Font("Century Schoolbook", 10F);
            txtEndereco.Location = new Point(43, 223);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(685, 24);
            txtEndereco.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            label5.Location = new Point(43, 195);
            label5.Name = "label5";
            label5.Size = new Size(99, 17);
            label5.TabIndex = 26;
            label5.Text = "ENDEREÇO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            label2.Location = new Point(43, 62);
            label2.Name = "label2";
            label2.Size = new Size(57, 17);
            label2.TabIndex = 24;
            label2.Text = "NOME";
            // 
            // pnDados
            // 
            pnDados.BorderStyle = BorderStyle.Fixed3D;
            pnDados.Controls.Add(txtTelefone);
            pnDados.Controls.Add(label7);
            pnDados.Controls.Add(combPrefTel);
            pnDados.Controls.Add(txtNome);
            pnDados.Controls.Add(txtEndereco);
            pnDados.Controls.Add(label5);
            pnDados.Controls.Add(label2);
            pnDados.Location = new Point(12, 133);
            pnDados.Name = "pnDados";
            pnDados.Size = new Size(776, 577);
            pnDados.TabIndex = 42;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 13F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(269, 17);
            label1.Name = "label1";
            label1.Size = new Size(252, 21);
            label1.TabIndex = 44;
            label1.Text = "CADASTRO DE CLIENTE";
            // 
            // pnBotao
            // 
            pnBotao.BorderStyle = BorderStyle.Fixed3D;
            pnBotao.Controls.Add(btnCancelar);
            pnBotao.Controls.Add(btnSalvar);
            pnBotao.Location = new Point(12, 716);
            pnBotao.Name = "pnBotao";
            pnBotao.Size = new Size(776, 72);
            pnBotao.TabIndex = 45;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold);
            btnCancelar.Location = new Point(22, 18);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(285, 40);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Lime;
            btnSalvar.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold);
            btnSalvar.Location = new Point(470, 18);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(285, 40);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnInserir
            // 
            btnInserir.BackColor = Color.DodgerBlue;
            btnInserir.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold);
            btnInserir.ForeColor = SystemColors.ControlText;
            btnInserir.Location = new Point(12, 95);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(250, 35);
            btnInserir.TabIndex = 7;
            btnInserir.Text = "INSERIR\r\n";
            btnInserir.UseVisualStyleBackColor = false;
            btnInserir.Click += btnInserir_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Schoolbook", 6F, FontStyle.Bold);
            label9.Location = new Point(718, 75);
            label9.Name = "label9";
            label9.Size = new Size(70, 12);
            label9.TabIndex = 49;
            label9.Text = "NEW_PHARMA";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.medicine_icon_icons_com_66070;
            pictureBox2.Location = new Point(716, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(72, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 48;
            pictureBox2.TabStop = false;
            // 
            // FormCadastroDeCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSpringGreen;
            ClientSize = new Size(800, 800);
            Controls.Add(label9);
            Controls.Add(pictureBox2);
            Controls.Add(pnBotao);
            Controls.Add(label1);
            Controls.Add(pbVoltar);
            Controls.Add(pnDados);
            Controls.Add(btnInserir);
            Font = new Font("Century Schoolbook", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCadastroDeCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro De Cliente";
            Load += FormCadastroDeCliente_Load;
            ((System.ComponentModel.ISupportInitialize)pbVoltar).EndInit();
            pnDados.ResumeLayout(false);
            pnDados.PerformLayout();
            pnBotao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbVoltar;
        private TextBox txtTelefone;
        private Label label7;
        private ComboBox combPrefTel;
        private TextBox txtNome;
        private TextBox txtEndereco;
        private Label label5;
        private Label label2;
        private Panel pnDados;
        private Label label1;
        private Panel pnBotao;
        private Button btnCancelar;
        private Button btnSalvar;
        private Button btnInserir;
        private Label label9;
        private PictureBox pictureBox2;
    }
}