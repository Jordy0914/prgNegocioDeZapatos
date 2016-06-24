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
using MaterialSkin.Animations;
using Entidades;
using LogicaNegocios;
using AccesoDatos;
using System.Data.SqlClient;
namespace prgNegocioDeZapatos
{
    public partial class frmAcceso : MaterialForm
    {
        #region Atributos
        private clsConexion conexion;
        private clsEntidadUsuario pEntidadUsuario;
        private clsUsuario usuario;
        private SqlDataReader dtrUsuario; //Para el retorno de las tuplas
        private int intContador;
        #endregion

        private readonly MaterialSkinManager materialSkinManager;
        public frmAcceso()
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange700, Primary.DeepOrange900, Primary.DeepOrange500, Accent.DeepOrange200, TextShade.WHITE);
            conexion = new clsConexion();
            pEntidadUsuario = new clsEntidadUsuario();
            usuario = new clsUsuario();
            intContador = 0;
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            MainForm menu = new MainForm();
            menu.Visible = true;
            this.Visible = false;
        }

        private void frmAcceso_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
                //El evento "Focus" permite trasladar el cursor del mouse al objeto indicado
                this.txtLogin.Focus();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                if (mValidarDatos() == true)
                {
                    this.btnIngresar.Enabled = true;
                }
            }
        }//fin KeyPressClave


        #region Metodos Propios
        //Este métoos permite verificar la existencia del usuario segun el codigo y la clave
        public Boolean mValidarDatos()
        {
            if (intContador <= 2)
            {

                //Llenado de lo atributos de la clase EntidadUsuario
                pEntidadUsuario.setLogin(this.txtLogin.Text.Trim());
                pEntidadUsuario.setPassword(this.txtPassword.Text.Trim());

                //Consltar si el usuario existe
                dtrUsuario = usuario.mConsultarUsuario(conexion, pEntidadUsuario);

                //Evaluar si retorna tuplas o datos
                if (dtrUsuario != null)
                {
                    if (dtrUsuario.Read())
                    {
                        pEntidadUsuario.setLogin(dtrUsuario.GetString(1));  // |0=codigo|1=clave|2=perfil|
                        pEntidadUsuario.setPassword(dtrUsuario.GetString(3));

                        if (pEntidadUsuario.getLogin() == this.txtLogin.Text.Trim() && pEntidadUsuario.getPassword() == this.txtPassword.Text.Trim())
                        {
                            this.btnIngresar.Enabled = true;
                            return true;
                        }//fin del if para verificar que el usuario agregado coincida con el que inicia sesion

                        else
                        {
                            MessageBox.Show("El usuario esta bloqueado", "Atención", MessageBoxButtons.OK);
                            return false;
                        }//fin del pEntidadUsuario


                    }//fin del if del Read
                    else
                    {
                        MessageBox.Show("El Usuario no existe", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }//fin else read

                }//fin del if del null
                else
                {
                    MessageBox.Show("El usuario no existe", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }//fin else null
            }//fin del if del contador
            else
            {
                MessageBox.Show("usted digitó 3 veces su usuario de forma errónea", "Usuario Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }//fin else  contador

        }//fin metodo
        #endregion
    }
}
