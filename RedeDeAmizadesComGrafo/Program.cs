// See https://aka.ms/new-console-template for more information

Console.WriteLine("Praticando a estrutura de dados do tipo Grafo");

Dictionary<string, List<string>> grafo = new();

while (true)
{
    Console.WriteLine("\nRede de Amizades");
    Console.WriteLine("1. Adicionar pessoa");
    Console.WriteLine("2. Conectar amizade");
    Console.WriteLine("3. Ver conexões");
    Console.WriteLine("4. Sair");
    Console.Write("Escolha uma opção: ");
    string? opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.Write("Nome da pessoa: ");
            string? nome = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(nome) && !grafo.ContainsKey(nome))
            {
                grafo[nome] = new List<string>();
                Console.WriteLine($"{nome} adicionada a rede.");
            }
            else
                Console.WriteLine("Nome inválido ou já existe.");
            break;

        case "2":
            Console.Write("Nome da primeira pessoa: ");
            string? p1 = Console.ReadLine();
            Console.Write("Nome da segunda pessoa: ");
            string? p2 = Console.ReadLine();

            if (grafo.ContainsKey(p1!) && grafo.ContainsKey(p2!))
            {
                grafo[p1!].Add(p2!);
                grafo[p2!].Add(p1!);
                Console.WriteLine($"{p1} e {p2} agora são amigas.");
            }
            else
                Console.WriteLine("Uma ou ambas as pessoas não existem.");
            break;

        case "3":
            Console.WriteLine("\nConexões na Rede:");
            foreach (var pessoa in grafo)
            {
                Console.WriteLine($"{pessoa.Key} → {string.Join(", ", pessoa.Value)}");
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
