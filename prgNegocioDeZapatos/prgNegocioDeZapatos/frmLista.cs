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
        private readonly MaterialSkinManager materialSkinManager;
        SqlDataReader strSentencia;
        clsConexion conexion;
        clsEntidadProducto pEntidadProducto;
        clsEntidadUsuario pEntidadUsuario;
        clsProducto clProducto;
        clsUsuario clUsuarios;
        private string tipo;
        public int idSelecto { get; set; }

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

            this.tipo = tipo;

            InitializeComponent();
        }

        private void frmListaProducto_Load(object sender, EventArgs e)
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
                strSentencia = clProducto.mConsultarProductoGeneral(conexion);
                while (strSentencia.Read())
                {
                    ListViewItem lista;
                    lista = lvGeneral.Items.Add(Convert.ToString(strSentencia.GetInt32(0)));
                    lista.SubItems.Add(strSentencia.GetString(1));
                }//fin del while
            }
        }//fin del metodo

        #region Eventos
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvLista_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lvGeneral.Items.Count; i++)
            {
                if (lvGeneral.Items[i].Selected)
                {
                    idSelecto = Convert.ToInt32(lvGeneral.Items[i].Text);
                }
            }//fin del for
        }//fin del metodo
        #endregion       
    }//fin de la clase
}
