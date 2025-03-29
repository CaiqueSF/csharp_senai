// Fundamentais = = = = = = = = = = = = = = = = = = = = = = = = = =

// 1. Função de Soma: Crie uma função que recebe dois números e retorna a soma deles.
/*
static string Soma(double numero1, double numero2) {
    Console.WriteLine("+ + + + + SOMA DE 2 NÚMEROS + + + + +");
    return $"\n{numero1} + {numero2} = {numero1 + numero2}";
}
Console.WriteLine(Soma(10, -5));
*/


// 2. Função de Média: Faça uma função que recebe um array de números e retorna a média dos valores.
/*
static string Media() {
    Console.WriteLine("+ / + / + / MÉDIA COM ARRAYS + / + / + /");
    Console.Write("Digite a quantidade de números que deseja saber a Média: ");

    int qtdNumeros;

    while (!int.TryParse(Console.ReadLine(), out qtdNumeros) || qtdNumeros < 2) {
        Console.Write("NÚMERO INVÁLIDO: entre com um número inteiro igual ou maior que 2: ");
    }

    double[] numeros = new double[qtdNumeros];
    Console.WriteLine("");

    for (int i = 0; i < numeros.Length; i++) {
        Console.Write($"Digite o {i + 1}º número: ");
        numeros[i] = double.Parse(Console.ReadLine());
    }

    return $"\nMÉDIA = {numeros.Average()}";
}
Console.WriteLine(Media());
*/


// 3. Função de Par ou Ímpar: Escreva uma função que recebe um número e retorna "Par" ou "Ímpar".
/*
static string ParImpar()
{
    Console.WriteLine("_ _ _ _ _ PAR OU ÍMPAR _ _ _ _ _");
    Console.Write("\nEntre com um número inteiro: ");
    int numero = int.Parse(Console.ReadLine());

    string result = (numero % 2 == 0 ? $"\nO número '{numero}' é PAR!" : $"\nO número '{numero}' é ÍMPAR!");

    return result;
}
Console.WriteLine(ParImpar());
*/


// Intermediários = = = = = = = = = = = = = = = = = = = = = = = = = =
// 1. Função de Fatorial: Implemente uma função que recebe um número e retorna seu fatorial.

// 2. Função para Inverter String: Faça uma função que recebe uma string e retorna a string invertida.

// 3. Função para Contar Vogais: Escreva uma função que recebe uma string e retorna a quantidade de vogais nela.



// Avançados = = = = = = = = = = = = = = = = = = = = = = = = = =
// 1. Função para Verificar Número Primo: Crie uma função que recebe um número e retorna se ele é primo ou não.

// 2. Função de Busca em Array: Faça uma função que recebe um array e um número, retornando `true` se o número estiver no array e `false` caso contrário.
    
// 3. Função Recursiva para Fibonacci: Implemente uma função recursiva que recebe um número `n` e retorna o `n`ésimo termo da sequência de Fibonacci.

Console.ReadKey();