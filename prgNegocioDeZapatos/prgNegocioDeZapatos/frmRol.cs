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
        #region Atributos
        private readonly MaterialSkinManager materialSkinManager;
        private clsConexion conexion;
        private clsEntidadRol pEntidadRol;
        private clsEntidadUsuario pEntidadUsuario;
        private clsEntidadVista pEntidadVista;
        private clsRol clRol;
        private clsVistas clVistas;
        private SqlDataReader dtrVista;
        private SqlDataReader dtrRol;
        private string nombreForm;
        #endregion

        public frmRol(clsConexion cone,clsEntidadUsuario pEntidadUsuario, string nombreForm)
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange700, Primary.DeepOrange900, Primary.DeepOrange500, Accent.DeepOrange200, TextShade.WHITE);

            this.conexion = cone;
            this.pEntidadUsuario = pEntidadUsuario;
            this.pEntidadRol = new clsEntidadRol();
            this.pEntidadVista = new clsEntidadVista();
            
            this.clRol = new clsRol();
            this.clVistas = new clsVistas();
            this.nombreForm = nombreForm;

            InitializeComponent();
        }

        private void frmRol_Load(object sender, EventArgs e)
        {
            pEntidadVista.Url = nombreForm;
            this.dtrVista = clVistas.mConsultarPermisosVista(this.conexion, this.pEntidadVista);

            if(dtrVista.Read())
            {
                this.pEntidadVista.Insertar = Convert.ToInt32(dtrVista.GetBoolean(0));
                this.pEntidadVista.Modificar = Convert.ToInt32(dtrVista.GetBoolean(1));
                this.pEntidadVista.Eliminar = Convert.ToInt32(dtrVista.GetBoolean(2));
                this.pEntidadVista.Consultar = Convert.ToInt32(dtrVista.GetBoolean(3));
            }

            this.activarInsertar(Convert.ToBoolean(this.pEntidadVista.Insertar));
            this.activarModificar(Convert.ToBoolean(this.pEntidadVista.Modificar));
            this.activarEliminar(Convert.ToBoolean(this.pEntidadVista.Eliminar));
            this.activarConsultar(Convert.ToBoolean(this.pEntidadVista.Consultar));
      
            this.txtNombreRol.LostFocus += new EventHandler(Validar_Textbox);
        }
        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Validar_Textbox(object Sender, EventArgs e)
        {
            pEntidadRol.setNombre(this.txtNombreRol.Text);
            dtrRol = clRol.mConsultarNombreRol(conexion,pEntidadRol);

            if(dtrRol.HasRows)
            {
                this.lblAdvertencia.Visible = true;
                this.lblAdvertencia.Text = "Este nombre ya existe";
                this.txtNombreRol.Focus();
            }
        }

        #region Metodos del IPermisos
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
