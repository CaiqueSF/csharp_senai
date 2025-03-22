// Fundamentais =====================================================

// 1. Soma dos Elementos: Crie um programa que receba 5 números inteiros, armazene-os em um array e exiba a soma total dos elementos.
/*
int[] numeros = new int[5];

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write($"Digite o {i + 1}º número: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

Console.Write($"\nA soma dos números digitados é: {numeros.Sum()}");
*/


// 2. Maior e Menor Valor: Peça ao usuário 10 números e armazene-os em um array.
// Em seguida, exiba o maior e o menor valor inserido.
/*
float[] numeros = new float[10];

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write($"Digite o {i + 1}º número: ");
    numeros[i] = float.Parse(Console.ReadLine());
}

Console.Write($"\nMaior valor = {numeros.Max()} | Menor valor = {numeros.Min()}");
*/


// 3. Média dos Valores: Receba 6 números inteiros e armazene-os em um array. Depois, calcule e exiba a média dos valores.
/*
float[] numeros = new float[6];

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write($"Digite o {i + 1}º número: ");
    numeros[i] = float.Parse(Console.ReadLine());
}

Console.Write($"\nMédia dos valores = {numeros.Average()}");
*/


// Intermediários ===================================================

// 1. Contagem de Números Pares Peça ao usuário 10 números, armazene em um array e exiba a quantidade de números pares inseridos.
/*
int[] numeros = new int[10];
int numerosPares = 0;

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write($"Digite o {i + 1}º número inteiro: ");
    numeros[i] = int.Parse(Console.ReadLine());

    if (numeros[i] % 2 == 0)
    {
        numerosPares++;
    }
}

Console.Write($"\nQuantidade de números pares = {numerosPares}");
*/


// 2. Inversão de Elementos: Crie um programa que recebe 8 números em um array e exibe os valores na ordem inversa à que foram inseridos.
/*
int[] numeros = new int[8];

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write($"Digite o {i + 1}º número inteiro: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

Array.Reverse(numeros);
Console.WriteLine("");

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write(numeros[i] + " ");
}
*/


// 3. Frequência de um Número: Peça ao usuário 10 números e um número adicional. O programa deve contar e exibir quantas vezes esse número aparece no array.
/*
List<int> numeros = new List<int> {};

for (int i = 0; i < 10; i++) {
    Console.Write($"Digite o {i + 1}º número inteiro: ");
    int n = int.Parse(Console.ReadLine());
    numeros.Add(n);
}

Console.Write($"\nEscolha um número aleatório: ");
int escolha = int.Parse(Console.ReadLine());

if (numeros.Contains(escolha)) {
    Console.Write($"\nO número {escolha} existe na lista!");
}
else {
    Console.Write($"\nO número {escolha} NÃO existe na lista!");
}
*/

// Avançados ========================================================

// 1. Remover Duplicatas: Receba 10 números em um array e exiba-os sem valores duplicados.
/*
List<float> numeros = new List<float> {};

for (int i = 0; i < 10; i++) {
    Console.Write($"Digite o {i + 1}º número inteiro: ");
    float n = float.Parse(Console.ReadLine());
    numeros.Add(n);
}

// Removendo duplicatas
List<float> numerosUnicos = numeros.Distinct().ToList();

Console.WriteLine($"\n> > > > > NÚMEROS ÚNICOS < < < < <");
for (int i = 0; i < numerosUnicos.Count; i++) {
    Console.Write($"{numerosUnicos[i]} ");
}
*/


// 2. Ordenação Crescente: Peça 10 números ao usuário e exiba-os em ordem crescente.
/*
float[] numeros = new float[10];

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write($"Digite o {i + 1}º número: ");
    numeros[i] = float.Parse(Console.ReadLine());
}

Array.Sort(numeros);
Console.WriteLine("");

Console.WriteLine($"\n> > > > > ORDEM CRESCENTE < < < < <");
for (int i = 0; i < numeros.Length; i++)
{
    Console.Write(numeros[i] + ", ");
}
*/


// 3. Intersecção de Arrays: O usuário insere dois arrays de 5 elementos. O programa exibe quais números aparecem em ambos.

float[] array1 = new float[5];
for (int i = 0; i < array1.Length; i++) {
    Console.Write($"Digite o {i + 1}º número do 'array 1': ");
    array1[i] = float.Parse(Console.ReadLine());
}

Console.WriteLine("");

float[] array2 = new float[5];
for (int j = 0; j < array2.Length; j++) {
    Console.Write($"Digite o {j + 1}º número do 'array 2': ");
    array2[j] = float.Parse(Console.ReadLine());
}

float[] comuns = array1.Intersect(array2).ToArray();

Console.WriteLine($"\n> > > > > Os números abaixo aparecem nos dois Arrays < < < < <");
if (comuns.Length == 0) {
    Console.WriteLine("Nenhum número em comum nos Arrays!");
}
else {
    for (int i = 0; i < comuns.Length; i++) {
        Console.Write($"{comuns[i]}, ");
    }
}

Console.ReadKey();