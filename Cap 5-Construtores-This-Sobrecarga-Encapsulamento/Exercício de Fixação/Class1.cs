using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercício_de_Fixação
{
    class Conta
    {
        //   Atributos Privados
        private int _numeroConta;
        private string _titular;
        private double _saldo;
        public double Taxa { get; private set; } = 5.00; //Auto Propertie

        
        //   Construtor
        public Conta(int conta, string titular, double saldo)
        {
            _numeroConta = conta;
            _titular = titular;
            _saldo = saldo;
        }

        //   Properties customizadas
        public int ContaNum 
        {
            get { return _numeroConta; }
            set
            {
                if (value > 1) _numeroConta = value;
            }
        }

        public string Titular
        {
            get { return _titular; }
            set { if (value.Length > 3) _titular = value; }
        }

        public double Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        //   MÉTODOS

        public double Deposito(double valor)
        {
            return _saldo + valor;
        }
        public double Saque(double valor)
        {
            return _saldo - (valor + Taxa);
        }

        public override string ToString()
        {
            return  "Conta " + ContaNum
                + ", Titular: " + Titular
                + ", Saldo: $ " + _saldo.ToString("F2",CultureInfo.InvariantCulture)
                ;
        }
    }
}
