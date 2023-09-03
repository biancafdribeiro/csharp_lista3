# csharp_lista3
Lista 3 de exercícios de C# orientado à objetos (Tema: Getters e Setters). Segundo semestre do curso tecnólogo de Análise e Desenvolvimento de Sistemas.

Getters e Setters (usando Métodos)
1. Crie uma classe Produto com os atributos privados nome (string) e preco (double). Implemente
os métodos GetNome() e SetNome(string name) para acessar e modificar o nome do produto, e
os métodos GetPreco() e SetPreco(double price) para acessar e modificar o preço do produto.
2. Crie uma classe Estudante com os atributos privados nome (string), sobrenome (string) e idade
(int). Implemente os métodos GetNome() e SetNome(string nome) para acessar e modificar o
nome do estudante, os métodos GetNome()para acessar o sobrenome do estudante e os
métodos GetIdade() e SetIdade(int idade) para acessar e modificar a idade do estudante. O
sobrenome do estudante não deve poder ser atribuído fora da classe e deve ter seu valor
padrão igual a “Oliveira”.
3. Crie uma classe ContaBancaria com os atributos privados saldo (double) e numeroConta
(string). Implemente os métodos GetSaldo() e SetSaldo(double valor) para acessar e modificar o
saldo da conta.
4. Crie uma classe Carro com os atributos privados marca (string) e ano (int). Implemente os
métodos GetMarca() e SetMarca(string marca) para acessar e modificar a marca do carro, e os
métodos GetAno() e SetAno(int ano) para acessar e modificar o ano do carro.
5. Crie uma classe Empregado com os atributos privados primeiroNome (string) e ultimoNome
(string). Implemente os métodos GetNomeCompleto() e SetNomeCompleto(string
primeiroNome, string ultimoNome) para acessar e modificar o nome completo do funcionário.

Propriedades (Get e Set)
6. Crie uma classe Temperatura com um atributo privado celsius (double). Implemente uma
propriedade Celsius usando get e set para acessar e modificar a temperatura em graus Celsius.
Adicione um método ConverteParaFahrenheit() que retorna a temperatura em Fahrenheit.
7. Crie uma classe Pessoa com um atributo privado anoAniversario (int). Implemente uma
propriedade Idade usando get para calcular e retornar a idade da pessoa com base no ano de
nascimento.
8. Expanda o exemplo da classe Produto do primeiro conjunto de exercícios, mas desta vez,
implemente a propriedade Nome usando get e set para acessar e modificar o nome do
produto.
9. Crie uma classe Retangulo com atributos privados tamanho (double) e altura (double).
Implemente propriedades Tamanho e Altura usando get e set para acessar e modificar a
largura e altura do retângulo.
10. Expanda o exemplo da classe ContaBancaria do primeiro conjunto de exercícios, mas desta vez,
implemente propriedades Saldo e NumeroConta usando get e set para acessar e modificar o
saldo da conta e o número da conta.
11. Expanda o exemplo da classe ContaBancaria e implementa a propriedade SaldoPositivo usando
get e set. A propriedade SaldoPositivo só permite definir um valor se o saldo for maior ou igual
a zero. Caso contrário, ela deve exibir uma mensagem.
12. Crie uma classe SensorTemperatura que simula a leitura de temperatura. Implemente uma
propriedade Temperatura usando get e set. A propriedade Temperature deve ajustar
automaticamente a temperatura medida se estiver fora de um intervalo especificado. 
