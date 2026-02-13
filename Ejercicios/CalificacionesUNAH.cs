using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea1.Ejercicios
{
    public class CalificacionesUNAH
    {
        // metodo principal que solicita la calificacion y muestra su equivalente en letra
        public bool EjecutarCalUNAH()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("===== CALIFICACIONES UNAH =====");
                Console.Write("Ingrese la calificación (0-100): ");
                if (!double.TryParse(Console.ReadLine(), out double calificacion) || calificacion < 0 || calificacion > 100)
                {
                    Error();
                    continue;
                }

                if (calificacion == 0) return true;

                Console.WriteLine("\n===== RESULTADO =====");
                string notaLetra = GetLetterGrade(calificacion);
                string descripcion = GetDescription(calificacion);
                string estado = calificacion >= 60 ? "Aprobado" : "Reprobado";
                Console.WriteLine("Letra: {notaLetra}");
                Console.WriteLine("Descripción: {descripcion}");
                Console.WriteLine("Estado: {estado}");

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
        // convierte la calificacion numerica a letra: a (90-100), b (80-89), c (70-79), d (60-69), f (0-59)
        private string GetLetterGrade(double calificacion)
        {
            if (calificacion >= 90) return "A";
            else if (calificacion >= 80) return "B";
            else if (calificacion >= 70) return "C";
            else if (calificacion >= 60) return "D";
            else return "F";
        }
        // retorna una descripcion del rendimiento segun la calificacion
        private string GetDescription(double calificacion)
        {
            if (calificacion >= 90) return "Excelente";
            else if (calificacion >= 80) return "Muy Bueno";
            else if (calificacion >= 70) return "Bueno";
            else if (calificacion >= 60) return "Satisfactorio";
            else return "Insuficiente";
        }
        // muestra mensaje de error cuando los datos son invalidos
        private void Error()
        {
            Console.WriteLine("Datos incorrectos, intente de nuevo");
            Console.ReadKey(true);
        }
    }
}