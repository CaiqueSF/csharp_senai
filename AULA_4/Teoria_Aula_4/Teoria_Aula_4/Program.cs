using Teoria_Aula_4;

// class Carro = = = = = = = = = = = = = = = = = = = = = = = = 
/*
Carro celta = new Carro();

celta.carro = "Celta";
celta.marca = "Chevrolet";
celta.cor = "Preto";
celta.placa = "SCCP-1910";
celta.ano = "2025";

celta.ExibirInfos();
Console.WriteLine();
celta.DefinirDono("Caíque de Sousa Ferreira");
celta.ExibirDono();
*/

// ENCAPSULAMENTO = = = = = = = = = = = = = = = = = = = = = = = = 
/*
ContaBancaria suaConta = new ContaBancaria();

suaConta.Depositar(20);
Console.WriteLine();
suaConta.Sacar(15);
*/

// HERANÇA = = = = = = = = = = = = = = = = = = = = = = = = 
/*
Cachorro dog = new Cachorro();
dog.nome = "HUSKY";
dog.respirar();
Console.WriteLine();
dog.latir();

Console.WriteLine();

Gato cat = new Gato();
cat.nome = "PERSIAN";
cat.respirar();
Console.WriteLine();
cat.miar();
*/

// POLIMORFISMO = = = = = = = = = = = = = = = = = = = = = = = = 

Veiculo minhaMoto = new Veiculo();
minhaMoto.Mover();

Veiculo meuCarro = new Carro();
meuCarro.Mover();

Veiculo meuAviao = new Aviao();
meuAviao.Mover();


// ABSTRAÇÃO = = = = = = = = = = = = = = = = = = = = = = = = 
































Console.ReadKey();