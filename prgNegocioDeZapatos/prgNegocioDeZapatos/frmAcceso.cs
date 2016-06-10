using System;
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
    public partial class frmAcceso : Form
    {
        public frmAcceso()
        {
            InitializeComponent();
        }

        private void frmAcceso_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saliendo del sistema");
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            this.SetVisibleCore(false);
           frmMenu Menu = new frmMenu();
            Menu.Show();
        }
    }
}
