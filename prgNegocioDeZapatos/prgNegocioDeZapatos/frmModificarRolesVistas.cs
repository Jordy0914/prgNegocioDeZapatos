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
using Entidades;
using AccesoDatos;
using LogicaNegocios;

namespace prgNegocioDeZapatos
{
    public partial class frmModificarRolesVistas : MaterialForm
    {
        #region Atributos
        private readonly MaterialSkinManager materialSkinManager;

        private clsConexion conexion;

        private clsRolVista clRolVista;

        private SqlDataReader dtr;

        public int IdRol { get; set; }
        public String RolName{ get; set; }
        public int IdVista { get; set; }
        public String VistaName { get; set; }
        public Boolean boolInsertar { get; set; }
        public Boolean boolModificar { get; set; }
        public Boolean boolEliminar { get; set; }
        public Boolean boolConsultar { get; set; }
        public Boolean isSeleciono { get; set; }
        #endregion

        public frmModificarRolesVistas(clsConexion cone)
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange700, Primary.DeepOrange900, Primary.DeepOrange500, Accent.DeepOrange200, TextShade.WHITE);

            this.conexion = cone;

            this.clRolVista = new clsRolVista();

            InitializeComponent();
        }

        private void frmModificarRolesVistas_Load(object sender, EventArgs e)
        {
            this.llenarLV();
        }
        
        #region Eventos
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.isSeleciono = false;
        }

        private void lvLista_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            isSeleciono = true; 

            for (int i = 0; i < lvGeneral.Items.Count; i++)
            {
                if (lvGeneral.Items[i].Selected)
                {
                    IdRol = Convert.ToInt32(lvGeneral.Items[i].Text);
                    RolName = lvGeneral.Items[i].SubItems[1].Text.ToString();
                    IdVista = Convert.ToInt32(lvGeneral.Items[i].SubItems[2].Text);
                    VistaName = lvGeneral.Items[i].SubItems[3].Text;
                    boolInsertar = Convert.ToBoolean(lvGeneral.Items[i].SubItems[4].Text);
                    boolModificar = Convert.ToBoolean(lvGeneral.Items[i].SubItems[5].Text);
                    boolEliminar = Convert.ToBoolean(lvGeneral.Items[i].SubItems[6].Text);
                    boolConsultar = Convert.ToBoolean(lvGeneral.Items[i].SubItems[7].Text);
                }
            }//fin del for
        }//fin del metodo

        #endregion

        #region Metodos Propios
        public void llenarLV()
        {
            dtr = clRolVista.mConsultarRolesVistasGeneral(conexion);
            while (dtr.Read())
            {
                ListViewItem lista;
                lista = lvGeneral.Items.Add(Convert.ToString(dtr.GetInt32(0)));
                lista.SubItems.Add(dtr.GetString(1));
                lista.SubItems.Add(Convert.ToString(dtr.GetInt32(2)));
                lista.SubItems.Add(dtr.GetString(3));
                lista.SubItems.Add(Convert.ToString(dtr.GetBoolean(4)));
                lista.SubItems.Add(Convert.ToString(dtr.GetBoolean(5)));
                lista.SubItems.Add(Convert.ToString(dtr.GetBoolean(6)));
                lista.SubItems.Add(Convert.ToString(dtr.GetBoolean(7)));
            }//fin del while
        }
        #endregion
    }
}
