using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Tarea1.Ejercicios
{
    public class cvTemperatura
    {
        private double temperatura;

        public double Temperatura
        {
            get { return temperatura; }
            set { temperatura = value; }
        }
        // metodo principal que solicita la temperatura y realiza la conversion seleccionada
        public bool EjecutarCv()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== CONVERTIDOR DE TEMPERATURAS =====\n");

                Console.Write("Ingrese la temperatura: ");
                Temperatura = double.Parse(Console.ReadLine());

                Console.WriteLine("Seleccione la conversion deseada:");
                Console.WriteLine("1. Celsius a Fahrenheit");
                Console.WriteLine("2. Celsius a Kelvin");
                Console.WriteLine("3. Fahrenheit a Celsius");
                Console.WriteLine("4. Fahrenheit a Kelvin");
                Console.WriteLine("5. Kelvin a Celsius");
                Console.WriteLine("6. Kelvin a Fahrenheit");
                Console.Write("Opcion: ");
                string opcion = Console.ReadLine();

                double resultado = 0;
                string unidad = "";
                // aplica la formula de conversion correspondiente segun la opcion seleccionada
                switch (opcion)
                {
                    case "1": resultado = (Temperatura * 9 / 5) + 32; unidad = "°F"; break;
                    case "2": resultado = Temperatura + 273.15; unidad = "K"; break;
                    case "3": resultado = (Temperatura - 32) * 5 / 9; unidad = "°C"; break;
                    case "4": resultado = (Temperatura - 32) * 5 / 9 + 273.15; unidad = "K"; break;
                    case "5": resultado = Temperatura - 273.15; unidad = "°C"; break;
                    case "6": resultado = (Temperatura - 273.15) * 9 / 5 + 32; unidad = "°F"; break;
                    default:
                        Console.WriteLine("Opcion incorrecta, elija una opcion correcta");
                        Console.ReadKey();
                        continue;
                }

                Console.WriteLine($"Resultado: {resultado} {unidad}");

                Console.WriteLine("\nOpciones:");
                Console.WriteLine("1. Realizar otra operacion");
                Console.WriteLine("2. Volver al menu principal");
                Console.WriteLine("3. Salir del programa");
                Console.Write("Seleccione una opcion: ");

                string subOpcion = Console.ReadLine();

                if (subOpcion == "1")
                    continue;
                else if (subOpcion == "2")
                    return true; 
                else if (subOpcion == "3")
                    return false; 
                else
                {
                    Console.WriteLine("Opcion incorrecta, elija una opcion correcta");
                    Console.ReadKey();
                }
            }
        }
    }
}

   
