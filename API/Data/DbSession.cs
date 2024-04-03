using System;
using System.Data;
using Npgsql;

public class DbSession : IDisposable
{
    public IDbConnection Connection { get; }

    public DbSession(string connectionString)
    {
        Connection = new NpgsqlConnection(connectionString);
        Connection.Open();
    }

    public void Dispose()
    {
        Connection?.Dispose();
    }
}
