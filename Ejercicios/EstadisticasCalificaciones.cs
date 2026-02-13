using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea1.Ejercicios
{
    public class EstadisticasCalificaciones
    {
        // metodo principal que solicita las calificaciones y calcula las estadisticas
        public bool EjecutarEC()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== ESTADISTICAS DE CALIFICACIONES =====");

                Console.Write("Ingrese la cantidad de calificaciones: ");
                if (!int.TryParse(Console.ReadLine(), out int n) || n < 0)
                {
                    MensajeError();
                    continue;
                }

                if (n == 0)
                {
                    MensajeError();
                    continue;
                }

                double[] notas = new double[n];

                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Ingrese calificacion {i + 1}: ");
                    if (!double.TryParse(Console.ReadLine(), out double nota) || nota < 0 || nota > 100)
                    {
                        MensajeError();
                        i--;
                        continue;
                    }

                    notas[i] = nota;
                }
                // calcula la suma, maxima, minima, aprobados y reprobados recorriendo el arreglo
                double suma = 0;
                double max = notas[0];
                double min = notas[0];
                int aprobados = 0;
                int reprobados = 0;

                for (int i = 0; i < n; i++)
                {
                    suma += notas[i];

                    if (notas[i] > max)
                        max = notas[i];

                    if (notas[i] < min)
                        min = notas[i];

                    if (notas[i] >= 60)
                        aprobados++;
                    else
                        reprobados++;
                }

                double promedio = suma / n;
                // calcula la desviacion estandar: raiz cuadrada de la suma de las diferencias al cuadrado dividido entre n
                double sumaCuadrados = 0;
                for (int i = 0; i < n; i++)
                {
                    sumaCuadrados += Math.Pow(notas[i] - promedio, 2);
                }

                double desviacion = Math.Sqrt(sumaCuadrados / n);

                Console.WriteLine("\n===== CALIFICACIONES FINALES =====");
                Console.WriteLine($"Promedio: {promedio:F2}");
                Console.WriteLine($"Maxima: {max:F2}");
                Console.WriteLine($"Minima: {min:F2}");
                Console.WriteLine($"Aprobados: {aprobados}");
                Console.WriteLine($"Reprobados: {reprobados}");
                Console.WriteLine($"Desviacion estandar: {desviacion:F4}");

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
        // muestra mensaje de error cuando los datos son invalidos
        private void MensajeError()
        {
            Console.WriteLine("Dato invalido, ingrese un valor correcto");
            Console.ReadKey(true);
        }
    }
}