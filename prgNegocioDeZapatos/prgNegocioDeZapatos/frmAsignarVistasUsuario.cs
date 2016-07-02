using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin.Controls;
using MaterialSkin;

namespace prgNegocioDeZapatos
{
    public partial class frmAsignarVistasUsuario : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public frmAsignarVistasUsuario()
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange700, Primary.DeepOrange900, Primary.DeepOrange500, Accent.DeepOrange200, TextShade.WHITE);

            InitializeComponent();
        }

        private void frmAsignarVistasUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
