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
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta = new ContaBancaria();
            conta.SetSaldo(1200.0);
            double ContaBancaria = conta.GetSaldo();
            Console.WriteLine("O saldo da conta é: " + ContaBancaria);
            Console.ReadKey();

        }
    }
}
