using System;
using System.Collections.Generic;
using System.Linq;
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

    internal class Produto
    {
        private string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                Nome = value;
            }
        }

        public string nome;
        private double preco { get; set; }
        private string NomeProduto { get; set; }
        private double PrecoProduto { get; set; }

        /*public string GetNome()
        {
            return nome;
        }

        public void SetNome(string NovoNome) //precisa ser void porque não vai retornar nada
        {
            nome = NovoNome; 
        }*/

        public double GetPreco()
        {
            return preco;
        }

        public void SetPreco(double NovoPreco)
        {
            preco = NovoPreco;
        }
    }
}
