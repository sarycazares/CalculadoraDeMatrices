using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraMatrices
{
    class TipoDeOperacion : ListaConfiguracion
    {
        public Operaciones OC = new Operaciones();



        public TipoDeOperacion(){}

        public void Matrices()
        {
            do
            {
                volvervolver = false;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                Console.WriteLine("║                              MATRICES                                 ║ ");
                Console.WriteLine("║                                                                       ║ ");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("║            INSERTE UN NUMERO SEGUN LA OPCION DESEADA DEL MENU         ║ ");
                Console.WriteLine("║ 0. Agregar Matriz                1. Imprimir Matrices                 ║ ");
                Console.WriteLine("║ 2. Modificar Matriz              3. Eliminar Martriz                  ║ ");
                Console.WriteLine("║ 4. Suma                          5. Resta                             ║ ");
                Console.WriteLine("║ 6. Multiplicacion                7. Producto Cruz                     ║ ");
                Console.WriteLine("║ 8. Transpuesta                   9. Regresar                          ║ ");
                Console.WriteLine("║                                                                       ║ ");
                Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");


                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("   -------------------------------------------------------------------    ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("¿Que opcion elige?                                                        ");
                opcion = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("   -------------------------------------------------------------------    ");
                Console.ForegroundColor = ConsoleColor.White;

                switch (opcion)
                {
                    case "0":
                        {
                            do
                            {
                                volvervolver = false;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                                Console.WriteLine("║                           AGREGAR MATRIZ                              ║ ");
                                Console.WriteLine("║                                                                       ║ ");

                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("║              SIGA POR FAVOR LAS INSTRUCCIONES SIGUIENTES              ║ ");
                                Console.WriteLine("║                                                                       ║ ");
                                Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");

                                AgregarMatriz();
                                ImprimirMatrizEspecifica(numerocodigoAux);

                                volvervolver = false;
                            } while (volvervolver != false);
                            volvervolver = true;
                            break;
                        }
                    case "1":
                        {
                            do
                            {
                                volvervolver = false;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                                Console.WriteLine("║                          IMPRIMIR MATRIZ                              ║ ");
                                Console.WriteLine("║                                                                       ║ ");

                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("║            INSERTE UN NUMERO SEGUN LA OPCION DESEADA DEL MENU         ║ ");
                                Console.WriteLine("║ 0. Imprimir todas las matrices   1. Imprimir matriz especifica        ║ ");
                                Console.WriteLine("║ 2. Salir                                                              ║ ");
                                Console.WriteLine("║                                                                       ║ ");
                                Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");

                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("   -------------------------------------------------------------------    ");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("¿Que opcion elige?                                                        ");
                                opcion = Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("   -------------------------------------------------------------------    ");
                                Console.ForegroundColor = ConsoleColor.White;

                                switch (opcion)
                                {
                                    case "0":
                                        ImprimirMatriz();
                                        volvervolver = false;
                                        break;
                                    case "1":
                                        do
                                        {
                                            volvervolver = false;
                                            do
                                            {
                                                volvervolver = false;
                                                Console.WriteLine(" Escriba el codigo de la matriz que busca");
                                                string numerosho = Console.ReadLine();

                                                int cantidad = numerosho.Length;
                                                if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                {
                                                    volvervolver = false;
                                                    numerocodigoAux = Convert.ToInt32(numerosho); // convierte a int
                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                }
                                            } while (volvervolver != false);

                                            if (ImprimirMatrizEspecifica(numerocodigoAux) != 0)
                                            {

                                                bool volvers = false;

                                                do
                                                {
                                                    volvervolver = false;

                                                    Console.WriteLine("¿Quiere intentar otro codigo?");
                                                    Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                    opcion = Console.ReadLine();

                                                    switch (opcion)
                                                    {
                                                        case "0":
                                                            volvervolver = false;
                                                            volvers = false;
                                                            break;
                                                        case "1":
                                                            volvervolver = false;
                                                            volvers = true;
                                                            break;
                                                        default:
                                                            Console.WriteLine(" Opcion invalida");
                                                            volvervolver = true;
                                                            break;

                                                    }

                                                } while (volvervolver != false);

                                                if (volvers == false)
                                                {
                                                    volvervolver = true;
                                                }
                                                else
                                                {
                                                    volvervolver = false;
                                                }

                                            }
                                        } while (volvervolver != false);
                                        volvervolver = false;
                                        break;
                                    case "2":
                                        volvervolver = false;
                                        break;

                                    default:
                                        Console.WriteLine(" Opcion invalida");
                                        volvervolver = true;
                                        break;
                                }

                            } while (volvervolver != false);
                            volvervolver = true;
                            break;
                        }
                    case "2":
                        {
                            do
                            {
                                volvervolver = false;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                                Console.WriteLine("║                         MODIFICAR MATRIZ                              ║ ");
                                Console.WriteLine("║                                                                       ║ ");

                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("║            INSERTE UN NUMERO SEGUN LA OPCION DESEADA DEL MENU         ║ ");
                                Console.WriteLine("║ 0. Modificar toda la matriz  1. Modificar dato especifico de la matriz║ ");
                                Console.WriteLine("║ 2. Salir                                                              ║ ");
                                Console.WriteLine("║                                                                       ║ ");
                                Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");

                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("   -------------------------------------------------------------------    ");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("¿Que opcion elige?                                                        ");
                                opcion = Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("   -------------------------------------------------------------------    ");
                                Console.ForegroundColor = ConsoleColor.White;

                                switch (opcion)
                                {
                                    case "0":
                                        do
                                        {
                                            volvervolver = false;
                                            do
                                            {
                                                volvervolver = false;
                                                Console.WriteLine(" Escriba el codigo de la matriz que busca");
                                                string numerosho = Console.ReadLine();

                                                int cantidad = numerosho.Length;
                                                if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                {
                                                    volvervolver = false;
                                                    numerocodigoAux = Convert.ToInt32(numerosho); // convierte a int
                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                }
                                            } while (volvervolver != false);

                                            if (ModificarMatriz(numerocodigoAux) != 0)
                                            {

                                                bool volvers = false;

                                                do
                                                {
                                                    volvervolver = false;

                                                    Console.WriteLine("¿Quiere intentar otro codigo?");
                                                    Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                    opcion = Console.ReadLine();

                                                    switch (opcion)
                                                    {
                                                        case "0":
                                                            volvervolver = false;
                                                            volvers = false;
                                                            break;
                                                        case "1":
                                                            volvervolver = false;
                                                            volvers = true;
                                                            break;
                                                        default:
                                                            Console.WriteLine(" Opcion invalida");
                                                            volvervolver = true;
                                                            break;

                                                    }

                                                } while (volvervolver != false);

                                                if (volvers == false)
                                                {
                                                    volvervolver = true;
                                                }
                                                else
                                                {
                                                    volvervolver = false;
                                                }

                                            }
                                            else
                                            {
                                                ImprimirMatrizEspecifica(numerocodigoAux);
                                            }



                                        } while (volvervolver != false);
                                        volvervolver = false;
                                        break;
                                    case "1":
                                        do
                                        {
                                            volvervolver = false;
                                            do
                                            {
                                                volvervolver = false;
                                                Console.WriteLine(" Escriba el codigo de la matriz que busca");
                                                string numerosho = Console.ReadLine();

                                                int cantidad = numerosho.Length;
                                                if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                {
                                                    volvervolver = false;
                                                    numerocodigoAux = Convert.ToInt32(numerosho); // convierte a int
                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                }
                                            } while (volvervolver != false);

                                            if (ModificarMatrizEspecifica(numerocodigoAux) != 0)
                                            {

                                                bool volvers = false;

                                                do
                                                {
                                                    volvervolver = false;

                                                    Console.WriteLine("¿Quiere intentar otro codigo?");
                                                    Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                    opcion = Console.ReadLine();

                                                    switch (opcion)
                                                    {
                                                        case "0":
                                                            volvervolver = false;
                                                            volvers = false;
                                                            break;
                                                        case "1":
                                                            volvervolver = false;
                                                            volvers = true;
                                                            break;
                                                        default:
                                                            Console.WriteLine(" Opcion invalida");
                                                            volvervolver = true;
                                                            break;

                                                    }

                                                } while (volvervolver != false);

                                                if (volvers == false)
                                                {
                                                    volvervolver = true;
                                                }
                                                else
                                                {
                                                    volvervolver = false;
                                                }

                                            }
                                        } while (volvervolver != false);
                                        volvervolver = false;
                                        break;
                                    case "2":
                                        volvervolver = false;
                                        break;

                                    default:
                                        Console.WriteLine(" Opcion invalida");
                                        volvervolver = true;
                                        break;
                                }

                            } while (volvervolver != false);
                            volvervolver = true;
                            break;
                        }
                    case "3":
                        {
                            do
                            {
                                volvervolver = false;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                                Console.WriteLine("║                          ELIMINAR MATRIZ                              ║ ");
                                Console.WriteLine("║                                                                       ║ ");

                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("║              SIGA POR FAVOR LAS INSTRUCCIONES SIGUIENTES              ║ ");
                                Console.WriteLine("║                                                                       ║ ");
                                Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");

                                do
                                {
                                    volvervolver = false;
                                    Console.WriteLine(" Escriba el codigo de la matriz que quiera eliminar");
                                    string numerosho = Console.ReadLine();

                                    int cantidad = numerosho.Length;
                                    if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                    {
                                        volvervolver = false;
                                        numerocodigoAux = Convert.ToInt32(numerosho); // convierte a int
                                    }
                                    else
                                    {
                                        volvervolver = true;
                                    }
                                } while (volvervolver != false);
                                if (EliminarMatriz(numerocodigoAux) != 0)
                                {

                                    bool volvers = false;

                                    do
                                    {
                                        volvervolver = false;

                                        Console.WriteLine("¿Quiere intentar otro codigo?");
                                        Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                        opcion = Console.ReadLine();

                                        switch (opcion)
                                        {
                                            case "0":
                                                volvervolver = false;
                                                volvers = false;
                                                break;
                                            case "1":
                                                volvervolver = false;
                                                volvers = true;
                                                break;
                                            default:
                                                Console.WriteLine(" Opcion invalida");
                                                volvervolver = true;
                                                break;

                                        }

                                    } while (volvervolver != false);

                                    if (volvers == false)
                                    {
                                        volvervolver = true;
                                    }
                                    else
                                    {
                                        volvervolver = false;
                                    }

                                }


                            } while (volvervolver != false);
                            volvervolver = true;
                            break;
                        }
                    case "4":
                        {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                                Console.WriteLine("║                             SUMAR MATRIZ                              ║ ");
                                Console.WriteLine("║                                                                       ║ ");

                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("║              SIGA POR FAVOR LAS INSTRUCCIONES SIGUIENTES              ║ ");
                                Console.WriteLine("║                                                                       ║ ");
                                Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");


                            if (inicioMN == null)
                            {
                                volvervolver = true;
                                Console.WriteLine("Warning: Aun no se agregan datos suficientes para la operacion");
                                Console.ReadLine();
                            }
                            else
                            {
                                do
                                {

                                    Console.WriteLine(" ");
                                    Console.WriteLine("¿COMO REALIZARAS LA SUMA? 0. Matriz-Matriz | 1. Escalar-Matriz | 2. Matriz-Escalar");
                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("¿Que opcion elige?                                                        ");
                                    opcion = Console.ReadLine();
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                    Console.ForegroundColor = ConsoleColor.White;

                                    switch (opcion)
                                    {
                                        case "0":
                                            {
                                                bool SiMatrizA = false;
                                                bool SiMatrizB = false;
                                                //MATRIZ A
                                                do
                                                {
                                                    volvervolver = false;
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        Console.WriteLine(" Escriba el codigo de la MATRIZ A que desea sumar");
                                                        string numerosho = Console.ReadLine();

                                                        int cantidad = numerosho.Length;
                                                        if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                        {
                                                            volvervolver = false;
                                                            numerocodigoAux = Convert.ToInt32(numerosho); // convierte a int
                                                        }
                                                        else
                                                        {
                                                            volvervolver = true;
                                                        }
                                                    } while (volvervolver != false);

                                                    if (BuscarMatriz(numerocodigoAux) != 0)
                                                    {
                                                        SiMatrizA = false;
                                                        bool volvers = false;

                                                        do
                                                        {
                                                            volvervolver = false;

                                                            Console.WriteLine("¿Quiere intentar otro codigo?");
                                                            Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                            opcion = Console.ReadLine();

                                                            switch (opcion)
                                                            {
                                                                case "0":
                                                                    volvervolver = false;
                                                                    volvers = false;
                                                                    break;
                                                                case "1":
                                                                    volvervolver = false;
                                                                    volvers = true;
                                                                    SiMatrizA = false;
                                                                    break;
                                                                default:
                                                                    Console.WriteLine(" Opcion invalida");
                                                                    volvervolver = true;
                                                                    break;

                                                            }

                                                        } while (volvervolver != false);

                                                        if (volvers == false)
                                                        {
                                                            volvervolver = true;
                                                        }
                                                        else
                                                        {
                                                            volvervolver = false;
                                                        }

                                                    }
                                                    else
                                                    {
                                                        SiMatrizA = true;
                                                    }
                                                } while (volvervolver != false);

                                                ifilaA = ifilaAux;
                                                icolumnaA = icolumnaAux;
                                                Matriz01 = new float[ifilaA, icolumnaA];
                                                if (SiMatrizA == true)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                                    Console.WriteLine(" MATRIZ A");
                                                    Console.WriteLine(" Codigo: " + numerocodigoAux + "  Con filas: " + ifilaA + "  Con Columnas: " + icolumnaA);

                                                    for (int i = 0; i < ifilaA; i++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int j = 0; j < icolumnaA; j++)
                                                        {
                                                            Matriz01[i, j] = MatrizAux[i, j];
                                                            Console.Write(Matriz01[i, j] + "   ");
                                                        }
                                                    }
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("\n");
                                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                                }

                                                //MATRIZ B
                                                if (SiMatrizA == true)
                                                {
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        do
                                                        {
                                                            volvervolver = false;
                                                            Console.WriteLine(" Escriba el codigo de la MATRIZ B que desea sumar");
                                                            string numerosho = Console.ReadLine();

                                                            int cantidad = numerosho.Length;
                                                            if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                            {
                                                                volvervolver = false;
                                                                numerocodigoAux = Convert.ToInt32(numerosho); // convierte a int
                                                            }
                                                            else
                                                            {
                                                                volvervolver = true;
                                                            }
                                                        } while (volvervolver != false);

                                                        if (BuscarMatriz(numerocodigoAux) != 0)
                                                        {
                                                            SiMatrizB = false;
                                                            bool volvers = false;

                                                            do
                                                            {
                                                                volvervolver = false;

                                                                Console.WriteLine("¿Quiere intentar otro codigo?");
                                                                Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                                opcion = Console.ReadLine();

                                                                switch (opcion)
                                                                {
                                                                    case "0":
                                                                        volvervolver = false;
                                                                        volvers = false;
                                                                        break;
                                                                    case "1":
                                                                        volvervolver = false;
                                                                        volvers = true;
                                                                        break;
                                                                    default:
                                                                        Console.WriteLine(" Opcion invalida");
                                                                        volvervolver = true;
                                                                        break;

                                                                }

                                                            } while (volvervolver != false);

                                                            if (volvers == false)
                                                            {
                                                                volvervolver = true;
                                                            }
                                                            else
                                                            {
                                                                volvervolver = false;
                                                            }

                                                        }
                                                        else
                                                        {
                                                            SiMatrizB = true;
                                                        }
                                                    } while (volvervolver != false);
                                                    ifilaB = ifilaAux;
                                                    icolumnaB = icolumnaAux;
                                                    Matriz02 = new float[ifilaB, icolumnaB];
                                                    if (SiMatrizB == true)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                                        Console.WriteLine(" MATRIZ B");
                                                        Console.WriteLine(" Codigo: " + numerocodigoAux + "  Con filas: " + ifilaB + "  Con Columnas: " + icolumnaB);

                                                        for (int i = 0; i < ifilaB; i++)
                                                        {
                                                            Console.Write("\n");
                                                            for (int j = 0; j < icolumnaB; j++)
                                                            {
                                                                Matriz02[i, j] = MatrizAux[i, j];
                                                                Console.Write(Matriz02[i, j] + "   ");
                                                            }
                                                        }
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        Console.WriteLine("\n");
                                                        Console.WriteLine("   -------------------------------------------------------------------    ");
                                                    }
                                                }

                                                if (VC.Igualdad(ifilaA, ifilaB) == 0 && VC.Igualdad(icolumnaA, icolumnaB) == 0 && SiMatrizA == true && SiMatrizB == true)
                                                {
                                                    volvervolver = false;

                                                    Matriz03 = new float[ifilaA, icolumnaA];

                                                    for (int iA = 0; iA < ifilaA; iA++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int jA = 0; jA < icolumnaA; jA++)
                                                        {

                                                            float MatriciosaA = Matriz01[iA, jA];
                                                            float MatricionaB = Matriz02[iA, jA];

                                                            Matriz03[iA, jA] = OC.Sumar(MatriciosaA, MatricionaB);


                                                        }

                                                    }


                                                    AgregarMatrizResultado(ifilaA, icolumnaA);
                                                    ImprimirMatrizEspecifica(numerocodigoAux);

                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                    Console.WriteLine("Warning: El tamaño del valor de las matrices no permite la operacion o no fue encontrada");
                                                    Console.ReadLine();

                                                }

                                                volvervolver = false;
                                                break;
                                            }
                                        case "1":
                                            {
                                                bool SiMatrizA = false;
                                                bool SiMatrizB = false;
                                                //ESCALAR
                                                do
                                                {
                                                    volver = false;
                                                    Console.WriteLine(" Escriba el numero a sumar");
                                                    string numeromatriz = Console.ReadLine();
                                                    int cantidad = numeromatriz.Length;
                                                    if (VC.Contador(cantidad, numeromatriz) == 0)
                                                    {
                                                        volver = false;
                                                        float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                                                        inumeromatriz = (float)Math.Round(inumeromatriz, 2);                                                        
                                                        escalarA = inumeromatriz;                                                                                                                 
                                                        SiMatrizA = true;
                                                    }
                                                    else
                                                    {
                                                        SiMatrizA = false;
                                                        volver = true;
                                                    }
                                                } while (volver != false);

                                                //MATRIZ B
                                                if (SiMatrizA == true)
                                                {
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        do
                                                        {
                                                            volvervolver = false;
                                                            Console.WriteLine(" Escriba el codigo de la MATRIZ B que desea sumar");
                                                            string numerosho = Console.ReadLine();

                                                            int cantidad = numerosho.Length;
                                                            if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                            {
                                                                volvervolver = false;
                                                                numerocodigoAux = Convert.ToInt32(numerosho); // convierte a int
                                                            }
                                                            else
                                                            {
                                                                volvervolver = true;
                                                            }
                                                        } while (volvervolver != false);

                                                        if (BuscarMatriz(numerocodigoAux) != 0)
                                                        {
                                                            SiMatrizB = false;
                                                            bool volvers = false;

                                                            do
                                                            {
                                                                volvervolver = false;

                                                                Console.WriteLine("¿Quiere intentar otro codigo?");
                                                                Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                                opcion = Console.ReadLine();

                                                                switch (opcion)
                                                                {
                                                                    case "0":
                                                                        volvervolver = false;
                                                                        volvers = false;
                                                                        break;
                                                                    case "1":
                                                                        volvervolver = false;
                                                                        volvers = true;
                                                                        break;
                                                                    default:
                                                                        Console.WriteLine(" Opcion invalida");
                                                                        volvervolver = true;
                                                                        break;

                                                                }

                                                            } while (volvervolver != false);

                                                            if (volvers == false)
                                                            {
                                                                volvervolver = true;
                                                            }
                                                            else
                                                            {
                                                                volvervolver = false;
                                                            }

                                                        }
                                                        else
                                                        {
                                                            SiMatrizB = true;
                                                        }
                                                    } while (volvervolver != false);
                                                    ifilaB = ifilaAux;
                                                    icolumnaB = icolumnaAux;
                                                    Matriz02 = new float[ifilaB, icolumnaB];
                                                    if (SiMatrizB == true)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                                        Console.WriteLine(" MATRIZ B");
                                                        Console.WriteLine(" Codigo: " + numerocodigoAux + "  Con filas: " + ifilaB + "  Con Columnas: " + icolumnaB);

                                                        for (int i = 0; i < ifilaB; i++)
                                                        {
                                                            Console.Write("\n");
                                                            for (int j = 0; j < icolumnaB; j++)
                                                            {
                                                                Matriz02[i, j] = MatrizAux[i, j];
                                                                Console.Write(Matriz02[i, j] + "   ");
                                                            }
                                                        }
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        Console.WriteLine("\n");
                                                        Console.WriteLine("   -------------------------------------------------------------------    ");
                                                    }
                                                }



                                                if (SiMatrizA == true && SiMatrizB == true)
                                                {
                                                    volvervolver = false;

                                                    Matriz03 = new float[ifilaB, icolumnaB];

                                                    for (int iA = 0; iA < ifilaB; iA++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int jA = 0; jA < icolumnaB; jA++)
                                                        {
                                                            float MatricionaB = Matriz02[iA, jA];

                                                            Matriz03[iA, jA] = OC.Sumar(escalarA, MatricionaB);


                                                        }

                                                    }


                                                    AgregarMatrizResultado(ifilaB, icolumnaB);
                                                    ImprimirMatrizEspecifica(numerocodigoAux);

                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                    Console.WriteLine("Warning: El tamaño del valor de las matrices no permite la operacion o no fue encontrada");
                                                    Console.ReadLine();

                                                }

                                                volvervolver = false;
                                                break;
                                            }
                                        case "2":
                                            {
                                                bool SiMatrizA = false;
                                                bool SiMatrizB = false;
                                                //MATRIZ A
                                                do
                                                {
                                                    volvervolver = false;
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        Console.WriteLine(" Escriba el codigo de la MATRIZ A que desea sumar");
                                                        string numerosho = Console.ReadLine();

                                                        int cantidad = numerosho.Length;
                                                        if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                        {
                                                            volvervolver = false;
                                                            numerocodigoAux = Convert.ToInt32(numerosho); // convierte a int
                                                        }
                                                        else
                                                        {
                                                            volvervolver = true;
                                                        }
                                                    } while (volvervolver != false);

                                                    if (BuscarMatriz(numerocodigoAux) != 0)
                                                    {
                                                        SiMatrizA = false;
                                                        bool volvers = false;

                                                        do
                                                        {
                                                            volvervolver = false;

                                                            Console.WriteLine("¿Quiere intentar otro codigo?");
                                                            Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                            opcion = Console.ReadLine();

                                                            switch (opcion)
                                                            {
                                                                case "0":
                                                                    volvervolver = false;
                                                                    volvers = false;
                                                                    break;
                                                                case "1":
                                                                    volvervolver = false;
                                                                    volvers = true;
                                                                    SiMatrizA = false;
                                                                    break;
                                                                default:
                                                                    Console.WriteLine(" Opcion invalida");
                                                                    volvervolver = true;
                                                                    break;

                                                            }

                                                        } while (volvervolver != false);

                                                        if (volvers == false)
                                                        {
                                                            volvervolver = true;
                                                        }
                                                        else
                                                        {
                                                            volvervolver = false;
                                                        }

                                                    }
                                                    else
                                                    {
                                                        SiMatrizA = true;
                                                    }
                                                } while (volvervolver != false);
                                                ifilaA = ifilaAux;
                                                icolumnaA = icolumnaAux;
                                                Matriz01 = new float[ifilaA, icolumnaA];
                                                if (SiMatrizA == true)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                                    Console.WriteLine(" MATRIZ A");
                                                    Console.WriteLine(" Codigo: " + numerocodigoAux + "  Con filas: " + ifilaA + "  Con Columnas: " + icolumnaA);

                                                    for (int i = 0; i < ifilaA; i++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int j = 0; j < icolumnaA; j++)
                                                        {
                                                            Matriz01[i, j] = MatrizAux[i, j];
                                                            Console.Write(Matriz01[i, j] + "   ");
                                                        }
                                                    }
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("\n");
                                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                                }

                                                //ESCALAR B
                                                if (SiMatrizA == true)
                                                {
                                                    do
                                                    {
                                                        volver = false;
                                                        Console.WriteLine(" Escriba el numero a sumar");
                                                        string numeromatriz = Console.ReadLine();
                                                        int cantidad = numeromatriz.Length;
                                                        if (VC.Contador(cantidad, numeromatriz) == 0)
                                                        {
                                                            volver = false;
                                                            float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                                                            inumeromatriz = (float)Math.Round(inumeromatriz, 2);
                                                            escalarB = inumeromatriz;
                                                            SiMatrizB = true;
                                                        }
                                                        else
                                                        {
                                                            SiMatrizB = false;
                                                            volver = true;
                                                        }
                                                    } while (volver != false);
                                                }

                                                if (SiMatrizA == true && SiMatrizB == true)
                                                {
                                                    volvervolver = false;

                                                    Matriz03 = new float[ifilaA, icolumnaA];

                                                    for (int iA = 0; iA < ifilaA; iA++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int jA = 0; jA < icolumnaA; jA++)
                                                        {
                                                            float MatriciosaA = Matriz01[iA, jA];
                                                            Matriz03[iA, jA] = OC.Sumar(MatriciosaA, escalarB);

                                                        }

                                                    }


                                                    AgregarMatrizResultado(ifilaA, icolumnaA);
                                                    ImprimirMatrizEspecifica(numerocodigoAux);

                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                    Console.WriteLine("Warning: El tamaño del valor de las matrices no permite la operacion o no fue encontrada");
                                                    Console.ReadLine();

                                                }

                                                volvervolver = false;
                                                break;
                                            }
                                        default:
                                            Console.WriteLine(" Opcion invalida");
                                            volvervolver = true;
                                            break;
                                    }

                                } while (volvervolver != false);

                            }
                            volvervolver = true;
                            break;
                        }
                    case "5":
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                            Console.WriteLine("║                            RESTAR MATRIZ                              ║ ");
                            Console.WriteLine("║                                                                       ║ ");

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("║              SIGA POR FAVOR LAS INSTRUCCIONES SIGUIENTES              ║ ");
                            Console.WriteLine("║                                                                       ║ ");
                            Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");


                            if (inicioMN == null)
                            {
                                volvervolver = true;
                                Console.WriteLine("Warning: Aun no se agregan datos suficientes para la operacion");
                                Console.ReadLine();
                            }
                            else
                            {
                                do
                                {

                                    Console.WriteLine(" ");
                                    Console.WriteLine("¿COMO REALIZARAS LA RESTA? 0. Matriz-Matriz | 1. Escalar-Matriz | 2. Matriz-Escalar");
                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("¿Que opcion elige?                                                        ");
                                    opcion = Console.ReadLine();
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                    Console.ForegroundColor = ConsoleColor.White;

                                    switch (opcion)
                                    {
                                        case "0":
                                            {
                                                bool SiMatrizA = false;
                                                bool SiMatrizB = false;
                                                //MATRIZ A
                                                do
                                                {
                                                    volvervolver = false;
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        Console.WriteLine(" Escriba el codigo de la MATRIZ A que desea RESTAR");
                                                        string numerosho = Console.ReadLine();

                                                        int cantidad = numerosho.Length;
                                                        if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                        {
                                                            volvervolver = false;
                                                            numerocodigoAux = Convert.ToInt32(numerosho); // convierte a int
                                                        }
                                                        else
                                                        {
                                                            volvervolver = true;
                                                        }
                                                    } while (volvervolver != false);

                                                    if (BuscarMatriz(numerocodigoAux) != 0)
                                                    {
                                                        SiMatrizA = false;
                                                        bool volvers = false;

                                                        do
                                                        {
                                                            volvervolver = false;

                                                            Console.WriteLine("¿Quiere intentar otro codigo?");
                                                            Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                            opcion = Console.ReadLine();

                                                            switch (opcion)
                                                            {
                                                                case "0":
                                                                    volvervolver = false;
                                                                    volvers = false;
                                                                    break;
                                                                case "1":
                                                                    volvervolver = false;
                                                                    volvers = true;
                                                                    SiMatrizA = false;
                                                                    break;
                                                                default:
                                                                    Console.WriteLine(" Opcion invalida");
                                                                    volvervolver = true;
                                                                    break;

                                                            }

                                                        } while (volvervolver != false);

                                                        if (volvers == false)
                                                        {
                                                            volvervolver = true;
                                                        }
                                                        else
                                                        {
                                                            volvervolver = false;
                                                        }

                                                    }
                                                    else
                                                    {
                                                        SiMatrizA = true;
                                                    }
                                                } while (volvervolver != false);

                                                ifilaA = ifilaAux;
                                                icolumnaA = icolumnaAux;
                                                Matriz01 = new float[ifilaA, icolumnaA];
                                                if (SiMatrizA == true)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                                    Console.WriteLine(" MATRIZ A");
                                                    Console.WriteLine(" Codigo: " + numerocodigoAux + "  Con filas: " + ifilaA + "  Con Columnas: " + icolumnaA);

                                                    for (int i = 0; i < ifilaA; i++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int j = 0; j < icolumnaA; j++)
                                                        {
                                                            Matriz01[i, j] = MatrizAux[i, j];
                                                            Console.Write(Matriz01[i, j] + "   ");
                                                        }
                                                    }
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("\n");
                                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                                }

                                                //MATRIZ B
                                                if (SiMatrizA == true)
                                                {
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        do
                                                        {
                                                            volvervolver = false;
                                                            Console.WriteLine(" Escriba el codigo de la MATRIZ B que desea RESTAR");
                                                            string numerosho = Console.ReadLine();

                                                            int cantidad = numerosho.Length;
                                                            if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                            {
                                                                volvervolver = false;
                                                                numerocodigoAux = Convert.ToInt32(numerosho); // convierte a int
                                                            }
                                                            else
                                                            {
                                                                volvervolver = true;
                                                            }
                                                        } while (volvervolver != false);

                                                        if (BuscarMatriz(numerocodigoAux) != 0)
                                                        {
                                                            SiMatrizB = false;
                                                            bool volvers = false;

                                                            do
                                                            {
                                                                volvervolver = false;

                                                                Console.WriteLine("¿Quiere intentar otro codigo?");
                                                                Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                                opcion = Console.ReadLine();

                                                                switch (opcion)
                                                                {
                                                                    case "0":
                                                                        volvervolver = false;
                                                                        volvers = false;
                                                                        break;
                                                                    case "1":
                                                                        volvervolver = false;
                                                                        volvers = true;
                                                                        break;
                                                                    default:
                                                                        Console.WriteLine(" Opcion invalida");
                                                                        volvervolver = true;
                                                                        break;

                                                                }

                                                            } while (volvervolver != false);

                                                            if (volvers == false)
                                                            {
                                                                volvervolver = true;
                                                            }
                                                            else
                                                            {
                                                                volvervolver = false;
                                                            }

                                                        }
                                                        else
                                                        {
                                                            SiMatrizB = true;
                                                        }
                                                    } while (volvervolver != false);
                                                    ifilaB = ifilaAux;
                                                    icolumnaB = icolumnaAux;
                                                    Matriz02 = new float[ifilaB, icolumnaB];
                                                    if (SiMatrizB == true)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                                        Console.WriteLine(" MATRIZ B");
                                                        Console.WriteLine(" Codigo: " + numerocodigoAux + "  Con filas: " + ifilaB + "  Con Columnas: " + icolumnaB);

                                                        for (int i = 0; i < ifilaB; i++)
                                                        {
                                                            Console.Write("\n");
                                                            for (int j = 0; j < icolumnaB; j++)
                                                            {
                                                                Matriz02[i, j] = MatrizAux[i, j];
                                                                Console.Write(Matriz02[i, j] + "   ");
                                                            }
                                                        }
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        Console.WriteLine("\n");
                                                        Console.WriteLine("   -------------------------------------------------------------------    ");
                                                    }
                                                }

                                                if (VC.Igualdad(ifilaA, ifilaB) == 0 && VC.Igualdad(icolumnaA, icolumnaB) == 0 && SiMatrizA == true && SiMatrizB == true)
                                                {
                                                    volvervolver = false;

                                                    Matriz03 = new float[ifilaA, icolumnaA];

                                                    for (int iA = 0; iA < ifilaA; iA++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int jA = 0; jA < icolumnaA; jA++)
                                                        {

                                                            float MatriciosaA = Matriz01[iA, jA];
                                                            float MatricionaB = Matriz02[iA, jA];

                                                            Matriz03[iA, jA] = OC.Restar(MatriciosaA, MatricionaB);


                                                        }

                                                    }


                                                    AgregarMatrizResultado(ifilaA, icolumnaA);
                                                    ImprimirMatrizEspecifica(numerocodigoAux);
                                                    break;

                                                }
                                                else
                                                {
                                                    Console.WriteLine("Warning: El tamaño del valor de las matrices no permite la operacion o no fue encontrada");
                                                    Console.ReadLine();
                                                }
                                                volvervolver = false;
                                                break;
                                            }
                                        case "1":
                                            {
                                                bool SiMatrizA = false;
                                                bool SiMatrizB = false;
                                                //ESCALAR
                                                do
                                                {
                                                    volver = false;
                                                    Console.WriteLine(" Escriba el numero a restar");
                                                    string numeromatriz = Console.ReadLine();
                                                    int cantidad = numeromatriz.Length;
                                                    if (VC.Contador(cantidad, numeromatriz) == 0)
                                                    {
                                                        volver = false;
                                                        float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                                                        inumeromatriz = (float)Math.Round(inumeromatriz, 2);
                                                        escalarA = inumeromatriz;
                                                        SiMatrizA = true;
                                                    }
                                                    else
                                                    {
                                                        SiMatrizA = false;
                                                        volver = true;
                                                    }
                                                } while (volver != false);

                                                //MATRIZ B
                                                if (SiMatrizA == true)
                                                {
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        do
                                                        {
                                                            volvervolver = false;
                                                            Console.WriteLine(" Escriba el codigo de la MATRIZ B que desea restar");
                                                            string numerosho = Console.ReadLine();

                                                            int cantidad = numerosho.Length;
                                                            if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                            {
                                                                volvervolver = false;
                                                                numerocodigoAux = Convert.ToInt32(numerosho); // convierte a int
                                                            }
                                                            else
                                                            {
                                                                volvervolver = true;
                                                            }
                                                        } while (volvervolver != false);

                                                        if (BuscarMatriz(numerocodigoAux) != 0)
                                                        {
                                                            SiMatrizB = false;
                                                            bool volvers = false;

                                                            do
                                                            {
                                                                volvervolver = false;

                                                                Console.WriteLine("¿Quiere intentar otro codigo?");
                                                                Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                                opcion = Console.ReadLine();

                                                                switch (opcion)
                                                                {
                                                                    case "0":
                                                                        volvervolver = false;
                                                                        volvers = false;
                                                                        break;
                                                                    case "1":
                                                                        volvervolver = false;
                                                                        volvers = true;
                                                                        break;
                                                                    default:
                                                                        Console.WriteLine(" Opcion invalida");
                                                                        volvervolver = true;
                                                                        break;

                                                                }

                                                            } while (volvervolver != false);

                                                            if (volvers == false)
                                                            {
                                                                volvervolver = true;
                                                            }
                                                            else
                                                            {
                                                                volvervolver = false;
                                                            }

                                                        }
                                                        else
                                                        {
                                                            SiMatrizB = true;
                                                        }
                                                    } while (volvervolver != false);
                                                    ifilaB = ifilaAux;
                                                    icolumnaB = icolumnaAux;
                                                    Matriz02 = new float[ifilaB, icolumnaB];
                                                    if (SiMatrizB == true)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                                        Console.WriteLine(" MATRIZ B");
                                                        Console.WriteLine(" Codigo: " + numerocodigoAux + "  Con filas: " + ifilaB + "  Con Columnas: " + icolumnaB);

                                                        for (int i = 0; i < ifilaB; i++)
                                                        {
                                                            Console.Write("\n");
                                                            for (int j = 0; j < icolumnaB; j++)
                                                            {
                                                                Matriz02[i, j] = MatrizAux[i, j];
                                                                Console.Write(Matriz02[i, j] + "   ");
                                                            }
                                                        }
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        Console.WriteLine("\n");
                                                        Console.WriteLine("   -------------------------------------------------------------------    ");
                                                    }
                                                }



                                                if (SiMatrizA == true && SiMatrizB == true)
                                                {
                                                    volvervolver = false;

                                                    Matriz03 = new float[ifilaB, icolumnaB];

                                                    for (int iA = 0; iA < ifilaB; iA++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int jA = 0; jA < icolumnaB; jA++)
                                                        {
                                                            float MatricionaB = Matriz02[iA, jA];

                                                            Matriz03[iA, jA] = OC.Restar(escalarA, MatricionaB);


                                                        }

                                                    }


                                                    AgregarMatrizResultado(ifilaB, icolumnaB);
                                                    ImprimirMatrizEspecifica(numerocodigoAux);

                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                    Console.WriteLine("Warning: El tamaño del valor de las matrices no permite la operacion o no fue encontrada");
                                                    Console.ReadLine();

                                                }

                                                volvervolver = false;
                                                break;
                                            }
                                        case "2":
                                            {
                                                bool SiMatrizA = false;
                                                bool SiMatrizB = false;
                                                //MATRIZ A
                                                do
                                                {
                                                    volvervolver = false;
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        Console.WriteLine(" Escriba el codigo de la MATRIZ A que desea restar");
                                                        string numerosho = Console.ReadLine();

                                                        int cantidad = numerosho.Length;
                                                        if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                        {
                                                            volvervolver = false;
                                                            numerocodigoAux = Convert.ToInt32(numerosho); // convierte a int
                                                        }
                                                        else
                                                        {
                                                            volvervolver = true;
                                                        }
                                                    } while (volvervolver != false);

                                                    if (BuscarMatriz(numerocodigoAux) != 0)
                                                    {
                                                        SiMatrizA = false;
                                                        bool volvers = false;

                                                        do
                                                        {
                                                            volvervolver = false;

                                                            Console.WriteLine("¿Quiere intentar otro codigo?");
                                                            Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                            opcion = Console.ReadLine();

                                                            switch (opcion)
                                                            {
                                                                case "0":
                                                                    volvervolver = false;
                                                                    volvers = false;
                                                                    break;
                                                                case "1":
                                                                    volvervolver = false;
                                                                    volvers = true;
                                                                    SiMatrizA = false;
                                                                    break;
                                                                default:
                                                                    Console.WriteLine(" Opcion invalida");
                                                                    volvervolver = true;
                                                                    break;

                                                            }

                                                        } while (volvervolver != false);

                                                        if (volvers == false)
                                                        {
                                                            volvervolver = true;
                                                        }
                                                        else
                                                        {
                                                            volvervolver = false;
                                                        }

                                                    }
                                                    else
                                                    {
                                                        SiMatrizA = true;
                                                    }
                                                } while (volvervolver != false);
                                                ifilaA = ifilaAux;
                                                icolumnaA = icolumnaAux;
                                                Matriz01 = new float[ifilaA, icolumnaA];
                                                if (SiMatrizA == true)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                                    Console.WriteLine(" MATRIZ A");
                                                    Console.WriteLine(" Codigo: " + numerocodigoAux + "  Con filas: " + ifilaA + "  Con Columnas: " + icolumnaA);

                                                    for (int i = 0; i < ifilaA; i++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int j = 0; j < icolumnaA; j++)
                                                        {
                                                            Matriz01[i, j] = MatrizAux[i, j];
                                                            Console.Write(Matriz01[i, j] + "   ");
                                                        }
                                                    }
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("\n");
                                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                                }

                                                //ESCALAR B
                                                if (SiMatrizA == true)
                                                {
                                                    do
                                                    {
                                                        volver = false;
                                                        Console.WriteLine(" Escriba el numero a restar");
                                                        string numeromatriz = Console.ReadLine();
                                                        int cantidad = numeromatriz.Length;
                                                        if (VC.Contador(cantidad, numeromatriz) == 0)
                                                        {
                                                            volver = false;
                                                            float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                                                            inumeromatriz = (float)Math.Round(inumeromatriz, 2);
                                                            escalarB = inumeromatriz;
                                                            SiMatrizB = true;
                                                        }
                                                        else
                                                        {
                                                            SiMatrizB = false;
                                                            volver = true;
                                                        }
                                                    } while (volver != false);
                                                }

                                                if (SiMatrizA == true && SiMatrizB == true)
                                                {
                                                    volvervolver = false;

                                                    Matriz03 = new float[ifilaA, icolumnaA];

                                                    for (int iA = 0; iA < ifilaA; iA++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int jA = 0; jA < icolumnaA; jA++)
                                                        {
                                                            float MatriciosaA = Matriz01[iA, jA];
                                                            Matriz03[iA, jA] = OC.Restar(MatriciosaA, escalarB);

                                                        }

                                                    }


                                                    AgregarMatrizResultado(ifilaA, icolumnaA);
                                                    ImprimirMatrizEspecifica(numerocodigoAux);

                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                    Console.WriteLine("Warning: El tamaño del valor de las matrices no permite la operacion o no fue encontrada");
                                                    Console.ReadLine();

                                                }

                                                volvervolver = false;
                                                break;
                                            }
                                        default:
                                            Console.WriteLine(" Opcion invalida");
                                            volvervolver = true;
                                            break;
                                    }

                                } while (volvervolver != false);

                               
                            }

                            volvervolver = true;
                            break;
                        }
                    case "6":
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                            Console.WriteLine("║                         MULTIPLICAR MATRIZ                            ║ ");
                            Console.WriteLine("║                                                                       ║ ");

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("║              SIGA POR FAVOR LAS INSTRUCCIONES SIGUIENTES              ║ ");
                            Console.WriteLine("║                                                                       ║ ");
                            Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");


                            if (inicioMN == null)
                            {
                                volvervolver = true;
                                Console.WriteLine("Warning: Aun no se agregan datos suficientes para la operacion");
                                Console.ReadLine();
                            }
                            else
                            {
                                do
                                {

                                    Console.WriteLine(" ");
                                    Console.WriteLine("¿COMO REALIZARAS LA MULTIPLICACION? 0. Matriz-Matriz | 1. Escalar-Matriz | 2. Matriz-Escalar");
                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("¿Que opcion elige?                                                        ");
                                    opcion = Console.ReadLine();
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                    Console.ForegroundColor = ConsoleColor.White;

                                    switch (opcion)
                                    {
                                        case "0":
                                            {
                                                bool SiMatrizA = false;
                                                bool SiMatrizB = false;
                                                //MATRIZ A
                                                do
                                                {
                                                    volvervolver = false;
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        Console.WriteLine(" Escriba el codigo de la MATRIZ A que desea realizar MULTIPLICAR");
                                                        string numerosho = Console.ReadLine();

                                                        int cantidad = numerosho.Length;
                                                        if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                        {
                                                            volvervolver = false;
                                                            numerocodigoAux = Convert.ToInt32(numerosho); // convierte a int
                                                        }
                                                        else
                                                        {
                                                            volvervolver = true;
                                                        }
                                                    } while (volvervolver != false);

                                                    if (BuscarMatriz(numerocodigoAux) != 0)
                                                    {
                                                        SiMatrizA = false;
                                                        bool volvers = false;

                                                        do
                                                        {
                                                            volvervolver = false;

                                                            Console.WriteLine("¿Quiere intentar otro codigo?");
                                                            Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                            opcion = Console.ReadLine();

                                                            switch (opcion)
                                                            {
                                                                case "0":
                                                                    volvervolver = false;
                                                                    volvers = false;
                                                                    break;
                                                                case "1":
                                                                    volvervolver = false;
                                                                    volvers = true;
                                                                    SiMatrizA = false;
                                                                    break;
                                                                default:
                                                                    Console.WriteLine(" Opcion invalida");
                                                                    volvervolver = true;
                                                                    break;

                                                            }

                                                        } while (volvervolver != false);

                                                        if (volvers == false)
                                                        {
                                                            volvervolver = true;
                                                        }
                                                        else
                                                        {
                                                            volvervolver = false;
                                                        }

                                                    }
                                                    else
                                                    {
                                                        SiMatrizA = true;
                                                    }
                                                } while (volvervolver != false);

                                                ifilaA = ifilaAux;
                                                icolumnaA = icolumnaAux;
                                                Matriz01 = new float[ifilaA, icolumnaA];
                                                if (SiMatrizA == true)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                                    Console.WriteLine(" MATRIZ A");
                                                    Console.WriteLine(" Codigo: " + numerocodigoAux + "  Con filas: " + ifilaA + "  Con Columnas: " + icolumnaA);

                                                    for (int i = 0; i < ifilaA; i++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int j = 0; j < icolumnaA; j++)
                                                        {
                                                            Matriz01[i, j] = MatrizAux[i, j];
                                                            Console.Write(Matriz01[i, j] + "   ");
                                                        }
                                                    }
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("\n");
                                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                                }

                                                //MATRIZ B
                                                if (SiMatrizA == true)
                                                {
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        do
                                                        {
                                                            volvervolver = false;
                                                            Console.WriteLine(" Escriba el codigo de la MATRIZ B que desea realizar MULTIPLICAR");
                                                            string numerosho = Console.ReadLine();

                                                            int cantidad = numerosho.Length;
                                                            if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                            {
                                                                volvervolver = false;
                                                                numerocodigoAux = Convert.ToInt32(numerosho); // convierte a int
                                                            }
                                                            else
                                                            {
                                                                volvervolver = true;
                                                            }
                                                        } while (volvervolver != false);

                                                        if (BuscarMatriz(numerocodigoAux) != 0)
                                                        {
                                                            SiMatrizB = false;
                                                            bool volvers = false;

                                                            do
                                                            {
                                                                volvervolver = false;

                                                                Console.WriteLine("¿Quiere intentar otro codigo?");
                                                                Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                                opcion = Console.ReadLine();

                                                                switch (opcion)
                                                                {
                                                                    case "0":
                                                                        volvervolver = false;
                                                                        volvers = false;
                                                                        break;
                                                                    case "1":
                                                                        volvervolver = false;
                                                                        volvers = true;
                                                                        break;
                                                                    default:
                                                                        Console.WriteLine(" Opcion invalida");
                                                                        volvervolver = true;
                                                                        break;

                                                                }

                                                            } while (volvervolver != false);

                                                            if (volvers == false)
                                                            {
                                                                volvervolver = true;
                                                            }
                                                            else
                                                            {
                                                                volvervolver = false;
                                                            }

                                                        }
                                                        else
                                                        {
                                                            SiMatrizB = true;
                                                        }
                                                    } while (volvervolver != false);
                                                    ifilaB = ifilaAux;
                                                    icolumnaB = icolumnaAux;
                                                    Matriz02 = new float[ifilaB, icolumnaB];
                                                    if (SiMatrizB == true)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                                        Console.WriteLine(" MATRIZ B");
                                                        Console.WriteLine(" Codigo: " + numerocodigoAux + "  Con filas: " + ifilaB + "  Con Columnas: " + icolumnaB);

                                                        for (int i = 0; i < ifilaB; i++)
                                                        {
                                                            Console.Write("\n");
                                                            for (int j = 0; j < icolumnaB; j++)
                                                            {
                                                                Matriz02[i, j] = MatrizAux[i, j];
                                                                Console.Write(Matriz02[i, j] + "   ");
                                                            }
                                                        }
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        Console.WriteLine("\n");
                                                        Console.WriteLine("   -------------------------------------------------------------------    ");
                                                    }
                                                }

                                                if (VC.Igualdad(icolumnaA, ifilaB) == 0 && SiMatrizA == true && SiMatrizB == true)
                                                {
                                                    volvervolver = false;

                                                    Matriz03 = new float[ifilaA, icolumnaB];

                                                    for (int iA = 0; iA < ifilaA; iA++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int jA = 0; jA < icolumnaB; jA++)
                                                        {
                                                            float suma = 0;
                                                            float sumaaux = 0;
                                                            for (int jB = 0; jB < icolumnaA; jB++)
                                                            {
                                                                sumaaux = OC.Multiplicar(Matriz01[iA, jB], Matriz02[jB, jA]);
                                                                suma = suma + sumaaux;
                                                            }
                                                            Matriz03[iA, jA] = suma;

                                                        }

                                                    }
                                                    AgregarMatrizResultado(ifilaA, icolumnaB);
                                                    ImprimirMatrizEspecifica(numerocodigoAux);

                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                    Console.WriteLine("Warning: El tamaño del valor de las matrices no permite la operacion o no fue encontrada");
                                                    Console.ReadLine();

                                                }

                                                volvervolver = false;
                                                break;
                                            }
                                        case "1":
                                            {
                                                bool SiMatrizA = false;
                                                bool SiMatrizB = false;
                                                //ESCALAR
                                                do
                                                {
                                                    volver = false;
                                                    Console.WriteLine(" Escriba el numero a multiplicar");
                                                    string numeromatriz = Console.ReadLine();
                                                    int cantidad = numeromatriz.Length;
                                                    if (VC.Contador(cantidad, numeromatriz) == 0)
                                                    {
                                                        volver = false;
                                                        float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                                                        inumeromatriz = (float)Math.Round(inumeromatriz, 2);
                                                        escalarA = inumeromatriz;
                                                        SiMatrizA = true;
                                                    }
                                                    else
                                                    {
                                                        SiMatrizA = false;
                                                        volver = true;
                                                    }
                                                } while (volver != false);

                                                //MATRIZ B
                                                if (SiMatrizA == true)
                                                {
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        do
                                                        {
                                                            volvervolver = false;
                                                            Console.WriteLine(" Escriba el codigo de la MATRIZ B que desea sumar");
                                                            string numerosho = Console.ReadLine();

                                                            int cantidad = numerosho.Length;
                                                            if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                            {
                                                                volvervolver = false;
                                                                numerocodigoAux = Convert.ToInt32(numerosho); // convierte a int
                                                            }
                                                            else
                                                            {
                                                                volvervolver = true;
                                                            }
                                                        } while (volvervolver != false);

                                                        if (BuscarMatriz(numerocodigoAux) != 0)
                                                        {
                                                            SiMatrizB = false;
                                                            bool volvers = false;

                                                            do
                                                            {
                                                                volvervolver = false;

                                                                Console.WriteLine("¿Quiere intentar otro codigo?");
                                                                Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                                opcion = Console.ReadLine();

                                                                switch (opcion)
                                                                {
                                                                    case "0":
                                                                        volvervolver = false;
                                                                        volvers = false;
                                                                        break;
                                                                    case "1":
                                                                        volvervolver = false;
                                                                        volvers = true;
                                                                        break;
                                                                    default:
                                                                        Console.WriteLine(" Opcion invalida");
                                                                        volvervolver = true;
                                                                        break;

                                                                }

                                                            } while (volvervolver != false);

                                                            if (volvers == false)
                                                            {
                                                                volvervolver = true;
                                                            }
                                                            else
                                                            {
                                                                volvervolver = false;
                                                            }

                                                        }
                                                        else
                                                        {
                                                            SiMatrizB = true;
                                                        }
                                                    } while (volvervolver != false);
                                                    ifilaB = ifilaAux;
                                                    icolumnaB = icolumnaAux;
                                                    Matriz02 = new float[ifilaB, icolumnaB];
                                                    if (SiMatrizB == true)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                                        Console.WriteLine(" MATRIZ B");
                                                        Console.WriteLine(" Codigo: " + numerocodigoAux + "  Con filas: " + ifilaB + "  Con Columnas: " + icolumnaB);

                                                        for (int i = 0; i < ifilaB; i++)
                                                        {
                                                            Console.Write("\n");
                                                            for (int j = 0; j < icolumnaB; j++)
                                                            {
                                                                Matriz02[i, j] = MatrizAux[i, j];
                                                                Console.Write(Matriz02[i, j] + "   ");
                                                            }
                                                        }
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        Console.WriteLine("\n");
                                                        Console.WriteLine("   -------------------------------------------------------------------    ");
                                                    }
                                                }

                                                if (SiMatrizA == true && SiMatrizB == true)
                                                {
                                                    volvervolver = false;

                                                    Matriz03 = new float[ifilaB, icolumnaB];

                                                    for (int iA = 0; iA < ifilaB; iA++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int jA = 0; jA < icolumnaB; jA++)
                                                        {
                                                            float MatricionaB = Matriz02[iA, jA];
                                                            Matriz03[iA, jA] = OC.Multiplicar(escalarA, MatricionaB);

                                                        }

                                                    }
                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                    Console.WriteLine("Warning: El tamaño del valor de las matrices no permite la operacion o no fue encontrada");
                                                    Console.ReadLine();

                                                }

                                                volvervolver = false;
                                                break;
                                            }
                                        case "2":
                                            {
                                                bool SiMatrizA = false;
                                                bool SiMatrizB = false;
                                                //MATRIZ A
                                                do
                                                {
                                                    volvervolver = false;
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        Console.WriteLine(" Escriba el codigo de la MATRIZ A que desea sumar");
                                                        string numerosho = Console.ReadLine();

                                                        int cantidad = numerosho.Length;
                                                        if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                        {
                                                            volvervolver = false;
                                                            numerocodigoAux = Convert.ToInt32(numerosho); // convierte a int
                                                        }
                                                        else
                                                        {
                                                            volvervolver = true;
                                                        }
                                                    } while (volvervolver != false);

                                                    if (BuscarMatriz(numerocodigoAux) != 0)
                                                    {
                                                        SiMatrizA = false;
                                                        bool volvers = false;

                                                        do
                                                        {
                                                            volvervolver = false;

                                                            Console.WriteLine("¿Quiere intentar otro codigo?");
                                                            Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                            opcion = Console.ReadLine();

                                                            switch (opcion)
                                                            {
                                                                case "0":
                                                                    volvervolver = false;
                                                                    volvers = false;
                                                                    break;
                                                                case "1":
                                                                    volvervolver = false;
                                                                    volvers = true;
                                                                    SiMatrizA = false;
                                                                    break;
                                                                default:
                                                                    Console.WriteLine(" Opcion invalida");
                                                                    volvervolver = true;
                                                                    break;

                                                            }

                                                        } while (volvervolver != false);

                                                        if (volvers == false)
                                                        {
                                                            volvervolver = true;
                                                        }
                                                        else
                                                        {
                                                            volvervolver = false;
                                                        }

                                                    }
                                                    else
                                                    {
                                                        SiMatrizA = true;
                                                    }
                                                } while (volvervolver != false);
                                                ifilaA = ifilaAux;
                                                icolumnaA = icolumnaAux;
                                                Matriz01 = new float[ifilaA, icolumnaA];
                                                if (SiMatrizA == true)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                                    Console.WriteLine(" MATRIZ A");
                                                    Console.WriteLine(" Codigo: " + numerocodigoAux + "  Con filas: " + ifilaA + "  Con Columnas: " + icolumnaA);

                                                    for (int i = 0; i < ifilaA; i++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int j = 0; j < icolumnaA; j++)
                                                        {
                                                            Matriz01[i, j] = MatrizAux[i, j];
                                                            Console.Write(Matriz01[i, j] + "   ");
                                                        }
                                                    }
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("\n");
                                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                                }

                                                //ESCALAR B
                                                if (SiMatrizA == true)
                                                {
                                                    do
                                                    {
                                                        volver = false;
                                                        Console.WriteLine(" Escriba el numero a multiplicar");
                                                        string numeromatriz = Console.ReadLine();
                                                        int cantidad = numeromatriz.Length;
                                                        if (VC.Contador(cantidad, numeromatriz) == 0)
                                                        {
                                                            volver = false;
                                                            float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                                                            inumeromatriz = (float)Math.Round(inumeromatriz, 2);
                                                            escalarB = inumeromatriz;
                                                            SiMatrizB = true;
                                                        }
                                                        else
                                                        {
                                                            SiMatrizB = false;
                                                            volver = true;
                                                        }
                                                    } while (volver != false);
                                                }

                                                if (SiMatrizA == true && SiMatrizB == true)
                                                {
                                                    volvervolver = false;

                                                    Matriz03 = new float[ifilaA, icolumnaA];

                                                    for (int iA = 0; iA < ifilaA; iA++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int jA = 0; jA < icolumnaA; jA++)
                                                        {
                                                            float MatriciosaA = Matriz01[iA, jA];
                                                            Matriz03[iA, jA] = OC.Multiplicar(MatriciosaA, escalarB);

                                                        }

                                                    }


                                                    AgregarMatrizResultado(ifilaA, icolumnaA);
                                                    ImprimirMatrizEspecifica(numerocodigoAux);

                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                    Console.WriteLine("Warning: El tamaño del valor de las matrices no permite la operacion o no fue encontrada");
                                                    Console.ReadLine();

                                                }

                                                volvervolver = false;
                                                break;
                                            }
                                        default:
                                            Console.WriteLine(" Opcion invalida");
                                            volvervolver = true;
                                            break;
                                    }

                                } while (volvervolver != false);
                            }    
                            volvervolver = true;
                            break;
                        }
                    case "7":
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                            Console.WriteLine("║                        PRODUCTO CRUZ MATRIZ                           ║ ");
                            Console.WriteLine("║                                                                       ║ ");

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("║              SIGA POR FAVOR LAS INSTRUCCIONES SIGUIENTES              ║ ");
                            Console.WriteLine("║                                                                       ║ ");
                            Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");


                            if (inicioMN == null)
                            {
                                volvervolver = true;
                                Console.WriteLine("Warning: Aun no se agregan datos suficientes para la operacion");
                                Console.ReadLine();
                            }
                            else
                            {
                                bool SiMatrizA = false;
                                bool SiMatrizB = false;
                                //MATRIZ A
                                do
                                {
                                    volvervolver = false;
                                    do
                                    {
                                        volvervolver = false;
                                        Console.WriteLine(" Escriba el codigo de la MATRIZ A que desea realizar PRODUCTO CRUZ");
                                        string numerosho = Console.ReadLine();

                                        int cantidad = numerosho.Length;
                                        if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                        {
                                            volvervolver = false;
                                            numerocodigoAux = Convert.ToInt32(numerosho); // convierte a int
                                        }
                                        else
                                        {
                                            volvervolver = true;
                                        }
                                    } while (volvervolver != false);

                                    if (BuscarMatriz(numerocodigoAux) != 0)
                                    {
                                        SiMatrizA = false;
                                        bool volvers = false;

                                        do
                                        {
                                            volvervolver = false;

                                            Console.WriteLine("¿Quiere intentar otro codigo?");
                                            Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                            opcion = Console.ReadLine();

                                            switch (opcion)
                                            {
                                                case "0":
                                                    volvervolver = false;
                                                    volvers = false;
                                                    break;
                                                case "1":
                                                    volvervolver = false;
                                                    volvers = true;
                                                    SiMatrizA = false;
                                                    break;
                                                default:
                                                    Console.WriteLine(" Opcion invalida");
                                                    volvervolver = true;
                                                    break;

                                            }

                                        } while (volvervolver != false);

                                        if (volvers == false)
                                        {
                                            volvervolver = true;
                                        }
                                        else
                                        {
                                            volvervolver = false;
                                        }

                                    }
                                    else
                                    {
                                        SiMatrizA = true;
                                    }
                                } while (volvervolver != false);

                                ifilaA = ifilaAux;
                                icolumnaA = icolumnaAux;
                                Matriz01 = new float[ifilaA, icolumnaA];
                                if (SiMatrizA == true)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                    Console.WriteLine(" MATRIZ A");
                                    Console.WriteLine(" Codigo: " + numerocodigoAux + "  Con filas: " + ifilaA + "  Con Columnas: " + icolumnaA);

                                    for (int i = 0; i < ifilaA; i++)
                                    {
                                        Console.Write("\n");
                                        for (int j = 0; j < icolumnaA; j++)
                                        {
                                            Matriz01[i, j] = MatrizAux[i, j];
                                            Console.Write(Matriz01[i, j] + "   ");
                                        }
                                    }
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("\n");
                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                }

                                //MATRIZ B
                                if (SiMatrizA == true)
                                {
                                    do
                                    {
                                        volvervolver = false;
                                        do
                                        {
                                            volvervolver = false;
                                            Console.WriteLine(" Escriba el codigo de la MATRIZ B que desea realizar PRODUCTO CRUZ");
                                            string numerosho = Console.ReadLine();

                                            int cantidad = numerosho.Length;
                                            if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                            {
                                                volvervolver = false;
                                                numerocodigoAux = Convert.ToInt32(numerosho); // convierte a int
                                            }
                                            else
                                            {
                                                volvervolver = true;
                                            }
                                        } while (volvervolver != false);

                                        if (BuscarMatriz(numerocodigoAux) != 0)
                                        {
                                            SiMatrizB = false;
                                            bool volvers = false;

                                            do
                                            {
                                                volvervolver = false;

                                                Console.WriteLine("¿Quiere intentar otro codigo?");
                                                Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                opcion = Console.ReadLine();

                                                switch (opcion)
                                                {
                                                    case "0":
                                                        volvervolver = false;
                                                        volvers = false;
                                                        break;
                                                    case "1":
                                                        volvervolver = false;
                                                        volvers = true;
                                                        break;
                                                    default:
                                                        Console.WriteLine(" Opcion invalida");
                                                        volvervolver = true;
                                                        break;

                                                }

                                            } while (volvervolver != false);

                                            if (volvers == false)
                                            {
                                                volvervolver = true;
                                            }
                                            else
                                            {
                                                volvervolver = false;
                                            }

                                        }
                                        else
                                        {
                                            SiMatrizB = true;
                                        }
                                    } while (volvervolver != false);
                                    ifilaB = ifilaAux;
                                    icolumnaB = icolumnaAux;
                                    Matriz02 = new float[ifilaB, icolumnaB];
                                    if (SiMatrizB == true)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine(" MATRIZ B");
                                        Console.WriteLine(" Codigo: " + numerocodigoAux + "  Con filas: " + ifilaB + "  Con Columnas: " + icolumnaB);

                                        for (int i = 0; i < ifilaB; i++)
                                        {
                                            Console.Write("\n");
                                            for (int j = 0; j < icolumnaB; j++)
                                            {
                                                Matriz02[i, j] = MatrizAux[i, j];
                                                Console.Write(Matriz02[i, j] + "   ");
                                            }
                                        }
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("\n");
                                        Console.WriteLine("   -------------------------------------------------------------------    ");
                                    }
                                }

                                int num1 = 1;
                                int num2 = 3;
                                if (VC.Igualdad(ifilaA, num1) == 0 && VC.Igualdad(icolumnaA, num2) == 0 && VC.Igualdad(ifilaB, num1) == 0 && VC.Igualdad(icolumnaB, num2) == 0 && SiMatrizA == true && SiMatrizB == true)
                                {
                                    volvervolver = false;

                                    Matriz03 = new float[num1, num2];

                                    float iAaux = Matriz01[0, 0];
                                    float jAaux = Matriz01[0, 1];
                                    float kAaux = Matriz01[0, 2];
                                    float iBaux = Matriz02[0, 0];
                                    float jBaux = Matriz02[0, 1];
                                    float kBaux = Matriz02[0, 2];

                                    OC.ProductoCruz(iAaux, jAaux, kAaux, iBaux, jBaux, kBaux);
                                    Matriz03[0, 0] = OC.i;
                                    Matriz03[0, 1] = OC.j;
                                    Matriz03[0, 2] = OC.k;

                                    AgregarMatrizResultado(1, 3);
                                    productuosocruz = true;
                                    ImprimirMatrizEspecifica(numerocodigoAux);
                                    productuosocruz = false;
                                }
                                else
                                {
                                    volvervolver = true;
                                    Console.WriteLine("Warning: El tamaño del valor de las matrices no permite la operacion o no fue encontrada");
                                    Console.ReadLine();

                                }
                            }

                            //} while (volvervolver != false);
                            volvervolver = true;
                            break;
                        }
                    case "8":
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                            Console.WriteLine("║                         MATRIZ TRANSPUESTA                            ║ ");
                            Console.WriteLine("║                                                                       ║ ");

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("║              SIGA POR FAVOR LAS INSTRUCCIONES SIGUIENTES              ║ ");
                            Console.WriteLine("║                                                                       ║ ");
                            Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");


                            if (inicioMN == null)
                            {
                                volvervolver = true;
                                Console.WriteLine("Warning: Aun no se agregan datos suficientes para la operacion");
                                Console.ReadLine();
                            }
                            else
                            {
                                bool SiMatrizA = false;
                                bool SiMatrizB = false;
                                //MATRIZ A
                                do
                                {
                                    volvervolver = false;
                                    do
                                    {
                                        volvervolver = false;
                                        Console.WriteLine(" Escriba el codigo de la MATRIZ A que desea realizar a TRANSPUESTA");
                                        string numerosho = Console.ReadLine();

                                        int cantidad = numerosho.Length;
                                        if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                        {
                                            volvervolver = false;
                                            numerocodigoAux = Convert.ToInt32(numerosho); // convierte a int
                                        }
                                        else
                                        {
                                            volvervolver = true;
                                        }
                                    } while (volvervolver != false);

                                    if (BuscarMatriz(numerocodigoAux) != 0)
                                    {
                                        SiMatrizA = false;
                                        bool volvers = false;

                                        do
                                        {
                                            volvervolver = false;

                                            Console.WriteLine("¿Quiere intentar otro codigo?");
                                            Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                            opcion = Console.ReadLine();

                                            switch (opcion)
                                            {
                                                case "0":
                                                    volvervolver = false;
                                                    volvers = false;
                                                    break;
                                                case "1":
                                                    volvervolver = false;
                                                    volvers = true;
                                                    SiMatrizA = false;
                                                    break;
                                                default:
                                                    Console.WriteLine(" Opcion invalida");
                                                    volvervolver = true;
                                                    break;

                                            }

                                        } while (volvervolver != false);

                                        if (volvers == false)
                                        {
                                            volvervolver = true;
                                        }
                                        else
                                        {
                                            volvervolver = false;
                                        }

                                    }
                                    else
                                    {
                                        SiMatrizA = true;
                                    }
                                } while (volvervolver != false);

                                ifilaA = ifilaAux;
                                icolumnaA = icolumnaAux;
                                Matriz01 = new float[ifilaA, icolumnaA];
                                if (SiMatrizA == true)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                    Console.WriteLine(" MATRIZ A");
                                    Console.WriteLine(" Codigo: " + numerocodigoAux + "  Con filas: " + ifilaA + "  Con Columnas: " + icolumnaA);

                                    for (int i = 0; i < ifilaA; i++)
                                    {
                                        Console.Write("\n");
                                        for (int j = 0; j < icolumnaA; j++)
                                        {
                                            Matriz01[i, j] = MatrizAux[i, j];
                                            Console.Write(Matriz01[i, j] + "   ");
                                        }
                                    }
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("\n");
                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                }

                                if (SiMatrizA == true)
                                {
                                    volvervolver = false;
                                    Matriz03 = new float[icolumnaA, ifilaA];

                                    for (int iA = 0; iA < icolumnaA; iA++)
                                    {
                                            Console.Write("\n");
                                            for (int jA = 0; jA < ifilaA; jA++)
                                            {

                                                    Matriz03[iA, jA] = Matriz01[jA, iA];
                                            }

                                    }
                                    AgregarMatrizResultado(icolumnaA, ifilaA);
                                    ImprimirMatrizEspecifica(numerocodigoAux);

                                }
                                else
                                {
                                    volvervolver = true;
                                    Console.WriteLine("Warning: El tamaño del valor de las matrices no permite la operacion o no fue encontrada");
                                    Console.ReadLine();

                                }
                            }

                            volvervolver = true;
                            break;
                        }
                    case "9":
                        {
                            volvervolver = false;
                            break;
                        }
                    default:
                        Console.WriteLine(" Opcion invalida");
                        volvervolver = true;
                        break;
                }

            } while (volvervolver != false);
        }

        public void Cuaternios()
        {
            do
            {
                volvervolver = false;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                Console.WriteLine("║                            CUATERNIOS                                 ║ ");
                Console.WriteLine("║                                                                       ║ ");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("║            INSERTE UN NUMERO SEGUN LA OPCION DESEADA DEL MENU         ║ ");
                Console.WriteLine("║ 0.  Agregar Cuaternios           1. Imprimir Cuaternios               ║ ");
                Console.WriteLine("║ 2.  Modificar Cuaternios         3. Eliminar Cuaternios               ║ ");
                Console.WriteLine("║ 4.  Nulo                         5. Conjugado                         ║ ");
                Console.WriteLine("║ 6.  Opuesto                      7. Valor Absoluto                    ║ ");
                Console.WriteLine("║ 8.  Unitario                     9. Normalizacion                     ║ ");
                Console.WriteLine("║ 10. Inverso                      11. Suma                             ║ ");
                Console.WriteLine("║ 12. Resta                        13. Producto                         ║ ");
                Console.WriteLine("║ 14. Regresar                                                          ║ ");
                Console.WriteLine("║                                                                       ║ ");
                Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");


                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("   -------------------------------------------------------------------    ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("¿Que opcion elige?                                                        ");
                opcion = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("   -------------------------------------------------------------------    ");
                Console.ForegroundColor = ConsoleColor.White;

                switch (opcion)
                {
                    case "0":
                        {
                            do
                            {
                                volvervolver = false;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                                Console.WriteLine("║                         AGREGAR CUATERNIOS                            ║ ");
                                Console.WriteLine("║                                                                       ║ ");

                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("║              SIGA POR FAVOR LAS INSTRUCCIONES SIGUIENTES              ║ ");
                                Console.WriteLine("║                                                                       ║ ");
                                Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");

                                AgregarCuaternio();
                                ImprimirCuaternioEspecifico(numerocodigoAuxCN);

                                volvervolver = false;
                            } while (volvervolver != false);
                            volvervolver = true;
                            break;
                        }
                    case "1":
                        {
                            do
                            {
                                volvervolver = false;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                                Console.WriteLine("║                         IMPRIMIR CUATERNIOS                           ║ ");
                                Console.WriteLine("║                                                                       ║ ");

                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("║            INSERTE UN NUMERO SEGUN LA OPCION DESEADA DEL MENU         ║ ");
                                Console.WriteLine("║ 0. Imprimir todos los cuaternios  1. Imprimir cuaternio especifica    ║ ");
                                Console.WriteLine("║ 2. Salir                                                              ║ ");
                                Console.WriteLine("║                                                                       ║ ");
                                Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");

                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("   -------------------------------------------------------------------    ");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("¿Que opcion elige?                                                        ");
                                opcion = Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("   -------------------------------------------------------------------    ");
                                Console.ForegroundColor = ConsoleColor.White;

                                switch (opcion)
                                {
                                    case "0":
                                        ImprimirCuaternios();
                                        volvervolver = false;
                                        break;
                                    case "1":
                                        do
                                        {
                                            volvervolver = false;
                                            do
                                            {
                                                volvervolver = false;
                                                Console.WriteLine(" Escriba el codigo del cuaternio que busca");
                                                string numerosho = Console.ReadLine();

                                                int cantidad = numerosho.Length;
                                                if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                {
                                                    volvervolver = false;
                                                    numerocodigoAuxCN = Convert.ToInt32(numerosho); // convierte a int
                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                }
                                            } while (volvervolver != false);

                                            if (ImprimirCuaternioEspecifico(numerocodigoAuxCN) != 0)
                                            {

                                                bool volvers = false;

                                                do
                                                {
                                                    volvervolver = false;

                                                    Console.WriteLine("¿Quiere intentar otro codigo?");
                                                    Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                    opcion = Console.ReadLine();

                                                    switch (opcion)
                                                    {
                                                        case "0":
                                                            volvervolver = false;
                                                            volvers = false;
                                                            break;
                                                        case "1":
                                                            volvervolver = false;
                                                            volvers = true;
                                                            break;
                                                        default:
                                                            Console.WriteLine(" Opcion invalida");
                                                            volvervolver = true;
                                                            break;

                                                    }

                                                } while (volvervolver != false);

                                                if (volvers == false)
                                                {
                                                    volvervolver = true;
                                                }
                                                else
                                                {
                                                    volvervolver = false;
                                                }

                                            }
                                        } while (volvervolver != false);
                                        volvervolver = false;
                                        break;
                                    case "2":
                                        volvervolver = false;
                                        break;

                                    default:
                                        Console.WriteLine(" Opcion invalida");
                                        volvervolver = true;
                                        break;
                                }

                            } while (volvervolver != false);
                            volvervolver = true;
                            break;
                        }
                    case "2":
                        {
                            do
                            {
                                volvervolver = false;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                                Console.WriteLine("║                         MODIFICAR CUATERNIO                           ║ ");
                                Console.WriteLine("║                                                                       ║ ");

                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("║            INSERTE UN NUMERO SEGUN LA OPCION DESEADA DEL MENU         ║ ");
                                Console.WriteLine("║ 0. Modificar cuaternio    1. Modificar dato especifico del cuaternio  ║ ");
                                Console.WriteLine("║ 2. Salir                                                              ║ ");
                                Console.WriteLine("║                                                                       ║ ");
                                Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");

                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("   -------------------------------------------------------------------    ");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("¿Que opcion elige?                                                        ");
                                opcion = Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("   -------------------------------------------------------------------    ");
                                Console.ForegroundColor = ConsoleColor.White;

                                switch (opcion)
                                {
                                    case "0":
                                        do
                                        {
                                            volvervolver = false;
                                            do
                                            {
                                                volvervolver = false;
                                                Console.WriteLine(" Escriba el codigo del cuaternio que busca");
                                                string numeroshoCN = Console.ReadLine();

                                                int cantidadCN = numeroshoCN.Length;
                                                if (VC.Contador(cantidadCN, numeroshoCN) == 0 && VC.Ceros(numeroshoCN) == 0)
                                                {
                                                    volvervolver = false;
                                                    numerocodigoAuxCN = Convert.ToInt32(numeroshoCN); // convierte a int
                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                }
                                            } while (volvervolver != false);

                                            if (ModificarCuaternio(numerocodigoAuxCN) != 0)
                                            {

                                                bool volvers = false;

                                                do
                                                {
                                                    volvervolver = false;

                                                    Console.WriteLine("¿Quiere intentar otro codigo?");
                                                    Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                    opcion = Console.ReadLine();

                                                    switch (opcion)
                                                    {
                                                        case "0":
                                                            volvervolver = false;
                                                            volvers = false;
                                                            break;
                                                        case "1":
                                                            volvervolver = false;
                                                            volvers = true;
                                                            break;
                                                        default:
                                                            Console.WriteLine(" Opcion invalida");
                                                            volvervolver = true;
                                                            break;

                                                    }

                                                } while (volvervolver != false);

                                                if (volvers == false)
                                                {
                                                    volvervolver = true;
                                                }
                                                else
                                                {
                                                    volvervolver = false;
                                                }

                                            }
                                            else
                                            {
                                            ImprimirCuaternioEspecifico(numerocodigoAuxCN);
                                            }



                                        } while (volvervolver != false);
                                        volvervolver = false;
                                        break;
                                    case "1":
                                        do
                                        {
                                            volvervolver = false;
                                            do
                                            {
                                                volvervolver = false;
                                                Console.WriteLine(" Escriba el codigo del CUATERNIO que busca");
                                                string numeroshoCN = Console.ReadLine();

                                                int cantidadCN = numeroshoCN.Length;
                                                if (VC.Contador(cantidadCN, numeroshoCN) == 0 && VC.Ceros(numeroshoCN) == 0)
                                                {
                                                    volvervolver = false;
                                                numerocodigoAuxCN = Convert.ToInt32(numeroshoCN); // convierte a int
                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                }
                                            } while (volvervolver != false);

                                            if (ModificarCuaternioEspecifico(numerocodigoAuxCN) != 0)
                                            {

                                                bool volvers = false;

                                                do
                                                {
                                                    volvervolver = false;

                                                    Console.WriteLine("¿Quiere intentar otro codigo?");
                                                    Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                    opcion = Console.ReadLine();

                                                    switch (opcion)
                                                    {
                                                        case "0":
                                                            volvervolver = false;
                                                            volvers = false;
                                                            break;
                                                        case "1":
                                                            volvervolver = false;
                                                            volvers = true;
                                                            break;
                                                        default:
                                                            Console.WriteLine(" Opcion invalida");
                                                            volvervolver = true;
                                                            break;

                                                    }

                                                } while (volvervolver != false);

                                                if (volvers == false)
                                                {
                                                    volvervolver = true;
                                                }
                                                else
                                                {
                                                    volvervolver = false;
                                                }

                                            }
                                        } while (volvervolver != false);
                                        volvervolver = false;
                                        break;
                                    case "2":
                                        volvervolver = false;
                                        break;

                                    default:
                                        Console.WriteLine(" Opcion invalida");
                                        volvervolver = true;
                                        break;
                                }

                            } while (volvervolver != false);
                            volvervolver = true;
                            break;
                        }
                    case "3":
                        {
                            do
                            {
                                volvervolver = false;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                                Console.WriteLine("║                         ELIMINAR CUATERNIO                            ║ ");
                                Console.WriteLine("║                                                                       ║ ");

                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("║              SIGA POR FAVOR LAS INSTRUCCIONES SIGUIENTES              ║ ");
                                Console.WriteLine("║                                                                       ║ ");
                                Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");

                                do
                                {
                                    volvervolver = false;
                                    Console.WriteLine(" Escriba el codigo del cuaternio que quiera eliminar");
                                    string numeroshoCN = Console.ReadLine();

                                    int cantidadCN = numeroshoCN.Length;
                                    if (VC.Contador(cantidadCN, numeroshoCN) == 0 && VC.Ceros(numeroshoCN) == 0)
                                    {
                                        volvervolver = false;
                                        numerocodigoAuxCN = Convert.ToInt32(numeroshoCN); // convierte a int
                                    }
                                    else
                                    {
                                        volvervolver = true;
                                    }
                                } while (volvervolver != false);
                                if (EliminarCuaternio(numerocodigoAuxCN) != 0)
                                {

                                    bool volvers = false;

                                    do
                                    {
                                        volvervolver = false;

                                        Console.WriteLine("¿Quiere intentar otro codigo?");
                                        Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                        opcion = Console.ReadLine();

                                        switch (opcion)
                                        {
                                            case "0":
                                                volvervolver = false;
                                                volvers = false;
                                                break;
                                            case "1":
                                                volvervolver = false;
                                                volvers = true;
                                                break;
                                            default:
                                                Console.WriteLine(" Opcion invalida");
                                                volvervolver = true;
                                                break;

                                        }

                                    } while (volvervolver != false);

                                    if (volvers == false)
                                    {
                                        volvervolver = true;
                                    }
                                    else
                                    {
                                        volvervolver = false;
                                    }

                                }


                            } while (volvervolver != false);
                            volvervolver = true;
                            break;
                        }
                    case "4":
                        {
                            do
                            {
                                volvervolver = false;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                                Console.WriteLine("║                           CUATERNIO NULO                              ║ ");
                                Console.WriteLine("║                                                                       ║ ");

                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("║              SIGA POR FAVOR LAS INSTRUCCIONES SIGUIENTES              ║ ");
                                Console.WriteLine("║                                                                       ║ ");
                                Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");

                                if (inicioCN == null)
                                {
                                    volvervolver = true;
                                    Console.WriteLine("Warning: Aun no se agregan datos suficientes para la operacion");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    do
                                    {
                                        bool SiCuaternioA = false;

                                        //CUATERNIO A
                                        do
                                        {
                                            volvervolver = false;
                                            do
                                            {
                                                volvervolver = false;
                                                Console.WriteLine(" Escriba el codigo de la CUATERNIO A que desea REVISAR");
                                                string numerosho = Console.ReadLine();

                                                int cantidad = numerosho.Length;
                                                if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                {
                                                    volvervolver = false;
                                                    numerocodigoAuxCN = Convert.ToInt32(numerosho); // convierte a int
                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                }
                                            } while (volvervolver != false);

                                            if (BuscarCuaternio(numerocodigoAuxCN) != 0)
                                            {
                                                SiCuaternioA = false;
                                                bool volvers = false;

                                                do
                                                {
                                                    volvervolver = false;

                                                    Console.WriteLine("¿Quiere intentar otro codigo?");
                                                    Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                    opcion = Console.ReadLine();

                                                    switch (opcion)
                                                    {
                                                        case "0":
                                                            volvervolver = false;
                                                            volvers = false;
                                                            break;
                                                        case "1":
                                                            volvervolver = false;
                                                            volvers = true;
                                                            SiCuaternioA = false;
                                                            break;
                                                        default:
                                                            Console.WriteLine(" Opcion invalida");
                                                            volvervolver = true;
                                                            break;

                                                    }

                                                } while (volvervolver != false);

                                                if (volvers == false)
                                                {
                                                    volvervolver = true;
                                                }
                                                else
                                                {
                                                    volvervolver = false;
                                                }

                                            }
                                            else
                                            {
                                                SiCuaternioA = true;
                                            }
                                        } while (volvervolver != false);
                                        ifilaACN = ifilaAuxCN;
                                        icolumnaACN = icolumnaAuxCN;
                                        Cuaternio01 = new float[ifilaACN, icolumnaACN];
                                        if (SiCuaternioA == true)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                                            Console.WriteLine(" CUATERNIO A");
                                            Console.WriteLine(" Codigo: " + numerocodigoAuxCN + "  Con filas: " + ifilaACN + "  Con Columnas: " + icolumnaACN);

                                            for (int i = 0; i < ifilaACN; i++)
                                            {
                                                Console.Write("\n");
                                                for (int j = 0; j < icolumnaACN; j++)
                                                {
                                                    Cuaternio01[i, j] = CuaternioAux[i, j];
                                                    Console.Write(Cuaternio01[i, j] + "   ");
                                                }
                                            }
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("\n");
                                            Console.WriteLine("   -------------------------------------------------------------------    ");
                                        }


                                        if (SiCuaternioA == true)
                                        {
                                            volvervolver = false;

                                            if (Cuaternio01[0, 0] == 0 && Cuaternio01[0, 1] == 0 && Cuaternio01[0, 2] == 0 && Cuaternio01[0, 3] == 0)
                                            {
                                                Console.WriteLine("El cuaternio es NULO");
                                                Console.ReadLine();
                                            }
                                            else
                                            {
                                                Console.WriteLine("El cuaternio NO ES NULO");
                                                Console.ReadLine();
                                            }

                                            //Cuaternio03 = new float[ifilaACN, icolumnaACN];

                                            /*
                                            for (int iA = 0; iA < ifilaACN; iA++)
                                            {
                                                Console.Write("\n");
                                                for (int jA = 0; jA < icolumnaACN; jA++)
                                                {
                                                    float CuaterniosaA = Cuaternio01[iA, jA];
                                                    Cuaternio03[iA, jA] = OC.Sumar(CuaterniosaA, escalarBCN);

                                                }

                                            }
                                            AgregarCuaternioResultado(ifilaACN, icolumnaACN);
                                            ImprimirCuaternioEspecifico(numerocodigoAuxCN);
                                            */
                                        }
                                        else
                                        {
                                            volvervolver = true;
                                            Console.WriteLine("Warning: El tamaño del valor de los cuaternios no permite la operacion o no fue encontrada");
                                            Console.ReadLine();

                                        }

                                        volvervolver = false;
                                        break;
                                    

                                    } while (volvervolver != false);

                                }

                                volvervolver = false;
                            } while (volvervolver != false);
                            volvervolver = true;
                            break;
                        }
                    case "5":
                        {
                            do
                            {
                                volvervolver = false;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                                Console.WriteLine("║                        CUATERNIO CONJUGADO                            ║ ");
                                Console.WriteLine("║                                                                       ║ ");

                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("║              SIGA POR FAVOR LAS INSTRUCCIONES SIGUIENTES              ║ ");
                                Console.WriteLine("║                                                                       ║ ");
                                Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");

                                if (inicioCN == null)
                                {
                                    volvervolver = true;
                                    Console.WriteLine("Warning: Aun no se agregan datos suficientes para la operacion");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    do
                                    {
                                        bool SiCuaternioA = false;

                                        //CUATERNIO A
                                        do
                                        {
                                            volvervolver = false;
                                            do
                                            {
                                                volvervolver = false;
                                                Console.WriteLine(" Escriba el codigo de la CUATERNIO A que desea REVISAR");
                                                string numerosho = Console.ReadLine();

                                                int cantidad = numerosho.Length;
                                                if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                {
                                                    volvervolver = false;
                                                    numerocodigoAuxCN = Convert.ToInt32(numerosho); // convierte a int
                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                }
                                            } while (volvervolver != false);

                                            if (BuscarCuaternio(numerocodigoAuxCN) != 0)
                                            {
                                                SiCuaternioA = false;
                                                bool volvers = false;

                                                do
                                                {
                                                    volvervolver = false;

                                                    Console.WriteLine("¿Quiere intentar otro codigo?");
                                                    Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                    opcion = Console.ReadLine();

                                                    switch (opcion)
                                                    {
                                                        case "0":
                                                            volvervolver = false;
                                                            volvers = false;
                                                            break;
                                                        case "1":
                                                            volvervolver = false;
                                                            volvers = true;
                                                            SiCuaternioA = false;
                                                            break;
                                                        default:
                                                            Console.WriteLine(" Opcion invalida");
                                                            volvervolver = true;
                                                            break;

                                                    }

                                                } while (volvervolver != false);

                                                if (volvers == false)
                                                {
                                                    volvervolver = true;
                                                }
                                                else
                                                {
                                                    volvervolver = false;
                                                }

                                            }
                                            else
                                            {
                                                SiCuaternioA = true;
                                            }
                                        } while (volvervolver != false);
                                        ifilaACN = ifilaAuxCN;
                                        icolumnaACN = icolumnaAuxCN;
                                        Cuaternio01 = new float[ifilaACN, icolumnaACN];
                                        if (SiCuaternioA == true)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                                            Console.WriteLine(" CUATERNIO A");
                                            Console.WriteLine(" Codigo: " + numerocodigoAuxCN + "  Con filas: " + ifilaACN + "  Con Columnas: " + icolumnaACN);

                                            for (int i = 0; i < ifilaACN; i++)
                                            {
                                                Console.Write("\n");
                                                for (int j = 0; j < icolumnaACN; j++)
                                                {
                                                    Cuaternio01[i, j] = CuaternioAux[i, j];
                                                    Console.Write(Cuaternio01[i, j] + "   ");
                                                }
                                            }
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("\n");
                                            Console.WriteLine("   -------------------------------------------------------------------    ");
                                        }


                                        if (SiCuaternioA == true)
                                        {
                                            volvervolver = false;

                                            Cuaternio03 = new float[ifilaACN, icolumnaACN];

                                            
                                            for (int iA = 0; iA < ifilaACN; iA++)
                                            {
                                                Console.Write("\n");
                                                for (int jA = 0; jA < icolumnaACN; jA++)
                                                {

                                                    float CuaterniosaA = Cuaternio01[iA, jA];
                                                    if(iA == 0 && jA == 0)
                                                    {
                                                        Cuaternio03[iA, jA] = CuaterniosaA;
                                                    }
                                                    else
                                                    {
                                                        Cuaternio03[iA, jA] = OC.CambioSigno(CuaterniosaA);
                                                    }
                                                    

                                                }

                                            }
                                            AgregarCuaternioResultado(ifilaACN, icolumnaACN);
                                            ImprimirCuaternioEspecifico(numerocodigoAuxCN);
                                            
                                        }
                                        else
                                        {
                                            volvervolver = true;
                                            Console.WriteLine("Warning: El tamaño del valor de los cuaternios no permite la operacion o no fue encontrada");
                                            Console.ReadLine();

                                        }

                                        volvervolver = false;
                                        break;


                                    } while (volvervolver != false);

                                }

                                volvervolver = false;
                            } while (volvervolver != false);
                            volvervolver = true;
                            break;
                        }
                    case "6":
                        {
                            do
                            {
                                volvervolver = false;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                                Console.WriteLine("║                          CUATERNIO OPUESTO                            ║ ");
                                Console.WriteLine("║                                                                       ║ ");

                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("║              SIGA POR FAVOR LAS INSTRUCCIONES SIGUIENTES              ║ ");
                                Console.WriteLine("║                                                                       ║ ");
                                Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");

                                if (inicioCN == null)
                                {
                                    volvervolver = true;
                                    Console.WriteLine("Warning: Aun no se agregan datos suficientes para la operacion");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    do
                                    {
                                        bool SiCuaternioA = false;

                                        //CUATERNIO A
                                        do
                                        {
                                            volvervolver = false;
                                            do
                                            {
                                                volvervolver = false;
                                                Console.WriteLine(" Escriba el codigo de la CUATERNIO A que desea REVISAR");
                                                string numerosho = Console.ReadLine();

                                                int cantidad = numerosho.Length;
                                                if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                {
                                                    volvervolver = false;
                                                    numerocodigoAuxCN = Convert.ToInt32(numerosho); // convierte a int
                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                }
                                            } while (volvervolver != false);

                                            if (BuscarCuaternio(numerocodigoAuxCN) != 0)
                                            {
                                                SiCuaternioA = false;
                                                bool volvers = false;

                                                do
                                                {
                                                    volvervolver = false;

                                                    Console.WriteLine("¿Quiere intentar otro codigo?");
                                                    Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                    opcion = Console.ReadLine();

                                                    switch (opcion)
                                                    {
                                                        case "0":
                                                            volvervolver = false;
                                                            volvers = false;
                                                            break;
                                                        case "1":
                                                            volvervolver = false;
                                                            volvers = true;
                                                            SiCuaternioA = false;
                                                            break;
                                                        default:
                                                            Console.WriteLine(" Opcion invalida");
                                                            volvervolver = true;
                                                            break;

                                                    }

                                                } while (volvervolver != false);

                                                if (volvers == false)
                                                {
                                                    volvervolver = true;
                                                }
                                                else
                                                {
                                                    volvervolver = false;
                                                }

                                            }
                                            else
                                            {
                                                SiCuaternioA = true;
                                            }
                                        } while (volvervolver != false);
                                        ifilaACN = ifilaAuxCN;
                                        icolumnaACN = icolumnaAuxCN;
                                        Cuaternio01 = new float[ifilaACN, icolumnaACN];
                                        if (SiCuaternioA == true)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                                            Console.WriteLine(" CUATERNIO A");
                                            Console.WriteLine(" Codigo: " + numerocodigoAuxCN + "  Con filas: " + ifilaACN + "  Con Columnas: " + icolumnaACN);

                                            for (int i = 0; i < ifilaACN; i++)
                                            {
                                                Console.Write("\n");
                                                for (int j = 0; j < icolumnaACN; j++)
                                                {
                                                    Cuaternio01[i, j] = CuaternioAux[i, j];
                                                    Console.Write(Cuaternio01[i, j] + "   ");
                                                }
                                            }
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("\n");
                                            Console.WriteLine("   -------------------------------------------------------------------    ");
                                        }


                                        if (SiCuaternioA == true)
                                        {
                                            volvervolver = false;

                                            Cuaternio03 = new float[ifilaACN, icolumnaACN];


                                            for (int iA = 0; iA < ifilaACN; iA++)
                                            {
                                                Console.Write("\n");
                                                for (int jA = 0; jA < icolumnaACN; jA++)
                                                {

                                                    float CuaterniosaA = Cuaternio01[iA, jA];                                                    
                                                    Cuaternio03[iA, jA] = OC.CambioSigno(CuaterniosaA);
                                                  


                                                }

                                            }
                                            AgregarCuaternioResultado(ifilaACN, icolumnaACN);
                                            ImprimirCuaternioEspecifico(numerocodigoAuxCN);

                                        }
                                        else
                                        {
                                            volvervolver = true;
                                            Console.WriteLine("Warning: El tamaño del valor de los cuaternios no permite la operacion o no fue encontrada");
                                            Console.ReadLine();

                                        }

                                        volvervolver = false;
                                        break;


                                    } while (volvervolver != false);

                                }

                                volvervolver = false;
                            } while (volvervolver != false);
                            volvervolver = true;
                            break;
                        }
                    case "7":
                        {
                            do
                            {
                                volvervolver = false;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                                Console.WriteLine("║                       CUATERNIO VALOR ABSOLUTO                        ║ ");
                                Console.WriteLine("║                                                                       ║ ");

                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("║              SIGA POR FAVOR LAS INSTRUCCIONES SIGUIENTES              ║ ");
                                Console.WriteLine("║                                                                       ║ ");
                                Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");

                                if (inicioCN == null)
                                {
                                    volvervolver = true;
                                    Console.WriteLine("Warning: Aun no se agregan datos suficientes para la operacion");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    do
                                    {
                                        bool SiCuaternioA = false;

                                        //CUATERNIO A
                                        do
                                        {
                                            volvervolver = false;
                                            do
                                            {
                                                volvervolver = false;
                                                Console.WriteLine(" Escriba el codigo de la CUATERNIO A que desea REVISAR");
                                                string numerosho = Console.ReadLine();

                                                int cantidad = numerosho.Length;
                                                if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                {
                                                    volvervolver = false;
                                                    numerocodigoAuxCN = Convert.ToInt32(numerosho); // convierte a int
                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                }
                                            } while (volvervolver != false);

                                            if (BuscarCuaternio(numerocodigoAuxCN) != 0)
                                            {
                                                SiCuaternioA = false;
                                                bool volvers = false;

                                                do
                                                {
                                                    volvervolver = false;

                                                    Console.WriteLine("¿Quiere intentar otro codigo?");
                                                    Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                    opcion = Console.ReadLine();

                                                    switch (opcion)
                                                    {
                                                        case "0":
                                                            volvervolver = false;
                                                            volvers = false;
                                                            break;
                                                        case "1":
                                                            volvervolver = false;
                                                            volvers = true;
                                                            SiCuaternioA = false;
                                                            break;
                                                        default:
                                                            Console.WriteLine(" Opcion invalida");
                                                            volvervolver = true;
                                                            break;

                                                    }

                                                } while (volvervolver != false);

                                                if (volvers == false)
                                                {
                                                    volvervolver = true;
                                                }
                                                else
                                                {
                                                    volvervolver = false;
                                                }

                                            }
                                            else
                                            {
                                                SiCuaternioA = true;
                                            }
                                        } while (volvervolver != false);
                                        ifilaACN = ifilaAuxCN;
                                        icolumnaACN = icolumnaAuxCN;
                                        Cuaternio01 = new float[ifilaACN, icolumnaACN];
                                        if (SiCuaternioA == true)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                                            Console.WriteLine(" CUATERNIO A");
                                            Console.WriteLine(" Codigo: " + numerocodigoAuxCN + "  Con filas: " + ifilaACN + "  Con Columnas: " + icolumnaACN);

                                            for (int i = 0; i < ifilaACN; i++)
                                            {
                                                Console.Write("\n");
                                                for (int j = 0; j < icolumnaACN; j++)
                                                {
                                                    Cuaternio01[i, j] = CuaternioAux[i, j];
                                                    Console.Write(Cuaternio01[i, j] + "   ");
                                                }
                                            }
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("\n");
                                            Console.WriteLine("   -------------------------------------------------------------------    ");
                                        }


                                        if (SiCuaternioA == true)
                                        {
                                            volvervolver = false;

                                            Cuaternio03 = new float[ifilaACN, icolumnaACN];


                                            float suma = 0;
                                            float sumaaux = 0;

                                            for (int iA = 0; iA < ifilaACN; iA++)
                                            {
                                                Console.Write("\n");
                                                for (int jA = 0; jA < icolumnaACN; jA++)
                                                {
                                                    
                                                    sumaaux = OC.Potencia(Cuaternio01[iA, jA], 2);
                                                    suma = suma + sumaaux;                                                    
                                                }

                                            }
                                            float resultado = OC.RaizCuadrada(suma);
                                            Console.WriteLine("El VALOR ABSOLUTO es:" + resultado);
                                            Console.ReadLine();

                                        }
                                        else
                                        {
                                            volvervolver = true;
                                            Console.WriteLine("Warning: El tamaño del valor de los cuaternios no permite la operacion o no fue encontrada");
                                            Console.ReadLine();

                                        }

                                        volvervolver = false;
                                        break;


                                    } while (volvervolver != false);

                                }

                                volvervolver = false;
                            } while (volvervolver != false);
                            volvervolver = true;
                            break;
                        }
                    case "8":
                        {
                            do
                            {
                                volvervolver = false;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                                Console.WriteLine("║                         CUATERNIO UNITARIO                            ║ ");
                                Console.WriteLine("║                                                                       ║ ");

                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("║              SIGA POR FAVOR LAS INSTRUCCIONES SIGUIENTES              ║ ");
                                Console.WriteLine("║                                                                       ║ ");
                                Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");

                                if (inicioCN == null)
                                {
                                    volvervolver = true;
                                    Console.WriteLine("Warning: Aun no se agregan datos suficientes para la operacion");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    do
                                    {
                                        bool SiCuaternioA = false;

                                        //CUATERNIO A
                                        do
                                        {
                                            volvervolver = false;
                                            do
                                            {
                                                volvervolver = false;
                                                Console.WriteLine(" Escriba el codigo de la CUATERNIO A que desea REVISAR");
                                                string numerosho = Console.ReadLine();

                                                int cantidad = numerosho.Length;
                                                if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                {
                                                    volvervolver = false;
                                                    numerocodigoAuxCN = Convert.ToInt32(numerosho); // convierte a int
                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                }
                                            } while (volvervolver != false);

                                            if (BuscarCuaternio(numerocodigoAuxCN) != 0)
                                            {
                                                SiCuaternioA = false;
                                                bool volvers = false;

                                                do
                                                {
                                                    volvervolver = false;

                                                    Console.WriteLine("¿Quiere intentar otro codigo?");
                                                    Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                    opcion = Console.ReadLine();

                                                    switch (opcion)
                                                    {
                                                        case "0":
                                                            volvervolver = false;
                                                            volvers = false;
                                                            break;
                                                        case "1":
                                                            volvervolver = false;
                                                            volvers = true;
                                                            SiCuaternioA = false;
                                                            break;
                                                        default:
                                                            Console.WriteLine(" Opcion invalida");
                                                            volvervolver = true;
                                                            break;

                                                    }

                                                } while (volvervolver != false);

                                                if (volvers == false)
                                                {
                                                    volvervolver = true;
                                                }
                                                else
                                                {
                                                    volvervolver = false;
                                                }

                                            }
                                            else
                                            {
                                                SiCuaternioA = true;
                                            }
                                        } while (volvervolver != false);
                                        ifilaACN = ifilaAuxCN;
                                        icolumnaACN = icolumnaAuxCN;
                                        Cuaternio01 = new float[ifilaACN, icolumnaACN];
                                        if (SiCuaternioA == true)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                                            Console.WriteLine(" CUATERNIO A");
                                            Console.WriteLine(" Codigo: " + numerocodigoAuxCN + "  Con filas: " + ifilaACN + "  Con Columnas: " + icolumnaACN);

                                            for (int i = 0; i < ifilaACN; i++)
                                            {
                                                Console.Write("\n");
                                                for (int j = 0; j < icolumnaACN; j++)
                                                {
                                                    Cuaternio01[i, j] = CuaternioAux[i, j];
                                                    Console.Write(Cuaternio01[i, j] + "   ");
                                                }
                                            }
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("\n");
                                            Console.WriteLine("   -------------------------------------------------------------------    ");
                                        }


                                        if (SiCuaternioA == true)
                                        {
                                            Cuaternio03 = new float[ifilaACN, icolumnaACN];


                                            float suma = 0;
                                            float sumaaux = 0;

                                            for (int iA = 0; iA < ifilaACN; iA++)
                                            {
                                                Console.Write("\n");
                                                for (int jA = 0; jA < icolumnaACN; jA++)
                                                {

                                                    sumaaux = OC.Potencia(Cuaternio01[iA, jA], 2);
                                                    suma = suma + sumaaux;
                                                }

                                            }
                                            float resultado = OC.RaizCuadrada(suma);

                                            if (resultado == 1)
                                            {
                                                Console.WriteLine("El VALOR ABSOLUTO es UNITARIO");
                                                Console.WriteLine("El VALOR ABSOLUTO es:" + resultado);
                                                Console.ReadLine();

                                            } else
                                            {
                                                Console.WriteLine("El VALOR ABSOLUTO es NO ES UNITARIO");
                                                Console.WriteLine("El VALOR ABSOLUTO es:" + resultado);
                                                Console.ReadLine();
                                            }



                                        }
                                        else
                                        {
                                            volvervolver = true;
                                            Console.WriteLine("Warning: El tamaño del valor de los cuaternios no permite la operacion o no fue encontrada");
                                            Console.ReadLine();

                                        }

                                        volvervolver = false;
                                        break;


                                    } while (volvervolver != false);

                                }

                                volvervolver = false;
                            } while (volvervolver != false);
                            volvervolver = true;
                            break;
                        }
                    case "9":
                        {
                            do
                            {
                                volvervolver = false;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                                Console.WriteLine("║                        CUATERNIO NORMALIZACION                        ║ ");
                                Console.WriteLine("║                                                                       ║ ");

                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("║              SIGA POR FAVOR LAS INSTRUCCIONES SIGUIENTES              ║ ");
                                Console.WriteLine("║                                                                       ║ ");
                                Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");

                                if (inicioCN == null)
                                {
                                    volvervolver = true;
                                    Console.WriteLine("Warning: Aun no se agregan datos suficientes para la operacion");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    bool SiCuaternioA = false;
                                    bool SiCuaternioB = false;
                                    //CUATERNIO UNITARIO
                                    do
                                    {
                                        volver = false;
                                        Console.WriteLine(" Escriba el numero del CUATERNIO UNITARIO asociado");
                                        string numeromatriz = Console.ReadLine();
                                        int cantidad = numeromatriz.Length;
                                        if (VC.Contador(cantidad, numeromatriz) == 0)
                                        {
                                            volver = false;
                                            float inumerocuaternio = (float)Convert.ToDouble(numeromatriz);
                                            inumerocuaternio = (float)Math.Round(inumerocuaternio, 2);
                                            escalarACN = inumerocuaternio;
                                            SiCuaternioA = true;
                                        }
                                        else
                                        {
                                            SiCuaternioA = false;
                                            volver = true;
                                        }
                                    } while (volver != false);

                                    //CUATERNIO B
                                    if (SiCuaternioA == true)
                                    {
                                        do
                                        {
                                            volvervolver = false;
                                            do
                                            {
                                                volvervolver = false;
                                                Console.WriteLine(" Escriba el codigo del CUATERNIO B que desea RESTAR");
                                                string numerosho = Console.ReadLine();

                                                int cantidad = numerosho.Length;
                                                if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                {
                                                    volvervolver = false;
                                                    numerocodigoAuxCN = Convert.ToInt32(numerosho); // convierte a int
                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                }
                                            } while (volvervolver != false);

                                            if (BuscarCuaternio(numerocodigoAuxCN) != 0)
                                            {
                                                SiCuaternioB = false;
                                                bool volvers = false;

                                                do
                                                {
                                                    volvervolver = false;

                                                    Console.WriteLine("¿Quiere intentar otro codigo?");
                                                    Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                    opcion = Console.ReadLine();

                                                    switch (opcion)
                                                    {
                                                        case "0":
                                                            volvervolver = false;
                                                            volvers = false;
                                                            break;
                                                        case "1":
                                                            volvervolver = false;
                                                            volvers = true;
                                                            break;
                                                        default:
                                                            Console.WriteLine(" Opcion invalida");
                                                            volvervolver = true;
                                                            break;

                                                    }

                                                } while (volvervolver != false);

                                                if (volvers == false)
                                                {
                                                    volvervolver = true;
                                                }
                                                else
                                                {
                                                    volvervolver = false;
                                                }

                                            }
                                            else
                                            {
                                                SiCuaternioB = true;
                                            }
                                        } while (volvervolver != false);
                                        ifilaBCN = ifilaAuxCN;
                                        icolumnaBCN = icolumnaAuxCN;
                                        Cuaternio02 = new float[ifilaBCN, icolumnaBCN];
                                        if (SiCuaternioB == true)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine(" MATRIZ B");
                                            Console.WriteLine(" Codigo: " + numerocodigoAuxCN + "  Con filas: " + ifilaBCN + "  Con Columnas: " + icolumnaBCN);

                                            for (int i = 0; i < ifilaBCN; i++)
                                            {
                                                Console.Write("\n");
                                                for (int j = 0; j < icolumnaBCN; j++)
                                                {
                                                    Cuaternio02[i, j] = CuaternioAux[i, j];
                                                    Console.Write(Cuaternio02[i, j] + "   ");
                                                }
                                            }
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("\n");
                                            Console.WriteLine("   -------------------------------------------------------------------    ");
                                        }
                                    }



                                    if (SiCuaternioA == true && SiCuaternioB == true)
                                    {
                                        volvervolver = false;

                                        Cuaternio03 = new float[ifilaBCN, icolumnaBCN];
                                        OC.Normalizacion(Cuaternio02[0, 0], Cuaternio02[0, 1], Cuaternio02[0, 2], Cuaternio02[0, 3], escalarACN);

                                        for (int iA = 0; iA < ifilaBCN; iA++)
                                        {
                                            Console.Write("\n");
                                            for (int jA = 0; jA < icolumnaBCN; jA++)
                                            {
                                                float CuaterniosaB;

                                                switch (jA)
                                                {
                                                    case 0:
                                                        CuaterniosaB = OC.r;
                                                        break;
                                                    case 1:
                                                        CuaterniosaB = OC.i;
                                                        break;
                                                    case 2:
                                                        CuaterniosaB = OC.j;
                                                        break;
                                                    case 3:
                                                        CuaterniosaB = OC.k;
                                                        break;
                                                    default:
                                                        CuaterniosaB = 0;
                                                        break;
                                                }
                                                Cuaternio03[iA, jA] = CuaterniosaB;

                                            }

                                        }


                                        AgregarCuaternioResultado(ifilaBCN, icolumnaBCN);
                                        ImprimirCuaternioEspecifico(numerocodigoAuxCN);

                                    }
                                    else
                                    {
                                        volvervolver = true;
                                        Console.WriteLine("Warning: El tamaño del valor del cuaternio no permite la operacion o no fue encontrada");
                                        Console.ReadLine();

                                    }

                                    volvervolver = false;
                                    break;

                                }

                                volvervolver = false;
                            } while (volvervolver != false);
                            volvervolver = true;
                            break;
                        }
                    case "10":
                        {
                            do
                            {
                                volvervolver = false;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                                Console.WriteLine("║                          CUATERNIO INVERSO                            ║ ");
                                Console.WriteLine("║                                                                       ║ ");

                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("║              SIGA POR FAVOR LAS INSTRUCCIONES SIGUIENTES              ║ ");
                                Console.WriteLine("║                                                                       ║ ");
                                Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");

                                if (inicioCN == null)
                                {
                                    volvervolver = true;
                                    Console.WriteLine("Warning: Aun no se agregan datos suficientes para la operacion");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    bool SiCuaternioA = false;
                                    bool SiCuaternioB = false;
                                    //CUATERNIO UNITARIO
                                    do
                                    {
                                        volver = false;
                                        Console.WriteLine(" Escriba el numero del CUATERNIO UNITARIO asociado");
                                        string numeromatriz = Console.ReadLine();
                                        int cantidad = numeromatriz.Length;
                                        if (VC.Contador(cantidad, numeromatriz) == 0)
                                        {
                                            volver = false;
                                            float inumerocuaternio = (float)Convert.ToDouble(numeromatriz);
                                            inumerocuaternio = (float)Math.Round(inumerocuaternio, 2);
                                            escalarACN = inumerocuaternio;
                                            SiCuaternioA = true;
                                        }
                                        else
                                        {
                                            SiCuaternioA = false;
                                            volver = true;
                                        }
                                    } while (volver != false);

                                    //CUATERNIO B
                                    if (SiCuaternioA == true)
                                    {
                                        do
                                        {
                                            volvervolver = false;
                                            do
                                            {
                                                volvervolver = false;
                                                Console.WriteLine(" Escriba el codigo del CUATERNIO B que desea RESTAR");
                                                string numerosho = Console.ReadLine();

                                                int cantidad = numerosho.Length;
                                                if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                {
                                                    volvervolver = false;
                                                    numerocodigoAuxCN = Convert.ToInt32(numerosho); // convierte a int
                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                }
                                            } while (volvervolver != false);

                                            if (BuscarCuaternio(numerocodigoAuxCN) != 0)
                                            {
                                                SiCuaternioB = false;
                                                bool volvers = false;

                                                do
                                                {
                                                    volvervolver = false;

                                                    Console.WriteLine("¿Quiere intentar otro codigo?");
                                                    Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                    opcion = Console.ReadLine();

                                                    switch (opcion)
                                                    {
                                                        case "0":
                                                            volvervolver = false;
                                                            volvers = false;
                                                            break;
                                                        case "1":
                                                            volvervolver = false;
                                                            volvers = true;
                                                            break;
                                                        default:
                                                            Console.WriteLine(" Opcion invalida");
                                                            volvervolver = true;
                                                            break;

                                                    }

                                                } while (volvervolver != false);

                                                if (volvers == false)
                                                {
                                                    volvervolver = true;
                                                }
                                                else
                                                {
                                                    volvervolver = false;
                                                }

                                            }
                                            else
                                            {
                                                SiCuaternioB = true;
                                            }
                                        } while (volvervolver != false);
                                        ifilaBCN = ifilaAuxCN;
                                        icolumnaBCN = icolumnaAuxCN;
                                        Cuaternio02 = new float[ifilaBCN, icolumnaBCN];
                                        if (SiCuaternioB == true)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine(" MATRIZ B");
                                            Console.WriteLine(" Codigo: " + numerocodigoAuxCN + "  Con filas: " + ifilaBCN + "  Con Columnas: " + icolumnaBCN);

                                            for (int i = 0; i < ifilaBCN; i++)
                                            {
                                                Console.Write("\n");
                                                for (int j = 0; j < icolumnaBCN; j++)
                                                {
                                                    Cuaternio02[i, j] = CuaternioAux[i, j];
                                                    Console.Write(Cuaternio02[i, j] + "   ");
                                                }
                                            }
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("\n");
                                            Console.WriteLine("   -------------------------------------------------------------------    ");
                                        }
                                    }



                                    if (SiCuaternioA == true && SiCuaternioB == true)
                                    {
                                        volvervolver = false;

                                        Cuaternio03 = new float[ifilaBCN, icolumnaBCN];
                                        OC.NormalizacionInverso(Cuaternio02[0, 0], Cuaternio02[0, 1], Cuaternio02[0, 2], Cuaternio02[0, 3], escalarACN);

                                        for (int iA = 0; iA < ifilaBCN; iA++)
                                        {
                                            Console.Write("\n");
                                            for (int jA = 0; jA < icolumnaBCN; jA++)
                                            {
                                                float CuaterniosaB;

                                                switch (jA)
                                                {
                                                    case 0:
                                                        CuaterniosaB = OC.r;
                                                        break;
                                                    case 1:
                                                        CuaterniosaB = OC.i;
                                                        break;
                                                    case 2:
                                                        CuaterniosaB = OC.j;
                                                        break;
                                                    case 3:
                                                        CuaterniosaB = OC.k;
                                                        break;
                                                    default:
                                                        CuaterniosaB = 0;
                                                        break;
                                                }
                                                Cuaternio03[iA, jA] = CuaterniosaB;

                                            }

                                        }


                                        AgregarCuaternioResultado(ifilaBCN, icolumnaBCN);
                                        ImprimirCuaternioEspecifico(numerocodigoAuxCN);

                                    }
                                    else
                                    {
                                        volvervolver = true;
                                        Console.WriteLine("Warning: El tamaño del valor del cuaternio no permite la operacion o no fue encontrada");
                                        Console.ReadLine();

                                    }

                                    volvervolver = false;
                                    break;

                                }

                                volvervolver = false;
                            } while (volvervolver != false);
                            volvervolver = true;
                            break;
                        }
                    case "11":    
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                            Console.WriteLine("║                          SUMAR CUATERNIOS                             ║ ");
                            Console.WriteLine("║                                                                       ║ ");

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("║              SIGA POR FAVOR LAS INSTRUCCIONES SIGUIENTES              ║ ");
                            Console.WriteLine("║                                                                       ║ ");
                            Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");


                            if (inicioCN == null)
                            {
                                volvervolver = true;
                                Console.WriteLine("Warning: Aun no se agregan datos suficientes para la operacion");
                                Console.ReadLine();
                            }
                            else
                            {
                                do
                                {

                                    Console.WriteLine(" ");
                                    Console.WriteLine("¿COMO REALIZARAS LA SUMA? 0. CUATERNIO-CUATERNIO | 1. Escalar-CUATERNIO | 2. CUATERNIO-Escalar");
                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("¿Que opcion elige?                                                        ");
                                    opcion = Console.ReadLine();
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                    Console.ForegroundColor = ConsoleColor.White;

                                    switch (opcion)
                                    {
                                        case "0":
                                            {
                                                bool SiCuaternioA = false;
                                                bool SiCuaternioB = false;
                                                //CUATERNIO A
                                                do
                                                {
                                                    volvervolver = false;
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        Console.WriteLine(" Escriba el codigo del CUATERNIO A que desea sumar");
                                                        string numerosho = Console.ReadLine();

                                                        int cantidad = numerosho.Length;
                                                        if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                        {
                                                            volvervolver = false;
                                                            numerocodigoAuxCN = Convert.ToInt32(numerosho); // convierte a int
                                                        }
                                                        else
                                                        {
                                                            volvervolver = true;
                                                        }
                                                    } while (volvervolver != false);

                                                    if (BuscarCuaternio(numerocodigoAuxCN) != 0)
                                                    {
                                                        SiCuaternioA = false;
                                                        bool volvers = false;

                                                        do
                                                        {
                                                            volvervolver = false;

                                                            Console.WriteLine("¿Quiere intentar otro codigo?");
                                                            Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                            opcion = Console.ReadLine();

                                                            switch (opcion)
                                                            {
                                                                case "0":
                                                                    volvervolver = false;
                                                                    volvers = false;
                                                                    break;
                                                                case "1":
                                                                    volvervolver = false;
                                                                    volvers = true;
                                                                    SiCuaternioA = false;
                                                                    break;
                                                                default:
                                                                    Console.WriteLine(" Opcion invalida");
                                                                    volvervolver = true;
                                                                    break;

                                                            }

                                                        } while (volvervolver != false);

                                                        if (volvers == false)
                                                        {
                                                            volvervolver = true;
                                                        }
                                                        else
                                                        {
                                                            volvervolver = false;
                                                        }

                                                    }
                                                    else
                                                    {
                                                        SiCuaternioA = true;
                                                    }
                                                } while (volvervolver != false);

                                                ifilaACN = ifilaAuxCN;
                                                icolumnaACN = icolumnaAuxCN;
                                                Cuaternio01 = new float[ifilaACN, icolumnaACN];
                                                if (SiCuaternioA == true)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                                    Console.WriteLine(" CUATERNIO A");
                                                    Console.WriteLine(" Codigo: " + numerocodigoAuxCN + "  Con filas: " + ifilaACN + "  Con Columnas: " + icolumnaACN);

                                                    for (int i = 0; i < ifilaACN; i++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int j = 0; j < icolumnaACN; j++)
                                                        {
                                                            Cuaternio01[i, j] = CuaternioAux[i, j];
                                                            Console.Write(Cuaternio01[i, j] + "   ");
                                                        }
                                                    }
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("\n");
                                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                                }

                                                //CUATERNIO B
                                                if (SiCuaternioA == true)
                                                {
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        do
                                                        {
                                                            volvervolver = false;
                                                            Console.WriteLine(" Escriba el codigo de la CUATERNIO B que desea sumar");
                                                            string numerosho = Console.ReadLine();

                                                            int cantidad = numerosho.Length;
                                                            if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                            {
                                                                volvervolver = false;
                                                                numerocodigoAuxCN = Convert.ToInt32(numerosho); // convierte a int
                                                            }
                                                            else
                                                            {
                                                                volvervolver = true;
                                                            }
                                                        } while (volvervolver != false);

                                                        if (BuscarCuaternio(numerocodigoAuxCN) != 0)
                                                        {
                                                            SiCuaternioB = false;
                                                            bool volvers = false;

                                                            do
                                                            {
                                                                volvervolver = false;

                                                                Console.WriteLine("¿Quiere intentar otro codigo?");
                                                                Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                                opcion = Console.ReadLine();

                                                                switch (opcion)
                                                                {
                                                                    case "0":
                                                                        volvervolver = false;
                                                                        volvers = false;
                                                                        break;
                                                                    case "1":
                                                                        volvervolver = false;
                                                                        volvers = true;
                                                                        break;
                                                                    default:
                                                                        Console.WriteLine(" Opcion invalida");
                                                                        volvervolver = true;
                                                                        break;

                                                                }

                                                            } while (volvervolver != false);

                                                            if (volvers == false)
                                                            {
                                                                volvervolver = true;
                                                            }
                                                            else
                                                            {
                                                                volvervolver = false;
                                                            }

                                                        }
                                                        else
                                                        {
                                                            SiCuaternioB = true;
                                                        }
                                                    } while (volvervolver != false);
                                                    ifilaBCN = ifilaAuxCN;
                                                    icolumnaBCN = icolumnaAuxCN;
                                                    Cuaternio02 = new float[ifilaBCN, icolumnaBCN];
                                                    if (SiCuaternioB == true)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                                        Console.WriteLine(" CUATERNIO B");
                                                        Console.WriteLine(" Codigo: " + numerocodigoAuxCN + "  Con filas: " + ifilaBCN + "  Con Columnas: " + icolumnaBCN);

                                                        for (int i = 0; i < ifilaBCN; i++)
                                                        {
                                                            Console.Write("\n");
                                                            for (int j = 0; j < icolumnaBCN; j++)
                                                            {
                                                                Cuaternio02[i, j] = CuaternioAux[i, j];
                                                                Console.Write(Cuaternio02[i, j] + "   ");
                                                            }
                                                        }
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        Console.WriteLine("\n");
                                                        Console.WriteLine("   -------------------------------------------------------------------    ");
                                                    }
                                                }

                                                if (VC.Igualdad(ifilaACN, ifilaBCN) == 0 && VC.Igualdad(icolumnaACN, icolumnaBCN) == 0 && SiCuaternioA == true && SiCuaternioB == true)
                                                {
                                                    volvervolver = false;

                                                    Cuaternio03 = new float[ifilaACN, icolumnaACN];

                                                    for (int iA = 0; iA < ifilaACN; iA++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int jA = 0; jA < icolumnaACN; jA++)
                                                        {

                                                            float CuaterniosaA = Cuaternio01[iA, jA];
                                                            float CuaterniosaB = Cuaternio02[iA, jA];

                                                            Cuaternio03[iA, jA] = OC.Sumar(CuaterniosaA, CuaterniosaB);


                                                        }

                                                    }


                                                    AgregarCuaternioResultado(ifilaACN, icolumnaACN);
                                                    ImprimirCuaternioEspecifico(numerocodigoAuxCN);

                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                    Console.WriteLine("Warning: El tamaño del valor del cuaternio no permite la operacion o no fue encontrada");
                                                    Console.ReadLine();

                                                }

                                                volvervolver = false;
                                                break;
                                            }
                                        case "1":
                                            {
                                                bool SiCuaternioA = false;
                                                bool SiCuaternioB = false;
                                                //ESCALAR
                                                do
                                                {
                                                    volver = false;
                                                    Console.WriteLine(" Escriba el numero a sumar");
                                                    string numeromatriz = Console.ReadLine();
                                                    int cantidad = numeromatriz.Length;
                                                    if (VC.Contador(cantidad, numeromatriz) == 0)
                                                    {
                                                        volver = false;
                                                        float inumerocuaternio = (float)Convert.ToDouble(numeromatriz);
                                                        inumerocuaternio = (float)Math.Round(inumerocuaternio, 2);
                                                        escalarACN = inumerocuaternio;
                                                        SiCuaternioA = true;
                                                    }
                                                    else
                                                    {
                                                        SiCuaternioA = false;
                                                        volver = true;
                                                    }
                                                } while (volver != false);

                                                //CUATERNIO B
                                                if (SiCuaternioA == true)
                                                {
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        do
                                                        {
                                                            volvervolver = false;
                                                            Console.WriteLine(" Escriba el codigo del CUATERNIO B que desea sumar");
                                                            string numerosho = Console.ReadLine();

                                                            int cantidad = numerosho.Length;
                                                            if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                            {
                                                                volvervolver = false;
                                                                numerocodigoAuxCN = Convert.ToInt32(numerosho); // convierte a int
                                                            }
                                                            else
                                                            {
                                                                volvervolver = true;
                                                            }
                                                        } while (volvervolver != false);

                                                        if (BuscarCuaternio(numerocodigoAuxCN) != 0)
                                                        {
                                                            SiCuaternioB = false;
                                                            bool volvers = false;

                                                            do
                                                            {
                                                                volvervolver = false;

                                                                Console.WriteLine("¿Quiere intentar otro codigo?");
                                                                Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                                opcion = Console.ReadLine();

                                                                switch (opcion)
                                                                {
                                                                    case "0":
                                                                        volvervolver = false;
                                                                        volvers = false;
                                                                        break;
                                                                    case "1":
                                                                        volvervolver = false;
                                                                        volvers = true;
                                                                        break;
                                                                    default:
                                                                        Console.WriteLine(" Opcion invalida");
                                                                        volvervolver = true;
                                                                        break;

                                                                }

                                                            } while (volvervolver != false);

                                                            if (volvers == false)
                                                            {
                                                                volvervolver = true;
                                                            }
                                                            else
                                                            {
                                                                volvervolver = false;
                                                            }

                                                        }
                                                        else
                                                        {
                                                            SiCuaternioB = true;
                                                        }
                                                    } while (volvervolver != false);
                                                    ifilaBCN = ifilaAuxCN;
                                                    icolumnaBCN = icolumnaAuxCN;
                                                    Cuaternio02 = new float[ifilaBCN, icolumnaBCN];
                                                    if (SiCuaternioB == true)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                                        Console.WriteLine(" MATRIZ B");
                                                        Console.WriteLine(" Codigo: " + numerocodigoAuxCN + "  Con filas: " + ifilaBCN + "  Con Columnas: " + icolumnaBCN);

                                                        for (int i = 0; i < ifilaBCN; i++)
                                                        {
                                                            Console.Write("\n");
                                                            for (int j = 0; j < icolumnaBCN; j++)
                                                            {
                                                                Cuaternio02[i, j] = CuaternioAux[i, j];
                                                                Console.Write(Cuaternio02[i, j] + "   ");
                                                            }
                                                        }
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        Console.WriteLine("\n");
                                                        Console.WriteLine("   -------------------------------------------------------------------    ");
                                                    }
                                                }



                                                if (SiCuaternioA == true && SiCuaternioB == true)
                                                {
                                                    volvervolver = false;

                                                    Cuaternio03 = new float[ifilaBCN, icolumnaBCN];

                                                    for (int iA = 0; iA < ifilaBCN; iA++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int jA = 0; jA < icolumnaBCN; jA++)
                                                        {
                                                            float CuaterniosaB = Cuaternio02[iA, jA];

                                                            Cuaternio03[iA, jA] = OC.Sumar(escalarACN, CuaterniosaB);


                                                        }

                                                    }


                                                    AgregarCuaternioResultado(ifilaBCN, icolumnaBCN);
                                                    ImprimirCuaternioEspecifico(numerocodigoAuxCN);

                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                    Console.WriteLine("Warning: El tamaño del valor del cuaternio no permite la operacion o no fue encontrada");
                                                    Console.ReadLine();

                                                }

                                                volvervolver = false;
                                                break;
                                            }
                                        case "2":
                                            {
                                                bool SiCuaternioA = false;
                                                bool SiCuaternioB = false;
                                                //CUATERNIO A
                                                do
                                                {
                                                    volvervolver = false;
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        Console.WriteLine(" Escriba el codigo de la CUATERNIO A que desea sumar");
                                                        string numerosho = Console.ReadLine();

                                                        int cantidad = numerosho.Length;
                                                        if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                        {
                                                            volvervolver = false;
                                                            numerocodigoAuxCN = Convert.ToInt32(numerosho); // convierte a int
                                                        }
                                                        else
                                                        {
                                                            volvervolver = true;
                                                        }
                                                    } while (volvervolver != false);

                                                    if (BuscarCuaternio(numerocodigoAuxCN) != 0)
                                                    {
                                                        SiCuaternioA = false;
                                                        bool volvers = false;

                                                        do
                                                        {
                                                            volvervolver = false;

                                                            Console.WriteLine("¿Quiere intentar otro codigo?");
                                                            Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                            opcion = Console.ReadLine();

                                                            switch (opcion)
                                                            {
                                                                case "0":
                                                                    volvervolver = false;
                                                                    volvers = false;
                                                                    break;
                                                                case "1":
                                                                    volvervolver = false;
                                                                    volvers = true;
                                                                    SiCuaternioA = false;
                                                                    break;
                                                                default:
                                                                    Console.WriteLine(" Opcion invalida");
                                                                    volvervolver = true;
                                                                    break;

                                                            }

                                                        } while (volvervolver != false);

                                                        if (volvers == false)
                                                        {
                                                            volvervolver = true;
                                                        }
                                                        else
                                                        {
                                                            volvervolver = false;
                                                        }

                                                    }
                                                    else
                                                    {
                                                        SiCuaternioA = true;
                                                    }
                                                } while (volvervolver != false);
                                                ifilaACN = ifilaAuxCN;
                                                icolumnaACN = icolumnaAuxCN;
                                                Cuaternio01 = new float[ifilaACN, icolumnaACN];
                                                if (SiCuaternioA == true)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                                    Console.WriteLine(" CUATERNIO A");
                                                    Console.WriteLine(" Codigo: " + numerocodigoAuxCN + "  Con filas: " + ifilaACN + "  Con Columnas: " + icolumnaACN);

                                                    for (int i = 0; i < ifilaACN; i++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int j = 0; j < icolumnaACN; j++)
                                                        {
                                                            Cuaternio01[i, j] = CuaternioAux[i, j];
                                                            Console.Write(Cuaternio01[i, j] + "   ");
                                                        }
                                                    }
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("\n");
                                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                                }

                                                //ESCALAR B
                                                if (SiCuaternioA == true)
                                                {
                                                    do
                                                    {
                                                        volver = false;
                                                        Console.WriteLine(" Escriba el numero a sumar");
                                                        string numeromatriz = Console.ReadLine();
                                                        int cantidad = numeromatriz.Length;
                                                        if (VC.Contador(cantidad, numeromatriz) == 0)
                                                        {
                                                            volver = false;
                                                            float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                                                            inumeromatriz = (float)Math.Round(inumeromatriz, 2);
                                                            escalarBCN = inumeromatriz;
                                                            SiCuaternioB = true;
                                                        }
                                                        else
                                                        {
                                                            SiCuaternioB = false;
                                                            volver = true;
                                                        }
                                                    } while (volver != false);
                                                }

                                                if (SiCuaternioA == true && SiCuaternioB == true)
                                                {
                                                    volvervolver = false;

                                                    Cuaternio03 = new float[ifilaACN, icolumnaACN];

                                                    for (int iA = 0; iA < ifilaACN; iA++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int jA = 0; jA < icolumnaACN; jA++)
                                                        {
                                                            float CuaterniosaA = Cuaternio01[iA, jA];
                                                            Cuaternio03[iA, jA] = OC.Sumar(CuaterniosaA, escalarBCN);

                                                        }

                                                    }


                                                    AgregarCuaternioResultado(ifilaACN, icolumnaACN);
                                                    ImprimirCuaternioEspecifico(numerocodigoAuxCN);

                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                    Console.WriteLine("Warning: El tamaño del valor de los cuaternios no permite la operacion o no fue encontrada");
                                                    Console.ReadLine();

                                                }

                                                volvervolver = false;
                                                break;
                                            }
                                        default:
                                            Console.WriteLine(" Opcion invalida");
                                            volvervolver = true;
                                            break;
                                    }

                                } while (volvervolver != false);

                            }
                            volvervolver = true;
                            break;
                        }
                    case "12":
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                            Console.WriteLine("║                         RESTAR CUATERNIOS                             ║ ");
                            Console.WriteLine("║                                                                       ║ ");

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("║              SIGA POR FAVOR LAS INSTRUCCIONES SIGUIENTES              ║ ");
                            Console.WriteLine("║                                                                       ║ ");
                            Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");


                            if (inicioCN == null)
                            {
                                volvervolver = true;
                                Console.WriteLine("Warning: Aun no se agregan datos suficientes para la operacion");
                                Console.ReadLine();
                            }
                            else
                            {
                                do
                                {

                                    Console.WriteLine(" ");
                                    Console.WriteLine("¿COMO REALIZARAS LA RESTA? 0. CUATERNIO-CUATERNIO | 1. Escalar-CUATERNIO | 2. CUATERNIO-Escalar");
                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("¿Que opcion elige?                                                        ");
                                    opcion = Console.ReadLine();
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                    Console.ForegroundColor = ConsoleColor.White;

                                    switch (opcion)
                                    {
                                        case "0":
                                            {
                                                bool SiCuaternioA = false;
                                                bool SiCuaternioB = false;
                                                //CUATERNIO A
                                                do
                                                {
                                                    volvervolver = false;
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        Console.WriteLine(" Escriba el codigo del CUATERNIO A que desea RESTAR");
                                                        string numerosho = Console.ReadLine();

                                                        int cantidad = numerosho.Length;
                                                        if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                        {
                                                            volvervolver = false;
                                                            numerocodigoAuxCN = Convert.ToInt32(numerosho); // convierte a int
                                                        }
                                                        else
                                                        {
                                                            volvervolver = true;
                                                        }
                                                    } while (volvervolver != false);

                                                    if (BuscarCuaternio(numerocodigoAuxCN) != 0)
                                                    {
                                                        SiCuaternioA = false;
                                                        bool volvers = false;

                                                        do
                                                        {
                                                            volvervolver = false;

                                                            Console.WriteLine("¿Quiere intentar otro codigo?");
                                                            Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                            opcion = Console.ReadLine();

                                                            switch (opcion)
                                                            {
                                                                case "0":
                                                                    volvervolver = false;
                                                                    volvers = false;
                                                                    break;
                                                                case "1":
                                                                    volvervolver = false;
                                                                    volvers = true;
                                                                    SiCuaternioA = false;
                                                                    break;
                                                                default:
                                                                    Console.WriteLine(" Opcion invalida");
                                                                    volvervolver = true;
                                                                    break;

                                                            }

                                                        } while (volvervolver != false);

                                                        if (volvers == false)
                                                        {
                                                            volvervolver = true;
                                                        }
                                                        else
                                                        {
                                                            volvervolver = false;
                                                        }

                                                    }
                                                    else
                                                    {
                                                        SiCuaternioA = true;
                                                    }
                                                } while (volvervolver != false);

                                                ifilaACN = ifilaAuxCN;
                                                icolumnaACN = icolumnaAuxCN;
                                                Cuaternio01 = new float[ifilaACN, icolumnaACN];
                                                if (SiCuaternioA == true)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                                    Console.WriteLine(" CUATERNIO A");
                                                    Console.WriteLine(" Codigo: " + numerocodigoAuxCN + "  Con filas: " + ifilaACN + "  Con Columnas: " + icolumnaACN);

                                                    for (int i = 0; i < ifilaACN; i++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int j = 0; j < icolumnaACN; j++)
                                                        {
                                                            Cuaternio01[i, j] = CuaternioAux[i, j];
                                                            Console.Write(Cuaternio01[i, j] + "   ");
                                                        }
                                                    }
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("\n");
                                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                                }

                                                //CUATERNIO B
                                                if (SiCuaternioA == true)
                                                {
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        do
                                                        {
                                                            volvervolver = false;
                                                            Console.WriteLine(" Escriba el codigo de la CUATERNIO B que desea RESTAR");
                                                            string numerosho = Console.ReadLine();

                                                            int cantidad = numerosho.Length;
                                                            if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                            {
                                                                volvervolver = false;
                                                                numerocodigoAuxCN = Convert.ToInt32(numerosho); // convierte a int
                                                            }
                                                            else
                                                            {
                                                                volvervolver = true;
                                                            }
                                                        } while (volvervolver != false);

                                                        if (BuscarCuaternio(numerocodigoAuxCN) != 0)
                                                        {
                                                            SiCuaternioB = false;
                                                            bool volvers = false;

                                                            do
                                                            {
                                                                volvervolver = false;

                                                                Console.WriteLine("¿Quiere intentar otro codigo?");
                                                                Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                                opcion = Console.ReadLine();

                                                                switch (opcion)
                                                                {
                                                                    case "0":
                                                                        volvervolver = false;
                                                                        volvers = false;
                                                                        break;
                                                                    case "1":
                                                                        volvervolver = false;
                                                                        volvers = true;
                                                                        break;
                                                                    default:
                                                                        Console.WriteLine(" Opcion invalida");
                                                                        volvervolver = true;
                                                                        break;

                                                                }

                                                            } while (volvervolver != false);

                                                            if (volvers == false)
                                                            {
                                                                volvervolver = true;
                                                            }
                                                            else
                                                            {
                                                                volvervolver = false;
                                                            }

                                                        }
                                                        else
                                                        {
                                                            SiCuaternioB = true;
                                                        }
                                                    } while (volvervolver != false);
                                                    ifilaBCN = ifilaAuxCN;
                                                    icolumnaBCN = icolumnaAuxCN;
                                                    Cuaternio02 = new float[ifilaBCN, icolumnaBCN];
                                                    if (SiCuaternioB == true)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                                        Console.WriteLine(" CUATERNIO B");
                                                        Console.WriteLine(" Codigo: " + numerocodigoAuxCN + "  Con filas: " + ifilaBCN + "  Con Columnas: " + icolumnaBCN);

                                                        for (int i = 0; i < ifilaBCN; i++)
                                                        {
                                                            Console.Write("\n");
                                                            for (int j = 0; j < icolumnaBCN; j++)
                                                            {
                                                                Cuaternio02[i, j] = CuaternioAux[i, j];
                                                                Console.Write(Cuaternio02[i, j] + "   ");
                                                            }
                                                        }
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        Console.WriteLine("\n");
                                                        Console.WriteLine("   -------------------------------------------------------------------    ");
                                                    }
                                                }

                                                if (VC.Igualdad(ifilaACN, ifilaBCN) == 0 && VC.Igualdad(icolumnaACN, icolumnaBCN) == 0 && SiCuaternioA == true && SiCuaternioB == true)
                                                {
                                                    volvervolver = false;

                                                    Cuaternio03 = new float[ifilaACN, icolumnaACN];

                                                    for (int iA = 0; iA < ifilaACN; iA++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int jA = 0; jA < icolumnaACN; jA++)
                                                        {

                                                            float CuaterniosaA = Cuaternio01[iA, jA];
                                                            float CuaterniosaB = Cuaternio02[iA, jA];

                                                            Cuaternio03[iA, jA] = OC.Restar(CuaterniosaA, CuaterniosaB);


                                                        }

                                                    }


                                                    AgregarCuaternioResultado(ifilaACN, icolumnaACN);
                                                    ImprimirCuaternioEspecifico(numerocodigoAuxCN);

                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                    Console.WriteLine("Warning: El tamaño del valor del cuaternio no permite la operacion o no fue encontrada");
                                                    Console.ReadLine();

                                                }

                                                volvervolver = false;
                                                break;
                                            }
                                        case "1":
                                           {
                                                bool SiCuaternioA = false;
                                                bool SiCuaternioB = false;
                                                //ESCALAR
                                                do
                                                {
                                                    volver = false;
                                                    Console.WriteLine(" Escriba el numero a RESTAR");
                                                    string numeromatriz = Console.ReadLine();
                                                    int cantidad = numeromatriz.Length;
                                                    if (VC.Contador(cantidad, numeromatriz) == 0)
                                                    {
                                                        volver = false;
                                                        float inumerocuaternio = (float)Convert.ToDouble(numeromatriz);
                                                        inumerocuaternio = (float)Math.Round(inumerocuaternio, 2);
                                                        escalarACN = inumerocuaternio;
                                                        SiCuaternioA = true;
                                                    }
                                                    else
                                                    {
                                                        SiCuaternioA = false;
                                                        volver = true;
                                                    }
                                                } while (volver != false);

                                                //CUATERNIO B
                                                if (SiCuaternioA == true)
                                                {
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        do
                                                        {
                                                            volvervolver = false;
                                                            Console.WriteLine(" Escriba el codigo del CUATERNIO B que desea RESTAR");
                                                            string numerosho = Console.ReadLine();

                                                            int cantidad = numerosho.Length;
                                                            if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                            {
                                                                volvervolver = false;
                                                                numerocodigoAuxCN = Convert.ToInt32(numerosho); // convierte a int
                                                            }
                                                            else
                                                            {
                                                                volvervolver = true;
                                                            }
                                                        } while (volvervolver != false);

                                                        if (BuscarCuaternio(numerocodigoAuxCN) != 0)
                                                        {
                                                            SiCuaternioB = false;
                                                            bool volvers = false;

                                                            do
                                                            {
                                                                volvervolver = false;

                                                                Console.WriteLine("¿Quiere intentar otro codigo?");
                                                                Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                                opcion = Console.ReadLine();

                                                                switch (opcion)
                                                                {
                                                                    case "0":
                                                                        volvervolver = false;
                                                                        volvers = false;
                                                                        break;
                                                                    case "1":
                                                                        volvervolver = false;
                                                                        volvers = true;
                                                                        break;
                                                                    default:
                                                                        Console.WriteLine(" Opcion invalida");
                                                                        volvervolver = true;
                                                                        break;

                                                                }

                                                            } while (volvervolver != false);

                                                            if (volvers == false)
                                                            {
                                                                volvervolver = true;
                                                            }
                                                            else
                                                            {
                                                                volvervolver = false;
                                                            }

                                                        }
                                                        else
                                                        {
                                                            SiCuaternioB = true;
                                                        }
                                                    } while (volvervolver != false);
                                                    ifilaBCN = ifilaAuxCN;
                                                    icolumnaBCN = icolumnaAuxCN;
                                                    Cuaternio02 = new float[ifilaBCN, icolumnaBCN];
                                                    if (SiCuaternioB == true)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                                        Console.WriteLine(" MATRIZ B");
                                                        Console.WriteLine(" Codigo: " + numerocodigoAuxCN + "  Con filas: " + ifilaBCN + "  Con Columnas: " + icolumnaBCN);

                                                        for (int i = 0; i < ifilaBCN; i++)
                                                        {
                                                            Console.Write("\n");
                                                            for (int j = 0; j < icolumnaBCN; j++)
                                                            {
                                                                Cuaternio02[i, j] = CuaternioAux[i, j];
                                                                Console.Write(Cuaternio02[i, j] + "   ");
                                                            }
                                                        }
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        Console.WriteLine("\n");
                                                        Console.WriteLine("   -------------------------------------------------------------------    ");
                                                    }
                                                }



                                                if (SiCuaternioA == true && SiCuaternioB == true)
                                                {
                                                    volvervolver = false;

                                                    Cuaternio03 = new float[ifilaBCN, icolumnaBCN];

                                                    for (int iA = 0; iA < ifilaBCN; iA++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int jA = 0; jA < icolumnaBCN; jA++)
                                                        {
                                                            float CuaterniosaB = Cuaternio02[iA, jA];

                                                            Cuaternio03[iA, jA] = OC.Restar(escalarACN, CuaterniosaB);


                                                        }

                                                    }


                                                    AgregarCuaternioResultado(ifilaBCN, icolumnaBCN);
                                                    ImprimirCuaternioEspecifico(numerocodigoAuxCN);

                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                    Console.WriteLine("Warning: El tamaño del valor del cuaternio no permite la operacion o no fue encontrada");
                                                    Console.ReadLine();

                                                }

                                                volvervolver = false;
                                                break;
                                            } 
                                        case "2":
                                            {
                                                bool SiCuaternioA = false;
                                                bool SiCuaternioB = false;
                                                //CUATERNIO A
                                                do
                                                {
                                                    volvervolver = false;
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        Console.WriteLine(" Escriba el codigo de la CUATERNIO A que desea RESTAR");
                                                        string numerosho = Console.ReadLine();

                                                        int cantidad = numerosho.Length;
                                                        if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                        {
                                                            volvervolver = false;
                                                            numerocodigoAuxCN = Convert.ToInt32(numerosho); // convierte a int
                                                        }
                                                        else
                                                        {
                                                            volvervolver = true;
                                                        }
                                                    } while (volvervolver != false);

                                                    if (BuscarCuaternio(numerocodigoAuxCN) != 0)
                                                    {
                                                        SiCuaternioA = false;
                                                        bool volvers = false;

                                                        do
                                                        {
                                                            volvervolver = false;

                                                            Console.WriteLine("¿Quiere intentar otro codigo?");
                                                            Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                            opcion = Console.ReadLine();

                                                            switch (opcion)
                                                            {
                                                                case "0":
                                                                    volvervolver = false;
                                                                    volvers = false;
                                                                    break;
                                                                case "1":
                                                                    volvervolver = false;
                                                                    volvers = true;
                                                                    SiCuaternioA = false;
                                                                    break;
                                                                default:
                                                                    Console.WriteLine(" Opcion invalida");
                                                                    volvervolver = true;
                                                                    break;

                                                            }

                                                        } while (volvervolver != false);

                                                        if (volvers == false)
                                                        {
                                                            volvervolver = true;
                                                        }
                                                        else
                                                        {
                                                            volvervolver = false;
                                                        }

                                                    }
                                                    else
                                                    {
                                                        SiCuaternioA = true;
                                                    }
                                                } while (volvervolver != false);
                                                ifilaACN = ifilaAuxCN;
                                                icolumnaACN = icolumnaAuxCN;
                                                Cuaternio01 = new float[ifilaACN, icolumnaACN];
                                                if (SiCuaternioA == true)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                                    Console.WriteLine(" CUATERNIO A");
                                                    Console.WriteLine(" Codigo: " + numerocodigoAuxCN + "  Con filas: " + ifilaACN + "  Con Columnas: " + icolumnaACN);

                                                    for (int i = 0; i < ifilaACN; i++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int j = 0; j < icolumnaACN; j++)
                                                        {
                                                            Cuaternio01[i, j] = CuaternioAux[i, j];
                                                            Console.Write(Cuaternio01[i, j] + "   ");
                                                        }
                                                    }
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("\n");
                                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                                }

                                                //ESCALAR B
                                                if (SiCuaternioA == true)
                                                {
                                                    do
                                                    {
                                                        volver = false;
                                                        Console.WriteLine(" Escriba el numero a RESTAR");
                                                        string numeromatriz = Console.ReadLine();
                                                        int cantidad = numeromatriz.Length;
                                                        if (VC.Contador(cantidad, numeromatriz) == 0)
                                                        {
                                                            volver = false;
                                                            float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                                                            inumeromatriz = (float)Math.Round(inumeromatriz, 2);
                                                            escalarBCN = inumeromatriz;
                                                            SiCuaternioB = true;
                                                        }
                                                        else
                                                        {
                                                            SiCuaternioB = false;
                                                            volver = true;
                                                        }
                                                    } while (volver != false);
                                                }

                                                if (SiCuaternioA == true && SiCuaternioB == true)
                                                {
                                                    volvervolver = false;

                                                    Cuaternio03 = new float[ifilaACN, icolumnaACN];

                                                    for (int iA = 0; iA < ifilaACN; iA++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int jA = 0; jA < icolumnaACN; jA++)
                                                        {
                                                            float CuaterniosaA = Cuaternio01[iA, jA];
                                                            Cuaternio03[iA, jA] = OC.Restar(CuaterniosaA, escalarBCN);

                                                        }

                                                    }


                                                    AgregarCuaternioResultado(ifilaACN, icolumnaACN);
                                                    ImprimirCuaternioEspecifico(numerocodigoAuxCN);

                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                    Console.WriteLine("Warning: El tamaño del valor de los cuaternios no permite la operacion o no fue encontrada");
                                                    Console.ReadLine();

                                                }

                                                volvervolver = false;
                                                break;
                                            }
                                        default:
                                            Console.WriteLine(" Opcion invalida");
                                            volvervolver = true;
                                            break;
                                    }

                                } while (volvervolver != false);

                            }
                            volvervolver = true;
                            break;
                        }
                    case "13":
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                            Console.WriteLine("║                       PRODUCTO DE CUATERNIOS                          ║ ");
                            Console.WriteLine("║                                                                       ║ ");

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("║              SIGA POR FAVOR LAS INSTRUCCIONES SIGUIENTES              ║ ");
                            Console.WriteLine("║                                                                       ║ ");
                            Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");


                            if (inicioCN == null)
                            {
                                volvervolver = true;
                                Console.WriteLine("Warning: Aun no se agregan datos suficientes para la operacion");
                                Console.ReadLine();
                            }
                            else
                            {
                                bool SiCuaternioA = false;
                                bool SiCuaternioB = false;
                                //CUATERNIO A
                                do
                                {
                                    volvervolver = false;
                                    do
                                    {
                                        volvervolver = false;
                                        Console.WriteLine(" Escriba el codigo del CUATERNIO A que desea realizar PRODUCTO");
                                        string numerosho = Console.ReadLine();

                                        int cantidad = numerosho.Length;
                                        if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                        {
                                            volvervolver = false;
                                            numerocodigoAuxCN = Convert.ToInt32(numerosho); // convierte a int
                                        }
                                        else
                                        {
                                            volvervolver = true;
                                        }
                                    } while (volvervolver != false);

                                    if (BuscarCuaternio(numerocodigoAuxCN) != 0)
                                    {
                                        SiCuaternioA = false;
                                        bool volvers = false;

                                        do
                                        {
                                            volvervolver = false;

                                            Console.WriteLine("¿Quiere intentar otro codigo?");
                                            Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                            opcion = Console.ReadLine();

                                            switch (opcion)
                                            {
                                                case "0":
                                                    volvervolver = false;
                                                    volvers = false;
                                                    break;
                                                case "1":
                                                    volvervolver = false;
                                                    volvers = true;
                                                    SiCuaternioA = false;
                                                    break;
                                                default:
                                                    Console.WriteLine(" Opcion invalida");
                                                    volvervolver = true;
                                                    break;

                                            }

                                        } while (volvervolver != false);

                                        if (volvers == false)
                                        {
                                            volvervolver = true;
                                        }
                                        else
                                        {
                                            volvervolver = false;
                                        }

                                    }
                                    else
                                    {
                                        SiCuaternioA = true;
                                    }
                                } while (volvervolver != false);

                                ifilaACN = ifilaAuxCN;
                                icolumnaACN = icolumnaAuxCN;
                                Cuaternio01 = new float[ifilaACN, icolumnaACN];
                                if (SiCuaternioA == true)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                    Console.WriteLine(" CUATERNIO A");
                                    Console.WriteLine(" Codigo: " + numerocodigoAuxCN + "  Con filas: " + ifilaACN + "  Con Columnas: " + icolumnaACN);

                                    for (int i = 0; i < ifilaACN; i++)
                                    {
                                        Console.Write("\n");
                                        for (int j = 0; j < icolumnaACN; j++)
                                        {
                                            Cuaternio01[i, j] = CuaternioAux[i, j];
                                            Console.Write(Cuaternio01[i, j] + "   ");
                                        }
                                    }
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("\n");
                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                }

                                //CUATERNIO B
                                if (SiCuaternioA == true)
                                {
                                    do
                                    {
                                        volvervolver = false;
                                        do
                                        {
                                            volvervolver = false;
                                            Console.WriteLine(" Escriba el codigo de la CUATERNIO B que desea realizar PRODUCTO");
                                            string numerosho = Console.ReadLine();

                                            int cantidad = numerosho.Length;
                                            if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                            {
                                                volvervolver = false;
                                                numerocodigoAuxCN = Convert.ToInt32(numerosho); // convierte a int
                                            }
                                            else
                                            {
                                                volvervolver = true;
                                            }
                                        } while (volvervolver != false);

                                        if (BuscarCuaternio(numerocodigoAuxCN) != 0)
                                        {
                                            SiCuaternioB = false;
                                            bool volvers = false;

                                            do
                                            {
                                                volvervolver = false;

                                                Console.WriteLine("¿Quiere intentar otro codigo?");
                                                Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                opcion = Console.ReadLine();

                                                switch (opcion)
                                                {
                                                    case "0":
                                                        volvervolver = false;
                                                        volvers = false;
                                                        break;
                                                    case "1":
                                                        volvervolver = false;
                                                        volvers = true;
                                                        break;
                                                    default:
                                                        Console.WriteLine(" Opcion invalida");
                                                        volvervolver = true;
                                                        break;

                                                }

                                            } while (volvervolver != false);

                                            if (volvers == false)
                                            {
                                                volvervolver = true;
                                            }
                                            else
                                            {
                                                volvervolver = false;
                                            }

                                        }
                                        else
                                        {
                                            SiCuaternioB = true;
                                        }
                                    } while (volvervolver != false);
                                    ifilaBCN = ifilaAuxCN;
                                    icolumnaBCN = icolumnaAuxCN;
                                    Cuaternio02 = new float[ifilaBCN, icolumnaBCN];
                                    if (SiCuaternioB == true)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine(" CUATERNIO B");
                                        Console.WriteLine(" Codigo: " + numerocodigoAuxCN + "  Con filas: " + ifilaBCN + "  Con Columnas: " + icolumnaBCN);

                                        for (int i = 0; i < ifilaBCN; i++)
                                        {
                                            Console.Write("\n");
                                            for (int j = 0; j < icolumnaBCN; j++)
                                            {
                                                Cuaternio02[i, j] = CuaternioAux[i, j];
                                                Console.Write(Cuaternio02[i, j] + "   ");
                                            }
                                        }
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("\n");
                                        Console.WriteLine("   -------------------------------------------------------------------    ");
                                    }
                                }

                                if (VC.Igualdad(ifilaACN, ifilaBCN) == 0 && VC.Igualdad(icolumnaACN, icolumnaBCN) == 0 && SiCuaternioA == true && SiCuaternioB == true)
                                {
                                    volvervolver = false;

                                    Cuaternio03 = new float[ifilaBCN, icolumnaBCN];
                                    OC.ProductoCuaternios(Cuaternio01[0, 0], Cuaternio01[0, 1], Cuaternio01[0, 2], Cuaternio01[0, 3], Cuaternio02[0, 0], Cuaternio02[0, 1], Cuaternio02[0, 2], Cuaternio02[0, 3]);

                                    for (int iA = 0; iA < ifilaBCN; iA++)
                                    {
                                        Console.Write("\n");
                                        for (int jA = 0; jA < icolumnaBCN; jA++)
                                        {
                                            float CuaterniosaB;

                                            switch (jA)
                                            {
                                                case 0:
                                                    CuaterniosaB = OC.r;
                                                    break;
                                                case 1:
                                                    CuaterniosaB = OC.i;
                                                    break;
                                                case 2:
                                                    CuaterniosaB = OC.j;
                                                    break;
                                                case 3:
                                                    CuaterniosaB = OC.k;
                                                    break;
                                                default:
                                                    CuaterniosaB = 0;
                                                    break;
                                            }
                                            Cuaternio03[iA, jA] = CuaterniosaB;

                                        }

                                    }


                                    AgregarCuaternioResultado(ifilaBCN, icolumnaBCN);
                                    ImprimirCuaternioEspecifico(numerocodigoAuxCN);

                                }
                                else
                                {
                                    volvervolver = true;
                                    Console.WriteLine("Warning: El tamaño del valor del cuaternio no permite la operacion o no fue encontrada");
                                    Console.ReadLine();

                                }
                            }
                                volvervolver = true;
                                break;
                            }
                    case "14":
                        {
                            volvervolver = false;
                            break;
                        }
                    default:
                        Console.WriteLine(" Opcion invalida");
                        volvervolver = true;
                        break;
                }

            } while (volvervolver != false);
        }

        public void TraslacionRotacionEscala()
        {
            do
            {
                volvervolver = false;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                Console.WriteLine("║                     TRASLACION ROTACION ESCALAR                       ║ ");
                Console.WriteLine("║                                                                       ║ ");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("║            INSERTE UN NUMERO SEGUN LA OPCION DESEADA DEL MENU         ║ ");
                Console.WriteLine("║ 0. Agregar Punto                 1. Imprimir Puntos                   ║ ");
                Console.WriteLine("║ 2. Modificar Punto               3. Eliminar Punto                    ║ ");
                Console.WriteLine("║ 4. Traslacion                    5. Rotacion                          ║ ");
                Console.WriteLine("║ 6. Escalar                       7. Regresar                          ║ ");
                Console.WriteLine("║                                                                       ║ ");
                Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");


                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("   -------------------------------------------------------------------    ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("¿Que opcion elige?                                                        ");
                opcion = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("   -------------------------------------------------------------------    ");
                Console.ForegroundColor = ConsoleColor.White;

                switch (opcion)
                {
                    case "0":
                        {
                            do
                            {
                                volvervolver = false;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                                Console.WriteLine("║                            AGREGAR PUNTO                              ║ ");
                                Console.WriteLine("║                                                                       ║ ");

                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("║              SIGA POR FAVOR LAS INSTRUCCIONES SIGUIENTES              ║ ");
                                Console.WriteLine("║                                                                       ║ ");
                                Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");

                                AgregarTRE();
                                ImprimirTREEspecifica(numerocodigoAuxTRE);

                                volvervolver = false;
                            } while (volvervolver != false);
                            volvervolver = true;
                            break;
                        }
                    case "1":
                        {
                            do
                            {
                                volvervolver = false;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                                Console.WriteLine("║                          IMPRIMIR PUNTOS                              ║ ");
                                Console.WriteLine("║                                                                       ║ ");

                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("║            INSERTE UN NUMERO SEGUN LA OPCION DESEADA DEL MENU         ║ ");
                                Console.WriteLine("║ 0. Imprimir todos los puntos      1. Imprimir punto especifica        ║ ");
                                Console.WriteLine("║ 2. Salir                                                              ║ ");
                                Console.WriteLine("║                                                                       ║ ");
                                Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");

                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("   -------------------------------------------------------------------    ");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("¿Que opcion elige?                                                        ");
                                opcion = Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("   -------------------------------------------------------------------    ");
                                Console.ForegroundColor = ConsoleColor.White;

                                switch (opcion)
                                {
                                    case "0":
                                        ImprimirTRE();
                                        volvervolver = false;
                                        break;
                                    case "1":
                                        do
                                        {
                                            volvervolver = false;
                                            do
                                            {
                                                volvervolver = false;
                                                Console.WriteLine(" Escriba el codigo del PUNTO que busca");
                                                string numerosho = Console.ReadLine();

                                                int cantidad = numerosho.Length;
                                                if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                {
                                                    volvervolver = false;
                                                    numerocodigoAuxTRE = Convert.ToInt32(numerosho); // convierte a int
                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                }
                                            } while (volvervolver != false);

                                            if (ImprimirTREEspecifica(numerocodigoAuxTRE) != 0)
                                            {

                                                bool volvers = false;

                                                do
                                                {
                                                    volvervolver = false;

                                                    Console.WriteLine("¿Quiere intentar otro codigo?");
                                                    Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                    opcion = Console.ReadLine();

                                                    switch (opcion)
                                                    {
                                                        case "0":
                                                            volvervolver = false;
                                                            volvers = false;
                                                            break;
                                                        case "1":
                                                            volvervolver = false;
                                                            volvers = true;
                                                            break;
                                                        default:
                                                            Console.WriteLine(" Opcion invalida");
                                                            volvervolver = true;
                                                            break;

                                                    }

                                                } while (volvervolver != false);

                                                if (volvers == false)
                                                {
                                                    volvervolver = true;
                                                }
                                                else
                                                {
                                                    volvervolver = false;
                                                }

                                            }
                                        } while (volvervolver != false);
                                        volvervolver = false;
                                        break;
                                    case "2":
                                        volvervolver = false;
                                        break;

                                    default:
                                        Console.WriteLine(" Opcion invalida");
                                        volvervolver = true;
                                        break;
                                }

                            } while (volvervolver != false);
                            volvervolver = true;
                            break;
                        }
                    case "2":
                        {
                            do
                            {
                                volvervolver = false;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                                Console.WriteLine("║                         MODIFICAR PUNTOS                              ║ ");
                                Console.WriteLine("║                                                                       ║ ");

                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("║            INSERTE UN NUMERO SEGUN LA OPCION DESEADA DEL MENU         ║ ");
                                Console.WriteLine("║ 0. Modificar todo el punto   1. Modificar dato especifico del punto   ║ ");
                                Console.WriteLine("║ 2. Salir                                                              ║ ");
                                Console.WriteLine("║                                                                       ║ ");
                                Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");

                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("   -------------------------------------------------------------------    ");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("¿Que opcion elige?                                                        ");
                                opcion = Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("   -------------------------------------------------------------------    ");
                                Console.ForegroundColor = ConsoleColor.White;

                                switch (opcion)
                                {
                                    case "0":
                                        do
                                        {
                                            volvervolver = false;
                                            do
                                            {
                                                volvervolver = false;
                                                Console.WriteLine(" Escriba el codigo del punto que busca");
                                                string numerosho = Console.ReadLine();

                                                int cantidad = numerosho.Length;
                                                if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                {
                                                    volvervolver = false;
                                                    numerocodigoAuxTRE = Convert.ToInt32(numerosho); // convierte a int
                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                }
                                            } while (volvervolver != false);

                                            if (ModificarTRE(numerocodigoAuxTRE) != 0)
                                            {

                                                bool volvers = false;

                                                do
                                                {
                                                    volvervolver = false;

                                                    Console.WriteLine("¿Quiere intentar otro codigo?");
                                                    Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                    opcion = Console.ReadLine();

                                                    switch (opcion)
                                                    {
                                                        case "0":
                                                            volvervolver = false;
                                                            volvers = false;
                                                            break;
                                                        case "1":
                                                            volvervolver = false;
                                                            volvers = true;
                                                            break;
                                                        default:
                                                            Console.WriteLine(" Opcion invalida");
                                                            volvervolver = true;
                                                            break;

                                                    }

                                                } while (volvervolver != false);

                                                if (volvers == false)
                                                {
                                                    volvervolver = true;
                                                }
                                                else
                                                {
                                                    volvervolver = false;
                                                }

                                            }
                                            else
                                            {
                                                ImprimirTREEspecifica(numerocodigoAuxTRE);
                                            }



                                        } while (volvervolver != false);
                                        volvervolver = false;
                                        break;
                                    case "1":
                                        do
                                        {
                                            volvervolver = false;
                                            do
                                            {
                                                volvervolver = false;
                                                Console.WriteLine(" Escriba el codigo del punto que busca");
                                                string numerosho = Console.ReadLine();

                                                int cantidad = numerosho.Length;
                                                if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                {
                                                    volvervolver = false;
                                                    numerocodigoAuxTRE = Convert.ToInt32(numerosho); // convierte a int
                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                }
                                            } while (volvervolver != false);

                                            if (ModificarTREEspecifica(numerocodigoAuxTRE) != 0)
                                            {

                                                bool volvers = false;

                                                do
                                                {
                                                    volvervolver = false;

                                                    Console.WriteLine("¿Quiere intentar otro codigo?");
                                                    Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                    opcion = Console.ReadLine();

                                                    switch (opcion)
                                                    {
                                                        case "0":
                                                            volvervolver = false;
                                                            volvers = false;
                                                            break;
                                                        case "1":
                                                            volvervolver = false;
                                                            volvers = true;
                                                            break;
                                                        default:
                                                            Console.WriteLine(" Opcion invalida");
                                                            volvervolver = true;
                                                            break;

                                                    }

                                                } while (volvervolver != false);

                                                if (volvers == false)
                                                {
                                                    volvervolver = true;
                                                }
                                                else
                                                {
                                                    volvervolver = false;
                                                }

                                            }
                                        } while (volvervolver != false);
                                        volvervolver = false;
                                        break;
                                    case "2":
                                        volvervolver = false;
                                        break;

                                    default:
                                        Console.WriteLine(" Opcion invalida");
                                        volvervolver = true;
                                        break;
                                }

                            } while (volvervolver != false);
                            volvervolver = true;
                            break;
                        }
                    case "3":
                        {
                            do
                            {
                                volvervolver = false;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                                Console.WriteLine("║                           ELIMINAR PUNTO                              ║ ");
                                Console.WriteLine("║                                                                       ║ ");

                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("║              SIGA POR FAVOR LAS INSTRUCCIONES SIGUIENTES              ║ ");
                                Console.WriteLine("║                                                                       ║ ");
                                Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");

                                do
                                {
                                    volvervolver = false;
                                    Console.WriteLine(" Escriba el codigo del punto que quiera eliminar");
                                    string numerosho = Console.ReadLine();

                                    int cantidad = numerosho.Length;
                                    if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                    {
                                        volvervolver = false;
                                        numerocodigoAuxTRE = Convert.ToInt32(numerosho); // convierte a int
                                    }
                                    else
                                    {
                                        volvervolver = true;
                                    }
                                } while (volvervolver != false);
                                if (EliminarTRE(numerocodigoAuxTRE) != 0)
                                {

                                    bool volvers = false;

                                    do
                                    {
                                        volvervolver = false;

                                        Console.WriteLine("¿Quiere intentar otro codigo?");
                                        Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                        opcion = Console.ReadLine();

                                        switch (opcion)
                                        {
                                            case "0":
                                                volvervolver = false;
                                                volvers = false;
                                                break;
                                            case "1":
                                                volvervolver = false;
                                                volvers = true;
                                                break;
                                            default:
                                                Console.WriteLine(" Opcion invalida");
                                                volvervolver = true;
                                                break;

                                        }

                                    } while (volvervolver != false);

                                    if (volvers == false)
                                    {
                                        volvervolver = true;
                                    }
                                    else
                                    {
                                        volvervolver = false;
                                    }

                                }


                            } while (volvervolver != false);
                            volvervolver = true;
                            break;
                        }
                    case "4":
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                            Console.WriteLine("║                             TRASLACION                                ║ ");
                            Console.WriteLine("║                                                                       ║ ");

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("║              SIGA POR FAVOR LAS INSTRUCCIONES SIGUIENTES              ║ ");
                            Console.WriteLine("║                                                                       ║ ");
                            Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");


                            if (inicioTRE == null)
                            {
                                volvervolver = true;
                                Console.WriteLine("Warning: Aun no se agregan datos suficientes para la operacion");
                                Console.ReadLine();
                            }
                            else
                            {
                                do
                                {

                                    Console.WriteLine(" ");
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("¿COMO REALIZARAS LA TRASLACION? 0. Punto-Punto | 2. Punto-Escalar");
                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("¿Que opcion elige?                                                        ");
                                    opcion = Console.ReadLine();
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                    Console.ForegroundColor = ConsoleColor.White;

                                    switch (opcion)
                                    {
                                        case "0":
                                            {
                                                bool SiMatrizA = false;
                                                bool SiMatrizB = false;
                                                //MATRIZ A
                                                do
                                                {
                                                    volvervolver = false;
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        Console.WriteLine(" Escriba el codigo del PUNTO A que desea TRASLADAR");
                                                        string numerosho = Console.ReadLine();

                                                        int cantidad = numerosho.Length;
                                                        if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                        {
                                                            volvervolver = false;
                                                            numerocodigoAuxTRE = Convert.ToInt32(numerosho); // convierte a int
                                                        }
                                                        else
                                                        {
                                                            volvervolver = true;
                                                        }
                                                    } while (volvervolver != false);

                                                    if (BuscarTRE(numerocodigoAuxTRE) != 0)
                                                    {
                                                        SiMatrizA = false;
                                                        bool volvers = false;

                                                        do
                                                        {
                                                            volvervolver = false;

                                                            Console.WriteLine("¿Quiere intentar otro codigo?");
                                                            Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                            opcion = Console.ReadLine();

                                                            switch (opcion)
                                                            {
                                                                case "0":
                                                                    volvervolver = false;
                                                                    volvers = false;
                                                                    break;
                                                                case "1":
                                                                    volvervolver = false;
                                                                    volvers = true;
                                                                    SiMatrizA = false;
                                                                    break;
                                                                default:
                                                                    Console.WriteLine(" Opcion invalida");
                                                                    volvervolver = true;
                                                                    break;

                                                            }

                                                        } while (volvervolver != false);

                                                        if (volvers == false)
                                                        {
                                                            volvervolver = true;
                                                        }
                                                        else
                                                        {
                                                            volvervolver = false;
                                                        }

                                                    }
                                                    else
                                                    {
                                                        SiMatrizA = true;
                                                    }
                                                } while (volvervolver != false);

                                                ifilaATRE = ifilaAuxTRE;
                                                icolumnaATRE = icolumnaAuxTRE;
                                                TRE01 = new float[ifilaATRE, icolumnaATRE];
                                                if (SiMatrizA == true)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                                    Console.WriteLine(" PUNTO A");
                                                    Console.WriteLine(" Codigo: " + numerocodigoAuxTRE + "  Con filas: " + ifilaATRE + "  Con Columnas: " + icolumnaATRE);

                                                    for (int i = 0; i < ifilaATRE; i++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int j = 0; j < icolumnaATRE; j++)
                                                        {
                                                            TRE01[i, j] = TREAux[i, j];
                                                            Console.Write(TRE01[i, j] + "   ");
                                                        }
                                                    }
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("\n");
                                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                                }

                                                //MATRIZ B
                                                if (SiMatrizA == true)
                                                {
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        do
                                                        {
                                                            volvervolver = false;
                                                            Console.WriteLine(" Escriba el codigo del PUNTO B que desea TRASLADAR al PUNTO A");
                                                            string numerosho = Console.ReadLine();

                                                            int cantidad = numerosho.Length;
                                                            if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                            {
                                                                volvervolver = false;
                                                                numerocodigoAuxTRE = Convert.ToInt32(numerosho); // convierte a int
                                                            }
                                                            else
                                                            {
                                                                volvervolver = true;
                                                            }
                                                        } while (volvervolver != false);

                                                        if (BuscarTRE(numerocodigoAuxTRE) != 0)
                                                        {
                                                            SiMatrizB = false;
                                                            bool volvers = false;

                                                            do
                                                            {
                                                                volvervolver = false;

                                                                Console.WriteLine("¿Quiere intentar otro codigo?");
                                                                Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                                opcion = Console.ReadLine();

                                                                switch (opcion)
                                                                {
                                                                    case "0":
                                                                        volvervolver = false;
                                                                        volvers = false;
                                                                        break;
                                                                    case "1":
                                                                        volvervolver = false;
                                                                        volvers = true;
                                                                        break;
                                                                    default:
                                                                        Console.WriteLine(" Opcion invalida");
                                                                        volvervolver = true;
                                                                        break;

                                                                }

                                                            } while (volvervolver != false);

                                                            if (volvers == false)
                                                            {
                                                                volvervolver = true;
                                                            }
                                                            else
                                                            {
                                                                volvervolver = false;
                                                            }

                                                        }
                                                        else
                                                        {
                                                            SiMatrizB = true;
                                                        }
                                                    } while (volvervolver != false);
                                                    ifilaBTRE = ifilaAuxTRE;
                                                    icolumnaBTRE = icolumnaAuxTRE;
                                                    TRE02 = new float[ifilaBTRE, icolumnaBTRE];
                                                    if (SiMatrizB == true)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                                        Console.WriteLine(" PUNTO B");
                                                        Console.WriteLine(" Codigo: " + numerocodigoAuxTRE + "  Con filas: " + ifilaBTRE + "  Con Columnas: " + icolumnaBTRE);

                                                        for (int i = 0; i < ifilaBTRE; i++)
                                                        {
                                                            Console.Write("\n");
                                                            for (int j = 0; j < icolumnaBTRE; j++)
                                                            {
                                                                TRE02[i, j] = TREAux[i, j];
                                                                Console.Write(TRE02[i, j] + "   ");
                                                            }
                                                        }
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        Console.WriteLine("\n");
                                                        Console.WriteLine("   -------------------------------------------------------------------    ");
                                                    }
                                                }

                                                if (VC.Igualdad(ifilaATRE, ifilaBTRE) == 0 && VC.Igualdad(icolumnaATRE, icolumnaBTRE) == 0 && SiMatrizA == true && SiMatrizB == true)
                                                {
                                                    volvervolver = false;

                                                    TRE03 = new float[ifilaATRE, icolumnaATRE];
                                                    OC.TraslacionPunto(TRE01[0, 0], TRE01[0, 1], TRE01[0, 2], TRE02[0, 0], TRE02[0, 1], TRE02[0, 2]);

                                                    for (int iA = 0; iA < ifilaATRE; iA++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int jA = 0; jA < icolumnaATRE; jA++)
                                                        {
                                                            float TREA;

                                                            switch (jA)
                                                            {
                                                                case 0:
                                                                    TREA = OC.x;
                                                                    break;
                                                                case 1:
                                                                    TREA = OC.y;
                                                                    break;
                                                                case 2:
                                                                    TREA = OC.z;
                                                                    break;
                                                                case 3:
                                                                    TREA = OC.e;
                                                                    break;
                                                                default:
                                                                    TREA = 0;
                                                                    break;
                                                            }
                                                            TRE03[iA, jA] = TREA;

                                                        }

                                                    }


                                                    AgregarTREResultado(ifilaATRE, icolumnaATRE);
                                                    ImprimirTREEspecifica(numerocodigoAuxTRE); ;

                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                    Console.WriteLine("Warning: El tamaño del valor de las matrices no permite la operacion o no fue encontrada");
                                                    Console.ReadLine();

                                                }

                                                volvervolver = false;
                                                break;
                                            }
                                        case "1":
                                            {
                                                bool SiMatrizA = false;
                                                bool SiMatrizB = false;
                                                bool SiMatrizC = false;
                                                bool SiMatrizD = false;
                                                //MATRIZ A
                                                do
                                                {
                                                    volvervolver = false;
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        Console.WriteLine(" Escriba el codigo del PUNTO A que desea TRASLADAR");
                                                        string numerosho = Console.ReadLine();

                                                        int cantidad = numerosho.Length;
                                                        if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                        {
                                                            volvervolver = false;
                                                            numerocodigoAuxTRE = Convert.ToInt32(numerosho); // convierte a int
                                                        }
                                                        else
                                                        {
                                                            volvervolver = true;
                                                        }
                                                    } while (volvervolver != false);

                                                    if (BuscarTRE(numerocodigoAuxTRE) != 0)
                                                    {
                                                        SiMatrizA = false;
                                                        bool volvers = false;

                                                        do
                                                        {
                                                            volvervolver = false;

                                                            Console.WriteLine("¿Quiere intentar otro codigo?");
                                                            Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                            opcion = Console.ReadLine();

                                                            switch (opcion)
                                                            {
                                                                case "0":
                                                                    volvervolver = false;
                                                                    volvers = false;
                                                                    break;
                                                                case "1":
                                                                    volvervolver = false;
                                                                    volvers = true;
                                                                    SiMatrizA = false;
                                                                    break;
                                                                default:
                                                                    Console.WriteLine(" Opcion invalida");
                                                                    volvervolver = true;
                                                                    break;

                                                            }

                                                        } while (volvervolver != false);

                                                        if (volvers == false)
                                                        {
                                                            volvervolver = true;
                                                        }
                                                        else
                                                        {
                                                            volvervolver = false;
                                                        }

                                                    }
                                                    else
                                                    {
                                                        SiMatrizA = true;
                                                    }
                                                } while (volvervolver != false);
                                                ifilaATRE = ifilaAuxTRE;
                                                icolumnaATRE = icolumnaAuxTRE;
                                                TRE01 = new float[ifilaATRE, icolumnaATRE];
                                                if (SiMatrizA == true)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                                    Console.WriteLine(" PUNTO A");
                                                    Console.WriteLine(" Codigo: " + numerocodigoAuxTRE + "  Con filas: " + ifilaATRE + "  Con Columnas: " + icolumnaATRE);

                                                    for (int i = 0; i < ifilaATRE; i++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int j = 0; j < icolumnaATRE; j++)
                                                        {
                                                            TRE01[i, j] = TREAux[i, j];
                                                            Console.Write(TRE01[i, j] + "   ");
                                                        }
                                                    }
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("\n");
                                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                                }

                                                //ESCALAR B
                                                if (SiMatrizA == true)
                                                {
                                                    do
                                                    {
                                                        volver = false;
                                                        Console.WriteLine(" Escriba el numero en X que desea trasladar");
                                                        string numeromatriz = Console.ReadLine();
                                                        int cantidad = numeromatriz.Length;
                                                        if (VC.Contador(cantidad, numeromatriz) == 0)
                                                        {
                                                            volver = false;
                                                            float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                                                            inumeromatriz = (float)Math.Round(inumeromatriz, 2);
                                                            escalarATRE = inumeromatriz;
                                                            SiMatrizB = true;
                                                        }
                                                        else
                                                        {
                                                            SiMatrizB = false;
                                                            volver = true;
                                                        }
                                                    } while (volver != false);

                                                    do
                                                    {
                                                        volver = false;
                                                        Console.WriteLine(" Escriba el numero en Y que desea trasladar");
                                                        string numeromatriz = Console.ReadLine();
                                                        int cantidad = numeromatriz.Length;
                                                        if (VC.Contador(cantidad, numeromatriz) == 0)
                                                        {
                                                            volver = false;
                                                            float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                                                            inumeromatriz = (float)Math.Round(inumeromatriz, 2);
                                                            escalarBTRE = inumeromatriz;
                                                            SiMatrizC = true;
                                                        }
                                                        else
                                                        {
                                                            SiMatrizC = false;
                                                            volver = true;
                                                        }
                                                    } while (volver != false);

                                                    do
                                                    {
                                                        volver = false;
                                                        Console.WriteLine(" Escriba el numero en Z que desea trasladar");
                                                        string numeromatriz = Console.ReadLine();
                                                        int cantidad = numeromatriz.Length;
                                                        if (VC.Contador(cantidad, numeromatriz) == 0)
                                                        {
                                                            volver = false;
                                                            float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                                                            inumeromatriz = (float)Math.Round(inumeromatriz, 2);
                                                            escalarCTRE = inumeromatriz;
                                                            SiMatrizD = true;
                                                        }
                                                        else
                                                        {
                                                            SiMatrizD = false;
                                                            volver = true;
                                                        }
                                                    } while (volver != false);
                                                }

                                                if (SiMatrizA == true && SiMatrizB == true && SiMatrizC == true && SiMatrizD == true)
                                                {
                                                    volvervolver = false;

                                                    TRE03 = new float[ifilaATRE, icolumnaATRE];
                                                    OC.TraslacionPunto(escalarATRE, escalarBTRE, escalarCTRE, TRE01[0, 0], TRE01[0, 1], TRE01[0, 2]);

                                                    for (int iA = 0; iA < ifilaATRE; iA++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int jA = 0; jA < icolumnaATRE; jA++)
                                                        {
                                                            float TREA;

                                                            switch (jA)
                                                            {
                                                                case 0:
                                                                    TREA = OC.x;
                                                                    break;
                                                                case 1:
                                                                    TREA = OC.y;
                                                                    break;
                                                                case 2:
                                                                    TREA = OC.z;
                                                                    break;
                                                                case 3:
                                                                    TREA = OC.e;
                                                                    break;
                                                                default:
                                                                    TREA = 0;
                                                                    break;
                                                            }
                                                            TRE03[iA, jA] = TREA;

                                                        }

                                                    }


                                                    AgregarTREResultado(ifilaATRE, icolumnaATRE);
                                                    ImprimirTREEspecifica(numerocodigoAuxTRE);

                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                    Console.WriteLine("Warning: El tamaño del valor de los PUNTOS no permite la operacion o no fue encontrada");
                                                    Console.ReadLine();

                                                }

                                                volvervolver = false;
                                                break;
                                            }
                                        default:
                                            Console.WriteLine(" Opcion invalida");
                                            volvervolver = true;
                                            break;
                                    }

                                } while (volvervolver != false);

                            }
                            volvervolver = true;
                            break;
                        }
                    case "5":
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                            Console.WriteLine("║                              ROTACION                                 ║ ");
                            Console.WriteLine("║                                                                       ║ ");

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("║              SIGA POR FAVOR LAS INSTRUCCIONES SIGUIENTES              ║ ");
                            Console.WriteLine("║                                                                       ║ ");
                            Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");


                            if (inicioTRE == null)
                            {
                                volvervolver = true;
                                Console.WriteLine("Warning: Aun no se agregan datos suficientes para la operacion");
                                Console.ReadLine();
                            }
                            else
                            {
                                    bool SiMatrizA = false;
                                    bool SiMatrizB = false;
                                    bool SiMatrizC = false;
                                    bool SiMatrizD = false;
                                    //MATRIZ A
                                    do
                                    {
                                        volvervolver = false;
                                        do
                                        {
                                            volvervolver = false;
                                            Console.WriteLine(" Escriba el codigo del PUNTO A que desea ROTAR");
                                            string numerosho = Console.ReadLine();

                                            int cantidad = numerosho.Length;
                                            if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                            {
                                                volvervolver = false;
                                                numerocodigoAuxTRE = Convert.ToInt32(numerosho); // convierte a int
                                            }
                                            else
                                            {
                                                volvervolver = true;
                                            }
                                        } while (volvervolver != false);

                                        if (BuscarTRE(numerocodigoAuxTRE) != 0)
                                        {
                                            SiMatrizA = false;
                                            bool volvers = false;

                                            do
                                            {
                                                volvervolver = false;

                                                Console.WriteLine("¿Quiere intentar otro codigo?");
                                                Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                opcion = Console.ReadLine();

                                                switch (opcion)
                                                {
                                                    case "0":
                                                        volvervolver = false;
                                                        volvers = false;
                                                        break;
                                                    case "1":
                                                        volvervolver = false;
                                                        volvers = true;
                                                        SiMatrizA = false;
                                                        break;
                                                    default:
                                                        Console.WriteLine(" Opcion invalida");
                                                        volvervolver = true;
                                                        break;

                                                }

                                            } while (volvervolver != false);

                                            if (volvers == false)
                                            {
                                                volvervolver = true;
                                            }
                                            else
                                            {
                                                volvervolver = false;
                                            }

                                        }
                                        else
                                        {
                                            SiMatrizA = true;
                                        }
                                    } while (volvervolver != false);
                                    ifilaATRE = ifilaAuxTRE;
                                    icolumnaATRE = icolumnaAuxTRE;
                                    TRE01 = new float[ifilaATRE, icolumnaATRE];
                                    if (SiMatrizA == true)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                        Console.WriteLine(" PUNTO A");
                                        Console.WriteLine(" Codigo: " + numerocodigoAuxTRE + "  Con filas: " + ifilaATRE + "  Con Columnas: " + icolumnaATRE);

                                        for (int i = 0; i < ifilaATRE; i++)
                                        {
                                            Console.Write("\n");
                                            for (int j = 0; j < icolumnaATRE; j++)
                                            {
                                                TRE01[i, j] = TREAux[i, j];
                                                Console.Write(TRE01[i, j] + "   ");
                                            }
                                        }
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("\n");
                                        Console.WriteLine("   -------------------------------------------------------------------    ");
                                    }

                                    //ESCALAR B
                                    if (SiMatrizA == true)
                                    {
                                        do
                                        {
                                            volver = false;
                                            Console.WriteLine(" Escriba la opcion deseada: 0 Rotar en X | 1 Rotar en Y | 2 Rotar en Z");
                                            string numeromatriz = Console.ReadLine();
                                            int cantidad = numeromatriz.Length;
                                            if (VC.Contador(cantidad, numeromatriz) == 0)
                                            {
                                                volver = false;
                                                float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                                                if (inumeromatriz == 0 || inumeromatriz == 1 || inumeromatriz == 2)
                                                {
                                                    inumeromatriz = (float)Math.Round(inumeromatriz, 2);
                                                    xyzTRE = inumeromatriz;
                                                    SiMatrizC = true;
                                                }
                                                else
                                                {
                                                    SiMatrizC = false;
                                                }
                                            }
                                            else
                                            {
                                                SiMatrizC = false;
                                                volver = true;
                                            }
                                        } while (volver != false);

                                        if (SiMatrizC == true)
                                        {
                                            do
                                            {
                                                volver = false;
                                                Console.WriteLine(" Escriba el angulo al que desea ROTAR");
                                                string numeromatriz = Console.ReadLine();
                                                int cantidad = numeromatriz.Length;
                                                if (VC.Contador(cantidad, numeromatriz) == 0)
                                                {
                                                    volver = false;
                                                    float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                                                    inumeromatriz = (float)Math.Round(inumeromatriz, 2);
                                                    escalarATRE = inumeromatriz;
                                                    SiMatrizB = true;
                                                }
                                                else
                                                {
                                                    SiMatrizB = false;
                                                    volver = true;
                                                }
                                            } while (volver != false);
                                        }
                                    }

                                    if (SiMatrizA == true && SiMatrizB == true && SiMatrizC == true)
                                    {
                                        volvervolver = false;

                                        TRE03 = new float[ifilaATRE, icolumnaATRE];
                                        OC.RotacionPunto(xyzTRE, escalarATRE, TRE01[0, 0], TRE01[0, 1], TRE01[0, 2]);

                                        for (int iA = 0; iA < ifilaATRE; iA++)
                                        {
                                            Console.Write("\n");
                                            for (int jA = 0; jA < icolumnaATRE; jA++)
                                            {
                                                float TREA;

                                                switch (jA)
                                                {
                                                    case 0:
                                                        TREA = OC.x;
                                                        break;
                                                    case 1:
                                                        TREA = OC.y;
                                                        break;
                                                    case 2:
                                                        TREA = OC.z;
                                                        break;
                                                    case 3:
                                                        TREA = OC.e;
                                                        break;
                                                    default:
                                                        TREA = 0;
                                                        break;
                                                }
                                                TRE03[iA, jA] = TREA;

                                            }

                                        }


                                        AgregarTREResultado(ifilaATRE, icolumnaATRE);
                                        ImprimirTREEspecifica(numerocodigoAuxTRE);

                                    }
                                    else
                                    {
                                        volvervolver = true;
                                        Console.WriteLine("Warning: El tamaño del valor de los PUNTOS no permite la operacion o no fue encontrada");
                                        Console.ReadLine();

                                    }

                            }
                            volvervolver = true;
                            break;
                        }
                    case "6":
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                            Console.WriteLine("║                              ESCALAR                                  ║ ");
                            Console.WriteLine("║                                                                       ║ ");

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("║              SIGA POR FAVOR LAS INSTRUCCIONES SIGUIENTES              ║ ");
                            Console.WriteLine("║                                                                       ║ ");
                            Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");


                            if (inicioTRE == null)
                            {
                                volvervolver = true;
                                Console.WriteLine("Warning: Aun no se agregan datos suficientes para la operacion");
                                Console.ReadLine();
                            }
                            else
                            {
                                do
                                {

                                    Console.WriteLine(" ");
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("¿COMO REALIZARAS LA TRASLACION? 0. Punto-Punto | 2. Punto-Escalar");
                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("¿Que opcion elige?                                                        ");
                                    opcion = Console.ReadLine();
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                    Console.ForegroundColor = ConsoleColor.White;

                                    switch (opcion)
                                    {
                                        case "0":
                                            {
                                                bool SiMatrizA = false;
                                                bool SiMatrizB = false;
                                                //MATRIZ A
                                                do
                                                {
                                                    volvervolver = false;
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        Console.WriteLine(" Escriba el codigo del PUNTO A que desea ESCALR");
                                                        string numerosho = Console.ReadLine();

                                                        int cantidad = numerosho.Length;
                                                        if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                        {
                                                            volvervolver = false;
                                                            numerocodigoAuxTRE = Convert.ToInt32(numerosho); // convierte a int
                                                        }
                                                        else
                                                        {
                                                            volvervolver = true;
                                                        }
                                                    } while (volvervolver != false);

                                                    if (BuscarTRE(numerocodigoAuxTRE) != 0)
                                                    {
                                                        SiMatrizA = false;
                                                        bool volvers = false;

                                                        do
                                                        {
                                                            volvervolver = false;

                                                            Console.WriteLine("¿Quiere intentar otro codigo?");
                                                            Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                            opcion = Console.ReadLine();

                                                            switch (opcion)
                                                            {
                                                                case "0":
                                                                    volvervolver = false;
                                                                    volvers = false;
                                                                    break;
                                                                case "1":
                                                                    volvervolver = false;
                                                                    volvers = true;
                                                                    SiMatrizA = false;
                                                                    break;
                                                                default:
                                                                    Console.WriteLine(" Opcion invalida");
                                                                    volvervolver = true;
                                                                    break;

                                                            }

                                                        } while (volvervolver != false);

                                                        if (volvers == false)
                                                        {
                                                            volvervolver = true;
                                                        }
                                                        else
                                                        {
                                                            volvervolver = false;
                                                        }

                                                    }
                                                    else
                                                    {
                                                        SiMatrizA = true;
                                                    }
                                                } while (volvervolver != false);

                                                ifilaATRE = ifilaAuxTRE;
                                                icolumnaATRE = icolumnaAuxTRE;
                                                TRE01 = new float[ifilaATRE, icolumnaATRE];
                                                if (SiMatrizA == true)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                                    Console.WriteLine(" PUNTO A");
                                                    Console.WriteLine(" Codigo: " + numerocodigoAuxTRE + "  Con filas: " + ifilaATRE + "  Con Columnas: " + icolumnaATRE);

                                                    for (int i = 0; i < ifilaATRE; i++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int j = 0; j < icolumnaATRE; j++)
                                                        {
                                                            TRE01[i, j] = TREAux[i, j];
                                                            Console.Write(TRE01[i, j] + "   ");
                                                        }
                                                    }
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("\n");
                                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                                }

                                                //MATRIZ B
                                                if (SiMatrizA == true)
                                                {
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        do
                                                        {
                                                            volvervolver = false;
                                                            Console.WriteLine(" Escriba el codigo del PUNTO B que desea ESCALAR al PUNTO A");
                                                            string numerosho = Console.ReadLine();

                                                            int cantidad = numerosho.Length;
                                                            if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                            {
                                                                volvervolver = false;
                                                                numerocodigoAuxTRE = Convert.ToInt32(numerosho); // convierte a int
                                                            }
                                                            else
                                                            {
                                                                volvervolver = true;
                                                            }
                                                        } while (volvervolver != false);

                                                        if (BuscarTRE(numerocodigoAuxTRE) != 0)
                                                        {
                                                            SiMatrizB = false;
                                                            bool volvers = false;

                                                            do
                                                            {
                                                                volvervolver = false;

                                                                Console.WriteLine("¿Quiere intentar otro codigo?");
                                                                Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                                opcion = Console.ReadLine();

                                                                switch (opcion)
                                                                {
                                                                    case "0":
                                                                        volvervolver = false;
                                                                        volvers = false;
                                                                        break;
                                                                    case "1":
                                                                        volvervolver = false;
                                                                        volvers = true;
                                                                        break;
                                                                    default:
                                                                        Console.WriteLine(" Opcion invalida");
                                                                        volvervolver = true;
                                                                        break;

                                                                }

                                                            } while (volvervolver != false);

                                                            if (volvers == false)
                                                            {
                                                                volvervolver = true;
                                                            }
                                                            else
                                                            {
                                                                volvervolver = false;
                                                            }

                                                        }
                                                        else
                                                        {
                                                            SiMatrizB = true;
                                                        }
                                                    } while (volvervolver != false);
                                                    ifilaBTRE = ifilaAuxTRE;
                                                    icolumnaBTRE = icolumnaAuxTRE;
                                                    TRE02 = new float[ifilaBTRE, icolumnaBTRE];
                                                    if (SiMatrizB == true)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                                        Console.WriteLine(" PUNTO B");
                                                        Console.WriteLine(" Codigo: " + numerocodigoAuxTRE + "  Con filas: " + ifilaBTRE + "  Con Columnas: " + icolumnaBTRE);

                                                        for (int i = 0; i < ifilaBTRE; i++)
                                                        {
                                                            Console.Write("\n");
                                                            for (int j = 0; j < icolumnaBTRE; j++)
                                                            {
                                                                TRE02[i, j] = TREAux[i, j];
                                                                Console.Write(TRE02[i, j] + "   ");
                                                            }
                                                        }
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        Console.WriteLine("\n");
                                                        Console.WriteLine("   -------------------------------------------------------------------    ");
                                                    }
                                                }

                                                if (VC.Igualdad(ifilaATRE, ifilaBTRE) == 0 && VC.Igualdad(icolumnaATRE, icolumnaBTRE) == 0 && SiMatrizA == true && SiMatrizB == true)
                                                {
                                                    volvervolver = false;

                                                    TRE03 = new float[ifilaATRE, icolumnaATRE];
                                                    OC.EscalarPunto(TRE01[0, 0], TRE01[0, 1], TRE01[0, 2], TRE02[0, 0], TRE02[0, 1], TRE02[0, 2]);

                                                    for (int iA = 0; iA < ifilaATRE; iA++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int jA = 0; jA < icolumnaATRE; jA++)
                                                        {
                                                            float TREA;

                                                            switch (jA)
                                                            {
                                                                case 0:
                                                                    TREA = OC.x;
                                                                    break;
                                                                case 1:
                                                                    TREA = OC.y;
                                                                    break;
                                                                case 2:
                                                                    TREA = OC.z;
                                                                    break;
                                                                case 3:
                                                                    TREA = OC.e;
                                                                    break;
                                                                default:
                                                                    TREA = 0;
                                                                    break;
                                                            }
                                                            TRE03[iA, jA] = TREA;

                                                        }

                                                    }


                                                    AgregarTREResultado(ifilaATRE, icolumnaATRE);
                                                    ImprimirTREEspecifica(numerocodigoAuxTRE); ;

                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                    Console.WriteLine("Warning: El tamaño del valor de las matrices no permite la operacion o no fue encontrada");
                                                    Console.ReadLine();

                                                }

                                                volvervolver = false;
                                                break;
                                            }
                                        case "1":
                                            {
                                                bool SiMatrizA = false;
                                                bool SiMatrizB = false;
                                                bool SiMatrizC = false;
                                                bool SiMatrizD = false;
                                                //MATRIZ A
                                                do
                                                {
                                                    volvervolver = false;
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        Console.WriteLine(" Escriba el codigo del PUNTO A que desea ESCALAR");
                                                        string numerosho = Console.ReadLine();

                                                        int cantidad = numerosho.Length;
                                                        if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                        {
                                                            volvervolver = false;
                                                            numerocodigoAuxTRE = Convert.ToInt32(numerosho); // convierte a int
                                                        }
                                                        else
                                                        {
                                                            volvervolver = true;
                                                        }
                                                    } while (volvervolver != false);

                                                    if (BuscarTRE(numerocodigoAuxTRE) != 0)
                                                    {
                                                        SiMatrizA = false;
                                                        bool volvers = false;

                                                        do
                                                        {
                                                            volvervolver = false;

                                                            Console.WriteLine("¿Quiere intentar otro codigo?");
                                                            Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                            opcion = Console.ReadLine();

                                                            switch (opcion)
                                                            {
                                                                case "0":
                                                                    volvervolver = false;
                                                                    volvers = false;
                                                                    break;
                                                                case "1":
                                                                    volvervolver = false;
                                                                    volvers = true;
                                                                    SiMatrizA = false;
                                                                    break;
                                                                default:
                                                                    Console.WriteLine(" Opcion invalida");
                                                                    volvervolver = true;
                                                                    break;

                                                            }

                                                        } while (volvervolver != false);

                                                        if (volvers == false)
                                                        {
                                                            volvervolver = true;
                                                        }
                                                        else
                                                        {
                                                            volvervolver = false;
                                                        }

                                                    }
                                                    else
                                                    {
                                                        SiMatrizA = true;
                                                    }
                                                } while (volvervolver != false);
                                                ifilaATRE = ifilaAuxTRE;
                                                icolumnaATRE = icolumnaAuxTRE;
                                                TRE01 = new float[ifilaATRE, icolumnaATRE];
                                                if (SiMatrizA == true)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                                    Console.WriteLine(" PUNTO A");
                                                    Console.WriteLine(" Codigo: " + numerocodigoAuxTRE + "  Con filas: " + ifilaATRE + "  Con Columnas: " + icolumnaATRE);

                                                    for (int i = 0; i < ifilaATRE; i++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int j = 0; j < icolumnaATRE; j++)
                                                        {
                                                            TRE01[i, j] = TREAux[i, j];
                                                            Console.Write(TRE01[i, j] + "   ");
                                                        }
                                                    }
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("\n");
                                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                                }

                                                //ESCALAR B
                                                if (SiMatrizA == true)
                                                {
                                                    do
                                                    {
                                                        volver = false;
                                                        Console.WriteLine(" Escriba el numero en X que desea ESCALAR");
                                                        string numeromatriz = Console.ReadLine();
                                                        int cantidad = numeromatriz.Length;
                                                        if (VC.Contador(cantidad, numeromatriz) == 0)
                                                        {
                                                            volver = false;
                                                            float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                                                            inumeromatriz = (float)Math.Round(inumeromatriz, 2);
                                                            escalarATRE = inumeromatriz;
                                                            SiMatrizB = true;
                                                        }
                                                        else
                                                        {
                                                            SiMatrizB = false;
                                                            volver = true;
                                                        }
                                                    } while (volver != false);

                                                    do
                                                    {
                                                        volver = false;
                                                        Console.WriteLine(" Escriba el numero en Y que desea ESCALAR");
                                                        string numeromatriz = Console.ReadLine();
                                                        int cantidad = numeromatriz.Length;
                                                        if (VC.Contador(cantidad, numeromatriz) == 0)
                                                        {
                                                            volver = false;
                                                            float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                                                            inumeromatriz = (float)Math.Round(inumeromatriz, 2);
                                                            escalarBTRE = inumeromatriz;
                                                            SiMatrizC = true;
                                                        }
                                                        else
                                                        {
                                                            SiMatrizC = false;
                                                            volver = true;
                                                        }
                                                    } while (volver != false);

                                                    do
                                                    {
                                                        volver = false;
                                                        Console.WriteLine(" Escriba el numero en Z que desea ESCALAR");
                                                        string numeromatriz = Console.ReadLine();
                                                        int cantidad = numeromatriz.Length;
                                                        if (VC.Contador(cantidad, numeromatriz) == 0)
                                                        {
                                                            volver = false;
                                                            float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                                                            inumeromatriz = (float)Math.Round(inumeromatriz, 2);
                                                            escalarCTRE = inumeromatriz;
                                                            SiMatrizD = true;
                                                        }
                                                        else
                                                        {
                                                            SiMatrizD = false;
                                                            volver = true;
                                                        }
                                                    } while (volver != false);
                                                }

                                                if (SiMatrizA == true && SiMatrizB == true && SiMatrizC == true && SiMatrizD == true)
                                                {
                                                    volvervolver = false;

                                                    TRE03 = new float[ifilaATRE, icolumnaATRE];
                                                    OC.EscalarPunto(escalarATRE, escalarBTRE, escalarCTRE, TRE01[0, 0], TRE01[0, 1], TRE01[0, 2]);

                                                    for (int iA = 0; iA < ifilaATRE; iA++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int jA = 0; jA < icolumnaATRE; jA++)
                                                        {
                                                            float TREA;

                                                            switch (jA)
                                                            {
                                                                case 0:
                                                                    TREA = OC.x;
                                                                    break;
                                                                case 1:
                                                                    TREA = OC.y;
                                                                    break;
                                                                case 2:
                                                                    TREA = OC.z;
                                                                    break;
                                                                case 3:
                                                                    TREA = OC.e;
                                                                    break;
                                                                default:
                                                                    TREA = 0;
                                                                    break;
                                                            }
                                                            TRE03[iA, jA] = TREA;

                                                        }

                                                    }


                                                    AgregarTREResultado(ifilaATRE, icolumnaATRE);
                                                    ImprimirTREEspecifica(numerocodigoAuxTRE);

                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                    Console.WriteLine("Warning: El tamaño del valor de los PUNTOS no permite la operacion o no fue encontrada");
                                                    Console.ReadLine();

                                                }

                                                volvervolver = false;
                                                break;
                                            }
                                        default:
                                            Console.WriteLine(" Opcion invalida");
                                            volvervolver = true;
                                            break;
                                    }

                                } while (volvervolver != false);

                            }
                            volvervolver = true;
                            break;
                        }
                    case "7":
                        {
                            volvervolver = false;
                            break;
                        }
                    default:
                        Console.WriteLine(" Opcion invalida");
                        volvervolver = true;
                        break;
                }

            } while (volvervolver != false);
        }

        public void Vectores()
        {
            do
            {
                volvervolver = false;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                Console.WriteLine("║                              VECTORES                                 ║ ");
                Console.WriteLine("║                                                                       ║ ");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("║            INSERTE UN NUMERO SEGUN LA OPCION DESEADA DEL MENU         ║ ");
                Console.WriteLine("║ 0. Agregar Vector                1. Imprimir Vectores                 ║ ");
                Console.WriteLine("║ 2. Modificar Vector              3. Eliminar Vector                   ║ ");
                Console.WriteLine("║ 4. Suma                          5. Resta                             ║ ");
                Console.WriteLine("║ 6. Multiplicacion                7. Normalizacion                     ║ ");
                Console.WriteLine("║ 8. Regresar                                                           ║ ");
                Console.WriteLine("║                                                                       ║ ");
                Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");


                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("   -------------------------------------------------------------------    ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("¿Que opcion elige?                                                        ");
                opcion = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("   -------------------------------------------------------------------    ");
                Console.ForegroundColor = ConsoleColor.White;

                switch (opcion)
                {
                    case "0":
                        {
                            do
                            {
                                volvervolver = false;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                                Console.WriteLine("║                           AGREGAR VECTOR                              ║ ");
                                Console.WriteLine("║                                                                       ║ ");

                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("║              SIGA POR FAVOR LAS INSTRUCCIONES SIGUIENTES              ║ ");
                                Console.WriteLine("║                                                                       ║ ");
                                Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");

                                AgregarVectores();
                                ImprimirVectorEspecifica(numerocodigoAuxVEC);

                                volvervolver = false;
                            } while (volvervolver != false);
                            volvervolver = true;
                            break;
                        }
                    case "1":
                        {
                            do
                            {
                                volvervolver = false;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                                Console.WriteLine("║                          IMPRIMIR VECTOR                              ║ ");
                                Console.WriteLine("║                                                                       ║ ");

                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("║            INSERTE UN NUMERO SEGUN LA OPCION DESEADA DEL MENU         ║ ");
                                Console.WriteLine("║ 0. Imprimir todos los vectores   1. Imprimir vector especifico        ║ ");
                                Console.WriteLine("║ 2. Salir                                                              ║ ");
                                Console.WriteLine("║                                                                       ║ ");
                                Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");

                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("   -------------------------------------------------------------------    ");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("¿Que opcion elige?                                                        ");
                                opcion = Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("   -------------------------------------------------------------------    ");
                                Console.ForegroundColor = ConsoleColor.White;

                                switch (opcion)
                                {
                                    case "0":
                                        ImprimirVectores();
                                        volvervolver = false;
                                        break;
                                    case "1":
                                        do
                                        {
                                            volvervolver = false;
                                            do
                                            {
                                                volvervolver = false;
                                                Console.WriteLine(" Escriba el codigo del vector que busca");
                                                string numerosho = Console.ReadLine();

                                                int cantidad = numerosho.Length;
                                                if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                {
                                                    volvervolver = false;
                                                    numerocodigoAuxVEC = Convert.ToInt32(numerosho); // convierte a int
                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                }
                                            } while (volvervolver != false);

                                            if (ImprimirVectorEspecifica(numerocodigoAuxVEC) != 0)
                                            {

                                                bool volvers = false;

                                                do
                                                {
                                                    volvervolver = false;

                                                    Console.WriteLine("¿Quiere intentar otro codigo?");
                                                    Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                    opcion = Console.ReadLine();

                                                    switch (opcion)
                                                    {
                                                        case "0":
                                                            volvervolver = false;
                                                            volvers = false;
                                                            break;
                                                        case "1":
                                                            volvervolver = false;
                                                            volvers = true;
                                                            break;
                                                        default:
                                                            Console.WriteLine(" Opcion invalida");
                                                            volvervolver = true;
                                                            break;

                                                    }

                                                } while (volvervolver != false);

                                                if (volvers == false)
                                                {
                                                    volvervolver = true;
                                                }
                                                else
                                                {
                                                    volvervolver = false;
                                                }

                                            }
                                        } while (volvervolver != false);
                                        volvervolver = false;
                                        break;
                                    case "2":
                                        volvervolver = false;
                                        break;

                                    default:
                                        Console.WriteLine(" Opcion invalida");
                                        volvervolver = true;
                                        break;
                                }

                            } while (volvervolver != false);
                            volvervolver = true;
                            break;
                        }
                    case "2":
                        {
                            do
                            {
                                volvervolver = false;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                                Console.WriteLine("║                         MODIFICAR VECTOR                              ║ ");
                                Console.WriteLine("║                                                                       ║ ");

                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("║            INSERTE UN NUMERO SEGUN LA OPCION DESEADA DEL MENU         ║ ");
                                Console.WriteLine("║ 0. Modificar todo el vector  1. Modificar dato especifico del vector  ║ ");
                                Console.WriteLine("║ 2. Salir                                                              ║ ");
                                Console.WriteLine("║                                                                       ║ ");
                                Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");

                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("   -------------------------------------------------------------------    ");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("¿Que opcion elige?                                                        ");
                                opcion = Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("   -------------------------------------------------------------------    ");
                                Console.ForegroundColor = ConsoleColor.White;

                                switch (opcion)
                                {
                                    case "0":
                                        do
                                        {
                                            volvervolver = false;
                                            do
                                            {
                                                volvervolver = false;
                                                Console.WriteLine(" Escriba el codigo del vector que busca");
                                                string numerosho = Console.ReadLine();

                                                int cantidad = numerosho.Length;
                                                if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                {
                                                    volvervolver = false;
                                                    numerocodigoAuxVEC = Convert.ToInt32(numerosho); // convierte a int
                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                }
                                            } while (volvervolver != false);

                                            if (ModificarVector(numerocodigoAuxVEC) != 0)
                                            {

                                                bool volvers = false;

                                                do
                                                {
                                                    volvervolver = false;

                                                    Console.WriteLine("¿Quiere intentar otro codigo?");
                                                    Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                    opcion = Console.ReadLine();

                                                    switch (opcion)
                                                    {
                                                        case "0":
                                                            volvervolver = false;
                                                            volvers = false;
                                                            break;
                                                        case "1":
                                                            volvervolver = false;
                                                            volvers = true;
                                                            break;
                                                        default:
                                                            Console.WriteLine(" Opcion invalida");
                                                            volvervolver = true;
                                                            break;

                                                    }

                                                } while (volvervolver != false);

                                                if (volvers == false)
                                                {
                                                    volvervolver = true;
                                                }
                                                else
                                                {
                                                    volvervolver = false;
                                                }

                                            }
                                            else
                                            {
                                                ImprimirVectorEspecifica(numerocodigoAuxVEC);
                                            }



                                        } while (volvervolver != false);
                                        volvervolver = false;
                                        break;
                                    case "1":
                                        do
                                        {
                                            volvervolver = false;
                                            do
                                            {
                                                volvervolver = false;
                                                Console.WriteLine(" Escriba el codigo del vector que busca");
                                                string numerosho = Console.ReadLine();

                                                int cantidad = numerosho.Length;
                                                if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                {
                                                    volvervolver = false;
                                                    numerocodigoAuxVEC = Convert.ToInt32(numerosho); // convierte a int
                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                }
                                            } while (volvervolver != false);

                                            if (ModificarVectorEspecifica(numerocodigoAuxVEC) != 0)
                                            {

                                                bool volvers = false;

                                                do
                                                {
                                                    volvervolver = false;

                                                    Console.WriteLine("¿Quiere intentar otro codigo?");
                                                    Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                    opcion = Console.ReadLine();

                                                    switch (opcion)
                                                    {
                                                        case "0":
                                                            volvervolver = false;
                                                            volvers = false;
                                                            break;
                                                        case "1":
                                                            volvervolver = false;
                                                            volvers = true;
                                                            break;
                                                        default:
                                                            Console.WriteLine(" Opcion invalida");
                                                            volvervolver = true;
                                                            break;

                                                    }

                                                } while (volvervolver != false);

                                                if (volvers == false)
                                                {
                                                    volvervolver = true;
                                                }
                                                else
                                                {
                                                    volvervolver = false;
                                                }

                                            }
                                        } while (volvervolver != false);
                                        volvervolver = false;
                                        break;
                                    case "2":
                                        volvervolver = false;
                                        break;

                                    default:
                                        Console.WriteLine(" Opcion invalida");
                                        volvervolver = true;
                                        break;
                                }

                            } while (volvervolver != false);
                            volvervolver = true;
                            break;
                        }
                    case "3":
                        {
                            do
                            {
                                volvervolver = false;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                                Console.WriteLine("║                          ELIMINAR VECTOR                              ║ ");
                                Console.WriteLine("║                                                                       ║ ");

                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("║              SIGA POR FAVOR LAS INSTRUCCIONES SIGUIENTES              ║ ");
                                Console.WriteLine("║                                                                       ║ ");
                                Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");

                                do
                                {
                                    volvervolver = false;
                                    Console.WriteLine(" Escriba el codigo del vector que quiera eliminar");
                                    string numerosho = Console.ReadLine();

                                    int cantidad = numerosho.Length;
                                    if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                    {
                                        volvervolver = false;
                                        numerocodigoAuxVEC = Convert.ToInt32(numerosho); // convierte a int
                                    }
                                    else
                                    {
                                        volvervolver = true;
                                    }
                                } while (volvervolver != false);
                                if (EliminarVector(numerocodigoAuxVEC) != 0)
                                {

                                    bool volvers = false;

                                    do
                                    {
                                        volvervolver = false;

                                        Console.WriteLine("¿Quiere intentar otro codigo?");
                                        Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                        opcion = Console.ReadLine();

                                        switch (opcion)
                                        {
                                            case "0":
                                                volvervolver = false;
                                                volvers = false;
                                                break;
                                            case "1":
                                                volvervolver = false;
                                                volvers = true;
                                                break;
                                            default:
                                                Console.WriteLine(" Opcion invalida");
                                                volvervolver = true;
                                                break;

                                        }

                                    } while (volvervolver != false);

                                    if (volvers == false)
                                    {
                                        volvervolver = true;
                                    }
                                    else
                                    {
                                        volvervolver = false;
                                    }

                                }


                            } while (volvervolver != false);
                            volvervolver = true;
                            break;
                        }
                    case "4":
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                            Console.WriteLine("║                             SUMAR VECTOR                              ║ ");
                            Console.WriteLine("║                                                                       ║ ");

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("║              SIGA POR FAVOR LAS INSTRUCCIONES SIGUIENTES              ║ ");
                            Console.WriteLine("║                                                                       ║ ");
                            Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");


                            if (inicioVEC == null)
                            {
                                volvervolver = true;
                                Console.WriteLine("Warning: Aun no se agregan datos suficientes para la operacion");
                                Console.ReadLine();
                            }
                            else
                            {
                                do
                                {

                                    Console.WriteLine(" ");
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine("¿COMO REALIZARAS LA SUMA? 0. Vector-Vector | 1. Escalar-Vector | 2. Vector-Escalar");
                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("¿Que opcion elige?                                                        ");
                                    opcion = Console.ReadLine();
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                    Console.ForegroundColor = ConsoleColor.White;

                                    switch (opcion)
                                    {
                                        case "0":
                                            {
                                                bool SiMatrizA = false;
                                                bool SiMatrizB = false;
                                                //MATRIZ A
                                                do
                                                {
                                                    volvervolver = false;
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        Console.WriteLine(" Escriba el codigo del VECTOR A que desea sumar");
                                                        string numerosho = Console.ReadLine();

                                                        int cantidad = numerosho.Length;
                                                        if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                        {
                                                            volvervolver = false;
                                                            numerocodigoAuxVEC = Convert.ToInt32(numerosho); // convierte a int
                                                        }
                                                        else
                                                        {
                                                            volvervolver = true;
                                                        }
                                                    } while (volvervolver != false);

                                                    if (BuscarVector(numerocodigoAuxVEC) != 0)
                                                    {
                                                        SiMatrizA = false;
                                                        bool volvers = false;

                                                        do
                                                        {
                                                            volvervolver = false;

                                                            Console.WriteLine("¿Quiere intentar otro codigo?");
                                                            Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                            opcion = Console.ReadLine();

                                                            switch (opcion)
                                                            {
                                                                case "0":
                                                                    volvervolver = false;
                                                                    volvers = false;
                                                                    break;
                                                                case "1":
                                                                    volvervolver = false;
                                                                    volvers = true;
                                                                    SiMatrizA = false;
                                                                    break;
                                                                default:
                                                                    Console.WriteLine(" Opcion invalida");
                                                                    volvervolver = true;
                                                                    break;

                                                            }

                                                        } while (volvervolver != false);

                                                        if (volvers == false)
                                                        {
                                                            volvervolver = true;
                                                        }
                                                        else
                                                        {
                                                            volvervolver = false;
                                                        }

                                                    }
                                                    else
                                                    {
                                                        SiMatrizA = true;
                                                    }
                                                } while (volvervolver != false);

                                                ifilaAVEC = ifilaAuxVEC;
                                                icolumnaAVEC = icolumnaAuxVEC;
                                                VEC01 = new float[ifilaAVEC, icolumnaAVEC];
                                                if (SiMatrizA == true)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                                    Console.WriteLine(" VECTOR A");
                                                    Console.WriteLine(" Codigo: " + numerocodigoAuxVEC + "  Con filas: " + ifilaAVEC + "  Con Columnas: " + icolumnaAVEC);

                                                    for (int i = 0; i < ifilaAVEC; i++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int j = 0; j < icolumnaAVEC; j++)
                                                        {
                                                            VEC01[i, j] = VECAux[i, j];
                                                            Console.Write(VEC01[i, j] + "   ");
                                                        }
                                                    }
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("\n");
                                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                                }

                                                //MATRIZ B
                                                if (SiMatrizA == true)
                                                {
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        do
                                                        {
                                                            volvervolver = false;
                                                            Console.WriteLine(" Escriba el codigo del VECTOR B que desea sumar");
                                                            string numerosho = Console.ReadLine();

                                                            int cantidad = numerosho.Length;
                                                            if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                            {
                                                                volvervolver = false;
                                                                numerocodigoAuxVEC = Convert.ToInt32(numerosho); // convierte a int
                                                            }
                                                            else
                                                            {
                                                                volvervolver = true;
                                                            }
                                                        } while (volvervolver != false);

                                                        if (BuscarVector(numerocodigoAuxVEC) != 0)
                                                        {
                                                            SiMatrizB = false;
                                                            bool volvers = false;

                                                            do
                                                            {
                                                                volvervolver = false;

                                                                Console.WriteLine("¿Quiere intentar otro codigo?");
                                                                Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                                opcion = Console.ReadLine();

                                                                switch (opcion)
                                                                {
                                                                    case "0":
                                                                        volvervolver = false;
                                                                        volvers = false;
                                                                        break;
                                                                    case "1":
                                                                        volvervolver = false;
                                                                        volvers = true;
                                                                        break;
                                                                    default:
                                                                        Console.WriteLine(" Opcion invalida");
                                                                        volvervolver = true;
                                                                        break;

                                                                }

                                                            } while (volvervolver != false);

                                                            if (volvers == false)
                                                            {
                                                                volvervolver = true;
                                                            }
                                                            else
                                                            {
                                                                volvervolver = false;
                                                            }

                                                        }
                                                        else
                                                        {
                                                            SiMatrizB = true;
                                                        }
                                                    } while (volvervolver != false);
                                                    ifilaBVEC = ifilaAuxVEC;
                                                    icolumnaBVEC = icolumnaAuxVEC;
                                                    VEC02 = new float[ifilaBVEC, icolumnaBVEC];
                                                    if (SiMatrizB == true)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                                        Console.WriteLine(" VECTOR B");
                                                        Console.WriteLine(" Codigo: " + numerocodigoAuxVEC + "  Con filas: " + ifilaBVEC + "  Con Columnas: " + icolumnaBVEC);

                                                        for (int i = 0; i < ifilaBVEC; i++)
                                                        {
                                                            Console.Write("\n");
                                                            for (int j = 0; j < icolumnaBVEC; j++)
                                                            {
                                                                VEC02[i, j] = VECAux[i, j];
                                                                Console.Write(VEC02[i, j] + "   ");
                                                            }
                                                        }
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        Console.WriteLine("\n");
                                                        Console.WriteLine("   -------------------------------------------------------------------    ");
                                                    }
                                                }

                                                if (VC.Igualdad(ifilaAVEC, ifilaBVEC) == 0 && VC.Igualdad(icolumnaAVEC, icolumnaBVEC) == 0 && SiMatrizA == true && SiMatrizB == true)
                                                {
                                                    volvervolver = false;

                                                    VEC03 = new float[ifilaAVEC, icolumnaAVEC];

                                                    for (int iA = 0; iA < ifilaAVEC; iA++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int jA = 0; jA < icolumnaAVEC; jA++)
                                                        {

                                                            float MatriciosaA = VEC01[iA, jA];
                                                            float MatricionaB = VEC02[iA, jA];

                                                            VEC03[iA, jA] = OC.Sumar(MatriciosaA, MatricionaB);


                                                        }

                                                    }


                                                    AgregarVectorResultado(ifilaAVEC, icolumnaAVEC);
                                                    ImprimirVectorEspecifica(numerocodigoAuxVEC);

                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                    Console.WriteLine("Warning: El tamaño del valor de las matrices no permite la operacion o no fue encontrada");
                                                    Console.ReadLine();

                                                }

                                                volvervolver = false;
                                                break;
                                            }
                                        case "1":
                                            {
                                                bool SiMatrizA = false;
                                                bool SiMatrizB = false;
                                                //ESCALAR
                                                do
                                                {
                                                    volver = false;
                                                    Console.WriteLine(" Escriba el numero a sumar");
                                                    string numeromatriz = Console.ReadLine();
                                                    int cantidad = numeromatriz.Length;
                                                    if (VC.Contador(cantidad, numeromatriz) == 0)
                                                    {
                                                        volver = false;
                                                        float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                                                        inumeromatriz = (float)Math.Round(inumeromatriz, 2);
                                                        escalarAVEC = inumeromatriz;
                                                        SiMatrizA = true;
                                                    }
                                                    else
                                                    {
                                                        SiMatrizA = false;
                                                        volver = true;
                                                    }
                                                } while (volver != false);

                                                //MATRIZ B
                                                if (SiMatrizA == true)
                                                {
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        do
                                                        {
                                                            volvervolver = false;
                                                            Console.WriteLine(" Escriba el codigo del VECTOR B que desea sumar");
                                                            string numerosho = Console.ReadLine();

                                                            int cantidad = numerosho.Length;
                                                            if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                            {
                                                                volvervolver = false;
                                                                numerocodigoAuxVEC = Convert.ToInt32(numerosho); // convierte a int
                                                            }
                                                            else
                                                            {
                                                                volvervolver = true;
                                                            }
                                                        } while (volvervolver != false);

                                                        if (BuscarVector(numerocodigoAuxVEC) != 0)
                                                        {
                                                            SiMatrizB = false;
                                                            bool volvers = false;

                                                            do
                                                            {
                                                                volvervolver = false;

                                                                Console.WriteLine("¿Quiere intentar otro codigo?");
                                                                Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                                opcion = Console.ReadLine();

                                                                switch (opcion)
                                                                {
                                                                    case "0":
                                                                        volvervolver = false;
                                                                        volvers = false;
                                                                        break;
                                                                    case "1":
                                                                        volvervolver = false;
                                                                        volvers = true;
                                                                        break;
                                                                    default:
                                                                        Console.WriteLine(" Opcion invalida");
                                                                        volvervolver = true;
                                                                        break;

                                                                }

                                                            } while (volvervolver != false);

                                                            if (volvers == false)
                                                            {
                                                                volvervolver = true;
                                                            }
                                                            else
                                                            {
                                                                volvervolver = false;
                                                            }

                                                        }
                                                        else
                                                        {
                                                            SiMatrizB = true;
                                                        }
                                                    } while (volvervolver != false);
                                                    ifilaBVEC = ifilaAuxVEC;
                                                    icolumnaBVEC = icolumnaAuxVEC;
                                                    VEC02 = new float[ifilaBVEC, icolumnaBVEC];
                                                    if (SiMatrizB == true)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                                        Console.WriteLine(" VECTOR B");
                                                        Console.WriteLine(" Codigo: " + numerocodigoAuxVEC + "  Con filas: " + ifilaBVEC + "  Con Columnas: " + icolumnaBVEC);

                                                        for (int i = 0; i < ifilaBVEC; i++)
                                                        {
                                                            Console.Write("\n");
                                                            for (int j = 0; j < icolumnaBVEC; j++)
                                                            {
                                                                VEC02[i, j] = VECAux[i, j];
                                                                Console.Write(VEC02[i, j] + "   ");
                                                            }
                                                        }
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        Console.WriteLine("\n");
                                                        Console.WriteLine("   -------------------------------------------------------------------    ");
                                                    }
                                                }



                                                if (SiMatrizA == true && SiMatrizB == true)
                                                {
                                                    volvervolver = false;

                                                    VEC03 = new float[ifilaBVEC, icolumnaBVEC];

                                                    for (int iA = 0; iA < ifilaBVEC; iA++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int jA = 0; jA < icolumnaBVEC; jA++)
                                                        {
                                                            float MatricionaB = VEC02[iA, jA];

                                                            VEC03[iA, jA] = OC.Sumar(escalarAVEC, MatricionaB);


                                                        }

                                                    }


                                                    AgregarVectorResultado(ifilaBVEC, icolumnaBVEC);
                                                    ImprimirVectorEspecifica(numerocodigoAuxVEC);

                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                    Console.WriteLine("Warning: El tamaño del valor de las matrices no permite la operacion o no fue encontrada");
                                                    Console.ReadLine();

                                                }

                                                volvervolver = false;
                                                break;
                                            }
                                        case "2":
                                            {
                                                bool SiMatrizA = false;
                                                bool SiMatrizB = false;
                                                //MATRIZ A
                                                do
                                                {
                                                    volvervolver = false;
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        Console.WriteLine(" Escriba el codigo del VECTOR A que desea sumar");
                                                        string numerosho = Console.ReadLine();

                                                        int cantidad = numerosho.Length;
                                                        if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                        {
                                                            volvervolver = false;
                                                            numerocodigoAuxVEC = Convert.ToInt32(numerosho); // convierte a int
                                                        }
                                                        else
                                                        {
                                                            volvervolver = true;
                                                        }
                                                    } while (volvervolver != false);

                                                    if (BuscarVector(numerocodigoAuxVEC) != 0)
                                                    {
                                                        SiMatrizA = false;
                                                        bool volvers = false;

                                                        do
                                                        {
                                                            volvervolver = false;

                                                            Console.WriteLine("¿Quiere intentar otro codigo?");
                                                            Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                            opcion = Console.ReadLine();

                                                            switch (opcion)
                                                            {
                                                                case "0":
                                                                    volvervolver = false;
                                                                    volvers = false;
                                                                    break;
                                                                case "1":
                                                                    volvervolver = false;
                                                                    volvers = true;
                                                                    SiMatrizA = false;
                                                                    break;
                                                                default:
                                                                    Console.WriteLine(" Opcion invalida");
                                                                    volvervolver = true;
                                                                    break;

                                                            }

                                                        } while (volvervolver != false);

                                                        if (volvers == false)
                                                        {
                                                            volvervolver = true;
                                                        }
                                                        else
                                                        {
                                                            volvervolver = false;
                                                        }

                                                    }
                                                    else
                                                    {
                                                        SiMatrizA = true;
                                                    }
                                                } while (volvervolver != false);
                                                ifilaAVEC = ifilaAuxVEC;
                                                icolumnaAVEC = icolumnaAuxVEC;
                                                VEC01 = new float[ifilaAVEC, icolumnaAVEC];
                                                if (SiMatrizA == true)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                                    Console.WriteLine(" VECTOR A");
                                                    Console.WriteLine(" Codigo: " + numerocodigoAuxVEC + "  Con filas: " + ifilaAVEC + "  Con Columnas: " + icolumnaAVEC);

                                                    for (int i = 0; i < ifilaAVEC; i++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int j = 0; j < icolumnaAVEC; j++)
                                                        {
                                                            VEC01[i, j] = VECAux[i, j];
                                                            Console.Write(VEC01[i, j] + "   ");
                                                        }
                                                    }
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("\n");
                                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                                }

                                                //ESCALAR B
                                                if (SiMatrizA == true)
                                                {
                                                    do
                                                    {
                                                        volver = false;
                                                        Console.WriteLine(" Escriba el numero a sumar");
                                                        string numeromatriz = Console.ReadLine();
                                                        int cantidad = numeromatriz.Length;
                                                        if (VC.Contador(cantidad, numeromatriz) == 0)
                                                        {
                                                            volver = false;
                                                            float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                                                            inumeromatriz = (float)Math.Round(inumeromatriz, 2);
                                                            escalarBVEC = inumeromatriz;
                                                            SiMatrizB = true;
                                                        }
                                                        else
                                                        {
                                                            SiMatrizB = false;
                                                            volver = true;
                                                        }
                                                    } while (volver != false);
                                                }

                                                if (SiMatrizA == true && SiMatrizB == true)
                                                {
                                                    volvervolver = false;

                                                    VEC03 = new float[ifilaAVEC, icolumnaAVEC];

                                                    for (int iA = 0; iA < ifilaAVEC; iA++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int jA = 0; jA < icolumnaAVEC; jA++)
                                                        {
                                                            float MatriciosaA = VEC01[iA, jA];
                                                            VEC03[iA, jA] = OC.Sumar(MatriciosaA, escalarBVEC);

                                                        }

                                                    }


                                                    AgregarVectorResultado(ifilaAVEC, icolumnaAVEC);
                                                    ImprimirVectorEspecifica(numerocodigoAuxVEC);

                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                    Console.WriteLine("Warning: El tamaño del valor de las matrices no permite la operacion o no fue encontrada");
                                                    Console.ReadLine();

                                                }

                                                volvervolver = false;
                                                break;
                                            }
                                        default:
                                            Console.WriteLine(" Opcion invalida");
                                            volvervolver = true;
                                            break;
                                    }

                                } while (volvervolver != false);

                            }
                            volvervolver = true;
                            break;
                        }
                    case "5":
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                            Console.WriteLine("║                            RESTAR VECTOR                              ║ ");
                            Console.WriteLine("║                                                                       ║ ");

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("║              SIGA POR FAVOR LAS INSTRUCCIONES SIGUIENTES              ║ ");
                            Console.WriteLine("║                                                                       ║ ");
                            Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");


                            if (inicioVEC == null)
                            {
                                volvervolver = true;
                                Console.WriteLine("Warning: Aun no se agregan datos suficientes para la operacion");
                                Console.ReadLine();
                            }
                            else
                            {
                                do
                                {

                                    Console.WriteLine(" ");
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine("¿COMO REALIZARAS LA RESTA? 0. Vector-Vector | 1. Escalar-Vector | 2. Vector-Escalar");
                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("¿Que opcion elige?                                                        ");
                                    opcion = Console.ReadLine();
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                    Console.ForegroundColor = ConsoleColor.White;

                                    switch (opcion)
                                    {
                                        case "0":
                                            {
                                                bool SiMatrizA = false;
                                                bool SiMatrizB = false;
                                                //MATRIZ A
                                                do
                                                {
                                                    volvervolver = false;
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        Console.WriteLine(" Escriba el codigo del VECTOR A que desea RESTAR");
                                                        string numerosho = Console.ReadLine();

                                                        int cantidad = numerosho.Length;
                                                        if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                        {
                                                            volvervolver = false;
                                                            numerocodigoAuxVEC = Convert.ToInt32(numerosho); // convierte a int
                                                        }
                                                        else
                                                        {
                                                            volvervolver = true;
                                                        }
                                                    } while (volvervolver != false);

                                                    if (BuscarVector(numerocodigoAuxVEC) != 0)
                                                    {
                                                        SiMatrizA = false;
                                                        bool volvers = false;

                                                        do
                                                        {
                                                            volvervolver = false;

                                                            Console.WriteLine("¿Quiere intentar otro codigo?");
                                                            Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                            opcion = Console.ReadLine();

                                                            switch (opcion)
                                                            {
                                                                case "0":
                                                                    volvervolver = false;
                                                                    volvers = false;
                                                                    break;
                                                                case "1":
                                                                    volvervolver = false;
                                                                    volvers = true;
                                                                    SiMatrizA = false;
                                                                    break;
                                                                default:
                                                                    Console.WriteLine(" Opcion invalida");
                                                                    volvervolver = true;
                                                                    break;

                                                            }

                                                        } while (volvervolver != false);

                                                        if (volvers == false)
                                                        {
                                                            volvervolver = true;
                                                        }
                                                        else
                                                        {
                                                            volvervolver = false;
                                                        }

                                                    }
                                                    else
                                                    {
                                                        SiMatrizA = true;
                                                    }
                                                } while (volvervolver != false);

                                                ifilaAVEC = ifilaAuxVEC;
                                                icolumnaAVEC = icolumnaAuxVEC;
                                                VEC01 = new float[ifilaAVEC, icolumnaAVEC];
                                                if (SiMatrizA == true)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                                    Console.WriteLine(" VECTOR A");
                                                    Console.WriteLine(" Codigo: " + numerocodigoAuxVEC + "  Con filas: " + ifilaAVEC + "  Con Columnas: " + icolumnaAVEC);

                                                    for (int i = 0; i < ifilaAVEC; i++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int j = 0; j < icolumnaAVEC; j++)
                                                        {
                                                            VEC01[i, j] = VECAux[i, j];
                                                            Console.Write(VEC01[i, j] + "   ");
                                                        }
                                                    }
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("\n");
                                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                                }

                                                //MATRIZ B
                                                if (SiMatrizA == true)
                                                {
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        do
                                                        {
                                                            volvervolver = false;
                                                            Console.WriteLine(" Escriba el codigo del VECTOR B que desea RESTAR");
                                                            string numerosho = Console.ReadLine();

                                                            int cantidad = numerosho.Length;
                                                            if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                            {
                                                                volvervolver = false;
                                                                numerocodigoAuxVEC = Convert.ToInt32(numerosho); // convierte a int
                                                            }
                                                            else
                                                            {
                                                                volvervolver = true;
                                                            }
                                                        } while (volvervolver != false);

                                                        if (BuscarVector(numerocodigoAuxVEC) != 0)
                                                        {
                                                            SiMatrizB = false;
                                                            bool volvers = false;

                                                            do
                                                            {
                                                                volvervolver = false;

                                                                Console.WriteLine("¿Quiere intentar otro codigo?");
                                                                Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                                opcion = Console.ReadLine();

                                                                switch (opcion)
                                                                {
                                                                    case "0":
                                                                        volvervolver = false;
                                                                        volvers = false;
                                                                        break;
                                                                    case "1":
                                                                        volvervolver = false;
                                                                        volvers = true;
                                                                        break;
                                                                    default:
                                                                        Console.WriteLine(" Opcion invalida");
                                                                        volvervolver = true;
                                                                        break;

                                                                }

                                                            } while (volvervolver != false);

                                                            if (volvers == false)
                                                            {
                                                                volvervolver = true;
                                                            }
                                                            else
                                                            {
                                                                volvervolver = false;
                                                            }

                                                        }
                                                        else
                                                        {
                                                            SiMatrizB = true;
                                                        }
                                                    } while (volvervolver != false);
                                                    ifilaBVEC = ifilaAuxVEC;
                                                    icolumnaBVEC = icolumnaAuxVEC;
                                                    VEC02 = new float[ifilaBVEC, icolumnaBVEC];
                                                    if (SiMatrizB == true)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                                        Console.WriteLine(" VECTOR B");
                                                        Console.WriteLine(" Codigo: " + numerocodigoAuxVEC + "  Con filas: " + ifilaBVEC + "  Con Columnas: " + icolumnaBVEC);

                                                        for (int i = 0; i < ifilaBVEC; i++)
                                                        {
                                                            Console.Write("\n");
                                                            for (int j = 0; j < icolumnaBVEC; j++)
                                                            {
                                                                VEC02[i, j] = VECAux[i, j];
                                                                Console.Write(VEC02[i, j] + "   ");
                                                            }
                                                        }
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        Console.WriteLine("\n");
                                                        Console.WriteLine("   -------------------------------------------------------------------    ");
                                                    }
                                                }

                                                if (VC.Igualdad(ifilaAVEC, ifilaBVEC) == 0 && VC.Igualdad(icolumnaAVEC, icolumnaBVEC) == 0 && SiMatrizA == true && SiMatrizB == true)
                                                {
                                                    volvervolver = false;

                                                    VEC03 = new float[ifilaAVEC, icolumnaAVEC];

                                                    for (int iA = 0; iA < ifilaAVEC; iA++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int jA = 0; jA < icolumnaAVEC; jA++)
                                                        {

                                                            float MatriciosaA = VEC01[iA, jA];
                                                            float MatricionaB = VEC02[iA, jA];

                                                            VEC03[iA, jA] = OC.Restar(MatriciosaA, MatricionaB);


                                                        }

                                                    }


                                                    AgregarVectorResultado(ifilaAVEC, icolumnaAVEC);
                                                    ImprimirVectorEspecifica(numerocodigoAuxVEC);
                                                    break;

                                                }
                                                else
                                                {
                                                    Console.WriteLine("Warning: El tamaño del valor del VECTOR no permite la operacion o no fue encontrada");
                                                    Console.ReadLine();
                                                }
                                                volvervolver = false;
                                                break;
                                            }
                                        case "1":
                                            {
                                                bool SiMatrizA = false;
                                                bool SiMatrizB = false;
                                                //ESCALAR
                                                do
                                                {
                                                    volver = false;
                                                    Console.WriteLine(" Escriba el numero a restar");
                                                    string numeromatriz = Console.ReadLine();
                                                    int cantidad = numeromatriz.Length;
                                                    if (VC.Contador(cantidad, numeromatriz) == 0)
                                                    {
                                                        volver = false;
                                                        float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                                                        inumeromatriz = (float)Math.Round(inumeromatriz, 2);
                                                        escalarAVEC = inumeromatriz;
                                                        SiMatrizA = true;
                                                    }
                                                    else
                                                    {
                                                        SiMatrizA = false;
                                                        volver = true;
                                                    }
                                                } while (volver != false);

                                                //MATRIZ B
                                                if (SiMatrizA == true)
                                                {
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        do
                                                        {
                                                            volvervolver = false;
                                                            Console.WriteLine(" Escriba el codigo del VECTOR B que desea restar");
                                                            string numerosho = Console.ReadLine();

                                                            int cantidad = numerosho.Length;
                                                            if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                            {
                                                                volvervolver = false;
                                                                numerocodigoAuxVEC = Convert.ToInt32(numerosho); // convierte a int
                                                            }
                                                            else
                                                            {
                                                                volvervolver = true;
                                                            }
                                                        } while (volvervolver != false);

                                                        if (BuscarVector(numerocodigoAuxVEC) != 0)
                                                        {
                                                            SiMatrizB = false;
                                                            bool volvers = false;

                                                            do
                                                            {
                                                                volvervolver = false;

                                                                Console.WriteLine("¿Quiere intentar otro codigo?");
                                                                Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                                opcion = Console.ReadLine();

                                                                switch (opcion)
                                                                {
                                                                    case "0":
                                                                        volvervolver = false;
                                                                        volvers = false;
                                                                        break;
                                                                    case "1":
                                                                        volvervolver = false;
                                                                        volvers = true;
                                                                        break;
                                                                    default:
                                                                        Console.WriteLine(" Opcion invalida");
                                                                        volvervolver = true;
                                                                        break;

                                                                }

                                                            } while (volvervolver != false);

                                                            if (volvers == false)
                                                            {
                                                                volvervolver = true;
                                                            }
                                                            else
                                                            {
                                                                volvervolver = false;
                                                            }

                                                        }
                                                        else
                                                        {
                                                            SiMatrizB = true;
                                                        }
                                                    } while (volvervolver != false);
                                                    ifilaBVEC = ifilaAuxVEC;
                                                    icolumnaBVEC = icolumnaAuxVEC;
                                                    VEC02 = new float[ifilaBVEC, icolumnaBVEC];
                                                    if (SiMatrizB == true)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                                        Console.WriteLine(" VECTOR B");
                                                        Console.WriteLine(" Codigo: " + numerocodigoAuxVEC + "  Con filas: " + ifilaBVEC + "  Con Columnas: " + icolumnaBVEC);

                                                        for (int i = 0; i < ifilaBVEC; i++)
                                                        {
                                                            Console.Write("\n");
                                                            for (int j = 0; j < icolumnaBVEC; j++)
                                                            {
                                                                VEC02[i, j] = VECAux[i, j];
                                                                Console.Write(VEC02[i, j] + "   ");
                                                            }
                                                        }
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        Console.WriteLine("\n");
                                                        Console.WriteLine("   -------------------------------------------------------------------    ");
                                                    }
                                                }



                                                if (SiMatrizA == true && SiMatrizB == true)
                                                {
                                                    volvervolver = false;

                                                    VEC03 = new float[ifilaBVEC, icolumnaBVEC];

                                                    for (int iA = 0; iA < ifilaBVEC; iA++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int jA = 0; jA < icolumnaBVEC; jA++)
                                                        {
                                                            float MatricionaB = VEC02[iA, jA];

                                                            VEC03[iA, jA] = OC.Restar(escalarAVEC, MatricionaB);


                                                        }

                                                    }


                                                    AgregarVectorResultado(ifilaBVEC, icolumnaBVEC);
                                                    ImprimirVectorEspecifica(numerocodigoAuxVEC);

                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                    Console.WriteLine("Warning: El tamaño del valor del VECTOR no permite la operacion o no fue encontrada");
                                                    Console.ReadLine();

                                                }

                                                volvervolver = false;
                                                break;
                                            }
                                        case "2":
                                            {
                                                bool SiMatrizA = false;
                                                bool SiMatrizB = false;
                                                //MATRIZ A
                                                do
                                                {
                                                    volvervolver = false;
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        Console.WriteLine(" Escriba el codigo del VECTOR A que desea restar");
                                                        string numerosho = Console.ReadLine();

                                                        int cantidad = numerosho.Length;
                                                        if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                        {
                                                            volvervolver = false;
                                                            numerocodigoAuxVEC = Convert.ToInt32(numerosho); // convierte a int
                                                        }
                                                        else
                                                        {
                                                            volvervolver = true;
                                                        }
                                                    } while (volvervolver != false);

                                                    if (BuscarVector(numerocodigoAuxVEC) != 0)
                                                    {
                                                        SiMatrizA = false;
                                                        bool volvers = false;

                                                        do
                                                        {
                                                            volvervolver = false;

                                                            Console.WriteLine("¿Quiere intentar otro codigo?");
                                                            Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                            opcion = Console.ReadLine();

                                                            switch (opcion)
                                                            {
                                                                case "0":
                                                                    volvervolver = false;
                                                                    volvers = false;
                                                                    break;
                                                                case "1":
                                                                    volvervolver = false;
                                                                    volvers = true;
                                                                    SiMatrizA = false;
                                                                    break;
                                                                default:
                                                                    Console.WriteLine(" Opcion invalida");
                                                                    volvervolver = true;
                                                                    break;

                                                            }

                                                        } while (volvervolver != false);

                                                        if (volvers == false)
                                                        {
                                                            volvervolver = true;
                                                        }
                                                        else
                                                        {
                                                            volvervolver = false;
                                                        }

                                                    }
                                                    else
                                                    {
                                                        SiMatrizA = true;
                                                    }
                                                } while (volvervolver != false);
                                                ifilaAVEC = ifilaAuxVEC;
                                                icolumnaAVEC = icolumnaAuxVEC;
                                                VEC01 = new float[ifilaAVEC, icolumnaAVEC];
                                                if (SiMatrizA == true)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                                    Console.WriteLine(" VECTOR A");
                                                    Console.WriteLine(" Codigo: " + numerocodigoAuxVEC + "  Con filas: " + ifilaAVEC + "  Con Columnas: " + icolumnaAVEC);

                                                    for (int i = 0; i < ifilaAVEC; i++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int j = 0; j < icolumnaAVEC; j++)
                                                        {
                                                            VEC01[i, j] = VECAux[i, j];
                                                            Console.Write(VEC01[i, j] + "   ");
                                                        }
                                                    }
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("\n");
                                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                                }

                                                //ESCALAR B
                                                if (SiMatrizA == true)
                                                {
                                                    do
                                                    {
                                                        volver = false;
                                                        Console.WriteLine(" Escriba el numero a restar");
                                                        string numeromatriz = Console.ReadLine();
                                                        int cantidad = numeromatriz.Length;
                                                        if (VC.Contador(cantidad, numeromatriz) == 0)
                                                        {
                                                            volver = false;
                                                            float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                                                            inumeromatriz = (float)Math.Round(inumeromatriz, 2);
                                                            escalarBVEC = inumeromatriz;
                                                            SiMatrizB = true;
                                                        }
                                                        else
                                                        {
                                                            SiMatrizB = false;
                                                            volver = true;
                                                        }
                                                    } while (volver != false);
                                                }

                                                if (SiMatrizA == true && SiMatrizB == true)
                                                {
                                                    volvervolver = false;

                                                    VEC03 = new float[ifilaAVEC, icolumnaAVEC];

                                                    for (int iA = 0; iA < ifilaAVEC; iA++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int jA = 0; jA < icolumnaAVEC; jA++)
                                                        {
                                                            float MatriciosaA = VEC01[iA, jA];
                                                            VEC03[iA, jA] = OC.Restar(MatriciosaA, escalarBVEC);

                                                        }

                                                    }


                                                    AgregarVectorResultado(ifilaAVEC, icolumnaAVEC);
                                                    ImprimirVectorEspecifica(numerocodigoAuxVEC);

                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                    Console.WriteLine("Warning: El tamaño del valor del VECOTR no permite la operacion o no fue encontrada");
                                                    Console.ReadLine();

                                                }

                                                volvervolver = false;
                                                break;
                                            }
                                        default:
                                            Console.WriteLine(" Opcion invalida");
                                            volvervolver = true;
                                            break;
                                    }

                                } while (volvervolver != false);


                            }

                            volvervolver = true;
                            break;
                        }
                    case "6":
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                            Console.WriteLine("║                         MULTIPLICAR VECTOR                            ║ ");
                            Console.WriteLine("║                                                                       ║ ");

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("║              SIGA POR FAVOR LAS INSTRUCCIONES SIGUIENTES              ║ ");
                            Console.WriteLine("║                                                                       ║ ");
                            Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");


                            if (inicioVEC == null)
                            {
                                volvervolver = true;
                                Console.WriteLine("Warning: Aun no se agregan datos suficientes para la operacion");
                                Console.ReadLine();
                            }
                            else
                            {
                                do
                                {

                                    Console.WriteLine(" ");
                                    Console.WriteLine("¿COMO REALIZARAS LA MULTIPLICACION? 0. Vector-Vector | 1. Escalar-Vector | 2. Vector-Escalar");
                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("¿Que opcion elige?                                                        ");
                                    opcion = Console.ReadLine();
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                    Console.ForegroundColor = ConsoleColor.White;

                                    switch (opcion)
                                    {
                                        case "0":
                                            {
                                                bool SiMatrizA = false;
                                                bool SiMatrizB = false;
                                                //MATRIZ A
                                                do
                                                {
                                                    volvervolver = false;
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        Console.WriteLine(" Escriba el codigo del VECTOR A que desea realizar MULTIPLICAR");
                                                        string numerosho = Console.ReadLine();

                                                        int cantidad = numerosho.Length;
                                                        if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                        {
                                                            volvervolver = false;
                                                            numerocodigoAuxVEC = Convert.ToInt32(numerosho); // convierte a int
                                                        }
                                                        else
                                                        {
                                                            volvervolver = true;
                                                        }
                                                    } while (volvervolver != false);

                                                    if (BuscarVector(numerocodigoAuxVEC) != 0)
                                                    {
                                                        SiMatrizA = false;
                                                        bool volvers = false;

                                                        do
                                                        {
                                                            volvervolver = false;

                                                            Console.WriteLine("¿Quiere intentar otro codigo?");
                                                            Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                            opcion = Console.ReadLine();

                                                            switch (opcion)
                                                            {
                                                                case "0":
                                                                    volvervolver = false;
                                                                    volvers = false;
                                                                    break;
                                                                case "1":
                                                                    volvervolver = false;
                                                                    volvers = true;
                                                                    SiMatrizA = false;
                                                                    break;
                                                                default:
                                                                    Console.WriteLine(" Opcion invalida");
                                                                    volvervolver = true;
                                                                    break;

                                                            }

                                                        } while (volvervolver != false);

                                                        if (volvers == false)
                                                        {
                                                            volvervolver = true;
                                                        }
                                                        else
                                                        {
                                                            volvervolver = false;
                                                        }

                                                    }
                                                    else
                                                    {
                                                        SiMatrizA = true;
                                                    }
                                                } while (volvervolver != false);

                                                ifilaAVEC = ifilaAuxVEC;
                                                icolumnaAVEC = icolumnaAuxVEC;
                                                VEC01 = new float[ifilaAVEC, icolumnaAVEC];
                                                if (SiMatrizA == true)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                                    Console.WriteLine(" VECTOR A");
                                                    Console.WriteLine(" Codigo: " + numerocodigoAuxVEC + "  Con filas: " + ifilaAVEC + "  Con Columnas: " + icolumnaAVEC);

                                                    for (int i = 0; i < ifilaAVEC; i++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int j = 0; j < icolumnaAVEC; j++)
                                                        {
                                                            VEC01[i, j] = VECAux[i, j];
                                                            Console.Write(VEC01[i, j] + "   ");
                                                        }
                                                    }
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("\n");
                                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                                }

                                                //MATRIZ B
                                                if (SiMatrizA == true)
                                                {
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        do
                                                        {
                                                            volvervolver = false;
                                                            Console.WriteLine(" Escriba el codigo del VECTOR B que desea realizar MULTIPLICAR");
                                                            string numerosho = Console.ReadLine();

                                                            int cantidad = numerosho.Length;
                                                            if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                            {
                                                                volvervolver = false;
                                                                numerocodigoAuxVEC = Convert.ToInt32(numerosho); // convierte a int
                                                            }
                                                            else
                                                            {
                                                                volvervolver = true;
                                                            }
                                                        } while (volvervolver != false);

                                                        if (BuscarVector(numerocodigoAuxVEC) != 0)
                                                        {
                                                            SiMatrizB = false;
                                                            bool volvers = false;

                                                            do
                                                            {
                                                                volvervolver = false;

                                                                Console.WriteLine("¿Quiere intentar otro codigo?");
                                                                Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                                opcion = Console.ReadLine();

                                                                switch (opcion)
                                                                {
                                                                    case "0":
                                                                        volvervolver = false;
                                                                        volvers = false;
                                                                        break;
                                                                    case "1":
                                                                        volvervolver = false;
                                                                        volvers = true;
                                                                        break;
                                                                    default:
                                                                        Console.WriteLine(" Opcion invalida");
                                                                        volvervolver = true;
                                                                        break;

                                                                }

                                                            } while (volvervolver != false);

                                                            if (volvers == false)
                                                            {
                                                                volvervolver = true;
                                                            }
                                                            else
                                                            {
                                                                volvervolver = false;
                                                            }

                                                        }
                                                        else
                                                        {
                                                            SiMatrizB = true;
                                                        }
                                                    } while (volvervolver != false);
                                                    ifilaBVEC = ifilaAuxVEC;
                                                    icolumnaBVEC = icolumnaAuxVEC;
                                                    VEC02 = new float[ifilaBVEC, icolumnaBVEC];
                                                    if (SiMatrizB == true)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                                        Console.WriteLine(" VECTOR B");
                                                        Console.WriteLine(" Codigo: " + numerocodigoAuxVEC + "  Con filas: " + ifilaBVEC + "  Con Columnas: " + icolumnaBVEC);

                                                        for (int i = 0; i < ifilaBVEC; i++)
                                                        {
                                                            Console.Write("\n");
                                                            for (int j = 0; j < icolumnaBVEC; j++)
                                                            {
                                                                VEC02[i, j] = VECAux[i, j];
                                                                Console.Write(VEC02[i, j] + "   ");
                                                            }
                                                        }
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        Console.WriteLine("\n");
                                                        Console.WriteLine("   -------------------------------------------------------------------    ");
                                                    }
                                                }

                                                if (VC.Igualdad(icolumnaAVEC, icolumnaBVEC) == 0 && SiMatrizA == true && SiMatrizB == true)
                                                {
                                                    volvervolver = false;

                                                    VEC03 = new float[ifilaAVEC, icolumnaBVEC];

                                                    for (int iA = 0; iA < ifilaAVEC; iA++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int jA = 0; jA < icolumnaBVEC; jA++)
                                                        {
                                                            float multiaux = 0;
                                                            multiaux = OC.Multiplicar(VEC01[iA, jA], VEC02[iA, jA]);                                                            
                                                            VEC03[iA, jA] = multiaux;

                                                        }

                                                    }
                                                    AgregarVectorResultado(ifilaAVEC, icolumnaBVEC);
                                                    ImprimirVectorEspecifica(numerocodigoAuxVEC);

                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                    Console.WriteLine("Warning: El tamaño del valor del VECTOR no permite la operacion o no fue encontrada");
                                                    Console.ReadLine();

                                                }

                                                volvervolver = false;
                                                break;
                                            }
                                        case "1":
                                            {
                                                bool SiMatrizA = false;
                                                bool SiMatrizB = false;
                                                //ESCALAR
                                                do
                                                {
                                                    volver = false;
                                                    Console.WriteLine(" Escriba el numero a multiplicar");
                                                    string numeromatriz = Console.ReadLine();
                                                    int cantidad = numeromatriz.Length;
                                                    if (VC.Contador(cantidad, numeromatriz) == 0)
                                                    {
                                                        volver = false;
                                                        float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                                                        inumeromatriz = (float)Math.Round(inumeromatriz, 2);
                                                        escalarAVEC = inumeromatriz;
                                                        SiMatrizA = true;
                                                    }
                                                    else
                                                    {
                                                        SiMatrizA = false;
                                                        volver = true;
                                                    }
                                                } while (volver != false);

                                                //MATRIZ B
                                                if (SiMatrizA == true)
                                                {
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        do
                                                        {
                                                            volvervolver = false;
                                                            Console.WriteLine(" Escriba el codigo de la VECTOR B que desea multiplicar");
                                                            string numerosho = Console.ReadLine();

                                                            int cantidad = numerosho.Length;
                                                            if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                            {
                                                                volvervolver = false;
                                                                numerocodigoAuxVEC = Convert.ToInt32(numerosho); // convierte a int
                                                            }
                                                            else
                                                            {
                                                                volvervolver = true;
                                                            }
                                                        } while (volvervolver != false);

                                                        if (BuscarVector(numerocodigoAuxVEC) != 0)
                                                        {
                                                            SiMatrizB = false;
                                                            bool volvers = false;

                                                            do
                                                            {
                                                                volvervolver = false;

                                                                Console.WriteLine("¿Quiere intentar otro codigo?");
                                                                Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                                opcion = Console.ReadLine();

                                                                switch (opcion)
                                                                {
                                                                    case "0":
                                                                        volvervolver = false;
                                                                        volvers = false;
                                                                        break;
                                                                    case "1":
                                                                        volvervolver = false;
                                                                        volvers = true;
                                                                        break;
                                                                    default:
                                                                        Console.WriteLine(" Opcion invalida");
                                                                        volvervolver = true;
                                                                        break;

                                                                }

                                                            } while (volvervolver != false);

                                                            if (volvers == false)
                                                            {
                                                                volvervolver = true;
                                                            }
                                                            else
                                                            {
                                                                volvervolver = false;
                                                            }

                                                        }
                                                        else
                                                        {
                                                            SiMatrizB = true;
                                                        }
                                                    } while (volvervolver != false);
                                                    ifilaBVEC = ifilaAuxVEC;
                                                    icolumnaBVEC = icolumnaAuxVEC;
                                                    VEC02 = new float[ifilaBVEC, icolumnaBVEC];
                                                    if (SiMatrizB == true)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                                        Console.WriteLine(" VECTOR B");
                                                        Console.WriteLine(" Codigo: " + numerocodigoAuxVEC + "  Con filas: " + ifilaBVEC + "  Con Columnas: " + icolumnaBVEC);

                                                        for (int i = 0; i < ifilaBVEC; i++)
                                                        {
                                                            Console.Write("\n");
                                                            for (int j = 0; j < icolumnaBVEC; j++)
                                                            {
                                                                VEC02[i, j] = VECAux[i, j];
                                                                Console.Write(VEC02[i, j] + "   ");
                                                            }
                                                        }
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        Console.WriteLine("\n");
                                                        Console.WriteLine("   -------------------------------------------------------------------    ");
                                                    }
                                                }

                                                if (SiMatrizA == true && SiMatrizB == true)
                                                {
                                                    volvervolver = false;

                                                    VEC03 = new float[ifilaBVEC, icolumnaBVEC];

                                                    for (int iA = 0; iA < ifilaBVEC; iA++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int jA = 0; jA < icolumnaBVEC; jA++)
                                                        {
                                                            float MatricionaB = VEC02[iA, jA];
                                                            VEC03[iA, jA] = OC.Multiplicar(escalarAVEC, MatricionaB);

                                                        }

                                                    }
                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                    Console.WriteLine("Warning: El tamaño del valor del vector no permite la operacion o no fue encontrada");
                                                    Console.ReadLine();

                                                }

                                                volvervolver = false;
                                                break;
                                            }
                                        case "2":
                                            {
                                                bool SiMatrizA = false;
                                                bool SiMatrizB = false;
                                                //MATRIZ A
                                                do
                                                {
                                                    volvervolver = false;
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        Console.WriteLine(" Escriba el codigo del VECTOR A que desea multiplicar");
                                                        string numerosho = Console.ReadLine();

                                                        int cantidad = numerosho.Length;
                                                        if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                        {
                                                            volvervolver = false;
                                                            numerocodigoAuxVEC = Convert.ToInt32(numerosho); // convierte a int
                                                        }
                                                        else
                                                        {
                                                            volvervolver = true;
                                                        }
                                                    } while (volvervolver != false);

                                                    if (BuscarVector(numerocodigoAuxVEC) != 0)
                                                    {
                                                        SiMatrizA = false;
                                                        bool volvers = false;

                                                        do
                                                        {
                                                            volvervolver = false;

                                                            Console.WriteLine("¿Quiere intentar otro codigo?");
                                                            Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                            opcion = Console.ReadLine();

                                                            switch (opcion)
                                                            {
                                                                case "0":
                                                                    volvervolver = false;
                                                                    volvers = false;
                                                                    break;
                                                                case "1":
                                                                    volvervolver = false;
                                                                    volvers = true;
                                                                    SiMatrizA = false;
                                                                    break;
                                                                default:
                                                                    Console.WriteLine(" Opcion invalida");
                                                                    volvervolver = true;
                                                                    break;

                                                            }

                                                        } while (volvervolver != false);

                                                        if (volvers == false)
                                                        {
                                                            volvervolver = true;
                                                        }
                                                        else
                                                        {
                                                            volvervolver = false;
                                                        }

                                                    }
                                                    else
                                                    {
                                                        SiMatrizA = true;
                                                    }
                                                } while (volvervolver != false);
                                                ifilaAVEC = ifilaAuxVEC;
                                                icolumnaAVEC = icolumnaAuxVEC;
                                                VEC01 = new float[ifilaAVEC, icolumnaAVEC];
                                                if (SiMatrizA == true)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                                    Console.WriteLine(" VECTOR A");
                                                    Console.WriteLine(" Codigo: " + numerocodigoAuxVEC + "  Con filas: " + ifilaAVEC + "  Con Columnas: " + icolumnaAVEC);

                                                    for (int i = 0; i < ifilaAVEC; i++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int j = 0; j < icolumnaAVEC; j++)
                                                        {
                                                            VEC01[i, j] = VECAux[i, j];
                                                            Console.Write(VEC01[i, j] + "   ");
                                                        }
                                                    }
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("\n");
                                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                                }

                                                //ESCALAR B
                                                if (SiMatrizA == true)
                                                {
                                                    do
                                                    {
                                                        volver = false;
                                                        Console.WriteLine(" Escriba el numero a multiplicar");
                                                        string numeromatriz = Console.ReadLine();
                                                        int cantidad = numeromatriz.Length;
                                                        if (VC.Contador(cantidad, numeromatriz) == 0)
                                                        {
                                                            volver = false;
                                                            float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                                                            inumeromatriz = (float)Math.Round(inumeromatriz, 2);
                                                            escalarBVEC = inumeromatriz;
                                                            SiMatrizB = true;
                                                        }
                                                        else
                                                        {
                                                            SiMatrizB = false;
                                                            volver = true;
                                                        }
                                                    } while (volver != false);
                                                }

                                                if (SiMatrizA == true && SiMatrizB == true)
                                                {
                                                    volvervolver = false;

                                                    VEC03 = new float[ifilaAVEC, icolumnaAVEC];

                                                    for (int iA = 0; iA < ifilaAVEC; iA++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int jA = 0; jA < icolumnaAVEC; jA++)
                                                        {
                                                            float MatriciosaA = VEC01[iA, jA];
                                                            VEC03[iA, jA] = OC.Multiplicar(MatriciosaA, escalarBVEC);

                                                        }

                                                    }


                                                    AgregarVectorResultado(ifilaAVEC, icolumnaAVEC);
                                                    ImprimirVectorEspecifica(numerocodigoAuxVEC);

                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                    Console.WriteLine("Warning: El tamaño del valor del vector no permite la operacion o no fue encontrada");
                                                    Console.ReadLine();

                                                }

                                                volvervolver = false;
                                                break;
                                            }
                                        default:
                                            Console.WriteLine(" Opcion invalida");
                                            volvervolver = true;
                                            break;
                                    }

                                } while (volvervolver != false);
                            }
                            volvervolver = true;
                            break;
                        }
                    case "7":
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                            Console.WriteLine("║                         NORMALIZACION VECTOR                          ║ ");
                            Console.WriteLine("║                                                                       ║ ");

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("║              SIGA POR FAVOR LAS INSTRUCCIONES SIGUIENTES              ║ ");
                            Console.WriteLine("║                                                                       ║ ");
                            Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");


                            if (inicioVEC == null)
                            {
                                volvervolver = true;
                                Console.WriteLine("Warning: Aun no se agregan datos suficientes para la operacion");
                                Console.ReadLine();
                            }
                            else
                            {
                                bool SiMatrizA = false;
                                bool SiMatrizB = false;
                                //MATRIZ A
                                do
                                {
                                    volvervolver = false;
                                    do
                                    {
                                        volvervolver = false;
                                        Console.WriteLine(" Escriba el codigo del VECTOR A que desea NORMALIZAR");
                                        string numerosho = Console.ReadLine();

                                        int cantidad = numerosho.Length;
                                        if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                        {
                                            volvervolver = false;
                                            numerocodigoAuxVEC = Convert.ToInt32(numerosho); // convierte a int
                                        }
                                        else
                                        {
                                            volvervolver = true;
                                        }
                                    } while (volvervolver != false);

                                    if (BuscarVector(numerocodigoAuxVEC) != 0)
                                    {
                                        SiMatrizA = false;
                                        bool volvers = false;

                                        do
                                        {
                                            volvervolver = false;

                                            Console.WriteLine("¿Quiere intentar otro codigo?");
                                            Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                            opcion = Console.ReadLine();

                                            switch (opcion)
                                            {
                                                case "0":
                                                    volvervolver = false;
                                                    volvers = false;
                                                    break;
                                                case "1":
                                                    volvervolver = false;
                                                    volvers = true;
                                                    SiMatrizA = false;
                                                    break;
                                                default:
                                                    Console.WriteLine(" Opcion invalida");
                                                    volvervolver = true;
                                                    break;

                                            }

                                        } while (volvervolver != false);

                                        if (volvers == false)
                                        {
                                            volvervolver = true;
                                        }
                                        else
                                        {
                                            volvervolver = false;
                                        }

                                    }
                                    else
                                    {
                                        SiMatrizA = true;
                                    }
                                } while (volvervolver != false);

                                ifilaAVEC = ifilaAuxVEC;
                                icolumnaAVEC = icolumnaAuxVEC;
                                VEC01 = new float[ifilaAVEC, icolumnaAVEC];
                                if (SiMatrizA == true)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                    Console.WriteLine(" VECTOR A");
                                    Console.WriteLine(" Codigo: " + numerocodigoAuxVEC + "  Con filas: " + ifilaAVEC + "  Con Columnas: " + icolumnaAVEC);

                                    for (int i = 0; i < ifilaAVEC; i++)
                                    {
                                        Console.Write("\n");
                                        for (int j = 0; j < icolumnaAVEC; j++)
                                        {
                                            VEC01[i, j] = VECAux[i, j];
                                            Console.Write(VEC01[i, j] + "   ");
                                        }
                                    }
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("\n");
                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                }

                                if (SiMatrizA == true)
                                {

                                    volvervolver = false;
                                    VEC03 = new float[ifilaAVEC, icolumnaAVEC];
                                    float sumaaux = 0;
                                    float suma = 0;
                                    float unitario = 0;
                                    float normal = 0;

                                    for (int iA = 0; iA < ifilaAVEC; iA++)
                                    {
                                        Console.Write("\n");
                                        for (int jA = 0; jA < icolumnaAVEC; jA++)
                                        {
                                            sumaaux = OC.Potencia(VEC01[iA, jA], 2);
                                            suma = suma + sumaaux;
                                        }

                                        unitario = OC.RaizCuadrada(suma);
                                        unitario = OC.Dividir(1, unitario);
                                        //VEC03[iA, jA] = VEC01[jA, iA];

                                    }

                                    for (int iA = 0; iA < ifilaAVEC; iA++)
                                    {
                                        Console.Write("\n");
                                        for (int jA = 0; jA < icolumnaAVEC; jA++)
                                        {
                                            normal = OC.Multiplicar(unitario, VEC01[iA, jA]);
                                            VEC03[iA, jA] = normal;

                                        }

                                    }

                                    AgregarVectorResultado(ifilaAVEC , icolumnaAVEC);
                                    ImprimirVectorEspecifica(numerocodigoAuxVEC);

                                }
                                else
                                {
                                    volvervolver = true;
                                    Console.WriteLine("Warning: El tamaño del valor de los VECTORES no permite la operacion o no fue encontrada");
                                    Console.ReadLine();

                                }
                            }

                            volvervolver = true;
                            break;
                        }
                    case "8":
                        {
                            volvervolver = false;
                            break;
                        }
                    default:
                        Console.WriteLine(" Opcion invalida");
                        volvervolver = true;
                        break;
                }

            } while (volvervolver != false);
        }

        public void MatrizCompuesta()
        {
            do
            {
                volvervolver = false;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                Console.WriteLine("║                         MATRIZ COMPUESTA                              ║ ");
                Console.WriteLine("║                                                                       ║ ");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("║            INSERTE UN NUMERO SEGUN LA OPCION DESEADA DEL MENU         ║ ");
                Console.WriteLine("║ 0. Agregar Matriz                1. Imprimir Matrices                 ║ ");
                Console.WriteLine("║ 2. Modificar Matriz              3. Eliminar Martriz                  ║ ");
                Console.WriteLine("║ 4. Suma                          5. Resta                             ║ ");
                Console.WriteLine("║ 6. Multiplicacion                7. Transpuesta                       ║ ");
                Console.WriteLine("║ 8. Operacion con punto           9. Regresar                          ║ ");
                Console.WriteLine("║                                                                       ║ ");
                Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");


                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("   -------------------------------------------------------------------    ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("¿Que opcion elige?                                                        ");
                opcion = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("   -------------------------------------------------------------------    ");
                Console.ForegroundColor = ConsoleColor.White;

                switch (opcion)
                {
                    case "0":
                        {
                            do
                            {
                                volvervolver = false;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                                Console.WriteLine("║                       AGREGAR MATRIZ COMPUESTA                        ║ ");
                                Console.WriteLine("║                                                                       ║ ");

                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("║              SIGA POR FAVOR LAS INSTRUCCIONES SIGUIENTES              ║ ");
                                Console.WriteLine("║                                                                       ║ ");
                                Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");

                                AgregarMatrizCompuesta();
                                ImprimirMatrizCompuestaEspecifica(numerocodigoAuxMC);

                                volvervolver = false;
                            } while (volvervolver != false);
                            volvervolver = true;
                            break;
                        }
                    case "1":
                        {
                            do
                            {
                                volvervolver = false;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                                Console.WriteLine("║                      IMPRIMIR MATRIZ COMPUESTA                        ║ ");
                                Console.WriteLine("║                                                                       ║ ");

                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("║            INSERTE UN NUMERO SEGUN LA OPCION DESEADA DEL MENU         ║ ");
                                Console.WriteLine("║ 0. Imprimir todas las matrices   1. Imprimir matriz especifica        ║ ");
                                Console.WriteLine("║ 2. Salir                                                              ║ ");
                                Console.WriteLine("║                                                                       ║ ");
                                Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");

                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("   -------------------------------------------------------------------    ");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("¿Que opcion elige?                                                        ");
                                opcion = Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("   -------------------------------------------------------------------    ");
                                Console.ForegroundColor = ConsoleColor.White;

                                switch (opcion)
                                {
                                    case "0":
                                        ImprimirMatrizCompuesta();
                                        volvervolver = false;
                                        break;
                                    case "1":
                                        do
                                        {
                                            volvervolver = false;
                                            do
                                            {
                                                volvervolver = false;
                                                Console.WriteLine(" Escriba el codigo de la matriz que busca");
                                                string numerosho = Console.ReadLine();

                                                int cantidad = numerosho.Length;
                                                if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                {
                                                    volvervolver = false;
                                                    numerocodigoAuxMC = Convert.ToInt32(numerosho); // convierte a int
                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                }
                                            } while (volvervolver != false);

                                            if (ImprimirMatrizCompuestaEspecifica(numerocodigoAuxMC) != 0)
                                            {

                                                bool volvers = false;

                                                do
                                                {
                                                    volvervolver = false;

                                                    Console.WriteLine("¿Quiere intentar otro codigo?");
                                                    Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                    opcion = Console.ReadLine();

                                                    switch (opcion)
                                                    {
                                                        case "0":
                                                            volvervolver = false;
                                                            volvers = false;
                                                            break;
                                                        case "1":
                                                            volvervolver = false;
                                                            volvers = true;
                                                            break;
                                                        default:
                                                            Console.WriteLine(" Opcion invalida");
                                                            volvervolver = true;
                                                            break;

                                                    }

                                                } while (volvervolver != false);

                                                if (volvers == false)
                                                {
                                                    volvervolver = true;
                                                }
                                                else
                                                {
                                                    volvervolver = false;
                                                }

                                            }
                                        } while (volvervolver != false);
                                        volvervolver = false;
                                        break;
                                    case "2":
                                        volvervolver = false;
                                        break;

                                    default:
                                        Console.WriteLine(" Opcion invalida");
                                        volvervolver = true;
                                        break;
                                }

                            } while (volvervolver != false);
                            volvervolver = true;
                            break;
                        }
                    case "2":
                        {
                            do
                            {
                                volvervolver = false;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                                Console.WriteLine("║                      MODIFICAR MATRIZ COMPUESTA                       ║ ");
                                Console.WriteLine("║                                                                       ║ ");

                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("║            INSERTE UN NUMERO SEGUN LA OPCION DESEADA DEL MENU         ║ ");
                                Console.WriteLine("║ 0. Modificar toda la matriz          1. Salir                         ║ ");
                                Console.WriteLine("║                                                                       ║ ");
                                Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");

                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("   -------------------------------------------------------------------    ");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("¿Que opcion elige?                                                        ");
                                opcion = Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("   -------------------------------------------------------------------    ");
                                Console.ForegroundColor = ConsoleColor.White;

                                switch (opcion)
                                {
                                    case "0":
                                        do
                                        {
                                            volvervolver = false;
                                            do
                                            {
                                                volvervolver = false;
                                                Console.WriteLine(" Escriba el codigo de la matriz que busca");
                                                string numerosho = Console.ReadLine();

                                                int cantidad = numerosho.Length;
                                                if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                {
                                                    volvervolver = false;
                                                    numerocodigoAuxMC = Convert.ToInt32(numerosho); // convierte a int
                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                }
                                            } while (volvervolver != false);

                                            if (ModificarMatrizCompuesta(numerocodigoAuxMC) != 0)
                                            {

                                                bool volvers = false;

                                                do
                                                {
                                                    volvervolver = false;

                                                    Console.WriteLine("¿Quiere intentar otro codigo?");
                                                    Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                    opcion = Console.ReadLine();

                                                    switch (opcion)
                                                    {
                                                        case "0":
                                                            volvervolver = false;
                                                            volvers = false;
                                                            break;
                                                        case "1":
                                                            volvervolver = false;
                                                            volvers = true;
                                                            break;
                                                        default:
                                                            Console.WriteLine(" Opcion invalida");
                                                            volvervolver = true;
                                                            break;

                                                    }

                                                } while (volvervolver != false);

                                                if (volvers == false)
                                                {
                                                    volvervolver = true;
                                                }
                                                else
                                                {
                                                    volvervolver = false;
                                                }

                                            }
                                            else
                                            {
                                                ImprimirMatrizCompuestaEspecifica(numerocodigoAuxMC);
                                            }



                                        } while (volvervolver != false);
                                        volvervolver = false;
                                        break;
                                    //case "1":
                                    //    do
                                    //    {
                                    //        volvervolver = false;
                                    //        do
                                    //        {
                                    //            volvervolver = false;
                                    //            Console.WriteLine(" Escriba el codigo de la matriz que busca");
                                    //            string numerosho = Console.ReadLine();

                                    //            int cantidad = numerosho.Length;
                                    //            if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                    //            {
                                    //                volvervolver = false;
                                    //                numerocodigoAuxMC = Convert.ToInt32(numerosho); // convierte a int
                                    //            }
                                    //            else
                                    //            {
                                    //                volvervolver = true;
                                    //            }
                                    //        } while (volvervolver != false);

                                    //        if (ModificarMatrizCompuestaEspecifica(numerocodigoAuxMC) != 0)
                                    //        {

                                    //            bool volvers = false;

                                    //            do
                                    //            {
                                    //                volvervolver = false;

                                    //                Console.WriteLine("¿Quiere intentar otro codigo?");
                                    //                Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                    //                opcion = Console.ReadLine();

                                    //                switch (opcion)
                                    //                {
                                    //                    case "0":
                                    //                        volvervolver = false;
                                    //                        volvers = false;
                                    //                        break;
                                    //                    case "1":
                                    //                        volvervolver = false;
                                    //                        volvers = true;
                                    //                        break;
                                    //                    default:
                                    //                        Console.WriteLine(" Opcion invalida");
                                    //                        volvervolver = true;
                                    //                        break;

                                    //                }

                                    //            } while (volvervolver != false);

                                    //            if (volvers == false)
                                    //            {
                                    //                volvervolver = true;
                                    //            }
                                    //            else
                                    //            {
                                    //                volvervolver = false;
                                    //            }

                                    //        }
                                    //    } while (volvervolver != false);
                                    //    volvervolver = false;
                                    //    break;
                                    case "1":
                                        volvervolver = false;
                                        break;

                                    default:
                                        Console.WriteLine(" Opcion invalida");
                                        volvervolver = true;
                                        break;
                                }

                            } while (volvervolver != false);
                            volvervolver = true;
                            break;
                        }
                    case "3":
                        {
                            do
                            {
                                volvervolver = false;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                                Console.WriteLine("║                      ELIMINAR MATRIZ COMPUESTA                        ║ ");
                                Console.WriteLine("║                                                                       ║ ");

                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("║              SIGA POR FAVOR LAS INSTRUCCIONES SIGUIENTES              ║ ");
                                Console.WriteLine("║                                                                       ║ ");
                                Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");

                                do
                                {
                                    volvervolver = false;
                                    Console.WriteLine(" Escriba el codigo de la matriz que quiera eliminar");
                                    string numerosho = Console.ReadLine();

                                    int cantidad = numerosho.Length;
                                    if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                    {
                                        volvervolver = false;
                                        numerocodigoAuxMC = Convert.ToInt32(numerosho); // convierte a int
                                    }
                                    else
                                    {
                                        volvervolver = true;
                                    }
                                } while (volvervolver != false);
                                if (EliminarMatrizCompuesta(numerocodigoAuxMC) != 0)
                                {

                                    bool volvers = false;

                                    do
                                    {
                                        volvervolver = false;

                                        Console.WriteLine("¿Quiere intentar otro codigo?");
                                        Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                        opcion = Console.ReadLine();

                                        switch (opcion)
                                        {
                                            case "0":
                                                volvervolver = false;
                                                volvers = false;
                                                break;
                                            case "1":
                                                volvervolver = false;
                                                volvers = true;
                                                break;
                                            default:
                                                Console.WriteLine(" Opcion invalida");
                                                volvervolver = true;
                                                break;

                                        }

                                    } while (volvervolver != false);

                                    if (volvers == false)
                                    {
                                        volvervolver = true;
                                    }
                                    else
                                    {
                                        volvervolver = false;
                                    }

                                }


                            } while (volvervolver != false);
                            volvervolver = true;
                            break;
                        }
                    case "4":
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                            Console.WriteLine("║                        SUMAR MATRIZ COMPUESTA                         ║ ");
                            Console.WriteLine("║                                                                       ║ ");

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("║              SIGA POR FAVOR LAS INSTRUCCIONES SIGUIENTES              ║ ");
                            Console.WriteLine("║                                                                       ║ ");
                            Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");


                            if (inicioMC == null)
                            {
                                volvervolver = true;
                                Console.WriteLine("Warning: Aun no se agregan datos suficientes para la operacion");
                                Console.ReadLine();
                            }
                            else
                            {
                                do
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine(" ");
                                    Console.WriteLine("¿COMO REALIZARAS LA SUMA? 0. Matriz-Matriz | 1. Escalar-Matriz | 2. Matriz-Escalar");
                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("¿Que opcion elige?                                                        ");
                                    opcion = Console.ReadLine();
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                    Console.ForegroundColor = ConsoleColor.White;

                                    switch (opcion)
                                    {
                                        case "0":
                                            {
                                                bool SiMatrizA = false;
                                                bool SiMatrizB = false;
                                                //MATRIZ A
                                                do
                                                {
                                                    volvervolver = false;
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        Console.WriteLine(" Escriba el codigo de la MATRIZ A que desea sumar");
                                                        string numerosho = Console.ReadLine();

                                                        int cantidad = numerosho.Length;
                                                        if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                        {
                                                            volvervolver = false;
                                                            numerocodigoAuxMC = Convert.ToInt32(numerosho); // convierte a int
                                                        }
                                                        else
                                                        {
                                                            volvervolver = true;
                                                        }
                                                    } while (volvervolver != false);

                                                    if (BuscarMatrizCompuesta(numerocodigoAuxMC) != 0)
                                                    {
                                                        SiMatrizA = false;
                                                        bool volvers = false;

                                                        do
                                                        {
                                                            volvervolver = false;

                                                            Console.WriteLine("¿Quiere intentar otro codigo?");
                                                            Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                            opcion = Console.ReadLine();

                                                            switch (opcion)
                                                            {
                                                                case "0":
                                                                    volvervolver = false;
                                                                    volvers = false;
                                                                    break;
                                                                case "1":
                                                                    volvervolver = false;
                                                                    volvers = true;
                                                                    SiMatrizA = false;
                                                                    break;
                                                                default:
                                                                    Console.WriteLine(" Opcion invalida");
                                                                    volvervolver = true;
                                                                    break;

                                                            }

                                                        } while (volvervolver != false);

                                                        if (volvers == false)
                                                        {
                                                            volvervolver = true;
                                                        }
                                                        else
                                                        {
                                                            volvervolver = false;
                                                        }

                                                    }
                                                    else
                                                    {
                                                        SiMatrizA = true;
                                                    }
                                                } while (volvervolver != false);

                                                ifilaAMC = ifilaAuxMC;
                                                icolumnaAMC = icolumnaAuxMC;
                                                MC01 = new float[ifilaAMC, icolumnaAMC];
                                                if (SiMatrizA == true)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                                    Console.WriteLine(" MATRIZ A");
                                                    Console.WriteLine(" Codigo: " + numerocodigoAuxMC + "  Con filas: " + ifilaAMC + "  Con Columnas: " + icolumnaAMC);

                                                    for (int i = 0; i < ifilaAMC; i++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int j = 0; j < icolumnaAMC; j++)
                                                        {
                                                            MC01[i, j] = MCAux[i, j];
                                                            Console.Write(MC01[i, j] + "   ");
                                                        }
                                                    }
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("\n");
                                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                                }

                                                //MATRIZ B
                                                if (SiMatrizA == true)
                                                {
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        do
                                                        {
                                                            volvervolver = false;
                                                            Console.WriteLine(" Escriba el codigo de la MATRIZ B que desea sumar");
                                                            string numerosho = Console.ReadLine();

                                                            int cantidad = numerosho.Length;
                                                            if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                            {
                                                                volvervolver = false;
                                                                numerocodigoAuxMC = Convert.ToInt32(numerosho); // convierte a int
                                                            }
                                                            else
                                                            {
                                                                volvervolver = true;
                                                            }
                                                        } while (volvervolver != false);

                                                        if (BuscarMatrizCompuesta(numerocodigoAuxMC) != 0)
                                                        {
                                                            SiMatrizB = false;
                                                            bool volvers = false;

                                                            do
                                                            {
                                                                volvervolver = false;

                                                                Console.WriteLine("¿Quiere intentar otro codigo?");
                                                                Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                                opcion = Console.ReadLine();

                                                                switch (opcion)
                                                                {
                                                                    case "0":
                                                                        volvervolver = false;
                                                                        volvers = false;
                                                                        break;
                                                                    case "1":
                                                                        volvervolver = false;
                                                                        volvers = true;
                                                                        break;
                                                                    default:
                                                                        Console.WriteLine(" Opcion invalida");
                                                                        volvervolver = true;
                                                                        break;

                                                                }

                                                            } while (volvervolver != false);

                                                            if (volvers == false)
                                                            {
                                                                volvervolver = true;
                                                            }
                                                            else
                                                            {
                                                                volvervolver = false;
                                                            }

                                                        }
                                                        else
                                                        {
                                                            SiMatrizB = true;
                                                        }
                                                    } while (volvervolver != false);
                                                    ifilaBMC = ifilaAuxMC;
                                                    icolumnaBMC = icolumnaAuxMC;
                                                    MC02 = new float[ifilaBMC, icolumnaBMC];
                                                    if (SiMatrizB == true)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                                        Console.WriteLine(" MATRIZ B");
                                                        Console.WriteLine(" Codigo: " + numerocodigoAuxMC + "  Con filas: " + ifilaBMC + "  Con Columnas: " + icolumnaBMC);

                                                        for (int i = 0; i < ifilaBMC; i++)
                                                        {
                                                            Console.Write("\n");
                                                            for (int j = 0; j < icolumnaBMC; j++)
                                                            {
                                                                MC02[i, j] = MCAux[i, j];
                                                                Console.Write(MC02[i, j] + "   ");
                                                            }
                                                        }
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        Console.WriteLine("\n");
                                                        Console.WriteLine("   -------------------------------------------------------------------    ");
                                                    }
                                                }

                                                if (VC.Igualdad(ifilaAMC, ifilaBMC) == 0 && VC.Igualdad(icolumnaAMC, icolumnaBMC) == 0 && SiMatrizA == true && SiMatrizB == true)
                                                {
                                                    volvervolver = false;

                                                    MC03 = new float[ifilaAMC, icolumnaAMC];

                                                    for (int iA = 0; iA < ifilaAMC; iA++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int jA = 0; jA < icolumnaAMC; jA++)
                                                        {

                                                            float MatriciosaA = MC01[iA, jA];
                                                            float MatricionaB = MC02[iA, jA];

                                                            MC03[iA, jA] = OC.Sumar(MatriciosaA, MatricionaB);


                                                        }

                                                    }


                                                    AgregarMatrizCompuestaResultado(ifilaAMC, icolumnaAMC);
                                                    ImprimirMatrizCompuestaEspecifica(numerocodigoAuxMC);

                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                    Console.WriteLine("Warning: El tamaño del valor de las matrices no permite la operacion o no fue encontrada");
                                                    Console.ReadLine();

                                                }

                                                volvervolver = false;
                                                break;
                                            }
                                        case "1":
                                            {
                                                bool SiMatrizA = false;
                                                bool SiMatrizB = false;
                                                //ESCALAR
                                                do
                                                {
                                                    volver = false;
                                                    Console.WriteLine(" Escriba el numero a sumar");
                                                    string numeromatriz = Console.ReadLine();
                                                    int cantidad = numeromatriz.Length;
                                                    if (VC.Contador(cantidad, numeromatriz) == 0)
                                                    {
                                                        volver = false;
                                                        float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                                                        inumeromatriz = (float)Math.Round(inumeromatriz, 2);
                                                        escalarAMC = inumeromatriz;
                                                        SiMatrizA = true;
                                                    }
                                                    else
                                                    {
                                                        SiMatrizA = false;
                                                        volver = true;
                                                    }
                                                } while (volver != false);

                                                //MATRIZ B
                                                if (SiMatrizA == true)
                                                {
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        do
                                                        {
                                                            volvervolver = false;
                                                            Console.WriteLine(" Escriba el codigo de la MATRIZ B que desea sumar");
                                                            string numerosho = Console.ReadLine();

                                                            int cantidad = numerosho.Length;
                                                            if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                            {
                                                                volvervolver = false;
                                                                numerocodigoAuxMC = Convert.ToInt32(numerosho); // convierte a int
                                                            }
                                                            else
                                                            {
                                                                volvervolver = true;
                                                            }
                                                        } while (volvervolver != false);

                                                        if (BuscarMatrizCompuesta(numerocodigoAuxMC) != 0)
                                                        {
                                                            SiMatrizB = false;
                                                            bool volvers = false;

                                                            do
                                                            {
                                                                volvervolver = false;

                                                                Console.WriteLine("¿Quiere intentar otro codigo?");
                                                                Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                                opcion = Console.ReadLine();

                                                                switch (opcion)
                                                                {
                                                                    case "0":
                                                                        volvervolver = false;
                                                                        volvers = false;
                                                                        break;
                                                                    case "1":
                                                                        volvervolver = false;
                                                                        volvers = true;
                                                                        break;
                                                                    default:
                                                                        Console.WriteLine(" Opcion invalida");
                                                                        volvervolver = true;
                                                                        break;

                                                                }

                                                            } while (volvervolver != false);

                                                            if (volvers == false)
                                                            {
                                                                volvervolver = true;
                                                            }
                                                            else
                                                            {
                                                                volvervolver = false;
                                                            }

                                                        }
                                                        else
                                                        {
                                                            SiMatrizB = true;
                                                        }
                                                    } while (volvervolver != false);
                                                    ifilaBMC = ifilaAuxMC;
                                                    icolumnaBMC = icolumnaAuxMC;
                                                    MC02 = new float[ifilaBMC, icolumnaBMC];
                                                    if (SiMatrizB == true)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                                        Console.WriteLine(" MATRIZ B");
                                                        Console.WriteLine(" Codigo: " + numerocodigoAuxMC + "  Con filas: " + ifilaBMC + "  Con Columnas: " + icolumnaBMC);

                                                        for (int i = 0; i < ifilaBMC; i++)
                                                        {
                                                            Console.Write("\n");
                                                            for (int j = 0; j < icolumnaBMC; j++)
                                                            {
                                                                MC02[i, j] = MCAux[i, j];
                                                                Console.Write(MC02[i, j] + "   ");
                                                            }
                                                        }
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        Console.WriteLine("\n");
                                                        Console.WriteLine("   -------------------------------------------------------------------    ");
                                                    }
                                                }



                                                if (SiMatrizA == true && SiMatrizB == true)
                                                {
                                                    volvervolver = false;

                                                    MC03 = new float[ifilaBMC, icolumnaBMC];

                                                    for (int iA = 0; iA < ifilaBMC; iA++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int jA = 0; jA < icolumnaBMC; jA++)
                                                        {
                                                            float MatricionaB = MC02[iA, jA];

                                                            MC03[iA, jA] = OC.Sumar(escalarAMC, MatricionaB);


                                                        }

                                                    }


                                                    AgregarMatrizCompuestaResultado(ifilaBMC, icolumnaBMC);
                                                    ImprimirMatrizCompuestaEspecifica(numerocodigoAuxMC);

                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                    Console.WriteLine("Warning: El tamaño del valor de las matrices no permite la operacion o no fue encontrada");
                                                    Console.ReadLine();

                                                }

                                                volvervolver = false;
                                                break;
                                            }
                                        case "2":
                                            {
                                                bool SiMatrizA = false;
                                                bool SiMatrizB = false;
                                                //MATRIZ A
                                                do
                                                {
                                                    volvervolver = false;
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        Console.WriteLine(" Escriba el codigo de la MATRIZ A que desea sumar");
                                                        string numerosho = Console.ReadLine();

                                                        int cantidad = numerosho.Length;
                                                        if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                        {
                                                            volvervolver = false;
                                                            numerocodigoAuxMC = Convert.ToInt32(numerosho); // convierte a int
                                                        }
                                                        else
                                                        {
                                                            volvervolver = true;
                                                        }
                                                    } while (volvervolver != false);

                                                    if (BuscarMatrizCompuesta(numerocodigoAuxMC) != 0)
                                                    {
                                                        SiMatrizA = false;
                                                        bool volvers = false;

                                                        do
                                                        {
                                                            volvervolver = false;

                                                            Console.WriteLine("¿Quiere intentar otro codigo?");
                                                            Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                            opcion = Console.ReadLine();

                                                            switch (opcion)
                                                            {
                                                                case "0":
                                                                    volvervolver = false;
                                                                    volvers = false;
                                                                    break;
                                                                case "1":
                                                                    volvervolver = false;
                                                                    volvers = true;
                                                                    SiMatrizA = false;
                                                                    break;
                                                                default:
                                                                    Console.WriteLine(" Opcion invalida");
                                                                    volvervolver = true;
                                                                    break;

                                                            }

                                                        } while (volvervolver != false);

                                                        if (volvers == false)
                                                        {
                                                            volvervolver = true;
                                                        }
                                                        else
                                                        {
                                                            volvervolver = false;
                                                        }

                                                    }
                                                    else
                                                    {
                                                        SiMatrizA = true;
                                                    }
                                                } while (volvervolver != false);
                                                ifilaAMC = ifilaAuxMC;
                                                icolumnaAMC = icolumnaAuxMC;
                                                MC01 = new float[ifilaAMC, icolumnaAMC];
                                                if (SiMatrizA == true)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                                    Console.WriteLine(" MATRIZ A");
                                                    Console.WriteLine(" Codigo: " + numerocodigoAuxMC + "  Con filas: " + ifilaAMC + "  Con Columnas: " + icolumnaAMC);

                                                    for (int i = 0; i < ifilaAMC; i++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int j = 0; j < icolumnaAMC; j++)
                                                        {
                                                            MC01[i, j] = MCAux[i, j];
                                                            Console.Write(MC01[i, j] + "   ");
                                                        }
                                                    }
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("\n");
                                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                                }

                                                //ESCALAR B
                                                if (SiMatrizA == true)
                                                {
                                                    do
                                                    {
                                                        volver = false;
                                                        Console.WriteLine(" Escriba el numero a sumar");
                                                        string numeromatriz = Console.ReadLine();
                                                        int cantidad = numeromatriz.Length;
                                                        if (VC.Contador(cantidad, numeromatriz) == 0)
                                                        {
                                                            volver = false;
                                                            float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                                                            inumeromatriz = (float)Math.Round(inumeromatriz, 2);
                                                            escalarBMC = inumeromatriz;
                                                            SiMatrizB = true;
                                                        }
                                                        else
                                                        {
                                                            SiMatrizB = false;
                                                            volver = true;
                                                        }
                                                    } while (volver != false);
                                                }

                                                if (SiMatrizA == true && SiMatrizB == true)
                                                {
                                                    volvervolver = false;

                                                    MC03 = new float[ifilaAMC, icolumnaAMC];

                                                    for (int iA = 0; iA < ifilaAMC; iA++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int jA = 0; jA < icolumnaAMC; jA++)
                                                        {
                                                            float MatriciosaA = MC01[iA, jA];
                                                            MC03[iA, jA] = OC.Sumar(MatriciosaA, escalarBMC);

                                                        }

                                                    }


                                                    AgregarMatrizCompuestaResultado(ifilaAMC, icolumnaAMC);
                                                    ImprimirMatrizCompuestaEspecifica(numerocodigoAuxMC);

                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                    Console.WriteLine("Warning: El tamaño del valor de las matrices no permite la operacion o no fue encontrada");
                                                    Console.ReadLine();

                                                }

                                                volvervolver = false;
                                                break;
                                            }
                                        default:
                                            Console.WriteLine(" Opcion invalida");
                                            volvervolver = true;
                                            break;
                                    }

                                } while (volvervolver != false);

                            }
                            volvervolver = true;
                            break;
                        }
                    case "5":
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                            Console.WriteLine("║                       RESTAR MATRIZ COMPUESTA                         ║ ");
                            Console.WriteLine("║                                                                       ║ ");

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("║              SIGA POR FAVOR LAS INSTRUCCIONES SIGUIENTES              ║ ");
                            Console.WriteLine("║                                                                       ║ ");
                            Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");


                            if (inicioMC == null)
                            {
                                volvervolver = true;
                                Console.WriteLine("Warning: Aun no se agregan datos suficientes para la operacion");
                                Console.ReadLine();
                            }
                            else
                            {
                                do
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine(" ");
                                    Console.WriteLine("¿COMO REALIZARAS LA RESTA? 0. Matriz-Matriz | 1. Escalar-Matriz | 2. Matriz-Escalar");
                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("¿Que opcion elige?                                                        ");
                                    opcion = Console.ReadLine();
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                    Console.ForegroundColor = ConsoleColor.White;

                                    switch (opcion)
                                    {
                                        case "0":
                                            {
                                                bool SiMatrizA = false;
                                                bool SiMatrizB = false;
                                                //MATRIZ A
                                                do
                                                {
                                                    volvervolver = false;
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        Console.WriteLine(" Escriba el codigo de la MATRIZ A que desea RESTAR");
                                                        string numerosho = Console.ReadLine();

                                                        int cantidad = numerosho.Length;
                                                        if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                        {
                                                            volvervolver = false;
                                                            numerocodigoAuxMC = Convert.ToInt32(numerosho); // convierte a int
                                                        }
                                                        else
                                                        {
                                                            volvervolver = true;
                                                        }
                                                    } while (volvervolver != false);

                                                    if (BuscarMatrizCompuesta(numerocodigoAuxMC) != 0)
                                                    {
                                                        SiMatrizA = false;
                                                        bool volvers = false;

                                                        do
                                                        {
                                                            volvervolver = false;

                                                            Console.WriteLine("¿Quiere intentar otro codigo?");
                                                            Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                            opcion = Console.ReadLine();

                                                            switch (opcion)
                                                            {
                                                                case "0":
                                                                    volvervolver = false;
                                                                    volvers = false;
                                                                    break;
                                                                case "1":
                                                                    volvervolver = false;
                                                                    volvers = true;
                                                                    SiMatrizA = false;
                                                                    break;
                                                                default:
                                                                    Console.WriteLine(" Opcion invalida");
                                                                    volvervolver = true;
                                                                    break;

                                                            }

                                                        } while (volvervolver != false);

                                                        if (volvers == false)
                                                        {
                                                            volvervolver = true;
                                                        }
                                                        else
                                                        {
                                                            volvervolver = false;
                                                        }

                                                    }
                                                    else
                                                    {
                                                        SiMatrizA = true;
                                                    }
                                                } while (volvervolver != false);

                                                ifilaAMC = ifilaAuxMC;
                                                icolumnaAMC = icolumnaAuxMC;
                                                MC01 = new float[ifilaAMC, icolumnaAMC];
                                                if (SiMatrizA == true)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                                    Console.WriteLine(" MATRIZ A");
                                                    Console.WriteLine(" Codigo: " + numerocodigoAuxMC + "  Con filas: " + ifilaAMC + "  Con Columnas: " + icolumnaAMC);

                                                    for (int i = 0; i < ifilaAMC; i++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int j = 0; j < icolumnaAMC; j++)
                                                        {
                                                            MC01[i, j] = MCAux[i, j];
                                                            Console.Write(MC01[i, j] + "   ");
                                                        }
                                                    }
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("\n");
                                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                                }

                                                //MATRIZ B
                                                if (SiMatrizA == true)
                                                {
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        do
                                                        {
                                                            volvervolver = false;
                                                            Console.WriteLine(" Escriba el codigo de la MATRIZ B que desea RESTAR");
                                                            string numerosho = Console.ReadLine();

                                                            int cantidad = numerosho.Length;
                                                            if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                            {
                                                                volvervolver = false;
                                                                numerocodigoAuxMC = Convert.ToInt32(numerosho); // convierte a int
                                                            }
                                                            else
                                                            {
                                                                volvervolver = true;
                                                            }
                                                        } while (volvervolver != false);

                                                        if (BuscarMatrizCompuesta(numerocodigoAuxMC) != 0)
                                                        {
                                                            SiMatrizB = false;
                                                            bool volvers = false;

                                                            do
                                                            {
                                                                volvervolver = false;

                                                                Console.WriteLine("¿Quiere intentar otro codigo?");
                                                                Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                                opcion = Console.ReadLine();

                                                                switch (opcion)
                                                                {
                                                                    case "0":
                                                                        volvervolver = false;
                                                                        volvers = false;
                                                                        break;
                                                                    case "1":
                                                                        volvervolver = false;
                                                                        volvers = true;
                                                                        break;
                                                                    default:
                                                                        Console.WriteLine(" Opcion invalida");
                                                                        volvervolver = true;
                                                                        break;

                                                                }

                                                            } while (volvervolver != false);

                                                            if (volvers == false)
                                                            {
                                                                volvervolver = true;
                                                            }
                                                            else
                                                            {
                                                                volvervolver = false;
                                                            }

                                                        }
                                                        else
                                                        {
                                                            SiMatrizB = true;
                                                        }
                                                    } while (volvervolver != false);
                                                    ifilaBMC = ifilaAuxMC;
                                                    icolumnaBMC = icolumnaAuxMC;
                                                    MC02 = new float[ifilaBMC, icolumnaBMC];
                                                    if (SiMatrizB == true)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                                        Console.WriteLine(" MATRIZ B");
                                                        Console.WriteLine(" Codigo: " + numerocodigoAuxMC + "  Con filas: " + ifilaBMC + "  Con Columnas: " + icolumnaBMC);

                                                        for (int i = 0; i < ifilaBMC; i++)
                                                        {
                                                            Console.Write("\n");
                                                            for (int j = 0; j < icolumnaBMC; j++)
                                                            {
                                                                MC02[i, j] = MCAux[i, j];
                                                                Console.Write(MC02[i, j] + "   ");
                                                            }
                                                        }
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        Console.WriteLine("\n");
                                                        Console.WriteLine("   -------------------------------------------------------------------    ");
                                                    }
                                                }

                                                if (VC.Igualdad(ifilaAMC, ifilaBMC) == 0 && VC.Igualdad(icolumnaAMC, icolumnaBMC) == 0 && SiMatrizA == true && SiMatrizB == true)
                                                {
                                                    volvervolver = false;

                                                    MC03 = new float[ifilaAMC, icolumnaAMC];

                                                    for (int iA = 0; iA < ifilaAMC; iA++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int jA = 0; jA < icolumnaAMC; jA++)
                                                        {

                                                            float MatriciosaA = MC01[iA, jA];
                                                            float MatricionaB = MC02[iA, jA];

                                                            MC03[iA, jA] = OC.Restar(MatriciosaA, MatricionaB);


                                                        }

                                                    }


                                                    AgregarMatrizCompuestaResultado(ifilaAMC, icolumnaAMC);
                                                    ImprimirMatrizCompuestaEspecifica(numerocodigoAuxMC);
                                                    break;

                                                }
                                                else
                                                {
                                                    Console.WriteLine("Warning: El tamaño del valor de las matrices no permite la operacion o no fue encontrada");
                                                    Console.ReadLine();
                                                }
                                                volvervolver = false;
                                                break;
                                            }
                                        case "1":
                                            {
                                                bool SiMatrizA = false;
                                                bool SiMatrizB = false;
                                                //ESCALAR
                                                do
                                                {
                                                    volver = false;
                                                    Console.WriteLine(" Escriba el numero a restar");
                                                    string numeromatriz = Console.ReadLine();
                                                    int cantidad = numeromatriz.Length;
                                                    if (VC.Contador(cantidad, numeromatriz) == 0)
                                                    {
                                                        volver = false;
                                                        float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                                                        inumeromatriz = (float)Math.Round(inumeromatriz, 2);
                                                        escalarAMC = inumeromatriz;
                                                        SiMatrizA = true;
                                                    }
                                                    else
                                                    {
                                                        SiMatrizA = false;
                                                        volver = true;
                                                    }
                                                } while (volver != false);

                                                //MATRIZ B
                                                if (SiMatrizA == true)
                                                {
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        do
                                                        {
                                                            volvervolver = false;
                                                            Console.WriteLine(" Escriba el codigo de la MATRIZ B que desea restar");
                                                            string numerosho = Console.ReadLine();

                                                            int cantidad = numerosho.Length;
                                                            if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                            {
                                                                volvervolver = false;
                                                                numerocodigoAuxMC = Convert.ToInt32(numerosho); // convierte a int
                                                            }
                                                            else
                                                            {
                                                                volvervolver = true;
                                                            }
                                                        } while (volvervolver != false);

                                                        if (BuscarMatrizCompuesta(numerocodigoAuxMC) != 0)
                                                        {
                                                            SiMatrizB = false;
                                                            bool volvers = false;

                                                            do
                                                            {
                                                                volvervolver = false;

                                                                Console.WriteLine("¿Quiere intentar otro codigo?");
                                                                Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                                opcion = Console.ReadLine();

                                                                switch (opcion)
                                                                {
                                                                    case "0":
                                                                        volvervolver = false;
                                                                        volvers = false;
                                                                        break;
                                                                    case "1":
                                                                        volvervolver = false;
                                                                        volvers = true;
                                                                        break;
                                                                    default:
                                                                        Console.WriteLine(" Opcion invalida");
                                                                        volvervolver = true;
                                                                        break;

                                                                }

                                                            } while (volvervolver != false);

                                                            if (volvers == false)
                                                            {
                                                                volvervolver = true;
                                                            }
                                                            else
                                                            {
                                                                volvervolver = false;
                                                            }

                                                        }
                                                        else
                                                        {
                                                            SiMatrizB = true;
                                                        }
                                                    } while (volvervolver != false);
                                                    ifilaBMC = ifilaAuxMC;
                                                    icolumnaBMC = icolumnaAuxMC;
                                                    MC02 = new float[ifilaBMC, icolumnaBMC];
                                                    if (SiMatrizB == true)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                                        Console.WriteLine(" MATRIZ B");
                                                        Console.WriteLine(" Codigo: " + numerocodigoAuxMC + "  Con filas: " + ifilaBMC + "  Con Columnas: " + icolumnaBMC);

                                                        for (int i = 0; i < ifilaBMC; i++)
                                                        {
                                                            Console.Write("\n");
                                                            for (int j = 0; j < icolumnaBMC; j++)
                                                            {
                                                                MC02[i, j] = MCAux[i, j];
                                                                Console.Write(MC02[i, j] + "   ");
                                                            }
                                                        }
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        Console.WriteLine("\n");
                                                        Console.WriteLine("   -------------------------------------------------------------------    ");
                                                    }
                                                }



                                                if (SiMatrizA == true && SiMatrizB == true)
                                                {
                                                    volvervolver = false;

                                                    MC03 = new float[ifilaBMC, icolumnaBMC];

                                                    for (int iA = 0; iA < ifilaBMC; iA++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int jA = 0; jA < icolumnaBMC; jA++)
                                                        {
                                                            float MatricionaB = MC02[iA, jA];

                                                            MC03[iA, jA] = OC.Restar(escalarAMC, MatricionaB);


                                                        }

                                                    }


                                                    AgregarMatrizCompuestaResultado(ifilaBMC, icolumnaBMC);
                                                    ImprimirMatrizCompuestaEspecifica(numerocodigoAuxMC);

                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                    Console.WriteLine("Warning: El tamaño del valor de las matrices no permite la operacion o no fue encontrada");
                                                    Console.ReadLine();

                                                }

                                                volvervolver = false;
                                                break;
                                            }
                                        case "2":
                                            {
                                                bool SiMatrizA = false;
                                                bool SiMatrizB = false;
                                                //MATRIZ A
                                                do
                                                {
                                                    volvervolver = false;
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        Console.WriteLine(" Escriba el codigo de la MATRIZ A que desea restar");
                                                        string numerosho = Console.ReadLine();

                                                        int cantidad = numerosho.Length;
                                                        if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                        {
                                                            volvervolver = false;
                                                            numerocodigoAuxMC = Convert.ToInt32(numerosho); // convierte a int
                                                        }
                                                        else
                                                        {
                                                            volvervolver = true;
                                                        }
                                                    } while (volvervolver != false);

                                                    if (BuscarMatrizCompuesta(numerocodigoAuxMC) != 0)
                                                    {
                                                        SiMatrizA = false;
                                                        bool volvers = false;

                                                        do
                                                        {
                                                            volvervolver = false;

                                                            Console.WriteLine("¿Quiere intentar otro codigo?");
                                                            Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                            opcion = Console.ReadLine();

                                                            switch (opcion)
                                                            {
                                                                case "0":
                                                                    volvervolver = false;
                                                                    volvers = false;
                                                                    break;
                                                                case "1":
                                                                    volvervolver = false;
                                                                    volvers = true;
                                                                    SiMatrizA = false;
                                                                    break;
                                                                default:
                                                                    Console.WriteLine(" Opcion invalida");
                                                                    volvervolver = true;
                                                                    break;

                                                            }

                                                        } while (volvervolver != false);

                                                        if (volvers == false)
                                                        {
                                                            volvervolver = true;
                                                        }
                                                        else
                                                        {
                                                            volvervolver = false;
                                                        }

                                                    }
                                                    else
                                                    {
                                                        SiMatrizA = true;
                                                    }
                                                } while (volvervolver != false);
                                                ifilaAMC = ifilaAuxMC;
                                                icolumnaAMC = icolumnaAuxMC;
                                                MC01 = new float[ifilaAMC, icolumnaAMC];
                                                if (SiMatrizA == true)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                                    Console.WriteLine(" MATRIZ A");
                                                    Console.WriteLine(" Codigo: " + numerocodigoAuxMC + "  Con filas: " + ifilaAMC + "  Con Columnas: " + icolumnaAMC);

                                                    for (int i = 0; i < ifilaAMC; i++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int j = 0; j < icolumnaAMC; j++)
                                                        {
                                                            MC01[i, j] = MCAux[i, j];
                                                            Console.Write(MC01[i, j] + "   ");
                                                        }
                                                    }
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("\n");
                                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                                }

                                                //ESCALAR B
                                                if (SiMatrizA == true)
                                                {
                                                    do
                                                    {
                                                        volver = false;
                                                        Console.WriteLine(" Escriba el numero a restar");
                                                        string numeromatriz = Console.ReadLine();
                                                        int cantidad = numeromatriz.Length;
                                                        if (VC.Contador(cantidad, numeromatriz) == 0)
                                                        {
                                                            volver = false;
                                                            float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                                                            inumeromatriz = (float)Math.Round(inumeromatriz, 2);
                                                            escalarBMC = inumeromatriz;
                                                            SiMatrizB = true;
                                                        }
                                                        else
                                                        {
                                                            SiMatrizB = false;
                                                            volver = true;
                                                        }
                                                    } while (volver != false);
                                                }

                                                if (SiMatrizA == true && SiMatrizB == true)
                                                {
                                                    volvervolver = false;

                                                    MC03 = new float[ifilaAMC, icolumnaAMC];

                                                    for (int iA = 0; iA < ifilaAMC; iA++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int jA = 0; jA < icolumnaAMC; jA++)
                                                        {
                                                            float MatriciosaA = MC01[iA, jA];
                                                            MC03[iA, jA] = OC.Restar(MatriciosaA, escalarBMC);

                                                        }

                                                    }


                                                    AgregarMatrizCompuestaResultado(ifilaAMC, icolumnaAMC);
                                                    ImprimirMatrizCompuestaEspecifica(numerocodigoAuxMC);

                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                    Console.WriteLine("Warning: El tamaño del valor de las matrices no permite la operacion o no fue encontrada");
                                                    Console.ReadLine();

                                                }

                                                volvervolver = false;
                                                break;
                                            }
                                        default:
                                            Console.WriteLine(" Opcion invalida");
                                            volvervolver = true;
                                            break;
                                    }

                                } while (volvervolver != false);


                            }

                            volvervolver = true;
                            break;
                        }
                    case "6":
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                            Console.WriteLine("║                    MULTIPLICAR MATRIZ COMPUESTA                       ║ ");
                            Console.WriteLine("║                                                                       ║ ");

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("║              SIGA POR FAVOR LAS INSTRUCCIONES SIGUIENTES              ║ ");
                            Console.WriteLine("║                                                                       ║ ");
                            Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");


                            if (inicioMC == null)
                            {
                                volvervolver = true;
                                Console.WriteLine("Warning: Aun no se agregan datos suficientes para la operacion");
                                Console.ReadLine();
                            }
                            else
                            {
                                do
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine(" ");
                                    Console.WriteLine("¿COMO REALIZARAS LA SUMA? 0. Matriz-Matriz | 1. Escalar-Matriz | 2. Matriz-Escalar");
                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("¿Que opcion elige?                                                        ");
                                    opcion = Console.ReadLine();
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                    Console.ForegroundColor = ConsoleColor.White;

                                    switch (opcion)
                                    {
                                        case "0":
                                            {
                                                bool SiMatrizA = false;
                                                bool SiMatrizB = false;
                                                //MATRIZ A
                                                do
                                                {
                                                    volvervolver = false;
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        Console.WriteLine(" Escriba el codigo de la MATRIZ A que desea realizar MULTIPLICAR");
                                                        string numerosho = Console.ReadLine();

                                                        int cantidad = numerosho.Length;
                                                        if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                        {
                                                            volvervolver = false;
                                                            numerocodigoAuxMC = Convert.ToInt32(numerosho); // convierte a int
                                                        }
                                                        else
                                                        {
                                                            volvervolver = true;
                                                        }
                                                    } while (volvervolver != false);

                                                    if (BuscarMatrizCompuesta(numerocodigoAuxMC) != 0)
                                                    {
                                                        SiMatrizA = false;
                                                        bool volvers = false;

                                                        do
                                                        {
                                                            volvervolver = false;

                                                            Console.WriteLine("¿Quiere intentar otro codigo?");
                                                            Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                            opcion = Console.ReadLine();

                                                            switch (opcion)
                                                            {
                                                                case "0":
                                                                    volvervolver = false;
                                                                    volvers = false;
                                                                    break;
                                                                case "1":
                                                                    volvervolver = false;
                                                                    volvers = true;
                                                                    SiMatrizA = false;
                                                                    break;
                                                                default:
                                                                    Console.WriteLine(" Opcion invalida");
                                                                    volvervolver = true;
                                                                    break;

                                                            }

                                                        } while (volvervolver != false);

                                                        if (volvers == false)
                                                        {
                                                            volvervolver = true;
                                                        }
                                                        else
                                                        {
                                                            volvervolver = false;
                                                        }

                                                    }
                                                    else
                                                    {
                                                        SiMatrizA = true;
                                                    }
                                                } while (volvervolver != false);

                                                ifilaAMC = ifilaAuxMC;
                                                icolumnaAMC = icolumnaAuxMC;
                                                MC01 = new float[ifilaAMC, icolumnaAMC];
                                                if (SiMatrizA == true)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                                    Console.WriteLine(" MATRIZ A");
                                                    Console.WriteLine(" Codigo: " + numerocodigoAuxMC + "  Con filas: " + ifilaAMC + "  Con Columnas: " + icolumnaAMC);

                                                    for (int i = 0; i < ifilaAMC; i++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int j = 0; j < icolumnaAMC; j++)
                                                        {
                                                            MC01[i, j] = MCAux[i, j];
                                                            Console.Write(MC01[i, j] + "   ");
                                                        }
                                                    }
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("\n");
                                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                                }

                                                //MATRIZ B
                                                if (SiMatrizA == true)
                                                {
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        do
                                                        {
                                                            volvervolver = false;
                                                            Console.WriteLine(" Escriba el codigo de la MATRIZ B que desea realizar MULTIPLICAR");
                                                            string numerosho = Console.ReadLine();

                                                            int cantidad = numerosho.Length;
                                                            if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                            {
                                                                volvervolver = false;
                                                                numerocodigoAuxMC = Convert.ToInt32(numerosho); // convierte a int
                                                            }
                                                            else
                                                            {
                                                                volvervolver = true;
                                                            }
                                                        } while (volvervolver != false);

                                                        if (BuscarMatrizCompuesta(numerocodigoAuxMC) != 0)
                                                        {
                                                            SiMatrizB = false;
                                                            bool volvers = false;

                                                            do
                                                            {
                                                                volvervolver = false;

                                                                Console.WriteLine("¿Quiere intentar otro codigo?");
                                                                Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                                opcion = Console.ReadLine();

                                                                switch (opcion)
                                                                {
                                                                    case "0":
                                                                        volvervolver = false;
                                                                        volvers = false;
                                                                        break;
                                                                    case "1":
                                                                        volvervolver = false;
                                                                        volvers = true;
                                                                        break;
                                                                    default:
                                                                        Console.WriteLine(" Opcion invalida");
                                                                        volvervolver = true;
                                                                        break;

                                                                }

                                                            } while (volvervolver != false);

                                                            if (volvers == false)
                                                            {
                                                                volvervolver = true;
                                                            }
                                                            else
                                                            {
                                                                volvervolver = false;
                                                            }

                                                        }
                                                        else
                                                        {
                                                            SiMatrizB = true;
                                                        }
                                                    } while (volvervolver != false);
                                                    ifilaBMC = ifilaAuxMC;
                                                    icolumnaBMC = icolumnaAuxMC;
                                                    MC02 = new float[ifilaBMC, icolumnaBMC];
                                                    if (SiMatrizB == true)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                                        Console.WriteLine(" MATRIZ B");
                                                        Console.WriteLine(" Codigo: " + numerocodigoAuxMC + "  Con filas: " + ifilaBMC + "  Con Columnas: " + icolumnaBMC);

                                                        for (int i = 0; i < ifilaBMC; i++)
                                                        {
                                                            Console.Write("\n");
                                                            for (int j = 0; j < icolumnaBMC; j++)
                                                            {
                                                                MC02[i, j] = MCAux[i, j];
                                                                Console.Write(MC02[i, j] + "   ");
                                                            }
                                                        }
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        Console.WriteLine("\n");
                                                        Console.WriteLine("   -------------------------------------------------------------------    ");
                                                    }
                                                }

                                                if (VC.Igualdad(icolumnaAMC, ifilaBMC) == 0 && SiMatrizA == true && SiMatrizB == true)
                                                {
                                                    volvervolver = false;

                                                    MC03 = new float[ifilaAMC, icolumnaBMC];

                                                    for (int iA = 0; iA < ifilaAMC; iA++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int jA = 0; jA < icolumnaBMC; jA++)
                                                        {
                                                            float suma = 0;
                                                            float sumaaux = 0;
                                                            for (int jB = 0; jB < icolumnaAMC; jB++)
                                                            {
                                                                sumaaux = OC.Multiplicar(MC01[iA, jB], MC02[jB, jA]);
                                                                suma = suma + sumaaux;
                                                            }
                                                            MC03[iA, jA] = suma;

                                                        }

                                                    }
                                                    AgregarMatrizCompuestaResultado(ifilaAMC, icolumnaBMC);
                                                    ImprimirMatrizCompuestaEspecifica(numerocodigoAuxMC);

                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                    Console.WriteLine("Warning: El tamaño del valor de las matrices no permite la operacion o no fue encontrada");
                                                    Console.ReadLine();

                                                }

                                                volvervolver = false;
                                                break;
                                            }
                                        case "1":
                                            {
                                                bool SiMatrizA = false;
                                                bool SiMatrizB = false;
                                                //ESCALAR
                                                do
                                                {
                                                    volver = false;
                                                    Console.WriteLine(" Escriba el numero a multiplicar");
                                                    string numeromatriz = Console.ReadLine();
                                                    int cantidad = numeromatriz.Length;
                                                    if (VC.Contador(cantidad, numeromatriz) == 0)
                                                    {
                                                        volver = false;
                                                        float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                                                        inumeromatriz = (float)Math.Round(inumeromatriz, 2);
                                                        escalarAMC = inumeromatriz;
                                                        SiMatrizA = true;
                                                    }
                                                    else
                                                    {
                                                        SiMatrizA = false;
                                                        volver = true;
                                                    }
                                                } while (volver != false);

                                                //MATRIZ B
                                                if (SiMatrizA == true)
                                                {
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        do
                                                        {
                                                            volvervolver = false;
                                                            Console.WriteLine(" Escriba el codigo de la MATRIZ B que desea sumar");
                                                            string numerosho = Console.ReadLine();

                                                            int cantidad = numerosho.Length;
                                                            if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                            {
                                                                volvervolver = false;
                                                                numerocodigoAuxMC = Convert.ToInt32(numerosho); // convierte a int
                                                            }
                                                            else
                                                            {
                                                                volvervolver = true;
                                                            }
                                                        } while (volvervolver != false);

                                                        if (BuscarMatrizCompuesta(numerocodigoAuxMC) != 0)
                                                        {
                                                            SiMatrizB = false;
                                                            bool volvers = false;

                                                            do
                                                            {
                                                                volvervolver = false;

                                                                Console.WriteLine("¿Quiere intentar otro codigo?");
                                                                Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                                opcion = Console.ReadLine();

                                                                switch (opcion)
                                                                {
                                                                    case "0":
                                                                        volvervolver = false;
                                                                        volvers = false;
                                                                        break;
                                                                    case "1":
                                                                        volvervolver = false;
                                                                        volvers = true;
                                                                        break;
                                                                    default:
                                                                        Console.WriteLine(" Opcion invalida");
                                                                        volvervolver = true;
                                                                        break;

                                                                }

                                                            } while (volvervolver != false);

                                                            if (volvers == false)
                                                            {
                                                                volvervolver = true;
                                                            }
                                                            else
                                                            {
                                                                volvervolver = false;
                                                            }

                                                        }
                                                        else
                                                        {
                                                            SiMatrizB = true;
                                                        }
                                                    } while (volvervolver != false);
                                                    ifilaBMC = ifilaAuxMC;
                                                    icolumnaBMC = icolumnaAuxMC;
                                                    MC02 = new float[ifilaBMC, icolumnaBMC];
                                                    if (SiMatrizB == true)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                                        Console.WriteLine(" MATRIZ B");
                                                        Console.WriteLine(" Codigo: " + numerocodigoAuxMC + "  Con filas: " + ifilaBMC + "  Con Columnas: " + icolumnaBMC);

                                                        for (int i = 0; i < ifilaBMC; i++)
                                                        {
                                                            Console.Write("\n");
                                                            for (int j = 0; j < icolumnaBMC; j++)
                                                            {
                                                                MC02[i, j] = MCAux[i, j];
                                                                Console.Write(MC02[i, j] + "   ");
                                                            }
                                                        }
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        Console.WriteLine("\n");
                                                        Console.WriteLine("   -------------------------------------------------------------------    ");
                                                    }
                                                }

                                                if (SiMatrizA == true && SiMatrizB == true)
                                                {
                                                    volvervolver = false;

                                                    MC03 = new float[ifilaBMC, icolumnaBMC];

                                                    for (int iA = 0; iA < ifilaBMC; iA++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int jA = 0; jA < icolumnaBMC; jA++)
                                                        {
                                                            float MatricionaB = MC02[iA, jA];
                                                            MC03[iA, jA] = OC.Multiplicar(escalarAMC, MatricionaB);

                                                        }

                                                    }
                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                    Console.WriteLine("Warning: El tamaño del valor de las matrices no permite la operacion o no fue encontrada");
                                                    Console.ReadLine();

                                                }

                                                volvervolver = false;
                                                break;
                                            }
                                        case "2":
                                            {
                                                bool SiMatrizA = false;
                                                bool SiMatrizB = false;
                                                //MATRIZ A
                                                do
                                                {
                                                    volvervolver = false;
                                                    do
                                                    {
                                                        volvervolver = false;
                                                        Console.WriteLine(" Escriba el codigo de la MATRIZ A que desea sumar");
                                                        string numerosho = Console.ReadLine();

                                                        int cantidad = numerosho.Length;
                                                        if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                                        {
                                                            volvervolver = false;
                                                            numerocodigoAuxMC = Convert.ToInt32(numerosho); // convierte a int
                                                        }
                                                        else
                                                        {
                                                            volvervolver = true;
                                                        }
                                                    } while (volvervolver != false);

                                                    if (BuscarMatrizCompuesta(numerocodigoAuxMC) != 0)
                                                    {
                                                        SiMatrizA = false;
                                                        bool volvers = false;

                                                        do
                                                        {
                                                            volvervolver = false;

                                                            Console.WriteLine("¿Quiere intentar otro codigo?");
                                                            Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                                            opcion = Console.ReadLine();

                                                            switch (opcion)
                                                            {
                                                                case "0":
                                                                    volvervolver = false;
                                                                    volvers = false;
                                                                    break;
                                                                case "1":
                                                                    volvervolver = false;
                                                                    volvers = true;
                                                                    SiMatrizA = false;
                                                                    break;
                                                                default:
                                                                    Console.WriteLine(" Opcion invalida");
                                                                    volvervolver = true;
                                                                    break;

                                                            }

                                                        } while (volvervolver != false);

                                                        if (volvers == false)
                                                        {
                                                            volvervolver = true;
                                                        }
                                                        else
                                                        {
                                                            volvervolver = false;
                                                        }

                                                    }
                                                    else
                                                    {
                                                        SiMatrizA = true;
                                                    }
                                                } while (volvervolver != false);
                                                ifilaAMC = ifilaAuxMC;
                                                icolumnaAMC = icolumnaAuxMC;
                                                MC01 = new float[ifilaAMC, icolumnaAMC];
                                                if (SiMatrizA == true)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                                    Console.WriteLine(" MATRIZ A");
                                                    Console.WriteLine(" Codigo: " + numerocodigoAuxMC + "  Con filas: " + ifilaAMC + "  Con Columnas: " + icolumnaAMC);

                                                    for (int i = 0; i < ifilaAMC; i++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int j = 0; j < icolumnaAMC; j++)
                                                        {
                                                            MC01[i, j] = MCAux[i, j];
                                                            Console.Write(MC01[i, j] + "   ");
                                                        }
                                                    }
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("\n");
                                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                                }

                                                //ESCALAR B
                                                if (SiMatrizA == true)
                                                {
                                                    do
                                                    {
                                                        volver = false;
                                                        Console.WriteLine(" Escriba el numero a multiplicar");
                                                        string numeromatriz = Console.ReadLine();
                                                        int cantidad = numeromatriz.Length;
                                                        if (VC.Contador(cantidad, numeromatriz) == 0)
                                                        {
                                                            volver = false;
                                                            float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                                                            inumeromatriz = (float)Math.Round(inumeromatriz, 2);
                                                            escalarBMC = inumeromatriz;
                                                            SiMatrizB = true;
                                                        }
                                                        else
                                                        {
                                                            SiMatrizB = false;
                                                            volver = true;
                                                        }
                                                    } while (volver != false);
                                                }

                                                if (SiMatrizA == true && SiMatrizB == true)
                                                {
                                                    volvervolver = false;

                                                    MC03 = new float[ifilaAMC, icolumnaAMC];

                                                    for (int iA = 0; iA < ifilaAMC; iA++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int jA = 0; jA < icolumnaAMC; jA++)
                                                        {
                                                            float MatriciosaA = MC01[iA, jA];
                                                            MC03[iA, jA] = OC.Multiplicar(MatriciosaA, escalarBMC);

                                                        }

                                                    }


                                                    AgregarMatrizCompuestaResultado(ifilaAMC, icolumnaAMC);
                                                    ImprimirMatrizCompuestaEspecifica(numerocodigoAuxMC);

                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                    Console.WriteLine("Warning: El tamaño del valor de las matrices no permite la operacion o no fue encontrada");
                                                    Console.ReadLine();

                                                }

                                                volvervolver = false;
                                                break;
                                            }
                                        default:
                                            Console.WriteLine(" Opcion invalida");
                                            volvervolver = true;
                                            break;
                                    }

                                } while (volvervolver != false);
                            }
                            volvervolver = true;
                            break;
                        }
                    case "7":
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                            Console.WriteLine("║                     MATRIZ COMPUESTA TRANSPUESTA                      ║ ");
                            Console.WriteLine("║                                                                       ║ ");

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("║              SIGA POR FAVOR LAS INSTRUCCIONES SIGUIENTES              ║ ");
                            Console.WriteLine("║                                                                       ║ ");
                            Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");


                            if (inicioMC == null)
                            {
                                volvervolver = true;
                                Console.WriteLine("Warning: Aun no se agregan datos suficientes para la operacion");
                                Console.ReadLine();
                            }
                            else
                            {
                                bool SiMatrizA = false;
                                bool SiMatrizB = false;
                                //MATRIZ A
                                do
                                {
                                    volvervolver = false;
                                    do
                                    {
                                        volvervolver = false;
                                        Console.WriteLine(" Escriba el codigo de la MATRIZ A que desea realizar a TRANSPUESTA");
                                        string numerosho = Console.ReadLine();

                                        int cantidad = numerosho.Length;
                                        if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                        {
                                            volvervolver = false;
                                            numerocodigoAuxMC = Convert.ToInt32(numerosho); // convierte a int
                                        }
                                        else
                                        {
                                            volvervolver = true;
                                        }
                                    } while (volvervolver != false);

                                    if (BuscarMatrizCompuesta(numerocodigoAuxMC) != 0)
                                    {
                                        SiMatrizA = false;
                                        bool volvers = false;

                                        do
                                        {
                                            volvervolver = false;

                                            Console.WriteLine("¿Quiere intentar otro codigo?");
                                            Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                            opcion = Console.ReadLine();

                                            switch (opcion)
                                            {
                                                case "0":
                                                    volvervolver = false;
                                                    volvers = false;
                                                    break;
                                                case "1":
                                                    volvervolver = false;
                                                    volvers = true;
                                                    SiMatrizA = false;
                                                    break;
                                                default:
                                                    Console.WriteLine(" Opcion invalida");
                                                    volvervolver = true;
                                                    break;

                                            }

                                        } while (volvervolver != false);

                                        if (volvers == false)
                                        {
                                            volvervolver = true;
                                        }
                                        else
                                        {
                                            volvervolver = false;
                                        }

                                    }
                                    else
                                    {
                                        SiMatrizA = true;
                                    }
                                } while (volvervolver != false);

                                ifilaAMC = ifilaAuxMC;
                                icolumnaAMC = icolumnaAuxMC;
                                MC01 = new float[ifilaAMC, icolumnaAMC];
                                if (SiMatrizA == true)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                    Console.WriteLine(" MATRIZ A");
                                    Console.WriteLine(" Codigo: " + numerocodigoAuxMC + "  Con filas: " + ifilaAMC + "  Con Columnas: " + icolumnaAMC);

                                    for (int i = 0; i < ifilaAMC; i++)
                                    {
                                        Console.Write("\n");
                                        for (int j = 0; j < icolumnaAMC; j++)
                                        {
                                            MC01[i, j] = MCAux[i, j];
                                            Console.Write(MC01[i, j] + "   ");
                                        }
                                    }
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("\n");
                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                }

                                if (SiMatrizA == true)
                                {
                                    volvervolver = false;
                                    MC03 = new float[icolumnaAMC, ifilaAMC];

                                    for (int iA = 0; iA < icolumnaAMC; iA++)
                                    {
                                        Console.Write("\n");
                                        for (int jA = 0; jA < ifilaAMC; jA++)
                                        {

                                            MC03[iA, jA] = MC01[jA, iA];
                                        }

                                    }
                                    AgregarMatrizCompuestaResultado(icolumnaAMC, ifilaAMC);
                                    ImprimirMatrizCompuestaEspecifica(numerocodigoAuxMC);

                                }
                                else
                                {
                                    volvervolver = true;
                                    Console.WriteLine("Warning: El tamaño del valor de las matrices no permite la operacion o no fue encontrada");
                                    Console.ReadLine();

                                }
                            }

                            volvervolver = true;
                            break;
                        }
                    case "8":
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                            Console.WriteLine("║                         OPERACION  CON PUNTO                          ║ ");
                            Console.WriteLine("║                                                                       ║ ");

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("║              SIGA POR FAVOR LAS INSTRUCCIONES SIGUIENTES              ║ ");
                            Console.WriteLine("║                                                                       ║ ");
                            Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");


                            if (inicioMC == null)
                            {
                                volvervolver = true;
                                Console.WriteLine("Warning: Aun no se agregan datos suficientes para la operacion");
                                Console.ReadLine();
                            }
                            else
                            {
                                bool SiMatrizA = false;
                                bool SiMatrizB = false;
                                //MATRIZ A


                                do
                                {
                                    volvervolver = false;
                                    do
                                    {
                                        volvervolver = false;
                                        Console.WriteLine(" Escriba el codigo de la MATRIZ A que desea realizar operacion");
                                        string numerosho = Console.ReadLine();

                                        int cantidad = numerosho.Length;
                                        if (VC.Contador(cantidad, numerosho) == 0 && VC.Ceros(numerosho) == 0)
                                        {
                                            volvervolver = false;
                                            numerocodigoAuxMC = Convert.ToInt32(numerosho); // convierte a int
                                        }
                                        else
                                        {
                                            volvervolver = true;
                                        }
                                    } while (volvervolver != false);

                                    if (BuscarMatrizCompuesta(numerocodigoAuxMC) != 0)
                                    {
                                        SiMatrizA = false;
                                        bool volvers = false;

                                        do
                                        {
                                            volvervolver = false;

                                            Console.WriteLine("¿Quiere intentar otro codigo?");
                                            Console.WriteLine("Escriba 0 para volver a intentar o 1 para salir");
                                            opcion = Console.ReadLine();

                                            switch (opcion)
                                            {
                                                case "0":
                                                    volvervolver = false;
                                                    volvers = false;
                                                    break;
                                                case "1":
                                                    volvervolver = false;
                                                    volvers = true;
                                                    SiMatrizA = false;
                                                    break;
                                                default:
                                                    Console.WriteLine(" Opcion invalida");
                                                    volvervolver = true;
                                                    break;

                                            }

                                        } while (volvervolver != false);

                                        if (volvers == false)
                                        {
                                            volvervolver = true;
                                        }
                                        else
                                        {
                                            volvervolver = false;
                                        }

                                    }
                                    else
                                    {
                                        SiMatrizA = true;
                                    }
                                } while (volvervolver != false);

                                ifilaAMC = ifilaAuxMC;
                                icolumnaAMC = icolumnaAuxMC;
                                MC01 = new float[ifilaAMC, icolumnaAMC];
                                if (SiMatrizA == true)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                    Console.WriteLine(" MATRIZ A");
                                    Console.WriteLine(" Codigo: " + numerocodigoAuxMC + "  Con filas: " + ifilaAMC + "  Con Columnas: " + icolumnaAMC);

                                    for (int i = 0; i < ifilaAMC; i++)
                                    {
                                        Console.Write("\n");
                                        for (int j = 0; j < icolumnaAMC; j++)
                                        {
                                            MC01[i, j] = MCAux[i, j];
                                            Console.Write(MC01[i, j] + "   ");
                                        }
                                    }
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("\n");
                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                }

                                //MATRIZ B
                                if (SiMatrizA == true)
                                {

                                    ifilaBMC = 4;
                                    icolumnaBMC = 4;
                                    MC02 = new float[ifilaBMC, icolumnaBMC];

                                    int filosha = 1;
                                    int columnosha = 4;

                                    MC05 = new float[filosha, columnosha];

                                    // LLENA LA MATRIZ DE DATOS
                                    for (int i = 0; i < filosha; i++)
                                    {
                                        for (int j = 0; j < columnosha; j++)
                                        {
                                            do
                                            {
                                                volver = false;
                                                Console.WriteLine(" Escribe el numero que ira en el punto posicion:" + "[" + i + " , " + j + "]");
                                                string numeromatriz = Console.ReadLine();
                                                int cantidad = numeromatriz.Length;
                                                if (VC.Contador(cantidad, numeromatriz) == 0)
                                                {
                                                    volver = false;
                                                    ///float inumeromatriz = Convert.ToInt32(numeromatriz); // convierte a int
                                                    float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                                                    inumeromatriz = (float)Math.Round(inumeromatriz, 2);
                                                    MC05[i, j] = inumeromatriz;
                                                }
                                                else
                                                {
                                                    volver = true;
                                                }
                                            } while (volver != false);
                                        }
                                    }

                                    MC02[0, 0] = MC05[0, 0];
                                    MC02[0, 1] = 0;
                                    MC02[0, 2] = 0;
                                    MC02[0, 3] = 0;

                                    MC02[1, 0] = 0;
                                    MC02[1, 1] = MC05[0, 1];
                                    MC02[1, 2] = 0;
                                    MC02[1, 3] = 0;

                                    MC02[2, 0] = 0;
                                    MC02[2, 1] = 0;
                                    MC02[2, 2] = MC05[0, 2];
                                    MC02[2, 3] = 0;

                                    MC02[3, 0] = 0;
                                    MC02[3, 1] = 0;
                                    MC02[3, 2] = 0;
                                    MC02[3, 3] = MC05[0, 3];
                                    SiMatrizB = true;

                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine(" PUNTO");
                                    Console.WriteLine("Con filas: " + filosha + "  Con Columnas: " + columnosha);

                                    for (int i = 0; i < filosha; i++)
                                    {
                                        Console.Write("\n");
                                        for (int j = 0; j < columnosha; j++)
                                        {
                                            Console.Write(MC05[i, j] + "   ");
                                        }
                                    }
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("\n");
                                    Console.WriteLine("   -------------------------------------------------------------------    ");

                                }


                                do
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine(" ");
                                    Console.WriteLine("¿QUE OPERACION HARAS? 0. SUMA | 1. RESTA | 2. MULTIPLICACION");
                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("¿Que opcion elige?                                                        ");
                                    opcion = Console.ReadLine();
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                    Console.ForegroundColor = ConsoleColor.White;


                                    switch (opcion)
                                    {
                                        case "0":
                                            {
                                                if (VC.Igualdad(ifilaAMC, ifilaBMC) == 0 && VC.Igualdad(icolumnaAMC, icolumnaBMC) == 0 && SiMatrizA == true && SiMatrizB == true)
                                                {
                                                    volvervolver = false;

                                                    int numeroFila = 1;
                                                    int numeroColumna = 4;
                                                    MC03 = new float[numeroFila, numeroColumna];
                                                    MC04 = new float[ifilaAMC, icolumnaBMC];

                                                    for (int iA = 0; iA < ifilaAMC; iA++)
                                                    {
                                                        for (int jA = 0; jA < icolumnaAMC; jA++)
                                                        {

                                                            float MatriciosaA = MC01[iA, jA];
                                                            float MatricionaB = MC02[iA, jA];

                                                            MC04[iA, jA] = OC.Sumar(MatriciosaA, MatricionaB);


                                                        }

                                                    }

                                                    float sumaAUXMC = 0;

                                                    for (int iA = 0; iA < 4; iA++)
                                                    {
                                                        sumaAUXMC = 0;
                                                        Console.Write("\n");
                                                        for (int jA = 0; jA < 4; jA++)
                                                        {
                                                            sumaAUXMC = OC.Sumar(sumaAUXMC, MC04[iA, jA]);

                                                        }
                                                        MC03[0, iA] = sumaAUXMC;
                                                    }


                                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                    Console.WriteLine(" PUNTO RESULTANTE");
                                                    Console.WriteLine("  Con filas: " + 1 + "  Con Columnas: " + 3);
                                                    Console.ForegroundColor = ConsoleColor.White;

                                                    for (int i = 0; i < numeroFila; i++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int j = 0; j < 3; j++)
                                                        {
                                                            Console.Write(MC03[i, j] + "   ");
                                                        }
                                                    }
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("\n");
                                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                                    Console.ReadLine();
                                                    break;

                                                }
                                                else
                                                {
                                                    Console.WriteLine("Warning: El tamaño del valor de las matrices no permite la operacion o no fue encontrada");
                                                    Console.ReadLine();
                                                }
                                                volvervolver = false;
                                                break;
                                            }
                                        case "1":
                                            {
                                                if (VC.Igualdad(ifilaAMC, ifilaBMC) == 0 && VC.Igualdad(icolumnaAMC, icolumnaBMC) == 0 && SiMatrizA == true && SiMatrizB == true)
                                                {
                                                    volvervolver = false;

                                                    int numeroFila = 1;
                                                    int numeroColumna = 4;
                                                    MC03 = new float[numeroFila, numeroColumna];
                                                    MC04 = new float[ifilaAMC, icolumnaBMC];

                                                    for (int iA = 0; iA < ifilaAMC; iA++)
                                                    {
                                                        for (int jA = 0; jA < icolumnaAMC; jA++)
                                                        {

                                                            float MatriciosaA = MC01[iA, jA];
                                                            float MatricionaB = MC02[iA, jA];

                                                            MC04[iA, jA] = OC.Restar(MatriciosaA, MatricionaB);


                                                        }

                                                    }

                                                    float sumaAUXMC = 0;

                                                    for (int iA = 0; iA < 4; iA++)
                                                    {
                                                        sumaAUXMC = 0;
                                                        Console.Write("\n");
                                                        for (int jA = 0; jA < 4; jA++)
                                                        {
                                                            sumaAUXMC = OC.Sumar(sumaAUXMC, MC04[iA, jA]);

                                                        }
                                                        MC03[0, iA] = sumaAUXMC;
                                                    }


                                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                    Console.WriteLine(" PUNTO RESULTANTE");
                                                    Console.WriteLine("  Con filas: " + 1 + "  Con Columnas: " + 3);
                                                    Console.ForegroundColor = ConsoleColor.White;

                                                    for (int i = 0; i < numeroFila; i++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int j = 0; j < 3; j++)
                                                        {
                                                            Console.Write(MC03[i, j] + "   ");
                                                        }
                                                    }
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("\n");
                                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                                    Console.ReadLine();
                                                    break;

                                                }
                                                else
                                                {
                                                    Console.WriteLine("Warning: El tamaño del valor de las matrices no permite la operacion o no fue encontrada");
                                                    Console.ReadLine();
                                                }
                                                volvervolver = false;
                                                break;
                                            }
                                        case "2":
                                            {
                                                if (VC.Igualdad(icolumnaAMC, ifilaBMC) == 0 && SiMatrizA == true && SiMatrizB == true)
                                                {
                                                    volvervolver = false;

                                                    int numeroFila = 1;
                                                    int numeroColumna = 4;
                                                    MC03 = new float[numeroFila, numeroColumna];
                                                    MC04 = new float[ifilaAMC, icolumnaBMC];

                                                    for (int iA = 0; iA < ifilaAMC; iA++)
                                                    {
                                                        for (int jA = 0; jA < icolumnaBMC; jA++)
                                                        {
                                                            float suma = 0;
                                                            float sumaaux = 0;
                                                            for (int jB = 0; jB < icolumnaAMC; jB++)
                                                            {
                                                                sumaaux = OC.Multiplicar(MC01[iA, jB], MC02[jB, jA]);
                                                                suma = suma + sumaaux;
                                                            }
                                                            MC04[iA, jA] = suma;

                                                        }

                                                    }

                                                    float sumaAUXMC = 0;

                                                    for (int iA = 0; iA < 4; iA++)
                                                    {
                                                        sumaAUXMC = 0;
                                                        Console.Write("\n");
                                                        for (int jA = 0; jA < 4; jA++)
                                                        {
                                                            sumaAUXMC = OC.Sumar(sumaAUXMC, MC04[iA, jA]);

                                                        }
                                                        MC03[0, iA] = sumaAUXMC;
                                                    }

                                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                    Console.WriteLine(" PUNTO RESULTANTE");
                                                    Console.WriteLine("  Con filas: " + 1 + "  Con Columnas: " + 3);
                                                    Console.ForegroundColor = ConsoleColor.White;

                                                    for (int i = 0; i < numeroFila; i++)
                                                    {
                                                        Console.Write("\n");
                                                        for (int j = 0; j < 3; j++)
                                                        {
                                                            Console.Write(MC03[i, j] + "   ");
                                                        }
                                                    }
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("\n");
                                                    Console.WriteLine("   -------------------------------------------------------------------    ");
                                                    Console.ReadLine();

                                                }
                                                else
                                                {
                                                    volvervolver = true;
                                                    Console.WriteLine("Warning: El tamaño del valor de las matrices no permite la operacion o no fue encontrada");
                                                    Console.ReadLine();

                                                }

                                                volvervolver = false;
                                                break;
                                            }
                                        default:
                                            Console.WriteLine(" Opcion invalida");
                                            volvervolver = true;
                                            break;
                                    }

                                } while (volvervolver != false);

                            }
                                
                            volvervolver = true;
                            break;
                        }
                    case "9":
                        {
                            volvervolver = false;
                            break;
                        }
                    default:
                        Console.WriteLine(" Opcion invalida");
                        volvervolver = true;
                        break;
                }

            } while (volvervolver != false);
        }

        public void AlgoritmoBresenham()
        {
            do
            {
                volvervolver = false;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                Console.WriteLine("║                        ALGORITMO BRESENHAM                            ║ ");
                Console.WriteLine("║                                                                       ║ ");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("║            INSERTE UN NUMERO SEGUN LA OPCION DESEADA DEL MENU         ║ ");
                Console.WriteLine("║ 1. Linea                         2. Circunferencia                    ║ ");
                Console.WriteLine("║ 3. Elipse                        4. Regresar                          ║ ");
                Console.WriteLine("║                                                                       ║ ");
                Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");


                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("   -------------------------------------------------------------------    ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("¿Que opcion elige?                                                        ");
                opcion = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("   -------------------------------------------------------------------    ");
                Console.ForegroundColor = ConsoleColor.White;

                switch (opcion)
                {
                    case "1":
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                            Console.WriteLine("║                   ALGORITMO BRESENHAM PARA LINEA                      ║ ");
                            Console.WriteLine("║                                                                       ║ ");

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("║              SIGA POR FAVOR LAS INSTRUCCIONES SIGUIENTES              ║ ");
                            Console.WriteLine("║                                                                       ║ ");
                            Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");

                            Console.WriteLine(" ");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine(" Favor de agregar los siguientes datos que se soliciten");
                            Console.WriteLine("   -------------------------------------------------------------------    ");
                            Console.ForegroundColor = ConsoleColor.White;


                            float xInicial = 0;
                            float yInicial = 0;
                            float xFinal = 0;
                            float yFinal = 0;

                            
                            do
                            {
                                volvervolver = false;
                                Console.WriteLine(" Punto inicial para x");
                                string numerosho = Console.ReadLine();

                                int cantidad = numerosho.Length;
                                if (VC.Contador(cantidad, numerosho) == 0)
                                {
                                    volvervolver = false;
                                    xInicial = (float)Convert.ToDouble(numerosho);
                                }
                                else
                                {
                                    volvervolver = true;
                                }
                            } while (volvervolver != false);

                            do
                            {
                                volvervolver = false;
                                Console.WriteLine(" Punto inicial para y");
                                string numerosho = Console.ReadLine();

                                int cantidad = numerosho.Length;
                                if (VC.Contador(cantidad, numerosho) == 0)
                                {
                                    volvervolver = false;
                                    yInicial = (float)Convert.ToDouble(numerosho);
                                }
                                else
                                {
                                    volvervolver = true;
                                }
                            } while (volvervolver != false);

                            do
                            {
                                volvervolver = false;
                                Console.WriteLine(" Punto final para x");
                                string numerosho = Console.ReadLine();

                                int cantidad = numerosho.Length;
                                if (VC.Contador(cantidad, numerosho) == 0)
                                {
                                    volvervolver = false;
                                    xFinal = (float)Convert.ToDouble(numerosho);
                                }
                                else
                                {
                                    volvervolver = true;
                                }
                            } while (volvervolver != false);

                            do
                            {
                                volvervolver = false;
                                Console.WriteLine(" Punto final para y");
                                string numerosho = Console.ReadLine();

                                int cantidad = numerosho.Length;
                                if (VC.Contador(cantidad, numerosho) == 0)
                                {
                                    volvervolver = false;
                                    yFinal = (float)Convert.ToDouble(numerosho);
                                }
                                else
                                {
                                    volvervolver = true;
                                }
                            } while (volvervolver != false);

                            if (xFinal > xInicial && yFinal > yInicial)
                            {
                                OC.BresenhamLinea(xInicial, yInicial, xFinal, yFinal);
                            }
                            else
                            {
                                Console.WriteLine("Warning: El tamaño del valor de los puntos no permite la operacion");
                                Console.ReadLine();
                            }

                            volvervolver = true;
                            break;
                        }
                    case "2":
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                            Console.WriteLine("║                ALGORITMO BRESENHAM PARA CIRCUNFERENCIA                ║ ");
                            Console.WriteLine("║                                                                       ║ ");

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("║              SIGA POR FAVOR LAS INSTRUCCIONES SIGUIENTES              ║ ");
                            Console.WriteLine("║                                                                       ║ ");
                            Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");

                            Console.WriteLine(" ");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine(" Favor de agregar los siguientes datos que se soliciten");
                            Console.WriteLine("   -------------------------------------------------------------------    ");
                            Console.ForegroundColor = ConsoleColor.White;


                            float origenX = 0;
                            float radioY = 0;
                            float enteroDecimal = 0;


                            do
                            {
                                volvervolver = false;
                                Console.WriteLine(" Escribe el punto ORIGEN para la circunferencia");
                                string numerosho = Console.ReadLine();

                                int cantidad = numerosho.Length;

                                for (int i = 0; i < numerosho.Length; i++)
                                {
                                    if (numerosho[i] == '.')
                                    {
                                        enteroDecimal = 1;
                                    }
                                    else
                                    {
                                        enteroDecimal = 0;
                                    }
                                }

                                if (VC.Contador(cantidad, numerosho) == 0)
                                {
                                    volvervolver = false;
                                    origenX = (float)Convert.ToDouble(numerosho);
                                }
                                else
                                {
                                    volvervolver = true;
                                }
                            } while (volvervolver != false);

                            do
                            {
                                volvervolver = false;
                                Console.WriteLine(" Escribe el RADIO para la circunferencia");
                                string numerosho = Console.ReadLine();

                                int cantidad = numerosho.Length;
                                if (VC.Contador(cantidad, numerosho) == 0)
                                {
                                    volvervolver = false;
                                    radioY = (float)Convert.ToDouble(numerosho);
                                }
                                else
                                {
                                    volvervolver = true;
                                }
                            } while (volvervolver != false);

                            if (radioY > origenX)
                            {
                                OC.BresenhamCircunferencia(origenX, radioY, enteroDecimal);
                            }
                            else
                            {
                                Console.WriteLine("Warning: El tamaño del valor de los puntos no permite la operacion");
                                Console.ReadLine();
                            }
                            


                            volvervolver = true;
                            break;
                        }
                    case "3":
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗ ");
                            Console.WriteLine("║                   ALGORITMO BRESENHAM PARA LA ELIPSE                  ║ ");
                            Console.WriteLine("║                                                                       ║ ");

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("║              SIGA POR FAVOR LAS INSTRUCCIONES SIGUIENTES              ║ ");
                            Console.WriteLine("║                                                                       ║ ");
                            Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝ ");

                            Console.WriteLine(" ");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine(" Favor de agregar los siguientes datos que se soliciten");
                            Console.WriteLine("   -------------------------------------------------------------------    ");
                            Console.ForegroundColor = ConsoleColor.White;


                            float radioX = 0;
                            float radioY = 0;


                            do
                            {
                                volvervolver = false;
                                Console.WriteLine(" Escribe el radio X para la elipse");
                                string numerosho = Console.ReadLine();

                                int cantidad = numerosho.Length;

                                if (VC.Contador(cantidad, numerosho) == 0)
                                {
                                    volvervolver = false;
                                    radioX = (float)Convert.ToDouble(numerosho);
                                }
                                else
                                {
                                    volvervolver = true;
                                }
                            } while (volvervolver != false);

                            do
                            {
                                volvervolver = false;
                                Console.WriteLine(" Escribe el radio Y para la elipse");
                                string numerosho = Console.ReadLine();

                                int cantidad = numerosho.Length;
                                if (VC.Contador(cantidad, numerosho) == 0)
                                {
                                    volvervolver = false;
                                    radioY = (float)Convert.ToDouble(numerosho);
                                }
                                else
                                {
                                    volvervolver = true;
                                }
                            } while (volvervolver != false);

                            int pan = 0;
                            if (pan == 0)
                            {
                                OC.BresenhamElipse(radioX, radioY);
                        }
                            else
                        {
                            Console.WriteLine("Warning: El tamaño del valor de los puntos no permite la operacion");
                            Console.ReadLine();
                        }



                        volvervolver = true;
                            break;
                        }
                    case "4":
                        {
                            volvervolver = false;
                            break;
                        }
                    default:
                        Console.WriteLine(" Opcion invalida");
                        volvervolver = true;
                        break;
                }

            } while (volvervolver != false);
        }





    }








    
}
