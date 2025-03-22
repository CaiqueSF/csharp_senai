// ENTRADAS E SAÍDAS =========================================
string nome = "Nome Padrão";
int idade = 32;
char genero = 'M';
float altura = 1.77f;
double pi = 3.14;
bool estudante = true;
/*
// SOLICITA NOME - - - - -
Console.Write("Entre com o seu novo nome? ");
nome = Console.ReadLine();
Console.WriteLine($"Seu novo nome é: {nome}");
Console.WriteLine("");

// SOLICITA IDADE - - - - -
Console.Write("Entre com a sua idade atual (apenas números inteiros): ");
idade = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sua idade atualizada é: {idade}");
Console.WriteLine("");

// SOLICITA GENERO - - - - -
Console.Write("Entre com o seu genero (M ou F): ");
genero = Convert.ToChar(Console.ReadLine());

if (genero == 'M'){
    Console.WriteLine($"Seu genero é Masculino");
    Console.WriteLine("");
}
else{
    Console.WriteLine($"Seu genero é Feminino");
    Console.WriteLine("");
}

// SOLICITA ALTURA - - - - -
Console.Write("Entre com a sua altura: ");
altura = float.Parse(Console.ReadLine());
string altura1 = altura.ToString().Replace(',', '.');
Console.WriteLine($"Sua altura é: {altura1}");
Console.WriteLine("");

// SOLICITA 'PI' - - - - -
Console.Write("Entre com o valor de π (pi): ");
pi = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"π = {pi}");
Console.WriteLine("");
*/

// VALIDA SE É ALUNO SENAI - - - - -
/*
Console.Write("Você é novo aluno do senai? (true or false): ");
estudante = Convert.ToBoolean(Console.ReadLine());

if (estudante){
    Console.WriteLine("");
    Console.WriteLine($"Seja bem vindo ao Senai Informática!");
}
else{
    Console.WriteLine("");
    Console.WriteLine($"Faça sua matrícula no Senai Informática!");
}
Console.WriteLine("");
*/

// OPERADORES MATEMÁTICOS =========================================
/*
Console.WriteLine(" = = = = = OPERADORES MATEMÁTICOS = = = = =");

Console.WriteLine($"5 + 5 = {5 + 5}");
Console.WriteLine($"nome = altura = {nome + " " + altura}");
Console.WriteLine($"pi - altura = {pi - altura}");
Console.WriteLine($"5 * 5 = {5 * 5}");
Console.WriteLine($"11 / 3 = {11 / 3}");
Console.WriteLine($"11 % 3 = {11 % 3}");
Console.WriteLine($"Double 11 / double 3 = {Convert.ToDouble(11) / (double)3}");
Console.WriteLine("");
*/

// OPERADORES DE COMPARAÇÃO =========================================
int entrada;
int valorPadrao = 55;
/*
Console.WriteLine(" = = = = = OPERADORES DE COMPARAÇÃO = = = = =");
Console.WriteLine("valorPadrao = 55\n");

Console.Write($"(valida se maior ou igual) Entre com um número inteiro: ");
entrada = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{valorPadrao} >= {entrada}: {valorPadrao >= entrada}");
Console.WriteLine("");

Console.Write($"(valida se menor ou igual) Entre com um número inteiro: ");
entrada = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{valorPadrao} <= {entrada}: {valorPadrao <= entrada}");
Console.WriteLine("");

Console.Write($"(valida se menor) Entre com um número inteiro: ");
entrada = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{valorPadrao} < {entrada}: {valorPadrao < entrada}");
Console.WriteLine("");

Console.Write($"(valida se maior) Entre com um número inteiro: ");
entrada = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{valorPadrao} > {entrada}: {valorPadrao > entrada}");
Console.WriteLine("");

Console.Write($"(valida se diferente) Entre com um número inteiro: ");
entrada = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{valorPadrao} != {entrada}: {valorPadrao != entrada}");
Console.WriteLine("");
*/

// VALIDA SOL ou CHUVA - - - - -
//bool estaSol = true;
//bool estaChovendo = false;
//Console.WriteLine($"estaSol ou estaChovendo: {estaSol || estaChovendo}");

// Válida USUÁRIO e SENHA - - - - -
string usuario = "admin";
string senha = "1234";
/*
Console.Write("Digite o seu usuário: ");
string usuarioInserido = Console.ReadLine();
Console.Write("Digite a sua senha: ");
string senhaInserida = Console.ReadLine();

if (usuario == usuarioInserido && senha == senhaInserida)
{
    Console.WriteLine("");
    Console.WriteLine("Login feito com SUCESSO!");
}
else if (usuario == usuarioInserido && senha != senhaInserida)
{
    Console.WriteLine("");
    Console.WriteLine($"Senha inválida para o usuário '{usuario}'");
}
else
{
    Console.WriteLine("");
    Console.WriteLine("FALHA ao efetuar o Login!");
}
*/

// VALIDA MARCHA COM SWITCH - - - - -

/*
Console.Write("Para qual marcha eu devo trocar? ");
char marcha = Convert.ToChar(Console.ReadLine());

switch (marcha) {
    case '1':
        Console.WriteLine("Primeira Marcha!");
        break;
    case '2':
        Console.WriteLine("Segunda Marcha!");
        break;
    default:
        Console.WriteLine();
        break;
}
*/

// VALIDA MARCHA COM 'IF' TERNÁRIO - - - - -

Console.Write("Para qual marcha eu devo trocar? ");
char pisca = Convert.ToChar(Console.ReadLine());

bool piscaAlerta = (pisca == '1');
string motivoPiscaAlerta = (pisca == '1' ? "Pisca alerta ligado" : "Pisca alerta desligado");
Console.WriteLine(motivoPiscaAlerta);
//Console.ReadKey();
