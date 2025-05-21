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
        public StudentService studentService = new StudentService();
        List<Student> stuList = new List<Student>();
        string filename = null;

        public FrmAddStudent()
        {
            InitializeComponent();
            // 初始化班级下拉框
            this.cbClassName.DataSource = studentClassService.GetStudentClasses();
            this.cbClassName.DisplayMember = "ClassName";
            this.cbClassName.ValueMember = "ClassId";
            this.cbClassName.SelectedIndex = -1;

            this.dgvAddStudent.AutoGenerateColumns = false;// 禁止自动生成列
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSelectPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                filename = openFileDialog.FileName;
                this.pbStuPhoto.Image = Image.FromFile(filename);
            }
        }

        private void btDeletePhoto_Click(object sender, EventArgs e)
        {
            this.pbStuPhoto.Image = null;
        }

        private void btnAddStu_Click(object sender, EventArgs e)
        {
            #region 数据验证

            if (this.tbStuName.Text.Trim().Length == 0)
            {
                MessageBox.Show("姓名不能为空！", "Message");
                this.tbStuName.Focus();
                return;
            }

            if (!(this.rdoMale.Checked || this.rdoFemale.Checked))
            {
                MessageBox.Show("请选择性别！", "Message");
                return;
            }

            if (this.cbClassName.SelectedIndex == -1)
            {
                MessageBox.Show("请选择班级！", "Message");
                return;
            }

            if (this.tbIdCard.Text.Trim().Length == 0)
            {
                MessageBox.Show("身份证不能为空！", "Message");
                this.tbStuName.Focus();
                return;
            }
            if (!Common.DataValidate.IsIdentityCard(this.tbIdCard.Text.Trim()))
            {
                MessageBox.Show("身份证号不符合要求！", "Message");
                this.tbIdCard.SelectAll();
                this.tbIdCard.Focus();
                return;
            }
            // 验证身份证号中的出生日期和用户出生日期是否一致
            string birthday = Convert.ToDateTime(this.dtpBirthday.Text.Trim()).ToString("yyyyMMdd");
            if (!this.tbIdCard.Text.Trim().Contains(birthday))
            {
                MessageBox.Show("身份证号和出生日期不匹配！", "Message");
                this.tbIdCard.SelectAll();
                this.tbIdCard.Focus();
                return;
            }

            if (studentService.IsIdExisted(this.tbIdCard.Text.Trim()))
            {
                MessageBox.Show("当前身份证号已被人使用", "Message");
                this.tbIdCard.SelectAll();
                this.tbIdCard.Focus();
                return;
            }

            if (this.tbWorkCard.Text.Trim().Length == 0)
            {
                MessageBox.Show("考勤卡号不能为空！", "Message");
                this.tbWorkCard.Focus();
                return;
            }

            if (studentService.IsCardExisted(this.tbWorkCard.Text.Trim()))
            {
                MessageBox.Show("当前考勤卡号已被人使用", "Message");
                this.tbWorkCard.SelectAll();
                this.tbWorkCard.Focus();
                return;
            }

            if (this.tbPhone.Text.Trim().Length == 0)
            {
                MessageBox.Show("电话号码不能为空！", "Message");
                this.tbPhone.Focus();
                return;
            }

            if (this.tbAddress.Text.Trim().Length == 0)
            {
                MessageBox.Show("地址不能为空！", "Message");
                this.tbAddress.Focus();
                return;
            }

            int age = DateTime.Now.Year - Convert.ToDateTime(this.dtpBirthday.Text).Year;
            if (age > 35 || age < 18)
            {
                MessageBox.Show("出生日期有误，年龄必须在18到35岁之间！", "Message");
                return;
            }



            #endregion

            // 封装学生对象
            Student student = new Student()
            {
                StudentName = this.tbStuName.Text.Trim(),
                Birthday = Convert.ToDateTime(this.dtpBirthday.Text),
                Gender = this.rdoMale.Checked ? "男" : "女",
                StudentIdNo = this.tbIdCard.Text.Trim(),
                Age = DateTime.Now.Year - Convert.ToDateTime(this.dtpBirthday.Text).Year,
                PhoneNumber = this.tbPhone.Text.Trim(),
                StudentAddress = this.tbAddress.Text.Trim(),
                CardNo = this.tbWorkCard.Text.Trim(),
                ClassId = Convert.ToInt32(this.cbClassName.SelectedValue),
                StuImage = this.pbStuPhoto.Image != null ? filename : "",
                ClassName = this.cbClassName.Text
            };
            // 存入数据库
            try
            {
                int studentId = studentService.AddStudent(student);
                if (studentId > 1)
                {
                    student.StudentId = studentId;
                    this.stuList.Add(student);
                    this.dgvAddStudent.DataSource = null;
                    this.dgvAddStudent.DataSource = this.stuList;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
