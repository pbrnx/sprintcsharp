// Local: sprintcsharp/Services/FileService.cs
using System.Text.Json; // Namespace nativo do .NET para trabalhar com JSON
using sprintcsharp.Models;

namespace sprintcsharp.Services;

public class FileService
{
    // Define um nome padr�o para o arquivo que ser� gerado/lido
    private const string NomeArquivo = "produtos_exportados.json";

    // M�todo para salvar a lista de produtos em um arquivo JSON
    public void ExportarParaJson(List<ProdutoInvestimento> produtos)
    {
        // Configura o JSON para ser formatado (indentado), facilitando a leitura
        var options = new JsonSerializerOptions { WriteIndented = true };

        // Converte a lista de objetos para uma string no formato JSON
        string jsonString = JsonSerializer.Serialize(produtos, options);

        // Salva a string no arquivo. Se o arquivo j� existir, ele ser� sobrescrito.
        File.WriteAllText(NomeArquivo, jsonString);
    }

    // M�todo para ler um arquivo JSON e converter para uma lista de produtos
    public List<ProdutoInvestimento> ImportarDeJson()
    {
        // Verifica se o arquivo a ser importado realmente existe
        if (!File.Exists(NomeArquivo))
        {
            // Se n�o existe, retorna uma lista vazia para evitar erros
            return new List<ProdutoInvestimento>();
        }

        // L� todo o conte�do do arquivo como uma string
        string jsonString = File.ReadAllText(NomeArquivo);

        // Converte a string JSON de volta para uma lista de objetos ProdutoInvestimento
        var produtos = JsonSerializer.Deserialize<List<ProdutoInvestimento>>(jsonString);

        // Retorna a lista de produtos (ou uma lista vazia se o arquivo estiver vazio)
        return produtos ?? new List<ProdutoInvestimento>();
    }
}