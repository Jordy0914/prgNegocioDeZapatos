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
using LogicaNegocios;
using AccesoDatos;
using Entidades;

using System.Data.SqlClient;

namespace prgNegocioDeZapatos
{
    public partial class frmAsignarVistasRol : MaterialForm , IPermisos
    {
        #region Atributos
        private readonly MaterialSkinManager materialSkinManager;
        private clsConexion conexion;

        private clsEntidadRolesVistas pEntidadRolVista;
        private clsEntidadUsuario pEntidadUsuario;
        private clsEntidadVista pEntidadVista;
        
        private clsRolVista clRolVista;
        private clsVistas clVistas;
        
        private SqlDataReader dtrVista;
        private SqlDataReader dtrRolVista;
        private Boolean boolModificar, boolEliminar;
        #endregion

        public frmAsignarVistasRol(clsConexion cone, clsEntidadUsuario pEntidadUsuario, clsEntidadVista vista)
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange700, Primary.DeepOrange900, Primary.DeepOrange500, Accent.DeepOrange200, TextShade.WHITE);

            this.conexion = cone;
            this.pEntidadUsuario = pEntidadUsuario;
            this.pEntidadVista = vista;
            this.pEntidadRolVista = new clsEntidadRolesVistas();

            this.clRolVista = new clsRolVista();
            this.clVistas = new clsVistas();
            
            InitializeComponent();
        }

        private void frmAsignarVistasRol_Load(object sender, EventArgs e)
        {
            this.activarPermisos();
        }

        #region Metodos de la Interface IPermisos
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
            this.btnConsultarRol.Enabled = condicion;
            this.btnConsultarVista.Enabled = condicion;
        }
        #endregion

        #region Eventos
        private void btnConsultarRol_Click(object sender, EventArgs e)
        {
            frmLista lista = new frmLista(this.conexion, "rol");
            lista.ShowDialog();

            this.txtCodRol.Text = Convert.ToString(lista.idSelecto);
            this.txtNombreRol.Text = lista.nombre;
        }

        private void btnConsultarVista_Click(object sender, EventArgs e)
        {
            frmLista lista = new frmLista(this.conexion, "vistas");
            lista.ShowDialog();

            this.txtCodVista.Text = Convert.ToString(lista.idSelecto);
            this.txtNombreVista.Text = lista.nombre;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.pEntidadRolVista.IdRol = Convert.ToInt32(this.txtCodRol.Text);
            this.pEntidadRolVista.IdVista = Convert.ToInt32(this.txtCodVista.Text);
            this.pEntidadRolVista.Insertar = this.chbInsertar.Checked;
            this.pEntidadRolVista.Modificar = this.chbModificar.Checked;
            this.pEntidadRolVista.Eliminar = this.chbEliminar.Checked;
            this.pEntidadRolVista.Consultar = this.chbConsultar.Checked;

            if (this.clRolVista.insertarRolVista(this.conexion, this.pEntidadRolVista, this.pEntidadUsuario))
            {
                MessageBox.Show("Insertado Correctamente");
                this.mLimpiar();
            }
                
            else
                MessageBox.Show("Problemas al insertar");

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificarRolesVistas modificar = new frmModificarRolesVistas();
            modificar.ShowDialog();
        }
        #endregion

        #region Metodos Propios
        private void activarPermisos()
        {
            this.dtrVista = clVistas.mConsultarPermisosVista(this.conexion, this.pEntidadVista);

            if (dtrVista.Read())
            {
                this.activarInsertar(dtrVista.GetBoolean(0));
                this.boolModificar = (dtrVista.GetBoolean(1));
                this.boolEliminar = (dtrVista.GetBoolean(2));
                this.activarConsultar(dtrVista.GetBoolean(3));
            }
        }

        private void mLimpiar()
        {
            this.txtCodRol.Text = "";
            this.txtNombreRol.Text = "";
            this.txtCodVista.Text = "";
            this.txtNombreVista.Text = "";
            this.chbInsertar.Checked = false;
            this.chbModificar.Checked = false;
            this.chbEliminar.Checked = false;
            this.chbConsultar.Checked = false;
        }
        #endregion

    }
}
