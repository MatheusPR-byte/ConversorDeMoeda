using System;

namespace ConversorDeMoeda {
    class Calculadora {

        public static double CotacaoDolar;
        public static double DolaresComprar;

        public static double ConversorDeMoeda(double cotacao, double dolarescomprar) {
            double porcento = 0.06 * CotacaoDolar * DolaresComprar;
            return porcento += CotacaoDolar * DolaresComprar;

        }

    }
}
