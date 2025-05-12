using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Models;

namespace StudentManagerPro
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 显示登陆窗体
            FrmUserLogin frmUserLogin = new FrmUserLogin();
            DialogResult dialogResult = frmUserLogin.ShowDialog();

            if (dialogResult == DialogResult.OK)
                Application.Run(new FrmMain());
            else
                Application.Exit();


            // Application.Run(new FrmMain());
            // Application.Run(new FrmUserLogin());
            // Application.Run(new FrmAddStudent());
        }

        // 登陆用户信息
        public static SysAdmin currentAdmin = null;
    }
}
