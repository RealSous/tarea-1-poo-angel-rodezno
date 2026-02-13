using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea1.Ejercicios
{
    public class dsgBilletes
    {
        // metodo principal que solicita un monto y lo desglosa en billetes
        public bool EjecutarDsg()
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== DESGLOSE DE BILLETES =====");


                Console.WriteLine("1. Ingresar monto");
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
                    Console.Write("Ingrese el monto en lempiras: ");
                    int monto = int.Parse(Console.ReadLine());

                    int[] billetes = { 500, 100, 50, 20, 10, 5, 2, 1 };

                    Console.WriteLine("\nDesglose:");
                    // calcula cuantos billetes de cada denominacion se necesitan, empezando por los mas grandes
                    foreach (int billete in billetes)
                    {
                        int cantidad = monto / billete;
                        if (cantidad > 0)
                        {
                            Console.WriteLine($"{cantidad} billete(s) de L {billete}");
                            monto %= billete;
                        }

                        else if (cantidad == 0)
                        {
                            Console.WriteLine($"0 billete(s) de L {billete}");
                        }

                    }

                
                
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

    }

    }

}