﻿using System;
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
            this.mAlmacenarMenuPrincipalRolTemp();
            this.mAlmacenarMenuPrincipalDirectoTemp();
            this.mCrearMenu();
            this.usuario.mEliminarMenuTemp(this.conexion);
        }

        #region Metodos Almacenar MenuTemp

        public void mAlmacenarMenuPrincipalRolTemp()
        {
            dtrUsuarioMenu = usuario.mConsultarMenuPrincipalRol(this.conexion, this.pEntidadUsuario);

            // 0 = idMenu 'int'
            // 1 = idMenuPadre 'int'
            // 2 = descripcion 'string'
            // 3 = posicion 'int'
            // 4 = habilitadoMenu 'int'
            // 5 = url  string

            while(dtrUsuarioMenu.Read())
            {
                pEntidadMenu.setIdMenu(dtrUsuarioMenu.GetInt32(0));
                pEntidadMenu.setIdMenuPadre(dtrUsuarioMenu.GetInt32(1));
                pEntidadMenu.setDescripcion(dtrUsuarioMenu.GetString(2));
                pEntidadMenu.setPosicion(dtrUsuarioMenu.GetInt32(3));
                pEntidadMenu.setHabilitadoMenu(Convert.ToInt32((dtrUsuarioMenu.GetBoolean(4))));

                try
                {
                    pEntidadMenu.setUrl(dtrUsuarioMenu.GetString(5));
                }
                catch (Exception e) { }
                
                usuario.mInsertarMenuTemporal(this.conexion, pEntidadMenu);

                dtrUsuarioSubMenu = usuario.mConsultarSubmenusRol(this.conexion,this.pEntidadUsuario,dtrUsuarioMenu.GetInt32(0));
                this.mAlmacenarMenusSecundariosRolTemp(dtrUsuarioSubMenu);     
            }
        }

        public void mAlmacenarMenusSecundariosRolTemp(SqlDataReader dtr)
        {
            while (dtr.Read())
            {
                pEntidadMenu.setIdMenu(dtr.GetInt32(0));
                pEntidadMenu.setIdMenuPadre(dtr.GetInt32(1));
                pEntidadMenu.setDescripcion(dtr.GetString(2));
                pEntidadMenu.setPosicion(dtr.GetInt32(3));
                pEntidadMenu.setHabilitadoMenu(Convert.ToInt32((dtr.GetBoolean(4))));


                try
                {
                    pEntidadMenu.setUrl(dtr.GetString(5));
                }
                catch (Exception e) { }
               
                usuario.mInsertarMenuTemporal(this.conexion, pEntidadMenu);

                dtrUsuarioSubMenu = usuario.mConsultarSubmenusRol(this.conexion, this.pEntidadUsuario, dtr.GetInt32(0));
                mAlmacenarMenusSecundariosRolTemp(dtrUsuarioSubMenu);
            }
        }

        public void mAlmacenarMenuPrincipalDirectoTemp()
        {
            dtrUsuarioMenu = usuario.mConsultarMenuPrincipalDirecto(this.conexion, this.pEntidadUsuario);

            // 0 = idMenu 'int'
            // 1 = idMenuPadre 'int'
            // 2 = descripcion 'string'
            // 3 = posicion 'int'
            // 4 = habilitadoMenu 'int'
            // 5 = url  string

            while (dtrUsuarioMenu.Read())
            {
                pEntidadMenu.setIdMenu(dtrUsuarioMenu.GetInt32(0));
                pEntidadMenu.setIdMenuPadre(dtrUsuarioMenu.GetInt32(1));
                pEntidadMenu.setDescripcion(dtrUsuarioMenu.GetString(2));
                pEntidadMenu.setPosicion(dtrUsuarioMenu.GetInt32(3));
                pEntidadMenu.setHabilitadoMenu(Convert.ToInt32((dtrUsuarioMenu.GetBoolean(4))));

                try
                {
                    pEntidadMenu.setUrl(dtrUsuarioMenu.GetString(5));
                }
                catch (Exception e) { }

                usuario.mInsertarMenuTemporal(this.conexion, pEntidadMenu);

                this.mAlmacenarMenusSecundariosDirectoTemp();
            }
        }

        public void mAlmacenarMenusSecundariosDirectoTemp()
        {

            dtrUsuarioSubMenu = usuario.mConsultarSubmenusDirecto(this.conexion, this.pEntidadUsuario);

            while (dtrUsuarioSubMenu.Read())
            {
                pEntidadMenu.setIdMenu(dtrUsuarioSubMenu.GetInt32(0));
                pEntidadMenu.setIdMenuPadre(dtrUsuarioSubMenu.GetInt32(1));
                pEntidadMenu.setDescripcion(dtrUsuarioSubMenu.GetString(2));
                pEntidadMenu.setPosicion(dtrUsuarioSubMenu.GetInt32(3));
                pEntidadMenu.setHabilitadoMenu(Convert.ToInt32((dtrUsuarioSubMenu.GetBoolean(4))));

                try
                {
                    pEntidadMenu.setUrl(dtrUsuarioSubMenu.GetString(5));
                }
                catch (Exception e) { }

                usuario.mInsertarMenuTemporal(this.conexion, pEntidadMenu);
            }
        }

        #endregion




        #region Metodos Propios

        public void mCrearMenu()
        {
            dtrUsuarioMenu = usuario.mCrearMenuPrincipal(this.conexion);
            ToolStripMenuItem menu;

            // 0 = idMenu 'int'
            // 1 = idMenuPadre 'int'
            // 2 = descripcion 'string'
            // 3 = posicion 'int'
            // 4 = habilitadoMenu 'int'
            // 5 = url  string

            while (dtrUsuarioMenu.Read())
            {
                menu = new ToolStripMenuItem();
                menu.Text = dtrUsuarioMenu.GetString(2);
                dtrUsuarioSubMenu = usuario.mCrearMenusSecundarios(this.conexion,dtrUsuarioMenu.GetInt32(0));
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
                subMenu.Text = dtr.GetString(2);
                dtrUsuarioSubMenu = usuario.mCrearMenusSecundarios(this.conexion,dtr.GetInt32(0));
                menu.DropDown.Items.Add(subMenu);
                mCrearSubMenusRecursivo(dtrUsuarioSubMenu, subMenu);
            }
        }
        
        #endregion

    }
}
