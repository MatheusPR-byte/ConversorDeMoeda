using System;
using System.Globalization;

namespace ConversorDeMoeda {
    class Program {
        static void Main(string[] args) {

            Console.Write("Qual é a cotação de dólar? ");
            Calculadora.CotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            Calculadora.DolaresComprar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double TotalReaisTaxaSeis = Calculadora.ConversorDeMoeda(Calculadora.CotacaoDolar, Calculadora.DolaresComprar);

            Console.WriteLine("Valor a ser pago em reais = " + TotalReaisTaxaSeis.ToString("F2", CultureInfo.InvariantCulture));

        }      
    }
}
