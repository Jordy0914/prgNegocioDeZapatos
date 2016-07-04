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
using LogicaNegocios;
using AccesoDatos;
using System.Globalization;

namespace prgNegocioDeZapatos
{
    
    public partial class frmAgregarProductos : MaterialForm 
    {
        private readonly MaterialSkinManager materialSkinManager;
        clsConexion conexion;
        clsEntidadProducto productos;
        clsEntidadUsuario usuarios;
        clsProducto clProductos;
        SqlDataReader dtrProducto;


        private Boolean bolAgregar,bolModificar, bolEliminar;


        public frmAgregarProductos()//clsConexion cone)
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange700, Primary.DeepOrange900, Primary.DeepOrange500, Accent.DeepOrange200, TextShade.WHITE);
            this.productos = new clsEntidadProducto();
            this.clProductos = new clsProducto();
            this.conexion = new clsConexion();
            this.usuarios = new clsEntidadUsuario();
            //this.conexion = cone;
            InitializeComponent();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            productos.setModelo(txtModelo.Text);
            productos.setNombre(txtNombre.Text);
            productos.setTalla(Double.Parse(txtTalla.Text));
            productos.setColor(cboColor.Text);
            productos.setPrecio(Convert.ToInt32(txtPrecio.Text));
            productos.setCosto(Convert.ToInt32(txtCosto.Text));
            productos.setMarca(txtMarca.Text);
            productos.setCategoria(txtCategoria.Text);
            productos.setCantidad(Convert.ToInt32(txtCantidad.Text));

            bolAgregar= clProductos.mInsertar(conexion, productos, usuarios);

            if (bolAgregar == true)
            {
                MessageBox.Show("El producto ha sido agregado correctamente", "Registro correcto", MessageBoxButtons.OK);


            }//fin del if
            this.limpiar();

        }//fin del metodo del boton de agregar

        private void btnModificar_Click(object sender, EventArgs e)
        {
            productos.setModelo(txtModelo.Text);
            productos.setNombre(txtNombre.Text);
            productos.setTalla(Double.Parse(txtTalla.Text));
            productos.setColor(cboColor.Text);
            productos.setPrecio(Convert.ToInt32(txtPrecio.Text));
            productos.setCosto(Convert.ToInt32(txtCosto.Text));
            productos.setMarca(txtMarca.Text);
            productos.setCategoria(txtCategoria.Text);
            productos.setCantidad(Convert.ToInt32(txtCantidad.Text));

            bolModificar = clProductos.mModificarProducto(conexion, productos);

            if (bolModificar == true)
            {
                MessageBox.Show("El producto ha sido modificado correctamente", "Registro correcto", MessageBoxButtons.OK);


            }//fin del if
            this.limpiar();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmListaProducto consultarProducto = new frmListaProducto(conexion);
            consultarProducto.ShowDialog();

            if (consultarProducto.getidProducto() != 0 || consultarProducto.getidProducto() == 0)
            {
                productos.setIdProducto(consultarProducto.getidProducto());
                txtCodigo.Text = Convert.ToString(consultarProducto.getidProducto());
                mConsultaProducto();
            }//fin del if que verifica que no sea igual a 0
        }

        public void mConsultaProducto()
        {

            productos.setIdProducto(Convert.ToInt32(txtCodigo.Text.Trim()));

            dtrProducto = clProductos.mConsultarProducto(conexion, productos);

            if (dtrProducto != null)
            {

                if (dtrProducto.Read())
                {
                    this.txtModelo.Text = dtrProducto.GetString(1);
                    this.txtNombre.Text = dtrProducto.GetString(2);
                    this.txtTalla.Text = Convert.ToString(dtrProducto.GetDecimal(3));
                    this.cboColor.Text =  dtrProducto.GetString(4);
                    this.txtCosto.Text =   Convert.ToString(dtrProducto.GetInt32(5));
                    this.txtPrecio.Text =   Convert.ToString(dtrProducto.GetInt32(6));
                    this.txtMarca.Text = dtrProducto.GetString(7);
                    this.txtCategoria.Text = dtrProducto.GetString(8);
                    this.txtCantidad.Text = Convert.ToString(dtrProducto.GetInt32(9));
                
                }//FIN READ

            }//fin del if que verifica que no este null

        }//fin del metodo que consulta el producto segun su id

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
          bolEliminar=  clProductos.mEliminarProducto(conexion, productos);
            if (bolEliminar == true)
            {
                MessageBox.Show("El producto ha sido eliminado correctamente", "Registro correcto", MessageBoxButtons.OK);


            }//fin del if
            this.limpiar();
        }


        public void limpiar()
        {

            this.txtNombre.Text = "";
            this.txtCodigo.Text = "";
            this.txtModelo.Text = "";
            this.txtTalla.Text = "";
            this.cboColor.Text = "";
            this.txtPrecio.Text="";
            this.txtCosto.Text = "";
            this.txtMarca.Text = "";
            this.txtCategoria.Text = "";
            this.txtCantidad.Text = "";

        }//fin del metodo limpiar

    }//fin de la clase
}


