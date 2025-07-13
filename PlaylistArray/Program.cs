// See https://aka.ms/new-console-template for more information

Console.WriteLine("Praticando a estrutura de dados do tipo Array");
string[] playlist = new string[5];
int quantidade = 0;

while (true)
{
    Console.WriteLine("\nPlaylist Simples");
    Console.WriteLine("1. Adicionar música");
    Console.WriteLine("2. Ver todas as músicas");
    Console.WriteLine("3. Reproduzir música por índice");
    Console.WriteLine("4. Sair");
    Console.Write("Escolha uma opção: ");
    string? opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            if (quantidade >= playlist.Length)
            {
                Console.WriteLine("Playlist cheia!");
                break;
            }
            Console.Write("Nome da música: ");
            string? musica = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(musica))
            {
                playlist[quantidade] = musica;
                quantidade++;
                Console.WriteLine("Música adicionada!");
            }
            break;

        case "2":
            Console.WriteLine("\nMúsicas na Playlist:");
            for (int i = 0; i < quantidade; i++)
                Console.WriteLine($"{i}: {playlist[i]}");
            break;

        case "3":
            Console.Write("Digite o índice da música: ");
            if (int.TryParse(Console.ReadLine(), out int indice) && indice >= 0 && indice < quantidade)
                Console.WriteLine($"Reproduzindo: {playlist[indice]}");
            else
                Console.WriteLine("Índice inválido.");
            break;

        case "4":
            Console.WriteLine("Encerrando...");
            return;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}
