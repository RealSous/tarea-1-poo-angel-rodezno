using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea1.Ejercicios
{
    public class RotacionArreglo
    {
        private int[] arreglo = null;
        private bool cargado = false;
        // metodo principal que muestra el menu de opciones para manipular el arreglo
        public bool EjecutarRA()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("===== ROTACION DE ARREGLO =====");
                Console.WriteLine("1. Crear y llenar arreglo (N elementos)");
                Console.WriteLine("2. Rotar K posiciones a la izquierda");
                Console.WriteLine("3. Rotar K posiciones a la derecha");
                Console.WriteLine("4. Invertir arreglo");
                Console.WriteLine("5. Mostrar arreglo");
                Console.WriteLine("0. Volver al menu principal");
                Console.Write("Seleccione una opcion: ");

                if (!int.TryParse(Console.ReadLine(), out int opcion))
                {
                    MensajeError();
                    continue;
                }

                switch (opcion)
                {
                    case 0:
                        return true;

                    case 1:
                        CrearYLlenar();
                        break;

                    case 2:
                        if (!VerificarCargado()) break;
                        RotarIzquierda();
                        break;

                    case 3:
                        if (!VerificarCargado()) break;
                        RotarDerecha();
                        break;

                    case 4:
                        if (!VerificarCargado()) break;
                        Invertir();
                        break;

                    case 5:
                        if (!VerificarCargado()) break;
                        MostrarArreglo();
                        break;

                    default:
                        MensajeError();
                        break;
                }

            } while (true);
        }
        // solicita la cantidad de elementos y los valores para llenar el arreglo
        private void CrearYLlenar()
        {
            Console.Clear();
            Console.WriteLine("===== CREAR Y LLENAR ARREGLO =====\n");
            Console.Write("Ingrese N (cantidad de elementos): ");

            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                MensajeError();
                return;
            }

            arreglo = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Ingrese entero {i + 1}: ");
                if (!int.TryParse(Console.ReadLine(), out int valor))
                {
                    MensajeError();
                    i--;
                    continue;
                }
                arreglo[i] = valor;
            }

            cargado = true;

            Console.WriteLine("\nArreglo creado y cargado:");
            MostrarArregloInterno();
            Console.WriteLine("\nPresione enter para continuar");
            Console.ReadKey(true);
        }
        // rota el arreglo k posiciones hacia la izquierda, moviendo los elementos al inicio al final
        private void RotarIzquierda()
        {
            Console.Clear();
            Console.WriteLine("===== ROTAR A LA IZQUIERDA =====\n");
            Console.Write("Ingrese K: ");

            if (!int.TryParse(Console.ReadLine(), out int k) || k < 0)
            {
                MensajeError();
                return;
            }

            int n = arreglo.Length;
            if (n == 0) return;

            k %= n; 
            if (k == 0)
            {
                Console.WriteLine("\nK no cambia el arreglo");
                Console.WriteLine("\nPresione enter para continuar");
                Console.ReadKey(true);
                return;
            }

            int[] nuevo = new int[n];
            // calcula la nueva posicion de cada elemento restandole k
            for (int i = 0; i < n; i++)
            {
                int nuevaPos = i - k;
                if (nuevaPos < 0) nuevaPos += n;
                nuevo[nuevaPos] = arreglo[i];
            }

            arreglo = nuevo;

            Console.WriteLine("\nArreglo rotado a la izquierda:");
            MostrarArregloInterno();
            Console.WriteLine("\nPresione enter para continuar");
            Console.ReadKey(true);
        }
        // rota el arreglo k posiciones hacia la derecha, moviendo los elementos al final al inicio
        private void RotarDerecha()
        {
            Console.Clear();
            Console.WriteLine("===== ROTAR A LA DERECHA =====\n");
            Console.Write("Ingrese K: ");

            if (!int.TryParse(Console.ReadLine(), out int k) || k < 0)
            {
                MensajeError();
                return;
            }

            int n = arreglo.Length;
            if (n == 0) return;

            k %= n;
            if (k == 0)
            {
                Console.WriteLine("\nK no cambia el arreglo");
                Console.WriteLine("\nPresione enter para continuar");
                Console.ReadKey(true);
                return;
            }

            int[] nuevo = new int[n];
            // calcula la nueva posicion de cada elemento sumandole k
            for (int i = 0; i < n; i++)
            {
                int nuevaPos = i + k;
                if (nuevaPos >= n) nuevaPos -= n;
                nuevo[nuevaPos] = arreglo[i];
            }

            arreglo = nuevo;

            Console.WriteLine("\nArreglo rotado a la derecha:");
            MostrarArregloInterno();
            Console.WriteLine("\nPresione enter para continuar");
            Console.ReadKey(true);
        }
        // invierte el orden de los elementos del arreglo intercambiando el primero con el ultimo, el segundo con el penultimo, etc
        private void Invertir()
        {
            Console.Clear();
            Console.WriteLine("===== INVERTIR ARREGLO =====\n");

            int i = 0;
            int j = arreglo.Length - 1;

            while (i < j)
            {
                int temp = arreglo[i];
                arreglo[i] = arreglo[j];
                arreglo[j] = temp;

                i++;
                j--;
            }

            Console.WriteLine("Arreglo invertido:");
            MostrarArregloInterno();
            Console.WriteLine("\nPresione enter para continuar");
            Console.ReadKey(true);
        }
        // muestra todos los elementos del arreglo
        private void MostrarArreglo()
        {
            Console.Clear();
            Console.WriteLine("===== MOSTRAR ARREGLO =====\n");
            MostrarArregloInterno();
            Console.WriteLine("\nPresione enter para continuar");
            Console.ReadKey(true);
        }
        // imprime cada elemento del arreglo con su indice
        private void MostrarArregloInterno()
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine($"Indice {i}: {arreglo[i]}");
            }
        }
        // verifica si el arreglo ha sido creado y llenado antes de realizar operaciones
        private bool VerificarCargado()
        {
            if (!cargado || arreglo == null)
            {
                Console.WriteLine("Debe crear y llenar el arreglo primero");
                Console.WriteLine("Presione enter para continuar");
                Console.ReadKey(true);
                return false;
            }
            return true;
        }
        // muestra mensaje de error cuando los datos son invalidos
        private void MensajeError()
        {
            Console.WriteLine("Dato incorrecto, ingrese un dato valido");
            Console.ReadKey(true);
        }
    }
}
