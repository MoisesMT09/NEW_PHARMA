namespace Views
{
    partial class FormCadastroDeProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroDeProduto));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnExcluir = new Button();
            btnSalvar = new Button();
            btnAlterar = new Button();
            btnLocalizar = new Button();
            btnInserir = new Button();
            pnBotao = new Panel();
            ptInicial = new PictureBox();
            btnCancelar = new Button();
            txtNome = new TextBox();
            txtID = new TextBox();
            label2 = new Label();
            pnDados = new Panel();
            cmbFornecedor = new ComboBox();
            cmbCategoria = new ComboBox();
            label8 = new Label();
            txtPreco = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtDescricao = new TextBox();
            txtQuantidade = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnBotao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptInicial).BeginInit();
            pnDados.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(229, 18);
            label1.Name = "label1";
            label1.Size = new Size(292, 25);
            label1.TabIndex = 0;
            label1.Text = "CADASTRO DE PRODUTO";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Red;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(755, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 33);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold);
            btnExcluir.Location = new Point(237, 17);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(82, 82);
            btnExcluir.TabIndex = 11;
            btnExcluir.Text = "EXCLUIR\r\n";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold);
            btnSalvar.Location = new Point(479, 17);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(82, 82);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold);
            btnAlterar.Location = new Point(355, 17);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(82, 82);
            btnAlterar.TabIndex = 8;
            btnAlterar.Text = "ALTERAR";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnLocalizar
            // 
            btnLocalizar.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold);
            btnLocalizar.Location = new Point(126, 17);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.Size = new Size(82, 82);
            btnLocalizar.TabIndex = 6;
            btnLocalizar.Text = "LOCALIZAR";
            btnLocalizar.UseVisualStyleBackColor = true;
            btnLocalizar.Click += btnLocalizar_Click;
            // 
            // btnInserir
            // 
            btnInserir.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold);
            btnInserir.Location = new Point(17, 17);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(82, 82);
            btnInserir.TabIndex = 7;
            btnInserir.Text = "INSERIR\r\n";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // pnBotao
            // 
            pnBotao.BorderStyle = BorderStyle.FixedSingle;
            pnBotao.Controls.Add(ptInicial);
            pnBotao.Controls.Add(btnExcluir);
            pnBotao.Controls.Add(btnCancelar);
            pnBotao.Controls.Add(btnSalvar);
            pnBotao.Controls.Add(btnAlterar);
            pnBotao.Controls.Add(btnLocalizar);
            pnBotao.Controls.Add(btnInserir);
            pnBotao.Location = new Point(12, 450);
            pnBotao.Name = "pnBotao";
            pnBotao.Size = new Size(776, 120);
            pnBotao.TabIndex = 25;
            // 
            // ptInicial
            // 
            ptInicial.Image = (Image)resources.GetObject("ptInicial.Image");
            ptInicial.Location = new Point(712, 47);
            ptInicial.Name = "ptInicial";
            ptInicial.Size = new Size(49, 52);
            ptInicial.TabIndex = 12;
            ptInicial.TabStop = false;
            ptInicial.Click += ptInicial_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold);
            btnCancelar.Location = new Point(588, 17);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 82);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(17, 131);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(328, 29);
            txtNome.TabIndex = 29;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtID.Location = new Point(17, 51);
            txtID.Name = "txtID";
            txtID.Size = new Size(150, 29);
            txtID.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 27);
            label2.Name = "label2";
            label2.Size = new Size(33, 21);
            label2.TabIndex = 21;
            label2.Text = "ID";
            // 
            // pnDados
            // 
            pnDados.BorderStyle = BorderStyle.FixedSingle;
            pnDados.Controls.Add(cmbFornecedor);
            pnDados.Controls.Add(cmbCategoria);
            pnDados.Controls.Add(label8);
            pnDados.Controls.Add(txtPreco);
            pnDados.Controls.Add(label5);
            pnDados.Controls.Add(label6);
            pnDados.Controls.Add(txtNome);
            pnDados.Controls.Add(txtDescricao);
            pnDados.Controls.Add(txtQuantidade);
            pnDados.Controls.Add(label4);
            pnDados.Controls.Add(label3);
            pnDados.Controls.Add(label7);
            pnDados.Controls.Add(txtID);
            pnDados.Controls.Add(label2);
            pnDados.Location = new Point(11, 57);
            pnDados.Name = "pnDados";
            pnDados.Size = new Size(777, 374);
            pnDados.TabIndex = 26;
            // 
            // cmbFornecedor
            // 
            cmbFornecedor.FormattingEnabled = true;
            cmbFornecedor.Location = new Point(577, 54);
            cmbFornecedor.Name = "cmbFornecedor";
            cmbFornecedor.Size = new Size(146, 30);
            cmbFornecedor.TabIndex = 35;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(366, 54);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(158, 30);
            cmbCategoria.TabIndex = 34;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold);
            label8.Location = new Point(577, 27);
            label8.Name = "label8";
            label8.Size = new Size(140, 21);
            label8.TabIndex = 33;
            label8.Text = "FornecedorID";
            // 
            // txtPreco
            // 
            txtPreco.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPreco.Location = new Point(366, 281);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(215, 29);
            txtPreco.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold);
            label5.Location = new Point(388, 248);
            label5.Name = "label5";
            label5.Size = new Size(149, 21);
            label5.TabIndex = 6;
            label5.Text = "Preço Unitario";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold);
            label6.Location = new Point(384, 27);
            label6.Name = "label6";
            label6.Size = new Size(125, 21);
            label6.TabIndex = 7;
            label6.Text = "CategoriaID";
            // 
            // txtDescricao
            // 
            txtDescricao.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold);
            txtDescricao.Location = new Point(17, 210);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(328, 29);
            txtDescricao.TabIndex = 28;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold);
            txtQuantidade.Location = new Point(17, 293);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(328, 29);
            txtQuantidade.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold);
            label4.Location = new Point(32, 269);
            label4.Name = "label4";
            label4.Size = new Size(120, 21);
            label4.TabIndex = 26;
            label4.Text = "Quantidade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold);
            label3.Location = new Point(32, 185);
            label3.Name = "label3";
            label3.Size = new Size(102, 21);
            label3.TabIndex = 25;
            label3.Text = "Descrição";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(32, 107);
            label7.Name = "label7";
            label7.Size = new Size(72, 21);
            label7.TabIndex = 24;
            label7.Text = "NOME";
            // 
            // FormCadastroDeProduto
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(pnDados);
            Controls.Add(pnBotao);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Font = new Font("Century Schoolbook", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCadastroDeProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro De Produto";
            Load += FormCadastroDeProduto_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnBotao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptInicial).EndInit();
            pnDados.ResumeLayout(false);
            pnDados.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button btnExcluir;
        private Button btnSalvar;
        private Button btnAlterar;
        private Button btnLocalizar;
        private Button btnInserir;
        private Panel pnBotao;
        private Button btnCancelar;
        private PictureBox ptInicial;
        private TextBox txtNome;
        private TextBox txtID;
        private Label label2;
        private Panel pnDados;
        private TextBox txtPreco;
        private Label label5;
        private Label label6;
        private TextBox txtDescricao;
        private TextBox txtQuantidade;
        private Label label4;
        private Label label3;
        private Label label7;
        private Label label8;
        private ComboBox cmbFornecedor;
        private ComboBox cmbCategoria;
    }
}