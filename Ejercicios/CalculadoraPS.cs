using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea1.Ejercicios
{
    public class CalculadoraPS
    {
        // metodo principal que solicita datos del prestamo y calcula el interes
        public bool EjecutarCPS()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== CALCULADORA DE PRESTAMO SIMPLE =====");


                Console.WriteLine("1. Calcular prestamo");
                Console.WriteLine("2. Volver al menu principal");
                Console.Write("Opcion: ");
                string opcion = Console.ReadLine();

                if (opcion == "2")
                    return true; 
                else if (opcion != "1")
                {
                    Console.WriteLine("Opcion incorrecta, elija una opcion correcta");
                    Console.ReadKey();
                    continue;
                }

                {
                    Console.Write("Ingrese el monto del prestamo: ");
                    double monto = double.Parse(Console.ReadLine());

                    Console.Write("Ingrese la tasa de interes anual (%): ");
                    double tasaAnual = double.Parse(Console.ReadLine()) / 100;

                    Console.Write("Ingrese el plazo en meses: ");
                    int meses = int.Parse(Console.ReadLine());

                    if (monto <= 0 || tasaAnual < 0 || meses <= 0)
                    {
                        Console.WriteLine("Los valores ingresados deben ser positivos y/o mayores a 0");
                        Console.ReadKey();
                        continue;
                    }
                    // calcula el interes simple: monto * tasa * tiempo, luego divide entre 12 para obtener el interes mensual
                    double interesTotal = monto * tasaAnual * meses / 12;
                    double totalPagar = monto + interesTotal;
                    double cuotaMensual = totalPagar / meses;

                    Console.WriteLine("\n=== RESULTADOS ===");
                    Console.WriteLine("Interes total: L {interesTotal:F2}");
                    Console.WriteLine("Total a pagar: L {totalPagar:F2}");
                    Console.WriteLine("Cuota mensual fija: L {cuotaMensual:F2}");


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
}