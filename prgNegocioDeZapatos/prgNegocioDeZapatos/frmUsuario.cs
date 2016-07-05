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
    public partial class frmUsuario : MaterialForm, IPermisos
    {
        #region Atributos
        private readonly MaterialSkinManager materialSkinManager;
        clsConexion conexion;

        clsUsuario clUsuario;
        clsEntidadUsuario pEntidadUsuario;

        SqlDataReader dtrUsuarios;

        private clsEntidadVista pEntidadVista;
        private clsVistas clVistas;
        
        private SqlDataReader dtrVista;
        Boolean bolAgregar, bolEliminar, bolModificar;
        #endregion

        #region Constructor
        public frmUsuario(clsConexion cone, clsEntidadUsuario pEntidadUsuario, clsEntidadVista vista)
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange700, Primary.DeepOrange900, Primary.DeepOrange500, Accent.DeepOrange200, TextShade.WHITE);
            this.conexion = cone;
            this.pEntidadUsuario = pEntidadUsuario;
            this.pEntidadVista = vista;
            this.clVistas = new clsVistas();
            this.clUsuario = new clsUsuario();

            InitializeComponent();

        }
        #endregion
        
        #region Eventos
        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bolEliminar = clUsuario.mEliminarUsuario(conexion, pEntidadUsuario);
            if (bolEliminar == true)
            {
                MessageBox.Show("El producto ha sido eliminado correctamente", "Registro correcto", MessageBoxButtons.OK);


            }//fin del if
            this.Limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        { 
            frmLista consultarUsuario = new frmLista(conexion,"usuarios");
            consultarUsuario.ShowDialog();

            if (consultarUsuario.isSelecciono==true) {
                this.pEntidadUsuario.IdUsuario = (consultarUsuario.idSelecto);
                txtCodigo.Text = Convert.ToString(consultarUsuario.idSelecto);
                mConsultaUsuario();
            }

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            pEntidadUsuario.setLogin(txtUsuario.Text);
            pEntidadUsuario.setPassword(txtPassword.Text);
            pEntidadUsuario.setNombre(txtNombre.Text);
            pEntidadUsuario.setApellido1(txtApellido1.Text);
            pEntidadUsuario.setApellido2(txtApellido2.Text);
            pEntidadUsuario.setDireccion(txtDireccion.Text);
            pEntidadUsuario.setTipoIdentificacion(cboTipoI.Text);
            pEntidadUsuario.setFechaN(Convert.ToDateTime(txtFechaN.Text));
            pEntidadUsuario.setPuesto(txtPuesto.Text);
            pEntidadUsuario.setCedula(Convert.ToInt32(txtCedula.Text));
            bolAgregar = clUsuario.mInsertar(conexion, pEntidadUsuario);

            if (bolAgregar == true)
            {
                MessageBox.Show("El usuario ha sido agregado correctamente", "Registro correcto", MessageBoxButtons.OK);


            }//fin del if
            this.Limpiar();



        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            pEntidadUsuario.setPassword(txtPassword.Text);
            pEntidadUsuario.setNombre(txtNombre.Text);
            pEntidadUsuario.setApellido1(txtApellido1.Text);
            pEntidadUsuario.setApellido2(txtApellido2.Text);
            pEntidadUsuario.setDireccion(txtDireccion.Text);
            pEntidadUsuario.setTipoIdentificacion(cboTipoI.Text);
            pEntidadUsuario.setFechaN(Convert.ToDateTime(txtFechaN.Text));
            pEntidadUsuario.setPuesto(txtPuesto.Text);
            pEntidadUsuario.setCedula(Convert.ToInt32(txtCedula.Text));
            bolModificar = clUsuario.mModificar(conexion, pEntidadUsuario);

            if (bolModificar == true)
            {
                MessageBox.Show("El usuario ha sido modificado correctamente", "Registro correcto", MessageBoxButtons.OK);


            }//fin del if
            this.Limpiar();
        }

        #endregion


        #region Metodos Propios
        public void mConsultaUsuario()
        {
            pEntidadUsuario.setIdUsuario(Convert.ToInt32(txtCodigo.Text.Trim()));
            
            dtrUsuarios =clUsuario.mConsultarUsuario2(conexion, pEntidadUsuario);
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
                    this.txtFechaN.Text = Convert.ToString(dtrUsuarios.GetDateTime(8));
                    this.txtPuesto.Text = dtrUsuarios.GetString(9);
                    this.txtCedula.Text = Convert.ToString(dtrUsuarios.GetInt32(10));
                    this.txtUsuario.Enabled = false;
                    
                   
                }//FIN READ
            }//fin del if que verifica que no este null
        }//fin del metodo que consulta el producto segun su id

        public void Limpiar()
        {
            this.txtCodigo.Text = "";
            this.txtNombre.Text = "";
            this.txtApellido1.Text = "";
            this.txtApellido2.Text = "";
            this.cboTipoI.Text = "";
            this.txtCedula.Text = "";
            this.txtFechaN.Text = "";
            this.txtDireccion.Text = "";
            this.txtUsuario.Text = "";
            this.txtPassword.Text = "";
            this.txtPuesto.Text = "";
            this.txtUsuario.Enabled = true;
        }

        private void activarPermisos()
        {
            this.dtrVista = clVistas.mConsultarPermisosVista(this.conexion, this.pEntidadVista);

            if (dtrVista.Read())
            {
                this.activarInsertar(dtrVista.GetBoolean(0));
                this.bolModificar = (dtrVista.GetBoolean(1));
                this.bolEliminar = (dtrVista.GetBoolean(2));
                this.activarConsultar(dtrVista.GetBoolean(3));
            }
        }

        #endregion


        #region Metodos de la Interface IPermisos
        public void activarInsertar(Boolean condicion)
        {
            this.btnIngresar.Enabled = condicion;
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
            this.btnBuscar.Enabled = condicion;
        }
        #endregion

        private void frmUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
