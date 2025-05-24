using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DAL;
using Models;

namespace StudentManagerPro
{
    public partial class FrmStudentManage : Form
    {
        public StudentClassService studentClassService = new StudentClassService();
        public StudentService studentService = new StudentService();
        List<Student> stus = new List<Student>();

        public FrmStudentManage()
        {
            InitializeComponent();
            // 初始化班级下拉框
            this.cbClassName.DataSource = studentClassService.GetStudentClasses();
            this.cbClassName.DisplayMember = "ClassName";
            this.cbClassName.ValueMember = "ClassId";
            this.cbClassName.SelectedIndex = -1;

            this.dgvShowData.AutoGenerateColumns = false;// 禁止自动生成列
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSelectByClass_Click(object sender, EventArgs e)
        {
            stus = studentService.GetStudent(
                Convert.ToInt32(this.cbClassName.SelectedValue), this.cbClassName.Text);
            this.dgvShowData.DataSource = stus;

        }

        private void sortByName_Click(object sender, EventArgs e)
        {
            this.stus.Sort(new NameDESC());
            this.dgvShowData.Refresh();
        }

        private void sortById_Click(object sender, EventArgs e)
        {
            this.stus.Sort(new IdDESC());
            this.dgvShowData.Refresh();
        }

        private void btSelectById_Click(object sender, EventArgs e)
        {

        }
    }

    #region 排序
    class NameDESC : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return y.StudentName.CompareTo(x.StudentName);
        }

    }

    class IdDESC : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return y.StudentId.CompareTo(x.StudentId);
        }
    }

    #endregion
}
