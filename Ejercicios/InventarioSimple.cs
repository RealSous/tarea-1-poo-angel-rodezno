using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea1.Ejercicios
{
    public class InventarioSimple
    {
        private int[] codigos = new int[5];
        private string[] nombres = new string[5];
        private int[] cantidades = new int[5];
        private double[] precios = new double[5];
        private bool inicializado = false;
        // metodo principal que muestra el menu de opciones del inventario
        public bool EjecutarInvS()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("===== INVENTARIO SIMPLE =====");
                Console.WriteLine("1. Inicializar productos");
                Console.WriteLine("2. Mostrar inventario");
                Console.WriteLine("3. Buscar producto");
                Console.WriteLine("4. Actualizar cantidad");
                Console.WriteLine("5. Calcular valor total del inventario");
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
                        Inicializar();
                        break;

                    case 2:
                        if (!VerificarInicializado()) break;
                        MostrarInventario();
                        break;

                    case 3:
                        if (!VerificarInicializado()) break;
                        BuscarProducto();
                        break;

                    case 4:
                        if (!VerificarInicializado()) break;
                        ActualizarCantidad();
                        break;

                    case 5:
                        if (!VerificarInicializado()) break;
                        CalcularValorTotal();
                        break;

                    default:
                        MensajeError();
                        break;
                }

            } while (true);
        }

        private void Inicializar()
        {
            Console.Clear();
            Console.WriteLine("===== REGISTRO DE PRODUCTOS =====\n");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Codigo del producto {i + 1}: ");
                if (!int.TryParse(Console.ReadLine(), out int cod))
                {
                    MensajeError();
                    i--;
                    continue;
                }

                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("Cantidad: ");
                if (!int.TryParse(Console.ReadLine(), out int cant) || cant < 0)
                {
                    MensajeError();
                    i--;
                    continue;
                }

                Console.Write("Precio: ");
                if (!double.TryParse(Console.ReadLine(), out double precio) || precio < 0)
                {
                    MensajeError();
                    i--;
                    continue;
                }

                codigos[i] = cod;
                nombres[i] = nombre;
                cantidades[i] = cant;
                precios[i] = precio;
            }

            inicializado = true;

            Console.WriteLine("\nProductos registrados correctamente");
            Console.WriteLine("Presione enter para continuar");
            Console.ReadKey(true);
        }

        private void MostrarInventario()
        {
            Console.Clear();
            Console.WriteLine("===== INVENTARIO =====\n");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Codigo: {codigos[i]}");
                Console.WriteLine($"Nombre: {nombres[i]}");
                Console.WriteLine($"Cantidad: {cantidades[i]}");
                Console.WriteLine($"Precio: {precios[i]:F2}");
            }

            Console.WriteLine("Presione enter para continuar");
            Console.ReadKey(true);
        }

        private void BuscarProducto()
        {
            Console.Clear();
            Console.Write("Ingrese codigo a buscar: ");

            if (!int.TryParse(Console.ReadLine(), out int codigo))
            {
                MensajeError();
                return;
            }

            for (int i = 0; i < 5; i++)
            {
                if (codigos[i] == codigo)
                {
                    Console.WriteLine("\nProducto encontrado:");
                    Console.WriteLine($"Nombre: {nombres[i]}");
                    Console.WriteLine($"Cantidad: {cantidades[i]}");
                    Console.WriteLine($"Precio: {precios[i]:F2}");
                    Console.WriteLine("\nPresione enter para continuar");
                    Console.ReadKey(true);
                    return;
                }
            }

            Console.WriteLine("El producto no se encontro");
            Console.WriteLine("Presione enter para continuar");
            Console.ReadKey(true);
        }

        private void ActualizarCantidad()
        {
            Console.Clear();
            Console.Write("Ingrese codigo del producto: ");

            if (!int.TryParse(Console.ReadLine(), out int codigo))
            {
                MensajeError();
                return;
            }

            for (int i = 0; i < 5; i++)
            {
                if (codigos[i] == codigo)
                {
                    Console.Write("Nueva cantidad: ");
                    if (!int.TryParse(Console.ReadLine(), out int nuevaCant) || nuevaCant < 0)
                    {
                        MensajeError();
                        return;
                    }

                    cantidades[i] = nuevaCant;
                    Console.WriteLine("La cantidad se actualizo correctamente");
                    Console.WriteLine("Presione enter para continuar");
                    Console.ReadKey(true);
                    return;
                }
            }

            Console.WriteLine("El producto no se encontro");
            Console.WriteLine("Presione enter para continuar");
            Console.ReadKey(true);
        }

        private void CalcularValorTotal()
        {
            Console.Clear();
            double total = 0;

            for (int i = 0; i < 5; i++)
            {
                total += cantidades[i] * precios[i];
            }

            Console.WriteLine($"Valor total del inventario: {total:F2}");
            Console.WriteLine("Presione enter para continuar");
            Console.ReadKey(true);
        }

        private bool VerificarInicializado()
        {
            if (!inicializado)
            {
                Console.WriteLine("Debe ingresar los productos primero");
                Console.WriteLine("Presione enter para continuar");
                Console.ReadKey(true);
                return false;
            }
            return true;
        }

        private void MensajeError()
        {
            Console.WriteLine("Dato incorrecto, ingrese un dato valido");
            Console.ReadKey(true);
        }
    }
}

