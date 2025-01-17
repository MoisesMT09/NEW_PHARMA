namespace Views
{
    partial class FormSenhaAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSenhaAdministrador));
            txtSenha = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            btnCancelar = new Button();
            btnConfirmar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtSenha
            // 
            txtSenha.BackColor = SystemColors.Menu;
            txtSenha.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold);
            txtSenha.Location = new Point(103, 190);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(389, 36);
            txtSenha.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(506, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 102);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            label1.Location = new Point(182, 32);
            label1.Name = "label1";
            label1.Size = new Size(268, 25);
            label1.TabIndex = 2;
            label1.Text = "Senha Do Administrador";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold);
            label2.Location = new Point(103, 146);
            label2.Name = "label2";
            label2.Size = new Size(253, 21);
            label2.TabIndex = 3;
            label2.Text = "Digte a do Administrador ";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            btnCancelar.Location = new Point(103, 245);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 42);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.DodgerBlue;
            btnConfirmar.Font = new Font("Century Schoolbook", 10F, FontStyle.Bold);
            btnConfirmar.Location = new Point(362, 245);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(130, 42);
            btnConfirmar.TabIndex = 5;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // FormSenhaAdministrador
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSpringGreen;
            ClientSize = new Size(620, 450);
            Controls.Add(btnConfirmar);
            Controls.Add(btnCancelar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(txtSenha);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSenhaAdministrador";
            Text = "FormSenhaAdministrador";
            Load += FormSenhaAdministrador_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSenha;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button btnCancelar;
        private Button btnConfirmar;
    }
}