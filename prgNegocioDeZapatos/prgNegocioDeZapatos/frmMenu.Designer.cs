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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuRoles = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarRolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarRolToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesToolStripMenuItem,
            this.ventasToolStripMenuItem});
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Name = "menuStrip";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuProveedores,
            this.subMenuUsuario,
            this.subMenuRoles,
            this.subMenuVentas,
            this.subMenuReportes});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            resources.ApplyResources(this.reportesToolStripMenuItem, "reportesToolStripMenuItem");
            // 
            // subMenuProveedores
            // 
            this.subMenuProveedores.Name = "subMenuProveedores";
            resources.ApplyResources(this.subMenuProveedores, "subMenuProveedores");
            // 
            // subMenuUsuario
            // 
            this.subMenuUsuario.Name = "subMenuUsuario";
            resources.ApplyResources(this.subMenuUsuario, "subMenuUsuario");
            this.subMenuUsuario.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // subMenuRoles
            // 
            this.subMenuRoles.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignarRolToolStripMenuItem,
            this.asignarRolToolStripMenuItem1});
            this.subMenuRoles.Name = "subMenuRoles";
            resources.ApplyResources(this.subMenuRoles, "subMenuRoles");
            // 
            // asignarRolToolStripMenuItem
            // 
            this.asignarRolToolStripMenuItem.Name = "asignarRolToolStripMenuItem";
            resources.ApplyResources(this.asignarRolToolStripMenuItem, "asignarRolToolStripMenuItem");
            this.asignarRolToolStripMenuItem.Click += new System.EventHandler(this.asignarRolToolStripMenuItem_Click);
            // 
            // asignarRolToolStripMenuItem1
            // 
            this.asignarRolToolStripMenuItem1.Name = "asignarRolToolStripMenuItem1";
            resources.ApplyResources(this.asignarRolToolStripMenuItem1, "asignarRolToolStripMenuItem1");
            this.asignarRolToolStripMenuItem1.Click += new System.EventHandler(this.asignarRolToolStripMenuItem1_Click);
            // 
            // subMenuVentas
            // 
            this.subMenuVentas.Name = "subMenuVentas";
            resources.ApplyResources(this.subMenuVentas, "subMenuVentas");
            // 
            // subMenuReportes
            // 
            this.subMenuReportes.Name = "subMenuReportes";
            resources.ApplyResources(this.subMenuReportes, "subMenuReportes");
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            resources.ApplyResources(this.ventasToolStripMenuItem, "ventasToolStripMenuItem");
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subMenuProveedores;
        private System.Windows.Forms.ToolStripMenuItem subMenuUsuario;
        private System.Windows.Forms.ToolStripMenuItem subMenuRoles;
        private System.Windows.Forms.ToolStripMenuItem asignarRolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarRolToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem subMenuVentas;
        private System.Windows.Forms.ToolStripMenuItem subMenuReportes;
    }
}