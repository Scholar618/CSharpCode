using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Models;
using DAL;

namespace StudentManagerPro
{
    public partial class FrmUserLogin : Form
    {
        SysAdminService objAdminService = new SysAdminService();
        public FrmUserLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //【1】数据验证
            if (this.tbUserName.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入用户名！", "Message");
                this.tbUserName.Focus();
                return;
            }
            if (this.tbPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入用户名！", "Message");
                this.tbUserName.Focus();
                return;
            }
            // TODO:用户名和密码验证未实现

            //【2】封装对象（Username And Pwd）
            SysAdmin objAdmin = new SysAdmin()
            {
                LoginId = Convert.ToInt32(this.tbUserName.Text.Trim()),
                LoginPwd = this.tbPwd.Text.Trim()
            };

            
            try
            {
                // 【3】和后台交互
                Program.currentAdmin = objAdminService.AdminLogin(objAdmin);
                // 【4】处理交互结果
                if (Program.currentAdmin != null)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！", "Message");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "数据库访问异常");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        #region 回车键确认
        private void tbUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.tbUserName.Text.Trim().Length != 0 && e.KeyValue == 13)
            {
                this.tbPwd.Focus();
                this.tbPwd.SelectAll();
            }
        }

        private void tbPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                btnLogin_Click(null, null);
            }
        }
        #endregion
    }
}
