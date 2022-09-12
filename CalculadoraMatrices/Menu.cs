using System;


namespace CalculadoraMatrices
{
    class Menu
    {

        public Menu()
        {
       
        }
               

        static void Main()
        {
            string opcion;
            bool volverse = true;
            bool volversevolverse = true;
            ListaConfiguracion LC = new ListaConfiguracion();
            Operaciones OC = new Operaciones();
            TipoDeOperacion TOC = new TipoDeOperacion();
            

            do
            {
                volversevolverse = false;
                Console.Clear();

               

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                Console.WriteLine("║                       CALCULADORA DE MATRICES                         ║ ");
                Console.WriteLine("║             MATEMATICAS PARA VIDEOJUEGOS II | LMAD | FCFM             ║ ");
                Console.WriteLine("║              Creado por: Leslie Sarahy Cazares Mendoza                ║ ");
                Console.WriteLine("║                    Matricula: 1673459 | GRUPO 03                      ║ ");
                Console.WriteLine("║                                                                       ║ ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("║            INSERTE UN NUMERO SEGUN LA OPCION DESEADA DEL MENU         ║ ");
                Console.WriteLine("║ 0. Operaciones                1. Salir                                ║ ");
                Console.WriteLine("║                                                                       ║ ");
                Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("   -------------------------------------------------------------------    ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("¿Que opcion elige?                                                        ");
                opcion = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("   -------------------------------------------------------------------    ");

                switch (opcion)
                {
                    case "0":
                        {
                            do
                            {
                                volverse = false;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                                Console.WriteLine("║                             OPERACIONES                               ║ ");
                                Console.WriteLine("║                                                                       ║ ");

                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("║            INSERTE UN NUMERO SEGUN LA OPCION DESEADA DEL MENU         ║ ");
                                Console.WriteLine("║ 0. Matrices                     1. Cuaterniones                       ║ ");
                                Console.WriteLine("║ 2. Traslacion/Rotacion/Escalar  3. Vectores                           ║ ");
                                Console.WriteLine("║ 4. Matriz Compuesta             5. Algoritmo Bresenham                ║ ");
                                Console.WriteLine("║ 6.                              7. Regresar                           ║ ");
                                Console.WriteLine("║                                                                       ║ ");
                                Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");

                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("   -------------------------------------------------------------------    ");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("¿Que opcion elige?                                                        ");
                                opcion = Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("   -------------------------------------------------------------------    ");

                                switch (opcion)
                                {
                                    case "0":
                                        TOC.Matrices();
                                        Console.ReadLine();
                                        volverse = true;
                                        break;
                                    case "1":
                                        TOC.Cuaternios();
                                        Console.ReadLine();
                                        volverse = true;
                                        break;
                                    case "2":
                                        TOC.TraslacionRotacionEscala();
                                        Console.ReadLine();
                                        volverse = true;
                                        break;
                                    case "3":
                                        TOC.Vectores();
                                        Console.ReadLine();
                                        volverse = true;
                                        break;
                                    case "4":
                                        TOC.MatrizCompuesta();
                                        Console.ReadLine();
                                        volverse = true;
                                        break;
                                    case "5":
                                        TOC.AlgoritmoBresenham();
                                        Console.ReadLine();
                                        volverse = true;
                                        break;
                                    case "7":
                                        volverse = false;
                                        break;
                                    default:
                                        Console.WriteLine(" Opcion invalida");
                                        Console.ReadLine();
                                        volverse = true;
                                        break;
                                }

                            } while (volverse != false);
                            volversevolverse = true;
                            break;
                        }
                    //case "1":
                    //    {
                    //        Console.WriteLine(" Opcion 1");
                    //        volversevolverse = true;
                    //        break;
                    //    }
                    case "1":
                        {
                            volversevolverse = false;
                            Console.Clear();
                            Console.WriteLine(" °  .             ¤   °        *               °       ° .      ¤      °          ¤       .   *                ¤    . ");
                            Console.WriteLine("             .              °                             ¤                                                    .      ");
                            Console.WriteLine("                                 ¤                                       .                °             *             ");
                            Console.WriteLine(" °  .                 °                        °         .                     .           .   *  °             ¤   . ");
                            Console.WriteLine("                                    *                     ▄        .                                                  ");
                            Console.WriteLine("  °          °                  .           ¤              █                                   °               *      ");
                            Console.WriteLine("    .                              .                    ▄██████▄       ¤                               *              ");
                            Console.WriteLine("             .           ¤                              ████▀▀██                       *                   .         *");
                            Console.WriteLine("     ¤               *              °                 ▀▀████████   °                              ¤                   ");
                            Console.WriteLine("                                                      ▀▀████▄▄██               *                                ¤     ");
                            Console.WriteLine("        °          *        .                      *    ▀██████▀    ¤                                      °          ");
                            Console.WriteLine("   .                                          ¤              █    .             .          °                          ");
                            Console.WriteLine("                                                              ▀                                                       ");
                            Console.WriteLine(" °  .             ¤   °        *               °       ° .      ¤      °                  .   *  °             ¤    . ");
                            Console.WriteLine("                                     ▄    ▄▄▄▄  ▄▄▄▄▄  ▄▄▄▄  ▄▄▄▄ ▄  ▄▄▄▄   ▄▄▄   █                                   ");
                            Console.WriteLine("                        ¤            ▄   █      █  ▄█ █    █ █  ▀ █ █    █ █  ▀   █               ¤                   ");
                            Console.WriteLine("     ¤     °                         █   █▄▄▄▄▄ █▀█   █▄▄▄▄█ █    █ █▄▄▄▄█ █▄▄    █   ¤                         .     ");
                            Console.WriteLine("                            *        █   █    █ █  █  █    █ █  ▄ █ █    █    █   ▀          *                        ");
                            Console.WriteLine("             °                       █    ▀▀▀▀  ▀   ▀ ▀    ▀ ▀▀▀▀ ▀ ▀    ▀ ▀▀▀    ▀                 ¤                 ");
                            Console.WriteLine(" °  .             ¤   °        *               °       ° .      ¤      °                  .   *                ¤    . ");
                            Console.WriteLine("             .              °                             ¤                         ¤                          .      ");
                            Console.WriteLine("                                 ¤                                                       °             *              ");
                            Console.WriteLine(" °  .                 °        *               °       ° .      ¤      °                  .      °                  . ");

                            Console.WriteLine("        *                          *        PULSA CUALQUIER TECLA PARA SALIR          *                   *           ");
                            Console.WriteLine("    .             ¤   °        *               °       ° .      ¤      °          ¤       .   *                     . ");
                            Console.WriteLine("             .              °                             ¤                                                    .      ");
                            Console.WriteLine("                                 ¤                                       .                °             *             ");
                            Console.WriteLine(" °  .                 °                        °         .                     .           .   *  °             ¤   . ");
                            Console.WriteLine(".         *          *              *                              .                                                  ");
                            Console.ReadLine();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine(" Opcion invalida");
                            Console.ReadLine();
                            volversevolverse = true;
                            break;
                        }
                }

                Console.Clear();
            } while (volversevolverse != false);
        }
    }
}
