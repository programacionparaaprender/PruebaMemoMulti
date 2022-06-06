using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaMemoMulti
{
    /*
     2.1.  Calculo  de IMC
Escribir  una  función  que  calcule  el  Indice  de  Masa  Corporal  (IMC  =  Peso/(Altura*Altura)
) 
Si  IMC  <=  18,5  devolver  “Infrapeso”
Si  IMC  <=  25,0  devolver  “Normal” 
Si  IMC  <=  30  devolver  “Sobrepeso” 
Si  IMC  >  30  devolver  “Obeso”
     */
    public class CalculoIMC
    {
        public double IMC(double Peso, double  Altura)
        {
            double IndiceMasaCorporal = Peso / (Altura * Altura);
            return IndiceMasaCorporal;
        }
        public string IndiceMasaCorporal(double Peso, double Altura)
        {
            string devolver = string.Empty;
            double IndiceMasaCorporal2 = IMC(Peso, Altura);
            if (IndiceMasaCorporal2 <= 18.5) { devolver = "Infrapeso"; }
            else if (IndiceMasaCorporal2 <= 25.0) { devolver = "Normal"; }
            else if (IndiceMasaCorporal2 <= 30) { devolver = "Sobrepeso"; }
            else if (IndiceMasaCorporal2 > 30) { devolver = "Obeso"; }
            return devolver;
        }
    }
}
