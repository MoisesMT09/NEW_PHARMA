namespace Views
{
    partial class FormModeloDeCadastro
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
            pnDados = new Panel();
            pnBotao = new Panel();
            btnExcluir = new Button();
            btnCancelar = new Button();
            btnSalvar = new Button();
            btnAlterar = new Button();
            btnLocalizar = new Button();
            btnInserir = new Button();
            pnBotao.SuspendLayout();
            SuspendLayout();
            // 
            // pnDados
            // 
            pnDados.Location = new Point(12, 9);
            pnDados.Name = "pnDados";
            pnDados.Size = new Size(755, 390);
            pnDados.TabIndex = 0;
            // 
            // pnBotao
            // 
            pnBotao.Controls.Add(btnExcluir);
            pnBotao.Controls.Add(btnCancelar);
            pnBotao.Controls.Add(btnSalvar);
            pnBotao.Controls.Add(btnAlterar);
            pnBotao.Controls.Add(btnLocalizar);
            pnBotao.Controls.Add(btnInserir);
            pnBotao.Location = new Point(12, 413);
            pnBotao.Name = "pnBotao";
            pnBotao.Size = new Size(755, 120);
            pnBotao.TabIndex = 1;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(248, 27);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(82, 82);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "EXCLUIR\r\n";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(637, 27);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 82);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(502, 27);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(82, 82);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(376, 27);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(82, 82);
            btnAlterar.TabIndex = 1;
            btnAlterar.Text = "ALTERAR";
            btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnLocalizar
            // 
            btnLocalizar.Location = new Point(130, 27);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.Size = new Size(82, 82);
            btnLocalizar.TabIndex = 0;
            btnLocalizar.Text = "LOCALIZAR";
            btnLocalizar.UseVisualStyleBackColor = true;
            btnLocalizar.Click += button2_Click;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(20, 27);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(82, 82);
            btnInserir.TabIndex = 0;
            btnInserir.Text = "INSERIR\r\n";
            btnInserir.UseVisualStyleBackColor = true;
            // 
            // FormModeloDeCadastro
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 544);
            Controls.Add(pnBotao);
            Controls.Add(pnDados);
            Font = new Font("Segoe UI", 10F);
            Name = "FormModeloDeCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Modelo De Formulario de Cadastro";
            Load += FormModeloDeCadastro_Load;
            pnBotao.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnDados;
        private Panel pnBotao;
        private Button btnLocalizar;
        private Button btnInserir;
        private Button btnExcluir;
        private Button btnCancelar;
        private Button btnSalvar;
        private Button btnAlterar;
    }
}