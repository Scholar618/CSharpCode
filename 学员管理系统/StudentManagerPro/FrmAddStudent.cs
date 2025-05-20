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
    public partial class FrmAddStudent : Form
    {
        public StudentClassService studentClassService = new StudentClassService();
        public StudentClass studentClass = new StudentClass();

        public FrmAddStudent()
        {
            InitializeComponent();
            // 初始化班级下拉框
            this.cbClassName.DataSource = studentClassService.GetStudentClasses();
            this.cbClassName.DisplayMember = "ClassName";
            this.cbClassName.ValueMember = "ClassId";
            this.cbClassName.SelectedIndex = -1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
