namespace prgNegocioDeZapatos
{
    partial class frmAsignarVentanaRol
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
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCodVentana = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.cbxCodRole = new System.Windows.Forms.ComboBox();
            this.cbxCodVentanas = new System.Windows.Forms.ComboBox();
            this.txtNombreRole = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.chbInsertar = new MaterialSkin.Controls.MaterialCheckBox();
            this.chbModificar = new MaterialSkin.Controls.MaterialCheckBox();
            this.chbEliminar = new MaterialSkin.Controls.MaterialCheckBox();
            this.chbConsultar = new MaterialSkin.Controls.MaterialCheckBox();
            this.btnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnModificar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAgregar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(33, 96);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(140, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Codigo de Role";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(33, 210);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(167, 24);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Codigo de ventana";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // txtCodVentana
            // 
            this.txtCodVentana.Depth = 0;
            this.txtCodVentana.Hint = "";
            this.txtCodVentana.Location = new System.Drawing.Point(225, 282);
            this.txtCodVentana.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodVentana.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodVentana.Name = "txtCodVentana";
            this.txtCodVentana.PasswordChar = '\0';
            this.txtCodVentana.SelectedText = "";
            this.txtCodVentana.SelectionLength = 0;
            this.txtCodVentana.SelectionStart = 0;
            this.txtCodVentana.Size = new System.Drawing.Size(161, 28);
            this.txtCodVentana.TabIndex = 3;
            this.txtCodVentana.TabStop = false;
            this.txtCodVentana.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(33, 161);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(147, 24);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Nombre del role";
            this.materialLabel3.Click += new System.EventHandler(this.materialLabel3_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(33, 287);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(167, 24);
            this.materialLabel4.TabIndex = 5;
            this.materialLabel4.Text = "Codigo de ventana";
            // 
            // cbxCodRole
            // 
            this.cbxCodRole.FormattingEnabled = true;
            this.cbxCodRole.Location = new System.Drawing.Point(225, 92);
            this.cbxCodRole.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCodRole.Name = "cbxCodRole";
            this.cbxCodRole.Size = new System.Drawing.Size(160, 24);
            this.cbxCodRole.TabIndex = 13;
            // 
            // cbxCodVentanas
            // 
            this.cbxCodVentanas.FormattingEnabled = true;
            this.cbxCodVentanas.Location = new System.Drawing.Point(225, 212);
            this.cbxCodVentanas.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCodVentanas.Name = "cbxCodVentanas";
            this.cbxCodVentanas.Size = new System.Drawing.Size(160, 24);
            this.cbxCodVentanas.TabIndex = 14;
            // 
            // txtNombreRole
            // 
            this.txtNombreRole.Depth = 0;
            this.txtNombreRole.Hint = "";
            this.txtNombreRole.Location = new System.Drawing.Point(225, 156);
            this.txtNombreRole.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreRole.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreRole.Name = "txtNombreRole";
            this.txtNombreRole.PasswordChar = '\0';
            this.txtNombreRole.SelectedText = "";
            this.txtNombreRole.SelectionLength = 0;
            this.txtNombreRole.SelectionStart = 0;
            this.txtNombreRole.Size = new System.Drawing.Size(161, 28);
            this.txtNombreRole.TabIndex = 2;
            this.txtNombreRole.TabStop = false;
            this.txtNombreRole.UseSystemPasswordChar = false;
            // 
            // chbInsertar
            // 
            this.chbInsertar.AutoSize = true;
            this.chbInsertar.Depth = 0;
            this.chbInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chbInsertar.Location = new System.Drawing.Point(520, 111);
            this.chbInsertar.Margin = new System.Windows.Forms.Padding(0);
            this.chbInsertar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chbInsertar.MouseState = MaterialSkin.MouseState.HOVER;
            this.chbInsertar.Name = "chbInsertar";
            this.chbInsertar.Ripple = true;
            this.chbInsertar.Size = new System.Drawing.Size(91, 30);
            this.chbInsertar.TabIndex = 16;
            this.chbInsertar.Text = "Insertar";
            this.chbInsertar.UseVisualStyleBackColor = true;
            // 
            // chbModificar
            // 
            this.chbModificar.AutoSize = true;
            this.chbModificar.Depth = 0;
            this.chbModificar.Font = new System.Drawing.Font("Roboto", 10F);
            this.chbModificar.Location = new System.Drawing.Point(520, 158);
            this.chbModificar.Margin = new System.Windows.Forms.Padding(0);
            this.chbModificar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chbModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.chbModificar.Name = "chbModificar";
            this.chbModificar.Ripple = true;
            this.chbModificar.Size = new System.Drawing.Size(105, 30);
            this.chbModificar.TabIndex = 17;
            this.chbModificar.Text = "Modificar";
            this.chbModificar.UseVisualStyleBackColor = true;
            // 
            // chbEliminar
            // 
            this.chbEliminar.AutoSize = true;
            this.chbEliminar.Depth = 0;
            this.chbEliminar.Font = new System.Drawing.Font("Roboto", 10F);
            this.chbEliminar.Location = new System.Drawing.Point(520, 203);
            this.chbEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.chbEliminar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chbEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.chbEliminar.Name = "chbEliminar";
            this.chbEliminar.Ripple = true;
            this.chbEliminar.Size = new System.Drawing.Size(94, 30);
            this.chbEliminar.TabIndex = 18;
            this.chbEliminar.Text = "Eliminar";
            this.chbEliminar.UseVisualStyleBackColor = true;
            // 
            // chbConsultar
            // 
            this.chbConsultar.AutoSize = true;
            this.chbConsultar.Depth = 0;
            this.chbConsultar.Font = new System.Drawing.Font("Roboto", 10F);
            this.chbConsultar.Location = new System.Drawing.Point(520, 244);
            this.chbConsultar.Margin = new System.Windows.Forms.Padding(0);
            this.chbConsultar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chbConsultar.MouseState = MaterialSkin.MouseState.HOVER;
            this.chbConsultar.Name = "chbConsultar";
            this.chbConsultar.Ripple = true;
            this.chbConsultar.Size = new System.Drawing.Size(105, 30);
            this.chbConsultar.TabIndex = 19;
            this.chbConsultar.Text = "Consultar";
            this.chbConsultar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Location = new System.Drawing.Point(334, 379);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Primary = true;
            this.btnEliminar.Size = new System.Drawing.Size(105, 45);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Depth = 0;
            this.btnModificar.Location = new System.Drawing.Point(210, 379);
            this.btnModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Primary = true;
            this.btnModificar.Size = new System.Drawing.Size(105, 45);
            this.btnModificar.TabIndex = 22;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(469, 379);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(105, 45);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Depth = 0;
            this.btnAgregar.Location = new System.Drawing.Point(79, 379);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Primary = true;
            this.btnAgregar.Size = new System.Drawing.Size(105, 45);
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // frmAsignarVentanaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(691, 474);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.chbConsultar);
            this.Controls.Add(this.chbEliminar);
            this.Controls.Add(this.chbModificar);
            this.Controls.Add(this.chbInsertar);
            this.Controls.Add(this.cbxCodVentanas);
            this.Controls.Add(this.cbxCodRole);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtCodVentana);
            this.Controls.Add(this.txtNombreRole);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAsignarVentanaRol";
            this.Text = "Asignar Ventanas a Role";
            this.Load += new System.EventHandler(this.frmAsignarVentanaRol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodVentana;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.ComboBox cbxCodRole;
        private System.Windows.Forms.ComboBox cbxCodVentanas;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreRole;
        private MaterialSkin.Controls.MaterialCheckBox chbInsertar;
        private MaterialSkin.Controls.MaterialCheckBox chbModificar;
        private MaterialSkin.Controls.MaterialCheckBox chbEliminar;
        private MaterialSkin.Controls.MaterialCheckBox chbConsultar;
        private MaterialSkin.Controls.MaterialRaisedButton btnEliminar;
        private MaterialSkin.Controls.MaterialRaisedButton btnModificar;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnAgregar;
    }
}