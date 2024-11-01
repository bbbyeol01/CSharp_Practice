using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_build.Repository
{
    public class DatabaseManager
    {
        private readonly string _server = "localhost";
        private readonly int _port = 3308;
        private readonly string _database = "pos_dataset";
        private readonly string _id = "root";
        private readonly string _pw = "abcde12345";
        private string _connectionAddress = "";
        private MySqlConnection _connection;

        public DatabaseManager()
        {
            _connectionAddress = $"Server={_server};Port={_port};Database={_database};Uid={_id};Pwd={_pw}";
        }

        public MySqlConnection GetConnection()
        {
            if (_connection == null || _connection.State == ConnectionState.Closed)
            {
                _connection = new MySqlConnection(_connectionAddress);
                _connection.Open();
            }
            return _connection;
        }
    }
}
