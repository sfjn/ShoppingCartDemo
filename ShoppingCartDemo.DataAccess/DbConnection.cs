using System.Data.SQLite;
using System.IO;

namespace ShoppingCartDemo.DataAccess
{
    public class DbConnection
    {
        private static SQLiteConnection _dbConnection;

        public static SQLiteConnection Get()
        {
            var dbFilePath = "./db.sql";
            if (!File.Exists(dbFilePath))
            {
                SQLiteConnection.CreateFile(dbFilePath);
            }
            _dbConnection = new SQLiteConnection(string.Format(
                "Data Source={0};Version=3;", dbFilePath));
            _dbConnection.Open();
            return _dbConnection;
        }
    }
}
