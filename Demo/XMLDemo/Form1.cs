using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XMLDemo
{
    public partial class FrmXMLRead : Form
    {
        public FrmXMLRead()
        {
            InitializeComponent();
        }

        private void btnLoadXML_Click(object sender, EventArgs e)
        {
            //[1]创建XML文档操作对象
            XmlDocument objXML = new XmlDocument();
            //[2]加载XML文件到文档对象中
            objXML.Load("StuFile.xml");
            //[3]获取XML文件根目录
            XmlNode xmlNode = objXML.DocumentElement;
            //创建集合对象
            List<Student> stus = new List<Student>();
            //[4]遍历根节点  
            foreach (XmlNode stuNode in xmlNode.ChildNodes)
            {
                if (stuNode.Name == "Student")
                {
                    Student objStu = new Student();
                    //[5]遍历子节点
                    foreach (XmlNode subNode in stuNode) 
                    {
                        switch (subNode.Name)
                        {
                            case "StuName":
                                objStu.StuName = subNode.InnerText;
                                break;
                            case "StuAge":
                                objStu.StuAge = Convert.ToInt32(subNode.InnerText);
                                break;
                            case "StuSex":
                                objStu.StuSex = subNode.InnerText;
                                break;
                            case "Class":
                                objStu.Class = subNode.InnerText;
                                break;
                        };
                    }
                    stus.Add(objStu);
                }
            }
            this.dgvStuList.DataSource = stus;
        }

        // 查找XML节点两个属性值
        private void btnShowVersion_Click(object sender, EventArgs e)
        {
            // 创建XML读取器
            XmlTextReader tReader = new XmlTextReader("StuFile.xml");
            string info = null;
            while (tReader.Read())
            {
                if (tReader.Name == "Version")
                {
                    info = "版本：" + tReader.GetAttribute("vNo") 
                        + "发布时间：" + tReader.GetAttribute("pTime");
                    break;
                }
            }
            MessageBox.Show(info);
        }
    }
}
