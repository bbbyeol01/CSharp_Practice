using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS_build.View;

namespace POS_build
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new MainSell());

            LoginForm loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK) // 로그인 성공 시
            {
                Application.Run(new MainSell()); // MainSell을 시작
            }
        }
    }
}
