namespace Teoria_Aula_4 {
    public class Carro {

        public string carro;
        public string marca;
        public string cor;
        public string placa;
        public string ano;
        public string dono;

        public void DefinirDono(string Dono) {
            dono = Dono;
        }

        public void ExibirDono()  {
            Console.WriteLine($"Proprietário(a) do carro: {dono}");
        }

        public void ExibirInfos() {
            Console.WriteLine($"Carro: {carro}\nMarca: {marca}\nCor: {cor}\nPlaca: {placa}\nAno: {ano}");
        }
    }
}