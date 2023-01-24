using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankIO
{
    public class ContaCorrente
    {
        public int Numero { get; }
        public int Agencia { get; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; set; }

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
        }

        public void Depositar(double valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentException("Valor de deposito deve ser maior que zero.", nameof(valor));
            }

            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentException("Valor de saque deve ser maior que zero.", nameof(valor));
            }

            if (valor > Saldo)
            {
                throw new InvalidOperationException("Saldo insuficiente.");
            }

            Saldo += valor;
        }
        public override string ToString()
        {

            return $"\n === DADOS DA CONTA === \n" +
                   $"Número da Conta : {this.Numero} \n" +
                   $"Número da Agência : {this.Agencia} \n" +
                   $"Saldo da Conta: R$ {this.Saldo} \n" +
                   $"Titular da Conta: {this.Titular.Nome} \n" +
                   $"CPF do Titular  : {this.Titular.CPF} \n\n" +
                   $"==============================";

        }
    }
}
