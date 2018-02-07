using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace excessoes_exercicio
{
    class Banco
    {
        public double saldo { get; private set; }
        public double limiteSaque { get; private set; }
        public int conta { get; private set; } 
        public string titular { get; private set; }




        public Banco(int conta, string titular, double limiteSaque)
        {
            this.saldo = 0.0;
            this.conta = conta;
            this.titular = titular;
            this.limiteSaque = limiteSaque;


        }

        public void Deposito(double deposito)
        {
            saldo = saldo + deposito;
            
        }

        public void Saque(double saque)
        {
            if (saldo < saque)
            {

                throw new OperacaoException("Não foi possível realizar o saque, saldo insuficiente.");
                //Console.WriteLine("Valor da Conta Corrente: " + b.saldo);
            }

            if (saque > limiteSaque)
            {

               throw new OperacaoException("Não foi possível realizar o saque, ultrapassa limite de saque.");
            }
            
            saldo = saldo - saque;
        }

        
        public override string ToString()
        {
            return "Conta Corrente : "
                + conta
                + ", Titular: "
                + titular
                + ", Saldo: "
                + saldo
                + ", Limite de Saque: "
                + limiteSaque.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
