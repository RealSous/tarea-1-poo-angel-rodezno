using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea1.Ejercicios
{
    public class NumPrimosRango
    {
        // verifica si un numero es primo: solo divisible entre 1 y si mismo
        private bool EsPrimo(int numero)
        {
            if (numero <= 1)
                return false;
            // verifica divisibilidad desde 2 hasta la raiz cuadrada del numero
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                    return false;
            }
            return true;
        }
        // metodo principal que solicita el rango y muestra los numeros primos
        public bool EjecutarNPR()
        {
            while (true)
            {
            Console.Clear();
            Console.WriteLine("===== NUMEROS PRIMOS EN UN RANGO =====");
            Console.Write("Ingrese el numero inicial del rango: ");
            int inicio = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el numero final del rango: ");
            int fin = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Numeros primos entre {inicio} y {fin}:");
            // recorre el rango y verifica cada numero si es primo
            for (int i = inicio; i <= fin; i++)
            {
                if (EsPrimo(i))
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("\nOpciones:");
                Console.WriteLine("1. Realizar otra operacion");
                Console.WriteLine("2. Volver al menu principal");
                Console.WriteLine("3. Salir del programa");
                Console.Write("Seleccione una opcion: ");

                string subOpcion = Console.ReadLine();

                switch (subOpcion)
                {
                    case "1":
                        break; 
                    case "2":
                        return true; 
                    case "3":
                        return false; 
                    default:
                        Console.WriteLine("Opcion incorrecta, elija una opcion correcta");
                        Console.ReadKey();
                        break;
                }
            }
        }
        
    }
}          