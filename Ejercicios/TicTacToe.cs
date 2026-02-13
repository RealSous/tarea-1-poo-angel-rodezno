using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea1.Ejercicios
{
    public class TicTacToe
    {
        private char[,] tablero = new char[3, 3];
        private char jugadorActual = 'X';
        // metodo principal que muestra el menu del juego
        public bool EjecutarTTT()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("===== JUEGO DEL GATO (TIC TAC TOE) =====");
                Console.WriteLine("1. Jugar");
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
                        Jugar();
                        break;

                    default:
                        MensajeError();
                        break;
                }

            } while (true);
        }
        // controla el flujo del juego: turnos, movimientos, verificacion de ganador y empate
        private void Jugar()
        {
            InicializarTablero();
            jugadorActual = 'X';

            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== TIC TAC TOE =====\n");
                MostrarTablero();
                Console.WriteLine($"\nTurno del jugador: {jugadorActual}");

                int fila = PedirNumero("Ingrese fila (1-3): ");
                if (fila == -1) { MensajeError(); continue; }

                int col = PedirNumero("Ingrese columna (1-3): ");
                if (col == -1) { MensajeError(); continue; }

                fila -= 1;
                col -= 1;

                if (!MovimientoValido(fila, col))
                {
                    Console.WriteLine("Dato incorrecto, ingrese un dato valido");
                    Console.ReadKey(true);
                    continue;
                }

                tablero[fila, col] = jugadorActual;

                if (HayGanador())
                {
                    Console.Clear();
                    Console.WriteLine("===== TIC TAC TOE =====\n");
                    MostrarTablero();
                    Console.WriteLine($"\nGanador: Jugador {jugadorActual}");
                    if (MenuReiniciar()) return;
                    InicializarTablero();
                    jugadorActual = 'X';
                    continue;
                }

                if (EsEmpate())
                {
                    Console.Clear();
                    Console.WriteLine("===== TIC TAC TOE =====\n");
                    MostrarTablero();
                    Console.WriteLine("\nEmpate");
                    if (MenuReiniciar()) return;
                    InicializarTablero();
                    jugadorActual = 'X';
                    continue;
                }

                CambiarJugador();
            }
        }
        // llena el tablero con espacios vacios para iniciar un nuevo juego
        private void InicializarTablero()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    tablero[i, j] = ' ';
        }
        // muestra el tablero de juego con las marcas de los jugadores
        private void MostrarTablero()
        {
            Console.WriteLine("   1   2   3");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{i + 1}  ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(tablero[i, j]);
                    if (j < 2) Console.Write(" | ");
                }
                Console.WriteLine();
                if (i < 2) Console.WriteLine("  ---+---+---");
            }
        }
        // solicita un numero entre 1 y 3 para fila o columna
        private int PedirNumero(string mensaje)
        {
            Console.Write(mensaje);
            if (!int.TryParse(Console.ReadLine(), out int valor))
                return -1;

            if (valor < 1 || valor > 3)
                return -1;

            return valor;
        }
        // verifica si la posicion seleccionada esta vacia y dentro del tablero
        private bool MovimientoValido(int fila, int col)
        {
            if (fila < 0 || fila > 2 || col < 0 || col > 2)
                return false;

            return tablero[fila, col] == ' ';
        }
        // alterna entre los jugadores x y o
        private void CambiarJugador()
        {
            jugadorActual = (jugadorActual == 'X') ? 'O' : 'X';
        }
        // verifica si hay tres marcas iguales en fila, columna o diagonal
        private bool HayGanador()
        {
            // filas
            for (int i = 0; i < 3; i++)
            {
                if (tablero[i, 0] != ' ' &&
                    tablero[i, 0] == tablero[i, 1] &&
                    tablero[i, 1] == tablero[i, 2])
                    return true;
            }

            // columnas
            for (int j = 0; j < 3; j++)
            {
                if (tablero[0, j] != ' ' &&
                    tablero[0, j] == tablero[1, j] &&
                    tablero[1, j] == tablero[2, j])
                    return true;
            }

            // diagonal principal
            if (tablero[0, 0] != ' ' &&
                tablero[0, 0] == tablero[1, 1] &&
                tablero[1, 1] == tablero[2, 2])
                return true;

            // diagonal secundaria
            if (tablero[0, 2] != ' ' &&
                tablero[0, 2] == tablero[1, 1] &&
                tablero[1, 1] == tablero[2, 0])
                return true;

            return false;
        }
        // verifica si todas las casillas estan ocupadas sin que haya ganador
        private bool EsEmpate()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (tablero[i, j] == ' ')
                        return false;

            return true;
        }
        // muestra opciones para reiniciar el juego o volver al menu
        private bool MenuReiniciar()
        {
            Console.WriteLine("\n1. Reiniciar");
            Console.WriteLine("0. Volver al menu del ejercicio");
            Console.Write("Seleccione una opcion: ");

            if (!int.TryParse(Console.ReadLine(), out int op))
            {
                MensajeError();
                return true;
            }

            if (op == 1)
                return false; 
            else
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
    