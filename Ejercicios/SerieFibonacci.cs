using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Numerics;

namespace Tarea1.Ejercicios
{
    public class SerieFibonacci
    {
        // metodo principal que solicita la cantidad de terminos y genera la serie
        public bool EjecutarSF()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Ingrese el numero de terminos de la serie Fibonacci: ");
                int n = int.Parse(Console.ReadLine());

                BigInteger a = 0, b = 1, c;
                BigInteger sum = 0;

                Console.WriteLine("Serie Fibonacci:");
                // genera la serie sumando los dos numeros anteriores: 0, 1, 1, 2, 3, 5, 8, 13, etc
                for (int i = 0; i < n; i++)
                {
                    Console.Write(a + " ");
                    sum += a;
                    c = a + b;
                    a = b;
                    b = c;
                }

                double average = double.Parse(sum.ToString()) / n;

                Console.WriteLine($"\n\nSuma total: {sum}");
                Console.WriteLine($"Promedio: {average:F2}");

                Console.WriteLine("\n\nOpciones:");
                Console.WriteLine("1. Repetir el ejercicio");
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