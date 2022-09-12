using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Text.Json.Serialization;

namespace CalculadoraMatrices
{
    class ListaConfiguracion
    {
        public Validaciones VC = new Validaciones();


        // AUXILIARES
        
        public string opcion;
        public bool validacionbusqueda;
        public bool volvervolver = false;
        public bool volver = false;

        // |||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

        // AUXILIARES MATRIZ
        public int ifila = 0;
        public int icolumna = 0;
        public int ifilaAux;
        public int icolumnaAux;
        public int ifilaA;
        public int icolumnaA;
        public int ifilaB;
        public int icolumnaB;
        public float escalarA;
        public float escalarB;
        public int numerocodigoAux;
        public float[,] MatrizAux;
        public float[,] Matriz01;
        public float[,] Matriz02;
        public float[,] Matriz03;
        public bool productuosocruz = false;

        // LISTA CONFIGURACION MATRIZ
        public class MatrizNodo
        {
            public MatrizNodo antMN;
            public int ifilaMN;
            public int icolumnaMN;
            public float[,] MatrizMN;
            public int CodigoMN;
            public MatrizNodo sigMN;
        }
        private MatrizNodo INICIOMN;
        private MatrizNodo FINMN;
        private MatrizNodo NUEVOMN;
        private MatrizNodo AUXMN;
        private MatrizNodo ELIMINARMN;
        public int numerocodigoMN;

        // |||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

        // AUXILIARES CUATERNIOS
        public string letraCN = " ";
        public int ifilaCN = 0;
        public int icolumnaCN = 0;
        public int ifilaAuxCN;
        public int icolumnaAuxCN;
        public int ifilaACN;
        public int icolumnaACN;
        public int ifilaBCN;
        public int icolumnaBCN;
        public float escalarACN;
        public float escalarBCN;
        public int numerocodigoAuxCN;
        public float[,] CuaternioAux;
        public float[,] Cuaternio01;
        public float[,] Cuaternio02;
        public float[,] Cuaternio03;

        // LISTA CONFIGURACION CUATERNIOS
        public class CuaternioNodo
        {
            public CuaternioNodo antCN;
            public int ifilaCN;
            public int icolumnaCN;
            public float[,] CuaternioCN;
            public int CodigoCN;
            public CuaternioNodo sigCN;
        }
        private CuaternioNodo INICIOCN;
        private CuaternioNodo FINCN;
        private CuaternioNodo NUEVOCN;
        private CuaternioNodo AUXCN;
        private CuaternioNodo ELIMINARCN;
        public int numerocodigoCN;

        // |||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

        // AUXILIARES TRASLACION_ROTACION_ESCALAR
        public int ifilaTRE = 0;
        public int icolumnaTRE = 0;
        public int ifilaAuxTRE;
        public int icolumnaAuxTRE;
        public int ifilaATRE;
        public int icolumnaATRE;
        public int ifilaBTRE;
        public int icolumnaBTRE;
        public float xyzTRE;
        public float escalarATRE;
        public float escalarBTRE;
        public float escalarCTRE;
        public int numerocodigoAuxTRE;
        public float[,] TREAux;
        public float[,] TRE01;
        public float[,] TRE02;
        public float[,] TRE03;
        public bool productuosocruzTRE = false;

        // LISTA CONFIGURACION TRASLACION_ROTACION_ESCALAR
        public class TRENodo
        {
            public TRENodo antTRE;
            public int ifilaTRE;
            public int icolumnaTRE;
            public float[,] PuntoTRE;
            public int CodigoTRE;
            public TRENodo sigTRE;
        }
        private TRENodo INICIOTRE;
        private TRENodo FINTRE;
        private TRENodo NUEVOTRE;
        private TRENodo AUXTRE;
        private TRENodo ELIMINARTRE;
        public int numerocodigoTRE;

        // |||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

        // AUXILIARES VECTORES
        public int ifilaVEC = 0;
        public int icolumnaVEC = 0;
        public int ifilaAuxVEC;
        public int icolumnaAuxVEC;
        public int ifilaAVEC;
        public int icolumnaAVEC;
        public int ifilaBVEC;
        public int icolumnaBVEC;
        public float escalarAVEC;
        public float escalarBVEC;
        public int numerocodigoAuxVEC;
        public float[,] VECAux;
        public float[,] VEC01;
        public float[,] VEC02;
        public float[,] VEC03;
        public bool productuosocruzVEC = false;

        // LISTA CONFIGURACION VECTORES
        public class VECNodo
        {
            public VECNodo antVEC;
            public int ifilaVEC;
            public int icolumnaVEC;
            public float[,] MatrizVEC;
            public int CodigoVEC;
            public VECNodo sigVEC;
        }
        private VECNodo INICIOVEC;
        private VECNodo FINVEC;
        private VECNodo NUEVOVEC;
        private VECNodo AUXVEC;
        private VECNodo ELIMINARVEC;
        public int numerocodigoVEC;

        // |||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

        // AUXILIARES MATRIZ COMPUESTA
        public int ifilaMC = 0;
        public int icolumnaMC = 0;
        public int ifilaAuxMC;
        public int icolumnaAuxMC;
        public int ifilaAMC;
        public int icolumnaAMC;
        public int ifilaBMC;
        public int icolumnaBMC;
        public float escalarAMC;
        public float escalarBMC;
        public int numerocodigoAuxMC;
        public float[,] MCAux;
        public float[,] MC01;
        public float[,] MC02;
        public float[,] MC03;
        public float[,] MC04;
        public float[,] MC05;
        public bool productuosocruzMC = false;

        // LISTA CONFIGURACION MATRIZ COMPUESTA
        public class MCNodo
        {
            public MCNodo antMC;
            public int ifilaMC;
            public int icolumnaMC;
            public int ifilaPuntoMC;
            public int icolumnaPuntoMC;
            public float TipoOperacionMC;
            public float RotxyzMC;
            public float AnguloMC;
            public float[,] MatrizMC;
            public float[,] PuntoMC;
            public int CodigoMC;
            public MCNodo sigMC;
        }
        private MCNodo INICIOMC;
        private MCNodo FINMC;
        private MCNodo NUEVOMC;
        private MCNodo AUXMC;
        private MCNodo ELIMINARMC;
        public int numerocodigoMC;

        // |||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

        // AUXILIARES ALGORITMO BRESENHAM
        public int ifilaAB = 0;
        public int icolumnaAB = 0;
        public int ifilaAuxAB;
        public int icolumnaAuxAB;
        public int ifilaAAB;
        public int icolumnaAAB;
        public int ifilaBAB;
        public int icolumnaBAB;
        public float escalarAAB;
        public float escalarBAB;
        public int numerocodigoAuxAB;
        public float[,] ABAux;
        public float[,] AB01;
        public float[,] AB02;
        public float[,] AB03;
        public bool productuosocruzAB = false;

        // LISTA CONFIGURACION ALGORITMO BRESENHAM
        public class ABNodo
        {
            public ABNodo antAB;
            public int ifilaAB;
            public int icolumnaAB;
            public float[,] MatrizAB;
            public int CodigoAB;
            public ABNodo sigAB;
        }
        private ABNodo INICIOAB;
        private ABNodo FINAB;
        private ABNodo NUEVOAB;
        private ABNodo AUXAB;
        private ABNodo ELIMINARAB;
        public int numerocodigoAB;







        






        public ListaConfiguracion()

        {
            //MATRIZ NODO
            inicioMN = null;
            finMN = null;
            nuevoMN = null;
            auxMN = null;
            eliminarMN = null;

            //CUATERNIOS NODO
            inicioCN = null;
            finCN = null;
            nuevoCN = null;
            auxCN = null;
            eliminarCN = null;

            //TRASLACION_ROTRACION_ESCALAR
            inicioTRE = null;
            finTRE = null;
            nuevoTRE = null;
            auxTRE = null;
            eliminarTRE = null;


        }



