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
            this.txtNombreRole = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCodVentana = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.chbInsertar = new System.Windows.Forms.CheckBox();
            this.choModificar = new System.Windows.Forms.CheckBox();
            this.chbEliminar = new System.Windows.Forms.CheckBox();
            this.chboConsultar = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnModificar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnEliminar = new MaterialSkin.Controls.MaterialFlatButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(25, 78);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(111, 19);
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
            this.materialLabel2.Location = new System.Drawing.Point(25, 171);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(133, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Codigo de ventana";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // txtNombreRole
            // 
            this.txtNombreRole.Depth = 0;
            this.txtNombreRole.Hint = "";
            this.txtNombreRole.Location = new System.Drawing.Point(169, 127);
            this.txtNombreRole.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreRole.Name = "txtNombreRole";
            this.txtNombreRole.PasswordChar = '\0';
            this.txtNombreRole.SelectedText = "";
            this.txtNombreRole.SelectionLength = 0;
            this.txtNombreRole.SelectionStart = 0;
            this.txtNombreRole.Size = new System.Drawing.Size(121, 23);
            this.txtNombreRole.TabIndex = 2;
            this.txtNombreRole.TabStop = false;
            this.txtNombreRole.UseSystemPasswordChar = false;
            // 
            // txtCodVentana
            // 
            this.txtCodVentana.Depth = 0;
            this.txtCodVentana.Hint = "";
            this.txtCodVentana.Location = new System.Drawing.Point(169, 229);
            this.txtCodVentana.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodVentana.Name = "txtCodVentana";
            this.txtCodVentana.PasswordChar = '\0';
            this.txtCodVentana.SelectedText = "";
            this.txtCodVentana.SelectionLength = 0;
            this.txtCodVentana.SelectionStart = 0;
            this.txtCodVentana.Size = new System.Drawing.Size(121, 23);
            this.txtCodVentana.TabIndex = 3;
            this.txtCodVentana.TabStop = false;
            this.txtCodVentana.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(25, 131);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(114, 18);
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
            this.materialLabel4.Location = new System.Drawing.Point(25, 233);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(133, 19);
            this.materialLabel4.TabIndex = 5;
            this.materialLabel4.Text = "Codigo de ventana";
            // 
            // chbInsertar
            // 
            this.chbInsertar.AutoSize = true;
            this.chbInsertar.Location = new System.Drawing.Point(604, 107);
            this.chbInsertar.Name = "chbInsertar";
            this.chbInsertar.Size = new System.Drawing.Size(61, 17);
            this.chbInsertar.TabIndex = 6;
            this.chbInsertar.Text = "Insertar";
            this.chbInsertar.UseVisualStyleBackColor = true;
            // 
            // choModificar
            // 
            this.choModificar.AutoSize = true;
            this.choModificar.Location = new System.Drawing.Point(604, 144);
            this.choModificar.Name = "choModificar";
            this.choModificar.Size = new System.Drawing.Size(69, 17);
            this.choModificar.TabIndex = 7;
            this.choModificar.Text = "Modificar";
            this.choModificar.UseVisualStyleBackColor = true;
            // 
            // chbEliminar
            // 
            this.chbEliminar.AutoSize = true;
            this.chbEliminar.Location = new System.Drawing.Point(604, 189);
            this.chbEliminar.Name = "chbEliminar";
            this.chbEliminar.Size = new System.Drawing.Size(62, 17);
            this.chbEliminar.TabIndex = 8;
            this.chbEliminar.Text = "Eliminar";
            this.chbEliminar.UseVisualStyleBackColor = true;
            // 
            // chboConsultar
            // 
            this.chboConsultar.AutoSize = true;
            this.chboConsultar.Location = new System.Drawing.Point(604, 229);
            this.chboConsultar.Name = "chboConsultar";
            this.chboConsultar.Size = new System.Drawing.Size(70, 17);
            this.chboConsultar.TabIndex = 9;
            this.chboConsultar.Text = "Consultar";
            this.chboConsultar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.Location = new System.Drawing.Point(29, 354);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Primary = false;
            this.btnAgregar.Size = new System.Drawing.Size(74, 36);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.AutoSize = true;
            this.btnModificar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModificar.Depth = 0;
            this.btnModificar.Location = new System.Drawing.Point(225, 353);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Primary = false;
            this.btnModificar.Size = new System.Drawing.Size(84, 36);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = true;
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Location = new System.Drawing.Point(422, 353);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Primary = false;
            this.btnEliminar.Size = new System.Drawing.Size(74, 36);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(169, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(169, 172);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 14;
            // 
            // frmAsignarVentanaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 404);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.chboConsultar);
            this.Controls.Add(this.chbEliminar);
            this.Controls.Add(this.choModificar);
            this.Controls.Add(this.chbInsertar);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtCodVentana);
            this.Controls.Add(this.txtNombreRole);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "frmAsignarVentanaRol";
            this.Text = "Asignar Ventanas a Role";
            this.Load += new System.EventHandler(this.frmAsignarVentanaRol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreRole;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodVentana;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.CheckBox chbInsertar;
        private System.Windows.Forms.CheckBox choModificar;
        private System.Windows.Forms.CheckBox chbEliminar;
        private System.Windows.Forms.CheckBox chboConsultar;
        private MaterialSkin.Controls.MaterialFlatButton btnAgregar;
        private MaterialSkin.Controls.MaterialFlatButton btnModificar;
        private MaterialSkin.Controls.MaterialFlatButton btnEliminar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}