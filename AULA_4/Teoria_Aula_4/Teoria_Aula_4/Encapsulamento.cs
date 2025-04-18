// Encapsulamento significa esconder os detalhes internos de um objeto e controlar o acesso a eles. 
// Usamos modificadores de acesso como private, public e protected.


public class ContaBancaria {

    private double saldo;


    public void Depositar(double valor) {
        saldo += valor;
        Console.WriteLine($"Depósito de R${valor} realizado\nSaldo Atual: R${saldo}");
    }


    public void Sacar(double saque) {
        if (saque <= saldo) {
            saldo -= saque;
            Console.WriteLine($"Saque de R${saque} realizado\nSaldo Atual: R${saldo}");
        }

        else {
            Console.WriteLine($"Saldo insuficiente: {saldo}");
        }
    }
}