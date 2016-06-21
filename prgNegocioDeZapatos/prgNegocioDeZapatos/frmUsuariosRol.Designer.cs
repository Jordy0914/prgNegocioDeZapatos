namespace prgNegocioDeZapatos
{
    partial class frmUsuariosRol
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
            this.lsvUsuariosRol = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSalir = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // lsvUsuariosRol
            // 
            this.lsvUsuariosRol.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lsvUsuariosRol.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lsvUsuariosRol.FullRowSelect = true;
            this.lsvUsuariosRol.GridLines = true;
            this.lsvUsuariosRol.Location = new System.Drawing.Point(64, 89);
            this.lsvUsuariosRol.Name = "lsvUsuariosRol";
            this.lsvUsuariosRol.Size = new System.Drawing.Size(260, 97);
            this.lsvUsuariosRol.TabIndex = 0;
            this.lsvUsuariosRol.UseCompatibleStateImageBehavior = false;
            this.lsvUsuariosRol.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Código usuario";
            this.columnHeader1.Width = 128;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Código Role";
            this.columnHeader2.Width = 124;
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(275, 210);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = false;
            this.btnSalir.Size = new System.Drawing.Size(49, 36);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // frmUsuariosRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 261);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lsvUsuariosRol);
            this.Name = "frmUsuariosRol";
            this.Text = "Seleccionar Usuario";
            this.Load += new System.EventHandler(this.frmUsuariosRol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvUsuariosRol;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private MaterialSkin.Controls.MaterialFlatButton btnSalir;
    }
}