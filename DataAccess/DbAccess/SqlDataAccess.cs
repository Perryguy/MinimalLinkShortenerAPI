using System.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;
using Dapper;

namespace DataAccess.DbAccess;

public class SqlDataAccess : ISqlDataAccess
{
    private readonly IConfiguration _config;

    public SqlDataAccess(IConfiguration config)
    {
        _config = config;
    }


    /// <summary>
    /// Access database and access data
    /// </summary>
    /// <typeparam name="T">LinkModel</typeparam>
    /// <typeparam name="U">Any parameters need. Example - LinkName</typeparam>
    /// <param name="storedProcedure">The stored SQL command to execute</param>
    /// <param name="parameters">Any parameters that need to be passed. Example - LinkName</param>
    /// <param name="connectionID">The default connection string set in appsetting.json</param>
    /// <returns></returns>
    public async Task<IEnumerable<T>> LoadData<T, U>(
        string storedProcedure,
        U parameters,
        string connectionID = "Default")
    {
        //ensures proper shutdown
        using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionID));

        return await connection.QueryAsync<T>(
            storedProcedure,
            parameters,
            commandType: CommandType.StoredProcedure);

    }

    /// <summary>
    /// Accesses database and saves to it.
    /// </summary>
    /// <typeparam name="T">UserModel</typeparam>
    /// <param name="storedProcedure">The stored SQL command to execute</param>
    /// <param name="parameters">Any parameters that need to be passed. Example - LinkName</param>
    /// <param name="connectionID">The default connection string set in appsetting.json</param>
    /// <returns></returns>
    public async Task SaveData<T>(
        string storedProcedure,
        T parameters,
        string connectionID = "Default")
    {
        using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionID));

        await connection.ExecuteAsync(
        storedProcedure,
        parameters,
        commandType: CommandType.StoredProcedure);
    }
}
