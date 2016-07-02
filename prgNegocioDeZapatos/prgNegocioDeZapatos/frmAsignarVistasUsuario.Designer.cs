namespace prgNegocioDeZapatos
{
    partial class frmAsignarVistasUsuario
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
            this.txtNombreVista = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.chbInsertar = new MaterialSkin.Controls.MaterialCheckBox();
            this.chbModificar = new MaterialSkin.Controls.MaterialCheckBox();
            this.chbEliminar = new MaterialSkin.Controls.MaterialCheckBox();
            this.chbConsultar = new MaterialSkin.Controls.MaterialCheckBox();
            this.btnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnModificar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAgregar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarVista = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBuscarUsuario = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtCodVista = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombreUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCodUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
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
            this.materialLabel1.Location = new System.Drawing.Point(18, 90);
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
            this.materialLabel2.Location = new System.Drawing.Point(14, 139);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(113, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Codigo de vista";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // txtCodVentana
            // 
            this.txtCodVentana.Depth = 0;
            this.txtCodVentana.Hint = "";
            this.txtCodVentana.Location = new System.Drawing.Point(169, 258);
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
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(14, 87);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(117, 19);
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
            this.materialLabel4.Location = new System.Drawing.Point(14, 193);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(133, 19);
            this.materialLabel4.TabIndex = 5;
            this.materialLabel4.Text = "Codigo de ventana";
            // 
            // cbxCodRole
            // 
            // chbInsertar
            // 
            this.chbInsertar.AutoSize = true;
            this.chbInsertar.Depth = 0;
            this.chbInsertar.Font = new System.Drawing.Font("Roboto", 10F);
            this.chbInsertar.Location = new System.Drawing.Point(13, 30);
            this.chbInsertar.Margin = new System.Windows.Forms.Padding(0);
            this.chbInsertar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chbInsertar.MouseState = MaterialSkin.MouseState.HOVER;
            this.chbInsertar.Name = "chbInsertar";
            this.chbInsertar.Ripple = true;
            this.chbInsertar.Size = new System.Drawing.Size(78, 30);
            this.chbInsertar.TabIndex = 16;
            this.chbInsertar.Text = "Insertar";
            this.chbInsertar.UseVisualStyleBackColor = true;
            // 
            // chbModificar
            // 
            this.chbModificar.AutoSize = true;
            this.chbModificar.Depth = 0;
            this.chbModificar.Font = new System.Drawing.Font("Roboto", 10F);
            this.chbModificar.Location = new System.Drawing.Point(13, 68);
            this.chbModificar.Margin = new System.Windows.Forms.Padding(0);
            this.chbModificar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chbModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.chbModificar.Name = "chbModificar";
            this.chbModificar.Ripple = true;
            this.chbModificar.Size = new System.Drawing.Size(89, 30);
            this.chbModificar.TabIndex = 17;
            this.chbModificar.Text = "Modificar";
            this.chbModificar.UseVisualStyleBackColor = true;
            // 
            // chbEliminar
            // 
            this.chbEliminar.AutoSize = true;
            this.chbEliminar.Depth = 0;
            this.chbEliminar.Font = new System.Drawing.Font("Roboto", 10F);
            this.chbEliminar.Location = new System.Drawing.Point(13, 105);
            this.chbEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.chbEliminar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chbEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.chbEliminar.Name = "chbEliminar";
            this.chbEliminar.Ripple = true;
            this.chbEliminar.Size = new System.Drawing.Size(80, 30);
            this.chbEliminar.TabIndex = 18;
            this.chbEliminar.Text = "Eliminar";
            this.chbEliminar.UseVisualStyleBackColor = true;
            // 
            // chbConsultar
            // 
            this.chbConsultar.AutoSize = true;
            this.chbConsultar.Depth = 0;
            this.chbConsultar.Font = new System.Drawing.Font("Roboto", 10F);
            this.chbConsultar.Location = new System.Drawing.Point(13, 138);
            this.chbConsultar.Margin = new System.Windows.Forms.Padding(0);
            this.chbConsultar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chbConsultar.MouseState = MaterialSkin.MouseState.HOVER;
            this.chbConsultar.Name = "chbConsultar";
            this.chbConsultar.Ripple = true;
            this.chbConsultar.Size = new System.Drawing.Size(89, 30);
            this.chbConsultar.TabIndex = 19;
            this.chbConsultar.Text = "Consultar";
            this.chbConsultar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Location = new System.Drawing.Point(254, 332);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Primary = true;
            this.btnEliminar.Size = new System.Drawing.Size(79, 37);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Depth = 0;
            this.btnModificar.Location = new System.Drawing.Point(162, 332);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Primary = true;
            this.btnModificar.Size = new System.Drawing.Size(79, 37);
            this.btnModificar.TabIndex = 22;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(356, 332);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(79, 37);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Depth = 0;
            this.btnAgregar.Location = new System.Drawing.Point(63, 332);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Primary = true;
            this.btnAgregar.Size = new System.Drawing.Size(79, 37);
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnBuscarVista);
            this.groupBox1.Controls.Add(this.btnBuscarUsuario);
            this.groupBox1.Controls.Add(this.txtCodVista);
            this.groupBox1.Controls.Add(this.txtNombreUsuario);
            this.groupBox1.Controls.Add(this.txtCodUsuario);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.txtNombreVista);
            this.groupBox1.Controls.Add(this.materialLabel4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 90);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(415, 236);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion General";
            // 
            // btnBuscarVista
            // 
            this.btnBuscarVista.Depth = 0;
            this.btnBuscarVista.Location = new System.Drawing.Point(311, 139);
            this.btnBuscarVista.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarVista.Name = "btnBuscarVista";
            this.btnBuscarVista.Primary = true;
            this.btnBuscarVista.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarVista.TabIndex = 8;
            this.btnBuscarVista.Text = "buscar";
            this.btnBuscarVista.UseVisualStyleBackColor = true;
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.Depth = 0;
            this.btnBuscarUsuario.Location = new System.Drawing.Point(311, 38);
            this.btnBuscarUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Primary = true;
            this.btnBuscarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarUsuario.TabIndex = 7;
            this.btnBuscarUsuario.Text = "buscar";
            this.btnBuscarUsuario.UseVisualStyleBackColor = true;
            // 
            // txtCodVista
            // 
            this.txtCodVista.Depth = 0;
            this.txtCodVista.Enabled = false;
            this.txtCodVista.Hint = "";
            this.txtCodVista.Location = new System.Drawing.Point(177, 135);
            this.txtCodVista.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodVista.Name = "txtCodVista";
            this.txtCodVista.PasswordChar = '\0';
            this.txtCodVista.SelectedText = "";
            this.txtCodVista.SelectionLength = 0;
            this.txtCodVista.SelectionStart = 0;
            this.txtCodVista.Size = new System.Drawing.Size(121, 23);
            this.txtCodVista.TabIndex = 6;
            this.txtCodVista.TabStop = false;
            this.txtCodVista.UseSystemPasswordChar = false;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Depth = 0;
            this.txtNombreUsuario.Enabled = false;
            this.txtNombreUsuario.Hint = "";
            this.txtNombreUsuario.Location = new System.Drawing.Point(177, 87);
            this.txtNombreUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.PasswordChar = '\0';
            this.txtNombreUsuario.SelectedText = "";
            this.txtNombreUsuario.SelectionLength = 0;
            this.txtNombreUsuario.SelectionStart = 0;
            this.txtNombreUsuario.Size = new System.Drawing.Size(128, 23);
            this.txtNombreUsuario.TabIndex = 5;
            this.txtNombreUsuario.TabStop = false;
            this.txtNombreUsuario.UseSystemPasswordChar = false;
            // 
            // txtCodUsuario
            // 
            this.txtCodUsuario.Depth = 0;
            this.txtCodUsuario.Enabled = false;
            this.txtCodUsuario.Hint = "";
            this.txtCodUsuario.Location = new System.Drawing.Point(177, 35);
            this.txtCodUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodUsuario.Name = "txtCodUsuario";
            this.txtCodUsuario.PasswordChar = '\0';
            this.txtCodUsuario.SelectedText = "";
            this.txtCodUsuario.SelectionLength = 0;
            this.txtCodUsuario.SelectionStart = 0;
            this.txtCodUsuario.Size = new System.Drawing.Size(128, 23);
            this.txtCodUsuario.TabIndex = 3;
            this.txtCodUsuario.TabStop = false;
            this.txtCodUsuario.UseSystemPasswordChar = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.chbInsertar);
            this.groupBox2.Controls.Add(this.chbModificar);
            this.groupBox2.Controls.Add(this.chbEliminar);
            this.groupBox2.Controls.Add(this.chbConsultar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(490, 113);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(126, 189);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Permisos";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.btnAgregar);
            this.groupBox3.Controls.Add(this.btnModificar);
            this.groupBox3.Controls.Add(this.btnEliminar);
            this.groupBox3.Controls.Add(this.btnSalir);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(94, 344);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(431, 69);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Botones";
            // 
            // frmAsignarVistasUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(651, 436);
            this.ControlBox = false;
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
            this.Name = "frmAsignarVentanaRol";
            this.Text = "Asignar Ventanas a Role";
            this.Load += new System.EventHandler(this.frmAsignarVentanaRol_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodVentana;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialCheckBox chbInsertar;
        private MaterialSkin.Controls.MaterialCheckBox chbModificar;
        private MaterialSkin.Controls.MaterialCheckBox chbEliminar;
        private MaterialSkin.Controls.MaterialCheckBox chbConsultar;
        private MaterialSkin.Controls.MaterialRaisedButton btnEliminar;
        private MaterialSkin.Controls.MaterialRaisedButton btnModificar;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscarVista;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscarUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodVista;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodUsuario;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}