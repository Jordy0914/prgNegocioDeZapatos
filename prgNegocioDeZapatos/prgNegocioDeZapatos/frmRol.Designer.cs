namespace prgNegocioDeZapatos
{
    partial class frmRol
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chEliminar = new MaterialSkin.Controls.MaterialCheckBox();
            this.chModificar = new MaterialSkin.Controls.MaterialCheckBox();
            this.chConsultar = new MaterialSkin.Controls.MaterialCheckBox();
            this.chInsertar = new MaterialSkin.Controls.MaterialCheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAdvertencia = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAgregar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtRol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombreRol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
          
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.chEliminar);
            this.groupBox1.Controls.Add(this.chModificar);
            this.groupBox1.Controls.Add(this.chConsultar);
            this.groupBox1.Controls.Add(this.chInsertar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(379, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 187);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permisos";
            // 
            // chEliminar
            // 
            this.chEliminar.AutoSize = true;
            this.chEliminar.Depth = 0;
            this.chEliminar.Font = new System.Drawing.Font("Roboto", 10F);
            this.chEliminar.Location = new System.Drawing.Point(16, 137);
            this.chEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.chEliminar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.chEliminar.Name = "chEliminar";
            this.chEliminar.Ripple = true;
            this.chEliminar.Size = new System.Drawing.Size(80, 30);
            this.chEliminar.TabIndex = 12;
            this.chEliminar.Text = "Eliminar";
            this.chEliminar.UseVisualStyleBackColor = true;
            // 
            // chModificar
            // 
            this.chModificar.AutoSize = true;
            this.chModificar.Depth = 0;
            this.chModificar.Font = new System.Drawing.Font("Roboto", 10F);
            this.chModificar.Location = new System.Drawing.Point(16, 95);
            this.chModificar.Margin = new System.Windows.Forms.Padding(0);
            this.chModificar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.chModificar.Name = "chModificar";
            this.chModificar.Ripple = true;
            this.chModificar.Size = new System.Drawing.Size(89, 30);
            this.chModificar.TabIndex = 11;
            this.chModificar.Text = "Modificar";
            this.chModificar.UseVisualStyleBackColor = true;
            // 
            // chConsultar
            // 
            this.chConsultar.AutoSize = true;
            this.chConsultar.Depth = 0;
            this.chConsultar.Font = new System.Drawing.Font("Roboto", 10F);
            this.chConsultar.Location = new System.Drawing.Point(16, 57);
            this.chConsultar.Margin = new System.Windows.Forms.Padding(0);
            this.chConsultar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chConsultar.MouseState = MaterialSkin.MouseState.HOVER;
            this.chConsultar.Name = "chConsultar";
            this.chConsultar.Ripple = true;
            this.chConsultar.Size = new System.Drawing.Size(89, 30);
            this.chConsultar.TabIndex = 10;
            this.chConsultar.Text = "Consultar";
            this.chConsultar.UseVisualStyleBackColor = true;
            // 
            // chInsertar
            // 
            this.chInsertar.AutoSize = true;
            this.chInsertar.Depth = 0;
            this.chInsertar.Font = new System.Drawing.Font("Roboto", 10F);
            this.chInsertar.Location = new System.Drawing.Point(16, 17);
            this.chInsertar.Margin = new System.Windows.Forms.Padding(0);
            this.chInsertar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chInsertar.MouseState = MaterialSkin.MouseState.HOVER;
            this.chInsertar.Name = "chInsertar";
            this.chInsertar.Ripple = true;
            this.chInsertar.Size = new System.Drawing.Size(78, 30);
            this.chInsertar.TabIndex = 9;
            this.chInsertar.Text = "Insertar";
            this.chInsertar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txtNombreRol);
            this.groupBox2.Controls.Add(this.txtRol);
            this.groupBox2.Controls.Add(this.lblAdvertencia);
            this.groupBox2.Controls.Add(this.materialLabel2);
            this.groupBox2.Controls.Add(this.materialLabel1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 187);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion del Rol";
            // 
            // lblAdvertencia
            // 
            this.lblAdvertencia.AutoSize = true;
            this.lblAdvertencia.Depth = 0;
            this.lblAdvertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblAdvertencia.ForeColor = System.Drawing.Color.Red;
            this.lblAdvertencia.Location = new System.Drawing.Point(7, 125);
            this.lblAdvertencia.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAdvertencia.Name = "lblAdvertencia";
            this.lblAdvertencia.Size = new System.Drawing.Size(10, 15);
            this.lblAdvertencia.TabIndex = 27;
            this.lblAdvertencia.Text = "¡";
            this.lblAdvertencia.Visible = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.White;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(6, 95);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(113, 19);
            this.materialLabel2.TabIndex = 26;
            this.materialLabel2.Text = "Nombre del Rol";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.White;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(5, 42);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(107, 19);
            this.materialLabel1.TabIndex = 25;
            this.materialLabel1.Text = "Codigo del Rol";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.btnSalir);
            this.groupBox3.Controls.Add(this.btnAgregar);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(181, 300);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(292, 65);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(177, 19);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(75, 30);
            this.btnSalir.TabIndex = 28;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Depth = 0;
            this.btnAgregar.Location = new System.Drawing.Point(36, 19);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Primary = true;
            this.btnAgregar.Size = new System.Drawing.Size(75, 30);
            this.btnAgregar.TabIndex = 27;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtRol
            // 
            this.txtRol.Depth = 0;
            this.txtRol.Enabled = false;
            this.txtRol.Hint = "";
            this.txtRol.Location = new System.Drawing.Point(141, 37);
            this.txtRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRol.Name = "txtRol";
            this.txtRol.PasswordChar = '\0';
            this.txtRol.SelectedText = "";
            this.txtRol.SelectionLength = 0;
            this.txtRol.SelectionStart = 0;
            this.txtRol.Size = new System.Drawing.Size(139, 23);
            this.txtRol.TabIndex = 28;
            this.txtRol.TabStop = false;
            this.txtRol.UseSystemPasswordChar = false;
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.Depth = 0;
            this.txtNombreRol.Hint = "";
            this.txtNombreRol.Location = new System.Drawing.Point(141, 90);
            this.txtNombreRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.PasswordChar = '\0';
            this.txtNombreRol.SelectedText = "";
            this.txtNombreRol.SelectionLength = 0;
            this.txtNombreRol.SelectionStart = 0;
            this.txtNombreRol.Size = new System.Drawing.Size(121, 23);
            this.txtNombreRol.TabIndex = 29;
            this.txtNombreRol.TabStop = false;
            this.txtNombreRol.UseSystemPasswordChar = false;
            // 
            // frmRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(646, 402);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Creacion de Roles";
            this.Load += new System.EventHandler(this.frmRol_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCheckBox chEliminar;
        private MaterialSkin.Controls.MaterialCheckBox chModificar;
        private MaterialSkin.Controls.MaterialCheckBox chConsultar;
        private MaterialSkin.Controls.MaterialCheckBox chInsertar;
        private MaterialSkin.Controls.MaterialRaisedButton btnAgregar;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialLabel lblAdvertencia;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreRol;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRol;
    }
}