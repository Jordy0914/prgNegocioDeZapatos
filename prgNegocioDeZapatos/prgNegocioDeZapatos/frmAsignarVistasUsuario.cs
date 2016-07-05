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

using AccesoDatos;
using Entidades;
using LogicaNegocios;
using System.Data.SqlClient;

namespace prgNegocioDeZapatos
{
    public partial class frmAsignarVistasUsuario : MaterialForm, IPermisos
    {
        #region Atributos
        private readonly MaterialSkinManager materialSkinManager;
        private clsConexion conexion;

        private clsEntidadUsuarioVistas pEntidadUsuarioVistas;
        private clsEntidadUsuario pEntidadUsuario;
        private clsEntidadVista pEntidadVista;

        private clsUsuarioVista clUsuarioVistas;
        private clsVistas clVistas;

        private SqlDataReader dtrVista;

        private Boolean boolCondicionModificar = false;
        private Boolean boolCondicionEliminar = false;
        private Boolean isSeleccionoDatos;
        private string idVista;
        #endregion

        public frmAsignarVistasUsuario(clsConexion cone, clsEntidadUsuario pEntidadUsuario, clsEntidadVista vista)
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange700, Primary.DeepOrange900, Primary.DeepOrange500, Accent.DeepOrange200, TextShade.WHITE);

            this.conexion = cone;
            this.pEntidadUsuario = pEntidadUsuario;
            this.pEntidadVista = vista;
            this.pEntidadUsuarioVistas = new clsEntidadUsuarioVistas();

            this.clUsuarioVistas = new clsUsuarioVista();
            this.clVistas = new clsVistas();

