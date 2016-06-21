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
            this.txtCodFactura = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCodUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCodProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCantidad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSubTotal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTotal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAgregar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnModificar = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtConsultar = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtEliminar = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(13, 73);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(111, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Código Factura";
            // 
            // txtCodFactura
            // 
            this.txtCodFactura.Depth = 0;
            this.txtCodFactura.Hint = "";
            this.txtCodFactura.Location = new System.Drawing.Point(130, 73);
            this.txtCodFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodFactura.Name = "txtCodFactura";
            this.txtCodFactura.PasswordChar = '\0';
            this.txtCodFactura.SelectedText = "";
            this.txtCodFactura.SelectionLength = 0;
            this.txtCodFactura.SelectionStart = 0;
            this.txtCodFactura.Size = new System.Drawing.Size(142, 23);
            this.txtCodFactura.TabIndex = 1;
            this.txtCodFactura.TabStop = false;
            this.txtCodFactura.Text = "materialSingleLineTextField1";
            this.txtCodFactura.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(13, 119);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(113, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Código Usuario";
            // 
            // txtCodUsuario
            // 
            this.txtCodUsuario.Depth = 0;
            this.txtCodUsuario.Hint = "";
            this.txtCodUsuario.Location = new System.Drawing.Point(132, 119);
            this.txtCodUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodUsuario.Name = "txtCodUsuario";
            this.txtCodUsuario.PasswordChar = '\0';
            this.txtCodUsuario.SelectedText = "";
            this.txtCodUsuario.SelectionLength = 0;
            this.txtCodUsuario.SelectionStart = 0;
            this.txtCodUsuario.Size = new System.Drawing.Size(142, 23);
            this.txtCodUsuario.TabIndex = 3;
            this.txtCodUsuario.TabStop = false;
            this.txtCodUsuario.Text = "materialSingleLineTextField1";
            this.txtCodUsuario.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(13, 177);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(122, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Código Producto";
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.Depth = 0;
            this.txtCodProducto.Hint = "";
            this.txtCodProducto.Location = new System.Drawing.Point(141, 177);
            this.txtCodProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.PasswordChar = '\0';
            this.txtCodProducto.SelectedText = "";
            this.txtCodProducto.SelectionLength = 0;
            this.txtCodProducto.SelectionStart = 0;
            this.txtCodProducto.Size = new System.Drawing.Size(142, 23);
            this.txtCodProducto.TabIndex = 5;
            this.txtCodProducto.TabStop = false;
            this.txtCodProducto.Text = "materialSingleLineTextField1";
            this.txtCodProducto.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(13, 226);
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
            this.txtCantidad.Location = new System.Drawing.Point(132, 226);
            this.txtCantidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.PasswordChar = '\0';
            this.txtCantidad.SelectedText = "";
            this.txtCantidad.SelectionLength = 0;
            this.txtCantidad.SelectionStart = 0;
            this.txtCantidad.Size = new System.Drawing.Size(142, 23);
            this.txtCantidad.TabIndex = 7;
            this.txtCantidad.TabStop = false;
            this.txtCantidad.Text = "materialSingleLineTextField1";
            this.txtCantidad.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(13, 275);
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
            this.txtSubTotal.Location = new System.Drawing.Point(130, 275);
            this.txtSubTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.PasswordChar = '\0';
            this.txtSubTotal.SelectedText = "";
            this.txtSubTotal.SelectionLength = 0;
            this.txtSubTotal.SelectionStart = 0;
            this.txtSubTotal.Size = new System.Drawing.Size(142, 23);
            this.txtSubTotal.TabIndex = 9;
            this.txtSubTotal.TabStop = false;
            this.txtSubTotal.Text = "materialSingleLineTextField1";
            this.txtSubTotal.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(13, 313);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(44, 19);
            this.materialLabel6.TabIndex = 10;
            this.materialLabel6.Text = "Total";
            this.materialLabel6.Click += new System.EventHandler(this.materialLabel6_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Depth = 0;
            this.txtTotal.Hint = "";
            this.txtTotal.Location = new System.Drawing.Point(130, 313);
            this.txtTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.SelectedText = "";
            this.txtTotal.SelectionLength = 0;
            this.txtTotal.SelectionStart = 0;
            this.txtTotal.Size = new System.Drawing.Size(142, 23);
            this.txtTotal.TabIndex = 11;
            this.txtTotal.TabStop = false;
            this.txtTotal.Text = "materialSingleLineTextField1";
            this.txtTotal.UseSystemPasswordChar = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.Location = new System.Drawing.Point(13, 379);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Primary = false;
            this.btnAgregar.Size = new System.Drawing.Size(74, 36);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.AutoSize = true;
            this.btnModificar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModificar.Depth = 0;
            this.btnModificar.Location = new System.Drawing.Point(130, 379);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Primary = false;
            this.btnModificar.Size = new System.Drawing.Size(84, 36);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // txtConsultar
            // 
            this.txtConsultar.AutoSize = true;
            this.txtConsultar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtConsultar.Depth = 0;
            this.txtConsultar.Location = new System.Drawing.Point(303, 73);
            this.txtConsultar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtConsultar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtConsultar.Name = "txtConsultar";
            this.txtConsultar.Primary = false;
            this.txtConsultar.Size = new System.Drawing.Size(91, 36);
            this.txtConsultar.TabIndex = 14;
            this.txtConsultar.Text = "Consultar";
            this.txtConsultar.UseVisualStyleBackColor = true;
            // 
            // txtEliminar
            // 
            this.txtEliminar.AutoSize = true;
            this.txtEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtEliminar.Depth = 0;
            this.txtEliminar.Location = new System.Drawing.Point(284, 379);
            this.txtEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Primary = false;
            this.txtEliminar.Size = new System.Drawing.Size(74, 36);
            this.txtEliminar.TabIndex = 15;
            this.txtEliminar.Text = "Eliminar";
            this.txtEliminar.UseVisualStyleBackColor = true;
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 430);
            this.Controls.Add(this.txtEliminar);
            this.Controls.Add(this.txtConsultar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.txtCodProducto);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtCodUsuario);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtCodFactura);
            this.Controls.Add(this.materialLabel1);
            this.Name = "frmFactura";
            this.Text = "Facturar";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodFactura;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodUsuario;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodProducto;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCantidad;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSubTotal;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTotal;
        private MaterialSkin.Controls.MaterialFlatButton btnAgregar;
        private MaterialSkin.Controls.MaterialFlatButton btnModificar;
        private MaterialSkin.Controls.MaterialFlatButton txtConsultar;
        private MaterialSkin.Controls.MaterialFlatButton txtEliminar;
    }
}