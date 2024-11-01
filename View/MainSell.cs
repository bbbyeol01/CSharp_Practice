using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using POS_build.Repository;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace POS_build
{
    public partial class MainSell : Form
    {
       
        //DataTable table = new DataTable();


        public MainSell()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            DatabaseManager databaseManager = new DatabaseManager();

            MySqlConnection connection = null;

            try
            {
                connection = databaseManager.GetConnection();

                if (connection.State == ConnectionState.Open)
                {
                    MessageBox.Show("Connected!");
                }
                else
                {
                    MessageBox.Show("DisConnected");
                }
            }catch(Exception ex)
            {

            }
            //finally
            //{
            //    connection?.Close();
            //}


            List<(string, string, string, List<string>)> menu = getMenuByCategory("coffee");

            menuPrint(menu);

        }

        private void menuPrint(List<(string, string, string, List<string>)> menu)
        {
            int xOffset = 0; // 초기 y 위치 설정
            int yOffset = 0;

            foreach (var (name, price, image, types) in menu)
            {
                MenuItem menuControl = new MenuItem();
                menuControl.MenuName = name;     // 메뉴 이름 설정
                menuControl.MenuPrice = price;   // 메뉴 가격 설정

                menuControl.setImageMode(PictureBoxSizeMode.StretchImage);

                // 이미지 로드
                //menuControl.MenuImage = Properties.Resources.choco;
                var resource = typeof(Properties.Resources).GetProperty(image, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);

                if (resource == null)
                {
                    MessageBox.Show($"리소스 '{image}'을(를) 찾을 수 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    // 리소스를 Image 형식으로 변환하여 MenuImage에 할당합니다.
                    menuControl.MenuImage = (Image)resource.GetValue(null);
                }

                foreach (var type in types)
                {
                    menuControl.Lbl_types += $"{type} ";
                }


                // 각 UserControl의 위치를 다르게 설정
                menuControl.Location = new System.Drawing.Point(xOffset, yOffset);
                xOffset += menuControl.Width;

                if (xOffset + menuControl.Width > this.Width)
                {
                    yOffset += menuControl.Height;
                    xOffset = 0;
                }


                panel1.Controls.Add(menuControl); // Panel에 UserControl 추가
            }
        }

        private void Btn_coffee_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            List<(string, string, string, List<string>)> menu = getMenuByCategory("coffee");
            
            menuPrint(menu);
        }

        private void Btn_nonCoffee_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            List<(string, string, string, List<string>)> menu = getMenuByCategory("nonCoffee");
            menuPrint(menu);
        }

        private void Btn_teaAndAde_Click(object sender, EventArgs e)
        {

        }
    }
}
