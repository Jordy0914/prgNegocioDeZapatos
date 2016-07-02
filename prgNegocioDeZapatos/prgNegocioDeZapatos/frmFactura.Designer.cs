namespace prgNegocioDeZapatos
{
    partial class frmFactura
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCodProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPrecio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCantidad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSubTotal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTotal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAgregar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnModificar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNumeroF = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvProductos = new System.Windows.Forms.ListView();
            this.codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnInsertar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCantidadProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(6, 26);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(122, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Código Producto";
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.Depth = 0;
            this.txtCodProducto.Enabled = false;
            this.txtCodProducto.Hint = "";
            this.txtCodProducto.Location = new System.Drawing.Point(145, 22);
            this.txtCodProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.PasswordChar = '\0';
            this.txtCodProducto.SelectedText = "";
            this.txtCodProducto.SelectionLength = 0;
            this.txtCodProducto.SelectionStart = 0;
            this.txtCodProducto.Size = new System.Drawing.Size(142, 23);
            this.txtCodProducto.TabIndex = 1;
            this.txtCodProducto.TabStop = false;
            this.txtCodProducto.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(6, 132);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(52, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Depth = 0;
            this.txtPrecio.Hint = "";
            this.txtPrecio.Location = new System.Drawing.Point(145, 132);
            this.txtPrecio.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PasswordChar = '\0';
            this.txtPrecio.SelectedText = "";
            this.txtPrecio.SelectionLength = 0;
            this.txtPrecio.SelectionStart = 0;
            this.txtPrecio.Size = new System.Drawing.Size(142, 23);
            this.txtPrecio.TabIndex = 3;
            this.txtPrecio.TabStop = false;
            this.txtPrecio.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(6, 78);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(70, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Producto";
            // 
            // txtProducto
            // 
            this.txtProducto.Depth = 0;
            this.txtProducto.Hint = "";
            this.txtProducto.Location = new System.Drawing.Point(145, 74);
            this.txtProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.PasswordChar = '\0';
            this.txtProducto.SelectedText = "";
            this.txtProducto.SelectionLength = 0;
            this.txtProducto.SelectionStart = 0;
            this.txtProducto.Size = new System.Drawing.Size(142, 23);
            this.txtProducto.TabIndex = 5;
            this.txtProducto.TabStop = false;
            this.txtProducto.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(6, 26);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(68, 19);
            this.materialLabel4.TabIndex = 6;
            this.materialLabel4.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Depth = 0;
            this.txtCantidad.Hint = "";
            this.txtCantidad.Location = new System.Drawing.Point(145, 22);
            this.txtCantidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.PasswordChar = '\0';
            this.txtCantidad.SelectedText = "";
            this.txtCantidad.SelectionLength = 0;
            this.txtCantidad.SelectionStart = 0;
            this.txtCantidad.Size = new System.Drawing.Size(142, 23);
            this.txtCantidad.TabIndex = 7;
            this.txtCantidad.TabStop = false;
            this.txtCantidad.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(6, 71);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(69, 19);
            this.materialLabel5.TabIndex = 8;
            this.materialLabel5.Text = "SubTotal";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Depth = 0;
            this.txtSubTotal.Hint = "";
            this.txtSubTotal.Location = new System.Drawing.Point(145, 67);
            this.txtSubTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.PasswordChar = '\0';
            this.txtSubTotal.SelectedText = "";
            this.txtSubTotal.SelectionLength = 0;
            this.txtSubTotal.SelectionStart = 0;
            this.txtSubTotal.Size = new System.Drawing.Size(142, 23);
            this.txtSubTotal.TabIndex = 9;
            this.txtSubTotal.TabStop = false;
            this.txtSubTotal.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(6, 109);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(44, 19);
            this.materialLabel6.TabIndex = 10;
            this.materialLabel6.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Depth = 0;
            this.txtTotal.Hint = "";
            this.txtTotal.Location = new System.Drawing.Point(145, 109);
            this.txtTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.SelectedText = "";
            this.txtTotal.SelectionLength = 0;
            this.txtTotal.SelectionStart = 0;
            this.txtTotal.Size = new System.Drawing.Size(142, 23);
            this.txtTotal.TabIndex = 11;
            this.txtTotal.TabStop = false;
            this.txtTotal.UseSystemPasswordChar = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Depth = 0;
            this.btnAgregar.Location = new System.Drawing.Point(367, 184);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Primary = true;
            this.btnAgregar.Size = new System.Drawing.Size(79, 37);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(523, 30);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(79, 37);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Depth = 0;
            this.btnModificar.Location = new System.Drawing.Point(194, 30);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Primary = true;
            this.btnModificar.Size = new System.Drawing.Size(79, 37);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Location = new System.Drawing.Point(367, 30);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Primary = true;
            this.btnEliminar.Size = new System.Drawing.Size(79, 37);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Depth = 0;
            this.btnBuscar.Location = new System.Drawing.Point(324, 21);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Primary = true;
            this.btnBuscar.Size = new System.Drawing.Size(75, 30);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInsertar);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Location = new System.Drawing.Point(12, 544);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 81);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(482, 76);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(72, 19);
            this.materialLabel7.TabIndex = 18;
            this.materialLabel7.Text = "# Factura";
            // 
            // txtNumeroF
            // 
            this.txtNumeroF.Depth = 0;
            this.txtNumeroF.Hint = "";
            this.txtNumeroF.Location = new System.Drawing.Point(560, 72);
            this.txtNumeroF.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNumeroF.Name = "txtNumeroF";
            this.txtNumeroF.PasswordChar = '\0';
            this.txtNumeroF.SelectedText = "";
            this.txtNumeroF.SelectionLength = 0;
            this.txtNumeroF.SelectionStart = 0;
            this.txtNumeroF.Size = new System.Drawing.Size(75, 23);
            this.txtNumeroF.TabIndex = 19;
            this.txtNumeroF.TabStop = false;
            this.txtNumeroF.UseSystemPasswordChar = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCantidadProducto);
            this.groupBox2.Controls.Add(this.materialLabel8);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.materialLabel1);
            this.groupBox2.Controls.Add(this.txtCodProducto);
            this.groupBox2.Controls.Add(this.materialLabel2);
            this.groupBox2.Controls.Add(this.txtPrecio);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.materialLabel3);
            this.groupBox2.Controls.Add(this.txtProducto);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(572, 243);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion Producto";
            // 
            // lvProductos
            // 
            this.lvProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codigo});
            this.lvProductos.Location = new System.Drawing.Point(442, 372);
            this.lvProductos.Name = "lvProductos";
            this.lvProductos.Size = new System.Drawing.Size(132, 155);
            this.lvProductos.TabIndex = 21;
            this.lvProductos.UseCompatibleStateImageBehavior = false;
            this.lvProductos.View = System.Windows.Forms.View.Details;
            this.lvProductos.SelectedIndexChanged += new System.EventHandler(this.lvProductos_SelectedIndexChanged);
            // 
            // codigo
            // 
            this.codigo.Text = "Codigo Producto";
            this.codigo.Width = 127;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Depth = 0;
            this.btnInsertar.Location = new System.Drawing.Point(16, 30);
            this.btnInsertar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Primary = true;
            this.btnInsertar.Size = new System.Drawing.Size(119, 37);
            this.btnInsertar.TabIndex = 22;
            this.btnInsertar.Text = "Realizar Venta\r\n";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.materialLabel4);
            this.groupBox3.Controls.Add(this.txtSubTotal);
            this.groupBox3.Controls.Add(this.materialLabel6);
            this.groupBox3.Controls.Add(this.txtCantidad);
            this.groupBox3.Controls.Add(this.materialLabel5);
            this.groupBox3.Controls.Add(this.txtTotal);
            this.groupBox3.Location = new System.Drawing.Point(12, 373);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(344, 154);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(12, 184);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(68, 19);
            this.materialLabel8.TabIndex = 17;
            this.materialLabel8.Text = "Cantidad";
            // 
            // txtCantidadProducto
            // 
            this.txtCantidadProducto.Depth = 0;
            this.txtCantidadProducto.Hint = "";
            this.txtCantidadProducto.Location = new System.Drawing.Point(145, 180);
            this.txtCantidadProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCantidadProducto.Name = "txtCantidadProducto";
            this.txtCantidadProducto.PasswordChar = '\0';
            this.txtCantidadProducto.SelectedText = "";
            this.txtCantidadProducto.SelectionLength = 0;
            this.txtCantidadProducto.SelectionStart = 0;
            this.txtCantidadProducto.Size = new System.Drawing.Size(142, 23);
            this.txtCantidadProducto.TabIndex = 18;
            this.txtCantidadProducto.TabStop = false;
            this.txtCantidadProducto.UseSystemPasswordChar = false;
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(678, 637);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lvProductos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtNumeroF);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmFactura";
            this.Text = "Facturar";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodProducto;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrecio;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtProducto;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCantidad;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSubTotal;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTotal;
        private MaterialSkin.Controls.MaterialRaisedButton btnAgregar;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnModificar;
        private MaterialSkin.Controls.MaterialRaisedButton btnEliminar;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNumeroF;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvProductos;
        private System.Windows.Forms.ColumnHeader codigo;
        private MaterialSkin.Controls.MaterialRaisedButton btnInsertar;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCantidadProducto;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
    }
}