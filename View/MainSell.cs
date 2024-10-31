using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
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

            _connetionAddress = $"Server={_server};Port={_port};Database={_database};Uid={_id};Pwd={_pw}";


            MySqlConnection connection = new MySqlConnection(_connetionAddress);
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                MessageBox.Show("Connected!");
            }
            else
            {
                MessageBox.Show("DisConnected");
            }
        }



        private void Btn_coffee_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            List<(string, string, string)> menu = getMenuByCategory("coffee");
            
            menuPrint(menu);
        }


        private void Btn_nonCoffee_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            List<(string, string, string)> menu = getMenuByCategory("nonCoffee");
            menuPrint(menu);
        }

        private void menuPrint(List<(string, string, string)> menu)
        {
            int xOffset = 0; // 초기 y 위치 설정

            foreach (var (name, price, image) in menu)
            {
                MenuItem menuControl = new MenuItem();
                menuControl.MenuName = name;     // 메뉴 이름 설정
                menuControl.MenuPrice = price;   // 메뉴 가격 설정
                
                // PictureBox의 SizeMode를 설정하여 이미지 크기를 조절
                menuControl.setImageMode(PictureBoxSizeMode.StretchImage); // 이미지를 PictureBox 크기에 맞게 늘리기

                // 이미지 로드
                // menuControl.MenuImage = Image.FromFile("C:\\Users\\KOSTA\\source\\repos\\POS_build\\Properties\\americano.png");
                menuControl.MenuImage = Properties.Resources.americano;

                // 각 UserControl의 위치를 다르게 설정
                menuControl.Location = new System.Drawing.Point(xOffset, 0);
                xOffset += menuControl.Width; // y 위치를 다음 UserControl의 위치로 설정

                panel1.Controls.Add(menuControl); // Panel에 UserControl 추가
            }
        }

        private void Btn_teaAndAde_Click(object sender, EventArgs e)
        {

        }
    }
}
