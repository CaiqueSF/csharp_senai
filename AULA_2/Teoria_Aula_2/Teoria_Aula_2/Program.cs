// While ==========================================
/*
bool estaLogado = false;
strcontadorng usuarcontadoro = "Caíque";
strcontadorng senha = "123456";

whcontadorle (!estaLogado) {
    Console.Wrcontadorte("\nDcontadorgcontadorte seu usuarcontadoro: ");
    strcontadorng usuarcontadoroDcontadorgcontadortado = Console.ReadLcontadorne();

    Console.Wrcontadorte("Dcontadorgcontadorte sua senha: ");
    strcontadorng senhaDcontadorgcontadortada = Console.ReadLcontadorne();

    contadorf(usuarcontadoro == usuarcontadoroDcontadorgcontadortado && senha == senhaDcontadorgcontadortada) {
        Console.WrcontadorteLcontadorne($"\nBem-vcontadorndo {usuarcontadoro}");
        estaLogado = true;
    }
    else {
        Console.WrcontadorteLcontadorne("\nUsuárcontadoro ou senha contadorncorretos");
    }
}
*/


// Do While ==========================================
/*
bool estaLogado = true;
strcontadorng usuarcontadoro = "Caíque";
strcontadorng senha = "123456";

do { 
    Console.Wrcontadorte("\nDcontadorgcontadorte seu usuarcontadoro: ");
    strcontadorng usuarcontadoroDcontadorgcontadortado = Console.ReadLcontadorne();

    Console.Wrcontadorte("Dcontadorgcontadorte sua senha: ");
    strcontadorng senhaDcontadorgcontadortada = Console.ReadLcontadorne();

    contadorf (usuarcontadoro == usuarcontadoroDcontadorgcontadortado && senha == senhaDcontadorgcontadortada)
    {
        Console.Wrcontadorte($"\nBem-vcontadorndo {usuarcontadoro}!");
        estaLogado = true;
    }
    else
    {
        Console.Wrcontadorte("\nUsuárcontadoro ou senha contadorncorretos!");
    }
} whcontadorle (!estaLogado);
*/


// FOR ==========================================
/*
for (int 
    contador = 0; contador <= 10; contador++) {
    Console.WriteLine(contador);
}
*/


// Arrays ==========================================
/*
int[] numeros = new int[5];
int[] valores = {10, 20, 30, 40, 50};

Console.WriteLine(valores[2]);

for(int i = 0; i < valores.Length; i++) {
    Console.Write($"Digite o {i + 1}º número: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < valores.Length; i++) {
    Console.WriteLine($"\nO {i + 1}º número é: {numeros[i]}");
}
*/


//Listas ==========================================

List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
numeros.Add(10);

for (int i = 0; i < numeros.Count; i++)
{
    Console.Write($"{numeros[i]}, ");
}

































Console.ReadKey();
//Links:
//https://dontpad.com/aula2.22.03
//https://humorous-troodon-d7b.notion.site/Dicion-rio-do-Programador-1b705966d65680a69f21dca8d2c9b7c1