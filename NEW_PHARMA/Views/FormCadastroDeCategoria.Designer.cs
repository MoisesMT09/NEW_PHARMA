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
            btnInserir = new Button();
            pnDados = new Panel();
            label2 = new Label();
            txtNome = new TextBox();
            label3 = new Label();
            pbVoltar = new PictureBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            pnBotao = new Panel();
            label9 = new Label();
            pictureBox2 = new PictureBox();
            pnDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbVoltar).BeginInit();
            pnBotao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnInserir
            // 
            btnInserir.BackColor = Color.DodgerBlue;
            btnInserir.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold);
            btnInserir.Location = new Point(12, 108);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(250, 35);
            btnInserir.TabIndex = 0;
            btnInserir.Text = "INSERIR\r\n";
            btnInserir.UseVisualStyleBackColor = false;
            btnInserir.Click += btnInserir_Click;
            // 
            // pnDados
            // 
            pnDados.BackColor = Color.MediumSpringGreen;
            pnDados.BorderStyle = BorderStyle.Fixed3D;
            pnDados.Controls.Add(label2);
            pnDados.Controls.Add(txtNome);
            pnDados.Location = new Point(12, 149);
            pnDados.Name = "pnDados";
            pnDados.Size = new Size(588, 239);
            pnDados.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            label2.Location = new Point(30, 44);
            label2.Name = "label2";
            label2.Size = new Size(57, 17);
            label2.TabIndex = 1;
            label2.Text = "NOME";
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.Menu;
            txtNome.Location = new Point(30, 72);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(518, 24);
            txtNome.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold | FontStyle.Underline);
            label3.Location = new Point(190, 26);
            label3.Name = "label3";
            label3.Size = new Size(248, 19);
            label3.TabIndex = 4;
            label3.Text = "CADASTRO DE CATEGORIA";
            // 
            // pbVoltar
            // 
            pbVoltar.Image = Properties.Resources.back_112351;
            pbVoltar.Location = new Point(12, 12);
            pbVoltar.Name = "pbVoltar";
            pbVoltar.Size = new Size(50, 46);
            pbVoltar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbVoltar.TabIndex = 34;
            pbVoltar.TabStop = false;
            pbVoltar.Click += pbVoltar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Lime;
            btnSalvar.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold);
            btnSalvar.Location = new Point(303, 27);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(261, 40);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold);
            btnCancelar.Location = new Point(14, 27);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(236, 40);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pnBotao
            // 
            pnBotao.BorderStyle = BorderStyle.Fixed3D;
            pnBotao.Controls.Add(btnCancelar);
            pnBotao.Controls.Add(btnSalvar);
            pnBotao.Location = new Point(10, 394);
            pnBotao.Name = "pnBotao";
            pnBotao.Size = new Size(590, 90);
            pnBotao.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Schoolbook", 6F, FontStyle.Bold);
            label9.Location = new Point(528, 74);
            label9.Name = "label9";
            label9.Size = new Size(70, 12);
            label9.TabIndex = 39;
            label9.Text = "NEW_PHARMA";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.medicine_icon_icons_com_66070;
            pictureBox2.Location = new Point(528, 11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(72, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 38;
            pictureBox2.TabStop = false;
            // 
            // FormCadastroDeCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSpringGreen;
            ClientSize = new Size(612, 500);
            Controls.Add(label9);
            Controls.Add(pictureBox2);
            Controls.Add(pbVoltar);
            Controls.Add(label3);
            Controls.Add(btnInserir);
            Controls.Add(pnBotao);
            Controls.Add(pnDados);
            Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormCadastroDeCategoria";
            RightToLeft = RightToLeft.No;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro De Categoria";
            Load += FormCadastroDeCategoria_Load;
            pnDados.ResumeLayout(false);
            pnDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbVoltar).EndInit();
            pnBotao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnInserir;
        private Panel pnDados;
        private Label label2;
        private TextBox txtNome;
        private Label label3;
        private PictureBox pbVoltar;
        private Button btnSalvar;
        private Button btnCancelar;
        private Panel pnBotao;
        private Label label9;
        private PictureBox pictureBox2;
    }
}