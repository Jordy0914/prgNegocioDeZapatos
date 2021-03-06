﻿namespace prgNegocioDeZapatos
{
    partial class frmListadoFacturas
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
            this.lvFacturas = new System.Windows.Forms.ListView();
            this.codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subtotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtIdFactura = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // lvFacturas
            // 
            this.lvFacturas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codigo,
            this.idProducto,
            this.cantidad,
            this.subtotal,
            this.total});
            this.lvFacturas.Enabled = false;
            this.lvFacturas.GridLines = true;
            this.lvFacturas.Location = new System.Drawing.Point(67, 141);
            this.lvFacturas.Name = "lvFacturas";
            this.lvFacturas.Size = new System.Drawing.Size(462, 223);
            this.lvFacturas.TabIndex = 0;
            this.lvFacturas.UseCompatibleStateImageBehavior = false;
            this.lvFacturas.View = System.Windows.Forms.View.Details;
            this.lvFacturas.DoubleClick += new System.EventHandler(this.lvFacturas_DoubleClick);
            // 
            // codigo
            // 
            this.codigo.Text = "Codigo Factura";
            this.codigo.Width = 87;
            // 
            // idProducto
            // 
            this.idProducto.Text = "Codigo Producto";
            this.idProducto.Width = 94;
            // 
            // cantidad
            // 
            this.cantidad.Text = "Cantidad";
            this.cantidad.Width = 90;
            // 
            // subtotal
            // 
            this.subtotal.Text = "SubTotal";
            this.subtotal.Width = 79;
            // 
            // total
            // 
            this.total.Text = "total";
            this.total.Width = 107;
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(235, 389);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(75, 33);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtIdFactura
            // 
            this.txtIdFactura.BackColor = System.Drawing.Color.White;
            this.txtIdFactura.Depth = 0;
            this.txtIdFactura.Hint = "";
            this.txtIdFactura.Location = new System.Drawing.Point(235, 90);
            this.txtIdFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIdFactura.Name = "txtIdFactura";
            this.txtIdFactura.PasswordChar = '\0';
            this.txtIdFactura.SelectedText = "";
            this.txtIdFactura.SelectionLength = 0;
            this.txtIdFactura.SelectionStart = 0;
            this.txtIdFactura.Size = new System.Drawing.Size(75, 23);
            this.txtIdFactura.TabIndex = 2;
            this.txtIdFactura.TabStop = false;
            this.txtIdFactura.UseSystemPasswordChar = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Depth = 0;
            this.btnBuscar.Location = new System.Drawing.Point(397, 79);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Primary = true;
            this.btnBuscar.Size = new System.Drawing.Size(75, 34);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.White;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 94);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(196, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Digite el Numero de Factura";
            // 
            // frmListadoFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 453);
            this.ControlBox = false;
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtIdFactura);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lvFacturas);
            this.Name = "frmListadoFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Facturas";
            this.Load += new System.EventHandler(this.frmListadoFacturas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvFacturas;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIdFactura;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscar;
        private System.Windows.Forms.ColumnHeader codigo;
        private System.Windows.Forms.ColumnHeader idProducto;
        private System.Windows.Forms.ColumnHeader total;
        private System.Windows.Forms.ColumnHeader subtotal;
        private System.Windows.Forms.ColumnHeader cantidad;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}