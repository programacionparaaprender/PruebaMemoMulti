using System;

namespace PruebaMemoMulti
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculoIMC CalculoIndiceMasaCorporal = new CalculoIMC();
            string IndiceMasaCorporal = CalculoIndiceMasaCorporal.IndiceMasaCorporal(67, 1.80);
            Console.WriteLine("Peso 67, Altura 1.80, Indice de masa corporal: " + IndiceMasaCorporal);

            SumaDeDigitos sumaDeDigitos = new SumaDeDigitos();
            double Digitos1 = sumaDeDigitos.sumarDigitos(4);
            Console.WriteLine("N = 4, resultado = " + Convert.ToString(Digitos1));

            double Digitos2 = sumaDeDigitos.sumarDigitos(10);
            Console.WriteLine("N = 10, resultado = " + Convert.ToString(Digitos2));

            double Digitos3 = sumaDeDigitos.sumarDigitos(12);
            Console.WriteLine("N = 12, resultado = " + Convert.ToString(Digitos3));

            MoviendoCeros moviendoCeros = new MoviendoCeros();
            object[] prueba1 = new object[] { false, 1, 0, 1, 2, 0, 1, 3, "a"};
            string resultado1 = string.Empty;
            resultado1 = moviendoCeros.MoviendoCerosAlFinal(prueba1);

            Console.WriteLine("Array1 = [false, 1, 0, 1, 2, 0, 1, 3, \"a\"], resultado = [ " + resultado1.ToString() + " ]");


            object[] prueba2 = new object[] { false, 1, 0, 0, 2, 0, 1, 3, "b" };
            string resultado2 = string.Empty;
            resultado2 = moviendoCeros.MoviendoCerosAlFinal(prueba2);

            Console.WriteLine("Array2 = [false, 1, 0, 0, 2, 0, 1, 3, \"b\"], resultado = [ " + resultado2.ToString() + " ]");


            Console.ReadKey();
        }
    }
}
