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
using AccesoDatos;
using LogicaNegocios;
using System.Data.SqlClient;

namespace prgNegocioDeZapatos
{
    public partial class frmListadoFacturas : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        clsEntidadFacturaEncabezado factura;
        clsConexion conexion;
        clsFactura clFactura;
        SqlDataReader dtrFacturas;
        public int codigoFacturas;
        public Boolean bolEliminar;
        clsVistas clVistas;
        clsEntidadUsuario usuario;
        

        public frmListadoFacturas(clsConexion cone, clsEntidadUsuario pEntidadUsuario, clsEntidadVista vista)
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange700, Primary.DeepOrange900, Primary.DeepOrange500, Accent.DeepOrange200, TextShade.WHITE);

            this.clFactura = new clsFactura();
            this.factura = new clsEntidadFacturaEncabezado();
            this.conexion = cone;
            usuario = pEntidadUsuario;
            this.clVistas = new clsVistas();

            InitializeComponent();
           
        }

        private void frmListadoFacturas_Load(object sender, EventArgs e)
        {
          
        }

        public int getCodigosFacturas()
        {
            return (codigoFacturas);
        }//fin del metodo


        private void lvFacturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lvFacturas.Items.Count; i++)
            {
                if (lvFacturas.Items[i].Selected)
                {
                    codigoFacturas = Convert.ToInt32(lvFacturas.Items[i].Text);
                    //MessageBox.Show("" + codigoFacturas);

                }//fin del if 

            }//fin del for
           
        }


        public void llenarLista()
        {
           
        }//fin del metodo para llenar la lista con datos



////////////////////////////////////////////// Accion del boton Buscar ////////////////////////////////////////////////////////

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
            factura.setIdFactura(Convert.ToInt32(txtIdFactura.Text.Trim()));
            dtrFacturas = clFactura.mConsultarFacturasGenerales(conexion, factura);

            if (txtIdFactura.Text=="") {

                MessageBox.Show("Debe de digitar el codigo de la factura que desear buscar");
            }//fin del if que verifica que se digite el numero de factua

            else {              
                    while (dtrFacturas.Read())
                     {
                        ListViewItem lista;
                        lista = lvFacturas.Items.Add(Convert.ToString(dtrFacturas.GetInt32(0)));
                        lista.SubItems.Add(Convert.ToString(dtrFacturas.GetInt32(1)));
                        lista.SubItems.Add(Convert.ToString(dtrFacturas.GetInt32(2)));
                        lista.SubItems.Add(Convert.ToString(dtrFacturas.GetDecimal(3)));
                        lista.SubItems.Add(Convert.ToString(dtrFacturas.GetDecimal(4)));

                   }//fin del while para llenar la lista con los datos del select
            }//fin del else que se realiza si se digita el numero de factura
        }//fin de la accion del boton buscar



        private void lvFacturas_DoubleClick(object sender, EventArgs e)
        {
            factura.setIdFactura(codigoFacturas);
            bolEliminar = clFactura.mEliminarFactura(conexion, factura);

        }//fin de la accion del double click de la lista

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }//fin de la accion del boton salir


        public void limpiar()
        {
            this.txtIdFactura.Text = "";
        }//fin del metodo para limpiar los campos

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //factura.setIdFactura(codigoFacturas);
            //bolEliminar = clFactura.mEliminarFactura(conexion, factura);
        }
    }
}
