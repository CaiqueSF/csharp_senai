namespace MenuClass {
    public class Menu {

        public string mostrar_menu() {
            Console.WriteLine(@$"
##################################
#        BRASILEIRÃO 2025        #              
##################################
            ");
            Console.Write($"Qual clube deseja buscar: ");
            string clube = Console.ReadLine();
            return clube;
        } 
    }
}