namespace Views
{
    partial class FormCadastroDeFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroDeFuncionario));
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            label6 = new Label();
            btnExcluir = new Button();
            btnCancelar = new Button();
            btnSalvar = new Button();
            btnAlterar = new Button();
            btnLocalizar = new Button();
            pnBotao = new Panel();
            btnInserir = new Button();
            combPrefTel = new ComboBox();
            txtNBI = new TextBox();
            label5 = new Label();
            label3 = new Label();
            pnDados = new Panel();
            label7 = new Label();
            txtNome = new TextBox();
            txtEndereco = new TextBox();
            label2 = new Label();
            txtID = new TextBox();
            label4 = new Label();
            label1 = new Label();
            pbVoltar = new PictureBox();
            pnBotao.SuspendLayout();
            pnDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbVoltar).BeginInit();
            SuspendLayout();
            // 
            // txtTelefone
            // 
            txtTelefone.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTelefone.Location = new Point(540, 225);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(215, 29);
            txtTelefone.TabIndex = 32;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(366, 146);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(389, 29);
            txtEmail.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold);
            label6.Location = new Point(381, 122);
            label6.Name = "label6";
            label6.Size = new Size(86, 21);
            label6.TabIndex = 7;
            label6.Text = "E_MAIL";
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
            // pnBotao
            // 
            pnBotao.BorderStyle = BorderStyle.FixedSingle;
            pnBotao.Controls.Add(btnExcluir);
            pnBotao.Controls.Add(btnCancelar);
            pnBotao.Controls.Add(btnSalvar);
            pnBotao.Controls.Add(btnAlterar);
            pnBotao.Controls.Add(btnLocalizar);
            pnBotao.Controls.Add(btnInserir);
            pnBotao.Location = new Point(12, 461);
            pnBotao.Name = "pnBotao";
            pnBotao.Size = new Size(776, 120);
            pnBotao.TabIndex = 39;
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
            // combPrefTel
            // 
            combPrefTel.FormattingEnabled = true;
            combPrefTel.Items.AddRange(new object[] { "Afeganistão: +93", "", "África do Sul: +27", "", "Albânia: +355", "", "Alemanha: +49", "", "Andorra: +376", "", "Angola: +244", "", "Arábia Saudita: +966", "", "Argentina: +54", "", "Austrália: +61", "", "Áustria: +43", "", "Bangladesh: +880", "", "Bélgica: +32", "", "Bolívia: +591", "", "Brasil: +55", "", "Canadá: +1", "", "Chile: +56", "", "China: +86", "", "Colômbia: +57", "", "Coreia do Sul: +82", "", "Cuba: +53", "", "Dinamarca: +45", "", "Egito: +20", "", "Emirados Árabes Unidos: +971", "", "Espanha: +34", "", "Estados Unidos: +1", "", "França: +33", "", "Grécia: +30", "", "Índia: +91", "", "Indonésia: +62", "", "Irã: +98", "", "Irlanda: +353", "", "Israel: +972", "", "Itália: +39", "", "Japão: +81", "", "México: +52", "", "Nigéria: +234", "", "Noruega: +47", "", "Nova Zelândia: +64", "", "Paquistão: +92", "", "Países Baixos: +31", "", "Peru: +51", "", "Portugal: +351", "Reino Unido: +44", "", "Rússia: +7", "", "Suécia: +46", "", "Suíça: +41", "", "Turquia: +90", "", "Ucrânia: +380", "", "Venezuela: +58", "", "Vietnã: +84" });
            combPrefTel.Location = new Point(366, 223);
            combPrefTel.Name = "combPrefTel";
            combPrefTel.Size = new Size(162, 29);
            combPrefTel.TabIndex = 30;
            // 
            // txtNBI
            // 
            txtNBI.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold);
            txtNBI.Location = new Point(17, 225);
            txtNBI.Name = "txtNBI";
            txtNBI.Size = new Size(328, 29);
            txtNBI.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold);
            label5.Location = new Point(32, 276);
            label5.Name = "label5";
            label5.Size = new Size(126, 21);
            label5.TabIndex = 26;
            label5.Text = "ENDEREÇO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold);
            label3.Location = new Point(32, 201);
            label3.Name = "label3";
            label3.Size = new Size(90, 21);
            label3.TabIndex = 25;
            label3.Text = "Nº Do BI";
            // 
            // pnDados
            // 
            pnDados.BorderStyle = BorderStyle.FixedSingle;
            pnDados.Controls.Add(txtTelefone);
            pnDados.Controls.Add(txtEmail);
            pnDados.Controls.Add(label7);
            pnDados.Controls.Add(combPrefTel);
            pnDados.Controls.Add(label6);
            pnDados.Controls.Add(txtNome);
            pnDados.Controls.Add(txtNBI);
            pnDados.Controls.Add(txtEndereco);
            pnDados.Controls.Add(label5);
            pnDados.Controls.Add(label3);
            pnDados.Controls.Add(label2);
            pnDados.Controls.Add(txtID);
            pnDados.Controls.Add(label4);
            pnDados.Location = new Point(12, 69);
            pnDados.Name = "pnDados";
            pnDados.Size = new Size(776, 374);
            pnDados.TabIndex = 40;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold);
            label7.Location = new Point(381, 199);
            label7.Name = "label7";
            label7.Size = new Size(121, 21);
            label7.TabIndex = 6;
            label7.Text = "TELEFONE";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(17, 146);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(328, 29);
            txtNome.TabIndex = 29;
            // 
            // txtEndereco
            // 
            txtEndereco.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold);
            txtEndereco.Location = new Point(17, 300);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(328, 29);
            txtEndereco.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 122);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 24;
            label2.Text = "NOME";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtID.Location = new Point(17, 66);
            txtID.Name = "txtID";
            txtID.Size = new Size(150, 29);
            txtID.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 42);
            label4.Name = "label4";
            label4.Size = new Size(33, 21);
            label4.TabIndex = 21;
            label4.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(229, 19);
            label1.Name = "label1";
            label1.Size = new Size(319, 25);
            label1.TabIndex = 38;
            label1.Text = "CADASTRAR FUNCIONÁRIO";
            // 
            // pbVoltar
            // 
            pbVoltar.Image = (Image)resources.GetObject("pbVoltar.Image");
            pbVoltar.Location = new Point(12, 12);
            pbVoltar.Name = "pbVoltar";
            pbVoltar.Size = new Size(39, 35);
            pbVoltar.TabIndex = 41;
            pbVoltar.TabStop = false;
            pbVoltar.Click += pbVoltar_Click;
            // 
            // FormCadastroDeFuncionario
            // 
            AutoScaleDimensions = new SizeF(12F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(pbVoltar);
            Controls.Add(pnBotao);
            Controls.Add(pnDados);
            Controls.Add(label1);
            Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormCadastroDeFuncionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro De Funcionario";
            Load += FormCadastroDeFuncionario_Load;
            pnBotao.ResumeLayout(false);
            pnDados.ResumeLayout(false);
            pnDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbVoltar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTelefone;
        private TextBox txtEmail;
        private Label label6;
        private Button btnExcluir;
        private Button btnCancelar;
        private Button btnSalvar;
        private Button btnAlterar;
        private Button btnLocalizar;
        private Panel pnBotao;
        private Button btnInserir;
        private ComboBox combPrefTel;
        private TextBox txtNBI;
        private Label label5;
        private Label label3;
        private Panel pnDados;
        private Label label7;
        private TextBox txtNome;
        private TextBox txtEndereco;
        private Label label2;
        private TextBox txtID;
        private Label label4;
        private Label label1;
        private PictureBox pbVoltar;
    }
}