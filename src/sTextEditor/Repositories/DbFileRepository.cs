using System;
using System.Data;
using System.Data.SQLite;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace sTextEditor.Repositories
{
    public class DbFileRepository : IFileRepository
    {
        private readonly SQLiteConnection _connection;

        public DbFileRepository(string connectionString)
        {
            _connection = new SQLiteConnection(connectionString);
            EnsureDbCreated();
        }

        public async Task<byte[]> LoadFileAsync(string name)
        {
            _connection.Open();

            var fileContent = await _connection.ExecuteScalarAsync<byte[]>($"" +
                $"SELECT Content " +
                $"FROM FileInfo " +
                $"WHERE Name='{name}'");

            _connection.Close();
            return fileContent;
        }

        public async Task SaveFileAsync(string name, string fileContent)
        {
            _connection.Open();

            var existingFileId = _connection.ExecuteScalar<int>(
                $"SELECT Id " +
                $"FROM FileInfo " +
                $"WHERE Name = '{name}'");

            var command = new SQLiteCommand(_connection);

            if (existingFileId <= 0)
            {
                command.CommandText =
                    $"INSERT INTO FileInfo (Name, Content, LastModifiedDate) " +
                    $"VALUES ('{name}', @content, '{DateTime.Now.ToString()}')";
            }
            else
            {
                command.CommandText =
                    $"UPDATE FileInfo " +
                    $"SET Content = @content, LastModifiedDate = '{DateTime.Now.ToString()}' " +
                    $"WHERE Id = {existingFileId}";
            }

            var parameter = new SQLiteParameter("@content", DbType.Binary);
            parameter.Value = Encoding.UTF8.GetBytes(fileContent);
            command.Parameters.Add(parameter);

            await command.ExecuteNonQueryAsync();

            _connection.Close();
        }

        private void EnsureDbCreated()
        {
            _connection.Open();

            var fileInfoTable = _connection.ExecuteScalar<string>(
                "SELECT name " +
                "FROM SQLITE_MASTER " +
                "WHERE type='table' AND name='FileInfo'");

            if (string.IsNullOrEmpty(fileInfoTable))
            {
                _connection.Execute(
                    $"CREATE TABLE FileInfo " +
                    $"(Id INTEGER PRIMARY KEY, Name TEXT UNIQUE, Content BLOB, LastModifiedDate DATETIME)");
            }

            _connection.Close();
        }
    }
}
