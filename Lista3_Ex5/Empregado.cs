using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

    /* Crie uma classe Empregado com os atributos privados primeiroNome (string) e ultimoNome
    (string). Implemente os métodos GetNomeCompleto() e SetNomeCompleto(string
    primeiroNome, string ultimoNome) para acessar e modificar o nome completo do funcionário.*/

namespace Lista3_Ex5
{
    internal class Empregado
    {
        private string primeiroNome { get; set; }
        private string ultimoNome { get; set; } 
        private string nomeCompleto { get; set; }

        public string GetNomeCompleto() { return nomeCompleto; }
        public void SetNomeCompleto(string primeiroNome, string ultimoNome) { nomeCompleto = primeiroNome + ultimoNome; }
    }
}
