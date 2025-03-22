// Caracteres especiais: / | \ •
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;


// ATIVIDADES 1 =========================================================================

// Escreva um programa que recebe dois números e imprime a soma deles.
/*
int num1, num2;
Console.WriteLine("+ + + + + SOMA + + + + +");

Console.Write("Entre com o Primeiro Número Inteiro: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Entre com o Segundo Número Inteiro: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{num1} + {num2} = {num1+num2}");
Console.WriteLine("");
*/


// Escreva um programa que recebe dois números e imprime o produto deles.
/*​​​
int num3, num4;
Console.WriteLine("* * * * * PRODUTO * * * * *");

Console.Write("Entre com o Primeiro Número Inteiro: ");
num3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Entre com o Segundo Número Inteiro: ");
num4 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{num3} x {num4} = {num3 * num4}");
Console.WriteLine("");
*/


// Diferença
/*​​​
//Escreva um programa que recebe dois números e imprime a diferença entre eles.
int num5, num6;

Console.WriteLine("- - - - - DIFERENÇA - - - - -");

Console.Write("Entre com o Primeiro Número Inteiro: ");
num5 = Convert.ToInt32(Console.ReadLine());

Console.Write("Entre com o Segundo Número Inteiro: ");
num6 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{num5} - {num6} = {num5 * num6}");
Console.WriteLine("");
*/

// Escreva um programa que recebe três números e imprime a média aritmética deles.
/*
using System.Linq;

int num7, num8, num9;

Console.WriteLine("= = = = = MÉDIA = = = = =");

Console.Write("Entre com o Primeiro Número Inteiro: ");
num7 = Convert.ToInt32(Console.ReadLine());

Console.Write("Entre com o Segundo Número Inteiro: ");
num8 = Convert.ToInt32(Console.ReadLine());

Console.Write("Entre com o Terceiro Número Inteiro: ");
num9 = Convert.ToInt32(Console.ReadLine());

List<int> lista = new() {num7, num8, num9};
double media = lista.Average();

Console.WriteLine($"Média dos números = {lista}");
Console.WriteLine("");
*/

// Escreva um programa que recebe dois números e imprime o resto da divisão do primeiro pelo segundo.

// Escreva um programa que troca os valores de duas variáveis sem usar variável auxiliar.

// Escreva um programa que recebe um número e imprime `1` se for par e `0` se for ímpar.

// Escreva um programa que recebe três números e imprime o maior deles sem utilizar if/else ou laços de repetição.


// ATIVIDADES 2 =========================================================================

// 1. Peça dois números inteiros ao usuário e exiba o maior entre eles.
/*​​​
int num1, num2;

Console.Write("Insira o PRIMEIRO número inteiro: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Insira o SEGUNDO número inteiro: ");
num2 = Convert.ToInt32(Console.ReadLine());

string maiorNumero = (num1 > num2 ? $"O maior número é {num1}" : $"O maior número é {num2}");
Console.WriteLine(maiorNumero);
*/


// 2. Peça a idade do usuário e classifique-o como:
// • "Criança"(0 a 12 anos)
// • "Adolescente"(13 a 17 anos)
// • "Adulto"(18 anos ou mais)
/*​​​
int idade;

Console.Write("Entre com a sua idade: ");
idade = Convert.ToInt32(Console.ReadLine());

string faixaEtaria = (idade <= 12 ? "Criança" : (idade >= 18 ? "Adulto" : "Adolescente"));
Console.WriteLine(faixaEtaria);
*/


// 3. Crie um programa que receba um número inteiro do usuário e exiba se ele é par ou ímpar.
/*​​​
int numero;

Console.Write("Entre com um número INTEIRO: ");
numero = Convert.ToInt32(Console.ReadLine());

string par_impar = (numero % 2 == 0 ? $"o número '{numero}' é PAR" : $"o número '{numero}' é ÍMPAR");
Console.WriteLine(par_impar);
*/


