﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prgNegocioDeZapatos
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAcceso Logeo = new frmAcceso();
            Logeo.Show();
        }

        private void asignarRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRol CreacionRoles = new frmRol();
            CreacionRoles.Show();
        }

        private void asignarRolToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAsignarRol AsignarRoles = new frmAsignarRol();
            AsignarRoles.Show();
        }
    }
}
