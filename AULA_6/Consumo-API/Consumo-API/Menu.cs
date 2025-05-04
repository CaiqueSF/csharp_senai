namespace MenuClass {
    public class Menu {


        public string mostrar_menu() {
            Console.WriteLine(@$"
##########################################
#              CONSULTA CNPJ             #              
##########################################
            ");
            Console.Write($"Entre com o CNPJ: ");
            string cnpj = Console.ReadLine();
            return cnpj;
        } 
    }
}