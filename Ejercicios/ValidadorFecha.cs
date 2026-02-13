using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea1.Ejercicios
{
    public class ValidadorFecha
    {
        // verifica si una fecha es valida segun el dia, mes y año ingresados
        public static bool EsFechaValida(int dia, int mes, int anio)
        {
            // verificar que el año sea valido (por ejemplo, mayor a 0)
            if (anio < 1) return false;

            // verificar que el mes este entre 1 y 12
            if (mes < 1 || mes > 12) return false;

            // dias en cada mes
            int[] diasPorMes = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            // verificar si es año bisiesto
            bool esBisiesto = (anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0);

            // si es febrero y año bisiesto, tiene 29 dias
            if (mes == 2 && esBisiesto)
            {
                diasPorMes[1] = 29;
            }

            // verificar que el dia este dentro del rango valido para el mes
            if (dia < 1 || dia > diasPorMes[mes - 1]) return false;

            return true;
        }
        // metodo principal que solicita una fecha y la valida
        public bool EjecutarVF()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== VALIDADOR DE FECHA =====");
                Console.Write("Ingrese el dia: ");
                if (!int.TryParse(Console.ReadLine(), out int dia))
                {
                    Console.WriteLine("Dia invalido, ingreselo nuevamente");
                    Console.ReadKey();
                    continue;
                }

                Console.Write("Ingrese el mes: ");
                if (!int.TryParse(Console.ReadLine(), out int mes))
                {
                    Console.WriteLine("Mes invalido, ingreselo nuevamente");
                    Console.ReadKey();
                    continue;
                }

                Console.Write("Ingrese el año: ");
                if (!int.TryParse(Console.ReadLine(), out int anio))
                {
                    Console.WriteLine("Año invalido, ingreselo nuevamente");
                    Console.ReadKey();
                    continue;
                }

                if (EsFechaValida(dia, mes, anio))
                {
                    Console.WriteLine($"La fecha {dia}/{mes}/{anio} es correcta");
                }
                else
                {
                    Console.WriteLine($"La fecha {dia}/{mes}/{anio} es correcta");
                }

                Console.WriteLine("\nOpciones:");
                Console.WriteLine("1. Validar otra fecha");
                Console.WriteLine("2. Volver al menu principal");
                Console.WriteLine("3. Salir");
                Console.Write("Opcion: ");

                string opcion = Console.ReadLine();

                if (opcion == "1")
                    continue;
                else if (opcion == "2")
                    return true; 
                else if (opcion == "3")
                    return false; 
                else
                {
                    Console.WriteLine("Opcion incorrecta, volviendo al menu principal");
                    Console.ReadKey();
                    return true;
                }
            }
        }
    }
}