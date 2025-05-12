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
    public partial class FrmModifyPwd : Form
    {
        public FrmModifyPwd()
        {
            InitializeComponent();
        }

        private void btnConfirmModify_Click(object sender, EventArgs e)
        {
            #region 密码验证
            if (this.tbNewPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入新密码！", "Message");
                this.tbNewPwd.Focus();
                return;
            }
            if (this.tbOldPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入原密码！", "Message");
                this.tbOldPwd.Focus();
                return;
            }
            if (this.tbConfirmNewPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入确认密码！", "Message");
                this.tbConfirmNewPwd.Focus();
                return;
            }
            if (this.tbNewPwd.Text.Trim() != this.tbConfirmNewPwd.Text)
            {
                MessageBox.Show("两次密码输入不一致！", "Message");
                this.tbConfirmNewPwd.Focus();
                return;
            }
            if (this.tbOldPwd.Text.Trim() != Program.currentAdmin.LoginPwd)
            {
                MessageBox.Show("请输入正确的原密码！", "Message");
                this.tbOldPwd.Focus();
                this.tbOldPwd.SelectAll();
                return;
            }
            #endregion

            try
            {
                SysAdmin objAdminService = new SysAdmin()
                {
                    LoginId = Program.currentAdmin.LoginId,
                    LoginPwd = this.tbNewPwd.Text.Trim()
                };
                if (new SysAdminService().ModifyPwd(objAdminService) == 1)
                {
                    MessageBox.Show("密码修改成功！", "Message");
                    Program.currentAdmin.LoginPwd = this.tbNewPwd.Text.Trim();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("密码修改失败：" + ex.Message);
            }

        }

        private void btnCancelModify_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
