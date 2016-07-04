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
using AccesoDatos;
using LogicaNegocios;
using Entidades;
using System.Data.SqlClient;


namespace prgNegocioDeZapatos
{
    public partial class frmUsuario : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        clsConexion conexion;

        clsUsuario clUsuario;
        clsEntidadUsuario pEntidadUsuario;

        SqlDataReader dtrUsuarios;

        public static int señal;

        public frmUsuario()
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange700, Primary.DeepOrange900, Primary.DeepOrange500, Accent.DeepOrange200, TextShade.WHITE);
            pEntidadUsuario = new clsEntidadUsuario();
            clUsuario = new clsUsuario();
            conexion = new clsConexion();

            InitializeComponent();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();

        }


        #region Eventos
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            señal = 1;
            frmLista consultarUsuario = new frmLista(conexion,"usuarios");
            consultarUsuario.ShowDialog();

            if (consultarUsuario.idSelecto != 0 || consultarUsuario.idSelecto == 0)
            {
                this.pEntidadUsuario.IdUsuario=(consultarUsuario.idSelecto);
                txtCodigo.Text = Convert.ToString(consultarUsuario.idSelecto);
                mConsultaUsuario();
            }//fin del if que verifica que no sea igual a 0
        }
        #endregion



        #region Metodos Propios
        public void mConsultaUsuario()
        {
            pEntidadUsuario.setIdUsuario(Convert.ToInt32(txtCodigo.Text.Trim()));

            dtrUsuarios = clUsuario.mConsultarUsuario(conexion, pEntidadUsuario);
            if (dtrUsuarios != null)
            {
                if (dtrUsuarios.Read())
                {
                    this.txtUsuario.Text = dtrUsuarios.GetString(1);
                    this.txtPassword.Text = dtrUsuarios.GetString(2);
                    this.txtNombre.Text = dtrUsuarios.GetString(3);
                    this.txtApellido1.Text = dtrUsuarios.GetString(4);
                    this.txtApellido2.Text = dtrUsuarios.GetString(5);
                    this.txtDireccion.Text = dtrUsuarios.GetString(6);
                    this.cboTipoI.Text = dtrUsuarios.GetString(7);
                    this.txtFechaN.Text = dtrUsuarios.GetString(8);
                    this.txtPuesto.Text = dtrUsuarios.GetString(9);
                    this.txtCedula.Text = dtrUsuarios.GetString(10);
                    
                   
                }//FIN READ
            }//fin del if que verifica que no este null
        }//fin del metodo que consulta el producto segun su id

        public void Limpiar()
        {
            this.txtNombre.Text = "";
            this.txtApellido1.Text = "";
            this.txtApellido2.Text = "";
            this.cboTipoI.Text = "";
            this.txtCedula.Text = "";
            this.txtFechaN.Text = "";
            this.txtDireccion.Text = "";
            this.txtUsuario.Text = "";
            this.txtPassword.Text = "";
        }
        #endregion
    }
}
