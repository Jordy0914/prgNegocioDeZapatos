﻿using MaterialSkin;
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
    public partial class frmFactura : MaterialForm, IPermisos
    {
        private readonly MaterialSkinManager materialSkinManager;

        SqlDataReader dtrFactura,dtrFacturaE,dtrProducto;
        clsEntidadFacturaEncabezado factura;
        clsFactura clFactura;
        clsEntidadProducto producto;
        clsProducto clProducto;
        clsEntidadDetalleFactura facturaDetalle;
        clsConexion conexion;
        clsEntidadUsuario usuario;
        private Boolean bolAgregarEncabezado, bolAgregarDetalle;
        public int codigoProductos;

        public int precios;
        private int total = 0;
        private int numeroFactura = 0;
        private Double descuento;
        private Double totalDescuento;
        String fecha_actual;
        DateTime Hoy;

        public frmFactura(clsConexion cone, clsEntidadUsuario pEntidadUsuario) {

            //clsConexion cone, clsEntidadUsuario pEntidadUsuario,
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange700, Primary.DeepOrange900, Primary.DeepOrange500, Accent.DeepOrange200, TextShade.WHITE);

            this.conexion = cone;
            //this.conexion = new clsConexion();
            factura = new clsEntidadFacturaEncabezado();
            clFactura = new clsFactura();
            producto = new clsEntidadProducto();
            clProducto = new clsProducto();
            facturaDetalle = new clsEntidadDetalleFactura();
            usuario = pEntidadUsuario;

            Hoy = DateTime.Today;
            fecha_actual = Hoy.ToString("dd-MM-yyyy");

            InitializeComponent();
        }//fin del constructor


/////////////////////////////////// Metodo Principal de la clase ///////////////////////////////////////////////


        private void frmFactura_Load(object sender, EventArgs e)
        {
            this.mConsultaIdFactura();
        }


/////////////////////////////////////// Accion del boton Agregar //////////////////////////////////////////////////////////           
        private void btnInsertar_Click(object sender, EventArgs e)
        {

            if (txtCodProducto.Text==""||txtProducto.Text==""||txtPrecio.Text==""||txtCantidadProducto.Text==""|| cboDescuento.Text=="") {

                MessageBox.Show("Debe de llenar todos los campos");
            }

            else { 
            factura.setTotal(Convert.ToDouble(txtTotal.Text));
           // factura.setIdUsuario(usuario.getIdUsuario());
            //factura.setFechaCreacion(Convert.ToDateTime(fecha_actual));

            facturaDetalle.setIdFactura(Convert.ToInt32(txtNumeroF.Text));
            facturaDetalle.setIdProducto(Convert.ToInt32(this.lvProductos.Items[0].Text));
            facturaDetalle.setCantidad(Convert.ToInt32(txtCantidad.Text));
            facturaDetalle.setDescuento(descuento);
            facturaDetalle.setSubTotal(Convert.ToDouble(txtSubTotal.Text));
            
          

            bolAgregarEncabezado = clFactura.mInsertarFacturaEncabezado(conexion, factura);
            bolAgregarDetalle = clFactura.mInsertarFacturaDetalle(conexion, facturaDetalle);

            if (bolAgregarEncabezado == true && bolAgregarDetalle == true)
            {
                MessageBox.Show("Ha sido agregado correctamente", "Registro correcto", MessageBoxButtons.OK);
                this.Limpiar();
               

            }//fin del if de agregar

            else {

                MessageBox.Show("Problemas al agregar", "Error", MessageBoxButtons.OK);

                this.Limpiar();

               }//fin del else
            }//fin del else

        }//fin de la accion del boton realizar venta

/////////////////////////////////////// Accion del boton Buscar //////////////////////////////////////////////////////////

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
            frmLista consultarProducto = new frmLista(conexion);
            consultarProducto.ShowDialog();

            if (consultarProducto.getidProducto() != 0 || consultarProducto.getidProducto() == 0)
            {
                producto.setIdProducto(consultarProducto.getidProducto());
                txtCodProducto.Text = Convert.ToString(consultarProducto.getidProducto());
                mConsultaProducto();
            }//fin del if que verifica que no sea igual a 0

      }//fin de la accion del boton buscar


/////////////////////////////////////// Accion del boton salir //////////////////////////////////////////////////////////

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }//fin del la accion del boton salir


