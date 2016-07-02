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
using LogicaNegocios;
using AccesoDatos;
using System.Data.SqlClient;

namespace prgNegocioDeZapatos
{
    public partial class frmAsignarRol : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;


        #region Atributos

        SqlDataReader dtrSentencia;
        clsEntidadUsuario usuario;
        clsUsuario clUsuario;

        clsEntidadRol rol;
        clsRol clRol;

        clsConexion conexion;
       
        #endregion

        public frmAsignarRol()
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange700, Primary.DeepOrange900, Primary.DeepOrange500, Accent.DeepOrange200, TextShade.WHITE);

            this.usuario = new clsEntidadUsuario();
            this.clUsuario = new clsUsuario();
            this.rol = new clsEntidadRol();
            this.clRol = new clsRol();

            InitializeComponent();
        }

        
    
        private void frmAsignarRol_Load(object sender, EventArgs e)
        {
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }
        
    }
}
