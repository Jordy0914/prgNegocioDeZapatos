using System;
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

using Entidades;
using AccesoDatos;
using LogicaNegocios;
using System.Data.SqlClient;

namespace prgNegocioDeZapatos
{
    public partial class frmRol : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private clsConexion conexion;
        private clsEntidadRol pEntidadRol;
        private clsEntidadUsuario pEntidadUsuario;
        private clsRol clRol;
        private SqlDataReader dtrRol;

        public frmRol(clsConexion cone,clsEntidadUsuario pEntidadUsuario)
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange700, Primary.DeepOrange900, Primary.DeepOrange500, Accent.DeepOrange200, TextShade.WHITE);

            this.conexion = cone;
            this.pEntidadRol = new clsEntidadRol();
            this.pEntidadUsuario = pEntidadUsuario;
            this.clRol = new clsRol();

            InitializeComponent();
        }

        private void frmRol_Load(object sender, EventArgs e)
        {
            this.actualizarIdRol();
            MessageBox.Show("el id del usuario es " + pEntidadUsuario.getIdUsuario());
        }
        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Metodos Propios
        public void actualizarIdRol()
        {
            dtrRol = clRol.mConsutarNumeroRol(this.conexion);
            if (dtrRol.Read())
                this.txtCodRol.Text = Convert.ToString(dtrRol.GetInt32(0));
            else
                this.txtCodRol.Text = "1";
        }
        #endregion


    }
}
