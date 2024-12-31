namespace Views
{
    partial class FormTelaDeApresentacao
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
            label1 = new Label();
            label2 = new Label();
            btnEntrar = new Button();
            label3 = new Label();
            pnCores = new Panel();
            pnCores.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(71, 217);
            label1.Name = "label1";
            label1.Size = new Size(235, 38);
            label1.TabIndex = 0;
            label1.Text = "NEW FARMA";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(80, 264);
            label2.Name = "label2";
            label2.Size = new Size(203, 20);
            label2.TabIndex = 1;
            label2.Text = "QUEREMOS - TE BEM";
            label2.Click += label2_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.Cyan;
            btnEntrar.Font = new Font("Century", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.Location = new Point(429, 222);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(242, 73);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "ENTRAR";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(462, 487);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 3;
            label3.Text = "BEM-VINDO";
            label3.Click += label3_Click;
            // 
            // pnCores
            // 
            pnCores.BackColor = Color.Cyan;
            pnCores.BorderStyle = BorderStyle.FixedSingle;
            pnCores.Controls.Add(label2);
            pnCores.Controls.Add(label1);
            pnCores.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnCores.ForeColor = Color.White;
            pnCores.Location = new Point(-3, -1);
            pnCores.Name = "pnCores";
            pnCores.Size = new Size(389, 544);
            pnCores.TabIndex = 4;
            // 
            // FormTelaDeApresentacao
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 544);
            Controls.Add(pnCores);
            Controls.Add(label3);
            Controls.Add(btnEntrar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormTelaDeApresentacao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela De Apresentação";
            pnCores.ResumeLayout(false);
            pnCores.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnEntrar;
        private Label label3;
        private Panel pnCores;
    }
}