using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;

namespace Tarea1.Ejercicios
{
    public class CalculadoraIMC
    {

        private double peso;
        private double altura;  

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }
        // calcula el imc usando la formula: peso / (altura^2)
        public double CalcularIMC()
        {
            return peso / (altura * altura);
        }
        // metodo principal que solicita datos y calcula el imc
    public bool EjecutarIMC()
    {
        while (true)
            {
            
            CalculadoraIMC persona = new CalculadoraIMC();

            Console.Clear();
            Console.WriteLine("===== CALCULADORA DE IMC =====");

            Console.WriteLine("Ingrese su peso en kilogramos:");
            Peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su altura en metros:");
            Altura = double.Parse(Console.ReadLine());

            if (peso <= 0 || altura <= 0)
        {
            Console.WriteLine("El peso y la altura deben ser valores positivos");
            Console.ReadKey();
            continue;
        }

            double imc = CalcularIMC();
            Console.WriteLine("Su Indice de Masa Corporal es: " + imc);

            Console.WriteLine("\nOpciones:");
            Console.WriteLine("1. Calcular nuevamente");
            Console.WriteLine("2. Volver al menu principal");
            Console.WriteLine("3. Salir");
            Console.Write("Opcion: ");

            string opcion = Console.ReadLine();

            if (opcion == "1")
                continue;
            
            else if (opcion == "2")
                return true; // Volver al menú principal
            
            else if (opcion == "3")
                return false; // Salir del programa
            
            else
               {
                Console.WriteLine("Opcion incorrecta, volviendo al menu principal");
                Console.ReadKey(); 
            }

    }

    }

    }

}