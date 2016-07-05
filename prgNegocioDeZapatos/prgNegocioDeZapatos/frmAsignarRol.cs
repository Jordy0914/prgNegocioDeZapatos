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
        clsRol clRol;
        private clsEntidadVista pEntidadVista;
        clsConexion conexion;
        clsEntidadRolesUsuarios pEntidadRolesUsurios;
        clsEntidadRol pEntidadRol;
        clsRolesUsuarios clRolesUsuarios;

        private Boolean bolAgregar, bolModificar, bolEliminar;
        #endregion

        #region Constructor
        public frmAsignarRol(clsConexion cone, clsEntidadUsuario pEntidadUsuario, clsEntidadVista vistas)
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange700, Primary.DeepOrange900, Primary.DeepOrange500, Accent.DeepOrange200, TextShade.WHITE);
            this.conexion = cone;
            this.pEntidadVista = vistas;
            this.usuario = pEntidadUsuario;
            this.pEntidadRol = new clsEntidadRol();
            this.clUsuario = new clsUsuario();
            this.clRol = new clsRol();
            this.pEntidadRol = new clsEntidadRol();
            this.pEntidadRolesUsurios = new clsEntidadRolesUsuarios();
            this.clRolesUsuarios = new clsRolesUsuarios();

            InitializeComponent();
        }

        #endregion

        #region Eventos

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
                this.pEntidadRol.IdRol = (consultarRol.idSelecto);
                txtIdRol.Text = Convert.ToString(consultarRol.idSelecto);
                mConsultaRol();
            }//fin del if que verifica que no sea igual a 0
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            usuario.IdUsuario = Convert.ToInt32(txtIdUsuario.Text);
            pEntidadRol.IdRol = Convert.ToInt32(txtIdRol.Text);
            bolModificar = clRolesUsuarios.modificarRolUsuario(conexion, pEntidadRol, usuario);

            if (bolModificar == true)
            {
                MessageBox.Show("El rol ha sido Modificado correctamente", "Registro correcto", MessageBoxButtons.OK);
            }//fin del if

            this.limpiar();

        }

        private void frmAsignarRol_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            usuario.IdUsuario = Convert.ToInt32(txtIdUsuario.Text);
            pEntidadRol.IdRol = Convert.ToInt32(txtIdRol.Text);

            bolEliminar = clRolesUsuarios.eliminarRolUsuario(conexion,pEntidadRol,usuario);

            if (bolEliminar == true)
            {
                MessageBox.Show("El rol ha sido eliminado correctamente", "Registro correcto", MessageBoxButtons.OK);
            }//fin del if
            this.limpiar();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {

            this.pEntidadRol.IdRol = Convert.ToInt32(txtIdRol.Text);
            this.usuario.setIdUsuario(Convert.ToInt32(txtIdUsuario.Text));

            bolAgregar = clRolesUsuarios.insertarRolUsuario(conexion, pEntidadRol, usuario);

                if (bolAgregar == true)
                {
                    MessageBox.Show("El rol ha sido agregado correctamente", "Registro correcto", MessageBoxButtons.OK);
                }//fin del if
                this.limpiar();
        }

        #endregion

        #region metodosPropios

        public void limpiar()
        {
            this.txtIdRol.Text = "";
            this.txtIdUsuario.Text = "";
            this.txtNombreRol.Text = "";
            this.txtNombreUsuario.Text = "";
            this.txtIdRol.Enabled = false;
            this.txtIdUsuario.Enabled = false;
        }

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
            pEntidadRol.IdRol=(Convert.ToInt32(txtIdRol.Text.Trim()));
            dtrRoles = clRol.mConsutarRol(conexion, pEntidadRol);
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
