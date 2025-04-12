//Polimorfismo permite que um mesmo método tenha diferentes comportamentos, 
//dependendo da classe que o implementa.

using System;

public class Veiculo {
	public virtual void Mover() {
        Console.WriteLine("O veículo está se movendo.");
    }
}


public class Carro : Veiculo {
    public override void Mover() {
        Console.WriteLine("O carro está andando na estrada.");
    }
}


public class Aviao : Veiculo {
    public override void Mover() {
        Console.WriteLine("O avião está voando.");
    }
}

