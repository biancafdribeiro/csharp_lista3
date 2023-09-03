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
    internal class Estudante
    {
        private string nome { get; set; }
        private string NovoNome { get; set; }
        public string sobrenome { get; private set; } = "Oliveira";
        public string NovoSobrenome { get; set; }
        private int idade { get; set; }
        public int NovaIdade { get; set; }


        public string GetNome() { return nome; }
        public void SetNome(string NovoNome) { nome = NovoNome; }

        public string GetSobrenome() {  return sobrenome; }
        public void SetSobrenome(string NovoSobrenome) { sobrenome = NovoSobrenome; }

        public int GetIdade() {  return idade; }
        public void SetIdade(int NovaIdade) { idade = NovaIdade; }


    }
}
