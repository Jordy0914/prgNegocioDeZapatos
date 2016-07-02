﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace prgNegocioDeZapatos
{
    public partial class frmRol : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public frmRol()
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange700, Primary.DeepOrange900, Primary.DeepOrange500, Accent.DeepOrange200, TextShade.WHITE);
            InitializeComponent();
        }

      

        private void frmRol_Load(object sender, EventArgs e)
        {

        }

        public void Limpiar()
        {
            this.txtCodigoRol.Text = "";
            this.txtNombreRol.Text = "";
           
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
