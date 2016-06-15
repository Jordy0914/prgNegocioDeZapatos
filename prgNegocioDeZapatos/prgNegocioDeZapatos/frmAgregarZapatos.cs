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
    public partial class frmAgregarZapatos : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public frmAgregarZapatos()
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange700, Primary.DeepOrange900, Primary.DeepOrange500, Accent.DeepOrange200, TextShade.WHITE);

            InitializeComponent();
        }


        private void frmAgregarZapatos_Load(object sender, EventArgs e)
        {

        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

   
    }
}
