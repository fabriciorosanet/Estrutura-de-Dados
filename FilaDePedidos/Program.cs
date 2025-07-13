// See https://aka.ms/new-console-template for more information

Console.WriteLine("Praticando a estrutura de dados do tipo fila (Queue)");  

Queue<string> filaDePedidos = new Queue<string>();

while (true)
{
    Console.WriteLine("\nFila de Pedidos");
    Console.WriteLine("1. Adicionar pedido");
    Console.WriteLine("2. Processar proximo pedido");
    Console.WriteLine("3. Ver pedidos pendentes");
    Console.WriteLine("4. Sair");
    Console.Write("Escolha uma opção: ");

    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.Write("Descrição do pedido: ");
            string? pedido = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(pedido))
            {
                filaDePedidos.Enqueue(pedido);
                Console.WriteLine(" Pedido adicionado à fila.");
            }
            break;

        case "2":
            if (filaDePedidos.Count > 0)
            {
                string proximo = filaDePedidos.Dequeue();
                Console.WriteLine($"Pedido processado: {proximo}");
            }
            else
            {
                Console.WriteLine("Nenhum pedido na fila.");
            }
            break;

        case "3":
            Console.WriteLine("\nPedidos Pendentes:");
            if (filaDePedidos.Count == 0)
                Console.WriteLine("Nenhum pedido na fila.");
            else
                foreach (var p in filaDePedidos)
                    Console.WriteLine($" {p}");
            break;

        case "4":
            Console.WriteLine("Encerrando...");
            return;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}
