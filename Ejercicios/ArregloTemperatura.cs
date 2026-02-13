using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea1.Ejercicios
{
    public class ArregloTemperatura
    {
        // metodo principal que muestra el menu de opciones
        public bool EjecutarAT()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("===== ARREGLO DE TEMPERATURAS =====");
                Console.WriteLine("1. Registrar temperaturas y mostrar estadisticas");
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
                        ProcesarTemperaturas();
                        break;

                    default:
                        MensajeError();
                        break;
                }

            } while (true);
        }
        // solicita las temperaturas de 7 dias y calcula estadisticas
        private void ProcesarTemperaturas()
        {
            double[] temps = new double[7];

            Console.Clear();
            Console.WriteLine("===== REGISTRO DE TEMPERATURAS =====\n");

            for (int i = 0; i < temps.Length; i++)
            {
                Console.Write($"Ingrese la temperatura del dia {i + 1}: ");
                if (!double.TryParse(Console.ReadLine(), out double t))
                {
                    MensajeError();
                    i--;
                    continue;
                }
                temps[i] = t;
            }
            // calcula la suma, maxima, minima y sus respectivos dias
            double suma = 0;
            double max = temps[0];
            double min = temps[0];
            int diaMax = 1;
            int diaMin = 1;

            for (int i = 0; i < temps.Length; i++)
            {
                suma += temps[i];

                if (temps[i] > max)
                {
                    max = temps[i];
                    diaMax = i + 1;
                }

                if (temps[i] < min)
                {
                    min = temps[i];
                    diaMin = i + 1;
                }
            }

            double promedio = suma / temps.Length;
            // cuenta cuantos dias tuvieron temperatura mayor al promedio
            int diasSobrePromedio = 0;
            for (int i = 0; i < temps.Length; i++)
            {
                if (temps[i] > promedio)
                    diasSobrePromedio++;
            }

            Console.WriteLine("\n===== ESTADISTICAS =====");
            Console.WriteLine($"Promedio semanal: {promedio:F2}");
            Console.WriteLine($"Dias sobre el promedio: {diasSobrePromedio}");
            Console.WriteLine($"Dia mas caluroso: dia {diaMax} con {max:F2}");
            Console.WriteLine($"Dia mas frio: dia {diaMin} con {min:F2}");
            // calcula la variacion de temperatura entre dias consecutivos
            Console.WriteLine("\nVariacion entre dias consecutivos:\n");
            for (int i = 0; i < temps.Length - 1; i++)
            {
                double variacion = temps[i + 1] - temps[i];
                Console.WriteLine($"Dia {i + 1} a dia {i + 2}: {variacion:F2}");
            }

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
