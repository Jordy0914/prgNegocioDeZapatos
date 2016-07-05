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
            this.Insertar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Modificar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Eliminar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Consultar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(407, 326);
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
            this.NombreVista,
            this.Insertar,
            this.Modificar,
            this.Eliminar,
            this.Consultar});
            this.lvGeneral.Cursor = System.Windows.Forms.Cursors.Default;
            this.lvGeneral.FullRowSelect = true;
            this.lvGeneral.GridLines = true;
            this.lvGeneral.Location = new System.Drawing.Point(30, 86);
            this.lvGeneral.Name = "lvGeneral";
            this.lvGeneral.Size = new System.Drawing.Size(811, 216);
            this.lvGeneral.TabIndex = 3;
            this.lvGeneral.UseCompatibleStateImageBehavior = false;
            this.lvGeneral.View = System.Windows.Forms.View.Details;
            this.lvGeneral.SelectedIndexChanged += new System.EventHandler(this.lvLista_SelectedIndexChanged);
            this.lvGeneral.DoubleClick += new System.EventHandler(this.lvLista_DoubleClick);
            // 
            // CodigoRol
            // 
            this.CodigoRol.Text = "Codigo";
            this.CodigoRol.Width = 45;
            // 
            // NombreRol
            // 
            this.NombreRol.Text = "Nombre ";
            this.NombreRol.Width = 204;
            // 
            // CodigoVista
            // 
            this.CodigoVista.Text = "Codigo";
            this.CodigoVista.Width = 45;
            // 
            // NombreVista
            // 
            this.NombreVista.Text = "Nombre ";
            this.NombreVista.Width = 295;
            // 
            // Insertar
            // 
            this.Insertar.Text = "Insertar";
            this.Insertar.Width = 51;
            // 
            // Modificar
            // 
            this.Modificar.Text = "Modificar";
            this.Modificar.Width = 56;
            // 
            // Eliminar
            // 
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.Width = 50;
            // 
            // Consultar
            // 
            this.Consultar.Text = "Consultar";
            this.Consultar.Width = 59;
            // 
            // frmModificarRolesVistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 386);
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
        private System.Windows.Forms.ColumnHeader Insertar;
        private System.Windows.Forms.ColumnHeader Modificar;
        private System.Windows.Forms.ColumnHeader Eliminar;
        private System.Windows.Forms.ColumnHeader Consultar;
    }
}