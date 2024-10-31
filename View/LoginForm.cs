using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_build.View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            if (login())
            {
                this.DialogResult = DialogResult.OK; // 다이얼로그 결과 설정
                this.Close(); // 로그인 폼 닫기
            }
        }

        private bool login()
        {
            string userId = "root";
            string userPwd = "1234";

            if (Txt_inputPwd.Text == "" || Txt_inputId.Text == "")
            {
                MessageBox.Show("아이디와 비밀번호를 모두 입력하세요.");
                Txt_inputId.Clear();
                Txt_inputPwd.Clear();
                return false;
            }

            if (Txt_inputId.Text != userId || Txt_inputPwd.Text != userPwd)
            {
                MessageBox.Show("아이디나 비밀번호가 올바르지 않습니다.");
                Txt_inputId.Clear();
                Txt_inputPwd.Clear();
                return false;
            }


            return true;
            
        }

    }
}
