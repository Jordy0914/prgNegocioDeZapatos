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

using System.Reflection;

namespace prgNegocioDeZapatos
{
    public partial class MainForm : MaterialForm
    {
        #region Atributos
        private readonly MaterialSkinManager materialSkinManager;
        private clsConexion conexion;

        private clsEntidadUsuario pEntidadUsuario;
        private clsUsuario clUsuario;
        private SqlDataReader dtrMenu;
        private SqlDataReader dtrSubMenu;

        private clsEntidadVista pEntidadVista;
        #endregion

        public MainForm(clsConexion cone, clsEntidadUsuario pEntidadUsuario)
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange700, Primary.DeepOrange900, Primary.DeepOrange500, Accent.DeepOrange200, TextShade.WHITE);

            this.conexion = cone;

            this.pEntidadUsuario = pEntidadUsuario;
            this.clUsuario = new clsUsuario();

            this.pEntidadVista = new clsEntidadVista();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.mAlmacenarVistasRolTemp();
            this.mAlmacenarVistasDirectasTemp();
            this.mCrearMenu();
        }

        #region Metodos Almacenar VistasTemp y Creacion del menu
        public void mAlmacenarVistasRolTemp()
        {
            dtrMenu = clUsuario.mConsultarVistasRol(this.conexion, this.pEntidadUsuario);
            // 0 = idMenu 'int'
            // 1 = idPadre 'int'
            // 2 = descripcion 'string'
            // 3 = posicion 'int'
            // 4 = habilitadoMenu 'int'
            // 5 = url  string
            // 6 = insertar
            // 7 = modificar
            // 8 = eliminar
            // 9 = consultar
            while (dtrMenu.Read())
            {
                pEntidadVista.IdVista = (dtrMenu.GetInt32(0));
                pEntidadVista.IdPadre = (dtrMenu.GetInt32(1));
                pEntidadVista.Descripcion = (dtrMenu.GetString(2));
                pEntidadVista.Posicion = (dtrMenu.GetInt32(3));
                pEntidadVista.HabilitadoMenu = (Convert.ToInt32((dtrMenu.GetBoolean(4))));
                pEntidadVista.Insertar = (Convert.ToInt32((dtrMenu.GetBoolean(6))));
                pEntidadVista.Modificar = (Convert.ToInt32((dtrMenu.GetBoolean(7))));
                pEntidadVista.Eliminar = (Convert.ToInt32((dtrMenu.GetBoolean(8))));
                pEntidadVista.Consultar = (Convert.ToInt32((dtrMenu.GetBoolean(9))));
                try
                {
                    pEntidadVista.Url = (dtrMenu.GetString(5));
                }
                catch (Exception e) { }

                clUsuario.mInsertarVistasTemp(this.conexion, pEntidadVista);     
            }
        }

        public void mAlmacenarVistasDirectasTemp()
        {
            dtrMenu = clUsuario.mConsultarVistasDirectas(this.conexion, this.pEntidadUsuario);
            // 0 = idMenu 'int'
            // 1 = idPadre 'int'
            // 2 = descripcion 'string'
            // 3 = posicion 'int'
            // 4 = habilitadoMenu 'int'
            // 5 = url  string
            // 6 = insertar
            // 7 = modificar
            // 8 = eliminar
            // 9 = consultar
            while (dtrMenu.Read())
            {
                pEntidadVista.IdVista = (dtrMenu.GetInt32(0));
                pEntidadVista.IdPadre = (dtrMenu.GetInt32(1));
                pEntidadVista.Descripcion = (dtrMenu.GetString(2));
                pEntidadVista.Posicion = (dtrMenu.GetInt32(3));
                pEntidadVista.HabilitadoMenu = (Convert.ToInt32((dtrMenu.GetBoolean(4))));
                pEntidadVista.Insertar = (Convert.ToInt32((dtrMenu.GetBoolean(6))));
                pEntidadVista.Modificar = (Convert.ToInt32((dtrMenu.GetBoolean(7))));
                pEntidadVista.Eliminar = (Convert.ToInt32((dtrMenu.GetBoolean(8))));
                pEntidadVista.Consultar = (Convert.ToInt32((dtrMenu.GetBoolean(9))));
                try
                {
                    pEntidadVista.Url = (dtrMenu.GetString(5));
                }
                catch (Exception e) { }

                clUsuario.mInsertarVistasTemp(this.conexion,pEntidadVista);
            }
        }

        public void mCrearMenu()
        {
            ToolStripMenuItem menu;
            dtrMenu = clUsuario.mCrearMenuPrincipal(this.conexion);
            // 0 = idMenu 'int'
            // 1 = idPadre 'int'
            // 2 = descripcion 'string'
            // 3 = posicion 'int'
            // 4 = habilitadoMenu 'int'
            // 5 = url  string
            while (dtrMenu.Read())
            {
                menu = new ToolStripMenuItem();
                menu.Text = dtrMenu.GetString(2);
                menuPrincipal.Items.Add(menu);
                dtrSubMenu = clUsuario.mCrearMenusSecundarios(this.conexion, dtrMenu.GetInt32(0));
                if (dtrSubMenu.HasRows)
                    this.mCrearSubMenusRecursivo(dtrSubMenu, menu);
                if (menu.Text == "Salir")
                    menu.Click += new EventHandler(SalirClicked);
            }
        } // fin crear menu

        public void mCrearSubMenusRecursivo(SqlDataReader dtr, ToolStripMenuItem menu)
        {
            ToolStripMenuItem subMenu;

            while (dtr.Read())
            {
                subMenu = new ToolStripMenuItem();
                subMenu.Text = dtr.GetString(2);
                subMenu.Tag = dtr.GetString(5);
                menu.DropDown.Items.Add(subMenu);
                dtrSubMenu = clUsuario.mCrearMenusSecundarios(this.conexion, dtr.GetInt32(0));
                if (dtrSubMenu.HasRows)
                    mCrearSubMenusRecursivo(dtrSubMenu, subMenu);
                else
                    subMenu.Click += new EventHandler(MenuItemClicked);      
            }
        }
        #endregion

        #region Metodos Propios
        private void MenuItemClicked(object sender, EventArgs e)
        {
            Assembly Ensamblado = Assembly.GetEntryAssembly();
    
            if (sender.GetType() == typeof(ToolStripMenuItem))
            {
                string NombreFormulario = ((ToolStripItem)sender).Tag.ToString();
                Type tipo = Ensamblado.GetType(Ensamblado.GetName().Name + "." + NombreFormulario);
                Object[] parametros = { this.conexion, this.pEntidadUsuario, NombreFormulario }; 

                if (tipo == null)
                {
                    MessageBox.Show("No se encontró el formulario", "Error de ubicación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (!this.FormularioEstaAbierto(NombreFormulario))
                    {
                        Form f = (Form)Activator.CreateInstance(tipo,parametros);
                        f.MdiParent = this;
                        f.Show();
                    }
                }
            }
        }

        private Boolean FormularioEstaAbierto(String NombreDelFrm)
        {
            if (this.MdiChildren.Length > 0)
            {
                for (int i = 0; i < this.MdiChildren.Length; i++)
                {
                    if (this.MdiChildren[i].Name == NombreDelFrm.Substring(NombreDelFrm.IndexOf("frm"), NombreDelFrm.Length - NombreDelFrm.IndexOf("frm")))
                    {
                        MessageBox.Show("El formulario solicitado ya se encuentra abierto");
                        return true;
                    }
                }
                return false;
            }
            else
                return false;
        }

        private void SalirClicked(object sender, EventArgs e)
        {
            this.clUsuario.mEliminarVistasTemp(this.conexion);
            Application.Restart(); 
        }
        #endregion
    }
}
