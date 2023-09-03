using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Crie uma classe Pessoa com um atributo privado anoAniversario (int). Implemente uma
propriedade Idade usando get para calcular e retornar a idade da pessoa com base no ano de
nascimento*/

namespace Lista3_Ex7
{
    internal class Pessoa
    {
        private int anoAniversario;
        public int idade 
        { get { return 2023 - anoAniversario; } 
        set { anoAniversario = value; } }
    }
}
