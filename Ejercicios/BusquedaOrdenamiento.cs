using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea1.Ejercicios
{
    public class BusquedaOrdenamiento
    {
        private int[] arreglo = new int[10];
        private bool cargado = false;
        // metodo principal que muestra el menu de opciones
        public bool EjecutarBO()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== BUSQUEDA Y ORDENAMIENTO =====");
                Console.WriteLine("1. Llenar arreglo de 10 enteros");
                Console.WriteLine("2. Busqueda lineal");
                Console.WriteLine("3. Encontrar segundo mayor");
                Console.WriteLine("4. Ordenar ascendente (burbuja)");
                Console.WriteLine("5. Mostrar elementos en posiciones pares");
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
                        LlenarArreglo();
                        break;

                    case 2:
                        if (!VerificarCargado()) break;
                        BusquedaLineal();
                        break;

                    case 3:
                        if (!VerificarCargado()) break;
                        SegundoMayor();
                        break;

                    case 4:
                        if (!VerificarCargado()) break;
                        OrdenarBurbujaAsc();
                        Console.WriteLine("\nArreglo ordenado ascendente:");
                        MostrarArreglo(arreglo);
                        Console.WriteLine("\nPresione enter para continuar");
                        Console.ReadKey(true);
                        break;

                    case 5:
                        if (!VerificarCargado()) break;
                        MostrarPosicionesPares();
                        break;

                    default:
                        MensajeError();
                        break;
                }

            }
        }
        // solicita al usuario 10 numeros enteros y los almacena en el arreglo
        private void LlenarArreglo()
        {
            Console.Clear();
            Console.WriteLine("===== LLENAR ARREGLO =====\n");

            for (int i = 0; i < arreglo.Length; i++)
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

            Console.WriteLine("\nArreglo cargado:");
            MostrarArreglo(arreglo);
            Console.WriteLine("\nPresione enter para continuar");
            Console.ReadKey(true);
        }
        // busca un valor en el arreglo recorriendo elemento por elemento
        private void BusquedaLineal()
        {
            Console.Clear();
            Console.WriteLine("===== BUSQUEDA LINEAL =====\n");

            Console.Write("Ingrese el valor a buscar: ");
            if (!int.TryParse(Console.ReadLine(), out int buscado))
            {
                MensajeError();
                return;
            }
            // recorre el arreglo hasta encontrar el valor o llegar al final
            int indice = -1;
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] == buscado)
                {
                    indice = i;
                    break;
                }
            }

            if (indice == -1)
                Console.WriteLine("\nNo se encontro el valor en el arreglo");
            else
                Console.WriteLine($"\nSe encontro el valor en la posicion: {indice}");

            Console.WriteLine("\nArreglo actual:");
            MostrarArreglo(arreglo);

            Console.WriteLine("\nPresione enter para continuar");
            Console.ReadKey(true);
        }
        // encuentra el segundo numero mas grande del arreglo
        private void SegundoMayor()
        {
            Console.Clear();
            Console.WriteLine("===== SEGUNDO MAYOR =====\n");

            int mayor = arreglo[0];
            int segundo = arreglo[0];
            bool existeSegundo = false;
            // recorre el arreglo comparando cada elemento con el mayor y segundo mayor
            for (int i = 0; i < arreglo.Length; i++)
            {
                int x = arreglo[i];

                if (x > mayor)
                {
                    segundo = mayor;
                    mayor = x;
                    existeSegundo = true;
                }
                else if (x < mayor) // evita repetir el mayor
                {
                    if (!existeSegundo || x > segundo)
                    {
                        segundo = x;
                        existeSegundo = true;
                    }
                }
            }

            if (!existeSegundo)
                Console.WriteLine("No existe segundo mayor");
            else
                Console.WriteLine($"Segundo mayor: {segundo}");

            Console.WriteLine("\nArreglo actual:");
            MostrarArreglo(arreglo);

            Console.WriteLine("\nPresione enter para continuar");
            Console.ReadKey(true);
        }
        // ordena el arreglo de menor a mayor usando el algoritmo de burbuja
        private void OrdenarBurbujaAsc()
        {
            // compara elementos adyacentes y los intercambia si estan en orden incorrecto
            for (int i = 0; i < arreglo.Length - 1; i++)
            {
                for (int j = 0; j < arreglo.Length - 1 - i; j++)
                {
                    if (arreglo[j] > arreglo[j + 1])
                    {
                        int temp = arreglo[j];
                        arreglo[j] = arreglo[j + 1];
                        arreglo[j + 1] = temp;
                    }
                }
            }
        }
        // muestra solo los elementos que estan en indices pares (0, 2, 4, 6, 8)
        private void MostrarPosicionesPares()
        {
            Console.Clear();
            Console.WriteLine("===== ELEMENTOS EN POSICIONES PARES =====\n");
            Console.WriteLine("Nota: posiciones pares se refiere a indices pares: 0, 2, 4, 6, 8\n");

            for (int i = 0; i < arreglo.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"Indice {i}: {arreglo[i]}");
                }
            }

            Console.WriteLine("\nPresione enter para continuar");
            Console.ReadKey(true);
        }
        // verifica si el arreglo ha sido llenado antes de realizar operaciones
        private bool VerificarCargado()
        {
            if (!cargado)
            {
                Console.WriteLine("Debe llenar el arreglo primero");
                Console.WriteLine("Presione enter para continuar");
                Console.ReadKey(true);
                return false;
            }
            return true;
        }
        // muestra todos los elementos del arreglo con sus indices
        private void MostrarArreglo(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Indice {i}: {arr[i]}");
            }
        }
        // muestra mensaje de error cuando el dato ingresado no es valido
        private void MensajeError()
        {
            Console.WriteLine("Dato incorrecto, ingrese un dato valido");
            Console.ReadKey(true);
        }
    }
}