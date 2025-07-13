// See https://aka.ms/new-console-template for more information

Console.WriteLine("Praticando a estrutura de dados do tipo dicionário com Dictionary");

Dictionary<string, string> contatos = new Dictionary<string, string>();

while (true)
{
    Console.WriteLine("\nAgenda de Contatos");
    Console.WriteLine("1. Adicionar contato");
    Console.WriteLine("2. Buscar contato");
    Console.WriteLine("3. Listar todos");
    Console.WriteLine("4. Remover contato");
    Console.WriteLine("5. Sair");
    Console.Write("Escolha uma opção: ");

    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.Write("Digite o nome do contato: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o telefone do contato: ");
            string telefone = Console.ReadLine();
            contatos[nome] = telefone;
            Console.WriteLine("Contato adicionado com sucesso!");
            break;

        case "2":
            Console.Write("Digite o nome do contato a buscar: ");
            string buscarPorNome = Console.ReadLine();
            if (contatos.TryGetValue(buscarPorNome, out string resultado))
            {
                Console.WriteLine($"Contato encontrado: {buscarPorNome} - {contatos[resultado]}");
            }
            else
            {
                Console.WriteLine("Contato não encontrado.");
            }

            break;

        case "3":
            Console.WriteLine("\nLista de Contatos: ");
            foreach (var contato in contatos)
                Console.WriteLine($"{contato.Key}: {contato.Value}");
            break;

        case "4":
            Console.Write("Digite o nome do contato a remover: ");
            string removerPorNome = Console.ReadLine();
            if (contatos.ContainsKey(removerPorNome))
            {
                contatos.Remove(removerPorNome);
                Console.WriteLine("Contato removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Contato não encontrado.");
            }

            break;

        case "5":
            Console.WriteLine("Saindo...");
            return;

        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
}