using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    /*4. Crie uma classe Carro com os atributos privados marca (string) e ano (int). Implemente os
    métodos GetMarca() e SetMarca(string marca) para acessar e modificar a marca do carro, e os
    métodos GetAno() e SetAno(int ano) para acessar e modificar o ano do carro.*/

namespace Lista3_Ex4
{
    internal class Carro
    {
        private string marca { get; set; }
        private int ano { get; set; }   

        public string GetMarca() { return marca; }
        public void SetMarca(string marca) { this.marca = marca; } //atribuindo o valor do parâmetro marca
                                                                   //ao campo marca da classe
        public int GetAno() { return ano; }
        public void SetAno(int ano) { this.ano = ano;}
    }
}
