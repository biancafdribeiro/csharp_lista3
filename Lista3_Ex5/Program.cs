using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    /* Crie uma classe Empregado com os atributos privados primeiroNome (string) e ultimoNome
    (string). Implemente os métodos GetNomeCompleto() e SetNomeCompleto(string
    primeiroNome, string ultimoNome) para acessar e modificar o nome completo do funcionário.*/

namespace Lista3_Ex5
{
internal class Program
{
    static void Main(string[] args)
    {
            Empregado objetoempregado = new Empregado();
            objetoempregado.SetNomeCompleto("Bianca ", "Ribeiro");
            string nomeCompleto = objetoempregado.GetNomeCompleto();
            Console.WriteLine("O nome completo do(a) empregado(a) é: " + nomeCompleto);
            Console.ReadKey();
    }
}
}
