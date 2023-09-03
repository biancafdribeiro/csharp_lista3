using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

/*Crie uma classe Produto com os atributos privados nome (string) e preco (double). Implemente
os métodos GetNome() e SetNome(string name) para acessar e modificar o nome do produto, e
os métodos GetPreco() e SetPreco(double price) para acessar e modificar o preço do produto.*/

/*Expanda o exemplo da classe Produto do primeiro conjunto de exercícios, mas desta vez,
implemente a propriedade Nome usando get e set para acessar e modificar o nome do
produto*/

namespace Lista3_Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto(); // objeto

            // nome: modifiquei para usar a propriedade Nome

            produto.nome = ("Bola");
            string nomeproduto = produto.nome;
            Console.WriteLine("Nome do Produto: " + nomeproduto);

            // produto

            produto.SetPreco(10.0); // double não precisa de aspas

            double PrecoProduto = produto.GetPreco();

            Console.WriteLine("Preço do Produto: " + PrecoProduto);

            Console.ReadKey();
        }
    }
}
