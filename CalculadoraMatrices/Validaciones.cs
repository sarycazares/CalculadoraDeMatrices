using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraMatrices
{
    class Validaciones
    {

        public Validaciones()
        {
 
        }


        public float Contador(float cantidad, string numeroespacio)
        {
            bool ValidacionContador = false;

            bool canConvert = float.TryParse(numeroespacio, out cantidad);
            if (canConvert == true)
            {
                ValidacionContador = false;
            }
            else
            {
                Console.WriteLine("Warning: Caracter invalido");
                ValidacionContador = true;
            }


            if (ValidacionContador == false)
            {
                return 0;
            }
            else
            {
                return 1;
            }

        }

        public int Ceros(string numerocero)
        {
            bool ValidacionCero = false;
            if (numerocero == "0")
            {
                Console.WriteLine("Warning: No se acepta el numero 0");
                ValidacionCero = true;
                return 1;
            } 
            else
            {
                ValidacionCero = false;
                return 0;
            }

            
        }

        public float Igualdad(float a, float b)
        {
            bool ValidacionIgualdad = false;
            if (a != b)
            {
                Console.WriteLine("Warning: El tamaño del valor no permite la operacion");
                ValidacionIgualdad = true;
                return 1;
            }
            else
            {
                ValidacionIgualdad = false;
                return 0;
            }

        }







    }
}
