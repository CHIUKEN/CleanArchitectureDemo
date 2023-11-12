using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitectureDemo.Core.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.Data.Sqlite;

namespace CleanArchitectureDemo.Infrastructure.Data;
public class SqlConnectionFactory : ISqlConnectionFactory
{
    private readonly string _connectionString;

    public SqlConnectionFactory(string connectionString)
    {
        _connectionString = connectionString;
    }

    private IDbConnection _connection = default!;
    public IDbConnection GetOpenConnection()
    {
        _connection = new SqliteConnection(_connectionString);
        return _connection;
    }
}
