using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagrama_a_Codigo
{
    internal class Taxi : Publico
    {
        private int TarifasReguladas;
        public Taxi()
        {
            TarifasReguladas = 90;
        }
        public void setTarifasReguladas(int TarifasReguladas)
        {
            this.TarifasReguladas = TarifasReguladas;
        }
        public string getTarifasReguladas()
        {
            return "La tarifa del taxi es de: " + TarifasReguladas + "cada 100 metros";
        }

    }
}
