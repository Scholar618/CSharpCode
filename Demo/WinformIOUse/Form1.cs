using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WinformIOUse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            //1、创建文件流
            FileStream fs = new FileStream("F:\\mytext.txt", FileMode.Create);
            //2、创建写入器
            StreamWriter sw = new StreamWriter(fs);
            //3、以流的形式写入数据
            sw.Write(this.textContent.Text.Trim());
            //4、关闭写入器
            sw.Close();
            //5、关闭文件流
            fs.Close();
            MessageBox.Show("写入成功！");
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            //1、创建文件流
            FileStream fs = new FileStream("F:\\mytext.txt", FileMode.Open);
            //2、创建读取器
            StreamReader sr = new StreamReader(fs);
            //3、以流的形式读取数据
            this.textContent.Text = sr.ReadToEnd();
            //4、关闭读取器
            sr.Close();
            //5、关闭文件流
            fs.Close();
        }

        private void btnSystemLog_Click(object sender, EventArgs e)
        {
            //1、创建文件流
            FileStream fs = new FileStream("F:\\mytext.txt", FileMode.Append);
            //2、创建写入器
            StreamWriter sw = new StreamWriter(fs);
            //3、以流的形式逐行添加
            sw.WriteLine(DateTime.Now.ToString() + "[文件操作正常！]");
            //4、关闭写入器
            sw.Close();
            //5、关闭文件流
            fs.Close();
            MessageBox.Show("写入成功！");
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            File.Delete(this.textFromFile.Text.Trim());
            MessageBox.Show("删除成功！");
        }

        private void btnCopyFile_Click(object sender, EventArgs e)
        {
            // 如果文件存在，直接复制会产生错误
            if (File.Exists(this.textToFile.Text.Trim()))
            {
                File.Delete(this.textToFile.Text.Trim());
            }
            if (File.Exists(this.textFromFile.Text.Trim()))
            {
                File.Copy(this.textFromFile.Text.Trim(), this.textToFile.Text.Trim());
                MessageBox.Show("文件复制成功！");
            }
            else 
            {
                MessageBox.Show("源文件不存在！");
            }
        }

        private void btnMoveFile_Click(object sender, EventArgs e)
        {
            // 如果文件存在，直接复制会产生错误
            if (File.Exists(this.textToFile.Text.Trim()))
            {
                File.Delete(this.textToFile.Text.Trim());
            }
            try
            {
                if (File.Exists(this.textFromFile.Text.Trim()))
                {
                    File.Move(this.textFromFile.Text.Trim(), this.textToFile.Text.Trim());
                    MessageBox.Show("文件移动成功！");
                }
                else
                {
                    MessageBox.Show("源文件不存在！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"操作失败：{ex.Message}");
            }

        }

        private void btnShowFile_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(this.textFromFile.Text.Trim());
            this.textContent.Clear();
            foreach (var item in files)
            {
                this.textContent.Text += item + '\n';
            }
        }

        private void btnShowCatlog_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetDirectories(this.textFromFile.Text.Trim());
            this.textContent.Clear();
            foreach (var item in files)
            {
                this.textContent.Text += item + '\n';
            }
        }

        private void btnCreateCatlog_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(this.textFromFile.Text.Trim());
            MessageBox.Show("目录创建成功！");
        }

        private void btnDeleteCatlogAndFile_Click(object sender, EventArgs e)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(this.textFromFile.Text.Trim());
            directoryInfo.Delete();
        }
    }
}
