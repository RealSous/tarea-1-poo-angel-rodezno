using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea1.Ejercicios
{
    public class CalculadoraDescuentos
    {
        // metodo principal que calcula el descuento aplicable
        public bool EjecutarCD()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("===== CALCULADORA DE DESCUENTOS =====");

                Console.Write("Ingrese el monto de compra: ");
                if (!double.TryParse(Console.ReadLine(), out double monto) || monto <= 0)
                {
                    Console.WriteLine("El monto ingresado no es correcto, ingrese un valor valido");
                    Console.ReadKey(true);
                    continue;
                }

                if (monto == 0)
                    return true;

                double porcentajeDescuento = 0;

                // determina el porcentaje de descuento segun el monto: 15% si es mayor a 2500, 10% si es mayor a 1000, 5% si es mayor a 500
                if (monto >= 2500)
                    porcentajeDescuento = 0.15;
                else if (monto >= 1000)
                    porcentajeDescuento = 0.10;
                else if (monto >= 500)
                    porcentajeDescuento = 0.05;

                double descuento = monto * porcentajeDescuento;
                double precioFinal = monto - descuento;

                // Resultado
                Console.WriteLine("\n===== RESULTADO =====");
                Console.WriteLine($"Precio original : L {monto:F2}");
                Console.WriteLine($"Descuento aplicado : {porcentajeDescuento * 100}%");
                Console.WriteLine($"Monto de descuento : L {descuento:F2}");
                Console.WriteLine($"Precio final : L {precioFinal:F2}");

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

            } while (true);
        }
    }
}    
        