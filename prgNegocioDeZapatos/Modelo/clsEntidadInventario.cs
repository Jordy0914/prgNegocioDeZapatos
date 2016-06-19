using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public  class clsEntidadInventario
    {


        #region Atributos

        private int idZapato;
        private int idEmpleado;
        private String modelo;
        private String nombre;
        private Double talla;
        private String color;
        private int costo;
        private int precio;
        private String marca;
        private String categoria;
        private int cantidad;


        #endregion


        #region Constructor

        public clsEntidadInventario() { 

             this.idZapato=0;
             this.idEmpleado=0;
             this.modelo="";
             this.nombre="";
             this.talla=0.0;
             this.color="";
             this.costo=0;
             this.precio=0;
             this.marca="";
             this.categoria="";
             this.cantidad=0;
        }
        #endregion


        #region Metodos 


        public void setIdZapato(int idZapato)
        {
            this.idZapato = idZapato;

        }


        public int getIdZapato()
        {

            return idZapato;
        }


        public void setIdEmpleado(int idEmpleado)
        {
            this.idEmpleado = idEmpleado;

        }


        public int getIdEmpleado()
        {

            return idEmpleado;
        }



        public void setModelo(String modelo)
        {
            this.modelo = modelo;

        }


        public String getModelo()
        {

            return modelo;
        }


        public void setNombre(String nombre)
        {
            this.nombre = nombre;

        }


        public String getNombre()
        {

            return nombre;
        }

        public void setTalla(Double talla)
        {
            this.talla = talla;

        }


        public Double getTalla()
        {

            return talla;
        }

        public void setColor(String color)
        {
            this.color = color;

        }


        public String getColor()
        {

            return color;
        }


        public void setCosto(int costo)
        {
            this.costo = costo;

        }


        public int getCosto()
        {

            return costo;
        }


        public void setPrecio(int precio)
        {
            this.precio = precio;

        }


        public int getPrecio()
        {

            return precio;
        }


        public void setMarca(String marca)
        {
            this.marca = marca;

        }


        public String getMarca()
        {

            return marca;
        }

        public void setCategoria(String categoria)
        {
            this.categoria = categoria;

        }


        public String getCategoria()
        {

            return categoria;
        }

        public void setCantidad(int cantidad)
        {
            this.cantidad = cantidad;

        }


        public int getCantidad()
        {

            return cantidad;
        }


        #endregion

    }
}
