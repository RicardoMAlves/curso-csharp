using System.Globalization;

namespace PrimeiroProjeto {

    public class ContaBancaria {

        public string TitularDaConta { get; set; }
        public int NumeroDaConta { get; private set; }
        public double SaldoInicial { get; private set; }

        public ContaBancaria(int numero, string titular) {
            NumeroDaConta = numero;
            TitularDaConta = titular;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular) {
            Depositar(depositoInicial);
        }

        public void Depositar(double deposito)
        {
            SaldoInicial += deposito;
        }

        public void Saque(double saque)
        {
            SaldoInicial -= (saque + 5.0);
        }

        public override string ToString() {
            return "Conta " + NumeroDaConta + ", Titular: " + TitularDaConta + ", Saldo: $ " + SaldoInicial.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
