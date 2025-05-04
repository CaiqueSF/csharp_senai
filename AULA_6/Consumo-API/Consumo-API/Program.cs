using MenuClass;
using ApiServiceClass;
using DeserializerClass;


public class Program {
    public static async Task Main(string[] args) {

        var menu = new Menu();
        var cnpj = menu.mostrar_menu();

        var apiService = new ApiService();
        CnpjInfo result = await apiService.BuscarCnpjAsync(cnpj);

        Console.WriteLine("\n------ Dados Cadastrais ------");
        Console.WriteLine($"Razão Social: {result.razao_social}");
        Console.WriteLine($"CNPJ Raiz: {result.cnpj_raiz}");
        Console.WriteLine($"Capital Social: {result.capital_social}");
        Console.WriteLine($"Porte: {result.porte?.descricao}");
        Console.WriteLine($"Natureza Jurídica: {result.natureza_juridica?.descricao}");
        Console.WriteLine($"Data Atualização: {result.atualizado_em.ToShortDateString()}");

        Console.WriteLine("\n------ Endereço ------");
        Console.WriteLine($"Logradouro: {result.estabelecimento?.logradouro}, {result.estabelecimento?.numero}");
        Console.WriteLine($"Bairro: {result.estabelecimento?.bairro}");
        Console.WriteLine($"Cidade: {result.estabelecimento?.cidade?.nome} - {result.estabelecimento?.estado?.sigla}");
        Console.WriteLine($"CEP: {result.estabelecimento?.cep}");
    }
}