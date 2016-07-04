namespace prgNegocioDeZapatos
{
    partial class frmModificarRolesVistas
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
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lvGeneral = new System.Windows.Forms.ListView();
            this.CodigoRol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NombreRol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CodigoVista = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NombreVista = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(256, 325);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(87, 31);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir\r\n";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lvGeneral
            // 
            this.lvGeneral.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvGeneral.BackColor = System.Drawing.Color.White;
            this.lvGeneral.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CodigoRol,
            this.NombreRol,
            this.CodigoVista,
            this.NombreVista});
            this.lvGeneral.Cursor = System.Windows.Forms.Cursors.Default;
            this.lvGeneral.FullRowSelect = true;
            this.lvGeneral.GridLines = true;
            this.lvGeneral.Location = new System.Drawing.Point(30, 87);
            this.lvGeneral.Name = "lvGeneral";
            this.lvGeneral.Size = new System.Drawing.Size(581, 216);
            this.lvGeneral.TabIndex = 3;
            this.lvGeneral.UseCompatibleStateImageBehavior = false;
            this.lvGeneral.View = System.Windows.Forms.View.Details;
            // 
            // CodigoRol
            // 
            this.CodigoRol.Text = "Codigo";
            this.CodigoRol.Width = 52;
            // 
            // NombreRol
            // 
            this.NombreRol.Text = "Nombre Rol";
            this.NombreRol.Width = 178;
            // 
            // CodigoVista
            // 
            this.CodigoVista.Text = "Codigo";
            this.CodigoVista.Width = 52;
            // 
            // NombreVista
            // 
            this.NombreVista.Text = "Nombre Vista";
            this.NombreVista.Width = 295;
            // 
            // frmModificarRolesVistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 386);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lvGeneral);
            this.Name = "frmModificarRolesVistas";
            this.Text = "Modificar Roles Vistas";
            this.Load += new System.EventHandler(this.frmModificarRolesVistas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private System.Windows.Forms.ListView lvGeneral;
        private System.Windows.Forms.ColumnHeader CodigoRol;
        private System.Windows.Forms.ColumnHeader NombreRol;
        private System.Windows.Forms.ColumnHeader CodigoVista;
        private System.Windows.Forms.ColumnHeader NombreVista;
    }
}