using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea1.Ejercicios
{
    public class DiasMesBisiesto
    {
            // metodo principal que solicita el año y mes para calcular los dias
            public bool EjecutarDMB()
            {
                while (true)
                {

                Console.Clear();
                Console.WriteLine("===== DIAS DEL MES Y AÑO BISIESTO =====");

                Console.Write("Ingrese el año: ");
                if (!int.TryParse(Console.ReadLine(), out int año) || año <= 0)
                {
                    Error();
                    continue;
                }

                if (año == 0)
                    return true;

                Console.Write("Ingrese el mes (1-12): ");
                if (!int.TryParse(Console.ReadLine(), out int mes) || mes < 1 || mes > 12)
                {
                    Error();
                    continue;
                }

                bool bisiesto = EsBisiesto(año);
                int dias = DiasDelMes(mes, año);

                Console.WriteLine("\n===== CONCLUSION =====");
                Console.WriteLine($"Año {año}: {(bisiesto ? "Bisiesto" : "No bisiesto")}");
                Console.WriteLine($"El mes indicado ({mes}) tiene {dias} dias.");

                Console.WriteLine("\nOpciones:");
                Console.WriteLine("1. Realizar otra operacion");
                Console.WriteLine("2. Volver al menu principal");
                Console.WriteLine("3. Salir del programa");
                Console.Write("Seleccione una opcion: ");

                string subOpcion = Console.ReadLine();

                if (subOpcion == "1")
                    continue;
                else if (subOpcion == "2")
                    return true; // volver al menú principal
                else if (subOpcion == "3")
                    return false; // salir del programa
                else
                {
                    Console.WriteLine("Opcion incorrecta, elija una opcion correcta");
                    Console.ReadKey();
                }

            }
        }
        // verifica si un año es bisiesto: divisible entre 400 o divisible entre 4 pero no entre 100
        private bool EsBisiesto(int año)
        {
            return (año % 400 == 0) || (año % 4 == 0 && año % 100 != 0);
        }
        // retorna la cantidad de dias que tiene un mes, considerando si el año es bisiesto para febrero
        private int DiasDelMes(int mes, int año)
        {
            switch (mes)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    return 31;
                case 4: case 6: case 9: case 11:
                    return 30;
                case 2:
                    return EsBisiesto(año) ? 29 : 28;
                default:
                    return 0; // nunca deberia llegar aqui
            }
        }
        // muestra mensaje de error cuando los datos son invalidos
        private void Error()
        {
            Console.WriteLine("Dato invalido, ingreselo nuevamente.");
            Console.ReadKey(true);
        }
    }
}   

    
