using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto(); // objeto

            // nome

            produto.SetNome("Bola");

            string NomeProduto = produto.GetNome();

            Console.WriteLine("Nome do Produto: " +  NomeProduto);


            // produto

            produto.SetPreco(10.0); // double não precisa de aspas

            double PrecoProduto = produto.GetPreco();

            Console.WriteLine("Preço do Produto: " + PrecoProduto);

            Console.ReadKey();
        }
    }
}
