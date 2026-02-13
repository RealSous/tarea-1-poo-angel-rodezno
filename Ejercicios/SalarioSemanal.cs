using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea1.Ejercicios
{
    public class SalarioSemanal
    {
        // metodo principal que solicita horas trabajadas y tarifa para calcular el salario
        public bool EjecutarSS()
        {
            do // menu interno para permitir varios calculos
            {
                Console.Clear();
                Console.WriteLine("===== CALCULO DE SALARIO SEMANAL ===");
                Console.WriteLine("Ingrese 0 en horas para volver al menu principal");

                // ingreso de horas trabajadas
                Console.Write("Horas trabajadas: ");
                if (!double.TryParse(Console.ReadLine(), out double horas) || horas < 0)
                {
                    Console.WriteLine("Dato no valido, intente nuevamente");
                    Console.ReadKey(true);
                    continue;
                }

                if (horas == 0) // opcion para salir
                    return true;

                // ingreso de tarifa por hora
                Console.Write("Tarifa por hora: ");
                if (!double.TryParse(Console.ReadLine(), out double tarifa) || tarifa <= 0)
                {
                    Console.WriteLine("La tarifa debe ser mayor que 0, intente nuevamente");
                    Console.ReadKey(true);
                    continue;
                }

                // calcula horas normales (maximo 44) y horas extra (las que excedan 44), las horas extra se pagan al 150%
                double horasNormales = Math.Min(horas, 44);
                double horasExtra = Math.Max(horas - 44, 0);

                double pagoNormal = horasNormales * tarifa;
                double pagoExtra = horasExtra * tarifa * 1.5;
                double salarioTotal = pagoNormal + pagoExtra;

                // Desglose
                Console.WriteLine("\n===== DESGLOSE =====");
                Console.WriteLine($"Horas normales ({horasNormales} h): L {pagoNormal:F2}");
                Console.WriteLine($"Horas extra ({horasExtra} h): L {pagoExtra:F2}");
                Console.WriteLine($"Salario total: L {salarioTotal:F2}");

                Console.WriteLine("\nPresione enter para hacer otro calculo / ingrese 0 en horas para salir");
                Console.ReadKey(true);

            } while (true);
        }
    }

    }
