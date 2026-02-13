using System;
using Tarea1.Ejercicios;

class Program
{
    static void Main(string[] args)
    {
        bool salir = false;

        while (!salir)
        {
            //Menu principal del programa, desde aqui se accede a todos los ejercicios
            Console.Clear();
            Console.WriteLine("Bienvenido al Menu Principal de Ejercicios");
            Console.WriteLine("Escriba el numero del ejercicio y presione enter para ejecutar");
            Console.WriteLine("Escriba 0 y presione enter para salir del programa");
            Console.WriteLine("\n===== MENU PRINCIPAL =====");
            Console.WriteLine("\n+++++ BLOQUE 1 +++++");
            Console.WriteLine("1. Calculadora de IMC");
            Console.WriteLine("2. Convertidor de Temperaturas");
            Console.WriteLine("3. Desglose de Billetes");
            Console.WriteLine("4. Calculadora de Prestamo Simple");
            Console.WriteLine("5. Transcurso de Tiempo");
            Console.WriteLine("6. Area y Perimetro");
            Console.WriteLine("7. Convertidor de Almacenamiento");
            Console.WriteLine("8. Calculo de Salario Semanal");
            Console.WriteLine("\n+++++ BLOQUE 2 +++++");
            Console.WriteLine("9. Clasificacion de Triangulos");
            Console.WriteLine("10. Calificaciones UNAH");
            Console.WriteLine("11. Calculadora de Descuentos");
            Console.WriteLine("12. Dias del Mes y Bisiesto");
            Console.WriteLine("13. Validador de Fecha");
            Console.WriteLine("14. Cajero Automatico");
            Console.WriteLine("\n+++++ BLOQUE 3 +++++");
            Console.WriteLine("15. Tabla de Multiplicar Extendida");
            Console.WriteLine("16. Numeros Primos en un Rango");
            Console.WriteLine("17. Serie de Fibonacci");
            Console.WriteLine("18. Factorial y Combinaciones");
            Console.WriteLine("19. Juego de Adivinanza");
            Console.WriteLine("20. Validar Contraseña");
            Console.WriteLine("21. Patron de Asteriscos");
            Console.WriteLine("22. Calculadora con Menu");
            Console.WriteLine("\n+++++ BLOQUE 4 +++++");
            Console.WriteLine("23. Estadisticas de Calificaciones");
            Console.WriteLine("24. Busqueda y Ordenamiento");
            Console.WriteLine("25. Rotacion de Arreglo");
            Console.WriteLine("26. Frecuencia de Elementos");
            Console.WriteLine("27. Arreglo de Temperaturas");
            Console.WriteLine("\n+++++ BLOQUE 5 +++++");
            Console.WriteLine("28. Matriz de Notas por Parcial");
            Console.WriteLine("29. Juego del Gato");
            Console.WriteLine("30. Inventario Simple");
            Console.Write("Seleccione una opcion: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                CalculadoraIMC imc = new CalculadoraIMC();
                salir = !imc.EjecutarIMC();
                break;

                case "2":
               cvTemperatura  conv = new cvTemperatura();
               salir = !conv.EjecutarCv();
                break;

                case "3":
                dsgBilletes desglose = new dsgBilletes();
                salir = !desglose.EjecutarDsg();
                break;

                case "4":
                CalculadoraPS prestamo = new CalculadoraPS();
                salir = !prestamo.EjecutarCPS();
                break;

                case "5":
                TranscursoTiempo tiempo = new TranscursoTiempo();
                salir = !tiempo.EjecutarTT();
                break;

                case "6":
                AreaPerimetro area = new AreaPerimetro();
                salir = !area.EjecutarAP();
                break;

                case "7":
                ConvAlmacenamiento cva = new ConvAlmacenamiento();
                salir = !cva.EjecutarCvA();
                break;

                case "8":
                SalarioSemanal salario = new SalarioSemanal();
                salir = !salario.EjecutarSS();
                break;

                case "9":
                ClasificarTriangulos triangulos = new ClasificarTriangulos();
                salir = !triangulos.EjecutarCT();
                break;

                case "10":
                CalificacionesUNAH calificaciones = new CalificacionesUNAH();
                salir = !calificaciones.EjecutarCalUNAH();
                break;

                case "11":
                CalculadoraDescuentos descuentos = new CalculadoraDescuentos();
                salir = !descuentos.EjecutarCD();
                break;

                case "12":
                DiasMesBisiesto dias = new DiasMesBisiesto();
                salir = !dias.EjecutarDMB();
                break;

                case "13":
                ValidadorFecha validador = new ValidadorFecha();
                salir = !validador.EjecutarVF();
                break;

                case "14":
                CajeroAutomatico cajero = new CajeroAutomatico();
                salir = !cajero.EjecutarCA();
                break;

                case "15":
                TablaMultiplicar tabla = new TablaMultiplicar();
                salir = !tabla.EjecutarTM();
                break;

                case "16":
                NumPrimosRango primos = new NumPrimosRango();
                salir = !primos.EjecutarNPR();
                break;

                case "17":
                SerieFibonacci fibonacci = new SerieFibonacci();
                salir = !fibonacci.EjecutarSF();
                break;

                case "18":
                FactorialCombinaciones factorial = new FactorialCombinaciones();
                salir = !factorial.EjecutarFC();
                break;

                case "19":
                JuegoAdivinanza ja = new JuegoAdivinanza();
                salir = !ja.EjecutarJA();
                break;

                case "20":
                ValidarPassword vp = new ValidarPassword();
                salir = !vp.EjecutarVP();
                break;

                case "21":
                PatronAsteriscos pa = new PatronAsteriscos();
                salir = !pa.EjecutarPA();
                break;

                case "22":
                CalculadoraConMenu ccm = new CalculadoraConMenu();
                salir = !ccm.EjecutarCCM();
                break;

                case "23":
                EstadisticasCalificaciones ec = new EstadisticasCalificaciones();
                salir = !ec.EjecutarEC();
                break;

                case "24":
                BusquedaOrdenamiento bo = new BusquedaOrdenamiento();
                salir = !bo.EjecutarBO();
                break;

                case "25":
                RotacionArreglo ra = new RotacionArreglo();
                salir = !ra.EjecutarRA();
                break;

                case "26":
                FrecuenciaElementos fe = new FrecuenciaElementos();
                salir = !fe.EjecutarFE();
                break;

                case "27":
                ArregloTemperatura at = new ArregloTemperatura();
                salir = !at.EjecutarAT();
                break;

                case "28":
                MatrizNotasParcial mnp = new MatrizNotasParcial();
                salir = !mnp.EjecutarMNP();
                break;

                case "29":
                TicTacToe ttt = new TicTacToe();
                salir = !ttt.EjecutarTTT();
                break;

                case "30":
                InventarioSimple invs = new InventarioSimple();
                salir = !invs.EjecutarInvS();
                break;

                case "0":
                salir = true;
                break;

                default:
                Console.WriteLine("Opcion incorrecta, elija una opcion correcta");
                Console.ReadKey();
                break;
            }
        }
    }
        
}

