using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea1.Ejercicios
{
    public class JuegoAdivinanza
    {
        // metodo principal que ejecuta el juego de adivinanza
        public bool EjecutarJA()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== JUEGO DE ADIVINANZA =====");
                Console.WriteLine("Adivina el numero entre 1 y 100 que estoy pensando");

                Random random = new Random();
                int numeroSecreto = random.Next(1, 101);
                int intentos = 0;
                bool adivinado = false;
                // permite hasta 7 intentos para adivinar el numero
                while (!adivinado && intentos < 7)
                {
                    Console.Write("Ingresa tu adivinanza: ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out int adivinanza))
                    {
                        intentos++;
                        if (adivinanza < numeroSecreto)
                        {
                            if (intentos < 7)
                                Console.WriteLine("Demasiado bajo, intenta de nuevo");
                        }
                        else if (adivinanza > numeroSecreto)
                        {
                            if (intentos < 7)
                                Console.WriteLine("Demasiado alto, intenta de nuevo");
                        }
                        else
                        {
                            Console.WriteLine($"Felicidades! Adivinaste el numero en {intentos} intentos");
                            adivinado = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ingresa un numero valido");
                    }
                }

                if (!adivinado)
                {
                    Console.WriteLine($"No adivinaste el numerero, era {numeroSecreto}.");
                }

                Console.WriteLine("\nOpciones:");
                Console.WriteLine("1. Jugar de nuevo");
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