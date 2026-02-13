using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea1.Ejercicios
{
    public class AreaPerimetro
    {
        // metodo principal que muestra el menu y ejecuta las opciones
        public bool EjecutarAP()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== AREA Y PERIMETRO =====");
                Console.WriteLine("1. Circulo");
                Console.WriteLine("2. Rectangulo");
                Console.WriteLine("3. Triangulo");
                Console.WriteLine("4. Trapecio");
                Console.WriteLine("5. Volver al menu principal");
                Console.Write("Opcion: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        CalcularCirculo();
                        break;
                    case "2":
                        CalcularRectangulo();
                        break;
                    case "3":
                        CalcularTriangulo();
                        break;
                    case "4":
                        CalcularTrapecio();
                        break;

                    case "5":
                        return true; 

                    default:
                        Console.WriteLine("Opcion incorrecta, elija una opcion correcta");
                        Console.ReadKey();
                        break;
                }

            }
        }
        // calcula area y perimetro de un circulo usando el radio
        private void CalcularCirculo()
        {
            Console.Write("Ingrese el radio: ");
            double radio = double.Parse(Console.ReadLine());

            if (radio <= 0)
            {
                Error();
                return;
            }
            // formula: area = pi * r^2, perimetro = 2 * pi * r
            double area = Math.PI * radio * radio;
            double perimetro = 2 * Math.PI * radio;

            MostrarResultado(area, perimetro);
        }
        // calcula area y perimetro de un rectangulo usando base y altura
        private void CalcularRectangulo()
        {
            Console.Write("Ingrese la base: ");
            double baseR = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la altura: ");
            double altura = double.Parse(Console.ReadLine());

            if (baseR <= 0 || altura <= 0)
            {
                Error();
                return;
            }
            // formula: area = base * altura, perimetro = 2 * (base + altura)
            double area = baseR * altura;
            double perimetro = 2 * (baseR + altura);

            MostrarResultado(area, perimetro);
        }
        // calcula area y perimetro de un triangulo usando base, altura y los tres lados
        private void CalcularTriangulo()
        {
            Console.Write("Ingrese la base: ");
            double baseT = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la altura: ");
            double altura = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el lado 2: ");
            double l2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el lado 3: ");
            double l3 = double.Parse(Console.ReadLine());

            if (baseT <= 0 || altura <= 0 || l2 <= 0 || l3 <= 0)
            {
                Error();
                return;
            }
            // formula: area = (base * altura) / 2, perimetro = suma de los tres lados
            double area = (baseT * altura) / 2;
            double perimetro = baseT + l2 + l3;

            MostrarResultado(area, perimetro);
        }
        // calcula area y perimetro de un trapecio usando las dos bases, altura y los lados
        private void CalcularTrapecio()
        {
            Console.Write("Ingrese la base mayor: ");
            double baseMayor = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la base menor: ");
            double baseMenor = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la altura: ");
            double altura = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el lado 1: ");
            double l1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el lado 2: ");
            double l2 = double.Parse(Console.ReadLine());

            if (baseMayor <= 0 || baseMenor <= 0 || altura <= 0 || l1 <= 0 || l2 <= 0)
            {
                Error();
                return;
            }
            // formula: area = ((base mayor + base menor) * altura) / 2, perimetro = suma de todos los lados
            double area = ((baseMayor + baseMenor) * altura) / 2;
            double perimetro = baseMayor + baseMenor + l1 + l2;

            MostrarResultado(area, perimetro);
        }
        // muestra los resultados del area y perimetro calculados
        private void MostrarResultado(double area, double perimetro)
        {
            Console.WriteLine("\nArea: {area:F2}");
            Console.WriteLine("Perimetro: {perimetro:F2}");
            Console.WriteLine("\nPresione enter para continuar");
                Console.ReadKey();
        }
        // muestra mensaje de error cuando los valores no son validos
        private void Error()
        {
            Console.WriteLine("\nTodos los valores deben ser positivos");
            Console.ReadKey();
        }
    }

}

    
                