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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            DialogResult respuesta = MessageBox.Show("Saliendo del sistema de usuario", "Salir", MessageBoxButtons.OK, MessageBoxIcon.Question);
            Close();
        }

       
    }
}
