using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea1.Ejercicios
{
    public class ConvAlmacenamiento
    {
        // metodo principal que solicita la unidad origen, el valor y la unidad destino para realizar la conversion
        public bool EjecutarCvA()
        {
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("===== CONVERSION DE ALMACENAMIENTO ===");
                Console.WriteLine("1. Bytes");
                Console.WriteLine("2. Kilobytes (KB)");
                Console.WriteLine("3. Megabytes (MB)");
                Console.WriteLine("4. Gigabytes (GB)");
                Console.WriteLine("5. Terabytes (TB)");
                Console.WriteLine("6. Volver al menu principal");
                Console.Write("Seleccione la unidad de origen: ");
                
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Entrada no valida, por favor ingrese una opcion correcta");
                    Console.ReadKey();
                    continue;
                }

                if (opcion == 6)
                    return true; // volver al menú principal

                switch (opcion)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta, elija una opcion correcta");
                        Console.ReadKey();
                        continue;
                }

                Console.Write("Ingrese el valor a convertir: ");
                double valor = double.Parse(Console.ReadLine());

                if (valor <= 0)
                {
                    Console.WriteLine("El valor debe ser mayor que 0");
                    Console.ReadKey();
                    continue;
                }

                Console.WriteLine("\nConvertir a:");
                Console.WriteLine("1. Bytes");
                Console.WriteLine("2. Kilobytes (KB)");
                Console.WriteLine("3. Megabytes (MB)");
                Console.WriteLine("4. Gigabytes (GB)");
                Console.WriteLine("5. Terabytes (TB)");
                Console.Write("Seleccione la unidad destino: ");
                
                if (!int.TryParse(Console.ReadLine(), out int destino))
                {
                    Console.WriteLine("Entrada no valida, por favor ingrese una opcion correcta");
                    Console.ReadKey();
                    continue;
                }

                switch (destino)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta, elija una opcion correcta");
                        Console.ReadKey();
                        continue;
                }
            // primero convierte todo a bytes multiplicando por 1024 segun la unidad origen
            double bytes = opcion switch
            {
                1 => valor,
                2 => valor * 1024,
                3 => valor * 1024 * 1024,
                4 => valor * 1024 * 1024 * 1024,
                5 => valor * (1024.0 * 1024 * 1024 * 1024), // evita overflow
                _ => 0
            };
            // luego convierte de bytes a la unidad destino dividiendo por 1024 segun corresponda
            double resultado = destino switch
            {
                1 => bytes,
                2 => bytes / 1024,
                3 => bytes / (1024 * 1024),
                4 => bytes / (1024 * 1024 * 1024),
                5 => bytes / (1024.0 * 1024 * 1024 * 1024), // evita overflow
                _ => 0
            };

            Console.WriteLine($"\nResultado: {resultado:F4}");
            Console.WriteLine("\nPresione enter para continuar");
            Console.ReadKey(true);
        } while (true);
    }
    }
}

    
