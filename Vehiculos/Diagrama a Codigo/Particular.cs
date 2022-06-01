using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagrama_a_Codigo
{
    internal class Particular : Terrestres
    {
        private string IdPlacaAmarilla;

        public Particular()
        {
            IdPlacaAmarilla = "BLM-074";
        }
        public void setIdPlacaAmarilla(string IdPlacaAmarilla)
        {
            this.IdPlacaAmarilla = IdPlacaAmarilla;
        }
        public string getIdPlacaAmarilla()
        {
            return "La placa amarilla del vehiculo es: " + IdPlacaAmarilla;
        }
    }
}
