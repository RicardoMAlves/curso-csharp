namespace PrimeiroProjeto {

    public static class ConversorDeMoeda {

        public static double Iof = 0.06;

        public static double CalcularValorEmReais(double cotacao, double dolares) {
            return (cotacao * dolares * Iof) + (cotacao * dolares);
        }

    }
}
