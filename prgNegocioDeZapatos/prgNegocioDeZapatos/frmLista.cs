﻿using System;
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
        clsEntidadProducto productos;
        clsProducto clProducto;
        clsUsuario clUsuarios;
        clsEntidadUsuario usuarios;
        public int idProducto;
        public int idUsuario;

        public frmLista(clsConexion conexion)
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange700, Primary.DeepOrange900, Primary.DeepOrange500, Accent.DeepOrange200, TextShade.WHITE);
            productos = new clsEntidadProducto();
            clProducto = new clsProducto();
            usuarios = new clsEntidadUsuario();
            clUsuarios = new clsUsuario();
            this.conexion = conexion;

            InitializeComponent();
        }

        private void frmListaProducto_Load(object sender, EventArgs e)
        {
            if (frmUsuario.señal == 1)
            {
                strSentencia = clUsuarios.mConsultarUsuarioGeneral(conexion);
                while (strSentencia.Read())

                {
                    ListViewItem lista;
                    lista = lvListaProductos.Items.Add(Convert.ToString(strSentencia.GetInt32(0)));
                    lista.SubItems.Add(strSentencia.GetString(2));
                }//fin del while
            }
            else {
                strSentencia = clProducto.mConsultarProductoGeneral(conexion);
                while (strSentencia.Read())

                {
                    ListViewItem lista;
                    lista = lvListaProductos.Items.Add(Convert.ToString(strSentencia.GetInt32(0)));
                    lista.SubItems.Add(strSentencia.GetString(2));

                }//fin del while

            }

        }//fin del metodo


        public int  getidProducto()
        {
            return (idProducto);
        }//fin del metodo getid

        public int getidUsuario()
        {
            return (idUsuario);
        }//fin del metodo getid


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lvLista_DoubleClick(object sender, EventArgs e)
        {
           this.Close();
        }

        private void lvLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            for (int i =0; i < lvListaProductos.Items.Count; i++)
            {
                if (lvListaProductos.Items[i].Selected)
                {
                    idProducto = Convert.ToInt32(lvListaProductos.Items[i].Text);
                }
            }//fin del for
       }//fin del metodo

    }//fin de la clase
}