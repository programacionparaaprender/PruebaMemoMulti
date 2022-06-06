using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaMemoMulti
{
    /*
     2.3.  Moviendo  ceros
Moviendo ceros  al final:
Escribe  un  algoritmo  que  reciba  un  array  y  mueva  todos  los  ceros  al  final,
manteniendo  el orden  del  resto  de  elementos.
Ejemplo:
moveZeros([false,1,0,1,2,0,1,3,"a"])  //  returns[false,1,1,2,1,3,"a",0,0] 
     */
    public class MoviendoCeros
    {
        public object[] MoviendoCerosAlFinal2(object[] array1)
        { 
            int contadorCeros = 0;
            int contadorArray2 = 0;
            object[] array2 = new object[array1.Length];
            string valor1 = string.Empty;
            for (int i = 0; i < array1.Length; i++)
            {
                valor1 = Convert.ToString(array1[i]);
                if (valor1 == "0")
                {
                    contadorCeros++;
                } 
            }
            for (int i = 0; i < array1.Length; i++)
            {
                valor1 = Convert.ToString(array1[i]);
                if (valor1 != "0")
                {
                    array2[contadorArray2++] = array1[i];
                }
            }
            if(contadorCeros == 0)
            {
                return array2;
            }
            for (; contadorArray2 < array2.Length ; contadorArray2++)
            {
                array2[contadorArray2] = 0;
            }
            return array2;
        }

        public string MoviendoCerosAlFinal(object[] array1)
        {
            object[] resultado1 = MoviendoCerosAlFinal2(array1);
            string resultado2 = string.Empty;
            string alfabeto = string.Empty;
            alfabeto = Convert.ToString(AlfabetoEspañol.abcdefghijkmnlñopqrstxyz);
            foreach (object resultadoTemporal in resultado1)
            {
                string cadena = Convert.ToString(resultadoTemporal);
                if (alfabeto.IndexOf(cadena) >= 0)
                {
                    resultado2 += "\"" + resultadoTemporal.ToString() + "\"" + ",";
                }
                else
                {
                    resultado2 += resultadoTemporal.ToString() + ",";
                }

            }
            resultado2 = resultado2.Substring(0, resultado2.Length - 1);
            return resultado2;
        }
    }
}
