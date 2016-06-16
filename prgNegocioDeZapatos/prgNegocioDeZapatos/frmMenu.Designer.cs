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
            this.Seguridad = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.SuspendLayout();
            // 
            // Seguridad
            // 
            this.Seguridad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Seguridad.Depth = 0;
            this.Seguridad.MouseState = MaterialSkin.MouseState.HOVER;
            this.Seguridad.Name = "Seguridad";
            this.Seguridad.ShowImageMargin = false;
            this.Seguridad.Size = new System.Drawing.Size(36, 4);
            this.Seguridad.Text = "msSeguridad";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 261);
            this.Name = "frmMenu";
            this.Text = "Menú Principal";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialContextMenuStrip Seguridad;
    }
}