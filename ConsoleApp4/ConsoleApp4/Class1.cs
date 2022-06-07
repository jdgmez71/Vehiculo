using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class1
    {
        public static void Main(string[] args)
        {
            Datos myData = new Datos();
            Console.WriteLine("Insert the fruit name:");
            myData.setName(Console.ReadLine());
            Console.WriteLine("Insert the fruit price:");
            myData.setPrice(double.Parse(Console.ReadLine()));
            Console.WriteLine(myData.ToString());
        }
    }
}
