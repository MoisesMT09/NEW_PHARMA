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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroDeCategoria));
            pnBotao = new Panel();
            btnCancelar = new Button();
            btnSalvar = new Button();
            btnInserir = new Button();
            pnDados = new Panel();
            label2 = new Label();
            txtNome = new TextBox();
            label3 = new Label();
            pbVoltar = new PictureBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            pnBotao.SuspendLayout();
            pnDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbVoltar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnBotao
            // 
            pnBotao.BorderStyle = BorderStyle.Fixed3D;
            pnBotao.Controls.Add(btnCancelar);
            pnBotao.Controls.Add(btnSalvar);
            pnBotao.Location = new Point(12, 698);
            pnBotao.Name = "pnBotao";
            pnBotao.Size = new Size(776, 90);
            pnBotao.TabIndex = 3;
            pnBotao.MouseDown += pnBotao_MouseDown;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold);
            btnCancelar.Location = new Point(25, 27);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(285, 40);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Lime;
            btnSalvar.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold);
            btnSalvar.Location = new Point(470, 27);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(285, 40);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
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
            pnDados.BorderStyle = BorderStyle.Fixed3D;
            pnDados.Controls.Add(label2);
            pnDados.Controls.Add(txtNome);
            pnDados.Location = new Point(12, 149);
            pnDados.Name = "pnDados";
            pnDados.Size = new Size(776, 543);
            pnDados.TabIndex = 2;
            pnDados.MouseDown += pnDados_MouseDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            label2.Location = new Point(152, 162);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 1;
            label2.Text = "NOME";
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.Menu;
            txtNome.Location = new Point(152, 190);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(518, 32);
            txtNome.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(221, 25);
            label3.Name = "label3";
            label3.Size = new Size(374, 30);
            label3.TabIndex = 4;
            label3.Text = "CADASTRO DE CATEGORIA";
            // 
            // pbVoltar
            // 
            pbVoltar.Image = (Image)resources.GetObject("pbVoltar.Image");
            pbVoltar.Location = new Point(12, 25);
            pbVoltar.Name = "pbVoltar";
            pbVoltar.Size = new Size(39, 35);
            pbVoltar.TabIndex = 34;
            pbVoltar.TabStop = false;
            pbVoltar.Click += pbVoltar_Click;
            pbVoltar.MouseDown += pbVoltar_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(709, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 79);
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Schoolbook", 5F, FontStyle.Bold);
            label4.Location = new Point(709, 107);
            label4.Name = "label4";
            label4.Size = new Size(77, 13);
            label4.TabIndex = 59;
            label4.Text = "New_Pharma";
            // 
            // FormCadastroDeCategoria
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSpringGreen;
            ClientSize = new Size(800, 800);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
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
            MouseDown += FormCadastroDeCategoria_MouseDown;
            pnBotao.ResumeLayout(false);
            pnDados.ResumeLayout(false);
            pnDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbVoltar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnBotao;
        private Button btnCancelar;
        private Button btnSalvar;
        private Button btnInserir;
        private Panel pnDados;
        private Label label2;
        private Label label1;
        private TextBox txtNome;
        private Label label3;
        private PictureBox pbVoltar;
        private PictureBox pictureBox1;
        private Label label4;
    }
}