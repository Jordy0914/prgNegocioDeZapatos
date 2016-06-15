﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Data.SqlClient;

namespace Modelo
{
    public class clsConexion
    {

        #region  Atributos 


        private String codigo;
        private String clave;
        private String perfil;

        private String baseDatos = "";

        private SqlConnection conexion;

        private SqlCommand comando;

        #endregion


        #region Constructor 


        public clsConexion()
        {

            this.codigo = "";
            this.clave = "";
            this.perfil = "";
            this.baseDatos = "";

        }//fin del metodo constructor

        #endregion



        #region Propiedades // son los set y los get

        public void setCodigo(String codigo)
        {

            this.codigo = codigo.Trim();

        }//fin del set

        public String getCodigo()
        {

            return this.codigo;

        }//fin del get

        public void setClave(String clave)
        {
            this.clave = clave.Trim();

        }//fin del set


        public String getClave()
        {
            return this.clave;

        }//fin del get


        public void setPerfil(String perfil)
        {
            this.perfil = perfil.Trim();

        }//fin del set


        public String getPerfil()
        {
            return this.perfil;

        }//fin del get

        #endregion



        #region Metodos 



        public SqlDataReader mSeleccionar(string strSentencia, clsConexion cone)
        {
            try
            {


                if (mConectar(cone))
                {

                    comando = new SqlCommand(strSentencia, conexion);
                    comando.CommandType = System.Data.CommandType.Text;//
                    return comando.ExecuteReader();

                }//fin del if


                else
                    return null;

            }//fin del try

            catch
            {

                return null;

            }//fin del catch

        }//fin del metodo mSeleccionar



        public Boolean mEjecutar(string strSentencia, clsConexion cone)
        {
            try
            {
                if (mConectar(cone))
                {
                    comando = new SqlCommand(strSentencia, conexion);
                    comando.ExecuteNonQuery();
                    return true;
                }//fin del if

                else
                    return false;

            }//fin del try

            catch
            {

                return false;

            }//fin del catch

        }//fin del metodo mEjecutar


        public Boolean mConectar(clsConexion cone)
        {

            try
            {
                conexion = new SqlConnection();
                conexion.ConnectionString = "user id='" + cone.getCodigo() + "';password='" + cone.getClave() + "';Data Source='" + mNomServidor() + "';Initial Catalog='" + this.baseDatos + "'";
                return true;

            }//fin del try

            catch
            {

                return false;
            }//fin del catch

        }//fin del metodo mConectar

        public string mNomServidor()
        {

            return Dns.GetHostName();

        }


        #endregion  //fin de la region de metodos
    }
}