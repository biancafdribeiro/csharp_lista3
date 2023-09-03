using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

/* Crie uma classe Pessoa com um atributo privado anoAniversario (int). Implemente uma
propriedade Idade usando get para calcular e retornar a idade da pessoa com base no ano de
nascimento*/ 

namespace Lista3_Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.idade = (1997);
            int idadepessoa = pessoa.idade;

            Console.WriteLine("A idade da pessoa é: " + idadepessoa);
            Console.ReadKey();
        }
    }
}