        // COMPONENTES PARA LA MATRIZ
        public MatrizNodo inicioMN
        {
            get { return INICIOMN; }
            set { INICIOMN = value; }
        }
        public MatrizNodo finMN
        {
            get { return FINMN; }
            set { FINMN = value; }
        }
        public MatrizNodo nuevoMN
        {
            get { return NUEVOMN; }
            set { NUEVOMN = value; }
        }
        public MatrizNodo auxMN
        {
            get { return AUXMN; }
            set { AUXMN = value; }
        }
        public MatrizNodo eliminarMN
        {
            get { return ELIMINARMN; }
            set { ELIMINARMN = value; }
        }        
        // FUNCIONES PARA LA MATRIZ
        public void AgregarMatriz()
        {
            nuevoMN = new MatrizNodo();
            ifila = 0;
            icolumna = 0;
            volver = false;

            //    icelula = Convert.ToInt32(scedula); // convierte a int


            // CONTADOR
            if (inicioMN == null)
            {
                nuevoMN.CodigoMN = 1;
                numerocodigoMN = nuevoMN.CodigoMN;
            }
            else
            {
                //auxMN = inicioMN;
                //while (auxMN != null)
                //{
                //    nuevoMN.CodigoMN = auxMN.CodigoMN + 1;
                //    auxMN = auxMN.sigMN;
                //}

                numerocodigoMN += 1;
                nuevoMN.CodigoMN = numerocodigoMN;
            }

            numerocodigoAux = numerocodigoMN;

            // FILAS
            do
            {
                volver = false;
                Console.WriteLine(" filas");
                string fila = Console.ReadLine();
                int cantidad = fila.Length;
                if (VC.Contador(cantidad, fila) == 0 && VC.Ceros(fila) == 0)
                {                    
                    ifila = Convert.ToInt32(fila); // convierte a int
                    if (ifila > 0)
                    {
                        volver = false;
                        nuevoMN.ifilaMN = ifila;
                    }
                    else
                    {
                        Console.WriteLine("Warning: Caracter invalido");
                        volver = true;
                    }
                }
                else
                {
                    volver = true;
                }
            } while (volver != false);

           // COLUMNAS
            do
            {
                volver = false;
                Console.WriteLine(" Columnas");
                string columna = Console.ReadLine();
                int cantidad = columna.Length;
                if (VC.Contador(cantidad, columna) == 0 && VC.Ceros(columna) == 0)
                {
                    icolumna = Convert.ToInt32(columna); // convierte a int
                    nuevoMN.icolumnaMN = icolumna;
                    if (icolumna > 0)
                    {
                        volver = false;
                        nuevoMN.icolumnaMN = icolumna;
                    }
                    else
                    {
                        Console.WriteLine("Warning: Caracter invalido");
                        volver = true;
                    }
                }
                else
                {
                    volver = true;
                }
            } while (volver != false);

            // LLENA LA MATRIZ DE DATOS
            nuevoMN.MatrizMN = new float[ifila, icolumna];
            for (int i = 0; i < ifila; i++)
            {
                for (int j = 0; j < icolumna; j++)
                {
                    do
                    {
                        volver = false;
                        Console.WriteLine(" Escribe el numero que ira en la matriz posicion:" + "[" + i + " , " + j + "]");
                        string numeromatriz = Console.ReadLine();
                        int cantidad = numeromatriz.Length;
                        if (VC.Contador(cantidad, numeromatriz) == 0)
                        {
                            volver = false;
                            ///float inumeromatriz = Convert.ToInt32(numeromatriz); // convierte a int
                            float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                            inumeromatriz = (float)Math.Round(inumeromatriz, 2);
                            nuevoMN.MatrizMN[i, j] = inumeromatriz;
                        }
                        else
                        {
                            volver = true;
                        }
                    } while (volver != false);
                }
            }


            if (inicioMN == null)
            {
                inicioMN = nuevoMN;
                finMN = inicioMN;
            }
            else
            {
                finMN.sigMN = nuevoMN;
                auxMN = finMN;
                finMN = finMN.sigMN;
                finMN.antMN = auxMN;
                finMN.sigMN = null;
            }

        }
        public void ImprimirMatriz()
        {
            auxMN = inicioMN;

            if (inicioMN == null)
            {
                Console.WriteLine("Warning: No se pudo imprimir");
                Console.WriteLine("Warning: No hay informacion que imprimir");
            }
            while (auxMN != null)
            {

                Console.WriteLine("-------------------------------------------------------------------    ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(" Codigo: " + auxMN.CodigoMN + "  Con filas: "+ auxMN.ifilaMN + "  Con Columnas: " + auxMN.icolumnaMN);
                Console.ForegroundColor = ConsoleColor.White;

                for (int i = 0; i < auxMN.ifilaMN; i++)
                {
                    Console.Write("\n");
                    for (int j = 0; j < auxMN.icolumnaMN; j++)
                    {
                        Console.Write(auxMN.MatrizMN[i, j] + "   ");
                    }
                }
                Console.WriteLine(" ");


                auxMN = auxMN.sigMN;
            }
            Console.ReadLine();
        }
        public int ImprimirMatrizEspecifica(int numerocodigoso)
        {
            validacionbusqueda = false;
            auxMN = inicioMN;
            while (auxMN != null)
            {
                if (auxMN.CodigoMN == numerocodigoso)
                {
                    validacionbusqueda = true;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(" Codigo: " + auxMN.CodigoMN + "  Con filas: " + auxMN.ifilaMN + "  Con Columnas: " + auxMN.icolumnaMN);
                    Console.ForegroundColor = ConsoleColor.White;

                    for (int i = 0; i < auxMN.ifilaMN; i++)
                    {
                        Console.Write("\n");
                        for (int j = 0; j < auxMN.icolumnaMN; j++)
                        {
                            if (productuosocruz == true)
                            {
                                string letraMN = " ";
                                switch (j)
                                {
                                    case 0:
                                        letraMN = "i";
                                        break;
                                    case 1:
                                        letraMN = "j";
                                        break;
                                    case 2:
                                        letraMN = "k";
                                        break;
                                    default:
                                        break;
                                }
                                Console.Write(auxMN.MatrizMN[i, j] + letraMN + "   ");
                            }
                            else
                            {
                                Console.Write(auxMN.MatrizMN[i, j] + "   ");
                            }
                        }
                    }
                    Console.ReadLine();
                    break;
                }
                else
                {
                    if (auxMN.sigMN == null)
                    {
                        validacionbusqueda = false;
                    }
                }

                auxMN = auxMN.sigMN;
            }

            if (validacionbusqueda == true)
            {
                return 0;
            }
            else
            {
                Console.WriteLine("Warning: No se pudo imprimir");
                Console.WriteLine("Warning: No se encontro la informacion buscada");
                Console.ReadLine();
                return 1;
            }
        }
        public int BuscarMatriz(int numerocodigoso)
        {

            validacionbusqueda = false;
            auxMN = inicioMN;
            while (auxMN != null)
            {
                if (auxMN.CodigoMN == numerocodigoso)
                {
                    validacionbusqueda = true;
                    MatrizAux = new float[auxMN.ifilaMN, auxMN.icolumnaMN];

                    ifilaAux = auxMN.ifilaMN;
                    icolumnaAux = auxMN.icolumnaMN;

                    for (int i = 0; i < auxMN.ifilaMN; i++)
                    {
                        for (int j = 0; j < auxMN.icolumnaMN; j++)
                        {
                            MatrizAux[i, j] = auxMN.MatrizMN[i, j];
                        }
                    }
                    Console.WriteLine(" ");
                    break;
                }
                else
                {
                   
                    if (auxMN.sigMN == null)
                    {
                        validacionbusqueda = false;
                        Console.ReadLine();
                    }
                }

                auxMN = auxMN.sigMN;
            }

            if (validacionbusqueda == true)
            {
                return 0;
            } 
            else
            {
                Console.WriteLine("Warning: No se encontro informacion disponible para la operacion");
                Console.ReadLine();
                return 1;
            }
        }
        public int EliminarMatriz(int numerocodigoso)
        {
            validacionbusqueda = false;
            auxMN = inicioMN;

            while (auxMN != null)
            {
                if (auxMN.CodigoMN == numerocodigoso)
                {
                    validacionbusqueda = true;
                    eliminarMN = new MatrizNodo();
                    eliminarMN = auxMN;

                    if (eliminarMN.sigMN == null && eliminarMN.antMN == null) // Solo esta el inicio
                    {
                        eliminarMN = inicioMN;
                        inicioMN = null;
                        auxMN = null;
                        eliminarMN = null;
                    }
                    else if (eliminarMN.antMN == null) // Eliminar nodo y no hay nada antes
                    {
                        //auxMN = auxMN.sigMN;
                        inicioMN = eliminarMN.sigMN;
                        inicioMN.sigMN = null;
                        inicioMN.antMN = null;
                        eliminarMN = null;
                    }
                    else if (eliminarMN.sigMN == null) // Eliminar nodo y no hay nada despues
                    {
                        auxMN = eliminarMN.antMN;
                        eliminarMN.antMN.sigMN = null;
                        finMN = auxMN;
                        eliminarMN = null;
                    }
                    else // Eliminar el de enmedio
                    {
                        auxMN = eliminarMN.antMN;
                        auxMN.sigMN = eliminarMN.sigMN;
                        eliminarMN.sigMN.antMN = auxMN;
                        eliminarMN = null;
                    }

                    Console.WriteLine("MATRIZ ELIMINADA");
                    Console.ReadLine();
                    break;

                }
                else
                {
                    if (auxMN.sigMN == null)
                    {
                        validacionbusqueda = false;
                    }
                }

                auxMN = auxMN.sigMN;
            }
            
            if (validacionbusqueda == true)
            {
                return 0;
            }
            else
            {
                Console.WriteLine("Warning: No se pudo eliminar");
                Console.WriteLine("Warning: No se encontro la informacion buscada");
                Console.ReadLine();
                return 1;
            }
        }
        public int ModificarMatriz(int numerocodigoso)
        {
            validacionbusqueda = false;
            auxMN = inicioMN;
            while (auxMN != null)
            {
                if (auxMN.CodigoMN == numerocodigoso)
                {

                    validacionbusqueda = true;
                    // FILAS
                    do
                    {
                        ifila = 0;
                        icolumna = 0;
                        volver = false;
                        Console.WriteLine(" filas");
                        string fila = Console.ReadLine();
                        int cantidad = fila.Length;
                        if (VC.Contador(cantidad, fila) == 0 && VC.Ceros(fila) == 0)
                        {
                            ifila = Convert.ToInt32(fila); // convierte a int
                            auxMN.ifilaMN = ifila;
                            if (ifila > 0)
                            {
                                volver = false;
                                nuevoMN.ifilaMN = ifila;
                            }
                            else
                            {
                                Console.WriteLine("Warning: Caracter invalido");
                                volver = true;
                            }

                        }
                        else
                        {
                            volver = true;
                        }
                    } while (volver != false);

                    // COLUMNAS
                    do
                    {
                        volver = false;
                        Console.WriteLine(" Columnas");
                        string columna = Console.ReadLine();
                        int cantidad = columna.Length;
                        if (VC.Contador(cantidad, columna) == 0 && VC.Ceros(columna) == 0)
                        {
                            icolumna = Convert.ToInt32(columna); // convierte a int
                            auxMN.icolumnaMN = icolumna;
                            if (icolumna > 0)
                            {
                                volver = false;
                                nuevoMN.icolumnaMN = icolumna;
                            }
                            else
                            {
                                Console.WriteLine("Warning: Caracter invalido");
                                volver = true;
                            }
                        }
                        else
                        {
                            volver = true;
                        }
                    } while (volver != false);

                    // LLENA LA MATRIZ DE DATOS
                    auxMN.MatrizMN = new float[ifila, icolumna];
                    for (int i = 0; i < ifila; i++)
                    {
                        for (int j = 0; j < icolumna; j++)
                        {
                            do
                            {
                                volver = false;
                                Console.WriteLine(" Escribe el numero que ira en la matriz posicion:" + "[" + i + " , " + j + "]");
                                string numeromatriz = Console.ReadLine();
                                int cantidad = numeromatriz.Length;
                                if (VC.Contador(cantidad, numeromatriz) == 0)
                                {
                                    volver = false;
                                    float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                                    inumeromatriz = (float)Math.Round(inumeromatriz, 2);
                                    auxMN.MatrizMN[i, j] = inumeromatriz;
                                }
                                else
                                {
                                    volver = true;
                                }
                            } while (volver != false);
                        }
                    }
                    Console.WriteLine(" ");
                    break;
                }
                else
                {

                    if (auxMN.sigMN == null)
                    {
                        validacionbusqueda = false;
                        Console.ReadLine();
                    }
                }

                auxMN = auxMN.sigMN;
            }

            if (validacionbusqueda == true)
            {
                return 0;
            }
            else
            {
                Console.WriteLine("Warning: No se encontro informacion disponible para la operacion");
                Console.ReadLine();
                return 1;
            }



        }
        public int ModificarMatrizEspecifica(int numerocodigoso)
        {
            validacionbusqueda = false;
            auxMN = inicioMN;
            while (auxMN != null)
            {
                if (auxMN.CodigoMN == numerocodigoso)
                {
                    // PIDE FILAS Y COLUMNAS PARA MODIFICAR
                    do
                    {
                        volvervolver = false;
                        Console.WriteLine(" Escriba la fila de la matriz que busca");
                        string numerosho = Console.ReadLine();

                        int cantidad = numerosho.Length;
                        if (VC.Contador(cantidad, numerosho) == 0)
                        {
                            volvervolver = false;
                            ifilaA = Convert.ToInt32(numerosho); // convierte a int
                        }
                        else
                        {
                            volvervolver = true;
                        }
                    } while (volvervolver != false);

                    do
                    {
                        volvervolver = false;
                        Console.WriteLine(" Escriba la columna de la matriz que busca");
                        string numerosho = Console.ReadLine();

                        int cantidad = numerosho.Length;
                        if (VC.Contador(cantidad, numerosho) == 0)
                        {
                            volvervolver = false;
                            icolumnaA = Convert.ToInt32(numerosho); // convierte a int
                        }
                        else
                        {
                            volvervolver = true;
                        }
                    } while (volvervolver != false);


                    auxMN = inicioMN;
                    while (auxMN != null)
                    {
                        if (auxMN.CodigoMN == numerocodigoso)
                        {
                            if (ifilaA < auxMN.ifilaMN && icolumnaA < auxMN.icolumnaMN)
                            {
                                validacionbusqueda = true;
                                for (int i = 0; i < auxMN.ifilaMN; i++)
                                {
                                    for (int j = 0; j < auxMN.icolumnaMN; j++)
                                    {

                                        if (ifilaA == i && icolumnaA == j)
                                        {
                                            do
                                            {
                                                volver = false;
                                                Console.WriteLine(" Escribe el numero que ira en la matriz posicion:" + "[" + i + " , " + j + "]");
                                                string numeromatriz = Console.ReadLine();
                                                int cantidad = numeromatriz.Length;
                                                if (VC.Contador(cantidad, numeromatriz) == 0)
                                                {
                                                    volver = false;
                                                    ///float inumeromatriz = Convert.ToInt32(numeromatriz); // convierte a int
                                                    float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                                                    inumeromatriz = (float)Math.Round(inumeromatriz, 2);
                                                    auxMN.MatrizMN[i, j] = inumeromatriz;


                                                    Console.WriteLine(" El numero que ira en la matriz posicion:" + "[" + i + " , " + j + "]" + " ahora sera: " + auxMN.MatrizMN[i, j] + "   ");
                                                    ImprimirMatrizEspecifica(auxMN.CodigoMN);
                                                    break;

                                                }
                                                else
                                                {
                                                    volver = true;
                                                }
                                            } while (volver != false);


                                        }


                                    }

                                }

                            }
                            else
                            {
                                validacionbusqueda = false;
                                break;
                            }

                            
                            break;
                        }
                        else
                        {
                            if (auxMN.sigMN == null)
                            {
                                validacionbusqueda = false;
                                Console.ReadLine();
                            }
                        }

                        auxMN = auxMN.sigMN;
                    }

                    if (validacionbusqueda == true)
                    {
                        return 0;
                    }
                    else
                    {
                        Console.WriteLine("Warning: No se encontro informacion disponible para la operacion");
                        return 1;
                    }



                }

                auxMN = auxMN.sigMN;

            }

            if (validacionbusqueda == true)
            {
                return 0;
            }
            else
            {
                Console.WriteLine("Warning: No se encontro informacion disponible para la operacion");
                Console.ReadLine();
                return 1;
            }
        }
        public void AgregarMatrizResultado(int ifilaaux, int icolumnaaux)
        {
            nuevoMN = new MatrizNodo();
            // CONTADOR
            if (inicioMN == null)
            {
                nuevoMN.CodigoMN = 1;
                numerocodigoMN = nuevoMN.CodigoMN;
            }
            else
            {
                numerocodigoMN += 1;
                nuevoMN.CodigoMN = numerocodigoMN;
            }

            numerocodigoAux = numerocodigoMN;

            nuevoMN.ifilaMN = ifilaaux;
            nuevoMN.icolumnaMN = icolumnaaux;

            // LLENA LA MATRIZ DE DATOS
            nuevoMN.MatrizMN = new float[ifilaaux, icolumnaaux];
            for (int i = 0; i < ifilaaux; i++)
            {
                for (int j = 0; j < icolumnaaux; j++)
                {
                    nuevoMN.MatrizMN[i, j] = Matriz03[i,j];
                }
            }


            if (inicioMN == null)
            {
                inicioMN = nuevoMN;
                finMN = inicioMN;
            }
            else
            {
                finMN.sigMN = nuevoMN;
                auxMN = finMN;
                finMN = finMN.sigMN;
                finMN.antMN = auxMN;
                finMN.sigMN = null;
            }

        }


        // |||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

        // COMPONENTES PARA CUATERNIOS
        public CuaternioNodo inicioCN
        {
            get { return INICIOCN; }
            set { INICIOCN = value; }
        }
        public CuaternioNodo finCN
        {
            get { return FINCN; }
            set { FINCN = value; }
        }
        public CuaternioNodo nuevoCN
        {
            get { return NUEVOCN; }
            set { NUEVOCN = value; }
        }
        public CuaternioNodo auxCN
        {
            get { return AUXCN; }
            set { AUXCN = value; }
        }
        public CuaternioNodo eliminarCN
        {
            get { return ELIMINARCN; }
            set { ELIMINARCN = value; }
        }
        // FUNCIONES PARA CUATERNIOS
        public void AgregarCuaternio()
        {
            nuevoCN = new CuaternioNodo();
            ifilaCN = 1;
            icolumnaCN = 4;
            volver = false;

            // CONTADOR
            if (inicioCN == null)
            {
                nuevoCN.CodigoCN = 1;
                numerocodigoCN = nuevoCN.CodigoCN;
            }
            else
            {
                numerocodigoCN += 1;
                nuevoCN.CodigoCN = numerocodigoCN;
            }

            numerocodigoAuxCN = numerocodigoCN;

            // FILAS
            nuevoCN.ifilaCN = ifilaCN;

            // COLUMNAS
            nuevoCN.icolumnaCN = icolumnaCN;

            // LLENA LA MATRIZ DE DATOS
            nuevoCN.CuaternioCN = new float[ifilaCN, icolumnaCN];
            for (int i = 0; i < ifilaCN; i++)
            {
                for (int j = 0; j < icolumnaCN; j++)
                {
                    do
                    {
                        volver = false;
                        switch (j)
                        {
                            case 0:
                                letraCN = "real o escalar";
                                break;
                            case 1:
                                letraCN = "i";
                                break;
                            case 2:
                                letraCN = "j";
                                break;
                            case 3:
                                letraCN = "k";
                                break;
                            default:
                                break;
                        }
                        Console.WriteLine(" Escribe el numero que ira en el CUATERNIO posicion:" + letraCN);
                        string numerocuaternio= Console.ReadLine();
                        int cantidad = numerocuaternio.Length;
                        if (VC.Contador(cantidad, numerocuaternio) == 0)
                        {
                            volver = false;
                            ///float inumeromatriz = Convert.ToInt32(numeromatriz); // convierte a int
                            float inumerocuaternio = (float)Convert.ToDouble(numerocuaternio);
                            inumerocuaternio = (float)Math.Round(inumerocuaternio, 2);
                            nuevoCN.CuaternioCN[i, j] = inumerocuaternio;
                        }
                        else
                        {
                            volver = true;
                        }
                    } while (volver != false);
                }
            }


            if (inicioCN == null)
            {
                inicioCN = nuevoCN;
                finCN = inicioCN;
            }
            else
            {
                finCN.sigCN = nuevoCN;
                auxCN = finCN;
                finCN = finCN.sigCN;
                finCN.antCN = auxCN;
                finCN.sigCN = null;
            }

        }
        public void ImprimirCuaternios()
        {
            auxCN = inicioCN;

            if (inicioCN == null)
            {
                Console.WriteLine("Warning: No se pudo imprimir");
                Console.WriteLine("Warning: No hay informacion que imprimir");
            }
            while (auxCN != null)
            {

                Console.WriteLine("-------------------------------------------------------------------    ");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine(" Codigo: " + auxCN.CodigoCN + "  Con filas: " + auxCN.ifilaCN + "  Con Columnas: " + auxCN.icolumnaCN);
                Console.ForegroundColor = ConsoleColor.White;

                for (int i = 0; i < auxCN.ifilaCN; i++)
                {
                    Console.Write("\n");
                    for (int j = 0; j < auxCN.icolumnaCN; j++)
                    {
                        switch (j)
                        {
                            case 0:
                                letraCN = " ";
                                break;
                            case 1:
                                letraCN = "i";
                                break;
                            case 2:
                                letraCN = "j";
                                break;
                            case 3:
                                letraCN = "k";
                                break;
                            default:
                                break;
                        }
                        Console.Write(auxCN.CuaternioCN[i, j] + letraCN + "   ");
                    }
                }
                Console.WriteLine(" ");


                auxCN = auxCN.sigCN;
            }
            Console.ReadLine();
        }
        public int ImprimirCuaternioEspecifico(int numerocodigoso)
        {
            validacionbusqueda = false;
            auxCN = inicioCN;
            while (auxCN != null)
            {
                if (auxCN.CodigoCN == numerocodigoso)
                {
                    validacionbusqueda = true;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine(" Codigo: " + auxCN.CodigoCN + "  Con filas: " + auxCN.ifilaCN + "  Con Columnas: " + auxCN.icolumnaCN);
                    Console.ForegroundColor = ConsoleColor.White;

                    for (int i = 0; i < auxCN.ifilaCN; i++)
                    {
                        Console.Write("\n");
                        for (int j = 0; j < auxCN.icolumnaCN; j++)
                        {
                            
                            switch (j)
                            {
                                case 0:
                                    letraCN = " ";
                                    break;
                                case 1:
                                    letraCN = "i";
                                    break;
                                case 2:
                                    letraCN = "j";
                                    break;
                                case 3:
                                    letraCN = "k";
                                    break;
                                default:
                                    break;
                            }
                            Console.Write(auxCN.CuaternioCN[i, j] + letraCN + "   ");
                        }
                    }
                    Console.ReadLine();
                    break;
                }
                else
                {
                    if (auxCN.sigCN == null)
                    {
                        validacionbusqueda = false;
                    }
                }

                auxCN = auxCN.sigCN;
            }

            if (validacionbusqueda == true)
            {
                return 0;
            }
            else
            {
                Console.WriteLine("Warning: No se pudo imprimir");
                Console.WriteLine("Warning: No se encontro la informacion buscada");
                Console.ReadLine();
                return 1;
            }
        }
        public int BuscarCuaternio(int numerocodigoso)
        {

            validacionbusqueda = false;
            auxCN = inicioCN;
            while (auxCN != null)
            {
                if (auxCN.CodigoCN == numerocodigoso)
                {
                    validacionbusqueda = true;
                    CuaternioAux = new float[auxCN.ifilaCN, auxCN.icolumnaCN];

                    ifilaAuxCN = auxCN.ifilaCN;
                    icolumnaAuxCN = auxCN.icolumnaCN;

                    for (int i = 0; i < auxCN.ifilaCN; i++)
                    {
                        for (int j = 0; j < auxCN.icolumnaCN; j++)
                        {
                            CuaternioAux[i, j] = auxCN.CuaternioCN[i, j];
                        }
                    }
                    Console.WriteLine(" ");
                    break;
                }
                else
                {

                    if (auxCN.sigCN == null)
                    {
                        validacionbusqueda = false;
                        Console.ReadLine();
                    }
                }

                auxCN = auxCN.sigCN;
            }

            if (validacionbusqueda == true)
            {
                return 0;
            }
            else
            {
                Console.WriteLine("Warning: No se encontro informacion disponible para la operacion");
                Console.ReadLine();
                return 1;
            }
        }
        public int EliminarCuaternio(int numerocodigoso)
        {
            validacionbusqueda = false;
            auxCN = inicioCN;

            while (auxCN != null)
            {
                if (auxCN.CodigoCN == numerocodigoso)
                {
                    validacionbusqueda = true;
                    eliminarCN = new CuaternioNodo();
                    eliminarCN = auxCN;

                    if (eliminarCN.sigCN == null && eliminarCN.antCN == null) // Solo esta el inicio
                    {
                        eliminarCN = inicioCN;
                        inicioCN = null;
                        auxCN = null;
                        eliminarCN = null;
                    }
                    else if (eliminarCN.antCN == null) // Eliminar nodo y no hay nada antes
                    {
                        inicioCN = eliminarCN.sigCN;
                        inicioCN.sigCN = null;
                        inicioCN.antCN = null;
                        eliminarCN = null;
                    }
                    else if (eliminarCN.sigCN == null) // Eliminar nodo y no hay nada despues
                    {
                        auxCN = eliminarCN.antCN;
                        eliminarCN.antCN.sigCN = null;
                        finCN = auxCN;
                        eliminarCN = null;
                    }
                    else // Eliminar el de enmedio
                    {
                        auxCN = eliminarCN.antCN;
                        auxCN.sigCN = eliminarCN.sigCN;
                        eliminarCN.sigCN.antCN = auxCN;
                        eliminarCN = null;
                    }

                    Console.WriteLine("CUATERNIO ELIMINADA");
                    Console.ReadLine();
                    break;

                }
                else
                {
                    if (auxCN.sigCN == null)
                    {
                        validacionbusqueda = false;
                    }
                }

                auxCN = auxCN.sigCN;
            }

            if (validacionbusqueda == true)
            {
                return 0;
            }
            else
            {
                Console.WriteLine("Warning: No se pudo eliminar");
                Console.WriteLine("Warning: No se encontro la informacion buscada");
                Console.ReadLine();
                return 1;
            }
        }
        public int ModificarCuaternio(int numerocodigoso)
        {
            validacionbusqueda = false;
            auxCN = inicioCN;
            while (auxCN != null)
            {
                if (auxCN.CodigoCN == numerocodigoso)
                {

                    validacionbusqueda = true;
                    ifilaCN = 1;
                    icolumnaCN = 4;

                    // LLENA LA MATRIZ DE DATOS
                    auxCN.CuaternioCN = new float[ifilaCN, icolumnaCN];
                    for (int i = 0; i < ifilaCN; i++)
                    {
                        for (int j = 0; j < icolumnaCN; j++)
                        {
                            do
                            {
                                volver = false;
                                switch (j)
                                {
                                    case 0:
                                        letraCN = "real o escalar";
                                        break;
                                    case 1:
                                        letraCN = "i";
                                        break;
                                    case 2:
                                        letraCN = "j";
                                        break;
                                    case 3:
                                        letraCN = "k";
                                        break;
                                    default:
                                        break;
                                }
                                Console.WriteLine(" Escribe el numero que ira en la matriz posicion:" + letraCN);
                                string numerocuaternio = Console.ReadLine();
                                int cantidadCN = numerocuaternio.Length;
                                if (VC.Contador(cantidadCN, numerocuaternio) == 0)
                                {
                                    volver = false;
                                    float inumerocuaternio= (float)Convert.ToDouble(numerocuaternio);
                                    inumerocuaternio = (float)Math.Round(inumerocuaternio, 2);
                                    auxCN.CuaternioCN[i, j] = inumerocuaternio;
                                }
                                else
                                {
                                    volver = true;
                                }
                            } while (volver != false);
                        }
                    }
                    Console.WriteLine(" ");
                    break;
                }
                else
                {

                    if (auxCN.sigCN == null)
                    {
                        validacionbusqueda = false;
                        Console.ReadLine();
                    }
                }

                auxCN = auxCN.sigCN;
            }

            if (validacionbusqueda == true)
            {
                return 0;
            }
            else
            {
                Console.WriteLine("Warning: No se encontro informacion disponible para la operacion");
                Console.ReadLine();
                return 1;
            }



        }
        public int ModificarCuaternioEspecifico(int numerocodigoso)
        {
            validacionbusqueda = false;
            auxCN = inicioCN;
            while (auxCN != null)
            {
                if (auxCN.CodigoCN == numerocodigoso)
                {
                    // PIDE FILAS Y COLUMNAS PARA MODIFICAR

                    ifilaACN = 1;
                    do
                    {
                        volvervolver = false;
                        Console.WriteLine(" Escriba la columna del CUATERNIO que busca");
                        Console.WriteLine("Consejo: Toma en cuenta que estan en el orden: real=1, i=2, j=3 y k=4");
                        string numeroshoCN = Console.ReadLine();

                        int cantidadCN = numeroshoCN.Length;
                        if (VC.Contador(cantidadCN, numeroshoCN) == 0)
                        {
                            volvervolver = false;
                            icolumnaACN = Convert.ToInt32(numeroshoCN); // convierte a int
                        }
                        else
                        {
                            volvervolver = true;
                        }
                    } while (volvervolver != false);


                    auxCN = inicioCN;
                    while (auxCN != null)
                    {
                        if (auxCN.CodigoCN == numerocodigoso)
                        {
                            if (ifilaACN < auxCN.ifilaCN && icolumnaACN < auxCN.icolumnaCN)
                            {
                                validacionbusqueda = true;
                                for (int i = 0; i < auxCN.ifilaCN; i++)
                                {
                                    for (int j = 0; j < auxCN.icolumnaCN; j++)
                                    {

                                        if (ifilaACN == i && icolumnaACN == j)
                                        {
                                            do
                                            {
                                                volver = false;
                                                Console.WriteLine(" Escribe el numero que ira en el CUATERNIO posicion:" + "[" + i + " , " + j + "]");
                                                string numerocuaternio = Console.ReadLine();
                                                int cantidadCN = numerocuaternio.Length;
                                                if (VC.Contador(cantidadCN, numerocuaternio) == 0)
                                                {
                                                    volver = false;
                                                    float inumerocuaternio = (float)Convert.ToDouble(numerocuaternio);
                                                    inumerocuaternio = (float)Math.Round(inumerocuaternio, 2);
                                                    auxCN.CuaternioCN[i, j] = inumerocuaternio;

                                                    switch (j)
                                                    {
                                                        case 0:
                                                            letraCN = "real o escalar";
                                                            break;
                                                        case 1:
                                                            letraCN = "i";
                                                            break;
                                                        case 2:
                                                            letraCN = "j";
                                                            break;
                                                        case 3:
                                                            letraCN = "k";
                                                            break;
                                                        default:
                                                            break;
                                                    }

                                                    Console.WriteLine(" El numero que ira en el CUATERNIO posicion:" + letraCN + " ahora sera: " + auxCN.CuaternioCN[i, j] + "   ");
                                                    ImprimirMatrizEspecifica(auxCN.CodigoCN);
                                                    break;

                                                }
                                                else
                                                {
                                                    volver = true;
                                                }
                                            } while (volver != false);


                                        }


                                    }

                                }
                            }
                            else
                            {
                                validacionbusqueda = false;
                                break;
                            }

                            
                            break;
                        }
                        else
                        {
                            if (auxCN.sigCN == null)
                            {
                                validacionbusqueda = false;
                                Console.ReadLine();
                            }
                        }

                        auxCN = auxCN.sigCN;
                    }

                    if (validacionbusqueda == true)
                    {
                        return 0;
                    }
                    else
                    {
                        Console.WriteLine("Warning: No se encontro informacion disponible para la operacion");
                        return 1;
                    }



                }

                auxMN = auxMN.sigMN;

            }

            if (validacionbusqueda == true)
            {
                return 0;
            }
            else
            {
                Console.WriteLine("Warning: No se encontro informacion disponible para la operacion");
                Console.ReadLine();
                return 1;
            }
        }
        public void AgregarCuaternioResultado(int ifilaaux, int icolumnaaux)
        {
            nuevoCN = new CuaternioNodo();
            // CONTADOR
            if (inicioCN == null)
            {
                nuevoCN.CodigoCN = 1;
                numerocodigoCN = nuevoCN.CodigoCN;
            }
            else
            {
                numerocodigoCN += 1;
                nuevoCN.CodigoCN = numerocodigoCN;
            }

            numerocodigoAuxCN = numerocodigoCN;

            nuevoCN.ifilaCN = ifilaaux;
            nuevoCN.icolumnaCN = icolumnaaux;

            // LLENA LA MATRIZ DE DATOS
            nuevoCN.CuaternioCN = new float[ifilaaux, icolumnaaux];
            for (int i = 0; i < ifilaaux; i++)
            {
                for (int j = 0; j < icolumnaaux; j++)
                {
                    nuevoCN.CuaternioCN[i, j] = Cuaternio03[i, j];
                }
            }


            if (inicioCN == null)
            {
                inicioCN = nuevoCN;
                finCN = inicioCN;
            }
            else
            {
                finCN.sigCN = nuevoCN;
                auxCN = finCN;
                finCN = finCN.sigCN;
                finCN.antCN = auxCN;
                finCN.sigCN = null;
            }

        }

        // |||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

        // COMPONENTES PARA TRASLACION_ROTACION_ESCALAR
        public TRENodo inicioTRE
        {
            get { return INICIOTRE; }
            set { INICIOTRE = value; }
        }
        public TRENodo finTRE
        {
            get { return FINTRE; }
            set { FINTRE = value; }
        }
        public TRENodo nuevoTRE
        {
            get { return NUEVOTRE; }
            set { NUEVOTRE = value; }
        }
        public TRENodo auxTRE
        {
            get { return AUXTRE; }
            set { AUXTRE = value; }
        }
        public TRENodo eliminarTRE
        {
            get { return ELIMINARTRE; }
            set { ELIMINARTRE = value; }
        }
        // FUNCIONES PARA TRASLACION_ROTACION_ESCALAR
        public void AgregarTRE()
        {
            nuevoTRE = new TRENodo();
            ifilaTRE = 1;
            icolumnaTRE = 3;
            volver = false;

            //    icelula = Convert.ToInt32(scedula); // convierte a int


            // CONTADOR
            if (inicioTRE == null)
            {
                nuevoTRE.CodigoTRE = 1;
                numerocodigoTRE = nuevoTRE.CodigoTRE;
            }
            else
            {
                //auxMN = inicioMN;
                //while (auxMN != null)
                //{
                //    nuevoMN.CodigoMN = auxMN.CodigoMN + 1;
                //    auxMN = auxMN.sigMN;
                //}

                numerocodigoTRE += 1;
                nuevoTRE.CodigoTRE = numerocodigoTRE;
            }

            numerocodigoAuxTRE = numerocodigoTRE;

            // FILAS
            nuevoTRE.ifilaTRE = ifilaTRE;

            // COLUMNAS
            nuevoTRE.icolumnaTRE = icolumnaTRE;

            // LLENA LA MATRIZ DE DATOS
            nuevoTRE.PuntoTRE = new float[ifilaTRE, icolumnaTRE];
            for (int i = 0; i < ifilaTRE; i++)
            {
                for (int j = 0; j < icolumnaTRE; j++)
                {
                    do
                    {
                        volver = false;
                        switch (j)
                        {
                            case 0:
                                letraCN = "x";
                                break;
                            case 1:
                                letraCN = "y";
                                break;
                            case 2:
                                letraCN = "z";
                                break;
                            default:
                                break;
                        }
                        Console.WriteLine(" Escribe el numero que ira en el PUNTO posicion:" + letraCN);
                        string numeromatriz = Console.ReadLine();
                        int cantidad = numeromatriz.Length;
                        if (VC.Contador(cantidad, numeromatriz) == 0)
                        {
                            volver = false;
                            ///float inumeromatriz = Convert.ToInt32(numeromatriz); // convierte a int
                            float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                            inumeromatriz = (float)Math.Round(inumeromatriz, 2);
                            nuevoTRE.PuntoTRE[i, j] = inumeromatriz;
                        }
                        else
                        {
                            volver = true;
                        }
                    } while (volver != false);
                }
            }


            if (inicioTRE == null)
            {
                inicioTRE = nuevoTRE;
                finTRE = inicioTRE;
            }
            else
            {
                finTRE.sigTRE = nuevoTRE;
                auxTRE = finTRE;
                finTRE = finTRE.sigTRE;
                finTRE.antTRE = auxTRE;
                finTRE.sigTRE = null;
            }

        }
        public void ImprimirTRE()
        {
            auxTRE = inicioTRE;

            if (inicioTRE == null)
            {
                Console.WriteLine("Warning: No se pudo imprimir");
                Console.WriteLine("Warning: No hay informacion que imprimir");
            }
            while (auxTRE != null)
            {

                Console.WriteLine("-------------------------------------------------------------------    ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(" Codigo: " + auxTRE.CodigoTRE + "  Con filas: " + auxTRE.ifilaTRE + "  Con Columnas: " + auxTRE.icolumnaTRE);
                Console.ForegroundColor = ConsoleColor.White;

                for (int i = 0; i < auxTRE.ifilaTRE; i++)
                {
                    Console.Write("\n");
                    for (int j = 0; j < auxTRE.icolumnaTRE; j++)
                    {
                        switch (j)
                        {
                            case 0:
                                letraCN = "x";
                                break;
                            case 1:
                                letraCN = "y";
                                break;
                            case 2:
                                letraCN = "z";
                                break;
                            default:
                                break;
                        }

                        Console.Write(auxTRE.PuntoTRE[i, j] + letraCN + "   ");
                    }
                }
                Console.WriteLine(" ");


                auxTRE = auxTRE.sigTRE;
            }
            Console.ReadLine();
        }
        public int ImprimirTREEspecifica(int numerocodigoso)
        {
            validacionbusqueda = false;
            auxTRE = inicioTRE;
            while (auxTRE != null)
            {
                if (auxTRE.CodigoTRE == numerocodigoso)
                {
                    validacionbusqueda = true;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(" Codigo: " + auxTRE.CodigoTRE + "  Con filas: " + auxTRE.ifilaTRE + "  Con Columnas: " + auxTRE.icolumnaTRE);
                    Console.ForegroundColor = ConsoleColor.White;

                    for (int i = 0; i < auxTRE.ifilaTRE; i++)
                    {
                        Console.Write("\n");
                        for (int j = 0; j < auxTRE.icolumnaTRE; j++)
                        {
                            switch (j)
                            {
                                case 0:
                                    letraCN = "x";
                                    break;
                                case 1:
                                    letraCN = "y";
                                    break;
                                case 2:
                                    letraCN = "z";
                                    break;
                                default:
                                    break;
                            }

                            Console.Write(auxTRE.PuntoTRE[i, j] + letraCN + "   ");
                        }
                    }
                    Console.ReadLine();
                    break;
                }
                else
                {
                    if (auxTRE.sigTRE == null)
                    {
                        validacionbusqueda = false;
                    }
                }

                auxTRE = auxTRE.sigTRE;
            }

            if (validacionbusqueda == true)
            {
                return 0;
            }
            else
            {
                Console.WriteLine("Warning: No se pudo imprimir");
                Console.WriteLine("Warning: No se encontro la informacion buscada");
                Console.ReadLine();
                return 1;
            }
        }
        public int BuscarTRE(int numerocodigoso)
        {

            validacionbusqueda = false;
            auxTRE = inicioTRE;
            while (auxTRE != null)
            {
                if (auxTRE.CodigoTRE == numerocodigoso)
                {
                    validacionbusqueda = true;
                    TREAux = new float[auxTRE.ifilaTRE, auxTRE.icolumnaTRE];

                    ifilaAuxTRE = auxTRE.ifilaTRE;
                    icolumnaAuxTRE = auxTRE.icolumnaTRE;

                    for (int i = 0; i < auxTRE.ifilaTRE; i++)
                    {
                        for (int j = 0; j < auxTRE.icolumnaTRE; j++)
                        {
                            TREAux[i, j] = auxTRE.PuntoTRE[i, j];
                        }
                    }
                    Console.WriteLine(" ");
                    break;
                }
                else
                {

                    if (auxTRE.sigTRE == null)
                    {
                        validacionbusqueda = false;
                        Console.ReadLine();
                    }
                }

                auxTRE = auxTRE.sigTRE;
            }

            if (validacionbusqueda == true)
            {
                return 0;
            }
            else
            {
                Console.WriteLine("Warning: No se encontro informacion disponible para la operacion");
                Console.ReadLine();
                return 1;
            }
        }
        public int EliminarTRE(int numerocodigoso)
        {
            validacionbusqueda = false;
            auxTRE = inicioTRE;

            while (auxTRE != null)
            {
                if (auxTRE.CodigoTRE == numerocodigoso)
                {
                    validacionbusqueda = true;
                    eliminarTRE = new TRENodo();
                    eliminarTRE = auxTRE;

                    if (eliminarTRE.sigTRE == null && eliminarTRE.antTRE == null) // Solo esta el inicio
                    {
                        eliminarTRE = inicioTRE;
                        inicioTRE = null;
                        auxTRE = null;
                        eliminarTRE = null;
                    }
                    else if (eliminarTRE.antTRE == null) // Eliminar nodo y no hay nada antes
                    {
                        //auxMN = auxMN.sigMN;
                        inicioTRE = eliminarTRE.sigTRE;
                        inicioTRE.sigTRE = null;
                        inicioTRE.antTRE = null;
                        eliminarTRE = null;
                    }
                    else if (eliminarTRE.sigTRE == null) // Eliminar nodo y no hay nada despues
                    {
                        auxTRE = eliminarTRE.antTRE;
                        eliminarTRE.antTRE.sigTRE = null;
                        finTRE = auxTRE;
                        eliminarTRE = null;
                    }
                    else // Eliminar el de enmedio
                    {
                        auxTRE = eliminarTRE.antTRE;
                        auxTRE.sigTRE = eliminarTRE.sigTRE;
                        eliminarTRE.sigTRE.antTRE = auxTRE;
                        eliminarTRE = null;
                    }

                    Console.WriteLine("MATRIZ ELIMINADA");
                    Console.ReadLine();
                    break;

                }
                else
                {
                    if (auxTRE.sigTRE == null)
                    {
                        validacionbusqueda = false;
                    }
                }

                auxTRE = auxTRE.sigTRE;
            }

            if (validacionbusqueda == true)
            {
                return 0;
            }
            else
            {
                Console.WriteLine("Warning: No se pudo eliminar");
                Console.WriteLine("Warning: No se encontro la informacion buscada");
                Console.ReadLine();
                return 1;
            }
        }
        public int ModificarTRE(int numerocodigoso)
        {
            validacionbusqueda = false;
            auxTRE = inicioTRE;
            while (auxTRE != null)
            {
                if (auxTRE.CodigoTRE == numerocodigoso)
                {

                    validacionbusqueda = true;
                    ifilaTRE = 1;
                    icolumnaTRE = 3;

                    // FILAS
                    auxTRE.ifilaTRE = ifilaTRE;

                    // COLUMNAS
                    auxTRE.icolumnaTRE = icolumnaTRE;

                    // LLENA LA MATRIZ DE DATOS
                    auxTRE.PuntoTRE = new float[ifilaTRE, icolumnaTRE];
                    for (int i = 0; i < ifilaTRE; i++)
                    {
                        for (int j = 0; j < icolumnaTRE; j++)
                        {
                            do
                            {
                                volver = false;
                                switch (j)
                                {
                                    case 0:
                                        letraCN = "x";
                                        break;
                                    case 1:
                                        letraCN = "y";
                                        break;
                                    case 2:
                                        letraCN = "z";
                                        break;
                                    default:
                                        break;
                                }
                                Console.WriteLine(" Escribe el numero que ira en el PUNTO posicion:" + letraCN);
                                string numeromatriz = Console.ReadLine();
                                int cantidad = numeromatriz.Length;
                                if (VC.Contador(cantidad, numeromatriz) == 0)
                                {
                                    volver = false;
                                    float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                                    inumeromatriz = (float)Math.Round(inumeromatriz, 2);
                                    auxTRE.PuntoTRE[i, j] = inumeromatriz;
                                }
                                else
                                {
                                    volver = true;
                                }
                            } while (volver != false);
                        }
                    }
                    Console.WriteLine(" ");
                    break;
                }
                else
                {

                    if (auxTRE.sigTRE == null)
                    {
                        validacionbusqueda = false;
                        Console.ReadLine();
                    }
                }

                auxTRE = auxTRE.sigTRE;
            }

            if (validacionbusqueda == true)
            {
                return 0;
            }
            else
            {
                Console.WriteLine("Warning: No se encontro informacion disponible para la operacion");
                Console.ReadLine();
                return 1;
            }



        }
        public int ModificarTREEspecifica(int numerocodigoso)
        {
            validacionbusqueda = false;
            auxTRE = inicioTRE;
            while (auxTRE != null)
            {
                if (auxTRE.CodigoTRE == numerocodigoso)
                {
                    // PIDE FILAS Y COLUMNAS PARA MODIFICAR
                    ifilaATRE = 1;

                    do
                    {
                        volvervolver = false;
                        Console.WriteLine(" Escriba la columna del PUNTO que busca");
                        string numerosho = Console.ReadLine();

                        int cantidad = numerosho.Length;
                        if (VC.Contador(cantidad, numerosho) == 0)
                        {
                            volvervolver = false;
                            icolumnaATRE = Convert.ToInt32(numerosho); // convierte a int
                        }
                        else
                        {
                            volvervolver = true;
                        }
                    } while (volvervolver != false);


                    auxTRE = inicioTRE;
                    while (auxTRE != null)
                    {
                        if (auxTRE.CodigoTRE == numerocodigoso)
                        {
                            if (ifilaATRE < auxTRE.ifilaTRE && icolumnaATRE < auxTRE.icolumnaTRE)
                            {
                                validacionbusqueda = true;
                                for (int i = 0; i < auxTRE.ifilaTRE; i++)
                                {
                                    for (int j = 0; j < auxTRE.icolumnaTRE; j++)
                                    {

                                        if (ifilaATRE == i && icolumnaATRE == j)
                                        {
                                            do
                                            {
                                                volver = false;
                                                switch (j)
                                                {
                                                    case 0:
                                                        letraCN = "x";
                                                        break;
                                                    case 1:
                                                        letraCN = "y";
                                                        break;
                                                    case 2:
                                                        letraCN = "z";
                                                        break;
                                                    default:
                                                        break;
                                                }
                                                Console.WriteLine(" Escribe el numero que ira en el PUNTO posicion:" + letraCN);
                                                string numeromatriz = Console.ReadLine();
                                                int cantidad = numeromatriz.Length;
                                                if (VC.Contador(cantidad, numeromatriz) == 0)
                                                {
                                                    volver = false;
                                                    ///float inumeromatriz = Convert.ToInt32(numeromatriz); // convierte a int
                                                    float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                                                    inumeromatriz = (float)Math.Round(inumeromatriz, 2);
                                                    auxTRE.PuntoTRE[i, j] = inumeromatriz;


                                                    Console.WriteLine(" El numero que ira en el PUNTO posicion:" + letraCN + "[" + i + " , " + j + "]" + " ahora sera: " + auxTRE.PuntoTRE[i, j] + "   ");
                                                    ImprimirTREEspecifica(auxTRE.CodigoTRE);
                                                    break;

                                                }
                                                else
                                                {
                                                    volver = true;
                                                }
                                            } while (volver != false);


                                        }


                                    }

                                }

                            }
                            else
                            {
                                validacionbusqueda = false;
                                break;
                            }


                            break;
                        }
                        else
                        {
                            if (auxTRE.sigTRE == null)
                            {
                                validacionbusqueda = false;
                                Console.ReadLine();
                            }
                        }

                        auxTRE = auxTRE.sigTRE;
                    }

                    if (validacionbusqueda == true)
                    {
                        return 0;
                    }
                    else
                    {
                        Console.WriteLine("Warning: No se encontro informacion disponible para la operacion");
                        return 1;
                    }



                }

                auxTRE = auxTRE.sigTRE;

            }

            if (validacionbusqueda == true)
            {
                return 0;
            }
            else
            {
                Console.WriteLine("Warning: No se encontro informacion disponible para la operacion");
                Console.ReadLine();
                return 1;
            }
        }
        public void AgregarTREResultado(int ifilaaux, int icolumnaaux)
        {
            nuevoTRE = new TRENodo();
            // CONTADOR
            if (inicioTRE == null)
            {
                nuevoTRE.CodigoTRE = 1;
                numerocodigoTRE = nuevoTRE.CodigoTRE;
            }
            else
            {
                numerocodigoTRE += 1;
                nuevoTRE.CodigoTRE = numerocodigoTRE;
            }

            numerocodigoAuxTRE = numerocodigoTRE;

            nuevoTRE.ifilaTRE = ifilaaux;
            nuevoTRE.icolumnaTRE = icolumnaaux;

            // LLENA LA MATRIZ DE DATOS
            nuevoTRE.PuntoTRE = new float[ifilaaux, icolumnaaux];
            for (int i = 0; i < ifilaaux; i++)
            {
                for (int j = 0; j < icolumnaaux; j++)
                {
                    nuevoTRE.PuntoTRE[i, j] = TRE03[i, j];
                }
            }


            if (inicioTRE == null)
            {
                inicioTRE = nuevoTRE;
                finTRE = inicioTRE;
            }
            else
            {
                finTRE.sigTRE = nuevoTRE;
                auxTRE = finTRE;
                finTRE = finTRE.sigTRE;
                finTRE.antTRE = auxTRE;
                finTRE.sigTRE = null;
            }

        }

        // |||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

        // COMPONENTES PARA VECTORES
        public VECNodo inicioVEC
        {
            get { return INICIOVEC; }
            set { INICIOVEC = value; }
        }
        public VECNodo finVEC
        {
            get { return FINVEC; }
            set { FINVEC = value; }
        }
        public VECNodo nuevoVEC
        {
            get { return NUEVOVEC; }
            set { NUEVOVEC = value; }
        }
        public VECNodo auxVEC
        {
            get { return AUXVEC; }
            set { AUXVEC = value; }
        }
        public VECNodo eliminarVEC
        {
            get { return ELIMINARVEC; }
            set { ELIMINARVEC = value; }
        }
        // FUNCIONES PARA VECTORES
        public void AgregarVectores()
        {
            nuevoVEC = new VECNodo();
            ifilaVEC = 1;
            icolumnaVEC = 0;
            volver = false;

            //    icelula = Convert.ToInt32(scedula); // convierte a int


            // CONTADOR
            if (inicioVEC == null)
            {
                nuevoVEC.CodigoVEC = 1;
                numerocodigoVEC = nuevoVEC.CodigoVEC;
            }
            else
            {
                //auxMN = inicioMN;
                //while (auxMN != null)
                //{
                //    nuevoMN.CodigoMN = auxMN.CodigoMN + 1;
                //    auxMN = auxMN.sigMN;
                //}

                numerocodigoVEC += 1;
                nuevoVEC.CodigoVEC = numerocodigoVEC;
            }

            numerocodigoAuxVEC = numerocodigoVEC;

            // FILAS
            nuevoVEC.ifilaVEC = ifilaVEC;

            // COLUMNAS
            do
            {
                volver = false;
                Console.WriteLine(" Columnas");
                string columna = Console.ReadLine();
                int cantidad = columna.Length;
                if (VC.Contador(cantidad, columna) == 0 && VC.Ceros(columna) == 0)
                {
                    icolumnaVEC = Convert.ToInt32(columna); // convierte a int
                    nuevoVEC.icolumnaVEC = icolumnaVEC;
                    if (icolumnaVEC > 0)
                    {
                        volver = false;
                        nuevoVEC.icolumnaVEC = icolumnaVEC;
                    }
                    else
                    {
                        Console.WriteLine("Warning: Caracter invalido");
                        volver = true;
                    }
                }
                else
                {
                    volver = true;
                }
            } while (volver != false);

            // LLENA LA MATRIZ DE DATOS
            nuevoVEC.MatrizVEC = new float[ifilaVEC, icolumnaVEC];
            for (int i = 0; i < ifilaVEC; i++)
            {
                for (int j = 0; j < icolumnaVEC; j++)
                {
                    do
                    {
                        volver = false;
                        Console.WriteLine(" Escribe el numero que ira en la matriz posicion:" + "[" + i + " , " + j + "]");
                        string numeromatriz = Console.ReadLine();
                        int cantidad = numeromatriz.Length;
                        if (VC.Contador(cantidad, numeromatriz) == 0)
                        {
                            volver = false;
                            ///float inumeromatriz = Convert.ToInt32(numeromatriz); // convierte a int
                            float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                            inumeromatriz = (float)Math.Round(inumeromatriz, 2);
                            nuevoVEC.MatrizVEC[i, j] = inumeromatriz;
                        }
                        else
                        {
                            volver = true;
                        }
                    } while (volver != false);
                }
            }


            if (inicioVEC == null)
            {
                inicioVEC = nuevoVEC;
                finVEC = inicioVEC;
            }
            else
            {
                finVEC.sigVEC = nuevoVEC;
                auxVEC = finVEC;
                finVEC = finVEC.sigVEC;
                finVEC.antVEC = auxVEC;
                finVEC.sigVEC = null;
            }

        }
        public void ImprimirVectores()
        {
            auxVEC = inicioVEC;

            if (inicioVEC == null)
            {
                Console.WriteLine("Warning: No se pudo imprimir");
                Console.WriteLine("Warning: No hay informacion que imprimir");
            }
            while (auxVEC != null)
            {

                Console.WriteLine("-------------------------------------------------------------------    ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(" Codigo: " + auxVEC.CodigoVEC + "  Con filas: " + auxVEC.ifilaVEC + "  Con Columnas: " + auxVEC.icolumnaVEC);
                Console.ForegroundColor = ConsoleColor.White;

                for (int i = 0; i < auxVEC.ifilaVEC; i++)
                {
                    Console.Write("\n");
                    for (int j = 0; j < auxVEC.icolumnaVEC; j++)
                    {
                        Console.Write(auxVEC.MatrizVEC[i, j] + "   ");
                    }
                }
                Console.WriteLine(" ");


                auxVEC = auxVEC.sigVEC;
            }
            Console.ReadLine();
        }
        public int ImprimirVectorEspecifica(int numerocodigoso)
        {
            validacionbusqueda = false;
            auxVEC = inicioVEC;
            while (auxVEC != null)
            {
                if (auxVEC.CodigoVEC == numerocodigoso)
                {
                    validacionbusqueda = true;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(" Codigo: " + auxVEC.CodigoVEC + "  Con filas: " + auxVEC.ifilaVEC + "  Con Columnas: " + auxVEC.icolumnaVEC);
                    Console.ForegroundColor = ConsoleColor.White;

                    for (int i = 0; i < auxVEC.ifilaVEC; i++)
                    {
                        Console.Write("\n");
                        for (int j = 0; j < auxVEC.icolumnaVEC; j++)
                        {
                            if (productuosocruzVEC == true)
                            {
                                string letraMN = " ";
                                switch (j)
                                {
                                    case 0:
                                        letraMN = "i";
                                        break;
                                    case 1:
                                        letraMN = "j";
                                        break;
                                    case 2:
                                        letraMN = "k";
                                        break;
                                    default:
                                        break;
                                }
                                Console.Write(auxVEC.MatrizVEC[i, j] + letraMN + "   ");
                            }
                            else
                            {
                                Console.Write(auxVEC.MatrizVEC[i, j] + "   ");
                            }
                        }
                    }
                    Console.ReadLine();
                    break;
                }
                else
                {
                    if (auxVEC.sigVEC == null)
                    {
                        validacionbusqueda = false;
                    }
                }

                auxVEC = auxVEC.sigVEC;
            }

            if (validacionbusqueda == true)
            {
                return 0;
            }
            else
            {
                Console.WriteLine("Warning: No se pudo imprimir");
                Console.WriteLine("Warning: No se encontro la informacion buscada");
                Console.ReadLine();
                return 1;
            }
        }
        public int BuscarVector(int numerocodigoso)
        {

            validacionbusqueda = false;
            auxVEC = inicioVEC;
            while (auxVEC != null)
            {
                if (auxVEC.CodigoVEC == numerocodigoso)
                {
                    validacionbusqueda = true;
                    VECAux = new float[auxVEC.ifilaVEC, auxVEC.icolumnaVEC];

                    ifilaAuxVEC = auxVEC.ifilaVEC;
                    icolumnaAuxVEC = auxVEC.icolumnaVEC;

                    for (int i = 0; i < auxVEC.ifilaVEC; i++)
                    {
                        for (int j = 0; j < auxVEC.icolumnaVEC; j++)
                        {
                            VECAux[i, j] = auxVEC.MatrizVEC[i, j];
                        }
                    }
                    Console.WriteLine(" ");
                    break;
                }
                else
                {

                    if (auxVEC.sigVEC == null)
                    {
                        validacionbusqueda = false;
                        Console.ReadLine();
                    }
                }

                auxVEC = auxVEC.sigVEC;
            }

            if (validacionbusqueda == true)
            {
                return 0;
            }
            else
            {
                Console.WriteLine("Warning: No se encontro informacion disponible para la operacion");
                Console.ReadLine();
                return 1;
            }
        }
        public int EliminarVector(int numerocodigoso)
        {
            validacionbusqueda = false;
            auxVEC = inicioVEC;

            while (auxVEC != null)
            {
                if (auxVEC.CodigoVEC == numerocodigoso)
                {
                    validacionbusqueda = true;
                    eliminarVEC = new VECNodo();
                    eliminarVEC = auxVEC;

                    if (eliminarVEC.sigVEC == null && eliminarVEC.antVEC == null) // Solo esta el inicio
                    {
                        eliminarVEC = inicioVEC;
                        inicioVEC = null;
                        auxVEC = null;
                        eliminarVEC = null;
                    }
                    else if (eliminarVEC.antVEC == null) // Eliminar nodo y no hay nada antes
                    {
                        //auxMN = auxMN.sigMN;
                        inicioVEC = eliminarVEC.sigVEC;
                        inicioVEC.sigVEC = null;
                        inicioVEC.antVEC = null;
                        eliminarVEC = null;
                    }
                    else if (eliminarVEC.sigVEC == null) // Eliminar nodo y no hay nada despues
                    {
                        auxVEC = eliminarVEC.antVEC;
                        eliminarVEC.antVEC.sigVEC = null;
                        finVEC = auxVEC;
                        eliminarVEC = null;
                    }
                    else // Eliminar el de enmedio
                    {
                        auxVEC = eliminarVEC.antVEC;
                        auxVEC.sigVEC = eliminarVEC.sigVEC;
                        eliminarVEC.sigVEC.antVEC = auxVEC;
                        eliminarVEC = null;
                    }

                    Console.WriteLine("MATRIZ ELIMINADA");
                    Console.ReadLine();
                    break;

                }
                else
                {
                    if (auxVEC.sigVEC == null)
                    {
                        validacionbusqueda = false;
                    }
                }

                auxVEC = auxVEC.sigVEC;
            }

            if (validacionbusqueda == true)
            {
                return 0;
            }
            else
            {
                Console.WriteLine("Warning: No se pudo eliminar");
                Console.WriteLine("Warning: No se encontro la informacion buscada");
                Console.ReadLine();
                return 1;
            }
        }
        public int ModificarVector(int numerocodigoso)
        {
            validacionbusqueda = false;
            auxVEC = inicioVEC;
            while (auxVEC != null)
            {
                if (auxVEC.CodigoVEC == numerocodigoso)
                {

                    validacionbusqueda = true;
                    // FILAS
                    ifilaVEC = 1;
                    auxVEC.ifilaVEC = ifilaVEC;

                    // COLUMNAS
                    do
                    {
                        volver = false;
                        Console.WriteLine(" Columnas");
                        string columna = Console.ReadLine();
                        int cantidad = columna.Length;
                        if (VC.Contador(cantidad, columna) == 0 && VC.Ceros(columna) == 0)
                        {
                            icolumnaVEC = Convert.ToInt32(columna); // convierte a int
                            auxVEC.icolumnaVEC = icolumnaVEC;
                            if (icolumnaVEC > 0)
                            {
                                volver = false;
                                auxVEC.icolumnaVEC = icolumnaVEC;
                            }
                            else
                            {
                                Console.WriteLine("Warning: Caracter invalido");
                                volver = true;
                            }
                        }
                        else
                        {
                            volver = true;
                        }
                    } while (volver != false);

                    // LLENA LA MATRIZ DE DATOS
                    auxVEC.MatrizVEC = new float[ifilaVEC, icolumnaVEC];
                    for (int i = 0; i < ifilaVEC; i++)
                    {
                        for (int j = 0; j < icolumnaVEC; j++)
                        {
                            do
                            {
                                volver = false;
                                Console.WriteLine(" Escribe el numero que ira en la matriz posicion:" + "[" + i + " , " + j + "]");
                                string numeromatriz = Console.ReadLine();
                                int cantidad = numeromatriz.Length;
                                if (VC.Contador(cantidad, numeromatriz) == 0)
                                {
                                    volver = false;
                                    float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                                    inumeromatriz = (float)Math.Round(inumeromatriz, 2);
                                    auxVEC.MatrizVEC[i, j] = inumeromatriz;
                                }
                                else
                                {
                                    volver = true;
                                }
                            } while (volver != false);
                        }
                    }
                    Console.WriteLine(" ");
                    break;
                }
                else
                {

                    if (auxVEC.sigVEC == null)
                    {
                        validacionbusqueda = false;
                        Console.ReadLine();
                    }
                }

                auxVEC = auxVEC.sigVEC;
            }

            if (validacionbusqueda == true)
            {
                return 0;
            }
            else
            {
                Console.WriteLine("Warning: No se encontro informacion disponible para la operacion");
                Console.ReadLine();
                return 1;
            }



        }
        public int ModificarVectorEspecifica(int numerocodigoso)
        {
            validacionbusqueda = false;
            auxVEC = inicioVEC;
            while (auxVEC != null)
            {
                if (auxVEC.CodigoVEC == numerocodigoso)
                {
                    // PIDE FILAS Y COLUMNAS PARA MODIFICAR

                    ifilaAVEC = 1;

                    do
                    {
                        volvervolver = false;
                        Console.WriteLine(" Escriba la columna de la matriz que busca");
                        string numerosho = Console.ReadLine();

                        int cantidad = numerosho.Length;
                        if (VC.Contador(cantidad, numerosho) == 0)
                        {
                            volvervolver = false;
                            icolumnaAVEC = Convert.ToInt32(numerosho); // convierte a int
                        }
                        else
                        {
                            volvervolver = true;
                        }
                    } while (volvervolver != false);


                    auxVEC = inicioVEC;
                    while (auxVEC != null)
                    {
                        if (auxVEC.CodigoVEC == numerocodigoso)
                        {
                            if (ifilaAVEC < auxVEC.ifilaVEC && icolumnaAVEC < auxVEC.icolumnaVEC)
                            {
                                validacionbusqueda = true;
                                for (int i = 0; i < auxVEC.ifilaVEC; i++)
                                {
                                    for (int j = 0; j < auxVEC.icolumnaVEC; j++)
                                    {

                                        if (ifilaAVEC == i && icolumnaAVEC == j)
                                        {
                                            do
                                            {
                                                volver = false;
                                                Console.WriteLine(" Escribe el numero que ira en el VECTOR posicion:" + "[" + i + " , " + j + "]");
                                                string numeromatriz = Console.ReadLine();
                                                int cantidad = numeromatriz.Length;
                                                if (VC.Contador(cantidad, numeromatriz) == 0)
                                                {
                                                    volver = false;
                                                    ///float inumeromatriz = Convert.ToInt32(numeromatriz); // convierte a int
                                                    float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                                                    inumeromatriz = (float)Math.Round(inumeromatriz, 2);
                                                    auxVEC.MatrizVEC[i, j] = inumeromatriz;


                                                    Console.WriteLine(" El numero que ira en el VECTOR posicion:" + "[" + i + " , " + j + "]" + " ahora sera: " + auxVEC.MatrizVEC[i, j] + "   ");
                                                    ImprimirVectorEspecifica(auxVEC.CodigoVEC);
                                                    break;

                                                }
                                                else
                                                {
                                                    volver = true;
                                                }
                                            } while (volver != false);


                                        }


                                    }

                                }

                            }
                            else
                            {
                                validacionbusqueda = false;
                                break;
                            }


                            break;
                        }
                        else
                        {
                            if (auxVEC.sigVEC == null)
                            {
                                validacionbusqueda = false;
                                Console.ReadLine();
                            }
                        }

                        auxVEC = auxVEC.sigVEC;
                    }

                    if (validacionbusqueda == true)
                    {
                        return 0;
                    }
                    else
                    {
                        Console.WriteLine("Warning: No se encontro informacion disponible para la operacion");
                        return 1;
                    }



                }

                auxVEC = auxVEC.sigVEC;

            }

            if (validacionbusqueda == true)
            {
                return 0;
            }
            else
            {
                Console.WriteLine("Warning: No se encontro informacion disponible para la operacion");
                Console.ReadLine();
                return 1;
            }
        }
        public void AgregarVectorResultado(int ifilaaux, int icolumnaaux)
        {
            nuevoVEC = new VECNodo();
            // CONTADOR
            if (inicioVEC == null)
            {
                nuevoVEC.CodigoVEC = 1;
                numerocodigoVEC = nuevoVEC.CodigoVEC;
            }
            else
            {
                numerocodigoVEC += 1;
                nuevoVEC.CodigoVEC = numerocodigoVEC;
            }

            numerocodigoAuxVEC = numerocodigoVEC;

            nuevoVEC.ifilaVEC = ifilaaux;
            nuevoVEC.icolumnaVEC = icolumnaaux;

            // LLENA LA MATRIZ DE DATOS
            nuevoVEC.MatrizVEC = new float[ifilaaux, icolumnaaux];
            for (int i = 0; i < ifilaaux; i++)
            {
                for (int j = 0; j < icolumnaaux; j++)
                {
                    nuevoVEC.MatrizVEC[i, j] = VEC03[i, j];
                }
            }


            if (inicioVEC == null)
            {
                inicioVEC = nuevoVEC;
                finVEC = inicioVEC;
            }
            else
            {
                finVEC.sigVEC = nuevoVEC;
                auxVEC = finVEC;
                finVEC = finVEC.sigVEC;
                finVEC.antVEC = auxVEC;
                finVEC.sigVEC = null;
            }

        }

        // |||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

        // COMPONENTES PARA MATRIZ COMPUESTA
        public MCNodo inicioMC
        {
            get { return INICIOMC; }
            set { INICIOMC = value; }
        }
        public MCNodo finMC
        {
            get { return FINMC; }
            set { FINMC = value; }
        }
        public MCNodo nuevoMC
        {
            get { return NUEVOMC; }
            set { NUEVOMC = value; }
        }
        public MCNodo auxMC
        {
            get { return AUXMC; }
            set { AUXMC = value; }
        }
        public MCNodo eliminarMC
        {
            get { return ELIMINARMC; }
            set { ELIMINARMC = value; }
        }
        // FUNCIONES PARA MATRIZ COMPUESTA
        public void AgregarMatrizCompuesta()
        {
            nuevoMC = new MCNodo();
            int filaPMC = 1;
            int columnaPMC = 3;
            ifilaMC = 4;
            icolumnaMC = 4;
            volver = false;
            bool SiMatrizA = false;

            //    icelula = Convert.ToInt32(scedula); // convierte a int


            // CONTADOR
            if (inicioMC == null)
            {
                nuevoMC.CodigoMC = 1;
                numerocodigoMC = nuevoMC.CodigoMC;
            }
            else
            {
                //auxMN = inicioMN;
                //while (auxMN != null)
                //{
                //    nuevoMN.CodigoMN = auxMN.CodigoMN + 1;
                //    auxMN = auxMN.sigMN;
                //}

                numerocodigoMC += 1;
                nuevoMC.CodigoMC = numerocodigoMC;
            }

            numerocodigoAuxMC = numerocodigoMC;

            // FILAS
            nuevoMC.ifilaMC = ifilaMC;
            nuevoMC.ifilaPuntoMC = filaPMC;

            // COLUMNAS
            nuevoMC.icolumnaMC = icolumnaMC;
            nuevoMC.icolumnaPuntoMC = columnaPMC;

            do
            {
                volver = false;
                Console.WriteLine(" Escriba la opcion deseada: 0 Traslacion | 1 Rotacion | 2 Escalar");
                string numeromatriz = Console.ReadLine();
                int cantidad = numeromatriz.Length;
                if (VC.Contador(cantidad, numeromatriz) == 0)
                {
                    float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                    if (inumeromatriz == 0 || inumeromatriz == 1 || inumeromatriz == 2)
                    {
                        inumeromatriz = (float)Math.Round(inumeromatriz, 2);
                        nuevoMC.TipoOperacionMC = inumeromatriz;
                        SiMatrizA = true;
                        volver = false;
                    }
                    else
                    {
                        SiMatrizA = false;
                        volver = true;
                    }
                }
                else
                {
                    SiMatrizA = false;
                    volver = true;
                }
            } while (volver != false);
            if (nuevoMC.TipoOperacionMC == 1)
            {
                do
                {
                    volver = false;
                    Console.WriteLine(" Escriba la opcion deseada: 0 Rotar en X | 1 Rotar en Y | 2 Rotar en Z");
                    string numeromatriz = Console.ReadLine();
                    int cantidad = numeromatriz.Length;
                    if (VC.Contador(cantidad, numeromatriz) == 0)
                    {
                        
                        float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                        if (inumeromatriz == 0 || inumeromatriz == 1 || inumeromatriz == 2)
                        {
                            inumeromatriz = (float)Math.Round(inumeromatriz, 2);
                            nuevoMC.RotxyzMC = inumeromatriz;
                            SiMatrizA = true;
                            volver = false;
                        }
                        else
                        {
                            SiMatrizA = false;
                            volver = true;
                        }
                    }
                    else
                    {
                        SiMatrizA = false;
                        volver = true;
                    }
                } while (volver != false);

                do
                {
                    volver = false;
                    Console.WriteLine("Angulo");
                    string angulosho = Console.ReadLine();
                    int cantidad = angulosho.Length;
                    if (VC.Contador(cantidad, angulosho) == 0 && VC.Ceros(angulosho) == 0)
                    {
                        float inumeroangulosho = (float)Convert.ToDouble(angulosho);
                        inumeroangulosho = (float)Math.Round(inumeroangulosho, 2);
                        nuevoMC.AnguloMC = inumeroangulosho;
                        SiMatrizA = true;

                    }
                    else
                    {
                        volver = true;
                    }
                } while (volver != false);
            }
            else
            {
                nuevoMC.RotxyzMC = 3;
                nuevoMC.AnguloMC = 0;
            }


            nuevoMC.MatrizMC = new float[ifilaMC, icolumnaMC];
            nuevoMC.PuntoMC = new float[filaPMC, columnaPMC];
            // LLENA LA MATRIZ DE DATOS
            if (nuevoMC.TipoOperacionMC != 1)
            {
                for (int i = 0; i < filaPMC; i++)
                {
                    for (int j = 0; j < columnaPMC; j++)
                    {
                        if (j == 3)
                        {
                            nuevoMC.PuntoMC[i, j] = 1;
                        }
                        else
                        {
                            do
                            {
                                volver = false;
                                switch (j)
                                {
                                    case 0:
                                        letraCN = "x";
                                        break;
                                    case 1:
                                        letraCN = "y";
                                        break;
                                    case 2:
                                        letraCN = "z";
                                        break;
                                    default:
                                        break;
                                }
                                Console.WriteLine(" Escribe el numero que ira en el PUNTO posicion:" + letraCN);
                                string numeromatriz = Console.ReadLine();
                                int cantidad = numeromatriz.Length;
                                if (VC.Contador(cantidad, numeromatriz) == 0)
                                {
                                    volver = false;
                                    ///float inumeromatriz = Convert.ToInt32(numeromatriz); // convierte a int
                                    float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                                    inumeromatriz = (float)Math.Round(inumeromatriz, 2);
                                    nuevoMC.PuntoMC[i, j] = inumeromatriz;
                                }
                                else
                                {
                                    volver = true;
                                }
                            } while (volver != false);
                        }
                    }
                }
            }

            switch (nuevoMC.TipoOperacionMC)
            {
                case 0:
                    {
                        //TRASLACION
                        nuevoMC.MatrizMC[0, 0] = 1;
                        nuevoMC.MatrizMC[0, 1] = 0;
                        nuevoMC.MatrizMC[0, 2] = 0;
                        nuevoMC.MatrizMC[0, 3] = nuevoMC.PuntoMC[0,0];

                        nuevoMC.MatrizMC[1, 0] = 0;
                        nuevoMC.MatrizMC[1, 1] = 1;
                        nuevoMC.MatrizMC[1, 2] = 0;
                        nuevoMC.MatrizMC[1, 3] = nuevoMC.PuntoMC[0, 1];

                        nuevoMC.MatrizMC[2, 0] = 0;
                        nuevoMC.MatrizMC[2, 1] = 0;
                        nuevoMC.MatrizMC[2, 2] = 1;
                        nuevoMC.MatrizMC[2, 3] = nuevoMC.PuntoMC[0, 2];

                        nuevoMC.MatrizMC[3, 0] = 0;
                        nuevoMC.MatrizMC[3, 1] = 0;
                        nuevoMC.MatrizMC[3, 2] = 0;
                        nuevoMC.MatrizMC[3, 3] = 1;

                        break;
                    }
                case 1:
                    {
                        double anguloshoshosho = Math.PI* nuevoMC.AnguloMC / 180.0;
                        float coscos = (float)Math.Cos(anguloshoshosho);
                        coscos = (float)Math.Round(coscos, 2);
                        float sensen = (float)Math.Sin(anguloshoshosho);
                        sensen = (float)Math.Round(sensen, 2);

                        float negativosensen = sensen * (-1);
                        negativosensen = (float)Math.Round(negativosensen,2);

                        switch (nuevoMC.RotxyzMC)
                        {
                            case 0:
                                {
                                    // Rotacion fila/columna
                                    nuevoMC.MatrizMC[0, 0] = 1;
                                    nuevoMC.MatrizMC[0, 1] = 0;
                                    nuevoMC.MatrizMC[0, 2] = 0;
                                    nuevoMC.MatrizMC[0, 3] = 0;

                                    nuevoMC.MatrizMC[1, 0] = 0;
                                    nuevoMC.MatrizMC[1, 1] = coscos;
                                    nuevoMC.MatrizMC[1, 2] = negativosensen;
                                    nuevoMC.MatrizMC[1, 3] = 0;

                                    nuevoMC.MatrizMC[2, 0] = 0;
                                    nuevoMC.MatrizMC[2, 1] = sensen;
                                    nuevoMC.MatrizMC[2, 2] = coscos;
                                    nuevoMC.MatrizMC[2, 3] = 0;

                                    nuevoMC.MatrizMC[3, 0] = 0;
                                    nuevoMC.MatrizMC[3, 1] = 0;
                                    nuevoMC.MatrizMC[3, 2] = 0;
                                    nuevoMC.MatrizMC[3, 3] = 1;

                                    break;
                                }
                            case 1:
                                {
                                    // Traslacion fila/columna
                                    nuevoMC.MatrizMC[0, 0] = coscos;
                                    nuevoMC.MatrizMC[0, 1] = 0;
                                    nuevoMC.MatrizMC[0, 2] = sensen;
                                    nuevoMC.MatrizMC[0, 3] = 0;

                                    nuevoMC.MatrizMC[1, 0] = 0;
                                    nuevoMC.MatrizMC[1, 1] = 1;
                                    nuevoMC.MatrizMC[1, 2] = 0;
                                    nuevoMC.MatrizMC[1, 3] = 0;

                                    nuevoMC.MatrizMC[2, 0] = negativosensen;
                                    nuevoMC.MatrizMC[2, 1] = 0;
                                    nuevoMC.MatrizMC[2, 2] = coscos;
                                    nuevoMC.MatrizMC[2, 3] = 0;

                                    nuevoMC.MatrizMC[3, 0] = 0;
                                    nuevoMC.MatrizMC[3, 1] = 0;
                                    nuevoMC.MatrizMC[3, 2] = 0;
                                    nuevoMC.MatrizMC[3, 3] = 1;
                                    
                                    break;
                                }
                            case 2:
                                {
                                    // Traslacion fila/columna
                                    nuevoMC.MatrizMC[0, 0] = coscos;
                                    nuevoMC.MatrizMC[0, 1] = negativosensen;
                                    nuevoMC.MatrizMC[0, 2] = 0;
                                    nuevoMC.MatrizMC[0, 3] = 0;

                                    nuevoMC.MatrizMC[1, 0] = sensen;
                                    nuevoMC.MatrizMC[1, 1] = coscos;
                                    nuevoMC.MatrizMC[1, 2] = 0;
                                    nuevoMC.MatrizMC[1, 3] = 0;

                                    nuevoMC.MatrizMC[2, 0] = 0;
                                    nuevoMC.MatrizMC[2, 1] = 0;
                                    nuevoMC.MatrizMC[2, 2] = 1;
                                    nuevoMC.MatrizMC[2, 3] = 0;

                                    nuevoMC.MatrizMC[3, 0] = 0;
                                    nuevoMC.MatrizMC[3, 1] = 0;
                                    nuevoMC.MatrizMC[3, 2] = 0;
                                    nuevoMC.MatrizMC[3, 3] = 1;
                                    break;
                                }
                            default:
                                break;
                        }
                        break;
                    }
                case 2:
                    {
                        // ESCALAR
                        nuevoMC.MatrizMC[0, 0] = nuevoMC.PuntoMC[0, 0];
                        nuevoMC.MatrizMC[0, 1] = 0;
                        nuevoMC.MatrizMC[0, 2] = 0;
                        nuevoMC.MatrizMC[0, 3] = 0;

                        nuevoMC.MatrizMC[1, 0] = 0;
                        nuevoMC.MatrizMC[1, 1] = nuevoMC.PuntoMC[0, 1];
                        nuevoMC.MatrizMC[1, 2] = 0;
                        nuevoMC.MatrizMC[1, 3] = 0;

                        nuevoMC.MatrizMC[2, 0] = 0;
                        nuevoMC.MatrizMC[2, 1] = 0;
                        nuevoMC.MatrizMC[2, 2] = nuevoMC.PuntoMC[0, 2];
                        nuevoMC.MatrizMC[2, 3] = 0;

                        nuevoMC.MatrizMC[3, 0] = 0;
                        nuevoMC.MatrizMC[3, 1] = 0;
                        nuevoMC.MatrizMC[3, 2] = 0;
                        nuevoMC.MatrizMC[3, 3] = 1;
                        break;
                    }
                default:
                    break;
            }



            if (inicioMC == null)
            {
                inicioMC = nuevoMC;
                finMC = inicioMC;
            }
            else
            {
                finMC.sigMC = nuevoMC;
                auxMC = finMC;
                finMC = finMC.sigMC;
                finMC.antMC = auxMC;
                finMC.sigMC = null;
            }

        }
        public void ImprimirMatrizCompuesta()
        {
            auxMC = inicioMC;

            if (inicioMC == null)
            {
                Console.WriteLine("Warning: No se pudo imprimir");
                Console.WriteLine("Warning: No hay informacion que imprimir");
            }
            while (auxMC != null)
            {

                Console.WriteLine("-------------------------------------------------------------------    ");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(" Codigo: " + auxMC.CodigoMC + "  Con filas: " + auxMC.ifilaMC + "  Con Columnas: " + auxMC.icolumnaMC);
                Console.ForegroundColor = ConsoleColor.White;

                for (int i = 0; i < auxMC.ifilaMC; i++)
                {
                    Console.Write("\n");
                    for (int j = 0; j < auxMC.icolumnaMC; j++)
                    {
                        Console.Write(auxMC.MatrizMC[i, j] + "   ");
                    }
                }
                Console.WriteLine(" ");


                auxMC = auxMC.sigMC;
            }
            Console.ReadLine();
        }
        public int ImprimirMatrizCompuestaEspecifica(int numerocodigoso)
        {
            validacionbusqueda = false;
            auxMC = inicioMC;
            while (auxMC != null)
            {
                if (auxMC.CodigoMC == numerocodigoso)
                {
                    validacionbusqueda = true;
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine(" Codigo: " + auxMC.CodigoMC + "  Con filas: " + auxMC.ifilaMC + "  Con Columnas: " + auxMC.icolumnaMC);
                    Console.ForegroundColor = ConsoleColor.White;

                    for (int i = 0; i < auxMC.ifilaMC; i++)
                    {
                        Console.Write("\n");
                        for (int j = 0; j < auxMC.icolumnaMC; j++)
                        {
                            if (productuosocruzMC == true)
                            {
                                string letraMN = " ";
                                switch (j)
                                {
                                    case 0:
                                        letraMN = "i";
                                        break;
                                    case 1:
                                        letraMN = "j";
                                        break;
                                    case 2:
                                        letraMN = "k";
                                        break;
                                    default:
                                        break;
                                }
                                Console.Write(auxMC.MatrizMC[i, j] + letraMN + "   ");
                            }
                            else
                            {
                                Console.Write(auxMC.MatrizMC[i, j] + "   ");
                            }
                        }
                    }
                    Console.ReadLine();
                    break;
                }
                else
                {
                    if (auxMC.sigMC == null)
                    {
                        validacionbusqueda = false;
                    }
                }

                auxMC = auxMC.sigMC;
            }

            if (validacionbusqueda == true)
            {
                return 0;
            }
            else
            {
                Console.WriteLine("Warning: No se pudo imprimir");
                Console.WriteLine("Warning: No se encontro la informacion buscada");
                Console.ReadLine();
                return 1;
            }
        }
        public int BuscarMatrizCompuesta(int numerocodigoso)
        {

            validacionbusqueda = false;
            auxMC = inicioMC;
            while (auxMC != null)
            {
                if (auxMC.CodigoMC == numerocodigoso)
                {
                    validacionbusqueda = true;
                    MCAux = new float[auxMC.ifilaMC, auxMC.icolumnaMC];

                    ifilaAuxMC = auxMC.ifilaMC;
                    icolumnaAuxMC = auxMC.icolumnaMC;

                    for (int i = 0; i < auxMC.ifilaMC; i++)
                    {
                        for (int j = 0; j < auxMC.icolumnaMC; j++)
                        {
                            MCAux[i, j] = auxMC.MatrizMC[i, j];
                        }
                    }
                    Console.WriteLine(" ");
                    break;
                }
                else
                {

                    if (auxMC.sigMC == null)
                    {
                        validacionbusqueda = false;
                        Console.ReadLine();
                    }
                }

                auxMC = auxMC.sigMC;
            }

            if (validacionbusqueda == true)
            {
                return 0;
            }
            else
            {
                Console.WriteLine("Warning: No se encontro informacion disponible para la operacion");
                Console.ReadLine();
                return 1;
            }
        }
        public int EliminarMatrizCompuesta(int numerocodigoso)
        {
            validacionbusqueda = false;
            auxMC = inicioMC;

            while (auxMC != null)
            {
                if (auxMC.CodigoMC == numerocodigoso)
                {
                    validacionbusqueda = true;
                    eliminarMC = new MCNodo();
                    eliminarMC = auxMC;

                    if (eliminarMC.sigMC == null && eliminarMC.antMC == null) // Solo esta el inicio
                    {
                        eliminarMC = inicioMC;
                        inicioMC = null;
                        auxMC = null;
                        eliminarMC = null;
                    }
                    else if (eliminarMC.antMC == null) // Eliminar nodo y no hay nada antes
                    {
                        //auxMN = auxMN.sigMN;
                        inicioMC = eliminarMC.sigMC;
                        inicioMC.sigMC = null;
                        inicioMC.antMC = null;
                        eliminarMC = null;
                    }
                    else if (eliminarMC.sigMC == null) // Eliminar nodo y no hay nada despues
                    {
                        auxMC = eliminarMC.antMC;
                        eliminarMC.antMC.sigMC = null;
                        finMC = auxMC;
                        eliminarMC = null;
                    }
                    else // Eliminar el de enmedio
                    {
                        auxMC = eliminarMC.antMC;
                        auxMC.sigMC = eliminarMC.sigMC;
                        eliminarMC.sigMC.antMC = auxMC;
                        eliminarMC = null;
                    }

                    Console.WriteLine("MATRIZ ELIMINADA");
                    Console.ReadLine();
                    break;

                }
                else
                {
                    if (auxMC.sigMC == null)
                    {
                        validacionbusqueda = false;
                    }
                }

                auxMC = auxMC.sigMC;
            }

            if (validacionbusqueda == true)
            {
                return 0;
            }
            else
            {
                Console.WriteLine("Warning: No se pudo eliminar");
                Console.WriteLine("Warning: No se encontro la informacion buscada");
                Console.ReadLine();
                return 1;
            }
        }
        public int ModificarMatrizCompuesta(int numerocodigoso)
        {
            validacionbusqueda = false;
            auxMC = inicioMC;
            while (auxMC != null)
            {
                if (auxMC.CodigoMC == numerocodigoso)
                {
                    int filaPMC = 1;
                    int columnaPMC = 3;
                    ifilaMC = 4;
                    icolumnaMC = 4;
                    validacionbusqueda = true;
                    bool SiMatrizA = false;

                    numerocodigoAuxMC = numerocodigoMC;

                    // FILAS
                    auxMC.ifilaMC = ifilaMC;
                    auxMC.ifilaPuntoMC = filaPMC;

                    // COLUMNAS
                    auxMC.icolumnaMC = icolumnaMC;
                    auxMC.icolumnaPuntoMC = columnaPMC;

                    do
                    {
                        volver = false;
                        Console.WriteLine(" Escriba la opcion deseada: 0 Traslacion | 1 Rotacion | 2 Escalar");
                        string numeromatriz = Console.ReadLine();
                        int cantidad = numeromatriz.Length;
                        if (VC.Contador(cantidad, numeromatriz) == 0)
                        {
                            float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                            if (inumeromatriz == 0 || inumeromatriz == 1 || inumeromatriz == 2)
                            {
                                inumeromatriz = (float)Math.Round(inumeromatriz, 2);
                                auxMC.TipoOperacionMC = inumeromatriz;
                                SiMatrizA = true;
                                volver = false;
                            }
                            else
                            {
                                SiMatrizA = false;
                                volver = true;
                            }
                        }
                        else
                        {
                            SiMatrizA = false;
                            volver = true;
                        }
                    } while (volver != false);
                    if (auxMC.TipoOperacionMC == 1)
                    {
                        do
                        {
                            volver = false;
                            Console.WriteLine(" Escriba la opcion deseada: 0 Rotar en X | 1 Rotar en Y | 2 Rotar en Z");
                            string numeromatriz = Console.ReadLine();
                            int cantidad = numeromatriz.Length;
                            if (VC.Contador(cantidad, numeromatriz) == 0)
                            {

                                float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                                if (inumeromatriz == 0 || inumeromatriz == 1 || inumeromatriz == 2)
                                {
                                    inumeromatriz = (float)Math.Round(inumeromatriz, 2);
                                    auxMC.RotxyzMC = inumeromatriz;
                                    SiMatrizA = true;
                                    volver = false;
                                }
                                else
                                {
                                    SiMatrizA = false;
                                    volver = true;
                                }
                            }
                            else
                            {
                                SiMatrizA = false;
                                volver = true;
                            }
                        } while (volver != false);

                        do
                        {
                            volver = false;
                            Console.WriteLine("Angulo");
                            string angulosho = Console.ReadLine();
                            int cantidad = angulosho.Length;
                            if (VC.Contador(cantidad, angulosho) == 0 && VC.Ceros(angulosho) == 0)
                            {
                                float inumeroangulosho = (float)Convert.ToDouble(angulosho);
                                inumeroangulosho = (float)Math.Round(inumeroangulosho, 2);
                                auxMC.AnguloMC = inumeroangulosho;
                                SiMatrizA = true;

                            }
                            else
                            {
                                volver = true;
                            }
                        } while (volver != false);
                    }
                    else
                    {
                        auxMC.RotxyzMC = 3;
                        auxMC.AnguloMC = 0;
                    }


                    auxMC.MatrizMC = new float[ifilaMC, icolumnaMC];
                    auxMC.PuntoMC = new float[filaPMC, columnaPMC];
                    // LLENA LA MATRIZ DE DATOS
                    if (auxMC.TipoOperacionMC != 1)
                    {
                        for (int i = 0; i < filaPMC; i++)
                        {
                            for (int j = 0; j < columnaPMC; j++)
                            {
                                if (j == 3)
                                {
                                    auxMC.PuntoMC[i, j] = 1;
                                }
                                else
                                {
                                    do
                                    {
                                        volver = false;
                                        switch (j)
                                        {
                                            case 0:
                                                letraCN = "x";
                                                break;
                                            case 1:
                                                letraCN = "y";
                                                break;
                                            case 2:
                                                letraCN = "z";
                                                break;
                                            default:
                                                break;
                                        }
                                        Console.WriteLine(" Escribe el numero que ira en el PUNTO posicion:" + letraCN);
                                        string numeromatriz = Console.ReadLine();
                                        int cantidad = numeromatriz.Length;
                                        if (VC.Contador(cantidad, numeromatriz) == 0)
                                        {
                                            volver = false;
                                            ///float inumeromatriz = Convert.ToInt32(numeromatriz); // convierte a int
                                            float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                                            inumeromatriz = (float)Math.Round(inumeromatriz, 2);
                                            auxMC.PuntoMC[i, j] = inumeromatriz;
                                        }
                                        else
                                        {
                                            volver = true;
                                        }
                                    } while (volver != false);
                                }
                            }
                        }
                    }

                    switch (auxMC.TipoOperacionMC)
                    {
                        case 0:
                            {
                                //TRASLACION
                                auxMC.MatrizMC[0, 0] = 1;
                                auxMC.MatrizMC[0, 1] = 0;
                                auxMC.MatrizMC[0, 2] = 0;
                                auxMC.MatrizMC[0, 3] = auxMC.PuntoMC[0, 0];

                                auxMC.MatrizMC[1, 0] = 0;
                                auxMC.MatrizMC[1, 1] = 1;
                                auxMC.MatrizMC[1, 2] = 0;
                                auxMC.MatrizMC[1, 3] = auxMC.PuntoMC[0, 1];

                                auxMC.MatrizMC[2, 0] = 0;
                                auxMC.MatrizMC[2, 1] = 0;
                                auxMC.MatrizMC[2, 2] = 1;
                                auxMC.MatrizMC[2, 3] = auxMC.PuntoMC[0, 2];

                                auxMC.MatrizMC[3, 0] = 0;
                                auxMC.MatrizMC[3, 1] = 0;
                                auxMC.MatrizMC[3, 2] = 0;
                                auxMC.MatrizMC[3, 3] = 1;

                                break;
                            }
                        case 1:
                            {
                                double anguloshoshosho = Math.PI * nuevoMC.AnguloMC / 180.0;
                                float coscos = (float)Math.Cos(anguloshoshosho);
                                coscos = (float)Math.Round(coscos, 2);
                                float sensen = (float)Math.Sin(anguloshoshosho);
                                sensen = (float)Math.Round(sensen, 2);

                                float negativosensen = sensen * (-1);
                                negativosensen = (float)Math.Round(negativosensen, 2);

                                switch (auxMC.RotxyzMC)
                                {
                                    case 0:
                                        {
                                            // Rotacion fila/columna
                                            auxMC.MatrizMC[0, 0] = 1;
                                            auxMC.MatrizMC[0, 1] = 0;
                                            auxMC.MatrizMC[0, 2] = 0;
                                            auxMC.MatrizMC[0, 3] = 0;

                                            auxMC.MatrizMC[1, 0] = 0;
                                            auxMC.MatrizMC[1, 1] = coscos;
                                            auxMC.MatrizMC[1, 2] = negativosensen;
                                            auxMC.MatrizMC[1, 3] = 0;

                                            auxMC.MatrizMC[2, 0] = 0;
                                            auxMC.MatrizMC[2, 1] = sensen;
                                            auxMC.MatrizMC[2, 2] = coscos;
                                            auxMC.MatrizMC[2, 3] = 0;

                                            auxMC.MatrizMC[3, 0] = 0;
                                            auxMC.MatrizMC[3, 1] = 0;
                                            auxMC.MatrizMC[3, 2] = 0;
                                            auxMC.MatrizMC[3, 3] = 1;

                                            break;
                                        }
                                    case 1:
                                        {
                                            // Traslacion fila/columna
                                            auxMC.MatrizMC[0, 0] = coscos;
                                            auxMC.MatrizMC[0, 1] = 0;
                                            auxMC.MatrizMC[0, 2] = sensen;
                                            auxMC.MatrizMC[0, 3] = 0;

                                            auxMC.MatrizMC[1, 0] = 0;
                                            auxMC.MatrizMC[1, 1] = 1;
                                            auxMC.MatrizMC[1, 2] = 0;
                                            auxMC.MatrizMC[1, 3] = 0;

                                            auxMC.MatrizMC[2, 0] = negativosensen;
                                            auxMC.MatrizMC[2, 1] = 0;
                                            auxMC.MatrizMC[2, 2] = coscos;
                                            auxMC.MatrizMC[2, 3] = 0;

                                            auxMC.MatrizMC[3, 0] = 0;
                                            auxMC.MatrizMC[3, 1] = 0;
                                            auxMC.MatrizMC[3, 2] = 0;
                                            auxMC.MatrizMC[3, 3] = 1;

                                            break;
                                        }
                                    case 2:
                                        {
                                            // Traslacion fila/columna
                                            auxMC.MatrizMC[0, 0] = coscos;
                                            auxMC.MatrizMC[0, 1] = negativosensen;
                                            auxMC.MatrizMC[0, 2] = 0;
                                            auxMC.MatrizMC[0, 3] = 0;

                                            auxMC.MatrizMC[1, 0] = sensen;
                                            auxMC.MatrizMC[1, 1] = coscos;
                                            auxMC.MatrizMC[1, 2] = 0;
                                            auxMC.MatrizMC[1, 3] = 0;

                                            auxMC.MatrizMC[2, 0] = 0;
                                            auxMC.MatrizMC[2, 1] = 0;
                                            auxMC.MatrizMC[2, 2] = 1;
                                            auxMC.MatrizMC[2, 3] = 0;

                                            auxMC.MatrizMC[3, 0] = 0;
                                            auxMC.MatrizMC[3, 1] = 0;
                                            auxMC.MatrizMC[3, 2] = 0;
                                            auxMC.MatrizMC[3, 3] = 1;
                                            break;
                                        }
                                    default:
                                        break;
                                }
                                break;
                            }
                        case 2:
                            {
                                // ESCALAR
                                auxMC.MatrizMC[0, 0] = auxMC.PuntoMC[0, 0];
                                auxMC.MatrizMC[0, 1] = 0;
                                auxMC.MatrizMC[0, 2] = 0;
                                auxMC.MatrizMC[0, 3] = 0;

                                auxMC.MatrizMC[1, 0] = 0;
                                auxMC.MatrizMC[1, 1] = auxMC.PuntoMC[0, 1];
                                auxMC.MatrizMC[1, 2] = 0;
                                auxMC.MatrizMC[1, 3] = 0;

                                auxMC.MatrizMC[2, 0] = 0;
                                auxMC.MatrizMC[2, 1] = 0;
                                auxMC.MatrizMC[2, 2] = auxMC.PuntoMC[0, 2];
                                auxMC.MatrizMC[2, 3] = 0;

                                auxMC.MatrizMC[3, 0] = 0;
                                auxMC.MatrizMC[3, 1] = 0;
                                auxMC.MatrizMC[3, 2] = 0;
                                auxMC.MatrizMC[3, 3] = 1;
                                break;
                            }
                        default:
                            break;
                    }


                    break;
                }
                else
                {

                    if (auxMC.sigMC == null)
                    {
                        validacionbusqueda = false;
                        Console.ReadLine();
                    }
                }

                auxMC = auxMC.sigMC;
            }

            if (validacionbusqueda == true)
            {
                return 0;
            }
            else
            {
                Console.WriteLine("Warning: No se encontro informacion disponible para la operacion");
                Console.ReadLine();
                return 1;
            }



        }
        public int ModificarMatrizCompuestaEspecifica(int numerocodigoso)
        {
            validacionbusqueda = false;
            auxMC = inicioMC;
            while (auxMC != null)
            {
                if (auxMC.CodigoMC == numerocodigoso)
                {
                    // PIDE FILAS Y COLUMNAS PARA MODIFICAR
                    do
                    {
                        volvervolver = false;
                        Console.WriteLine(" Escriba la fila de la matriz que busca");
                        string numerosho = Console.ReadLine();

                        int cantidad = numerosho.Length;
                        if (VC.Contador(cantidad, numerosho) == 0)
                        {
                            volvervolver = false;
                            ifilaAMC = Convert.ToInt32(numerosho); // convierte a int
                        }
                        else
                        {
                            volvervolver = true;
                        }
                    } while (volvervolver != false);

                    do
                    {
                        volvervolver = false;
                        Console.WriteLine(" Escriba la columna de la matriz que busca");
                        string numerosho = Console.ReadLine();

                        int cantidad = numerosho.Length;
                        if (VC.Contador(cantidad, numerosho) == 0)
                        {
                            volvervolver = false;
                            icolumnaAMC = Convert.ToInt32(numerosho); // convierte a int
                        }
                        else
                        {
                            volvervolver = true;
                        }
                    } while (volvervolver != false);


                    auxMC = inicioMC;
                    while (auxMC != null)
                    {
                        if (auxMC.CodigoMC == numerocodigoso)
                        {
                            if (ifilaAMC < auxMC.ifilaMC && icolumnaAMC < auxMC.icolumnaMC)
                            {
                                validacionbusqueda = true;
                                for (int i = 0; i < auxMC.ifilaMC; i++)
                                {
                                    for (int j = 0; j < auxMC.icolumnaMC; j++)
                                    {

                                        if (ifilaAMC == i && icolumnaAMC == j)
                                        {
                                            do
                                            {
                                                volver = false;
                                                Console.WriteLine(" Escribe el numero que ira en la matriz posicion:" + "[" + i + " , " + j + "]");
                                                string numeromatriz = Console.ReadLine();
                                                int cantidad = numeromatriz.Length;
                                                if (VC.Contador(cantidad, numeromatriz) == 0)
                                                {
                                                    volver = false;
                                                    ///float inumeromatriz = Convert.ToInt32(numeromatriz); // convierte a int
                                                    float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                                                    inumeromatriz = (float)Math.Round(inumeromatriz, 2);
                                                    auxMC.MatrizMC[i, j] = inumeromatriz;


                                                    Console.WriteLine(" El numero que ira en la matriz posicion:" + "[" + i + " , " + j + "]" + " ahora sera: " + auxMC.MatrizMC[i, j] + "   ");
                                                    ImprimirMatrizCompuestaEspecifica(auxMC.CodigoMC);
                                                    break;

                                                }
                                                else
                                                {
                                                    volver = true;
                                                }
                                            } while (volver != false);


                                        }


                                    }

                                }

                            }
                            else
                            {
                                validacionbusqueda = false;
                                break;
                            }


                            break;
                        }
                        else
                        {
                            if (auxMC.sigMC == null)
                            {
                                validacionbusqueda = false;
                                Console.ReadLine();
                            }
                        }

                        auxMC = auxMC.sigMC;
                    }

                    if (validacionbusqueda == true)
                    {
                        return 0;
                    }
                    else
                    {
                        Console.WriteLine("Warning: No se encontro informacion disponible para la operacion");
                        return 1;
                    }



                }

                auxMC = auxMC.sigMC;

            }

            if (validacionbusqueda == true)
            {
                return 0;
            }
            else
            {
                Console.WriteLine("Warning: No se encontro informacion disponible para la operacion");
                Console.ReadLine();
                return 1;
            }
        }
        public void AgregarMatrizCompuestaResultado(int ifilaaux, int icolumnaaux)
        {
            nuevoMC = new MCNodo();
            // CONTADOR
            if (inicioMC == null)
            {
                nuevoMC.CodigoMC = 1;
                numerocodigoMC = nuevoMC.CodigoMC;
            }
            else
            {
                numerocodigoMC += 1;
                nuevoMC.CodigoMC = numerocodigoMC;
            }

            numerocodigoAuxMC = numerocodigoMC;

            nuevoMC.ifilaMC = ifilaaux;
            nuevoMC.icolumnaMC = icolumnaaux;

            // LLENA LA MATRIZ DE DATOS
            nuevoMC.MatrizMC = new float[ifilaaux, icolumnaaux];
            for (int i = 0; i < ifilaaux; i++)
            {
                for (int j = 0; j < icolumnaaux; j++)
                {
                    nuevoMC.MatrizMC[i, j] = MC03[i, j];
                }
            }


            if (inicioMC == null)
            {
                inicioMC = nuevoMC;
                finMC = inicioMC;
            }
            else
            {
                finMC.sigMC = nuevoMC;
                auxMC = finMC;
                finMC = finMC.sigMC;
                finMC.antMC = auxMC;
                finMC.sigMC = null;
            }

        }


        // |||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

        // COMPONENTES PARA EL ALGORITMO BRESENHAM
        public ABNodo inicioAB
        {
            get { return INICIOAB; }
            set { INICIOAB = value; }
        }
        public ABNodo finAB
        {
            get { return FINAB; }
            set { FINAB = value; }
        }
        public ABNodo nuevoAB
        {
            get { return NUEVOAB; }
            set { NUEVOAB = value; }
        }
        public ABNodo auxAB
        {
            get { return AUXAB; }
            set { AUXAB = value; }
        }
        public ABNodo eliminarAB
        {
            get { return ELIMINARAB; }
            set { ELIMINARAB = value; }
        }
        // FUNCIONES PARA EL ALGORITMO BRESENHAM
        public void AgregarAlgoritmoBresenham()
        {
            nuevoAB = new ABNodo();
            ifilaAB = 0;
            icolumnaAB = 0;
            volver = false;

            //    icelula = Convert.ToInt32(scedula); // convierte a int


            // CONTADOR
            if (inicioAB == null)
            {
                nuevoAB.CodigoAB = 1;
                numerocodigoAB = nuevoAB.CodigoAB;
            }
            else
            {
                //auxMN = inicioMN;
                //while (auxMN != null)
                //{
                //    nuevoMN.CodigoMN = auxMN.CodigoMN + 1;
                //    auxMN = auxMN.sigMN;
                //}

                numerocodigoAB += 1;
                nuevoAB.CodigoAB = numerocodigoAB;
            }

            numerocodigoAuxAB = numerocodigoAB;

            // FILAS
            do
            {
                volver = false;
                Console.WriteLine(" filas");
                string fila = Console.ReadLine();
                int cantidad = fila.Length;
                if (VC.Contador(cantidad, fila) == 0 && VC.Ceros(fila) == 0)
                {
                    ifilaAB = Convert.ToInt32(fila); // convierte a int
                    if (ifilaAB > 0)
                    {
                        volver = false;
                        nuevoAB.ifilaAB = ifilaAB;
                    }
                    else
                    {
                        Console.WriteLine("Warning: Caracter invalido");
                        volver = true;
                    }
                }
                else
                {
                    volver = true;
                }
            } while (volver != false);

            // COLUMNAS
            do
            {
                volver = false;
                Console.WriteLine(" Columnas");
                string columna = Console.ReadLine();
                int cantidad = columna.Length;
                if (VC.Contador(cantidad, columna) == 0 && VC.Ceros(columna) == 0)
                {
                    icolumnaAB = Convert.ToInt32(columna); // convierte a int
                    nuevoAB.icolumnaAB = icolumnaAB;
                    if (icolumnaAB > 0)
                    {
                        volver = false;
                        nuevoAB.icolumnaAB = icolumnaAB;
                    }
                    else
                    {
                        Console.WriteLine("Warning: Caracter invalido");
                        volver = true;
                    }
                }
                else
                {
                    volver = true;
                }
            } while (volver != false);

            // LLENA LA MATRIZ DE DATOS
            nuevoAB.MatrizAB = new float[ifilaAB, icolumnaAB];
            for (int i = 0; i < ifilaAB; i++)
            {
                for (int j = 0; j < icolumnaAB; j++)
                {
                    do
                    {
                        volver = false;
                        Console.WriteLine(" Escribe el numero que ira en la matriz posicion:" + "[" + i + " , " + j + "]");
                        string numeromatriz = Console.ReadLine();
                        int cantidad = numeromatriz.Length;
                        if (VC.Contador(cantidad, numeromatriz) == 0)
                        {
                            volver = false;
                            ///float inumeromatriz = Convert.ToInt32(numeromatriz); // convierte a int
                            float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                            inumeromatriz = (float)Math.Round(inumeromatriz, 2);
                            nuevoAB.MatrizAB[i, j] = inumeromatriz;
                        }
                        else
                        {
                            volver = true;
                        }
                    } while (volver != false);
                }
            }


            if (inicioAB == null)
            {
                inicioAB = nuevoAB;
                finAB = inicioAB;
            }
            else
            {
                finAB.sigAB = nuevoAB;
                auxAB = finAB;
                finAB = finAB.sigAB;
                finAB.antAB = auxAB;
                finAB.sigAB = null;
            }

        }
        public void ImprimirAlgoritmoBresenham()
        {
            auxAB = inicioAB;

            if (inicioAB == null)
            {
                Console.WriteLine("Warning: No se pudo imprimir");
                Console.WriteLine("Warning: No hay informacion que imprimir");
            }
            while (auxAB != null)
            {

                Console.WriteLine("-------------------------------------------------------------------    ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(" Codigo: " + auxAB.CodigoAB + "  Con filas: " + auxAB.ifilaAB + "  Con Columnas: " + auxAB.icolumnaAB);
                Console.ForegroundColor = ConsoleColor.White;

                for (int i = 0; i < auxAB.ifilaAB; i++)
                {
                    Console.Write("\n");
                    for (int j = 0; j < auxAB.icolumnaAB; j++)
                    {
                        Console.Write(auxAB.MatrizAB[i, j] + "   ");
                    }
                }
                Console.WriteLine(" ");


                auxAB = auxAB.sigAB;
            }
            Console.ReadLine();
        }
        public int ImprimirAlgoritmoBresenhamEspecifica(int numerocodigoso)
        {
            validacionbusqueda = false;
            auxAB = inicioAB;
            while (auxAB != null)
            {
                if (auxAB.CodigoAB == numerocodigoso)
                {
                    validacionbusqueda = true;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(" Codigo: " + auxAB.CodigoAB + "  Con filas: " + auxAB.ifilaAB + "  Con Columnas: " + auxAB.icolumnaAB);
                    Console.ForegroundColor = ConsoleColor.White;

                    for (int i = 0; i < auxAB.ifilaAB; i++)
                    {
                        Console.Write("\n");
                        for (int j = 0; j < auxAB.icolumnaAB; j++)
                        {
                            if (productuosocruzAB == true)
                            {
                                string letraMN = " ";
                                switch (j)
                                {
                                    case 0:
                                        letraMN = "i";
                                        break;
                                    case 1:
                                        letraMN = "j";
                                        break;
                                    case 2:
                                        letraMN = "k";
                                        break;
                                    default:
                                        break;
                                }
                                Console.Write(auxAB.MatrizAB[i, j] + letraMN + "   ");
                            }
                            else
                            {
                                Console.Write(auxAB.MatrizAB[i, j] + "   ");
                            }
                        }
                    }
                    Console.ReadLine();
                    break;
                }
                else
                {
                    if (auxAB.sigAB == null)
                    {
                        validacionbusqueda = false;
                    }
                }

                auxAB = auxAB.sigAB;
            }

            if (validacionbusqueda == true)
            {
                return 0;
            }
            else
            {
                Console.WriteLine("Warning: No se pudo imprimir");
                Console.WriteLine("Warning: No se encontro la informacion buscada");
                Console.ReadLine();
                return 1;
            }
        }
        public int BuscarAlgoritmoBresenham(int numerocodigoso)
        {

            validacionbusqueda = false;
            auxAB = inicioAB;
            while (auxAB != null)
            {
                if (auxAB.CodigoAB == numerocodigoso)
                {
                    validacionbusqueda = true;
                    ABAux = new float[auxAB.ifilaAB, auxAB.icolumnaAB];

                    ifilaAuxAB = auxAB.ifilaAB;
                    icolumnaAuxAB = auxAB.icolumnaAB;

                    for (int i = 0; i < auxAB.ifilaAB; i++)
                    {
                        for (int j = 0; j < auxAB.icolumnaAB; j++)
                        {
                            ABAux[i, j] = auxAB.MatrizAB[i, j];
                        }
                    }
                    Console.WriteLine(" ");
                    break;
                }
                else
                {

                    if (auxAB.sigAB == null)
                    {
                        validacionbusqueda = false;
                        Console.ReadLine();
                    }
                }

                auxAB = auxAB.sigAB;
            }

            if (validacionbusqueda == true)
            {
                return 0;
            }
            else
            {
                Console.WriteLine("Warning: No se encontro informacion disponible para la operacion");
                Console.ReadLine();
                return 1;
            }
        }
        public int EliminarAlgoritmoBresenham(int numerocodigoso)
        {
            validacionbusqueda = false;
            auxAB = inicioAB;

            while (auxAB != null)
            {
                if (auxAB.CodigoAB == numerocodigoso)
                {
                    validacionbusqueda = true;
                    eliminarAB = new ABNodo();
                    eliminarAB = auxAB;

                    if (eliminarAB.sigAB == null && eliminarAB.antAB == null) // Solo esta el inicio
                    {
                        eliminarAB = inicioAB;
                        inicioAB = null;
                        auxAB = null;
                        eliminarAB = null;
                    }
                    else if (eliminarAB.antAB == null) // Eliminar nodo y no hay nada antes
                    {
                        //auxMN = auxMN.sigMN;
                        inicioAB = eliminarAB.sigAB;
                        inicioAB.sigAB = null;
                        inicioAB.antAB = null;
                        eliminarAB = null;
                    }
                    else if (eliminarAB.sigAB == null) // Eliminar nodo y no hay nada despues
                    {
                        auxAB = eliminarAB.antAB;
                        eliminarAB.antAB.sigAB = null;
                        finAB = auxAB;
                        eliminarAB = null;
                    }
                    else // Eliminar el de enmedio
                    {
                        auxAB = eliminarAB.antAB;
                        auxAB.sigAB = eliminarAB.sigAB;
                        eliminarAB.sigAB.antAB = auxAB;
                        eliminarAB = null;
                    }

                    Console.WriteLine("MATRIZ ELIMINADA");
                    Console.ReadLine();
                    break;

                }
                else
                {
                    if (auxAB.sigAB == null)
                    {
                        validacionbusqueda = false;
                    }
                }

                auxAB = auxAB.sigAB;
            }

            if (validacionbusqueda == true)
            {
                return 0;
            }
            else
            {
                Console.WriteLine("Warning: No se pudo eliminar");
                Console.WriteLine("Warning: No se encontro la informacion buscada");
                Console.ReadLine();
                return 1;
            }
        }
        public int ModificarAlgoritmoBresenham(int numerocodigoso)
        {
            validacionbusqueda = false;
            auxAB = inicioAB;
            while (auxAB != null)
            {
                if (auxAB.CodigoAB == numerocodigoso)
                {

                    validacionbusqueda = true;
                    // FILAS
                    do
                    {
                        ifilaAB = 0;
                        icolumnaAB = 0;
                        volver = false;
                        Console.WriteLine(" filas");
                        string fila = Console.ReadLine();
                        int cantidad = fila.Length;
                        if (VC.Contador(cantidad, fila) == 0 && VC.Ceros(fila) == 0)
                        {
                            ifilaAB = Convert.ToInt32(fila); // convierte a int
                            auxAB.ifilaAB = ifilaAB;
                            if (ifilaAB > 0)
                            {
                                volver = false;
                                nuevoAB.ifilaAB = ifilaAB;
                            }
                            else
                            {
                                Console.WriteLine("Warning: Caracter invalido");
                                volver = true;
                            }

                        }
                        else
                        {
                            volver = true;
                        }
                    } while (volver != false);

                    // COLUMNAS
                    do
                    {
                        volver = false;
                        Console.WriteLine(" Columnas");
                        string columna = Console.ReadLine();
                        int cantidad = columna.Length;
                        if (VC.Contador(cantidad, columna) == 0 && VC.Ceros(columna) == 0)
                        {
                            icolumnaAB = Convert.ToInt32(columna); // convierte a int
                            auxAB.icolumnaAB = icolumnaAB;
                            if (icolumnaAB > 0)
                            {
                                volver = false;
                                nuevoAB.icolumnaAB = icolumnaAB;
                            }
                            else
                            {
                                Console.WriteLine("Warning: Caracter invalido");
                                volver = true;
                            }
                        }
                        else
                        {
                            volver = true;
                        }
                    } while (volver != false);

                    // LLENA LA MATRIZ DE DATOS
                    auxAB.MatrizAB = new float[ifilaAB, icolumnaAB];
                    for (int i = 0; i < ifilaAB; i++)
                    {
                        for (int j = 0; j < icolumnaAB; j++)
                        {
                            do
                            {
                                volver = false;
                                Console.WriteLine(" Escribe el numero que ira en la matriz posicion:" + "[" + i + " , " + j + "]");
                                string numeromatriz = Console.ReadLine();
                                int cantidad = numeromatriz.Length;
                                if (VC.Contador(cantidad, numeromatriz) == 0)
                                {
                                    volver = false;
                                    float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                                    inumeromatriz = (float)Math.Round(inumeromatriz, 2);
                                    auxAB.MatrizAB[i, j] = inumeromatriz;
                                }
                                else
                                {
                                    volver = true;
                                }
                            } while (volver != false);
                        }
                    }
                    Console.WriteLine(" ");
                    break;
                }
                else
                {

                    if (auxAB.sigAB == null)
                    {
                        validacionbusqueda = false;
                        Console.ReadLine();
                    }
                }

                auxAB = auxAB.sigAB;
            }

            if (validacionbusqueda == true)
            {
                return 0;
            }
            else
            {
                Console.WriteLine("Warning: No se encontro informacion disponible para la operacion");
                Console.ReadLine();
                return 1;
            }



        }
        public int ModificarAlgoritmoBresenhamEspecifica(int numerocodigoso)
        {
            validacionbusqueda = false;
            auxAB = inicioAB;
            while (auxAB != null)
            {
                if (auxAB.CodigoAB == numerocodigoso)
                {
                    // PIDE FILAS Y COLUMNAS PARA MODIFICAR
                    do
                    {
                        volvervolver = false;
                        Console.WriteLine(" Escriba la fila de la matriz que busca");
                        string numerosho = Console.ReadLine();

                        int cantidad = numerosho.Length;
                        if (VC.Contador(cantidad, numerosho) == 0)
                        {
                            volvervolver = false;
                            ifilaAAB = Convert.ToInt32(numerosho); // convierte a int
                        }
                        else
                        {
                            volvervolver = true;
                        }
                    } while (volvervolver != false);

                    do
                    {
                        volvervolver = false;
                        Console.WriteLine(" Escriba la columna de la matriz que busca");
                        string numerosho = Console.ReadLine();

                        int cantidad = numerosho.Length;
                        if (VC.Contador(cantidad, numerosho) == 0)
                        {
                            volvervolver = false;
                            icolumnaAAB = Convert.ToInt32(numerosho); // convierte a int
                        }
                        else
                        {
                            volvervolver = true;
                        }
                    } while (volvervolver != false);


                    auxAB = inicioAB;
                    while (auxAB != null)
                    {
                        if (auxAB.CodigoAB == numerocodigoso)
                        {
                            if (ifilaAAB < auxAB.ifilaAB && icolumnaAAB < auxAB.icolumnaAB)
                            {
                                validacionbusqueda = true;
                                for (int i = 0; i < auxAB.ifilaAB; i++)
                                {
                                    for (int j = 0; j < auxAB.icolumnaAB; j++)
                                    {

                                        if (ifilaAAB == i && icolumnaAAB == j)
                                        {
                                            do
                                            {
                                                volver = false;
                                                Console.WriteLine(" Escribe el numero que ira en la matriz posicion:" + "[" + i + " , " + j + "]");
                                                string numeromatriz = Console.ReadLine();
                                                int cantidad = numeromatriz.Length;
                                                if (VC.Contador(cantidad, numeromatriz) == 0)
                                                {
                                                    volver = false;
                                                    ///float inumeromatriz = Convert.ToInt32(numeromatriz); // convierte a int
                                                    float inumeromatriz = (float)Convert.ToDouble(numeromatriz);
                                                    inumeromatriz = (float)Math.Round(inumeromatriz, 2);
                                                    auxAB.MatrizAB[i, j] = inumeromatriz;


                                                    Console.WriteLine(" El numero que ira en la matriz posicion:" + "[" + i + " , " + j + "]" + " ahora sera: " + auxAB.MatrizAB[i, j] + "   ");
                                                    ImprimirAlgoritmoBresenhamEspecifica(auxAB.CodigoAB);
                                                    break;

                                                }
                                                else
                                                {
                                                    volver = true;
                                                }
                                            } while (volver != false);


                                        }


                                    }

                                }

                            }
                            else
                            {
                                validacionbusqueda = false;
                                break;
                            }


                            break;
                        }
                        else
                        {
                            if (auxAB.sigAB == null)
                            {
                                validacionbusqueda = false;
                                Console.ReadLine();
                            }
                        }

                        auxAB = auxAB.sigAB;
                    }

                    if (validacionbusqueda == true)
                    {
                        return 0;
                    }
                    else
                    {
                        Console.WriteLine("Warning: No se encontro informacion disponible para la operacion");
                        return 1;
                    }



                }

                auxAB = auxAB.sigAB;

            }

            if (validacionbusqueda == true)
            {
                return 0;
            }
            else
            {
                Console.WriteLine("Warning: No se encontro informacion disponible para la operacion");
                Console.ReadLine();
                return 1;
            }
        }
        public void AgregarAlgoritmoBresenhamResultado(int ifilaaux, int icolumnaaux)
        {
            nuevoAB = new ABNodo();
            // CONTADOR
            if (inicioAB == null)
            {
                nuevoAB.CodigoAB = 1;
                numerocodigoAB = nuevoAB.CodigoAB;
            }
            else
            {
                numerocodigoAB += 1;
                nuevoAB.CodigoAB = numerocodigoAB;
            }

            numerocodigoAuxAB = numerocodigoAB;

            nuevoAB.ifilaAB = ifilaaux;
            nuevoAB.icolumnaAB = icolumnaaux;

            // LLENA LA MATRIZ DE DATOS
            nuevoAB.MatrizAB = new float[ifilaaux, icolumnaaux];
            for (int i = 0; i < ifilaaux; i++)
            {
                for (int j = 0; j < icolumnaaux; j++)
                {
                    nuevoAB.MatrizAB[i, j] = AB03[i, j];
                }
            }


            if (inicioAB == null)
            {
                inicioAB = nuevoAB;
                finAB = inicioAB;
            }
            else
            {
                finAB.sigAB = nuevoAB;
                auxAB = finAB;
                finAB = finAB.sigAB;
                finAB.antAB = auxAB;
                finAB.sigAB = null;
            }

        }





    }

}
