﻿namespace prgNegocioDeZapatos
{
    partial class frmListaProducto
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
            this.lvListaProductos = new System.Windows.Forms.ListView();
            this.codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.producto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // lvListaProductos
            // 
            this.lvListaProductos.BackColor = System.Drawing.Color.White;
            this.lvListaProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codigo,
            this.producto});
            this.lvListaProductos.GridLines = true;
            this.lvListaProductos.Location = new System.Drawing.Point(72, 91);
            this.lvListaProductos.Name = "lvListaProductos";
            this.lvListaProductos.Size = new System.Drawing.Size(285, 216);
            this.lvListaProductos.TabIndex = 0;
            this.lvListaProductos.UseCompatibleStateImageBehavior = false;
            this.lvListaProductos.View = System.Windows.Forms.View.Details;
            this.lvListaProductos.SelectedIndexChanged += new System.EventHandler(this.lvLista_SelectedIndexChanged);
            this.lvListaProductos.DoubleClick += new System.EventHandler(this.lvLista_DoubleClick);
            // 
            // codigo
            // 
            this.codigo.Text = "Codigo Producto";
            this.codigo.Width = 106;
            // 
            // producto
            // 
            this.producto.Text = "Producto";
            this.producto.Width = 172;
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(165, 337);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(87, 31);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir\r\n";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmListaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 393);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lvListaProductos);
            this.Name = "frmListaProducto";
            this.Text = "Lista Producto";
            this.Load += new System.EventHandler(this.frmListaProducto_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvListaProductos;
        private System.Windows.Forms.ColumnHeader codigo;
        private System.Windows.Forms.ColumnHeader producto;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
    }
}