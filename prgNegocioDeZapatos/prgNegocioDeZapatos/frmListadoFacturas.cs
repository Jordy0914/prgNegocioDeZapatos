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
    public partial class frmListadoFacturas : MaterialForm, IPermisos
    {
        private readonly MaterialSkinManager materialSkinManager;
        clsEntidadDetalleFactura factura;
        clsEntidadFacturaEncabezado facturaE;
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
            this.factura = new clsEntidadDetalleFactura();
            facturaE = new clsEntidadFacturaEncabezado();
            this.conexion = cone;
            usuario = pEntidadUsuario;
            this.clVistas = new clsVistas();

            InitializeComponent();
           
        }


        #region Metodos del IPermisos
        public void activarInsertar(Boolean condicion)
        {

        }

        public void activarModificar(Boolean condicion)
        {

        }

        public void activarEliminar(Boolean condicion)
        {

        }

        public void activarConsultar(Boolean condicion)
        {
            this.btnBuscar.Enabled = condicion;
        }
        #endregion



        ////////////////////////////////////// Metodo principal de la clase ////////////////////////////////////

        private void frmListadoFacturas_Load(object sender, EventArgs e)
        {
            this.activarPermisos();
        }

       
////////////////////////////////////// Metodo para obtener el codigo de la factura////////////////////////////////////
        
        public int getCodigosFacturas()
        {
            return (codigoFacturas);
        }//fin del metodo


/////////////////////////////////////////// Accion para obtener los datos seleccionados ////////////////////////////////////

        private void lvFacturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lvFacturas.Items.Count; i++)
            {
                if (lvFacturas.Items[i].Selected)
                {
                    codigoFacturas = Convert.ToInt32(lvFacturas.Items[i].Text);
                }//fin del if 

            }//fin del for
           
        }//fin de la accion de la lista facturas

        

////////////////////////////////////////////// Accion del boton Buscar ////////////////////////////////////////////////////////

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
            facturaE.setIdFactura(Convert.ToInt32(txtIdFactura.Text.Trim()));
            dtrFacturas = clFactura.mConsultarFacturasGenerales(conexion, facturaE);

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


/////////////////////////////////// Accion del boton eliminar ///////////////////////////////////////////////////////////////////

       

/////////////////////////////////// Accion del doble click de la lista /////////////////////////////////////////////////////////

        private void lvFacturas_DoubleClick(object sender, EventArgs e)
        {
            //factura.setIdFactura(getCodigosFacturas());
            //bolEliminar = clFactura.mEliminarFactura(conexion, factura);

        }//fin de la accion del double click de la lista

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }//fin de la accion del boton salir


////////////////////////////////////// Metodo para limpiar ////////////////////////////////////
        public void limpiar()
        {
            this.txtIdFactura.Text = "";
        }//fin del metodo para limpiar los campos
        private void activarPermisos()
        {
            this.dtrVista = clVistas.mConsultarPermisosVista(this.conexion, this.pEntidadVista);

            if (dtrVista.Read())
            {
                this.activarInsertar(dtrVista.GetBoolean(0));
                this.activarModificar(dtrVista.GetBoolean(1));
                this.activarEliminar(dtrVista.GetBoolean(2));
                this.activarConsultar(dtrVista.GetBoolean(3));
            }
        }

    }//fin de la clase
}
