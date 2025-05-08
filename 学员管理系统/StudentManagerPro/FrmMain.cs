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
            form.Show();
        }
        #endregion

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
    }
}
