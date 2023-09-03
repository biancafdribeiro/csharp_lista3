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
    internal class Temperatura
    {
        private double celsius;
        public double Celsius
        { get { return celsius; } 
          set { celsius = value;} }

        public double ConverteParaFahrenheit(double valorCelsius)
        {
            double fahrenheit = valorCelsius * 1.8 + 32.0;
            return fahrenheit;
        }
    }
}
