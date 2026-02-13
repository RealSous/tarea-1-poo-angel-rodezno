using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea1.Ejercicios
{
    public class ClasificarTriangulos
    {
        // metodo principal que solicita los lados del triangulo y lo clasifica
        public bool EjecutarCT()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("===== CLASIFICACION DE TRIANGULOS =====");
                Console.WriteLine("Ingrese los lados del triangulo");

                Console.Write("Base del Triangulo: ");
                if (!double.TryParse(Console.ReadLine(),out double a) || a <= 0)
                {
                    Error();
                    continue;
                }

                if (a == 0) return true;

                Console.Write("Lado 1: ");
                if (!double.TryParse(Console.ReadLine(),out double b) || b <= 0)
                {
                    Error();
                    continue;
                }

                Console.Write("Lado 2: ");
                if (!double.TryParse(Console.ReadLine(),out double c) || c <= 0)
                {
                    Error();
                    continue;
                }

                if (!EsTrianguloValido(a, b, c))
                {
                    Console.WriteLine("Los lados ingresados no forman un triangulo valido");
                    Console.ReadKey(true);
                    continue;
                }

                // clasifica por lados: equilatero (3 lados iguales), isosceles (2 lados iguales), escaleno (todos diferentes)
                string tipoLados;
                if (a == b && b == c)
                    tipoLados = "Es Equilatero";
                else if (a == b || a == c || b == c)
                    tipoLados = "Es Isosceles";
                else    
                    tipoLados = " Es Escaleno";

                // clasifica por angulos usando el teorema de pitagoras
                string tipoAngulos = ClasificarPorAngulos(a, b, c);

                // Resultado
                Console.WriteLine("\n===== RESULTADO =====");
                Console.WriteLine($"Por lados : {tipoLados}" );
                Console.WriteLine($"Por angulos : {tipoAngulos}" );

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
        // verifica que los tres lados puedan formar un triangulo valido usando la desigualdad triangular
        private bool EsTrianguloValido(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
        // clasifica el triangulo por angulos: rectangulo (90 grados), acutangulo (todos menores a 90), obtusangulo (uno mayor a 90)
        private string ClasificarPorAngulos(double a, double b, double c)
        {
            // ordena los lados para que el mayor sea el ultimo
            double[] lados = { a, b, c };
            Array.Sort(lados);

            double x = lados[0];
            double y = lados[1];
            double z = lados[2]; 
            // usa el teorema de pitagoras: si a^2 + b^2 = c^2 es rectangulo, si es menor es acutangulo, si es mayor es obtusangulo
            double sumaCuadrados = x * x + y * y;
            double mayorCuadrado = z * z;

            if (Math.Abs(mayorCuadrado - sumaCuadrados) < 0.0001)
                return "Es Rectangulo";
            else if (mayorCuadrado < sumaCuadrados)
                return "Es Acutangulo";
            else
                return "Es Obtusangulo";
        }
        // muestra mensaje de error cuando los datos son invalidos
        private void Error()
        {
            Console.WriteLine("Datos incorrectos, intente de nuevo");
            Console.ReadKey(true);
        }
    }
}




                
            