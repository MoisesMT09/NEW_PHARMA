namespace Views
{
    partial class FormCadastroDeFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroDeFornecedor));
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            pnBotao = new Panel();
            btnExcluir = new Button();
            btnCancelar = new Button();
            btnSalvar = new Button();
            btnAlterar = new Button();
            btnLocalizar = new Button();
            btnInserir = new Button();
            pnDados = new Panel();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            combPrefTel = new ComboBox();
            txtNome = new TextBox();
            txtNIF = new TextBox();
            txtEndereco = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtID = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pnBotao.SuspendLayout();
            pnDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold);
            label5.Location = new Point(392, 184);
            label5.Name = "label5";
            label5.Size = new Size(121, 21);
            label5.TabIndex = 6;
            label5.Text = "TELEFONE";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold);
            label6.Location = new Point(397, 107);
            label6.Name = "label6";
            label6.Size = new Size(86, 21);
            label6.TabIndex = 7;
            label6.Text = "E_MAIL";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.Location = new Point(201, 18);
            label7.Name = "label7";
            label7.Size = new Size(339, 25);
            label7.TabIndex = 12;
            label7.Text = "CADASTRO DE FORNECEDOR";
            // 
            // pnBotao
            // 
            pnBotao.BorderStyle = BorderStyle.FixedSingle;
            pnBotao.Controls.Add(btnExcluir);
            pnBotao.Controls.Add(btnCancelar);
            pnBotao.Controls.Add(btnSalvar);
            pnBotao.Controls.Add(btnAlterar);
            pnBotao.Controls.Add(btnLocalizar);
            pnBotao.Controls.Add(btnInserir);
            pnBotao.Location = new Point(12, 457);
            pnBotao.Name = "pnBotao";
            pnBotao.Size = new Size(776, 120);
            pnBotao.TabIndex = 21;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            btnExcluir.Location = new Point(263, 17);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(82, 82);
            btnExcluir.TabIndex = 11;
            btnExcluir.Text = "EXCLUIR\r\n";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            btnCancelar.Location = new Point(624, 17);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 82);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            btnSalvar.Location = new Point(506, 17);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(82, 82);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            btnAlterar.Location = new Point(381, 17);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(82, 82);
            btnAlterar.TabIndex = 8;
            btnAlterar.Text = "ALTERAR";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnLocalizar
            // 
            btnLocalizar.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            btnLocalizar.Location = new Point(140, 17);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.Size = new Size(82, 82);
            btnLocalizar.TabIndex = 6;
            btnLocalizar.Text = "LOCALIZAR";
            btnLocalizar.UseVisualStyleBackColor = true;
            btnLocalizar.Click += btnLocalizar_Click;
            // 
            // btnInserir
            // 
            btnInserir.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            btnInserir.Location = new Point(22, 17);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(82, 82);
            btnInserir.TabIndex = 7;
            btnInserir.Text = "INSERIR\r\n";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // pnDados
            // 
            pnDados.BorderStyle = BorderStyle.FixedSingle;
            pnDados.Controls.Add(txtTelefone);
            pnDados.Controls.Add(txtEmail);
            pnDados.Controls.Add(label5);
            pnDados.Controls.Add(combPrefTel);
            pnDados.Controls.Add(label6);
            pnDados.Controls.Add(txtNome);
            pnDados.Controls.Add(txtNIF);
            pnDados.Controls.Add(txtEndereco);
            pnDados.Controls.Add(label4);
            pnDados.Controls.Add(label3);
            pnDados.Controls.Add(label2);
            pnDados.Controls.Add(txtID);
            pnDados.Controls.Add(label1);
            pnDados.Location = new Point(12, 53);
            pnDados.Name = "pnDados";
            pnDados.Size = new Size(776, 386);
            pnDados.TabIndex = 22;
            // 
            // txtTelefone
            // 
            txtTelefone.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTelefone.Location = new Point(519, 209);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(215, 29);
            txtTelefone.TabIndex = 32;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(366, 131);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(368, 29);
            txtEmail.TabIndex = 31;
            txtEmail.TextChanged += textBox2_TextChanged;
            // 
            // combPrefTel
            // 
            combPrefTel.FormattingEnabled = true;
            combPrefTel.Items.AddRange(new object[] { "Afeganistão: +93", "", "África do Sul: +27", "", "Albânia: +355", "", "Alemanha: +49", "", "Andorra: +376", "", "Angola: +244", "", "Arábia Saudita: +966", "", "Argentina: +54", "", "Austrália: +61", "", "Áustria: +43", "", "Bangladesh: +880", "", "Bélgica: +32", "", "Bolívia: +591", "", "Brasil: +55", "", "Canadá: +1", "", "Chile: +56", "", "China: +86", "", "Colômbia: +57", "", "Coreia do Sul: +82", "", "Cuba: +53", "", "Dinamarca: +45", "", "Egito: +20", "", "Emirados Árabes Unidos: +971", "", "Espanha: +34", "", "Estados Unidos: +1", "", "França: +33", "", "Grécia: +30", "", "Índia: +91", "", "Indonésia: +62", "", "Irã: +98", "", "Irlanda: +353", "", "Israel: +972", "", "Itália: +39", "", "Japão: +81", "", "México: +52", "", "Nigéria: +234", "", "Noruega: +47", "", "Nova Zelândia: +64", "", "Paquistão: +92", "", "Países Baixos: +31", "", "Peru: +51", "", "Portugal: +351", "Reino Unido: +44", "", "Rússia: +7", "", "Suécia: +46", "", "Suíça: +41", "", "Turquia: +90", "", "Ucrânia: +380", "", "Venezuela: +58", "", "Vietnã: +84" });
            combPrefTel.Location = new Point(366, 208);
            combPrefTel.Name = "combPrefTel";
            combPrefTel.Size = new Size(147, 30);
            combPrefTel.TabIndex = 30;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(17, 131);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(328, 29);
            txtNome.TabIndex = 29;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtNIF
            // 
            txtNIF.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold);
            txtNIF.Location = new Point(17, 210);
            txtNIF.Name = "txtNIF";
            txtNIF.Size = new Size(328, 29);
            txtNIF.TabIndex = 28;
            // 
            // txtEndereco
            // 
            txtEndereco.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold);
            txtEndereco.Location = new Point(17, 281);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(328, 29);
            txtEndereco.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold);
            label4.Location = new Point(32, 257);
            label4.Name = "label4";
            label4.Size = new Size(126, 21);
            label4.TabIndex = 26;
            label4.Text = "ENDEREÇO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold);
            label3.Location = new Point(32, 185);
            label3.Name = "label3";
            label3.Size = new Size(46, 21);
            label3.TabIndex = 25;
            label3.Text = "NIF";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 107);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 24;
            label2.Text = "NOME";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtID.Location = new Point(17, 51);
            txtID.Name = "txtID";
            txtID.Size = new Size(150, 29);
            txtID.TabIndex = 22;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 27);
            label1.Name = "label1";
            label1.Size = new Size(33, 21);
            label1.TabIndex = 21;
            label1.Text = "ID";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Red;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(755, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 33);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FormCadastroDeFornecedor
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(pictureBox1);
            Controls.Add(pnDados);
            Controls.Add(pnBotao);
            Controls.Add(label7);
            Font = new Font("Century Schoolbook", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCadastroDeFornecedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro De Fornecedor";
            Load += FormCadastroDeFornecedor_Load;
            pnBotao.ResumeLayout(false);
            pnDados.ResumeLayout(false);
            pnDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Panel pnBotao;
        private Button btnExcluir;
        private Button btnCancelar;
        private Button btnSalvar;
        private Button btnAlterar;
        private Button btnLocalizar;
        private Button btnInserir;
        private Panel pnDados;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private ComboBox combPrefTel;
        private TextBox txtNome;
        private TextBox txtNIF;
        private TextBox txtEndereco;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtID;
        private Label label1;
        private PictureBox pictureBox1;
    }
}