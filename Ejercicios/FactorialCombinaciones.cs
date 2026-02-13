using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea1.Ejercicios
{
    public class FactorialCombinaciones
    {
        // metodo principal que muestra el menu de opciones
        public bool EjecutarFC()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== FACTORIAL Y COMBINACIONES =====");
                Console.WriteLine("1. Calcular factorial de N");
                Console.WriteLine("2. Calcular combinaciones C(n, r)");
                Console.Write("Opcion: ");

                if (!int.TryParse(Console.ReadLine(), out int opcion))
                {
                    Error("Dato incorrecto, ingrese un dato correcto");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        int res1 = CalcularFactorial();
                        if (res1 == 1) return true;
                        if (res1 == 2) return false;
                        break;

                    case 2:
                        int res2 = CalcularCombinaciones();
                        if (res2 == 1) return true;
                        if (res2 == 2) return false;
                        break;

                    default:
                        Error("Dato incorrecto, ingrese un dato correcto");
                        break;
                }
            } 
        }

        private int CalcularFactorial()
        {
            Console.Write("\nIngrese N (0 a 20): ");
            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Error("Dato incorrecto, ingrese un dato correcto");
                return 0;
            }

            if (n < 0 || n > 20)
            {
                Error("N debe estar entre 0 y 20");
                return 0;
            }

            long fac = Factorial(n);

            Console.WriteLine("\n===== RESULTADO =====");
            Console.WriteLine($"{n}! = {fac}");

            Console.WriteLine("\n\nOpciones:");
            Console.WriteLine("1. Repetir el ejercicio");
            Console.WriteLine("2. Volver al menu principal");
            Console.WriteLine("3. Salir del programa");
            Console.Write("Seleccione una opcion: ");

            string subOpcion = Console.ReadLine();

            switch (subOpcion)
            {
                case "1":
                    return 0; 
                case "2":
                    return 1; 
                case "3":
                    return 2; 
                default:
                    Error("Opcion incorrecta, elija una opcion correcta");
                    return 0; 
            }
        }

        private int CalcularCombinaciones()
        {
            Console.Write("\nIngrese n (0 a 20): ");
            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Error("Dato incorrecto, ingrese un dato correcto");
                return 0;
            }

            Console.Write("Ingrese r (0 a n): ");
            if (!int.TryParse(Console.ReadLine(), out int r))
            {
                Error("Dato incorrecto, ingrese un dato correcto");
                return 0;
            }

            if (n < 0 || n > 20)
            {
                Error("n debe estar entre 0 y 20");
                return 0;
            }

            if (r < 0 || r > n)
            {
                Error("r debe estar entre 0 y n");
                return 0;
            }

            long resultado = Combinaciones(n, r);

            Console.WriteLine("\n===== RESULTADO =====");
            Console.WriteLine($"C({n},{r}) = {resultado}");

            Console.WriteLine("\n\nOpciones:");
            Console.WriteLine("1. Repetir el ejercicio");
            Console.WriteLine("2. Volver al menu principal");
            Console.WriteLine("3. Salir del programa");
            Console.Write("Seleccione una opcion: ");

            string subOpcion = Console.ReadLine();

            switch (subOpcion)
            {
                case "1":
                    return 0; 
                case "2":
                    return 1; 
                case "3":
                    return 2; 
                default:
                    Error("Opcion incorrecta, elija una opcion correcta");
                    return 0; 
            }
        }

        // calcula el factorial de n multiplicando todos los numeros desde 2 hasta n
        private long Factorial(int n)
        {
            long resultado = 1;
            for (int i = 2; i <= n; i++)
                resultado *= i;

            return resultado;
        }
        // calcula combinaciones usando la formula: n! / (r! * (n-r)!)
        private long Combinaciones(int n, int r)
        {
            // formula: n! / (r! (n-r)!)
            long fn = Factorial(n);
            long fr = Factorial(r);
            long fnr = Factorial(n - r);

            return fn / (fr * fnr);
        }
        // muestra mensaje de error personalizado
        private void Error(string mensaje)
        {
            Console.WriteLine($"\n {mensaje}");
            Console.ReadKey(true);
        }
    }    
}
    