////////////////////////////////// Metodos para obtener datos para la ventana frmListaProducto /////////////////////////////

        public void mConsultaProducto()
        {

            producto.setIdProducto(Convert.ToInt32(txtCodProducto.Text.Trim()));
           
            dtrProducto = clProducto.mConsultarProducto(conexion,producto);

            if (dtrProducto != null)
            {

                if (dtrProducto.Read())
                {
                    this.txtProducto.Text = dtrProducto.GetString(2);
                    this.txtPrecio.Text = Convert.ToString(dtrProducto.GetInt32(6));                  
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


/////////////////////////////////Metodo para obtener el codigo de los producto/////////////////////////////////////

        public int getCodProductos()
        {
            return (codigoProductos);
        }//fin del metodo


///////////////////////////////////// Metodo para llenar la lista con los codigos del producto////////////////////////////////////

        public void llenarLista()
        {
            if (getCodProductos() != 0 || getCodProductos() == 0)
            {
                producto.setIdProducto(Convert.ToInt32(txtCodProducto.Text));

            }//fin del if que verifica que contenga datos

            ListViewItem lista;
            lista = lvProductos.Items.Add(txtCodProducto.Text);
        }//fin del metodo para llenar la lista con datos


//////////////////////////////////////////////// Accion del boton de remover /////////////////////////////////////////////////

        private void btnRemover_Click(object sender, EventArgs e)
        {

            foreach (ListViewItem listaProductos in lvProductos.SelectedItems)
            {
                listaProductos.Remove();
                
            }
             this.txtCantidad.Text =""+ this.mdismunirProductos();
            this.txtSubTotal.Text = "" + this.disminuirPrecio();
           
        }

////////////////////////////// Metodo para contar los productos que estan en la lista///////////////////////////////////////

        private int mContarProductos()
        {
            int contar = 0;
            foreach (ListViewItem item in lvProductos.Items)
            {
                contar++;
            }//fin del foreach

            return contar;

        }//fin del metodo que cuanta la cantidad de datos de la lista


////////////////////////////////////// Metodo para disminuir /////////////////////////////////////////////////////////

        private int mdismunirProductos()
        {
            int disminuir = 0;
            foreach (ListViewItem item in lvProductos.Items)
            {
                disminuir-=-1;
            }//fin del foreach

            return disminuir;

        }//fin del metodo que cuanta la cantidad de datos de la lista


///////////////////////////// Metodo para calcular el total de la venta si tiene factura////////////////////////////////

        private void cboDescuento_SelectedIndexChanged(object sender, EventArgs e)
        {
            totalDescuento = total - ( Convert.ToDouble(cboDescuento.SelectedItem) / 100 * total) ;
            descuento = Convert.ToDouble(cboDescuento.SelectedItem) / 100 * total;
            this.txtTotal.Text = "" + totalDescuento;

        }//fin de la accion del combobox de descuento


/////////////////////// Metodo para agregar los codigos del producto a la lista de produtos de la venta //////////////////////////

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (txtCodProducto.Text == "" || txtProducto.Text == "" || txtPrecio.Text == "" || txtCantidadProducto.Text == "")
            {

                MessageBox.Show("Debe de llenar todos los campos");
            }

            else { 
            int cantidad = 0;
            dtrProducto = clProducto.mConsultarProductoGeneral(conexion);

            if (dtrProducto != null)
            {

                if (dtrProducto.Read())
                {
                    cantidad = dtrProducto.GetInt32(9);

                }//Fin del del read

            }//fin del if 

            if (this.mVerificarExistencia()) { 

            producto.setCantidad(cantidad - (Convert.ToInt32(txtCantidadProducto.Text)));
            clProducto.mModificarCantidad(conexion, producto);

            this.llenarLista();//llena la lista con el codigo del producto
            this.txtCantidad.Text =""+ mContarProductos();
            this.txtSubTotal.Text = ""+ this.calcularPrecio();

                //this.txtCodProducto.Text = "";
                //this.txtProducto.Text = "";
                //this.txtPrecio.Text = "";
                //this.txtCantidadProducto.Text = "";
            }

            else
            {
                MessageBox.Show("No hay disponible en el inventario");
            }

         }//fin del else
        }//fin de la accion del boton agregar

/////////////////////////////////////// Metodo que verifica que la cantidad del producto sea mayor que 0 /////////////////////////////////

        private Boolean mVerificarExistencia()
        {
            dtrProducto = clProducto.mConsultarProducto(conexion, producto);

            if (dtrProducto.Read())
            {
                if (dtrProducto.GetInt32(9) > 0)
                    return true;
            }
            return false;
        }//fin del metodo mverificarExistencia




/////////////////////////////// Metodo para calcular el subtotal ///////////////////////////////////////////////// 

        public int calcularPrecio()
        {
          return total = total + (Convert.ToInt32(this.txtPrecio.Text) * Convert.ToInt32(this.txtCantidadProducto.Text));

        }//fin del metodo para calcular el subtotal

/////////////////////////////////// Metodo para disminuir el subtotal /////////////////////////////////////////////

        public int disminuirPrecio()
        {

            return total = total - (Convert.ToInt32(this.txtPrecio.Text) * Convert.ToInt32(this.txtCantidadProducto.Text));

            if (Convert.ToInt32(this.txtCantidadProducto.Text)==0) {
                total = 0;
                return total;
            }

        }//fin del metodo para calcular el subtotal

////////////////// Metodo para obtener el ultimo numero de la factura ////////////////////////////////////////////////////

        public void mConsultaIdFactura()
        {
         
            dtrFacturaE = clFactura.mConsultarIdFactura(conexion);

            if (dtrFacturaE != null)
            {

                if (dtrFacturaE.Read())
                {
                  numeroFactura=((dtrFacturaE.GetInt32(0)));
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
            this.lvProductos.Items.Clear();
        }//fin del metodo limpiar




///////////////////////////////////// Permisos heredados de la clase iPermisos ///////////////////////////////////////////

        public void activarInsertar(Boolean condicion) { }

       public void activarModificar(Boolean condicion) { }

       public void activarEliminar(Boolean condicion) { }

       public void activarConsultar(Boolean condicion) { }

    }//fin de la clase
}