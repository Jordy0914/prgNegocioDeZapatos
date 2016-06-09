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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbEliminar = new System.Windows.Forms.CheckBox();
            this.cbModificar = new System.Windows.Forms.CheckBox();
            this.cbConsultar = new System.Windows.Forms.CheckBox();
            this.cbInsertar = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Rol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo del Rol";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(123, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(12, 229);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 32);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(153, 229);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 32);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbEliminar);
            this.groupBox1.Controls.Add(this.cbModificar);
            this.groupBox1.Controls.Add(this.cbConsultar);
            this.groupBox1.Controls.Add(this.cbInsertar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(322, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 173);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permisos";
            // 
            // cbEliminar
            // 
            this.cbEliminar.AutoSize = true;
            this.cbEliminar.Location = new System.Drawing.Point(16, 135);
            this.cbEliminar.Name = "cbEliminar";
            this.cbEliminar.Size = new System.Drawing.Size(80, 19);
            this.cbEliminar.TabIndex = 3;
            this.cbEliminar.Text = "Eliminar";
            this.cbEliminar.UseVisualStyleBackColor = true;
            // 
            // cbModificar
            // 
            this.cbModificar.AutoSize = true;
            this.cbModificar.Location = new System.Drawing.Point(16, 100);
            this.cbModificar.Name = "cbModificar";
            this.cbModificar.Size = new System.Drawing.Size(86, 19);
            this.cbModificar.TabIndex = 2;
            this.cbModificar.Text = "Modificar";
            this.cbModificar.UseVisualStyleBackColor = true;
            // 
            // cbConsultar
            // 
            this.cbConsultar.AutoSize = true;
            this.cbConsultar.Location = new System.Drawing.Point(16, 63);
            this.cbConsultar.Name = "cbConsultar";
            this.cbConsultar.Size = new System.Drawing.Size(87, 19);
            this.cbConsultar.TabIndex = 1;
            this.cbConsultar.Text = "Consultar";
            this.cbConsultar.UseVisualStyleBackColor = true;
            // 
            // cbInsertar
            // 
            this.cbInsertar.AutoSize = true;
            this.cbInsertar.Location = new System.Drawing.Point(16, 31);
            this.cbInsertar.Name = "cbInsertar";
            this.cbInsertar.Size = new System.Drawing.Size(75, 19);
            this.cbInsertar.TabIndex = 0;
            this.cbInsertar.Text = "Insertar";
            this.cbInsertar.UseVisualStyleBackColor = true;
            // 
            // frmRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(564, 295);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRol";
            this.Text = "Creacion de Roles";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbEliminar;
        private System.Windows.Forms.CheckBox cbModificar;
        private System.Windows.Forms.CheckBox cbConsultar;
        private System.Windows.Forms.CheckBox cbInsertar;
    }
}