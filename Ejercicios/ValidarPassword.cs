using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea1.Ejercicios
{
    public class ValidarPassword
    {
        // metodo principal que solicita una contraseña y verifica que cumpla los requisitos
        public bool EjecutarVP()
        {
            bool continuarValidando = true;
            while (continuarValidando)
            {
                Console.Clear();
                Console.WriteLine("===== VALIDADOR DE CONTRASEÑA =====");
                Console.WriteLine("La contraseña debe tener:");
                Console.WriteLine("- Minimo 8 caracteres");
                Console.WriteLine("- Al menos una mayuscula");
                Console.WriteLine("- Al menos una minuscula");
                Console.WriteLine("- Al menos un numero");
                Console.WriteLine("- Al menos un caracter especial");
                Console.Write("Ingresa una contraseña: ");
                string password = Console.ReadLine();

                List<string> faltantes = new List<string>();

                if (password.Length < 8)
                    faltantes.Add("Minimo 8 caracteres");
                // verifica cada caracter para determinar si tiene mayusculas, minusculas, numeros y caracteres especiales
                bool hasUpper = false, hasLower = false, hasDigit = false, hasSpecial = false;
                foreach (char c in password)
                {
                    if (char.IsUpper(c)) hasUpper = true;
                    if (char.IsLower(c)) hasLower = true;
                    if (char.IsDigit(c)) hasDigit = true;
                    if (!char.IsLetterOrDigit(c)) hasSpecial = true;
                }

                if (!hasUpper) faltantes.Add("Al menos una mayuscula");
                if (!hasLower) faltantes.Add("Al menos una minuscula");
                if (!hasDigit) faltantes.Add("Al menos un numero");
                if (!hasSpecial) faltantes.Add("Al menos un caracter especial");

                if (faltantes.Count == 0)
                {
                    Console.WriteLine("La contraseña es correcta");
                    continuarValidando = false;
                }
                else
                {
                    Console.WriteLine("La contraseña no cumple con los siguientes requisitos:");
                    foreach (string falta in faltantes)
                    {
                        Console.WriteLine("- " + falta);
                    }
                    Console.WriteLine("Presiona cualquier tecla para intentar de nuevo");
                    Console.ReadKey();
                }
            }

            Console.WriteLine("\nOpciones:");
            Console.WriteLine("1. Validar otra contraseña");
            Console.WriteLine("2. Volver al menu principal");
            Console.WriteLine("3. Salir");
            Console.Write("Opcion: ");

            string opcion = Console.ReadLine();

            if (opcion == "1")
                return EjecutarVP(); 
            else if (opcion == "2")
                return true; 
            else if (opcion == "3")
                return false; 
            else
            {
                Console.WriteLine("Opcion incorrecta, volviendo al menu principal");
                Console.ReadKey();
                return true;
            }
        }
    }
}