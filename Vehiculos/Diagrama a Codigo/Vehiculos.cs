using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagrama_a_Codigo
{
    internal class Vehiculos
    {
        private string Marca;

        private string Nombre;

        private string Serial;

        private double Precio;

        private string Color;

        private int Capacidad;

        private string Motor;

        public Vehiculos()
        {
            Marca = "Ford";
            Nombre = "Fiesta";
            Serial = "MROFR2262055899";           
            Precio = 1200.99;
            Color = "Azul";
            Capacidad = 4;
            Motor = "EcoBoost de tres cilindros y turbo";
        }
        public void setMarca(string Marca)
        {
            this.Marca = Marca;
        }
        public string getMarca()
        {
            return "La marca del vehiculo es: " + Marca;
        }
        public void setNombre(string Nombre)
        {
            this.Nombre = Nombre;
        }
        public string getNombre()
        {
            return "El nombre del vehiculo es: " + Nombre;
        }
        public void setSerial(string Serial)
        {
            this.Serial = Serial;
        }
        public string getSerial()
        {
            return "El serial del vehiculo es: " + Serial;
        }
        public void setPrecio(double Precio)
        {
            this.Precio= Precio;
        }
        public string getPrecio()
        {
            return "El precio del vehiculo es: " + Precio + "USD";
        }
        public void setColor(string Color) 
        {
            this.Color = Color;
        }
        public string getColor()
        {
            return "El color del vehiculo es: " + Color;
        }
        public void setCapacidad(int Capacidad) 
        {
            this.Capacidad = Capacidad;
        }
        public string getCapacidad()
        {
            return "El vehiculo cuenta con una capacidad de:" + Capacidad + " personas" ;
        }
        public void setMotor(string Motor)
        { 
            this.Motor = Motor;
        }
        public string getMotor()
        {
            return "El motor del vehiculo es: " + Motor;
        }       
    }
}
