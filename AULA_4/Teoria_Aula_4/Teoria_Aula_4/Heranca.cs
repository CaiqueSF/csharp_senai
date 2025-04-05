public class Animal {

	public string nome;

	public void respirar() {
		Console.Write($"{nome} está respirando!");
	}
}

public class Cachorro : Animal {
	public void latir() {
		Console.WriteLine($"{nome} está latindo:  AUUU... AUUU...");
	}
}

public class Gato : Animal {
    public void miar() {
        Console.WriteLine($"{nome} está miando:  MIAAAAAAU...");
    }
}
