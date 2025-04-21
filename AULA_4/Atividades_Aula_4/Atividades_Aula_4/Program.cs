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

/*
class Pessoa {
    public string nome;
    private int idade;

    public int valida_idade {

        get { return idade; }

        set {
            if (value > 0) {
                idade = value;
            }
            else {
                Console.WriteLine("IDADE INVÁLIDA: a idade deve ser um número INTEIRO e MAIOR que ZERO");
            }
        }
    }

    // Método Construtor
    public Pessoa(string nome, int idade) {
        this.nome = nome;
        valida_idade = idade;
    }

    public void Apresentar() {
        Console.WriteLine($"\nOlá, meu nome é {nome}.");
    }

    public void Apresentar(string sobrenome) {
        Console.WriteLine($"Olá, meu nome é {nome} {sobrenome}.");
    }

    public virtual void exibirDados() {
        Console.WriteLine("\n* * * * * CLASSE PESSOA * * * * *");
        Console.WriteLine($"Nome: {this.nome} | Idade: {this.idade}");
    }
}


class Funcionario : Pessoa {

    public decimal salario;

    public Funcionario(string nome, int idade, decimal salario) : base(nome, idade) {
        this.salario = salario;
    }

    public override void exibirDados() {
        Console.WriteLine("\n* * * * * CLASSE FUNCIONÁRIO * * * * *");
        base.exibirDados();
        Console.WriteLine($"Salário: {salario:F2}");
    }
}


class Program {
    static void Main() {
        Pessoa pessoa = new Pessoa("Caíque", 32); // Instanciando objeto Pessoa
        pessoa.exibirDados();
        pessoa.Apresentar("de Sousa Ferreira");

        Console.WriteLine("");

        Funcionario funcionario = new Funcionario("Caíque", 32, 6000m); // Instanciando objeto Funcionario
        funcionario.exibirDados();        

        Console.ReadLine(); // Aguarda o usuário pressionar Enter
    }
}
*/


//Avançados = = = = = = = = = = = = = = = = = = = = = = = = = = =
/*
1.Polimorfismo - Sobrescrita
    Crie uma classe `Veiculo` com um método `Mover()`.
    Depois, crie as classes `Carro` e `Bicicleta`, sobrescrevendo `Mover()`
    para representar seus meios de locomoção.
*/

/*
class Veiculo {
    public virtual void Mover() {
        Console.WriteLine("O veículo está se movendo.");
    }
}

class Carro : Veiculo {
    public override void Mover() {
        Console.WriteLine("O carro está dirigindo.");
    }
}

class Bicicleta : Veiculo {
    public override void Mover() {
        Console.WriteLine("A bicicleta está pedalando.");
    }
}


class Program {
    static void Main() {
        Veiculo veiculo = new Veiculo();
        veiculo.Mover();

        Carro carro = new Carro();
        carro.Mover();

        Bicicleta bicicleta = new Bicicleta();
        bicicleta.Mover();

        Console.ReadLine(); // Aguarda o usuário pressionar Enter
    }
}
*/


/*
2. Interfaces
    Crie uma interface `IAutenticavel` com um método `Autenticar(string senha)`.
    Depois, implemente essa interface nas classes `Usuario` e `Administrador`.
*/

/*
interface IAutenticavel {
    bool Autenticar(string senha);
}

class Usuario : IAutenticavel {
    public bool Autenticar(string senha) {
        return senha == "senha123";
    }
}

class Adiministrador : IAutenticavel {
    public bool Autenticar(string senha) {
        return senha == "admin123";
    }
}

class Program {
    static void Main() {
        IAutenticavel user = new Usuario(); // Instanciando objeto Usuario
        bool senhaUser = user.Autenticar("senha123");

        if (senhaUser) {
            Console.WriteLine("Usuário autenticado com sucesso!");
        }
        else {
            Console.WriteLine("Falha na autenticação do usuário!");
        }

        IAutenticavel admin = new Adiministrador(); // Instanciando objeto Administrador
        bool senhaAdmin = admin.Autenticar("admin");

        if (senhaAdmin) {
            Console.WriteLine("Administrador autenticado com sucesso!");
        }
        else {
            Console.WriteLine("Falha na autenticação do administrador!");
        }

        Console.ReadLine(); // Aguarda o usuário pressionar Enter
    }    
}
*/


/*
3. Classes e Métodos Estáticos
    Crie uma classe `Calculadora` com métodos estáticos `Somar()` e `Multiplicar()`,
    permitindo chamadas sem instanciar objetos.
*/

class Calculadora {
    public static string somar(double a, double b) {
        return $"MÉTODO SOMA: {a} + {b} = {a + b}\n";
    }

    public static string multiplicar(double a, double b) {
        return $"MÉTODO MULTIPLICAÇÃO: {a} * {b} = {a * b}";
    }
}

class Program {
    static void Main() {
        Console.WriteLine(Calculadora.somar(3, 3));
        Console.WriteLine(Calculadora.multiplicar(3, 3));

        Console.ReadLine(); // Aguarda o usuário pressionar Enter
    }
}
