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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(492, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoUsuarioToolStripMenuItem,
            this.mantenimientoRolesToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mantenimientoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(139, 27);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // mantenimientoUsuarioToolStripMenuItem
            // 
            this.mantenimientoUsuarioToolStripMenuItem.Name = "mantenimientoUsuarioToolStripMenuItem";
            this.mantenimientoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.mantenimientoUsuarioToolStripMenuItem.Text = "Mantenimiento usuario";
            // 
            // mantenimientoRolesToolStripMenuItem
            // 
            this.mantenimientoRolesToolStripMenuItem.Name = "mantenimientoRolesToolStripMenuItem";
            this.mantenimientoRolesToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.mantenimientoRolesToolStripMenuItem.Text = "Mantenimiento roles";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 368);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoRolesToolStripMenuItem;
    }
}