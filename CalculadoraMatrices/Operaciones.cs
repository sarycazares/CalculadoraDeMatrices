using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CalculadoraMatrices
{

    class Operaciones
    {
        private float R;
        private float I;
        private float J;
        private float K;
        private float X;
        private float Y;
        private float Z;
        private float E;

        public Operaciones()
        { 

        }

        public float i  // property
        {
            get { return I; }   // get method
            set { I = value; }  // set method
        }
        public float j  // property
        {
            get { return J; }   // get method
            set { J = value; }  // set method
        }
        public float k  // property
        {
            get { return K; }   // get method
            set { K = value; }  // set method
        }
        public float r  // property
        {
            get { return R; }   // get method
            set { R = value; }  // set method
        }
        public float x  // property
        {
            get { return X; }   // get method
            set { X = value; }  // set method
        }
        public float y  // property
        {
            get { return Y; }   // get method
            set { Y = value; }  // set method
        }
        public float z  // property
        {
            get { return Z; }   // get method
            set { Z = value; }  // set method
        }
        public float e  // property
        {
            get { return E; }   // get method
            set { E = value; }  // set method
        }

        public float Sumar (float a, float b)
        {
            float suma = a + b;
            suma = (float)Math.Round(suma, 2);
            return suma;
        }

        public float Restar(float a, float b)
        {
            float resta = a - b;
            resta = (float)Math.Round(resta, 2);
            return resta;
        }

        public float Multiplicar(float a, float b)
        {
            float multiplicacion = a * b;
            multiplicacion = (float)Math.Round(multiplicacion, 2);
            return multiplicacion;
        }

        public float Dividir(float a, float b)
        {
            float division = a / b;
            division = (float)Math.Round(division, 2);
            return division;
        }

        public void ProductoCruz(float ia , float ja , float ka , float ib, float jb, float kb)
        {

            i = (ja * kb) - (ka * jb);
            j = ((ia * kb) - (ka * ib))*-1;
            k = (ia * jb) - (ja * ib);

            i = (float)Math.Round(i, 2);
            j = (float)Math.Round(j, 2);
            k = (float)Math.Round(k, 2);


            //Console.WriteLine(OC.i + " i " + OC.j + " j " + OC.k + " k ");

        }

        public float Igual(float a, float b)
        {
            if (a == b)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public float CambioSigno(float a)
        {
            if (a == 0)
            {
                float cambiosigno = a;
                cambiosigno = (float)Math.Round(cambiosigno, 2);
                return cambiosigno;
            }            
            else
            {
                float cambiosigno = a * (-1);
                cambiosigno = (float)Math.Round(cambiosigno, 2);
                return cambiosigno;
            }


        }

        public float Potencia (float a, float p)
        {
            float potencia = (float) Math.Pow(a, p);
            potencia = (float)Math.Round(potencia, 2);
            return potencia;
        }

        public float RaizCuadrada (float a)
        {
            float raiz = (float)Math.Sqrt(a);
            raiz = (float)Math.Round(raiz, 2);
            return raiz;

        }

        public float ValorAbsoluto(float a)
        {
            float ValorAbs = (float)Math.Abs(a);
            ValorAbs = (float)Math.Round(ValorAbs, 2);
            return ValorAbs;

        }

        public void Normalizacion(float ra, float ia, float ja, float ka, float num)
        {
            num = (float)Math.Abs(num);
            r = ra / num;
            i = ia / num;
            j = ja / num;
            k = ka / num;

            r = (float)Math.Round(r, 2);
            i = (float)Math.Round(i, 2);
            j = (float)Math.Round(j, 2);
            k = (float)Math.Round(k, 2);

        }

        public void NormalizacionInverso(float ra, float ia, float ja, float ka, float num)
        {
            num = (float)Math.Abs(num);
            num = Potencia(num, 2);
            r = ra / num;
            i = ia / num;
            j = ja / num;
            k = ka / num;

            r = (float)Math.Round(r, 2);
            i = (float)Math.Round(i, 2);
            j = (float)Math.Round(j, 2);
            k = (float)Math.Round(k, 2);

        }

        public void ProductoCuaternios(float ra, float ia, float ja, float ka, float rb, float ib, float jb, float kb)
        {
            
            // prod fila/columna
            float prod00 = (ra * rb);
            float prod01 = (ra * ib);
            float prod02 = (ra * jb);
            float prod03 = (ra * kb);

            float prod10 = (ia * ib);
            float prod11 = (ia * rb);
            float prod12 = (ia * kb);
            float prod13 = (ia * jb);

            float prod20 = (ja * jb);
            float prod21 = (ja * kb);
            float prod22 = (ja * rb);
            float prod23 = (ja * ib);

            float prod30 = (ka * kb);
            float prod31 = (ka * jb);
            float prod32 = (ka * ib);
            float prod33 = (ka * rb);

            prod10 = CambioSigno(prod10);
            prod20 = CambioSigno(prod20);
            prod30 = CambioSigno(prod30);
            prod31 = CambioSigno(prod31);
            prod12 = CambioSigno(prod12);
            prod23 = CambioSigno(prod23);

            r = prod00 + prod10 + prod20 + prod30;
            i = prod01 + prod11 + prod21 + prod31;
            j = prod02 + prod12 + prod22 + prod32;
            k = prod03 + prod13 + prod23 + prod33;

            r = (float)Math.Round(r, 2);
            i = (float)Math.Round(i, 2);
            j = (float)Math.Round(j, 2);
            k = (float)Math.Round(k, 2);

        }

        public void TraslacionPunto(float Tx, float Ty, float Tz, float xa, float ya, float za)
        {
            float ea = 1;

            // Traslacion fila/columna
            float T00 = 1;
            float T01 = 0;
            float T02 = 0;
            float T03 = Tx;

            float T10 = 0;
            float T11 = 1;
            float T12 = 0;
            float T13 = Ty;

            float T20 = 0;
            float T21 = 0;
            float T22 = 1;
            float T23 = Tz;

            float T30 = 0;
            float T31 = 0;
            float T32 = 0;
            float T33 = 1;

            x = Multiplicar(T00, xa) + Multiplicar(T01, ya) + Multiplicar(T02, za) + Multiplicar(T03, ea);
            y = Multiplicar(T10, xa) + Multiplicar(T11, ya) + Multiplicar(T12, za) + Multiplicar(T13, ea);
            z = Multiplicar(T20, xa) + Multiplicar(T21, ya) + Multiplicar(T22, za) + Multiplicar(T23, ea);
            e = Multiplicar(T30, xa) + Multiplicar(T31, ya) + Multiplicar(T32, za) + Multiplicar(T33, ea);

        }

        public void EscalarPunto(float Sx, float Sy, float Sz, float xa, float ya, float za)
        {
            float ea = 1;

            // ESCALAR fila/columna
            float T00 = Sx;
            float T01 = 0;
            float T02 = 0;
            float T03 = 0;

            float T10 = 0;
            float T11 = Sy;
            float T12 = 0;
            float T13 = 0;

            float T20 = 0;
            float T21 = 0;
            float T22 = Sz;
            float T23 = 0;

            float T30 = 0;
            float T31 = 0;
            float T32 = 0;
            float T33 = 1;

            x = Multiplicar(T00, xa) + Multiplicar(T01, ya) + Multiplicar(T02, za) + Multiplicar(T03, ea);
            y = Multiplicar(T10, xa) + Multiplicar(T11, ya) + Multiplicar(T12, za) + Multiplicar(T13, ea);
            z = Multiplicar(T20, xa) + Multiplicar(T21, ya) + Multiplicar(T22, za) + Multiplicar(T23, ea);
            e = Multiplicar(T30, xa) + Multiplicar(T31, ya) + Multiplicar(T32, za) + Multiplicar(T33, ea);

        }

        public void RotacionPunto(float xyzRot, float angulo, float xa, float ya, float za)
        {
            float ea = 1;

            double anguloshoshosho = Math.PI * angulo / 180.0;
            float coscos = (float)Math.Cos(anguloshoshosho);
            coscos = (float)Math.Round(coscos, 2);
            float sensen = (float)Math.Sin(anguloshoshosho);
            sensen = (float)Math.Round(sensen, 2);

            // Rotacion fila/columna
            float T00 = 0;
            float T01 = 0;
            float T02 = 0;
            float T03 = 0;

            float T10 = 0;
            float T11 = 0;
            float T12 = 0;
            float T13 = 0;

            float T20 = 0;
            float T21 = 0;
            float T22 = 0;
            float T23 = 0;

            float T30 = 0;
            float T31 = 0;
            float T32 = 0;
            float T33 = 0;

            switch (xyzRot)
            {
                case 0:
                    {
                    // Rotacion fila/columna
                    T00 = 1;
                    T01 = 0;
                    T02 = 0;
                    T03 = 0;

                    T10 = 0;
                    T11 = coscos;
                    T12 = (float)Math.Round(sensen * (-1));
                    T13 = 0;

                    T20 = 0;
                    T21 = sensen;
                    T22 = coscos;
                    T23 = 0;

                    T30 = 0;
                    T31 = 0;
                    T32 = 0;
                    T33 = 1;

                    x = Multiplicar(T00, xa) + Multiplicar(T01, ya) + Multiplicar(T02, za) + Multiplicar(T03, ea);
                    y = Multiplicar(T10, xa) + Multiplicar(T11, ya) + Multiplicar(T12, za) + Multiplicar(T13, ea);
                    z = Multiplicar(T20, xa) + Multiplicar(T21, ya) + Multiplicar(T22, za) + Multiplicar(T23, ea);
                    e = Multiplicar(T30, xa) + Multiplicar(T31, ya) + Multiplicar(T32, za) + Multiplicar(T33, ea);
                    break;            
                    }
                case 1:
                    {
                        // Traslacion fila/columna
                    T00 = coscos;
                    T01 = 0;
                    T02 = sensen;
                    T03 = 0;

                    T10 = 0;
                    T11 = 1;
                    T12 = 0;
                    T13 = 0;

                    T20 = (float)Math.Round(sensen * (-1));
                    T21 = 0;
                    T22 = coscos;
                    T23 = 0;

                    T30 = 0;
                    T31 = 0;
                    T32 = 0;
                    T33 = 1;

                    x = Multiplicar(T00, xa) + Multiplicar(T01, ya) + Multiplicar(T02, za) + Multiplicar(T03, ea);
                    y = Multiplicar(T10, xa) + Multiplicar(T11, ya) + Multiplicar(T12, za) + Multiplicar(T13, ea);
                    z = Multiplicar(T20, xa) + Multiplicar(T21, ya) + Multiplicar(T22, za) + Multiplicar(T23, ea);
                    e = Multiplicar(T30, xa) + Multiplicar(T31, ya) + Multiplicar(T32, za) + Multiplicar(T33, ea);
                    break;            
                    }
                case 2:
                    {
                    // Traslacion fila/columna
                    T00 = coscos;
                    T01 = (float)Math.Round(sensen * (-1));
                    T02 = 0;
                    T03 = 0;

                    T10 = sensen;
                    T11 = coscos;
                    T12 = 0;
                    T13 = 0;

                    T20 = 0;
                    T21 = 0;
                    T22 = 1;
                    T23 = 0;

                    T30 = 0;
                    T31 = 0;
                    T32 = 0;
                    T33 = 1;

                    x = Multiplicar(T00, xa) + Multiplicar(T01, ya) + Multiplicar(T02, za) + Multiplicar(T03, ea);
                    y = Multiplicar(T10, xa) + Multiplicar(T11, ya) + Multiplicar(T12, za) + Multiplicar(T13, ea);
                    z = Multiplicar(T20, xa) + Multiplicar(T21, ya) + Multiplicar(T22, za) + Multiplicar(T23, ea);
                    e = Multiplicar(T30, xa) + Multiplicar(T31, ya) + Multiplicar(T32, za) + Multiplicar(T33, ea);
                    break;           
                    }
                default:
                    break;
            }

        }

        public void BresenhamLinea(float xi, float yi, float xf, float yf)
        {

            xi = (float)Math.Round(xi, 2);
            yi = (float)Math.Round(yi, 2);
            xf = (float)Math.Round(xf, 2);
            yf = (float)Math.Round(yf, 2);

            float Deltax = xf - xi;
            float Deltay = yf - yi;

            Deltax = (float)Math.Round(Deltax, 2);
            Deltay = (float)Math.Round(Deltay, 2);

            float po = (2 * Deltay) - Deltax;
            float dobleDeltay = (2 * Deltay);
            float DeltaDelta = (2 * Deltay) - (2 * Deltax);

            po = (float)Math.Round(po, 2);
            dobleDeltay = (float)Math.Round(dobleDeltay, 2);
            DeltaDelta = (float)Math.Round(DeltaDelta, 2);

            float numerosho = 0;
            float xk = xi;
            float yk = yi;
            float pk = po;

            Console.WriteLine("    k    |      pk     |        ( xk + 1 , yk + 1)");



            for (int i = 0; i < Deltax; i++)
            {
                if (pk < 0)
                {
                    xk = xk + 1;
                    Console.WriteLine(numerosho + "  |   " + pk + "   |   (" + xk + " , " + yk + ")");
                    pk = pk + dobleDeltay;
                }
                else
                {
                    xk = xk + 1;
                    yk = yk + 1;
                    Console.WriteLine(numerosho + "  |   " + pk + "   |   (" + xk + " , " + yk + ")");
                    pk = pk + DeltaDelta;
                }

                numerosho = numerosho + 1;
            }

            Console.ReadLine();



        }

        public void BresenhamCircunferencia(float origen, float radio, float entero)
        {
            origen = (float)Math.Round(origen, 2);
            radio = (float)Math.Round(radio, 2);

            float po;
            if (entero == 0)
            {
                po = 1 - radio;
            }
            else
            {
                po = (5 / 4) - radio;
            }
            float doblex = (2 * origen);
            float dobley = (2 * radio);


            po = (float)Math.Round(po, 2);
            doblex = (float)Math.Round(doblex, 2);
            dobley = (float)Math.Round(dobley, 2);


            float numerosho = -1;
            float xk = origen;
            float yk = radio;
            float doblexk = 0;
            float dobleyk = 0;
            float pk = po;
            bool cerrarciclo = false;

            Console.WriteLine("    k    |      pk     |        ( xk + 1 , yk + 1)     |      2xk + 1     |       2yk + 1");

            do
            {          

                numerosho = numerosho + 1;

                if (pk < 0)
                {

                    xk = xk + 1;
                    doblexk = xk * 2;
                    dobleyk = yk * 2;
                    Console.WriteLine(numerosho + "  |   " + pk + "   |   (" + xk + " , " + yk + ")" + "  |   " + doblexk + "  |   " + dobleyk);
                    pk = pk + doblexk + 1;
                }
                else
                {
                    xk = xk + 1;
                    yk = yk - 1;
                    doblexk = xk * 2;
                    dobleyk = yk * 2;
                    Console.WriteLine(numerosho + "  |   " + pk + "   |   (" + xk + " , " + yk + ")" + "  |   " + doblexk + "  |   " + dobleyk);
                    pk = pk + doblexk + 1 - dobleyk;
                }


                if (xk >= yk)
                {
                    cerrarciclo = false;                   

                }
                else
                {
                    cerrarciclo = true;
                }

            } while (cerrarciclo == true);

            Console.ReadLine();
        }

        public void BresenhamElipse(float rx, float ry)
        {

            rx = (float)Math.Round(rx, 2);
            ry = (float)Math.Round(ry, 2);

            float fraccion = 0.25F;
            float p01= Potencia(ry, 2) - (Potencia(rx, 2) * ry) + (fraccion * Potencia(rx, 2));

            float numerosho = 0;
            bool cerrarciclo = false;
            float xk = 0;
            float yk = ry;
            float doblexk = 0;
            float dobleyk = 0;
            float pk = p01;

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(" ");
            Console.WriteLine("  TABLA 01");
            Console.WriteLine("    k    |      pk     |        ( xk + 1 , yk + 1)     |      2xk + 1     |       2yk + 1");
            Console.ForegroundColor = ConsoleColor.White;

            do
            {
                if (pk < 0)
                {
                    
                    xk = xk + 1;
                    doblexk = (2 * Potencia((ry), 2)) * xk;
                    dobleyk = (2 * Potencia((rx), 2)) * yk;
                    Console.WriteLine(numerosho + "  |   " + pk + "   |   (" + xk + " , " + yk + ")" + "  |   " + doblexk + "  |   " + dobleyk);
                    pk = pk + ((2 * Potencia(ry, 2)) * xk) + Potencia(ry, 2);
                }
                else
                {

                    xk = xk + 1;
                    yk = yk - 1;
                    doblexk = (2 * Potencia((ry), 2)) * xk;
                    dobleyk = (2 * Potencia((rx), 2)) * yk;
                    Console.WriteLine(numerosho + "  |   " + pk + "   |   (" + xk + " , " + yk + ")" + "  |   " + doblexk + "  |   " + dobleyk);
                    pk = pk + ((2 * Potencia(ry, 2)) * xk) - ((2 * Potencia(rx, 2)) * yk) + Potencia(ry, 2);
                }

                numerosho = numerosho + 1;

                if (((2 * Potencia(ry, 2)) * xk) >= ((2 * Potencia(rx, 2)) * yk))
                {
                    cerrarciclo = false;
                }
                else
                {
                    cerrarciclo = true;
                }

            } while (cerrarciclo == true);

            numerosho = 0;
            cerrarciclo = false;
            fraccion = 0.5F;
            float x0 = xk;
            float y0 = yk;
            xk = x0;
            yk = y0;

            float po2 = Potencia(ry, 2) * Potencia((x0 + fraccion), 2) + Potencia(rx, 2) * Potencia((y0 - 1), 2) - Potencia(rx, 2) * Potencia(ry, 2);
            pk = po2;

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine(" ");
            Console.WriteLine("  TABLA 02");
            Console.WriteLine("    k    |      pk     |        ( xk + 1 , yk + 1)     |      2xk + 1     |       2yk + 1");
            Console.ForegroundColor = ConsoleColor.White;

            do
            {

                    
                if (pk > 0)
                    {
                        yk = yk - 1;
                    doblexk = (2 * Potencia((ry), 2)) * xk;
                    dobleyk = (2 * Potencia((rx), 2)) * yk;
                    Console.WriteLine(numerosho + "  |   " + pk + "   |   (" + xk + " , " + yk + ")" + "  |   " + doblexk + "  |   " + dobleyk);
                    pk = pk - ((2 * Potencia(rx,2)) * yk) + Potencia(rx, 2);
                }
                else
                    {
                        xk = xk + 1;
                        yk = yk - 1;
                    doblexk = (2 * Potencia((ry), 2)) * xk;
                    dobleyk = (2 * Potencia((rx), 2)) * yk;
                    Console.WriteLine(numerosho + "  |   " + pk + "   |   (" + xk + " , " + yk + ")" + "  |   " + doblexk + "  |   " + dobleyk);
                    pk = pk + ((2 * Potencia(ry,2)) * xk) - ((2 * Potencia(rx,2)) * yk) + Potencia(rx, 2);
                }


                numerosho = numerosho + 1;

                if ( yk <= 0)
                {
                    cerrarciclo = false;
                }
                else
                {
                    cerrarciclo = true;
                }

            } while (cerrarciclo == true);

            Console.ReadLine();

        }







    }
}
