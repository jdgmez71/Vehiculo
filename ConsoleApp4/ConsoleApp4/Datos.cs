using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Datos
    {
        public string Name;
        public double Price;

        public Datos (string name, double price)
        {
            Name = name;
            Price = price;
        }

        public Datos()
        {
        }

        public void setName(string Name) { this.Name = Name; }
        public string getName()
        { return Name; }
        
        public void setPrice(double Price)
        { this.Price = Price; }

        public double getPrice()
        {
            return Price;
        }
        public override string ToString()
        {
            return $"Fruit: {Name} Price: {Price}";
        }

    }
}
