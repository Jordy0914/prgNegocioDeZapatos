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
   
        private Boolean boolCondicionModificar = false;
        private Boolean boolCondicionEliminar = false;
        private Boolean isSeleccionoDatos; 
        private string idVista;
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

        #region Eventos
        private void btnConsultarRol_Click(object sender, EventArgs e)
        {
            frmLista lista = new frmLista(this.conexion, "rol");
            lista.ShowDialog();

            this.isSeleccionoDatos = lista.isSelecciono;

            if (isSeleccionoDatos)
            {
                this.txtCodRol.Text = Convert.ToString(lista.idSelecto);
                this.txtNombreRol.Text = lista.nombre;
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
            if(boolCondicionModificar)
            {
                this.pEntidadRolVista = new clsEntidadRolesVistas();
                this.pEntidadRolVista.IdRol = Convert.ToInt32(this.txtCodRol.Text);
                this.pEntidadRolVista.IdVista = Convert.ToInt32(this.txtCodVista.Text);
                this.pEntidadRolVista.Insertar = this.chbInsertar.Checked;
                this.pEntidadRolVista.Modificar = this.chbModificar.Checked;
                this.pEntidadRolVista.Eliminar = this.chbEliminar.Checked;
                this.pEntidadRolVista.Consultar = this.chbConsultar.Checked;
                
                if(this.idVista.Equals(this.txtCodVista.Text))
                {
                    if (clRolVista.mModificarSinVista(this.conexion, this.pEntidadRolVista, this.pEntidadUsuario))
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
                    if (clRolVista.mModificaConVista(this.conexion, this.pEntidadRolVista, this.pEntidadUsuario, Convert.ToInt32(this.idVista)))
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
                frmModificarRolesVistas modificar = new frmModificarRolesVistas(this.conexion, "rolVistas");
                modificar.ShowDialog();

                this.isSeleccionoDatos = modificar.isSeleciono;

                if (isSeleccionoDatos)
                {
                    this.txtCodRol.Text = Convert.ToString(modificar.IdRol);
                    this.txtNombreRol.Text = Convert.ToString(modificar.RolName);
                    this.txtCodVista.Text = Convert.ToString(modificar.IdVista);
                    this.idVista = Convert.ToString(modificar.IdVista);
                    this.txtNombreVista.Text = Convert.ToString(modificar.VistaName);
                    this.chbInsertar.Checked = modificar.boolInsertar;
                    this.chbModificar.Checked = modificar.boolModificar;
                    this.chbEliminar.Checked = modificar.boolEliminar;
                    this.chbConsultar.Checked = modificar.boolConsultar;

                    this.btnConsultarRol.Enabled = false;
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
                if (clRolVista.mEliminarRolVista(this.conexion, this.pEntidadRolVista))
                {
                    MessageBox.Show("Eliminado Correctamente");
                    this.mLimpiar();
                }
                else
                    MessageBox.Show("Problemas al elimnar");
            }
            else
            {
                frmModificarRolesVistas modificar = new frmModificarRolesVistas(this.conexion , "rolVistas");
                modificar.ShowDialog();

                this.isSeleccionoDatos = modificar.isSeleciono;

                if (isSeleccionoDatos)
                {
                    this.pEntidadRolVista = new clsEntidadRolesVistas();
                    this.pEntidadRolVista.IdRol = modificar.IdRol;
                    this.pEntidadRolVista.IdVista = modificar.IdVista;

                    this.txtCodRol.Text = Convert.ToString(modificar.IdRol);
                    this.txtNombreRol.Text = Convert.ToString(modificar.RolName);
                    this.txtCodVista.Text = Convert.ToString(modificar.IdVista);
                    this.txtNombreVista.Text = Convert.ToString(modificar.VistaName);
                    this.boolCondicionEliminar = true;
                    this.btnEliminar.Text = "Aceptar";

                    this.btnAgregar.Enabled = false;
                    this.btnModificar.Enabled = false;
                    this.btnConsultarRol.Enabled = false;
                    this.btnConsultarVista.Enabled = false;

                    this.txtNombreRol.Enabled = false;           
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
            this.btnConsultarRol.Enabled = condicion;
            this.btnConsultarVista.Enabled = condicion;
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
            this.txtCodRol.Text = "";
            this.txtNombreRol.Text = "";
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

            this.btnConsultarRol.Enabled = true;
            this.btnEliminar.Enabled = true;
            this.btnAgregar.Enabled = true;
            this.btnModificar.Enabled = true;
            this.btnConsultarRol.Enabled = true;
            this.btnConsultarVista.Enabled = true;

            this.txtNombreRol.Enabled = true;         
            this.txtNombreVista.Enabled = true;
            this.chbInsertar.Enabled = true;
            this.chbModificar.Enabled = true;
            this.chbEliminar.Enabled = true;
            this.chbConsultar.Enabled = true;
        }
        #endregion
    }
}
