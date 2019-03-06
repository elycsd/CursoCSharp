using System.Globalization;

namespace ExercEncapsulamento {
    class ContaBancaria {
        public int Numero { get; }
        public string Titular { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular) {
            Numero = numero;
            Titular = titular;
        }
        public ContaBancaria(int numero, string titular, double depositoInicial) :this(numero, titular) {
            /*Saldo = saldo;
             Em vez de simplemente atibuir saldo à variável Saldo
             é melhor chamar o método Deposito, uma vez que na verdade se está fazendo um
             depósito inicial. Isto garante que se houver alguma mudança à regra de depósito
             ela será aplicada ao deposito inicial também.*/
            Deposito(depositoInicial);
        }
        public void Deposito(double quantia) {
            Saldo += quantia;
        }
        public void Saque(double quantia) {
            Saldo -= quantia + 5.0;
        }

        public override string ToString() {
            return "Conta: "
                + Numero.ToString()
                + ", Titular: " + Titular
                + ", Saldo: R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture)
                + ".";
        }

    }
}
