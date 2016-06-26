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

        private clsEntidadMenu pEntidadMenu;

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

            this.pEntidadMenu = new clsEntidadMenu();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.mAlmacenarMenuPrincipalTemp();
        }

        #region Metodos Almacenar MenuTemp

        public void mAlmacenarMenuPrincipalTemp()
        {
            dtrUsuarioMenu = usuario.mConsultarMenuPrincipal(this.conexion, this.pEntidadUsuario);

            // 0 = idMenu 'int'
            // 1 = descripcion 'string'
            // 2 = posicion 'int'
            // 3 = habilitadoMenu 'int'

            while(dtrUsuarioMenu.Read())
            {
                pEntidadMenu.setIdMenu(dtrUsuarioMenu.GetInt32(0));
                pEntidadMenu.setDescripcion(dtrUsuarioMenu.GetString(1));
                pEntidadMenu.setPosicion(dtrUsuarioMenu.GetInt32(2));
                pEntidadMenu.setHabilitadoMenu(Convert.ToInt32((dtrUsuarioMenu.GetBoolean(3))));
                usuario.mInsertarMenuTemporal(this.conexion, pEntidadMenu);

                dtrUsuarioSubMenu = usuario.mConsultarSubmenus(this.conexion,this.pEntidadUsuario,dtrUsuarioMenu.GetInt32(0));
                this.mAlmacenarMenusSecundariosTemp(dtrUsuarioSubMenu);     
            }
        }

        public void mAlmacenarMenusSecundariosTemp(SqlDataReader dtr)
        {
            while (dtr.Read())
            {
                pEntidadMenu.setIdMenu(dtr.GetInt32(0));
                pEntidadMenu.setDescripcion(dtr.GetString(1));
                pEntidadMenu.setPosicion(dtr.GetInt32(2));
                pEntidadMenu.setHabilitadoMenu(Convert.ToInt32((dtr.GetBoolean(3))));
                usuario.mInsertarMenuTemporal(this.conexion, pEntidadMenu);

                dtrUsuarioSubMenu = usuario.mConsultarSubmenus(this.conexion, this.pEntidadUsuario, dtr.GetInt32(0));
                mAlmacenarMenusSecundariosTemp(dtrUsuarioSubMenu);
            }
        }

        #endregion

        #region Metodos Propios

        public void mCrearMenu()
        {
            dtrUsuarioMenu = usuario.mConsultarMenuPrincipal(this.conexion, this.pEntidadUsuario);
            ToolStripMenuItem menu;
            

            while (dtrUsuarioMenu.Read())
            {
                menu = new ToolStripMenuItem();
                menu.Text = dtrUsuarioMenu.GetString(1);
                dtrUsuarioSubMenu = usuario.mConsultarSubmenus(this.conexion,this.pEntidadUsuario, dtrUsuarioMenu.GetInt32(0));
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
                dtrUsuarioSubMenu = usuario.mConsultarSubmenus(this.conexion,this.pEntidadUsuario, dtr.GetInt32(0));
                menu.DropDown.Items.Add(subMenu);
                mCrearSubMenusRecursivo(dtrUsuarioSubMenu, subMenu);
            }
        }
        
        #endregion

    }
}