            InitializeComponent();
        }

        private void frmAsignarVistasUsuario_Load(object sender, EventArgs e)
        {
            this.activarPermisos();
        }

        #region Eventos
        private void btnConsultarUsuario_Click(object sender, EventArgs e)
        {
            frmLista lista = new frmLista(this.conexion, "usuarios");
            lista.ShowDialog();

            this.isSeleccionoDatos = lista.isSelecciono;

            if (isSeleccionoDatos)
            {
                this.txtCodUsuario.Text = Convert.ToString(lista.idSelecto);
                this.txtNombreUsuario.Text = lista.nombre;
            }
        }

        private void btnConsultarVista_Click(object sender, EventArgs e)
        {
            frmLista lista = new frmLista(this.conexion, "vistas");
            lista.ShowDialog();

            this.isSeleccionoDatos = lista.isSelecciono;

            if (isSeleccionoDatos)
            {
                this.txtCodVista.Text = Convert.ToString(lista.idSelecto);
                this.txtNombreVista.Text = lista.nombre;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.pEntidadUsuarioVistas.IdUsuario = Convert.ToInt32(this.txtCodUsuario.Text);
            this.pEntidadUsuarioVistas.IdVista = Convert.ToInt32(this.txtCodVista.Text);
            this.pEntidadUsuarioVistas.Insertar = this.chbInsertar.Checked;
            this.pEntidadUsuarioVistas.Modificar = this.chbModificar.Checked;
            this.pEntidadUsuarioVistas.Eliminar = this.chbEliminar.Checked;
            this.pEntidadUsuarioVistas.Consultar = this.chbConsultar.Checked;

            if (this.clUsuarioVistas.mInsertarUsuarioVista(this.conexion, this.pEntidadUsuarioVistas, this.pEntidadUsuario))
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
            if (boolCondicionModificar)
            {
                this.pEntidadUsuarioVistas = new clsEntidadUsuarioVistas();
                this.pEntidadUsuarioVistas.IdUsuario = Convert.ToInt32(this.txtCodUsuario.Text);
                this.pEntidadUsuarioVistas.IdVista = Convert.ToInt32(this.txtCodVista.Text);
                this.pEntidadUsuarioVistas.Insertar = this.chbInsertar.Checked;
                this.pEntidadUsuarioVistas.Modificar = this.chbModificar.Checked;
                this.pEntidadUsuarioVistas.Eliminar = this.chbEliminar.Checked;
                this.pEntidadUsuarioVistas.Consultar = this.chbConsultar.Checked;

                if (this.idVista.Equals(this.txtCodVista.Text))
                {
                    if (clUsuarioVistas.mModificarSinVista(this.conexion, this.pEntidadUsuarioVistas, this.pEntidadUsuario))
                    {
                        MessageBox.Show("Modificacion Exitosa");
                        this.mLimpiar();
                    }
                    else
                    {
                        MessageBox.Show("Error en la modificacion");
                        this.mLimpiar();
                    }
                }
                else
                {
                    if (clUsuarioVistas.mModificarConVista(this.conexion, this.pEntidadUsuarioVistas, this.pEntidadUsuario, Convert.ToInt32(this.idVista)))
                    {
                        MessageBox.Show("Modificacion Exitosa con vista");
                        this.mLimpiar();
                    }
                    else
                    {
                        MessageBox.Show("Error en la modificacion");
                        this.mLimpiar();
                    }
                }

            }
            else
            {
                frmModificarRolesVistas modificar = new frmModificarRolesVistas(this.conexion, "usuarioVistas");
                modificar.ShowDialog();

                this.isSeleccionoDatos = modificar.isSeleciono;

                if (isSeleccionoDatos)
                {
                    this.txtCodUsuario.Text = Convert.ToString(modificar.IdRol);
                    this.txtNombreUsuario.Text = Convert.ToString(modificar.RolName);
                    this.txtCodVista.Text = Convert.ToString(modificar.IdVista);
                    this.idVista = Convert.ToString(modificar.IdVista);
                    this.txtNombreVista.Text = Convert.ToString(modificar.VistaName);
                    this.chbInsertar.Checked = modificar.boolInsertar;
                    this.chbModificar.Checked = modificar.boolModificar;
                    this.chbEliminar.Checked = modificar.boolEliminar;
                    this.chbConsultar.Checked = modificar.boolConsultar;

                    this.btnBuscarUsuario.Enabled = false;
                    this.btnEliminar.Enabled = false;
                    this.btnAgregar.Enabled = false;

                    this.boolCondicionModificar = true;
                    this.btnModificar.Text = "Aceptar";
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (boolCondicionEliminar)
            {
                if (clUsuarioVistas.mEliminarUsuarioVista(this.conexion, this.pEntidadUsuarioVistas))
                {
                    MessageBox.Show("Eliminado Correctamente");
                    this.mLimpiar();
                }
                else
                    MessageBox.Show("Problemas al elimnar");
            }
            else
            {
                frmModificarRolesVistas modificar = new frmModificarRolesVistas(this.conexion, "usuarioVistas");
                modificar.ShowDialog();

                this.isSeleccionoDatos = modificar.isSeleciono;

                if (isSeleccionoDatos)
                {
                    this.pEntidadUsuarioVistas = new clsEntidadUsuarioVistas();
                    this.pEntidadUsuarioVistas.IdUsuario = modificar.IdRol;
                    this.pEntidadUsuarioVistas.IdVista = modificar.IdVista;

                    this.txtCodUsuario.Text = Convert.ToString(modificar.IdRol);
                    this.txtNombreUsuario.Text = Convert.ToString(modificar.RolName);
                    this.txtCodVista.Text = Convert.ToString(modificar.IdVista);
                    this.txtNombreVista.Text = Convert.ToString(modificar.VistaName);
                    this.boolCondicionEliminar = true;
                    this.btnEliminar.Text = "Aceptar";

                    this.btnAgregar.Enabled = false;
                    this.btnModificar.Enabled = false;
                    this.btnBuscarUsuario.Enabled = false;
                    this.btnBuscarVista.Enabled = false;

                    this.txtNombreUsuario.Enabled = false;
                    this.txtNombreVista.Enabled = false;
                    this.chbInsertar.Enabled = false;
                    this.chbModificar.Enabled = false;
                    this.chbEliminar.Enabled = false;
                    this.chbConsultar.Enabled = false;
                }
            }
        }
        #endregion

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
            this.btnBuscarUsuario.Enabled = condicion;
            this.btnBuscarVista.Enabled = condicion;
        }
        #endregion

        #region Metodos Propios
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

        private void mLimpiar()
        {
            this.txtCodUsuario.Text = "";
            this.txtNombreUsuario.Text = "";
            this.txtCodVista.Text = "";
            this.txtNombreVista.Text = "";
            this.chbInsertar.Checked = false;
            this.chbModificar.Checked = false;
            this.chbEliminar.Checked = false;
            this.chbConsultar.Checked = false;
            this.boolCondicionModificar = false;
            this.boolCondicionEliminar = false;
            this.idVista = "";

            this.btnModificar.Text = "Modificar";
            this.btnEliminar.Text = "Eliminar";

            this.btnBuscarUsuario.Enabled = true;
            this.btnEliminar.Enabled = true;
            this.btnAgregar.Enabled = true;
            this.btnModificar.Enabled = true;
            this.btnBuscarVista.Enabled = true;

            this.txtNombreUsuario.Enabled = true;
            this.txtNombreVista.Enabled = true;
            this.chbInsertar.Enabled = true;
            this.chbModificar.Enabled = true;
            this.chbEliminar.Enabled = true;
            this.chbConsultar.Enabled = true;
        }
        #endregion
    }// fin clase
} // fin namespace
