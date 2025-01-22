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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTelaDeApresentacao));
            btnEntrar = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            panel4 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            label1 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.DodgerBlue;
            btnEntrar.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold);
            btnEntrar.Location = new Point(41, 176);
            btnEntrar.Margin = new Padding(2);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(145, 35);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "LOGIN";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(82, 376);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 14);
            label3.TabIndex = 3;
            label3.Text = "BEM-VINDO";
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(434, 376);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(23, 20);
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Red;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(188, 11);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(23, 20);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 31;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(630, 420);
            panel3.TabIndex = 33;
            // 
            // panel4
            // 
            panel4.BackColor = Color.MediumSpringGreen;
            panel4.Controls.Add(btnEntrar);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(pictureBox3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(408, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(222, 420);
            panel4.TabIndex = 34;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Menu;
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(408, 420);
            panel1.TabIndex = 32;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumSpringGreen;
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(70, 420);
            panel2.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(70, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(70, 420);
            panel5.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BackColor = Color.MediumSpringGreen;
            panel6.Controls.Add(label4);
            panel6.Controls.Add(pictureBox2);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(label1);
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(140, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(205, 420);
            panel6.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(345, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(62, 420);
            panel7.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 209);
            label1.Name = "label1";
            label1.Size = new Size(162, 23);
            label1.TabIndex = 0;
            label1.Text = "NEW_PHARMA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 6F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 232);
            label2.Name = "label2";
            label2.Size = new Size(190, 14);
            label2.TabIndex = 1;
            label2.Text = "A MELHOR PARCEIRA PARA A SUA SAÚDE";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(27, 69);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(145, 137);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Schoolbook", 6.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.Location = new Point(9, 397);
            label4.Name = "label4";
            label4.Size = new Size(171, 15);
            label4.TabIndex = 3;
            label4.Text = "MOISÉS MASSAQUIA TCHIPANGA";
            // 
            // FormTelaDeApresentacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 420);
            Controls.Add(panel3);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FormTelaDeApresentacao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela De Apresentação";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnEntrar;
        private Label label3;
        private PictureBox pictureBox1;
        private Panel panel3;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Panel panel4;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label1;
        private Label label4;
    }
}