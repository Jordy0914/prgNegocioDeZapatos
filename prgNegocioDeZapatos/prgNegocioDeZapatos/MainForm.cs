using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using AccesoDatos;
using Entidades;
using LogicaNegocios;

using System.Data.SqlClient;

namespace prgNegocioDeZapatos
{
    public partial class MainForm : MaterialForm
    {
        #region Atributos

        private readonly MaterialSkinManager materialSkinManager;
        private clsConexion conexion;

        private clsEntidadUsuario pEntidadUsuario;
        private clsUsuario usuario;
        private SqlDataReader dtrUsuario;

        #endregion

        public MainForm(clsConexion conexion, clsEntidadUsuario pEntidadUsuario)
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange700, Primary.DeepOrange900, Primary.DeepOrange500, Accent.DeepOrange200, TextShade.WHITE);

            this.conexion = conexion;
            this.pEntidadUsuario = pEntidadUsuario;

            this.usuario = new clsUsuario();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.mCrearMenu();
        }



        #region Metodos
        
        public void mCrearMenu()
        {
            dtrUsuario = usuario.mConsultarMenuPrincipal(this.conexion, this.pEntidadUsuario);
            
                ToolStripMenuItem menu = new ToolStripMenuItem();
                ToolStripMenuItem subMenu = new ToolStripMenuItem();

            while(dtrUsuario.Read())
            {
                MessageBox.Show(dtrUsuario.GetString(0));
            }

            //menu.Text = "hola0";
            //    subMenu.Text = "hola1";

               

            //    menu.DropDown.Items.Add(subMenu);

            //    this.menuPrincipal.Items.Add(menu);

            

        }
        
        //private void toolStripButton1_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Jordy encende el a/c");
        //    subMenu.Click += new EventHandler(toolStripButton1_Click);
        //}
        

    #endregion

}
}
