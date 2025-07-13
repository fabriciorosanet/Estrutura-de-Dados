// See https://aka.ms/new-console-template for more information

Console.WriteLine("Praticando a estrutura de dados do tipo Stack (Pilha)");

Stack<string> historicoDeComandos = new Stack<string>();
while (true)
{
    Console.WriteLine("\nTerminal Simulado");
    Console.WriteLine("Digite um comando ou use:");
    Console.WriteLine("• /historico → ver comandos");
    Console.WriteLine("• /desfazer  → desfazer último comando");
    Console.WriteLine("• /sair      → encerrar");
    Console.Write("Comando: ");
    string? entrada = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(entrada))
        continue;

    switch (entrada.Trim().ToLower())
    {
        case "/historico":
            Console.WriteLine("\nHistórico de Comandos:");
            if (historicoDeComandos.Count == 0)
                Console.WriteLine("Nenhum comando registrado.");
            else
                foreach (var cmd in historicoDeComandos)
                    Console.WriteLine($"{cmd}");
            break;

        case "/desfazer":
            if (historicoDeComandos.Count > 0)
            {
                string removido = historicoDeComandos.Pop();
                Console.WriteLine($"Comando desfeito: {removido}");
            }
            else
            {
                Console.WriteLine("Nenhum comando para desfazer.");
            }
            break;

        case "/sair":
            Console.WriteLine("Encerrando terminal...");
            return;

        default:
            historicoDeComandos.Push(entrada);
            Console.WriteLine($" Comando executado: {entrada}");
            break;
    }
}