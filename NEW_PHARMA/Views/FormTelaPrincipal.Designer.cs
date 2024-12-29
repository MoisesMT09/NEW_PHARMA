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
            Menu = new MenuStrip();
            CadastroMenuPrincipal = new ToolStripMenuItem();
            cONSUTAToolStripMenuItem = new ToolStripMenuItem();
            rESISTARVENDASToolStripMenuItem = new ToolStripMenuItem();
            rELATORIOToolStripMenuItem = new ToolStripMenuItem();
            sOBREToolStripMenuItem = new ToolStripMenuItem();
            cATEGORIAToolStripMenuItem = new ToolStripMenuItem();
            fORNECEDORToolStripMenuItem = new ToolStripMenuItem();
            pRODUTOToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            fUNCIONARIOToolStripMenuItem = new ToolStripMenuItem();
            cLIENTEToolStripMenuItem = new ToolStripMenuItem();
            Menu.SuspendLayout();
            SuspendLayout();
            // 
            // Menu
            // 
            resources.ApplyResources(Menu, "Menu");
            Menu.ImageScalingSize = new Size(24, 24);
            Menu.Items.AddRange(new ToolStripItem[] { CadastroMenuPrincipal, cONSUTAToolStripMenuItem, rESISTARVENDASToolStripMenuItem, rELATORIOToolStripMenuItem, sOBREToolStripMenuItem });
            Menu.Name = "Menu";
            // 
            // CadastroMenuPrincipal
            // 
            resources.ApplyResources(CadastroMenuPrincipal, "CadastroMenuPrincipal");
            CadastroMenuPrincipal.DropDownItems.AddRange(new ToolStripItem[] { cATEGORIAToolStripMenuItem, fORNECEDORToolStripMenuItem, pRODUTOToolStripMenuItem, toolStripSeparator1, fUNCIONARIOToolStripMenuItem, cLIENTEToolStripMenuItem });
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
            // cATEGORIAToolStripMenuItem
            // 
            resources.ApplyResources(cATEGORIAToolStripMenuItem, "cATEGORIAToolStripMenuItem");
            cATEGORIAToolStripMenuItem.Name = "cATEGORIAToolStripMenuItem";
            // 
            // fORNECEDORToolStripMenuItem
            // 
            resources.ApplyResources(fORNECEDORToolStripMenuItem, "fORNECEDORToolStripMenuItem");
            fORNECEDORToolStripMenuItem.Name = "fORNECEDORToolStripMenuItem";
            // 
            // pRODUTOToolStripMenuItem
            // 
            resources.ApplyResources(pRODUTOToolStripMenuItem, "pRODUTOToolStripMenuItem");
            pRODUTOToolStripMenuItem.Name = "pRODUTOToolStripMenuItem";
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(toolStripSeparator1, "toolStripSeparator1");
            toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // fUNCIONARIOToolStripMenuItem
            // 
            resources.ApplyResources(fUNCIONARIOToolStripMenuItem, "fUNCIONARIOToolStripMenuItem");
            fUNCIONARIOToolStripMenuItem.Name = "fUNCIONARIOToolStripMenuItem";
            // 
            // cLIENTEToolStripMenuItem
            // 
            resources.ApplyResources(cLIENTEToolStripMenuItem, "cLIENTEToolStripMenuItem");
            cLIENTEToolStripMenuItem.Name = "cLIENTEToolStripMenuItem";
            // 
            // FormTelaPrincipal
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Menu);
            MainMenuStrip = Menu;
            Name = "FormTelaPrincipal";
            Load += FormTelaPrincipal_Load;
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip Menu;
        private ToolStripMenuItem CadastroMenuPrincipal;
        private ToolStripMenuItem cONSUTAToolStripMenuItem;
        private ToolStripMenuItem rESISTARVENDASToolStripMenuItem;
        private ToolStripMenuItem rELATORIOToolStripMenuItem;
        private ToolStripMenuItem sOBREToolStripMenuItem;
        private ToolStripMenuItem cATEGORIAToolStripMenuItem;
        private ToolStripMenuItem fORNECEDORToolStripMenuItem;
        private ToolStripMenuItem pRODUTOToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem fUNCIONARIOToolStripMenuItem;
        private ToolStripMenuItem cLIENTEToolStripMenuItem;
    }
}