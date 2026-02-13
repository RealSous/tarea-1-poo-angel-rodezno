using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea1.Ejercicios
{
    public class CajeroAutomatico
    {
        private double saldo = 10000.00; // saldo inicial de la cuenta
        // metodo principal que muestra el menu del cajero
        public bool EjecutarCA()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== CAJERO AUTOMATICO =====");
                Console.WriteLine($"Saldo actual: L {saldo:F2}");
                Console.WriteLine("\nOpciones:");
                Console.WriteLine("1. Retirar dinero");
                Console.WriteLine("2. Volver al menu principal");
                Console.WriteLine("3. Salir");
                Console.Write("Opcion: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        RetirarDinero();
                        break;
                    case "2":
                        return true; 
                    case "3":
                        return false; 
                    default:
                        Console.WriteLine("Opcion incorrecta, escoja una opcion correcta");
                        Console.ReadKey();
                        break;
                }
            }
        }
        // procesa el retiro de dinero validando el monto y el saldo disponible
        private void RetirarDinero()
        {
            Console.Clear();
            Console.WriteLine("===== RETIRAR DINERO =====");
            Console.Write("Ingrese el monto a retirar: ");
            if (double.TryParse(Console.ReadLine(), out double monto))
            {
                // valida que el monto sea positivo, no exceda el saldo y sea multiplo de 20
                if (monto > 0 && monto <= saldo && monto % 20 == 0)
                {
                    saldo -= monto;
                    Console.WriteLine($"Retiro exitoso, nuevo saldo: L {saldo:F2}");
                    DesglosarBilletes(monto);
                }
                else if (monto > saldo)
                {
                    Console.WriteLine("Saldo insuficiente");
                }
                else
                {
                    Console.WriteLine("Monto invalido, ingrese un monto correcto (multiplo de 20)");
                }
            }
            else
            {
                Console.WriteLine("Monto invalido, ingrese un monto correcto");
            }
            Console.ReadKey();
        }

        // desglosa el monto retirado en billetes de diferentes denominaciones
        private void DesglosarBilletes(double monto)
        {
            int[] billetes = { 500, 100, 50, 20, 10, 5, 2, 1 };
            Console.WriteLine("\nDesglose de billetes:");
            // calcula cuantos billetes de cada denominacion se necesitan
            foreach (int billete in billetes)
            {
                int cantidad = (int)(monto / billete);
                if (cantidad > 0)
                {
                    Console.WriteLine($"{cantidad} billete(s) de L {billete}");
                    monto %= billete;
                }
            }
        }
    }
}
