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
        clsEntidadInventario producto;
        clsZapatos clProducto;
        clsConexion conexion;
        private Boolean bolAgregarE, bolAgregarD, bolModificar, bolEliminar;
        public int codigoProductos;

        public frmFactura() {


            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange700, Primary.DeepOrange900, Primary.DeepOrange500, Accent.DeepOrange200, TextShade.WHITE);

            this.conexion = new clsConexion();
            factura = new clsEntidadFactura();
            clFactura = new clsFactura();
            producto = new clsEntidadInventario();
            clProducto = new clsZapatos();
            

            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            factura.setIdFactura(Convert.ToInt32(txtCodProducto.Text));
             bolEliminar=clFactura.mEliminarFactura(conexion, factura);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            producto.setIdZapato(Convert.ToInt32(txtCodProducto.Text.Trim()));
            //consulta el estudiante por carnet

            dtrProducto = clProducto.mConsultarProducto(conexion, producto);
            this.llenarLista();

            //factura.setIdFactura(Convert.ToInt32(txtCodProducto.Text));
            //factura.setIdProducto(Convert.ToInt32(txtProducto.Text));
            //factura.setIdUsuario(Convert.ToInt32(txtPrecio.Text));
            //factura.setCantidad(Convert.ToInt32(txtCantidad.Text));
            //factura.setSubTotal(Convert.ToDouble(txtSubTotal.Text));
            //factura.setTotal(Convert.ToDouble(txtTotal.Text));

            //bolAgregarE = clFactura.mInsertarFacturaEncabezado(conexion,factura);
            //bolAgregarD = clFactura.mInsertarFacturaDetalle(conexion, factura);

            //if (bolAgregarE == true && bolAgregarD == true)
            //{

            //    MessageBox.Show("Ha sido agregado correctamente", "Registro correcto", MessageBoxButtons.OK);
            //    btnAgregar.Enabled = false;
            //    this.Limpiar();



            //}//fin del if de agregar

            //else {

            //    MessageBox.Show("Problemas al agregar", "Error", MessageBoxButtons.OK);
               
            //    this.Limpiar();

            //}

           

        }

   
        private void frmFactura_Load(object sender, EventArgs e)
        {
            this.mConsultaIdFactura();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //factura.setIdFactura(Convert.ToInt32(txtCodFactura.Text));

            //dtrFactura = clFactura .mConsultarFacturaDetalle(conexion, factura);
            //dtrFacturaE = clFactura.mConsultarFacturaEncabezado(conexion, factura);

            //if (dtrFactura != null)
            //{

            //    if (dtrFactura.Read())
            //    {

            //        this.txtCodProducto.Text = Convert.ToString(dtrFactura.GetInt32(2));
            //        this.txtCantidad.Text = Convert.ToString(dtrFactura.GetInt32(3));
            //        this.txtSubTotal.Text = Convert.ToString(dtrFactura.GetDecimal(4));

            //    }//fin del if 


            //    if (dtrFacturaE != null)
            //    {

            //        if (dtrFacturaE.Read())
            //        {

            //          this.txtCodUsuario.Text = Convert.ToString(dtrFacturaE.GetInt32(1));
            //          this.txtTotal.Text = Convert.ToString(dtrFacturaE.GetDecimal(2));

            //        }//fin del if 

            //    }//fin del if null

            frmListaProducto consultarProducto = new frmListaProducto(conexion);
            consultarProducto.ShowDialog();

            if (consultarProducto.getid() != 0)
            {
                producto.setIdZapato(consultarProducto.getid());
                txtCodProducto.Text = Convert.ToString(consultarProducto.getid());
                mConsultaProducto();
            }


      }//fin del buscar


        public void mConsultaProducto()
        {

            producto.setIdZapato(Convert.ToInt32(txtCodProducto.Text.Trim()));
            //consulta el estudiante por carnet

            dtrProducto = clProducto.mConsultarProducto(conexion,producto);

            if (dtrProducto != null)
            {

                if (dtrProducto.Read())
                {//si exise

                    this.txtProducto.Text = dtrProducto.GetString(2);
                    this.txtPrecio.Text = Convert.ToString(dtrProducto.GetInt32(5));
                      
                }//FIN READ

            }//fin del if que verifica que no este null

        }//fin del metodo que consulta el producto segun su id

        private void lvProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lvProductos.Items.Count; i++)
            {
                if (lvProductos.Items[i].Selected)
                {
                    codigoProductos = Convert.ToInt32(lvProductos.Items[i].Text);
                }

            }
        }

        public int getCodProductos()
        {
            return (codigoProductos);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }


        public void mConsultaIdFactura()
        {
            int numero = 0;
            dtrFacturaE = clFactura.mConsultarIdFactura(conexion);

            if (dtrFacturaE != null)
            {

                if (dtrFacturaE.Read())
                {//si exise

                  numero=((dtrFacturaE.GetInt32(0)));
                  numero++;
                  this.txtNumeroF.Text = Convert.ToString(numero);

                }//FIN READ

            }//fin del if que verifica que no este null

        }//fin del metodo que consulta el producto segun su id


        public void calcularSubtotal()
        {
            txtSubTotal.Text =""+ Convert.ToDecimal(txtCantidad.Text) * Convert.ToInt32(txtPrecio.Text);

        }

        public void llenarLista()
        {

            ListViewItem lista;
            lista = lvProductos.Items.Add(txtCodProducto.Text);

        }

        public void Limpiar()
        {
            this.txtCodProducto.Text = "";
            this.txtProducto.Text = "";
            this.txtPrecio.Text = "";
            this.txtCantidad.Text = "";
            this.txtSubTotal.Text = "";
            this.txtTotal.Text = "";

        }//fin del metodo limpiar
    }
}