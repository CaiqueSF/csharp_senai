﻿interface IContaBancaria {
    void Depositar(decimal valor);
    bool Sacar(decimal valor);
    void MostrarSaldo();
}


class ContaBancaria : IContaBancaria {
    private decimal saldo;
    private static int proximoNumero = 1;
    public int NumeroConta;
    public string Titular;

    public ContaBancaria(string titular) {
        Titular = titular;
        NumeroConta = proximoNumero++;
        saldo = 0;
    }

    public virtual void Depositar(decimal valor) {
        saldo += valor;
        Console.WriteLine($"Depósito de R${valor:F2} realizado.\nSaldo atual: R${saldo:F2}");
    }

    public virtual bool Sacar(decimal valor) {
        if (valor > saldo) {
            Console.WriteLine("Saldo insuficiente.");
            return false;
        }
        else {
            saldo -= valor;
            Console.WriteLine($"Saque de R${valor:F2} realizado.\nSaldo atual: R${saldo:F2}");
            return true;
        }
    }

    public void MostrarSaldo() {
        Console.WriteLine($"Conta: {NumeroConta} | Titular: {Titular} | Saldo: R$ {saldo:F2}");
    }
}


class ContaPoupanca : ContaBancaria {
    public ContaPoupanca(string titular) : base(titular) { }

    public override void Depositar(decimal valor) {
        decimal bonus = valor * 0.01m;
        base.Depositar(valor + bonus);
        Console.WriteLine($"Bônus de R$ {bonus:F2} adicionado!");
    }
}


class ContaCorrente : ContaBancaria {
    public ContaCorrente(string titular) : base(titular) { }

    public override bool Sacar(decimal valor) {
        decimal taxa = 2.50m;
        if (valor + taxa > 0) {
            bool sacou = base.Sacar(valor + taxa);
            if (sacou) {
                Console.WriteLine($"Taxa de saque de R$ {taxa} aplicada");
            }
            return sacou;
        }
        return false;
    }
}


class Banco {
    private List<ContaBancaria> contas = new List<ContaBancaria>();

    private ContaBancaria BuscarConta(int numeroContaDigitado) {
        return contas.Find(conta => conta.NumeroConta == numeroContaDigitado);
    }

    public void CriarConta() {
        Console.Write("Digite o nome do titular: ");
        string titular = Console.ReadLine();

        Console.WriteLine(@$"
Escolha o tipo de conta 
1 - Corrente
2 - Poupança");
        Console.Write("> ");
        int tipo = int.Parse(Console.ReadLine());

        ContaBancaria novaConta = tipo == 1 ? new ContaCorrente(titular) : new ContaPoupanca(titular);

        contas.Add(novaConta);
        Console.WriteLine($"Conta {novaConta.NumeroConta} criada com sucesso!\n");
    }

    public void Depositar() {
        Console.WriteLine("Digite o número da Conta");
        Console.Write("> ");
        int numeroContaDigitado = int.Parse(Console.ReadLine());

        ContaBancaria contaBuscada = contas.Find(conta => conta.NumeroConta == numeroContaDigitado);

        if (contaBuscada != null) {
            Console.WriteLine("Digite o valor do depósito");
            Console.Write("> ");
            decimal valor = decimal.Parse(Console.ReadLine());
            contaBuscada.Depositar(valor);
        }
        else {
            Console.WriteLine("Conta não encontrada!");
        }
    }

    public void Sacar() {
        Console.WriteLine("Digite o número da conta");
        Console.Write("> ");
        int numeroContaDigitado = int.Parse(Console.ReadLine());

        ContaBancaria contaBuscada = BuscarConta(numeroContaDigitado);

        if (contaBuscada != null) {
            Console.WriteLine("Digite o valor do saque");
            Console.Write("> ");
            decimal valor = decimal.Parse(Console.ReadLine());
            contaBuscada.Sacar(valor);
        }
        else {
            Console.WriteLine("Conta não encontrada");
        }
    }

    public void Listar() {
        if (contas.Count > 0) {
            foreach (var conta in contas) {
                conta.MostrarSaldo();
            }
        }
        else {
            Console.WriteLine("Nenhuma conta cadastrada.");
        }
    }
}


class Program {
    static void Main() {
        Banco banco = new Banco();
        int opcao;
        do {
            Console.WriteLine($@"
====== Sistema Bancário ======
1 - Criar Conta
2 - Depositar
3 - Sacar
4 - Listar Contas
0 - Sair
==============================");
            Console.Write("> ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao) {
                case 1:
                    banco.CriarConta();
                    break;
                case 2:
                    banco.Depositar();
                    break;
                case 3:
                    banco.Sacar();
                    break;
                case 4:
                    banco.Listar();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        } while (opcao != 0);
    }
}