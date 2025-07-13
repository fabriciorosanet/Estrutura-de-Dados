# Agenda de Contatos com Estrutura de Dados: Dicionário / Hashtable

Este repositório contém dois projetos simples em .NET 8 que simulam uma **agenda de contatos**, com o objetivo de exercitar o uso da estrutura de dados **Dicionário (ou Tabela Hash)** — ideal para buscas rápidas por chave.


## Propósito

Aprender e praticar o uso de **estruturas de dados do tipo chave-valor**, que são fundamentais para organizar e acessar informações de forma eficiente.

> “Dicionários ou tabelas hash: quando você precisa encontrar algo rápido.”

## O aprendemos aqui:

- Diferença entre `Hashtable` e `Dictionary<TKey, TValue>`
- Como armazenar dados em pares chave-valor
- Como buscar, adicionar, remover e listar dados
- Pensamento lógico aplicado à estrutura de dados
- Boas práticas com coleções genéricas em C#


## Projetos

### 1. `AgendaHash` – Usando `Hashtable`

📁 Pasta: `AgendaHash`

- Utiliza `System.Collections`
- Permite adicionar, buscar, listar e remover contatos
- Ideal para entender como funcionam as tabelas hash em sua forma mais básica

### 2. `AgendaDictionary` – Usando `Dictionary<string, string>`

📁 Pasta: `AgendaDictionary`

- Utiliza `System.Collections.Generic`
- Tipagem forte, melhor desempenho e suporte a LINQ
- Representa a forma moderna e recomendada de usar chave-valor em C#


## Como executar

1. Instale o [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
2. Navegue até a pasta do projeto desejado
3. Execute:

```bash
dotnet run
