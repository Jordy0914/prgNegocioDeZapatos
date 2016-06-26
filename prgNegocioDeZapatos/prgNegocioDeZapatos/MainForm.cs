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
        private SqlDataReader dtrUsuarioMenu;
        private SqlDataReader dtrUsuarioSubMenu;

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
            dtrUsuarioMenu = usuario.mConsultarMenuPrincipal(this.conexion, this.pEntidadUsuario);
            ToolStripMenuItem menu;
            

            while (dtrUsuarioMenu.Read())
            {
                menu = new ToolStripMenuItem();
                menu.Text = dtrUsuarioMenu.GetString(1);
                dtrUsuarioSubMenu = usuario.mConsultarSubmenus(this.conexion, dtrUsuarioMenu.GetInt32(0));
                this.mCrearSubMenusRecursivo(dtrUsuarioSubMenu,menu);
                menuPrincipal.Items.Add(menu);
            }         
        } // fin crear menu

        public void mCrearSubMenusRecursivo(SqlDataReader dtr,  ToolStripMenuItem menu)
        {
           ToolStripMenuItem subMenu;

            while (dtr.Read())
            {
                subMenu = new ToolStripMenuItem();
                subMenu.Text = dtr.GetString(1);
                dtrUsuarioSubMenu = usuario.mConsultarSubmenus(this.conexion, dtr.GetInt32(0));
                menu.DropDown.Items.Add(subMenu);
                mCrearSubMenusRecursivo(dtrUsuarioSubMenu, subMenu);
            }

        }



        //subMenu.Click += new EventHandler(toolStripButton1_Click);
 
        //private void toolStripButton1_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Jordy encende el a/c")
        //}


        #endregion

    }
}
