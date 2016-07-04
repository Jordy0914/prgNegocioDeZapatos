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

using Entidades;
using LogicaNegocios;
using AccesoDatos;

namespace prgNegocioDeZapatos
{
    
    public partial class frmAgregarProductos : MaterialForm 
    {
        private readonly MaterialSkinManager materialSkinManager;
        clsConexion conexion;
        clsEntidadProducto inventario;
        clsProducto clInventario;
        private Boolean bolAgregar,bolModificar;


        public frmAgregarProductos()//clsConexion cone)
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange700, Primary.DeepOrange900, Primary.DeepOrange500, Accent.DeepOrange200, TextShade.WHITE);
            this.inventario = new clsEntidadProducto();
            this.clInventario = new clsProducto();
            //this.conexion = cone;
            InitializeComponent();
        }


        private void frmAgregarZapatos_Load(object sender, EventArgs e, GroupBox gro)
        {
            btnAgregar.Visible = true;
            btnAgregar.Enabled = true;
            btnModificar.Visible = true;
            btnModificar.Enabled = true;
            groupBox3.AutoSize=true;

            
 
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {


            inventario.setIdProducto(Convert.ToInt32(txtCodigo.Text));
            inventario.setModelo(txtModelo.Text);
            inventario.setNombre(txtNombre.Text);
            inventario.setTalla(Double.Parse(txtTalla.Text));
            inventario.setColor(cboColor.Text);
            inventario.setPrecio(Convert.ToInt32(txtPrecio.Text));
            inventario.setCosto(Convert.ToInt32(txtCosto.Text));
            inventario.setMarca(txtMarca.Text);
            inventario.setCategoria(txtCategoria.Text);
            inventario.setCantidad(Convert.ToInt32(txtCantidad.Text));


            bolAgregar= clInventario.mInsertar(conexion, inventario);

            if (bolAgregar == true)
            {
                MessageBox.Show("El Inventario ha sido agregado correctamente", "Registro correcto", MessageBoxButtons.OK);


            }//fin del if
            this.limpiar();

        }//fin del metodo del boton de agregar

        private void btnModificar_Click(object sender, EventArgs e)
        {
            inventario.setModelo(txtModelo.Text);
            inventario.setNombre(txtNombre.Text);
            inventario.setTalla(Double.Parse(txtTalla.Text));
            inventario.setColor(cboColor.Text);
            inventario.setPrecio(Convert.ToInt32(txtPrecio.Text));
            inventario.setCosto(Convert.ToInt32(txtCosto.Text));
            inventario.setMarca(txtMarca.Text);
            inventario.setCategoria(txtCategoria.Text);
            inventario.setCantidad(Convert.ToInt32(txtCantidad.Text));

            bolModificar = clInventario.mModificarProducto(conexion, inventario);

            if (bolModificar == true)
            {
                MessageBox.Show("El Inventario ha sido modificado correctamente", "Registro correcto", MessageBoxButtons.OK);


            }//fin del if
            this.limpiar();
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void txtConsultar_Click(object sender, EventArgs e)
        {

        }

        private void frmAgregarProductos_Load(object sender, EventArgs e)
        {

        }

        public void limpiar()
        {

            this.txtNombre.Text = "";
            this.txtCodigo.Text = "";
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


