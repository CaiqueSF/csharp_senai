// FUNÇÕES = = = = = = = = = = = = = = = = = = = = = = = = = =
/*
static double Somar(double numero1, double numero2)
{
    return numero1 + numero2;
}

Console.WriteLine(Somar(10, -5));
Console.WriteLine(Somar(14, 21));


static void MostrarSoma()
{
    double numero1, numero2;

    Console.Write("Digite o primeiro número: ");
    numero2 = double.Parse(Console.ReadLine());

    Console.Write("Digite o segundo número: ");
    numero2 = double.Parse(Console.ReadLine());

    Console.WriteLine($"A soma dos números é: {numero1 + numero2}");
}

Console.WriteLine($"MostrarSoma: {MostrarSoma(10, -5)}");
Console.WriteLine($"MostrarSoma: {MostrarSoma(14, 21)}");


static double Media()
{
    Console.Write("Digite a primeira nota: ");
    double nota1 = double.Parse(Console.ReadLine());

    Console.Write("Digite a segunda nota: ");
    double nota2 = double.Parse(Console.ReadLine());

    Console.Write("Digite a terceira nota: ");
    double nota3 = double.Parse(Console.ReadLine());

    return $"Média Final: {(nota1 + nota2 + nota3) / 3}";
}

double media = Media();
Console.WriteLine($"Média: {media}");


static double MediaList()
{
    List<double> valores = new List<double>();

    for (int contador = 1; contador <= valores.Count(); contador++)
    {
        Console.Write($"Digite a {contador + 1}ª nota: ");
        valores.Add(double.Parse(Console.ReadLine()));
    }

    return valores.Average();
}

double media = MediaList();
Console.WriteLine($"Média: {media}");
*/

// FOREACH = = = = = = = = = = = = = = = = = = = = = = = = = =

//foreach (char letra ) {
//    Console.WriteLine(valor);
//}

Console.Write("Digite seu nome: ");
string nome1 = Console.ReadLine();

var nomeChar = nome1.ToCharArray();

for (int i = nomeChar.Length; i > 0; i--) {
    Console.Write(nomeChar[i - 1]);
}

Console.WriteLine("");

foreach (char i in nome1.Reverse()) {
    Console.WriteLine(i);
}

















Console.ReadKey();