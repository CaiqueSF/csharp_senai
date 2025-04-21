// A abstração foca no "o que deve ser feito" e não no "como será feito".
// Uma forma de aplicar abstração em C# é usando interfaces.


// Definição da interface (Contrato)
interface IVeiculo {
    void Mover(); // Método obrigatório
}

// Implementação do contrato na classe CarroSUV
public class CarroSUV : IVeiculo {
	public void Mover() {
        Console.WriteLine("Seu carro é SUV e está na promoção.");
    }
}

public class Bicicleta : IVeiculo {
    public void Mover() {
        Console.WriteLine("A bicicleta está pedalando na ciclovia");
    }
}