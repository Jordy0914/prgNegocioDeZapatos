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

        SqlDataReader dtrSentencia, dtrUsuarios, dtrRoles;
        clsEntidadUsuario usuario;
        clsUsuario clUsuario;

        clsEntidadRol rol;
        clsRol clRol;
        private clsEntidadVista pEntidadVista;
        clsConexion conexion;
       
        #endregion

        public frmAsignarRol(clsConexion cone, clsEntidadUsuario pEntidadUsuario, clsEntidadVista vistas)
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange700, Primary.DeepOrange900, Primary.DeepOrange500, Accent.DeepOrange200, TextShade.WHITE);
            this.conexion = cone;
            this.pEntidadVista = vistas;
            this.usuario = pEntidadUsuario;
            this.rol = new clsEntidadRol();
            this.clUsuario = new clsUsuario();
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

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            frmLista consultarUsuario = new frmLista(conexion, "usuarios");
            consultarUsuario.ShowDialog();

            if (consultarUsuario.idSelecto != 0 || consultarUsuario.idSelecto == 0)
            {
                this.usuario.IdUsuario = (consultarUsuario.idSelecto);
                txtIdUsuario.Text = Convert.ToString(consultarUsuario.idSelecto);
                mConsultaUsuario();
            }//fin del if que verifica que no sea igual a 0
        }

        private void btnBuscarRol_Click(object sender, EventArgs e)
        {
            frmLista consultarRol = new frmLista(conexion, "rol");
            consultarRol.ShowDialog();

            if (consultarRol.idSelecto != 0 || consultarRol.idSelecto == 0)
            {
                this.rol.IdRol = (consultarRol.idSelecto);
                txtIdRol.Text = Convert.ToString(consultarRol.idSelecto);
                mConsultaRol();
            }//fin del if que verifica que no sea igual a 0
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {

        }

        #region metodosPropios

        public void mConsultaUsuario()
        {
            usuario.setIdUsuario(Convert.ToInt32(txtIdUsuario.Text.Trim()));
            dtrUsuarios = clUsuario.mConsultarUsuario2(conexion, usuario);
            if (dtrUsuarios != null)
            {
                if (dtrUsuarios.Read())
                {
                    this.txtNombreUsuario.Text = dtrUsuarios.GetString(3);
                }//FIN READ
            }//fin del if que verifica que no este null
        }//fin del metodo que consulta el producto segun su id

        public void mConsultaRol()
        {
            rol.IdRol=(Convert.ToInt32(txtIdRol.Text.Trim()));
            dtrRoles = clRol.mConsutarRol(conexion, rol);
            if (dtrRoles != null)
            {
                if (dtrRoles.Read())
                {
                    this.txtNombreRol.Text = dtrRoles.GetString(1);
                }//FIN READ
            }//fin del if que verifica que no este null
        }//fin del metodo que consulta el producto segun su id
        #endregion
    }
}
