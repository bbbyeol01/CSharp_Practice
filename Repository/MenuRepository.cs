using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS_build.Repository;
using System.Xml.Linq;

namespace POS_build
{
    public partial class MainSell : Form
    {

        private List<(string, string, string, List<string>)> getMenuByCategory(string category)
        {
            List<(string, string, string, List<string>)> menu = new List<(string, string, string, List<string>)>();
            List<string> types = new List<string>();

            MySqlConnection connection = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                DatabaseManager databaseManager = new DatabaseManager();
                connection = databaseManager.GetConnection();

                string query = "SELECT idx, name, price, image FROM menu WHERE category = @category";
                
                cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@category", category);

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int idx = int.Parse(reader["idx"].ToString());
                    string name = reader["name"].ToString();
                    string price = $"{reader["price"].ToString()}원";
                    string image = reader["image"].ToString();

                    types = getTypes(idx);

                    menu.Add((name, price, image, types));
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader?.Close(); // 리더 닫기
                cmd?.Dispose();  // 명령 해제
            }

            return menu;
        }

        public List<string> getTypes(int menuIdx)
        {
            List<string> types = new List<string>();
            DatabaseManager databaseManager = new DatabaseManager();

            try
            {
                MySqlConnection connection = databaseManager.GetConnection();
                string query = "SELECT type FROM drink_type WHERE menu_idx = @menu_idx";


                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@menu_idx", menuIdx);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string type = $"{reader["type"].ToString()}";
                        types.Add(type);
                    }
                }

            }
            catch (Exception ex)
            {

            }

            types.Sort((a, b) => a.CompareTo(b));

            return types;

        }

        public List<(string, string)> getOptions()
        {
            List<(string, string)> options = new List<(string, string)>();

            DatabaseManager databaseManager = new DatabaseManager();

            using (MySqlConnection connection = databaseManager.GetConnection())
            {
                string query = "SELECT name, price FROM drink_option";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string name = reader["name"].ToString();
                        string price = $"{reader["price"].ToString()}원";
                        options.Add((name, price));
                    }
                }

            }

            return options;
        }
    }
}
