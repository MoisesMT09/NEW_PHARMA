namespace Views
{
    partial class FormTelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTelaPrincipal));
            menuStrip1 = new MenuStrip();
            CadastroMenuPrincipal = new ToolStripMenuItem();
            cONSUTAToolStripMenuItem = new ToolStripMenuItem();
            rESISTARVENDASToolStripMenuItem = new ToolStripMenuItem();
            rELATORIOToolStripMenuItem = new ToolStripMenuItem();
            sOBREToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { CadastroMenuPrincipal, cONSUTAToolStripMenuItem, rESISTARVENDASToolStripMenuItem, rELATORIOToolStripMenuItem, sOBREToolStripMenuItem });
            menuStrip1.Name = "menuStrip1";
            // 
            // CadastroMenuPrincipal
            // 
            resources.ApplyResources(CadastroMenuPrincipal, "CadastroMenuPrincipal");
            CadastroMenuPrincipal.Name = "CadastroMenuPrincipal";
            CadastroMenuPrincipal.Click += CadastroMenuPrincipal_Click;
            // 
            // cONSUTAToolStripMenuItem
            // 
            resources.ApplyResources(cONSUTAToolStripMenuItem, "cONSUTAToolStripMenuItem");
            cONSUTAToolStripMenuItem.Name = "cONSUTAToolStripMenuItem";
            // 
            // rESISTARVENDASToolStripMenuItem
            // 
            resources.ApplyResources(rESISTARVENDASToolStripMenuItem, "rESISTARVENDASToolStripMenuItem");
            rESISTARVENDASToolStripMenuItem.Name = "rESISTARVENDASToolStripMenuItem";
            // 
            // rELATORIOToolStripMenuItem
            // 
            resources.ApplyResources(rELATORIOToolStripMenuItem, "rELATORIOToolStripMenuItem");
            rELATORIOToolStripMenuItem.Name = "rELATORIOToolStripMenuItem";
            // 
            // sOBREToolStripMenuItem
            // 
            resources.ApplyResources(sOBREToolStripMenuItem, "sOBREToolStripMenuItem");
            sOBREToolStripMenuItem.Name = "sOBREToolStripMenuItem";
            // 
            // FormTelaPrincipal
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormTelaPrincipal";
            Load += FormTelaPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem CadastroMenuPrincipal;
        private ToolStripMenuItem cONSUTAToolStripMenuItem;
        private ToolStripMenuItem rESISTARVENDASToolStripMenuItem;
        private ToolStripMenuItem rELATORIOToolStripMenuItem;
        private ToolStripMenuItem sOBREToolStripMenuItem;
    }
}