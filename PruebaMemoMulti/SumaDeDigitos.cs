using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaMemoMulti
{
    /*
     2.2.  Suma  de dígitos
Encuentra  la  suma  de  los  dígitos  de  todos  los  números  de  1  a  N  (Ambos  incluidos)
Ejemplos:
# N = 4
1 + 2 + 3 + 4 = 10
# N = 10
1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + (1 + 0) = 46
# N = 12
1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + (1 + 0) + (1 + 1) + (1 + 2) = 51
     */
    public class SumaDeDigitos
    {
        public int sumarDigitos(int N)
        {
            int sumarDigitos = 0;

            if (N < 10)
            {
                sumarDigitos = (N * (N + 1)) / 2;
                return sumarDigitos;
            }
            int NA = 9;
            sumarDigitos = (NA * (NA + 1)) / 2;
            N = N - NA;
            for (int i = 0; i < N; i++)
            {
                sumarDigitos += (i + 1);
            }
            
            return sumarDigitos;
        }
    }
}
