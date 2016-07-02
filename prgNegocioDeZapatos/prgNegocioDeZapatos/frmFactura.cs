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
        SqlDataReader dtrFactura,dtrFacturaE;
        clsEntidadFactura factura;
        clsFactura clFactura;
        clsConexion conexion;
        private Boolean bolAgregarE, bolAgregarD, bolModificar, bolEliminar;

        public frmFactura() {


             materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange700, Primary.DeepOrange900, Primary.DeepOrange500, Accent.DeepOrange200, TextShade.WHITE);

            this.conexion = new clsConexion();
            factura = new clsEntidadFactura();
            
            clFactura = new clsFactura();
            

            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            factura.setIdFactura(Convert.ToInt32(txtCodFactura.Text));
             bolEliminar=clFactura.mEliminarFactura(conexion, factura);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            factura.setIdFactura(Convert.ToInt32(txtCodFactura.Text));
            factura.setIdProducto(Convert.ToInt32(txtCodProducto.Text));
            factura.setIdUsuario(Convert.ToInt32(txtCodUsuario.Text));
            factura.setCantidad(Convert.ToInt32(txtCantidad.Text));
            factura.setSubTotal(Convert.ToDouble(txtSubTotal.Text));
            factura.setTotal(Convert.ToDouble(txtTotal.Text));

            bolAgregarE = clFactura.mInsertarFacturaEncabezado(conexion,factura);
            bolAgregarD = clFactura.mInsertarFacturaDetalle(conexion, factura);

            if (bolAgregarE == true && bolAgregarD == true)
            {

                MessageBox.Show("Ha sido agregado correctamente", "Registro correcto", MessageBoxButtons.OK);
                btnAgregar.Enabled = false;
                this.Limpiar();



            }//fin del if de agregar

            else {

                MessageBox.Show("Problemas al agregar", "Error", MessageBoxButtons.OK);
               
                this.Limpiar();

            }

           

        }

        

        private void frmFactura_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            factura.setIdFactura(Convert.ToInt32(txtCodFactura.Text));

            dtrFactura = clFactura .mConsultarFacturaDetalle(conexion, factura);
            dtrFacturaE = clFactura.mConsultarFacturaEncabezado(conexion, factura);

            if (dtrFactura != null)
            {

                if (dtrFactura.Read())
                {

                    this.txtCodProducto.Text = Convert.ToString(dtrFactura.GetInt32(2));
                    this.txtCantidad.Text = Convert.ToString(dtrFactura.GetInt32(3));
                    this.txtSubTotal.Text = Convert.ToString(dtrFactura.GetDecimal(4));
                   
                }//fin del if 


                if (dtrFacturaE != null)
                {

                    if (dtrFacturaE.Read())
                    {
 
                      this.txtCodUsuario.Text = Convert.ToString(dtrFacturaE.GetInt32(1));
                      this.txtTotal.Text = Convert.ToString(dtrFacturaE.GetDecimal(2));

                    }//fin del if 

                }//fin del if null
            }

        }//fin del buscar


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Limpiar()
        {
            this.txtCodFactura.Text = "";
            this.txtCodProducto.Text = "";
            this.txtCodUsuario.Text = "";
            this.txtCantidad.Text = "";
            this.txtSubTotal.Text = "";
            this.txtTotal.Text = "";

        }//fin del metodo limpiar
    }
}