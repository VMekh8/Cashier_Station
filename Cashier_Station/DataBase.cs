using MySql.Data.MySqlClient;

namespace Cashier_Station
{
    public class DataBase
    {
        private readonly MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=cashierstation");

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        
        public void CloseConnection()
        {
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection GetConnection() => connection;

    }
}
