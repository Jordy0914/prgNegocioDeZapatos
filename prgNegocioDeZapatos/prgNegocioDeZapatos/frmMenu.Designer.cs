namespace prgNegocioDeZapatos
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarRolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarRolToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesToolStripMenuItem,
            this.ventasToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // reportesToolStripMenuItem
            // 
            resources.ApplyResources(this.reportesToolStripMenuItem, "reportesToolStripMenuItem");
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedoresToolStripMenuItem1,
            this.usuariosToolStripMenuItem,
            this.rolesToolStripMenuItem1,
            this.ventasToolStripMenuItem1,
            this.reportesToolStripMenuItem1});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            // 
            // proveedoresToolStripMenuItem1
            // 
            resources.ApplyResources(this.proveedoresToolStripMenuItem1, "proveedoresToolStripMenuItem1");
            this.proveedoresToolStripMenuItem1.Name = "proveedoresToolStripMenuItem1";
            // 
            // usuariosToolStripMenuItem
            // 
            resources.ApplyResources(this.usuariosToolStripMenuItem, "usuariosToolStripMenuItem");
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            // 
            // rolesToolStripMenuItem1
            // 
            resources.ApplyResources(this.rolesToolStripMenuItem1, "rolesToolStripMenuItem1");
            this.rolesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignarRolToolStripMenuItem,
            this.asignarRolToolStripMenuItem1});
            this.rolesToolStripMenuItem1.Name = "rolesToolStripMenuItem1";
            // 
            // asignarRolToolStripMenuItem
            // 
            resources.ApplyResources(this.asignarRolToolStripMenuItem, "asignarRolToolStripMenuItem");
            this.asignarRolToolStripMenuItem.Name = "asignarRolToolStripMenuItem";
            // 
            // asignarRolToolStripMenuItem1
            // 
            resources.ApplyResources(this.asignarRolToolStripMenuItem1, "asignarRolToolStripMenuItem1");
            this.asignarRolToolStripMenuItem1.Name = "asignarRolToolStripMenuItem1";
            // 
            // ventasToolStripMenuItem1
            // 
            resources.ApplyResources(this.ventasToolStripMenuItem1, "ventasToolStripMenuItem1");
            this.ventasToolStripMenuItem1.Name = "ventasToolStripMenuItem1";
            // 
            // reportesToolStripMenuItem1
            // 
            resources.ApplyResources(this.reportesToolStripMenuItem1, "reportesToolStripMenuItem1");
            this.reportesToolStripMenuItem1.Name = "reportesToolStripMenuItem1";
            // 
            // ventasToolStripMenuItem
            // 
            resources.ApplyResources(this.ventasToolStripMenuItem, "ventasToolStripMenuItem");
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            // 
            // frmMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem asignarRolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarRolToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem1;
    }
}