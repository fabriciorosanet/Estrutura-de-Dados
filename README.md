# Praticando Estrutura de Dados

Este repositório contém projetos simples em .NET 8.

### 1. `AgendaHash` – Usando `Hashtable`

📁 Pasta: `AgendaHash`

- Utiliza `System.Collections`
- Permite adicionar, buscar, listar e remover contatos
- Ideal para entender como funcionam as tabelas hash em sua forma mais básica

### 2. `AgendaDictionary` – Usando `Dictionary<string, string>`

📁 Pasta: `AgendaHashDictionary`

- Utiliza `System.Collections.Generic`
- Tipagem forte, melhor desempenho e suporte a LINQ
- Representa a forma moderna e recomendada de usar chave-valor em C#

> “Dicionários ou tabelas hash: quando você precisa encontrar algo rápido.”

### O que aprendemos com esses 2 primeiros projetos
- Aprender e praticar o uso de **estruturas de dados do tipo chave-valor**, que são fundamentais para organizar e acessar informações de forma eficiente.

### 3. FilaDePedidos com Queue<T>
📁 Pasta: `FilaDePedidos`
- Utiliza `System.Collections.Generic.Queue<T>`
- Implementa uma fila de pedidos com operações de adicionar, remover e listar pedidos
- Ideal para entender o conceito de FIFO (First In, First Out)
- Permite praticar o uso de filas em C#
- Exemplo de uso: simula um sistema de pedidos onde os pedidos são processados na ordem em que foram recebidos.

>"Filas: quando a ordem de chegada é importante."

### 4. TerminalHistorico com Stack<T>
📁 Pasta: `TerminalHistorico`
- Utiliza `System.Collections.Generic.Stack<T>`
- Implementa um histórico de comandos com operações de adicionar, desfazer e listar comandos
- Ideal para entender o conceito de LIFO (Last In, First Out)
- Permite praticar o uso de pilhas em C#
- Exemplo de uso: simula um terminal onde os últimos comandos executados podem ser desfeitos.

- >"Pilhas: quando o último a entrar é o primeiro a ser sair."
  
### 5. `PlaylistArray` – Usando `Array`
📁 Pasta: `PlaylistArray`
- Utiliza `System`
- Implementa uma playlist de músicas com operações de adicionar, remover e listar músicas
- Ideal para entender o uso básico de arrays em C#
- Permite praticar o uso de arrays para armazenar coleções de dados
- Exemplo de uso: simula uma playlist onde as músicas podem ser adicionadas, removidas e listadas.
- >"Arrays: quando você precisa de uma coleção de tamanho fixo."
  > "Arrays são úteis quando você sabe exatamente quantos elementos terá e não precisa de flexibilidade."
  > "Arrays são a base de muitas outras estruturas de dados."
  > "Arrays são rápidos para acessar, mas lentos para redimensionar."
  > "Arrays são a escolha certa quando o desempenho é crítico e o tamanho é conhecido."


## Como executar

1. Instale o [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
2. Navegue até a pasta do projeto desejado
3. Execute:

```bash
dotnet run
