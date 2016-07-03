using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using AccesoDatos;
using LogicaNegocios;
using System.Data.SqlClient;

namespace prgNegocioDeZapatos
{
    public partial class frmFactura : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        SqlDataReader dtrFactura,dtrFacturaE,dtrProducto;
        clsEntidadFactura factura;
        clsFactura clFactura;
        clsEntidadProducto producto;
        clsProducto clProducto;
        clsEntidadDetalleFactura facturaDetalle;
        clsConexion conexion;
        private Boolean bolAgregarE, bolAgregarD, bolModificar, bolEliminar;
        public int codigoProductos;
        public int precios;
        private int total = 0;
        private int numeroFactura = 0;

        public frmFactura() {


            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange700, Primary.DeepOrange900, Primary.DeepOrange500, Accent.DeepOrange200, TextShade.WHITE);

            this.conexion = new clsConexion();
            factura = new clsEntidadFactura();
            clFactura = new clsFactura();
            producto = new clsEntidadProducto();
            clProducto = new clsProducto();
            facturaDetalle = new clsEntidadDetalleFactura();
            InitializeComponent();
        }


/////////////////////////////////// Metodo Principal de la clase ///////////////////////////////////////////////


        private void frmFactura_Load(object sender, EventArgs e)
        {
            this.mConsultaIdFactura();
        }

////////////////////////////// Metodos de Accion de los botones ////////////////////////////////////////////

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            factura.setIdFactura(Convert.ToInt32(txtCodProducto.Text));
             bolEliminar=clFactura.mEliminarFactura(conexion, factura);

        }//fin de la accion del boton eliminar

            
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            factura.setIdFactura(Convert.ToInt32(txtNumeroF.Text));
            factura.setTotal(Convert.ToDouble(txtTotal.Text));
            factura.setIdUsuario(0);

           facturaDetalle.setIdFactura(Convert.ToInt32(txtNumeroF.Text));
            facturaDetalle.setIdProducto(Convert.ToInt32(Convert.ToInt32(this.lvProductos.Items[0].Text)));
            facturaDetalle.setCantidad(Convert.ToInt32(txtCantidadProducto.Text));
            facturaDetalle.setSubTotal(Convert.ToDouble(txtSubTotal.Text));
          

            bolAgregarE = clFactura.mInsertarFacturaEncabezado(conexion, factura);
            bolAgregarD = clFactura.mInsertarFacturaDetalle(conexion, facturaDetalle);

            if (bolAgregarE == true && bolAgregarD == true)
            {
                MessageBox.Show("Ha sido agregado correctamente", "Registro correcto", MessageBoxButtons.OK);
                //btnAgregar.Enabled = false;
                this.Limpiar();

            }//fin del if de agregar

            else {

                MessageBox.Show("Problemas al agregar", "Error", MessageBoxButtons.OK);

                this.Limpiar();

               }//fin del else

        }//fin de la accion del boton realizar venta


        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
            frmListaProducto consultarProducto = new frmListaProducto(conexion);
            consultarProducto.ShowDialog();

            if (consultarProducto.getid() != 0)
            {
                producto.setIdProducto(consultarProducto.getid());
                txtCodProducto.Text = Convert.ToString(consultarProducto.getid());
                mConsultaProducto();
            }//fin del if que verifica que no sea igual a 0

      }//fin de la accion del boton buscar


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }//fin del la accion del boton salir


////////////////////////////////// Metodos para obtener datos para la ventana frmListaProducto/////////////////////////////

        public void mConsultaProducto()
        {

            producto.setIdProducto(Convert.ToInt32(txtCodProducto.Text.Trim()));
           
            dtrProducto = clProducto.mConsultarProducto(conexion,producto);

            if (dtrProducto != null)
            {

                if (dtrProducto.Read())
                {
                    this.txtProducto.Text = dtrProducto.GetString(2);
                    this.txtPrecio.Text = Convert.ToString(dtrProducto.GetInt32(5));                  
                }//FIN READ

            }//fin del if que verifica que no este null

        }//fin del metodo que consulta el producto segun su id


/////////////////////////////////////// Metodo para ingresar datos a la lista de producto /////////////////////////////////////////


        private void lvProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lvProductos.Items.Count; i++)
            {
                if (lvProductos.Items[i].Selected)
                {
                    codigoProductos = Convert.ToInt32(lvProductos.Items[i].Text);
                }//fin del if 

            }//fin del for
        }//fin del metodo para agregar los items a la lista


        public int getCodProductos()
        {
            return (codigoProductos);
        }//fin del metodo


        public void llenarLista()
        {
            if (getCodProductos() != 0)
            {
                producto.setIdProducto(Convert.ToInt32(txtCodProducto.Text));
            }//fin del if que verifica que contenga datos

            ListViewItem lista;
            lista = lvProductos.Items.Add(txtCodProducto.Text);
        }//fin del metodo para llenar la lista con datos


        private String mContarProductos()
        {
            double contar = 0;

            foreach (ListViewItem item in lvProductos.Items)
            {
                contar++;
            }//fin del foreach

            return contar.ToString();

        }//fin del metodo que cuanta la cantidad de datos de la lista


///////////////////////////// Metodo para calcular el total de la venta si tiene factura////////////////////////////////

        private void cboDescuento_SelectedIndexChanged(object sender, EventArgs e)
        {
            Double descuento = total +( Convert.ToDouble(cboDescuento.SelectedItem) / 100 * total) ;
            this.txtTotal.Text = "" + descuento;

        }//fin de la accion del combobox de descuento

/////////////////////// Metodo para agregar los codigos del producto a la lista de produtos de la venta //////////////////////////

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            this.llenarLista();//llena la lista con el codigo del producto
            this.txtCantidad.Text = (mContarProductos());
            this.txtSubTotal.Text = ""+ this.calcularPrecio();

           // this.Limpiar();

        }//fin de la accion del boton agregar



/////////////////////////////// Metodo para calcular el subtotal ///////////////////////////////////////////////// 
    
        public int calcularPrecio()
        {
          return total = total + (Convert.ToInt32(this.txtPrecio.Text) * Convert.ToInt32(this.txtCantidadProducto.Text));

        }//fin del metodo para calcular el subtotal

       

////////////////// Metodo para obtener el ultimo numero de la factura ////////////////////////////////////////////////////

        public void mConsultaIdFactura()
        {
         
            dtrFacturaE = clFactura.mConsultarIdFactura(conexion);

            if (dtrFacturaE != null)
            {

                if (dtrFacturaE.Read())
                {//si exise

                  numeroFactura=((dtrFacturaE.GetInt32(0)));
                  numeroFactura++;
                  this.txtNumeroF.Text = Convert.ToString(numeroFactura);

                }//fin del if del read

            }//fin del if que verifica que no este null

        }//fin del metodo que consulta el producto segun su id



///////////////////////////////////////// Metodo para limpiar los campos de la pantalla ///////////////////////////////////////////////////

        public void Limpiar()
        {
            this.txtCodProducto.Text = "";
            this.txtProducto.Text = "";
            this.txtPrecio.Text = "";
            this.txtCantidad.Text = "";
            this.txtSubTotal.Text = "";
            this.txtTotal.Text = "";
            this.txtCantidadProducto.Text = "";
            this.cboDescuento.Text = "";
            this.lvProductos.Clear();
        }//fin del metodo limpiar

    }//fin de la clase
}