namespace prgNegocioDeZapatos
{
    partial class frmAsignarRol
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
            this.btnAsignar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombreUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombreRol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.btnConsultar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtIdUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtIdRol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(11, 79);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(61, 19);
            this.materialLabel1.TabIndex = 23;
            this.materialLabel1.Text = "Usuario";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 177);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(31, 19);
            this.materialLabel2.TabIndex = 24;
            this.materialLabel2.Text = "Rol";
            // 
            // btnAsignar
            // 
            this.btnAsignar.Depth = 0;
            this.btnAsignar.Location = new System.Drawing.Point(58, 294);
            this.btnAsignar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Primary = true;
            this.btnAsignar.Size = new System.Drawing.Size(75, 32);
            this.btnAsignar.TabIndex = 25;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(279, 294);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(75, 32);
            this.btnSalir.TabIndex = 26;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Location = new System.Drawing.Point(164, 294);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Primary = true;
            this.btnEliminar.Size = new System.Drawing.Size(75, 32);
            this.btnEliminar.TabIndex = 27;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(11, 125);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(119, 19);
            this.materialLabel3.TabIndex = 28;
            this.materialLabel3.Text = "Nombre Usuario";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Depth = 0;
            this.txtNombreUsuario.Enabled = false;
            this.txtNombreUsuario.Hint = "";
            this.txtNombreUsuario.Location = new System.Drawing.Point(136, 121);
            this.txtNombreUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.PasswordChar = '\0';
            this.txtNombreUsuario.SelectedText = "";
            this.txtNombreUsuario.SelectionLength = 0;
            this.txtNombreUsuario.SelectionStart = 0;
            this.txtNombreUsuario.Size = new System.Drawing.Size(166, 23);
            this.txtNombreUsuario.TabIndex = 29;
            this.txtNombreUsuario.TabStop = false;
            this.txtNombreUsuario.UseSystemPasswordChar = false;
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.Depth = 0;
            this.txtNombreRol.Enabled = false;
            this.txtNombreRol.Hint = "";
            this.txtNombreRol.Location = new System.Drawing.Point(136, 219);
            this.txtNombreRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.PasswordChar = '\0';
            this.txtNombreRol.SelectedText = "";
            this.txtNombreRol.SelectionLength = 0;
            this.txtNombreRol.SelectionStart = 0;
            this.txtNombreRol.Size = new System.Drawing.Size(166, 23);
            this.txtNombreRol.TabIndex = 30;
            this.txtNombreRol.TabStop = false;
            this.txtNombreRol.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(11, 223);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(109, 19);
            this.materialLabel4.TabIndex = 31;
            this.materialLabel4.Text = "Nombre del rol";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Depth = 0;
            this.btnConsultar.Location = new System.Drawing.Point(316, 73);
            this.btnConsultar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Primary = true;
            this.btnConsultar.Size = new System.Drawing.Size(95, 32);
            this.btnConsultar.TabIndex = 32;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Depth = 0;
            this.txtIdUsuario.Enabled = false;
            this.txtIdUsuario.Hint = "";
            this.txtIdUsuario.Location = new System.Drawing.Point(136, 82);
            this.txtIdUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.PasswordChar = '\0';
            this.txtIdUsuario.SelectedText = "";
            this.txtIdUsuario.SelectionLength = 0;
            this.txtIdUsuario.SelectionStart = 0;
            this.txtIdUsuario.Size = new System.Drawing.Size(166, 23);
            this.txtIdUsuario.TabIndex = 33;
            this.txtIdUsuario.TabStop = false;
            this.txtIdUsuario.UseSystemPasswordChar = false;
            // 
            // txtIdRol
            // 
            this.txtIdRol.Depth = 0;
            this.txtIdRol.Enabled = false;
            this.txtIdRol.Hint = "";
            this.txtIdRol.Location = new System.Drawing.Point(136, 177);
            this.txtIdRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIdRol.Name = "txtIdRol";
            this.txtIdRol.PasswordChar = '\0';
            this.txtIdRol.SelectedText = "";
            this.txtIdRol.SelectionLength = 0;
            this.txtIdRol.SelectionStart = 0;
            this.txtIdRol.Size = new System.Drawing.Size(166, 23);
            this.txtIdRol.TabIndex = 34;
            this.txtIdRol.TabStop = false;
            this.txtIdRol.UseSystemPasswordChar = false;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(316, 177);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(95, 32);
            this.materialRaisedButton1.TabIndex = 35;
            this.materialRaisedButton1.Text = "Consultar";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            // 
            // frmAsignarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(455, 365);
            this.ControlBox = false;
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.txtIdRol);
            this.Controls.Add(this.txtIdUsuario);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.txtNombreRol);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "frmAsignarRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Asignacion de Roles";
            this.Load += new System.EventHandler(this.frmAsignarRol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRaisedButton btnAsignar;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnEliminar;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreRol;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialRaisedButton btnConsultar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIdUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIdRol;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}