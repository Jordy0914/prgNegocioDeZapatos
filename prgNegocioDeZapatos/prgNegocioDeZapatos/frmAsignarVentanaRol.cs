using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class frmAsignarVentanaRol : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public frmAsignarVentanaRol()
        {

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange700, Primary.DeepOrange900, Primary.DeepOrange500, Accent.DeepOrange200, TextShade.WHITE);

            InitializeComponent();
        }

        private void frmAsignarVentanaRol_Load(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        public void Limpiar()
        {
            this.cbxCodRole.Text = "";
            this.txtNombreRole.Text = "";
            this.cbxCodVentanas.Text = "";
            this.txtNomVentana.Text = "";
        }//fin del metodo limpiar
    }
}
