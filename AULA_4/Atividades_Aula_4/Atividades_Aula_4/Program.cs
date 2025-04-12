using System;

/* 
Fundamentais = = = = = = = = = = = = = = = = = = = = = = = = = = = 

1.Criando uma Classe
Crie uma classe Pessoa com os atributos Nome e Idade. 
Instancie um objeto, atribua valores e exiba no console.

2. Métodos Simples
Adicione à classe Pessoa um método ExibirDados() 
que imprime o nome e a idade no console.

3. Encapsulamento - Propriedades
Modifique a classe Pessoa para que Idade só possa ser alterada 
se o valor for maior que zero.


Intermediários = = = = = = = = = = = = = = = = = = = = = = = = = = =

1.Construtores
Adicione um construtor à classe `Pessoa` que recebe `Nome` e `Idade`
como parâmetros ao instanciar um objeto.

2. Herança
Crie uma classe `Funcionario` que herda de `Pessoa` e adicione o atributo `Salario`.
Instancie um objeto e exiba seus dados.

3. Polimorfismo - Sobrecarga
Adicione um método `Apresentar()` na classe `Pessoa`, que pode ser chamado 
sem parâmetros ou recebendo um `string sobrenome` para exibir um nome completo.
*/

class Pessoa {
    public string nome;
    private int idade;

    // Método Construtor
    public Pessoa(string nome, int idade) {
        this.nome = nome;
        cadastraIdade(idade);
    }

    public void cadastraIdade(int idade)  {
        if (idade > 0) {
            this.idade = idade;
        }
        else {
            Console.WriteLine("ERRO: a idade deve ser maior que zero.");
        }
    }

    public void Apresentar() {
        Console.WriteLine($"\nOlá, meu nome é {nome}");
    }

    public void Apresentar(string sobrenome) {
        Console.WriteLine($"\nOlá, meu nome é {nome} {sobrenome}");
    }

    public virtual void exibirDados() {
        Console.WriteLine($"\nNome: {this.nome} | Idade: {this.idade}");
    }
}


class Funcionario : Pessoa {

    public decimal salario;

    public Funcionario(string nome, int idade, decimal salario) : base (nome, idade) {
        this.salario = salario;
    }

    public override void exibirDados() {
        base.exibirDados();
        Console.WriteLine($"\nSalário: {salario:F2}");
    }
}


class Program {
    static void Main() {
        Pessoa novoFuncionario = new Funcionario("Caíque", 32, 6000m); // Instanciando o objeto
        novoFuncionario.exibirDados();
        novoFuncionario.Apresentar();
        novoFuncionario.Apresentar("Ferreira");

        Console.ReadLine(); // Aguarda o usuário pressionar Enter
    }
}


/* Avançados = = = = = = = = = = = = = = = = = = = = = = = = = = =

1.Polimorfismo - Sobrescrita
 Crie uma classe `Veiculo` com um método `Mover()`.
 Depois, crie as classes `Carro` e `Bicicleta`, sobrescrevendo `Mover()`
 para representar seus meios de locomoção.


 2. Interfaces
 Crie uma interface `IAutenticavel` com um método `Autenticar(string senha)`.
 Depois, implemente essa interface nas classes `Usuario` e `Administrador`.

 3. Classes e Métodos Estáticos
 Crie uma classe `Calculadora` com métodos estáticos `Somar()` e `Multiplicar()`,
 permitindo chamadas sem instanciar objetos.
*/