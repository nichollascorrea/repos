using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EXERCICIO_BANCO
{
    class BANCO
    {
        public int conta { get; private set; }
        public string titular { get; private set; }
        public double saldo { get; private set; }

        public BANCO(int conta, string titular, double saldo)
        {

            this.conta = conta;
            this.titular = titular;
            this.saldo = saldo;

        }

        public BANCO(int conta, string titular)
        {

            this.conta = conta;
            this.titular = titular;
            this.saldo = 0.0;

        }

        public double Deposito(double deposito)
        {
           // saldo += deposito;
            return saldo = saldo + deposito;
        }

        public double Saque(double saque)
        {
            return saldo = saldo - saque - 5;
        }

        public override string ToString()
        {
            return "Conta: "
                + conta
                + ", Titular:"
                + titular
                + ", Saldo: R$ "
                + saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