// 4. Receba três números e determine o maior entre eles.
/*​​​
float num1, num2, num3;

Console.Write("Entre com o Primeiro número: ");
num1 = float.Parse(Console.ReadLine());

Console.Write("Entre com o Segundo número: ");
num2 = float.Parse(Console.ReadLine());

Console.Write("Entre com o Terceiro número: ");
num3 = float.Parse(Console.ReadLine());

string maiorNumero = (
        num1 > num2 && num1 > num3 ? $"O número {num1} é o maior" : 
        num2 > num1 && num2 > num3 ? $"O número {num2} é o maior" :
        $"O número {num3} é o maior"
    );

Console.WriteLine(maiorNumero);
*/


// 5. Receba os coeficientes de uma equação quadrática (ax² + bx + c = 0) e calcule o delta.
// • Delta: b² - 4 * a * c
// • EXTRA: Finalize toda a fórmula de Bhaskara, descobrindo x¹ e x² 
/*​​​
double a, b, c, delta, x1, x2;

Console.WriteLine("Calculando Equação Quadrática (ax² + bx + c = 0) usando Fórmula de Bhaskara:");

Console.Write("Entre com valor de 'a': ");
a = Convert.ToDouble(Console.ReadLine());

Console.Write("Entre com valor de 'b': ");
b = Convert.ToDouble(Console.ReadLine());

Console.Write("Entre com valor de 'c': ");
c = Convert.ToDouble(Console.ReadLine());

delta = Math.Pow(b, 2) - 4 * a * c;
x1 = (-b + Math.Sqrt(delta)) / (2 * a);
x2 = (-b - Math.Sqrt(delta)) / (2 * a);

Console.WriteLine(
    $"Delta = {delta:F3} | ".Replace(',', '.') +
    $"x¹ = {x1:F3} | ".Replace(',', '.') +
    $"x² = {x2:F3}".Replace(',', '.')
);
*/


// 6. Crie um programa que recebe dois números e uma operação (+, -, *, /) e realiza o cálculo correspondente.
/*​​​
float num1, num2;
char operacao;

Console.Write("Entre com o primeiro número: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Entre com o segundo número: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Qual operação deseja executar? (soma: + | Subtração: - | Multiplicação: * | Divisão: /): ");
operacao = Convert.ToChar(Console.ReadLine());

switch (operacao) {
    case '+':
        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        break;
    case '-':
        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        break;
    case '*':
        Console.WriteLine($"{num1} x {num2} = {num1 * num2}");
        break;
    case '/':
        Console.WriteLine($"{num1} ÷ {num2} = {num1 / num2}");
        break;
    default:
        Console.WriteLine("Operação Inválida, escolha entre '+ - * /'");
        break;
}
*/


// 7. Crie um programa que recebe um ano e verifica se ele é bissexto.
// • Se o ano não termina em 00, ele é bissexto se for divisível por 4. 
// • Todos os anos múltiplos de 400 são bissextos, exceto se forem múltiplos de 100, mas não de 400. 

int ano, bissexto;

Console.Write("Entre com um ano qualquer (exemplo: 2025): ");
ano = Convert.ToInt32(Console.ReadLine());

if (ano / 100 != 00 && ano % 4 == 0) {
    Console.WriteLine($"{ano} É um ano bissexto");
}
else {
    Console.WriteLine($"{ano} NÃO É um ano bissexto!");
}





//  • https://learn.microsoft.com/pt-br/office/troubleshoot/excel/determine-a-leap-year


// • Qualquer ano que seja uniformemente divisível por 4 é um ano bissexto: por exemplo, 1988, 1992 e 1996 são anos bissextos.
// • No entanto, ainda há um pequeno erro que deve ser contabilizado. Para eliminar esse erro, o calendário gregoriano estipula que um ano que é uniformemente divisível por 100 (por exemplo, 1900) é um ano bissexto apenas se também é igualmente divisível por 400.


// 8. Receba três valores numéricos e verifique se eles podem formar um triângulo. Caso possam, determine se ele é equilátero, isósceles ou escaleno.


// 9. Receba uma nota e classifique-a conforme a seguinte tabela:
// • A * *(90 - 100)
// • B * *(80 - 89)
// • C * *(70 - 79)
// • D * *(60 - 69)
// • F * *(menor que 60)