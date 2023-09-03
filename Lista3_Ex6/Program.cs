using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Crie uma classe Temperatura com um atributo privado celsius (double). Implemente uma
propriedade Celsius usando get e set para acessar e modificar a temperatura em graus Celsius.
Adicione um método ConverteParaFahrenheit() que retorna a temperatura em Fahrenheit.*/

namespace Lista3_Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperatura objetotemperatura = new Temperatura();
            double fahrenheit = objetotemperatura.ConverteParaFahrenheit(20.0); //lendo e atribuindo ao mesmo tempo
            Console.WriteLine("A temperatura em Fahrenheit é: " + fahrenheit);
            Console.ReadKey();
        }
    }
}
