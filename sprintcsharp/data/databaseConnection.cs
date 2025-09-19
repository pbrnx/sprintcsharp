// Local: sprintcsharp/Data/DatabaseConnection.cs
using Oracle.ManagedDataAccess.Client;

namespace sprintcsharp.Data; // O namespace muda para corresponder ao seu nome de projeto

public class DatabaseConnection
{
    // As credenciais foram extra�das do seu arquivo .env
    private readonly string _user = "RM99781";
    private readonly string _password = "270904";
    private readonly string _connectionString;

    public DatabaseConnection()
    {
        // Monta a string de conex�o no formato que o driver .NET da Oracle espera.
        string dataSource = "oracle.fiap.com.br:1521/ORCL";
        _connectionString = $"User Id={_user};Password={_password};Data Source={dataSource};";
    }

    // M�todo para obter uma nova conex�o aberta.
    public OracleConnection GetConnection()
    {
        try
        {
            var connection = new OracleConnection(_connectionString);
            connection.Open();
            return connection;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao conectar ao Oracle: {ex.Message}");
            throw; // Lan�a a exce��o para ser tratada por quem chamou o m�todo.
        }
    }
}