using System.Data;
using System.Data.SQLite;
using System.Threading.Tasks;
using Dapper;

namespace sTextEditor.Repositories
{
    public class DbFileRepository
    {
        private readonly SQLiteConnection _connection;

        public DbFileRepository(string connectionString)
        {
            _connection = new SQLiteConnection(connectionString);
        }

        public async Task<byte[]> LoadFileAsync(string name)
        {
            _connection.Open();

            var fileContent = await _connection.ExecuteScalarAsync<byte[]>(
                "SELECT Content " +
                "FROM FileInfo " +
                "WHERE Name = @Name",
                param: new { Name = name });

            _connection.Close();

            return fileContent;
        }

        public DataTable LoadAllFiles()
        {
            _connection.Open();

            var sql = new SQLiteCommand("" +
                "SELECT Id, Name, LENGTH(Content) || ' B' AS Size " +
                "FROM FileInfo", _connection);

            var dataAdapter = new SQLiteDataAdapter(sql);
            var resultDataTable = new DataTable();
            dataAdapter.Fill(resultDataTable);

            _connection.Close();

            return resultDataTable;
        }

        public async Task<bool> IsFileExistsAsync(string fileName)
        {
            _connection.Open();

            var fileId = await _connection.QueryFirstOrDefaultAsync<int?>(
                "SELECT Id " +
                "FROM FileInfo " +
                "WHERE Name = @Name",
                param: new { Name = fileName });

            _connection.Close();

            return fileId != null;
        }

        public async Task<int> InsertFileAsync(string fileName, byte[] fileContent)
        {
            _connection.Open();

            var updateResult = await _connection.ExecuteAsync(
                "INSERT INTO FileInfo (Name, Content) " +
                "VALUES (@Name, @Content)",
                param: new { Name = fileName, Content = fileContent });

            _connection.Close();

            return updateResult;
        }

        public async Task<int> UpdateFileAsync(string fileName, byte[] fileContent)
        {
            _connection.Open();

            var updateResult = await _connection.ExecuteAsync(
                "UPDATE FileInfo " +
                "SET Content = @Content " +
                "WHERE Name = @Name",
                param: new { Name = fileName, Content = fileContent });

            _connection.Close();

            return updateResult;
        }

        public async Task EnsureDbCreatedAsync()
        {
            _connection.Open();

            var fileInfoTable = await _connection.ExecuteScalarAsync<string>(
                "SELECT name " +
                "FROM SQLITE_MASTER " +
                "WHERE type='table' AND name='FileInfo'");

            if (string.IsNullOrEmpty(fileInfoTable))
            {
                await _connection.ExecuteAsync(
                    $"CREATE TABLE FileInfo " +
                    $"(Id INTEGER PRIMARY KEY, Name TEXT UNIQUE, Content BLOB)");
            }

            _connection.Close();
        }
    }
}
