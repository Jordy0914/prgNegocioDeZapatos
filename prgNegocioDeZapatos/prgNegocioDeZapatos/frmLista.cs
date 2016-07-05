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
using System.Data.SqlClient;
using AccesoDatos;
using Entidades;
using LogicaNegocios;
namespace prgNegocioDeZapatos
{
    public partial class frmLista : MaterialForm
    {
        #region Atributos
        private readonly MaterialSkinManager materialSkinManager;
        private SqlDataReader strSentencia;
        private clsConexion conexion;
        private clsEntidadProducto pEntidadProducto;
        private clsEntidadUsuario pEntidadUsuario;
        private clsProducto clProducto;
        private clsUsuario clUsuarios;
        private clsRol clRol;
        private clsVistas clVistas;
        private string tipo;
        public int idSelecto { get; set; }
        public String nombre { get; set; }
        public Boolean isSelecciono { get; set; }
        #endregion

        public frmLista(clsConexion conexion, string tipo)
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange700, Primary.DeepOrange900, Primary.DeepOrange500, Accent.DeepOrange200, TextShade.WHITE);

            this.conexion = conexion;

            pEntidadProducto = new clsEntidadProducto();
            pEntidadUsuario = new clsEntidadUsuario();

            clProducto = new clsProducto();
            clUsuarios = new clsUsuario();
            clRol = new clsRol();
            clVistas = new clsVistas();

            this.tipo = tipo;

            InitializeComponent();
        }

        private void frmListaProducto_Load(object sender, EventArgs e)
        {
            this.llenarLV();
        }//fin del metodo

        #region Eventos
        private void btnSalir_Click(object sender, EventArgs e)
        {
            isSelecciono = false;
            this.Close();
        }

        private void lvLista_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            isSelecciono = true;

            for (int i = 0; i < lvGeneral.Items.Count; i++)
            {
                if (lvGeneral.Items[i].Selected)
                {
                    idSelecto = Convert.ToInt32(lvGeneral.Items[i].Text);

                    nombre = lvGeneral.Items[i].SubItems[1].Text;
                }
            }//fin del for
        }//fin del metodo
        #endregion

        #region Metodos Propios
        public void llenarLV()
        {
            if (this.tipo == "usuarios")
            {
                this.Text = "Lista Usuarios";
                strSentencia = clUsuarios.mConsultarUsuarioGeneral(conexion);
                while (strSentencia.Read())
                {
                    ListViewItem lista;
                    lista = lvGeneral.Items.Add(Convert.ToString(strSentencia.GetInt32(0)));
                    lista.SubItems.Add(strSentencia.GetString(1));
                }//fin del while
            }
            if (this.tipo == "producto")
            {
                this.Text = "Lista Productos";
                strSentencia = clProducto.mConsultarProductoGeneral(conexion);
                while (strSentencia.Read())
                {
                    ListViewItem lista;
                    lista = lvGeneral.Items.Add(Convert.ToString(strSentencia.GetInt32(0)));
                    lista.SubItems.Add(strSentencia.GetString(2));
                }//fin del while
            }
            if (this.tipo == "rol")
            {
                this.Text = "Lista Roles";
                strSentencia = clRol.mConsultarRolesGenerales(conexion);
                while (strSentencia.Read())
                {
                    ListViewItem lista;
                    lista = lvGeneral.Items.Add(Convert.ToString(strSentencia.GetInt32(0)));
                    lista.SubItems.Add(strSentencia.GetString(1));
                }//fin del while
            }
            if (this.tipo == "vistas")
            {
                this.Text = "Lista de Vista";
                strSentencia = clVistas.mConsultarVistasGenerales(conexion);
                while (strSentencia.Read())
                {
                    ListViewItem lista;
                    lista = lvGeneral.Items.Add(Convert.ToString(strSentencia.GetInt32(0)));
                    lista.SubItems.Add(strSentencia.GetString(1));
                }//fin del while
            }
        }
        #endregion
    }//fin de la clase
}
