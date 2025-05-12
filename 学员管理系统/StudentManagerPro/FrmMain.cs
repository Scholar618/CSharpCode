using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagerPro
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.labelCurrentUser.Text = Program.currentAdmin.AdminName + "]";
        }

        #region 关闭已存在窗体并打开新窗体
        // 关闭已经存在的窗体
        private void ClosePreForm()
        {
            foreach (var item in this.spContainer.Panel2.Controls)
            {
                if (item is Form)
                {
                    Form closeFrm = (Form)item;
                    closeFrm.Close();
                }
            }
        }

        // 打开窗体到panel2
        private void OpenForm(Form form)
        {
            form.TopLevel = false; // 子窗体设置为非顶级控件
            form.WindowState = FormWindowState.Maximized; // 最大化
            form.FormBorderStyle = FormBorderStyle.None; // 去边框
            form.Parent = this.spContainer.Panel2;
            form.Dock = DockStyle.Fill;
            form.Show();
        }
        #endregion

        #region 窗体跳转
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            ClosePreForm();
            OpenForm(new FrmAddStudent());
        }

        private void btnStudentManage_Click(object sender, EventArgs e)
        {
            ClosePreForm();
            OpenForm(new FrmStudentManage());
        }

        private void btnImportData_Click(object sender, EventArgs e)
        {
            ClosePreForm();
            OpenForm(new FrmImportData());
        }

        private void btnPwdModify_Click(object sender, EventArgs e)
        {
            FrmModifyPwd frmModifyPwd = new FrmModifyPwd();
            frmModifyPwd.ShowDialog();
        }

        #endregion

        #region 系统关闭
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("确认退出吗？", "退出询问",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnExitSystem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExitSys_Click(object sender, EventArgs e)
        {
            btnExitSystem_Click(null, null);
        }
        #endregion

        private void btnChangeUser_Click(object sender, EventArgs e)
        {
            // 打开登陆窗体
            string oldName = Program.currentAdmin.AdminName;
            FrmUserLogin frmUserLogin = new FrmUserLogin();
            frmUserLogin.Text = "账号切换";
            DialogResult dialogResult = frmUserLogin.ShowDialog();
            if (dialogResult == DialogResult.OK && oldName != Program.currentAdmin.AdminName)
            {
                ClosePreForm();
                this.labelCurrentUser.Text = Program.currentAdmin.AdminName + "]";
            }
            else if (dialogResult == DialogResult.OK && oldName == Program.currentAdmin.AdminName)
            {
                MessageBox.Show("您已经在当前账户下！");
            }

        }


    }
}
