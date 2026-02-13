using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea1.Ejercicios
{
    public class TranscursoTiempo
    {
        // metodo principal que solicita dos horas y calcula la diferencia
        public bool EjecutarTT()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== TRANSCURSO DE TIEMPO =====");

                Console.WriteLine("1. Calcular diferencia de tiempo");
                Console.WriteLine("2. Volver al menu principal");
                Console.Write("Opcion: ");
                string opcion = Console.ReadLine();

                if (opcion == "2")
                    return true; 
                else if (opcion != "1")
                {
                    Console.WriteLine("Opcion incorrecta, elija una opcion correcta");
                    Console.ReadKey();
                    continue;
                }
                {
                    Console.Write("Ingrese la primera hora (HH:MM:SS): ");
                    string tiempo1 = Console.ReadLine();

                    Console.Write("Ingrese la segunda hora (HH:MM:SS): ");
                    string tiempo2 = Console.ReadLine();
                    // convierte ambas horas a segundos para facilitar el calculo
                    int segundos1 = ConvertirASegundos(tiempo1);
                    int segundos2 = ConvertirASegundos(tiempo2);

                    if (segundos1 == -1 || segundos2 == -1)
                    {
                        Console.WriteLine("Formato de hora incorrecto, por favor ingrese en formato HH:MM:SS");
                        Console.ReadKey();
                        continue;
                    }
                    // calcula la diferencia absoluta y la convierte de vuelta a horas, minutos y segundos
                    int diferencia = Math.Abs(segundos1 - segundos2);

                    int horas = diferencia / 3600;
                    diferencia %= 3600;

                    int minutos = diferencia / 60;
                    int segundos = diferencia % 60;

                    Console.WriteLine("\n===== RESULTADO =====");
                    Console.WriteLine($"Tiempo transcurrido: {horas} horas, {minutos} minutos, {segundos} segundos");

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
        }
        // convierte una hora en formato hh:mm:ss a segundos totales
        private int ConvertirASegundos(string tiempo)
        {
            string[] partes = tiempo.Split(':');

            if (partes.Length != 3)
            return -1; // formato incorrecto

            if (!int.TryParse(partes[0], out int horas) ||
                !int.TryParse(partes[1], out int minutos)||
                !int.TryParse(partes[2], out int segundos))
            return -1;

            if (horas < 0 || horas > 23 || minutos < 0 || minutos > 59 || segundos < 0 || segundos > 59)
            return -1; // valores fuera de rango
            // convierte todo a segundos: horas * 3600 + minutos * 60 + segundos
            return horas * 3600 + minutos * 60 + segundos;

    }

    }
}