using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagrama_a_Codigo
{
    internal class Moto : Particular
    {
        private string Cilindraje;
        private string Cuadro;
        public Moto()
        {
            Cilindraje = "Cilindraje Medio";
            Cuadro = "Doble Cuna";
        }
        public void setCilindraje(string Cilindraje)
        {
            this.Cilindraje = Cilindraje;
        }
        public string getCilindraje()
        {
            return "El cilindraje de la moto es: " + Cilindraje;
        }
        public void setCuadro(string Cuadro)
        {
            this.Cuadro = Cuadro;
        }
        public string getCuadro()
        {
            return "El cuadro de la moto es: " + Cuadro;
        }
    }
}
