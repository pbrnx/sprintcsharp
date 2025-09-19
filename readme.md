# Gestor de Investimentos - Painel Administrativo

Este projeto consiste em uma aplica��o de console desenvolvida em C# como um painel administrativo para gerenciar os dados da plataforma "Assessor de Investimentos Virtual".

A aplica��o se conecta diretamente a um banco de dados Oracle para realizar opera��es de CRUD (Create, Read, Update, Delete) sobre as entidades do sistema, com foco inicial no gerenciamento de produtos de investimento.

## Funcionalidades

-   **CRUD de Produtos:** Gerenciamento completo do cat�logo de produtos de investimento.
    -   Listar todos os produtos.
    -   Adicionar um novo produto.
    -   Atualizar as informa��es de um produto existente.
    -   Deletar um produto.
-   **Manipula��o de Arquivos:**
    -   **Exportar:** Salva a lista completa de produtos do banco de dados em um arquivo local `produtos_exportados.json`.
    -   **Importar:** L� um arquivo `produtos_exportados.json` e insere os registros no banco de dados.

## Tecnologias Utilizadas

-   **Linguagem:** C#
-   **Framework:** .NET 8
-   **Banco de Dados:** Oracle
-   **Driver de Acesso:** `Oracle.ManagedDataAccess.Core` (via NuGet)

## Estrutura do Projeto

O c�digo foi organizado seguindo princ�pios de separa��o de responsabilidades para garantir um c�digo limpo e de f�cil manuten��o:

-   **/Data**: Cont�m as classes respons�veis pela comunica��o com o banco de dados.
    -   `DatabaseConnection.cs`: Gerencia a string de conex�o e a abertura de conex�es com o Oracle.
    -   `ProdutoInvestimentoRepository.cs`: Implementa os m�todos de CRUD para os produtos.
-   **/Models**: Cont�m as classes que representam as entidades do banco de dados.
    -   `ProdutoInvestimento.cs`: Representa a tabela `investimento_produto`.
-   **/Services**: Cont�m a l�gica para funcionalidades auxiliares.
    -   `FileService.cs`: Implementa a exporta��o e importa��o de dados para JSON.
-   `Program.cs`: Ponto de entrada da aplica��o, respons�vel pela interface do usu�rio no console.

## Pr�-requisitos

-   [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
-   Acesso ao banco de dados Oracle da Fiap.

## Como Executar

1.  **Clone o reposit�rio:**
    ```bash
    git clone [URL_DO_SEU_REPOSITORIO_AQUI]
    cd sprintcsharp
    ```

2.  **Restaure as depend�ncias:**
    O .NET far� isso automaticamente na primeira vez que voc� executar, mas se necess�rio, use o comando:
    ```bash
    dotnet restore
    ```

3.  **Execute a aplica��o:**
    ```bash
    dotnet run
    ```

    Ap�s a execu��o, um menu interativo aparecer� no console, permitindo o uso de todas as funcionalidades.