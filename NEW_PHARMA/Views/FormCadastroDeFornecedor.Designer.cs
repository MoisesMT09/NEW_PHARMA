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
            btnCancelar = new Button();
            btnSalvar = new Button();
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
            pbVoltar = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pnBotao.SuspendLayout();
            pnDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbVoltar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            label5.Location = new Point(45, 413);
            label5.Name = "label5";
            label5.Size = new Size(133, 25);
            label5.TabIndex = 6;
            label5.Text = "TELEFONE";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            label6.Location = new Point(45, 237);
            label6.Name = "label6";
            label6.Size = new Size(95, 25);
            label6.TabIndex = 7;
            label6.Text = "E_MAIL";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold | FontStyle.Underline);
            label7.Location = new Point(202, 18);
            label7.Name = "label7";
            label7.Size = new Size(405, 30);
            label7.TabIndex = 12;
            label7.Text = "CADASTRO DE FORNECEDOR";
            // 
            // pnBotao
            // 
            pnBotao.BorderStyle = BorderStyle.FixedSingle;
            pnBotao.Controls.Add(btnCancelar);
            pnBotao.Controls.Add(btnSalvar);
            pnBotao.Location = new Point(12, 698);
            pnBotao.Name = "pnBotao";
            pnBotao.Size = new Size(776, 90);
            pnBotao.TabIndex = 21;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            btnCancelar.Location = new Point(45, 30);
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
            btnSalvar.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            btnSalvar.Location = new Point(445, 30);
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
            btnInserir.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnInserir.FlatAppearance.MouseDownBackColor = Color.DodgerBlue;
            btnInserir.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btnInserir.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            btnInserir.Location = new Point(12, 90);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(250, 35);
            btnInserir.TabIndex = 7;
            btnInserir.Text = "INSERIR\r\n";
            btnInserir.UseVisualStyleBackColor = false;
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
            pnDados.Cursor = Cursors.IBeam;
            pnDados.Font = new Font("Century Schoolbook", 9F);
            pnDados.Location = new Point(12, 131);
            pnDados.Name = "pnDados";
            pnDados.Size = new Size(776, 560);
            pnDados.TabIndex = 22;
            // 
            // txtTelefone
            // 
            txtTelefone.BackColor = SystemColors.Menu;
            txtTelefone.Font = new Font("Century Schoolbook", 10F);
            txtTelefone.Location = new Point(255, 441);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(475, 32);
            txtTelefone.TabIndex = 32;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.Menu;
            txtEmail.Font = new Font("Century Schoolbook", 10F);
            txtEmail.Location = new Point(45, 265);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(685, 32);
            txtEmail.TabIndex = 31;
            txtEmail.TextChanged += textBox2_TextChanged;
            // 
            // combPrefTel
            // 
            combPrefTel.BackColor = SystemColors.Menu;
            combPrefTel.Font = new Font("Century Schoolbook", 10F);
            combPrefTel.FormattingEnabled = true;
            combPrefTel.Items.AddRange(new object[] { "Afeganistão: +93", "", "África do Sul: +27", "", "Albânia: +355", "", "Alemanha: +49", "", "Andorra: +376", "", "Angola: +244", "", "Arábia Saudita: +966", "", "Argentina: +54", "", "Austrália: +61", "", "Áustria: +43", "", "Bangladesh: +880", "", "Bélgica: +32", "", "Bolívia: +591", "", "Brasil: +55", "", "Canadá: +1", "", "Chile: +56", "", "China: +86", "", "Colômbia: +57", "", "Coreia do Sul: +82", "", "Cuba: +53", "", "Dinamarca: +45", "", "Egito: +20", "", "Emirados Árabes Unidos: +971", "", "Espanha: +34", "", "Estados Unidos: +1", "", "França: +33", "", "Grécia: +30", "", "Índia: +91", "", "Indonésia: +62", "", "Irã: +98", "", "Irlanda: +353", "", "Israel: +972", "", "Itália: +39", "", "Japão: +81", "", "México: +52", "", "Nigéria: +234", "", "Noruega: +47", "", "Nova Zelândia: +64", "", "Paquistão: +92", "", "Países Baixos: +31", "", "Peru: +51", "", "Portugal: +351", "Reino Unido: +44", "", "Rússia: +7", "", "Suécia: +46", "", "Suíça: +41", "", "Turquia: +90", "", "Ucrânia: +380", "", "Venezuela: +58", "", "Vietnã: +84" });
            combPrefTel.Location = new Point(45, 441);
            combPrefTel.Name = "combPrefTel";
            combPrefTel.Size = new Size(204, 31);
            combPrefTel.TabIndex = 30;
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.Menu;
            txtNome.Font = new Font("Century Schoolbook", 10F);
            txtNome.Location = new Point(45, 77);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(685, 32);
            txtNome.TabIndex = 29;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtNIF
            // 
            txtNIF.BackColor = SystemColors.Menu;
            txtNIF.Font = new Font("Century Schoolbook", 10F);
            txtNIF.Location = new Point(45, 171);
            txtNIF.Name = "txtNIF";
            txtNIF.Size = new Size(685, 32);
            txtNIF.TabIndex = 28;
            // 
            // txtEndereco
            // 
            txtEndereco.BackColor = SystemColors.Menu;
            txtEndereco.Font = new Font("Century Schoolbook", 10F);
            txtEndereco.Location = new Point(45, 354);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(685, 32);
            txtEndereco.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            label4.Location = new Point(45, 326);
            label4.Name = "label4";
            label4.Size = new Size(140, 25);
            label4.TabIndex = 26;
            label4.Text = "ENDEREÇO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            label3.Location = new Point(45, 143);
            label3.Name = "label3";
            label3.Size = new Size(52, 25);
            label3.TabIndex = 25;
            label3.Text = "NIF";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            label2.Location = new Point(45, 49);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 24;
            label2.Text = "NOME";
            // 
            // pbVoltar
            // 
            pbVoltar.Image = (Image)resources.GetObject("pbVoltar.Image");
            pbVoltar.Location = new Point(12, 18);
            pbVoltar.Name = "pbVoltar";
            pbVoltar.Size = new Size(39, 35);
            pbVoltar.TabIndex = 35;
            pbVoltar.TabStop = false;
            pbVoltar.Click += pbVoltar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(709, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 79);
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 5F, FontStyle.Bold);
            label1.Location = new Point(711, 100);
            label1.Name = "label1";
            label1.Size = new Size(77, 13);
            label1.TabIndex = 60;
            label1.Text = "New_Pharma";
            // 
            // FormCadastroDeFornecedor
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSpringGreen;
            ClientSize = new Size(800, 800);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pbVoltar);
            Controls.Add(btnInserir);
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
            ((System.ComponentModel.ISupportInitialize)pbVoltar).EndInit();
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
        private Button btnCancelar;
        private Button btnSalvar;
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
        private PictureBox pbVoltar;
        private PictureBox pictureBox1;
        private Label label1;
    }
}