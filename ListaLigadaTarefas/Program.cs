// See https://aka.ms/new-console-template for more information

Console.WriteLine("Praticando a estrutura de dados do tipo Linked List");

LinkedList<string> tarefas =  new LinkedList<string>();
while (true)
{
    Console.WriteLine("\nLista de Tarefas");
    Console.WriteLine("1. Adicionar tarefa");
    Console.WriteLine("2. Listar tarefas");
    Console.WriteLine("3. Remover tarefa");
    Console.WriteLine("4. Sair");
    Console.Write("Escolha uma opção: ");

    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.Write("Digite a tarefa: ");
            string tarefa = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(tarefa))
            {
                tarefas.AddLast(tarefa);
                Console.WriteLine("Tarefa adicionada com sucesso!");
            }
            break;

        case "2":
            Console.WriteLine("\nLista de Tarefas:");
            foreach (var t in tarefas)
                Console.WriteLine($"- {t}");
            break;

        case "3":
            Console.Write("Digite a tarefa a remover: ");
            string removerTarefa = Console.ReadLine();
            var node = tarefas.Find(removerTarefa);
            if (node != null)
            {
                tarefas.Remove(node);
                Console.WriteLine("Tarefa removida com sucesso!");
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada.");
            }
            break;

        case "4":
            Console.WriteLine("Encerrando...");
            return;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}

