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
    public partial class frmListaProducto : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        SqlDataReader strSentencia;
        clsConexion conexion;
        clsEntidadProducto productos;
        clsProducto clProducto;
        public int idProducto;

        public frmListaProducto(clsConexion conexion)
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange700, Primary.DeepOrange900, Primary.DeepOrange500, Accent.DeepOrange200, TextShade.WHITE);

            productos = new clsEntidadProducto();
            clProducto = new clsProducto();
            this.conexion = conexion;

            InitializeComponent();
        }

        private void frmListaProducto_Load(object sender, EventArgs e)
        {

            strSentencia = clProducto.mConsultarProductoGeneral(conexion);
          while (strSentencia.Read())

            {
                ListViewItem lista;
                lista = lvLista.Items.Add(Convert.ToString(strSentencia.GetInt32(0)));
                lista.SubItems.Add(strSentencia.GetString(2));

            }

        }


        public int  getid()
        {
            return (idProducto);
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lvLista_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }

        private void lvLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            for (int i = 0; i < lvLista.Items.Count; i++)
            {
                if (lvLista.Items[i].Selected)
                {
                    idProducto = Convert.ToInt32(lvLista.Items[i].Text);
                }
            }

       }
    }//fin de la clase
}
