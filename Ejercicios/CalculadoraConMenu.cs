using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace Tarea1.Ejercicios
{
    public class CalculadoraConMenu
    {
        private double resultado = 0;
        // metodo principal que muestra el menu de operaciones
        public bool EjecutarCCM()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("===== CALCULADORA ENCADENADA =====");
                Console.WriteLine($"Resultado actual: {resultado:F4}\n");

                Console.WriteLine("1. Ingresar o cambiar valor actual");
                Console.WriteLine("2. Sumar");
                Console.WriteLine("3. Restar");
                Console.WriteLine("4. Multiplicar");
                Console.WriteLine("5. Dividir");
                Console.WriteLine("6. Potencia");
                Console.WriteLine("7. Raiz cuadrada");
                Console.WriteLine("8. Porcentaje");
                Console.WriteLine("9. Reiniciar resultado");
                Console.WriteLine("0. Salir");
                Console.Write("\nOpcion: ");

                if (!int.TryParse(Console.ReadLine(), out int opcion))
                {
                    Mensaje("Opcion invalida");
                    continue;
                }

                switch (opcion)
                {
                    case 0:
                        return true;

                    case 1:
                        CambiarValorActual();
                        break;

                    case 2:
                        OpBinaria((a, b) => a + b);
                        break;

                    case 3:
                        OpBinaria((a, b) => a - b);
                        break;

                    case 4:
                        OpBinaria((a, b) => a * b);
                        break;

                    case 5:
                        Dividir();
                        break;

                    case 6:
                        Potencia();
                        break;

                    case 7:
                        RaizCuadrada();
                        break;

                    case 8:
                        Porcentaje();
                        break;

                    case 9:
                        resultado = 0;
                        Mensaje("El resultado se ha reiniciado con exito");
                        break;

                    default:
                        Mensaje("Opcion incorrecta, elija una opcion valida");
                        break;
                }

            } while (true);
        }

        private void CambiarValorActual()
        {
            Console.Write("\nIngrese el nuevo valor actual: ");
            if (!double.TryParse(Console.ReadLine(), out double valor))
            {
                Mensaje("Dato invalido, ingrese un valor correcto");
                return;
            }

            resultado = valor;
            Mensaje("El valor se ha actualizado con exito");
        }

        private void OpBinaria(Func<double, double, double> op)
        {
            Console.Write("\nIngrese el segundo numero: ");
            if (!double.TryParse(Console.ReadLine(), out double b))
            {
                Mensaje("Dato invalido, ingrese un valor correcto");
                return;
            }

            resultado = op(resultado, b);
            Mensaje("La operacion se ha realizado con exito");
        }

        private void Dividir()
        {
            Console.Write("\nIngrese el divisor: ");
            if (!double.TryParse(Console.ReadLine(), out double b))
            {
                Mensaje("Dato invalido, ingrese un valor correcto");
                return;
            }

            if (b == 0)
            {
                Mensaje("No se puede dividir entre 0");
                return;
            }

            resultado = resultado / b;
            Mensaje("La operacion se ha realizado con exito");
        }

        private void Potencia()
        {
            Console.Write("\nIngrese el exponente: ");
            if (!double.TryParse(Console.ReadLine(), out double exp))
            {
                Mensaje("Dato invalido, ingrese un valor correcto");
                return;
            }

            resultado = Math.Pow(resultado, exp);
            Mensaje("La operacion se ha realizado con exito");
        }

        private void RaizCuadrada()
        {
            if (resultado < 0)
            {
                Mensaje("No se puede sacar raiz de numero negativo");
                return;
            }

            resultado = Math.Sqrt(resultado);
            Mensaje("La operacion se ha realizado con exito");
        }

        private void Porcentaje()
        {
            Console.WriteLine("\n1. Calcular p por ciento del resultado");
            Console.WriteLine("2. Aumentar resultado en p por ciento");
            Console.WriteLine("3. Disminuir resultado en p por ciento");
            Console.Write("Opcion: ");

            if (!int.TryParse(Console.ReadLine(), out int opc))
            {
                Mensaje("Opcion incorrecta, elija una opcion valida");
                return;
            }

            Console.Write("Ingrese el porcentaje: ");
            if (!double.TryParse(Console.ReadLine(), out double p))
            {
                Mensaje("Dato invalido, ingrese un valor correcto");
                return;
            }

            switch (opc)
            {
                case 1:
                    resultado = resultado * (p / 100.0);
                    break;

                case 2:
                    resultado = resultado + (resultado * (p / 100.0));
                    break;

                case 3:
                    resultado = resultado - (resultado * (p / 100.0));
                    break;

                default:
                    Mensaje("Opcion incorrecta, elija una opcion valida");
                    return;
            }

            Mensaje("La operacion se ha realizado con exito");
        }

        private void Mensaje(string texto)
        {
            Console.WriteLine($"\n{texto}");
            Console.WriteLine("Presione enter para continuar");
            Console.ReadKey(true);
        }
    }
}
