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
            this.txtIdUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtIdRol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.btnBuscarRol = new System.Windows.Forms.Button();
            this.btnModificar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(15, 97);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(74, 24);
            this.materialLabel1.TabIndex = 23;
            this.materialLabel1.Text = "Usuario";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(16, 218);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(38, 24);
            this.materialLabel2.TabIndex = 24;
            this.materialLabel2.Text = "Rol";
            // 
            // btnAsignar
            // 
            this.btnAsignar.Depth = 0;
            this.btnAsignar.Location = new System.Drawing.Point(52, 362);
            this.btnAsignar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAsignar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Primary = true;
            this.btnAsignar.Size = new System.Drawing.Size(100, 39);
            this.btnAsignar.TabIndex = 25;
            this.btnAsignar.Text = "Agregar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(430, 362);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(100, 39);
            this.btnSalir.TabIndex = 26;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Location = new System.Drawing.Point(302, 362);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Primary = true;
            this.btnEliminar.Size = new System.Drawing.Size(100, 39);
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
            this.materialLabel3.Location = new System.Drawing.Point(15, 154);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(148, 24);
            this.materialLabel3.TabIndex = 28;
            this.materialLabel3.Text = "Nombre Usuario";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Depth = 0;
            this.txtNombreUsuario.Enabled = false;
            this.txtNombreUsuario.Hint = "";
            this.txtNombreUsuario.Location = new System.Drawing.Point(181, 149);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.PasswordChar = '\0';
            this.txtNombreUsuario.SelectedText = "";
            this.txtNombreUsuario.SelectionLength = 0;
            this.txtNombreUsuario.SelectionStart = 0;
            this.txtNombreUsuario.Size = new System.Drawing.Size(221, 28);
            this.txtNombreUsuario.TabIndex = 29;
            this.txtNombreUsuario.TabStop = false;
            this.txtNombreUsuario.UseSystemPasswordChar = false;
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.Depth = 0;
            this.txtNombreRol.Enabled = false;
            this.txtNombreRol.Hint = "";
            this.txtNombreRol.Location = new System.Drawing.Point(181, 270);
            this.txtNombreRol.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.PasswordChar = '\0';
            this.txtNombreRol.SelectedText = "";
            this.txtNombreRol.SelectionLength = 0;
            this.txtNombreRol.SelectionStart = 0;
            this.txtNombreRol.Size = new System.Drawing.Size(221, 28);
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
            this.materialLabel4.Location = new System.Drawing.Point(15, 274);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(137, 24);
            this.materialLabel4.TabIndex = 31;
            this.materialLabel4.Text = "Nombre del rol";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Depth = 0;
            this.txtIdUsuario.Enabled = false;
            this.txtIdUsuario.Hint = "";
            this.txtIdUsuario.Location = new System.Drawing.Point(181, 101);
            this.txtIdUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.PasswordChar = '\0';
            this.txtIdUsuario.SelectedText = "";
            this.txtIdUsuario.SelectionLength = 0;
            this.txtIdUsuario.SelectionStart = 0;
            this.txtIdUsuario.Size = new System.Drawing.Size(221, 28);
            this.txtIdUsuario.TabIndex = 33;
            this.txtIdUsuario.TabStop = false;
            this.txtIdUsuario.UseSystemPasswordChar = false;
            // 
            // txtIdRol
            // 
            this.txtIdRol.Depth = 0;
            this.txtIdRol.Enabled = false;
            this.txtIdRol.Hint = "";
            this.txtIdRol.Location = new System.Drawing.Point(181, 218);
            this.txtIdRol.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIdRol.Name = "txtIdRol";
            this.txtIdRol.PasswordChar = '\0';
            this.txtIdRol.SelectedText = "";
            this.txtIdRol.SelectionLength = 0;
            this.txtIdRol.SelectionStart = 0;
            this.txtIdRol.Size = new System.Drawing.Size(221, 28);
            this.txtIdRol.TabIndex = 34;
            this.txtIdRol.TabStop = false;
            this.txtIdRol.UseSystemPasswordChar = false;
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBuscarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnBuscarUsuario.Image = global::prgNegocioDeZapatos.Properties.Resources.magnifier1;
            this.btnBuscarUsuario.Location = new System.Drawing.Point(430, 82);
            this.btnBuscarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(81, 74);
            this.btnBuscarUsuario.TabIndex = 41;
            this.btnBuscarUsuario.UseVisualStyleBackColor = false;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // btnBuscarRol
            // 
            this.btnBuscarRol.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarRol.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBuscarRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarRol.ForeColor = System.Drawing.Color.White;
            this.btnBuscarRol.Image = global::prgNegocioDeZapatos.Properties.Resources.magnifier1;
            this.btnBuscarRol.Location = new System.Drawing.Point(430, 194);
            this.btnBuscarRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarRol.Name = "btnBuscarRol";
            this.btnBuscarRol.Size = new System.Drawing.Size(81, 74);
            this.btnBuscarRol.TabIndex = 42;
            this.btnBuscarRol.UseVisualStyleBackColor = false;
            this.btnBuscarRol.Click += new System.EventHandler(this.btnBuscarRol_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Depth = 0;
            this.btnModificar.Location = new System.Drawing.Point(170, 362);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Primary = true;
            this.btnModificar.Size = new System.Drawing.Size(111, 39);
            this.btnModificar.TabIndex = 43;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // frmAsignarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(607, 449);
            this.ControlBox = false;
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBuscarRol);
            this.Controls.Add(this.btnBuscarUsuario);
            this.Controls.Add(this.txtIdRol);
            this.Controls.Add(this.txtIdUsuario);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.txtNombreRol);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIdUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIdRol;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.Button btnBuscarRol;
        private MaterialSkin.Controls.MaterialRaisedButton btnModificar;
    }
}