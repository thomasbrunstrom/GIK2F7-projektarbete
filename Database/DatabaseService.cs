using System;
using Microsoft.Data.Sqlite;
using Dapper;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using Backend.Models;
using System.Collections.Generic;

namespace Backend.Database
{
    public class DatabaseService : IDatabaseService
    {
        private DatabaseConfig databaseConfig;
        public DatabaseService(DatabaseConfig dbConfig)
        {
            databaseConfig = dbConfig;
        }

        public void Setup()
        {
            using(SqliteConnection connection = new SqliteConnection(databaseConfig.Name))
            {
                var table = connection.Query<string>("SELECT Name FROM sqlite_master WHERE type='table' AND name = 'Games'");
                var tableName = table.FirstOrDefault();
                if(!string.IsNullOrEmpty(tableName) && tableName == "Games")
                {
                    return;
                }
                using(var sr = new StreamReader(databaseConfig.StructureFile)) 
                {
                        var queries = sr.ReadToEnd();
                        connection.Execute(queries);
                }
            }
        }

        public Task<GameInfo> UpdateGame(GameInfo game)
        {
            throw new NotImplementedException();
        }
        public Task<GameInfo> AddGame(GameInfo game)
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<GameInfo>> Get()
        {
            throw new NotImplementedException();
        }
        public Task<GameInfo> Get(int id)
        {
            throw new NotImplementedException();
        }
        public Task<bool> RemoveGame(int id)
        {
            throw new NotImplementedException();
        }        
    }
}
