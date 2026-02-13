using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea1.Ejercicios
{
    public class PatronAsteriscos
    {
        // metodo principal que solicita el numero de filas y genera el patron
        public bool EjecutarPA()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== PATRON DE ASTERISCOS =====");

                Console.Write("Ingrese el numero de filas: ");
                if (!int.TryParse(Console.ReadLine(), out int filas) || filas <= 0)
                {
                    Console.WriteLine("Dato invalido, ingrese un numero positivo");
                    Console.ReadKey(true);
                    continue;
                }

                Console.WriteLine("\n===== RESULTADO =====\n");
                // imprime asteriscos en forma triangular: fila 1 tiene 1 asterisco, fila 2 tiene 2, etc
                for (int i = 1; i <= filas; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

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
                    Console.ReadKey(true);
                }
            }
        }
    }
}
