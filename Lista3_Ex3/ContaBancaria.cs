using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    /*Crie uma classe ContaBancaria com os atributos privados saldo (double) e numeroConta
    (string). Implemente os métodos GetSaldo() e SetSaldo(double valor) para acessar e modificar o
    saldo da conta.*/

namespace Lista3_Ex3
{
    internal class ContaBancaria
    {
        private double saldo { get; set; }
        private string numeroConta { get; set; }
        private double valor { get; set; }


        public double GetSaldo() { return saldo; }
        public void SetSaldo(double valor) { saldo = valor; }

    }
}
