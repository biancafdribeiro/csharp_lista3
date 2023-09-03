using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    /*4. Crie uma classe Carro com os atributos privados marca (string) e ano (int). Implemente os
    métodos GetMarca() e SetMarca(string marca) para acessar e modificar a marca do carro, e os
    métodos GetAno() e SetAno(int ano) para acessar e modificar o ano do carro.*/

namespace Lista3_Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro objetocarro = new Carro();

            objetocarro.SetMarca("Volkswagen");
            string marca = objetocarro.GetMarca();
            Console.WriteLine("A marca do carro é: " + marca);

            objetocarro.SetAno(2012);
            int ano = objetocarro.GetAno();
            Console.WriteLine("O ano do carro é: " + ano);

            Console.ReadKey();
        }
    }
}
