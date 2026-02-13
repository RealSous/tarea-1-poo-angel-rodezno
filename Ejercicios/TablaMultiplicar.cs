using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea1.Ejercicios
{
    public class TablaMultiplicar
    {
        // metodo principal que solicita un numero y muestra su tabla de multiplicar
        public bool EjecutarTM()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== TABLA DE MULTIPLICAR EXTENDIDA ===");

                Console.Write("Ingrese un numero: ");
                if (!int.TryParse(Console.ReadLine(), out int numero))
                {
                    Console.WriteLine("Dato invalido, ingrese un numero correcto");
                    Console.ReadKey(true);
                    continue;
                }

                Console.WriteLine("\n===== RESULTADO =====\n");
                // multiplica el numero por cada valor del 1 al 12 y muestra el resultado
                for (int i = 1; i <= 12; i++)
                {
                    int resultado = numero * i;

                    // formato alineado
                    Console.WriteLine($"{numero,4} x {i,2} = {resultado,4}");
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
                    Console.ReadKey();
                }

            } 
        }
    }
}   
       
    