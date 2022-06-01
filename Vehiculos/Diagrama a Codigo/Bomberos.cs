using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagrama_a_Codigo
{
    internal class Bomberos : Publico
    {
        private int Agua;
        private string EquipoRescate;
        public Bomberos()
        {
            Agua = 8000;
            EquipoRescate = "cuerdas \ncamillas \ncollares \ncervicales \ntablillas \ntanques de oxígeno \ntrajes de inmersión \nequipos de respiración \nmotobombas \nextintores \ntenazas hidráulicas \ncortadores \ngatos telescópicos hidráulicos";
        }
        public void SetAgua(int Agua)
        {
            this.Agua = Agua;
        }
        public string getAgua()
        {
            return "El Camion de bomberos cuenta con " + Agua + "lts";
        }
        public void setEquipoRescate(string EquipoRescate)
        {
            this.EquipoRescate = EquipoRescate;
        }
        public string getEquipoRescate()
        {
            return "El equipo medico con el que cuenta el camion de bomberos es: " + EquipoRescate;
        }
    }
}
