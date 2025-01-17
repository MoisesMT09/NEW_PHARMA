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
            btnSalvar = new Button();
            btnInserir = new Button();
            pnBotao = new Panel();
            btnCancelar = new Button();
            txtNome = new TextBox();
            pnDados = new Panel();
            label2 = new Label();
            dtpDataValidade = new DateTimePicker();
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
            pbVoltar = new PictureBox();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            pnBotao.SuspendLayout();
            pnDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbVoltar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(220, 13);
            label1.Name = "label1";
            label1.Size = new Size(348, 30);
            label1.TabIndex = 0;
            label1.Text = "CADASTRO DE PRODUTO";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Lime;
            btnSalvar.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold);
            btnSalvar.Location = new Point(444, 23);
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
            btnInserir.Location = new Point(11, 80);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(250, 35);
            btnInserir.TabIndex = 7;
            btnInserir.Text = "INSERIR\r\n";
            btnInserir.UseVisualStyleBackColor = false;
            btnInserir.Click += btnInserir_Click;
            // 
            // pnBotao
            // 
            pnBotao.BorderStyle = BorderStyle.Fixed3D;
            pnBotao.Controls.Add(btnCancelar);
            pnBotao.Controls.Add(btnSalvar);
            pnBotao.Location = new Point(12, 692);
            pnBotao.Name = "pnBotao";
            pnBotao.Size = new Size(776, 90);
            pnBotao.TabIndex = 25;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold);
            btnCancelar.Location = new Point(44, 23);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(285, 40);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Century Schoolbook", 11F);
            txtNome.Location = new Point(45, 57);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(685, 34);
            txtNome.TabIndex = 29;
            // 
            // pnDados
            // 
            pnDados.BorderStyle = BorderStyle.Fixed3D;
            pnDados.Controls.Add(label2);
            pnDados.Controls.Add(dtpDataValidade);
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
            pnDados.Location = new Point(11, 126);
            pnDados.Name = "pnDados";
            pnDados.Size = new Size(776, 560);
            pnDados.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            label2.Location = new Point(45, 463);
            label2.Name = "label2";
            label2.Size = new Size(192, 25);
            label2.TabIndex = 37;
            label2.Text = "Data De Validade";
            // 
            // dtpDataValidade
            // 
            dtpDataValidade.Location = new Point(45, 491);
            dtpDataValidade.Name = "dtpDataValidade";
            dtpDataValidade.Size = new Size(386, 29);
            dtpDataValidade.TabIndex = 36;
            // 
            // cmbFornecedor
            // 
            cmbFornecedor.Font = new Font("Century Schoolbook", 11F);
            cmbFornecedor.FormattingEnabled = true;
            cmbFornecedor.Items.AddRange(new object[] { "1  ", "2  ", "3  ", "4  ", "5  ", "6  ", "7  ", "8  ", "9  ", "10  ", "11  ", "12  ", "13  ", "14  ", "15  ", "16  ", "17  ", "18  ", "19  ", "20  " });
            cmbFornecedor.Location = new Point(45, 392);
            cmbFornecedor.Name = "cmbFornecedor";
            cmbFornecedor.Size = new Size(295, 35);
            cmbFornecedor.TabIndex = 35;
            // 
            // cmbCategoria
            // 
            cmbCategoria.Font = new Font("Century Schoolbook", 11F);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "1  ", "2  ", "3  ", "4  ", "5  ", "6  ", "7  ", "8  ", "9  ", "10  ", " " });
            cmbCategoria.Location = new Point(435, 392);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(295, 35);
            cmbCategoria.TabIndex = 34;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            label8.Location = new Point(435, 364);
            label8.Name = "label8";
            label8.Size = new Size(130, 25);
            label8.TabIndex = 33;
            label8.Text = "Fornecedor";
            // 
            // txtPreco
            // 
            txtPreco.Font = new Font("Century Schoolbook", 11F);
            txtPreco.Location = new Point(435, 295);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(295, 34);
            txtPreco.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            label5.Location = new Point(435, 270);
            label5.Name = "label5";
            label5.Size = new Size(165, 25);
            label5.TabIndex = 6;
            label5.Text = "Preço Unitario";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            label6.Location = new Point(45, 364);
            label6.Name = "label6";
            label6.Size = new Size(113, 25);
            label6.TabIndex = 7;
            label6.Text = "Categoria";
            // 
            // txtDescricao
            // 
            txtDescricao.Font = new Font("Century Schoolbook", 11F);
            txtDescricao.Location = new Point(45, 144);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(685, 98);
            txtDescricao.TabIndex = 28;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Font = new Font("Century Schoolbook", 11F);
            txtQuantidade.Location = new Point(45, 295);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(295, 34);
            txtQuantidade.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            label4.Location = new Point(45, 270);
            label4.Name = "label4";
            label4.Size = new Size(134, 25);
            label4.TabIndex = 26;
            label4.Text = "Quantidade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            label3.Location = new Point(45, 116);
            label3.Name = "label3";
            label3.Size = new Size(113, 25);
            label3.TabIndex = 25;
            label3.Text = "Descrição";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            label7.Location = new Point(45, 33);
            label7.Name = "label7";
            label7.Size = new Size(71, 25);
            label7.TabIndex = 24;
            label7.Text = "Nome";
            // 
            // pbVoltar
            // 
            pbVoltar.Image = (Image)resources.GetObject("pbVoltar.Image");
            pbVoltar.Location = new Point(11, 13);
            pbVoltar.Name = "pbVoltar";
            pbVoltar.Size = new Size(39, 35);
            pbVoltar.TabIndex = 34;
            pbVoltar.TabStop = false;
            pbVoltar.Click += pbVoltar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(708, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 79);
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Schoolbook", 5F, FontStyle.Bold);
            label9.Location = new Point(710, 93);
            label9.Name = "label9";
            label9.Size = new Size(77, 13);
            label9.TabIndex = 59;
            label9.Text = "New_Pharma";
            // 
            // FormCadastroDeProduto
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSpringGreen;
            ClientSize = new Size(800, 800);
            Controls.Add(label9);
            Controls.Add(pictureBox1);
            Controls.Add(pbVoltar);
            Controls.Add(pnDados);
            Controls.Add(btnInserir);
            Controls.Add(pnBotao);
            Controls.Add(label1);
            Font = new Font("Century Schoolbook", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCadastroDeProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro De Produto";
            Load += FormCadastroDeProduto_Load;
            pnBotao.ResumeLayout(false);
            pnDados.ResumeLayout(false);
            pnDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbVoltar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSalvar;
        private Button btnInserir;
        private Panel pnBotao;
        private Button btnCancelar;
        private TextBox txtNome;
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
        private PictureBox pbVoltar;
        private Label label2;
        private DateTimePicker dtpDataValidade;
        private PictureBox pictureBox1;
        private Label label9;
    }
}