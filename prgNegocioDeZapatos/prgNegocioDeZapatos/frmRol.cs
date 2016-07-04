using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
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
        #endregion

        public frmRol(clsConexion cone,clsEntidadUsuario pEntidadUsuario, clsEntidadVista vista)
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange700, Primary.DeepOrange900, Primary.DeepOrange500, Accent.DeepOrange200, TextShade.WHITE);

            this.conexion = cone;

            this.pEntidadUsuario = pEntidadUsuario;
            this.pEntidadRol = new clsEntidadRol();
            this.pEntidadVista = vista;
            
            this.clRol = new clsRol();
            this.clVistas = new clsVistas();
            
            InitializeComponent();
        }

        private void frmRol_Load(object sender, EventArgs e)
        {
            this.activarPermisos();
            this.actualizarIdRol();
            this.txtNombreRol.LostFocus += new EventHandler(Validar_Textbox);
        }

        #region Eventos
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Validar_Textbox(object Sender, EventArgs e)
        {
            pEntidadRol.Nombre = (this.txtNombreRol.Text);
            dtrRol = clRol.mConsultarNombreRol(conexion,pEntidadRol);

            if (dtrRol.HasRows)
            {
                this.lblAdvertencia.Visible = true;
                this.lblAdvertencia.Text = "Este nombre ya existe";
                this.txtNombreRol.Focus();
            }
            else
                this.lblAdvertencia.Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.pEntidadRol.Nombre = this.txtNombreRol.Text;
            this.pEntidadRol.CreadoPor = this.pEntidadUsuario.IdUsuario;
        
            if (this.clRol.mInsertarRol(this.conexion, this.pEntidadRol, this.pEntidadUsuario))
                MessageBox.Show("Insertado con exito");
            else
                MessageBox.Show("No hace ni ostia");
        }
        #endregion

        #region Metodos del IPermisos
        public void activarInsertar(Boolean condicion)
        {
            this.btnAgregar.Enabled = condicion;
        }

        public void activarModificar(Boolean condicion)
        {
            this.btnModificar.Enabled = condicion;
        }

        public void activarEliminar(Boolean condicion)
        {
            this.btnEliminar.Enabled = condicion;
        }

        public void activarConsultar(Boolean condicion)
        {
            this.btnConsultar.Enabled = condicion;
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

        private void activarPermisos()
        {
            this.dtrVista = clVistas.mConsultarPermisosVista(this.conexion, this.pEntidadVista);

            if (dtrVista.Read())
            {
                this.activarInsertar(dtrVista.GetBoolean(0));
                this.activarModificar(dtrVista.GetBoolean(1));
                this.activarEliminar(dtrVista.GetBoolean(2));
                this.activarConsultar(dtrVista.GetBoolean(3));
            }    
        }
        #endregion     
    }
}
