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
    public partial class frmRol : MaterialForm , IPermisos
    {
        private readonly MaterialSkinManager materialSkinManager;
        private clsConexion conexion;
        private clsEntidadRol pEntidadRol;
        private clsEntidadUsuario pEntidadUsuario;
        private clsEntidadVista pEntidadVista;
        private clsRol clRol;
        private SqlDataReader dtrRol;       

        public frmRol(clsConexion cone,clsEntidadUsuario pEntidadUsuario,clsEntidadVista vista)
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange700, Primary.DeepOrange900, Primary.DeepOrange500, Accent.DeepOrange200, TextShade.WHITE);

            this.conexion = cone;
            this.pEntidadRol = new clsEntidadRol();
            this.pEntidadUsuario = pEntidadUsuario;
            this.pEntidadVista = vista;
            this.clRol = new clsRol();

            InitializeComponent();
        }

        private void frmRol_Load(object sender, EventArgs e)
        {
            this.activarInsertar(Convert.ToBoolean(this.pEntidadVista.Insertar));
            this.activarModificar(Convert.ToBoolean(this.pEntidadVista.Modificar));
            this.activarEliminar(Convert.ToBoolean(this.pEntidadVista.Eliminar));
            this.activarConsultar(Convert.ToBoolean(this.pEntidadVista.Consultar));
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

        public void activarInsertar(Boolean condicion)
        {
            this.btnAgregar.Enabled = condicion;
            this.btnAgregar.Visible = condicion;
        }

        public void activarModificar(Boolean condicion)
        {
            this.btnModificar.Enabled = condicion;
            this.btnModificar.Visible = condicion;
        }

        public void activarEliminar(Boolean condicion)
        {
            this.btnEliminar.Enabled = condicion;
            this.btnEliminar.Visible = condicion;
        }

        public void activarConsultar(Boolean condicion)
        {
            this.btnConsultar.Enabled = condicion;
            this.btnConsultar.Visible = condicion;
        }
        #endregion
    }
}
