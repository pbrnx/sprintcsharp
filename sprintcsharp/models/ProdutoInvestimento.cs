// Local: sprintcsharp/Models/ProdutoInvestimento.cs
namespace sprintcsharp.Models; // O namespace corresponde ao local do arquivo

// Esta classe representa a tabela 'investimento_produto' do banco de dados.
public class ProdutoInvestimento
{
    // As propriedades da classe correspondem �s colunas da sua tabela.
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Tipo { get; set; }
    public string Risco { get; set; }
    public decimal Preco { get; set; }

    // Este � um m�todo auxiliar para facilitar a exibi��o do objeto no console.
    public override string ToString()
    {
        // O ':C' formata o pre�o como moeda (ex: R$ 108,50)
        return $"ID: {Id}, Nome: {Nome}, Tipo: {Tipo}, Risco: {Risco}, Pre�o: {Preco:C}";
    }
}