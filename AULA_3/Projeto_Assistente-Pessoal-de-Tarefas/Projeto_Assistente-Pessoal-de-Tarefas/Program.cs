/*
Projeto: Assistente Pessoal de Tarefas

1. Descrição: 
• Crie um assistente pessoal simples no console que permita ao usuário gerenciar tarefas diárias. 
• O programa terá um menu interativo onde o usuário pode:
    • adicionar tarefas; 
    • listar tarefas pendentes; 
    • marcar tarefas como concluídas; 
    • excluir tarefas.
• O projeto utilizará funções para organizar o código e torná-lo reutilizável.

2. Funcionalidades: 
• Adicionar uma nova tarefa
• Listar todas as tarefas pendentes
• Marcar uma tarefa como concluída
• Excluir uma tarefa da lista
• Exibir um resumo das tarefas
• Sair do programa

3. Extras
• Adicione uma funcionalidade para que o usuário possa ver quantas tarefas existem no sistema.
• Crie uma opção para listar apenas as tarefas que já foram marcadas como concluídas.
• Crie uma opção para que o usuário possa remover todas as tarefas que já foram concluídas de uma vez.
• Antes de apagar uma tarefa, o programa deve perguntar ao usuário se ele tem certeza.
• Crie uma funcionalidade para que o usuário possa modificar o nome de uma tarefa já existente.
*/



//static void add_tarefa() {

//}
//static void tarefas_pend() {

//}
//static void tarefas_concluídas() {

//}
//static void del_tarefa() {

//}



static int Menu() {
    while (true) {
        Console.Write(@"Escolha o número correspondete a sua opção:
            1. Adicionar Nova Tarefa;
            2. Listar Tarefas Pendentes;
            3. Listar Tarefas Concluídas;
            4. Excluir Tarefa;
            5. Sair do Menu.
        ");
        Console.WriteLine();

        string entrada = Console.ReadLine();

        if (!int.TryParse(entrada, out int escolha)) {
            Console.WriteLine("\nOPÇÃO INVÁLIDA!\n");
        }
        else {
            return escolha;
        }
    }
}

int menu = Menu();

while (menu != 5)
{

    switch (menu) {
        case 1:
            Console.WriteLine("\nChama função: Adicionar Nova Tarefa");
            break;
        case 2:
            Console.WriteLine("\nChama função: Listar Tarefas Pendentes");
            break;
        case 3:
            Console.WriteLine("\nChama função: Listar Tarefas Concluídas");
            break;
        case 4:
            Console.WriteLine("\nChama função: Excluir Tarefa");
            break;
        case 5:
            Console.WriteLine("\nChama função: Sair do Menu");
            break;
        default:
            Console.WriteLine("\OPÇÃO Inválida!");
            break;
    }

    Console.WriteLine();
    menu = Menu();
}

Console.WriteLine("\nVocê está saindo da sua TaskList, até breve!");




























































Console.ReadKey();