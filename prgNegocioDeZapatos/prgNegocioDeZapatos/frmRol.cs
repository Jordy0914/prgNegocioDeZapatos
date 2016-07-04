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
        private Boolean boolModificar , boolEliminar ;
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
        }

        #region Eventos
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.txtNombreRol.Text == "")
            {
                MessageBox.Show("Debe insertar un nombre");
            }
                else if (this.VerificarNombreRol()) { }
            else
            {
                this.pEntidadRol.Nombre = this.txtNombreRol.Text;
                this.pEntidadRol.CreadoPor = this.pEntidadUsuario.IdUsuario;

                if (this.clRol.mInsertarRol(this.conexion, this.pEntidadRol, this.pEntidadUsuario))
                {
                    MessageBox.Show("Insertado con exito");
                    this.mLimpiar();
                }
                else
                    MessageBox.Show("Problemas al insertar");
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (this.txtNombreRol.Text == "")
            {
                this.mLlenarLbAnuncio("Digite el nombre el rol");
            }
            else
            {
                String mensaje = "Escriba el nuevo nombre y presione 'Modificar'\n" +
                             "O elimine el rol presionando 'Eliminar'";

                pEntidadRol.Nombre = (this.txtNombreRol.Text);
                dtrRol = clRol.mConsultarNombreRol(conexion, pEntidadRol);

                if (dtrRol.HasRows)
                {
                    if (dtrRol.Read())
                    {
                        if (boolModificar)
                        {
                            this.txtCodRol.Text = Convert.ToString(dtrRol.GetInt32(0));
                            this.mLlenarLbAnuncio(mensaje);
                            this.activarModificar(boolModificar);
                            this.txtNombreRol.Focus();
                        }
                        if (boolEliminar)
                        {
                                this.txtCodRol.Text = Convert.ToString(dtrRol.GetInt32(0));
                                this.mLlenarLbAnuncio(mensaje);
                                this.activarEliminar(boolEliminar);
                        }
                        else
                            this.mLlenarLbAnuncio("Solo puede consultar");
                    }
                }
                else
                    this.mLlenarLbAnuncio("El rol no existe");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.pEntidadRol = new clsEntidadRol();
            this.pEntidadRol.IdRol = Convert.ToInt32(txtCodRol.Text);
            this.pEntidadRol.Nombre = txtNombreRol.Text;

            if(clRol.mModificarRol(this.conexion, this.pEntidadRol, this.pEntidadUsuario))
            {
                MessageBox.Show("Modificado con exito");
                this.mLimpiar();
            }        
            else
                MessageBox.Show("Problemas al modificar");

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.pEntidadRol = new clsEntidadRol();
            this.pEntidadRol.IdRol = Convert.ToInt32(txtCodRol.Text);

            if (clRol.mEliminarRol(this.conexion, this.pEntidadRol))
            {
                MessageBox.Show("Eliminado con exito");
                this.mLimpiar();
            }
            else
                MessageBox.Show("Problemas al eliminar");
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
            this.txtNombreRol.Text = "";
            this.lblAdvertencia.Visible = false;
            this.btnModificar.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.txtCodRol.Text = "";
        }

        private Boolean VerificarNombreRol()
        {
            pEntidadRol.Nombre = (this.txtNombreRol.Text);
            dtrRol = clRol.mConsultarNombreRol(conexion, pEntidadRol);

            if (dtrRol.HasRows)
            {
                this.mLlenarLbAnuncio("Este nombre ya existe!");
                this.txtNombreRol.Focus();
                return true;
            }
            else
            {
                this.lblAdvertencia.Visible = false;
                return false;
            }
        }

        private void mLlenarLbAnuncio(string mensaje)
        {
            this.lblAdvertencia.Visible = true;
            this.lblAdvertencia.Text = mensaje;
        }
        #endregion
    }
}
