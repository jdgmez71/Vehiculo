using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagrama_a_Codigo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("CLASE VEHICULO\n");
            Vehiculos vehiculos = new Vehiculos();
            Console.WriteLine(vehiculos.getMarca());
            Console.WriteLine(vehiculos.getNombre());
            Console.WriteLine(vehiculos.getSerial());
            Console.WriteLine(vehiculos.getPrecio());
            Console.WriteLine(vehiculos.getColor());
            Console.WriteLine(vehiculos.getCapacidad());
            Console.WriteLine(vehiculos.getMotor());
            Console.WriteLine("\n------------------------------------------------------------------------------\n");

            Console.WriteLine("\nCLASE TERRESTRES\n");
            Terrestres terrestres = new Terrestres();
            Console.WriteLine(terrestres.getRuedas());
            Console.WriteLine(terrestres.getCambios());
            Console.WriteLine("\n------------------------------------------------------------------------------\n");
            Console.WriteLine("\nCLASE PARTICULAR\n");
            Particular particular = new Particular();
            Console.WriteLine(particular.getIdPlacaAmarilla());

            Console.WriteLine("\nCLASE CARRO\n");
            Carro carro = new Carro();
            Console.WriteLine(carro.getCarroceria());
            Console.WriteLine(carro.getChasis());

            Console.WriteLine("\nCLASE MOTO\n");
            Moto moto = new Moto();
            Console.WriteLine(moto.getCilindraje());
            Console.WriteLine(moto.getCuadro());

            Console.WriteLine("\nCLASE BICICLETA\n");
            Bicicleta bicicleta = new Bicicleta();
            Console.WriteLine(bicicleta.getMarco());

            Console.WriteLine("\n------------------------------------------------------------------------------\n");

            Console.WriteLine("\nCLASE PÚBLICO\n");
            Publico publico = new Publico();
            Console.WriteLine(publico.getIdPlacaBlanca());
            Console.WriteLine(publico.getTipodeServicio());

            Console.WriteLine("\nCLASE TAXI\n");
            Taxi taxi = new Taxi();
            Console.WriteLine(taxi.getTarifasReguladas());

            Console.WriteLine("\nCLASE AMBULANCIA\n");
            Ambulancia ambulancia = new Ambulancia();
            Console.WriteLine(ambulancia.getEquipoMedico());

            Console.WriteLine("\nCLASE BOMBEROS\n");
            Bomberos bomberos = new Bomberos();
            Console.WriteLine(bomberos.getAgua());
            Console.WriteLine(bomberos.getEquipoRescate());

            Console.WriteLine("\nCLASE BUS\n");
            Bus bus = new Bus();
            Console.WriteLine(bus.getTarifasFijas());




        }
    }
}