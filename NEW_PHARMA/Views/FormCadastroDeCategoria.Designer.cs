namespace Views
{
    partial class FormCadastroDeCategoria
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
            pnBotao = new Panel();
            btnExcluir = new Button();
            btnCancelar = new Button();
            btnSalvar = new Button();
            btnAlterar = new Button();
            btnLocalizar = new Button();
            btnInserir = new Button();
            pnDados = new Panel();
            label2 = new Label();
            label1 = new Label();
            txtNome = new TextBox();
            txtID = new TextBox();
            pnBotao.SuspendLayout();
            pnDados.SuspendLayout();
            SuspendLayout();
            // 
            // pnBotao
            // 
            pnBotao.Controls.Add(btnExcluir);
            pnBotao.Controls.Add(btnCancelar);
            pnBotao.Controls.Add(btnSalvar);
            pnBotao.Controls.Add(btnAlterar);
            pnBotao.Controls.Add(btnLocalizar);
            pnBotao.Controls.Add(btnInserir);
            pnBotao.Location = new Point(12, 416);
            pnBotao.Name = "pnBotao";
            pnBotao.Size = new Size(755, 120);
            pnBotao.TabIndex = 3;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            btnExcluir.Location = new Point(277, 19);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(82, 82);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "EXCLUIR\r\n";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            btnCancelar.Location = new Point(640, 19);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 82);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            btnSalvar.Location = new Point(519, 19);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(82, 82);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            btnAlterar.Location = new Point(398, 19);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(82, 82);
            btnAlterar.TabIndex = 1;
            btnAlterar.Text = "ALTERAR";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnLocalizar
            // 
            btnLocalizar.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            btnLocalizar.Location = new Point(156, 19);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.Size = new Size(82, 82);
            btnLocalizar.TabIndex = 0;
            btnLocalizar.Text = "LOCALIZAR";
            btnLocalizar.UseVisualStyleBackColor = true;
            btnLocalizar.Click += btnLocalizar_Click;
            // 
            // btnInserir
            // 
            btnInserir.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            btnInserir.Location = new Point(35, 19);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(82, 82);
            btnInserir.TabIndex = 0;
            btnInserir.Text = "INSERIR\r\n";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // pnDados
            // 
            pnDados.Controls.Add(label2);
            pnDados.Controls.Add(label1);
            pnDados.Controls.Add(txtNome);
            pnDados.Controls.Add(txtID);
            pnDados.Location = new Point(12, 12);
            pnDados.Name = "pnDados";
            pnDados.Size = new Size(755, 390);
            pnDados.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            label2.Location = new Point(52, 152);
            label2.Name = "label2";
            label2.Size = new Size(70, 23);
            label2.TabIndex = 1;
            label2.Text = "NOME";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            label1.Location = new Point(52, 31);
            label1.Name = "label1";
            label1.Size = new Size(30, 23);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(46, 193);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(555, 32);
            txtNome.TabIndex = 1;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(46, 78);
            txtID.Name = "txtID";
            txtID.Size = new Size(313, 32);
            txtID.TabIndex = 1;
            // 
            // FormCadastroDeCategoria
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 544);
            Controls.Add(pnBotao);
            Controls.Add(pnDados);
            Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormCadastroDeCategoria";
            RightToLeft = RightToLeft.No;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro De Categoria";
            Load += FormCadastroDeCategoria_Load;
            pnBotao.ResumeLayout(false);
            pnDados.ResumeLayout(false);
            pnDados.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnBotao;
        private Button btnExcluir;
        private Button btnCancelar;
        private Button btnSalvar;
        private Button btnAlterar;
        private Button btnLocalizar;
        private Button btnInserir;
        private Panel pnDados;
        private Label label2;
        private Label label1;
        private TextBox txtNome;
        private TextBox txtID;
    }
}