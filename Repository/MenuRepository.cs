using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_build
{
    public partial class MainSell : Form
    {

        readonly string _server = "localhost";
        readonly int _port = 3308;
        readonly string _database = "pos_dataset";
        readonly string _id = "root";
        readonly string _pw = "abcde12345";
        string _connetionAddress = "";

       

        private List<(string, string, string)> getMenuByCategory(string category)
        {
            List<(string, string, string)> menu = new List<(string, string, string)>();

            using (MySqlConnection connection = new MySqlConnection(_connetionAddress))
            {
                connection.Open();
                string query = "SELECT name, price, image FROM menu WHERE category = @category";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@category", category);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string name = reader["name"].ToString();
                    string price = $"{reader["price"].ToString()}원";
                    string image = reader["image"].ToString();
                    menu.Add((name, price, image));
                }

            }

            return menu;
        }


    }
}
