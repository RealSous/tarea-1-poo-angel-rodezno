using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea1.Ejercicios
{
    public class FrecuenciaElementos
    {
        // metodo principal que muestra el menu de opciones
        public bool EjecutarFE()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== FRECUENCIA DE ELEMENTOS =====");
                Console.WriteLine("1. Generar numeros y mostrar frecuencias");
                Console.WriteLine("0. Volver al menu principal");
                Console.Write("Seleccione una opcion: ");

                if (!int.TryParse(Console.ReadLine(), out int opcion))
                {
                    MensajeError();
                    continue;
                }

                switch (opcion)
                {
                    case 0:
                        return true;

                    case 1:
                        ProcesarFrecuencia();
                        break;

                    default:
                        MensajeError();
                        break;
                }

            }
        }
        // genera 20 numeros aleatorios y cuenta cuantas veces aparece cada numero del 1 al 10
        private void ProcesarFrecuencia()
        {
            int[] numeros = new int[20];
            int[] frecuencia = new int[11]; 

            Random rnd = new Random();

            Console.WriteLine("\nNumeros generados:\n");
            // genera numeros aleatorios y cuenta su frecuencia
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = rnd.Next(1, 11); 
                Console.Write(numeros[i] + " ");
                frecuencia[numeros[i]]++;
            }

            Console.WriteLine("\n\nFrecuencia de cada numero:\n");

            int maxFrecuencia = frecuencia[1];
            int minFrecuencia = frecuencia[1];
            int numeroMasFrecuente = 1;
            int numeroMenosFrecuente = 1;
            // encuentra el numero mas y menos frecuente
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Numero {i}: {frecuencia[i]} veces");

                if (frecuencia[i] > maxFrecuencia)
                {
                    maxFrecuencia = frecuencia[i];
                    numeroMasFrecuente = i;
                }

                if (frecuencia[i] < minFrecuencia)
                {
                    minFrecuencia = frecuencia[i];
                    numeroMenosFrecuente = i;
                }
            }

            Console.WriteLine("\n===== RESULTADOS =====");
            Console.WriteLine($"Mas frecuente: {numeroMasFrecuente} ({maxFrecuencia} veces)");
            Console.WriteLine($"Menos frecuente: {numeroMenosFrecuente} ({minFrecuencia} veces)");

            Console.WriteLine("\nPresione enter para continuar");
            Console.ReadKey(true);
        }
        // muestra mensaje de error cuando los datos son invalidos
        private void MensajeError()
        {
            Console.WriteLine("Dato incorrecto, ingrese un dato valido");
            Console.ReadKey(true);
        }
    }
}