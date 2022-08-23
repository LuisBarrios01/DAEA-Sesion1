using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Celsius a Fahrenheit");
                Console.WriteLine("[2] Fahrenheit a Celsius");
                Console.WriteLine("[0] Salir");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        int celsius, faren;
                        Console.WriteLine("Ingrese los grados Celsius(°C) : ");
                        celsius = int.Parse(Console.ReadLine());
                        faren = (celsius * 9) / 5 + 32;
                        Console.WriteLine("La temperatura en Fahrenheit es(°F) : " + faren);
                        Console.ReadLine();
                        break;

                    case "2":
                        Console.WriteLine("Ingrese los grados Fahrenheit(°F):");
                        double Fahrenheit = Convert.ToDouble(Console.ReadLine()); ;
                        double Celsius = (Fahrenheit - 32) * 5 / 9;
                        Console.WriteLine("La temperatura en Celsius(°C):" + Celsius);
                        Console.ReadLine();
                        break;
                }
            } while (!opcion.Equals("0"));

        }
    }
}