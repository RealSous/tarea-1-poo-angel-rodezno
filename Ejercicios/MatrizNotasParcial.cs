using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea1.Ejercicios
{
    public class MatrizNotasParcial
    {
         // metodo principal que muestra el menu de opciones
         public bool EjecutarMNP()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("===== MATRIZ DE NOTAS POR PARCIAL =====");
                Console.WriteLine("1. Registrar notas y mostrar estadisticas");
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
                        ProcesarNotas();
                        break;

                    default:
                        MensajeError();
                        break;
                }

            } while (true);
        }
        // solicita las notas de n estudiantes en 3 parciales y calcula promedios por estudiante y por parcial
        private void ProcesarNotas()
        {
            Console.Clear();
            Console.Write("Ingrese cantidad de estudiantes: ");

            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                MensajeError();
                return;
            }

            double[,] notas = new double[n, 3];

            Console.WriteLine("\nIngrese notas de cada estudiante (3 parciales)\n");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Estudiante {i + 1}, Parcial {j + 1}: ");
                    if (!double.TryParse(Console.ReadLine(), out double nota) || nota < 0 || nota > 100)
                    {
                        MensajeError();
                        j--;
                        continue;
                    }

                    notas[i, j] = nota;
                }
            }

            double mejorPromedio = 0;
            int mejorEstudiante = 1;

            Console.WriteLine("\n===== PROMEDIO POR ESTUDIANTE =====");
            // calcula el promedio de cada estudiante sumando sus 3 parciales
            for (int i = 0; i < n; i++)
            {
                double suma = 0;
                for (int j = 0; j < 3; j++)
                {
                    suma += notas[i, j];
                }

                double promedio = suma / 3;
                Console.WriteLine($"Estudiante {i + 1}: {promedio:F2}");

                if (i == 0 || promedio > mejorPromedio)
                {
                    mejorPromedio = promedio;
                    mejorEstudiante = i + 1;
                }
            }

            Console.WriteLine("\n===== PROMEDIO POR PARCIAL =====");

            double[] promedioParcial = new double[3];
            // calcula el promedio de cada parcial sumando las notas de todos los estudiantes
            for (int j = 0; j < 3; j++)
            {
                double suma = 0;
                for (int i = 0; i < n; i++)
                {
                    suma += notas[i, j];
                }

                promedioParcial[j] = suma / n;
                Console.WriteLine($"Parcial {j + 1}: {promedioParcial[j]:F2}");
            }
            // encuentra el parcial mas dificil (el que tiene menor promedio)
            int parcialMasDificil = 1;
            double menorPromedio = promedioParcial[0];

            for (int j = 1; j < 3; j++)
            {
                if (promedioParcial[j] < menorPromedio)
                {
                    menorPromedio = promedioParcial[j];
                    parcialMasDificil = j + 1;
                }
            }

            Console.WriteLine("\n===== RESULTADOS FINALES =====");
            Console.WriteLine($"Estudiante con mejor promedio: Estudiante {mejorEstudiante} con {mejorPromedio:F2}");
            Console.WriteLine($"Parcial mas dificil: Parcial {parcialMasDificil} con promedio {menorPromedio:F2}");

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