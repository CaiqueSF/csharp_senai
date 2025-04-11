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

using System.ComponentModel.Design;

List<string> lista_tarefas = new List<string> {};
List<string> lista_tarefa_concluidas = new List<string> {};
List<string> deletar_tarefa = new List<string> {};


// LISTA TAREFAS = = = = = = = = = = = = = = = = = = = = = = = = = = = =
void listar_tarefas() {
    if (lista_tarefas.Count == 0) {
        Console.WriteLine($"\nSUA LISTA DE TAREFAS ESTÁ VAZIA!");
    }

    else {
        Console.WriteLine("\nLISTA DE TAREFAS ATUAL:");

        for (int i = 0; i < lista_tarefas.Count; i++) {
            Console.Write($"{i + 1}. {lista_tarefas[i]}\n");
        }
    }
}


// LISTA TAREFAS CONCLUÍDAS = = = = = = = = = = = = = = = = = = = = = = = = = = = =
void listar_tarefas_concluidas() {
    if (lista_tarefa_concluidas.Count == 0) {
        Console.WriteLine($"\nSUA LISTA DE TAREFAS CONCLUÍDAS ESTÁ VAZIA!");
    }
    else {
        Console.WriteLine("\nTAREFAS CONCLUÍDAS:");

        for (int i = 0; i < lista_tarefa_concluidas.Count; i++) {
            Console.Write($"{i + 1}. {lista_tarefa_concluidas[i]}\n");
        }
    }
}


// ADICIONA TAREFA = = = = = = = = = = = = = = = = = = = = = = = = = = = =
void add_tarefa() {
    Console.Write("\nEscreva brevemente o título da sua tarefa: ");
    lista_tarefas.Add(Console.ReadLine());

    Console.WriteLine("\nTAREFA ADICIONADA COM SUCESSO!");
    listar_tarefas();
}


// TAREFAS PENDENTES = = = = = = = = = = = = = = = = = = = = = = = = = = = =
void tarefas_pendentes() {
    List<string> list_tarefas_pendentes = lista_tarefas.Except(lista_tarefa_concluidas).ToList();

    if (list_tarefas_pendentes.Count == 0) {
        Console.WriteLine($"\nPARABÉNS, VOCÊ NÃO TEM TAREFAS PENDENTES!");
    }

    else {
        Console.WriteLine("\nTAREFAS PENDENTES:");
        for (int i = 0; i < list_tarefas_pendentes.Count; i++) {
            Console.Write($"{i + 1}. {list_tarefas_pendentes[i]}\n");
        }
    }
}


// TAREFAS CONCLUÍDAS = = = = = = = = = = = = = = = = = = = = = = = = = = = =
void tarefas_concluidas() {
    listar_tarefas_concluidas();
    Console.Write("\nDeseja concluir alguma tarefa? ('s' para sim | 'n' para não): ");
    string conclui = Console.ReadLine();

    if (conclui == "s" && lista_tarefas.Count >= 1) {
        Console.Write("\nDigite o número da tarefa que deseja concluir: ");
        string entrada = Console.ReadLine();

        if (int.TryParse(entrada, out int num_tarefa) && num_tarefa >= 1 && num_tarefa <= lista_tarefas.Count) {
            lista_tarefa_concluidas.Add(lista_tarefas[num_tarefa - 1]);
            Console.WriteLine("\nTAREFA CONCLUÍDA COM SUCESSO!");
            listar_tarefas_concluidas();
        }
        else {
            Console.WriteLine("\nOPÇÃO INVÁLIDA!");
        }
    }

    else if (conclui == "n") {
        listar_tarefas_concluidas();
    }

    else if (lista_tarefas.Count < 1) {
        listar_tarefas();
    }

    else {
        Console.WriteLine("\nOPÇÃO INVÁLIDA!");
    }
}


// RENOMEIA TAREFA = = = = = = = = = = = = = = = = = = = = = = = = = = = =
void renomear_tarefa() {
    if (lista_tarefas.Count >= 1) {
        Console.Write("\nDigite o número da tarefa que deseja renomear: ");
        string entrada = Console.ReadLine();

        if (int.TryParse(entrada, out int num_tarefa) && num_tarefa >= 1 && num_tarefa <= lista_tarefas.Count) {
            string nome_antigo = lista_tarefas[num_tarefa - 1];

            Console.Write("\nDigite o novo nome: ");
            string novo_nome = Console.ReadLine();
            lista_tarefas[num_tarefa - 1] = novo_nome;

            int nome_antigo_concluidas = lista_tarefa_concluidas.IndexOf(nome_antigo);
            if (nome_antigo_concluidas != -1) {
                lista_tarefa_concluidas[nome_antigo_concluidas] = novo_nome;
            }
            Console.WriteLine("\nTAREFA RENOMEADA COM SUCESSO!");
        }

        else {
            Console.WriteLine("\nOPÇÃO INVÁLIDA!");
        }
    }
    listar_tarefas();
}


// DELETA TAREFA = = = = = = = = = = = = = = = = = = = = = = = = = = = =
void del_tarefa() {
    if (lista_tarefas.Count >= 1) {
        Console.Write("\nDigite o número da tarefa que deseja excluir: ");
        string entrada = Console.ReadLine();

        if (int.TryParse(entrada, out int num_tarefa) && num_tarefa >= 1 && num_tarefa <= lista_tarefas.Count) {
            Console.Write("\nVocê tem certeza que deseja excluir a tarefa? ('s' para sim | 'n' para não): ");
            string confirma_exclusao = Console.ReadLine();

            if (confirma_exclusao == "s") {
                string del_tarefa = lista_tarefas[num_tarefa - 1];

                lista_tarefas.Remove(del_tarefa);
                lista_tarefa_concluidas.Remove(del_tarefa);

                Console.WriteLine("\nTAREFA EXCLUÍDA COM SUCESSO!");
            }
        }

        else {
            Console.WriteLine("\nOPÇÃO INVÁLIDA!");
        }
    }
    listar_tarefas();
}


// MENU DE TAREFAS = = = = = = = = = = = = = = = = = = = = = = = = = = = =
static int menu() {
    while (true) {
        Console.Write(@"Escolha o número correspondete a sua opção:
            1. Listar todas as tarefas;
            2. Adicionar Nova Tarefa;
            3. Listar Tarefas Pendentes;
            4. Adicionar/Listar Tarefas Concluídas;
            5. Renomear Tarefa;
            6. Excluir Tarefa;
            7. Sair do Menu.
        ");
        Console.WriteLine();

        string entrada = Console.ReadLine();

        if (int.TryParse(entrada, out int escolha)) {
            return escolha;
        }
        else {
            Console.WriteLine("\nOPÇÃO INVÁLIDA!\n");
        }
    }
}


int tarefa_menu = menu(); // Instanciando a função "menu"


// LÓGICA PRINCIPAL = = = = = = = = = = = = = = = = = = = = = = = = = = = =
while (tarefa_menu != 7) {

    switch (tarefa_menu) {
        case 1:
            listar_tarefas();
            break;
        case 2:
            add_tarefa();
            break;
        case 3:
            tarefas_pendentes();
            break;
        case 4:
            tarefas_concluidas();
            break;
        case 5:
            renomear_tarefa();
            break;
        case 6:
            del_tarefa();
            break;
        default:
            Console.WriteLine("\nOPÇÃO INVÁLIDA!");
            break;
    }

    Console.WriteLine();
    tarefa_menu = menu();
}

Console.WriteLine("\nVocê está saindo da sua lista de tarefas, até breve!");
Console.ReadKey();
