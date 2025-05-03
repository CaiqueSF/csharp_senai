using MenuClass;
using ApiServiceClass;
using System.Threading.Tasks;

public class Program {
    public static async Task Main(string[] args) {

        var menu = new Menu();
        var nomeClube = menu.mostrar_menu();

        var apiService = new ApiService();
        string result = await apiService.BuscarClubeAsync(nomeClube);

        Console.Write($"\nResultado da API:\n{result}");
    }
}