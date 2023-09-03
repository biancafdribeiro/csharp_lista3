using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    /*Crie uma classe Estudante com os atributos privados nome (string), sobrenome (string) e idade
    (int). Implemente os métodos GetNome() e SetNome(string nome) para acessar e modificar o
    nome do estudante, os métodos GetNome()para acessar o sobrenome do estudante e os
    métodos GetIdade() e SetIdade(int idade) para acessar e modificar a idade do estudante. O
    sobrenome do estudante não deve poder ser atribuído fora da classe e deve ter seu valor
    padrão igual a “Oliveira”.*/

namespace Lista3_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudante estudante = new Estudante(); // objeto

            estudante.SetNome("Bianca"); //método coloco direto 
            string NovoNome = estudante.GetNome();
            Console.WriteLine("O nome do estudante é: " + NovoNome);

            string NovoSobrenome = estudante.GetSobrenome();
            Console.WriteLine("O sobrenome do estudante é: " + NovoSobrenome);

            estudante.SetIdade(20);
            int NovaIdade = estudante.GetIdade();
            Console.WriteLine("A idade do estudante é: " + NovaIdade);

            Console.ReadKey();
        }
    }
}
