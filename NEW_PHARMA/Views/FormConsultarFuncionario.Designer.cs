namespace Views
{
    partial class FormConsultarFuncionario
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
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(204, 21);
            label1.Name = "label1";
            label1.Size = new Size(382, 30);
            label1.TabIndex = 0;
            label1.Text = "CADASTRAR FUNCIONARIO";
            // 
            // panel1
            // 
            panel1.Location = new Point(21, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(755, 377);
            panel1.TabIndex = 1;
            // 
            // FormConsultarFuncionario
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(panel1);
            Controls.Add(label1);
            Font = new Font("Century Schoolbook", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormConsultarFuncionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormConsultarFuncionario";
            Load += FormConsultarFuncionario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
    }
}