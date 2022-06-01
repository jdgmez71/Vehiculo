using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagrama_a_Codigo
{
    internal class Publico : Terrestres
    {
        private string IdPlacaBlanca;
        private string TipodeServicio;
        public Publico()
        {
            IdPlacaBlanca = "MAK-281";
            TipodeServicio = "Medico";
        }

        public void setIdPlacaBlanca(string IdPlacaBlanca)
        {
            this.IdPlacaBlanca = IdPlacaBlanca;
        }
        public string getIdPlacaBlanca()
        {
            return "La placa blanca del vehiculo es: " + IdPlacaBlanca;
        }
        public void setTipodeServicio(string TipodeServicio)
        {
            this.TipodeServicio = TipodeServicio;    
        }
        public string getTipodeServicio()
        {
            return "El tipo de servicio que presta el vehiculo es: " + TipodeServicio;
        }
        
    }
}
