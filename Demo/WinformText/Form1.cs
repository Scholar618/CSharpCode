using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WinformText
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            string path = LoadXml();
            this.tbFilePath.Text = path;
            string data = LoadData(); // 加载属性数据
            string[] strs = data.Split(',');
            DataProperty.swVersion = strs[0];
            DataProperty.upDateTime = strs[1];
            swVersion = new MyProperty
            {
                SwVersion = strs[0],
                UpDateTime = strs[1]
            };
            propertyGrid1.SelectedObject = swVersion;
        }

        public MyProperty swVersion;
        private ProduceData my_ProduceData = new ProduceData();
        #region 生成随机数和清除数据
        // 生产随机数据
        private void btCreateRandomData_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            this.tbCTData.Text = Math.Round(random.NextDouble() + (double)random.Next(1, 5), 2).ToString();
            this.tbOutputTotal.Text = random.Next(70, 95).ToString();
            this.tbInputTotal.Text = random.Next(95, 99).ToString();
            this.tbNgTotal.Text = (Convert.ToInt32(this.tbInputTotal.Text) - Convert.ToInt32(this.tbOutputTotal.Text)).ToString();
            this.tbUPH.Text = this.tbInputTotal.Text;
            this.tbYield.Text = Math.Round(random.NextDouble() + (double)random.Next(90, 99), 2).ToString();
        }

        // 清除数据
        private void btClearData_Click(object sender, EventArgs e)
        {
            this.tbCTData.Clear();
            this.tbOutputTotal.Clear();
            this.tbInputTotal.Clear();
            this.tbNgTotal.Clear();
            this.tbUPH.Clear();
            this.tbYield.Clear();
        }
        #endregion

        #region 加载二进制数据
        // 加载数据
        private void btLoadData_Click(object sender, EventArgs e)
        {
            my_ProduceData = LoadBina<ProduceData>();
            tbInputTotal.Text = my_ProduceData.InputTotal.ToString();
            tbOutputTotal.Text = my_ProduceData.OutputTotal.ToString();
            tbNgTotal.Text = my_ProduceData.NgTotal.ToString();
            tbYield.Text = my_ProduceData.Yield.ToString();
            tbUPH.Text = my_ProduceData.UPH.ToString();
            tbCTData.Text = my_ProduceData.CTData.ToString();
        }

        private T LoadBina<T>()
        {
            object data = new object();
            try
            {
                using (FileStream fileStream = new FileStream(tbFilePath.Text + "\\saveBina.config", FileMode.OpenOrCreate))
                {
                    BinaryFormatter bina = new BinaryFormatter();
                    data = (T)bina.Deserialize(fileStream);
                }
                MessageBox.Show("加载二进制数据完成！");
            }
            catch (Exception)
            {
                MessageBox.Show("加载二进制数据失败！");
                return (T)data;
            }
            return (T)data;
        }
        #endregion

        #region 保存路径
        private void btnSavePath_Click(object sender, EventArgs e)
        {
            SaveToXml(tbFilePath.Text);
        }


        private bool SaveToXml(string str)
        {
            try
            {
                using (FileStream fileStream = new FileStream("path.config", FileMode.OpenOrCreate))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(string));
                    xmlSerializer.Serialize(fileStream, str);
                }
                MessageBox.Show("路径保存成功！");
            }
            catch (Exception)
            {
                MessageBox.Show("路径保存失败！");
                return false;
            }

            return true;
        }

        private string LoadXml()
        {
            string path;
            try
            {
                using (FileStream fileStream = new FileStream("path.config", FileMode.OpenOrCreate))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(string));
                    path = xmlSerializer.Deserialize(fileStream).ToString();
                }
            }
            catch (Exception)
            {
                return "";
            }
            return path;
        }
        #endregion

        #region TXT和CSV保存
        private void btnSaveTxt_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(tbFilePath.Text))
            {
                Directory.CreateDirectory(tbFilePath.Text);
            }
            string fileName = tbFilePath.Text + "\\生产总值.txt";
            string WriteString = string.Format("投入总数：{0}，产出总数：{1}，设备良率：{2}，NG总数：{3}"
                , this.tbInputTotal.Text
                , this.tbOutputTotal.Text
                , Convert.ToDouble(this.tbYield.Text).ToString("f2")
                , this.tbNgTotal.Text);
            try
            {
                using (StreamWriter sw = new StreamWriter(fileName, false, Encoding.UTF8))
                {
                    sw.WriteLine(WriteString);
                }
                MessageBox.Show("文件写入完成！");
            }
            catch (Exception)
            {
                MessageBox.Show("文件写入失败！");
                return;
            }
        }

        private void btnSaveCSV_Click(object sender, EventArgs e)
        {
            string filename = tbFilePath.Text + "\\生产数据.csv";
            string title = "写入时间，投入总数，产出总数，设备良率，NG总数";
            string data = string.Format("{0}, {1}, {2}, {3}, {4}", DateTime.Now.ToString("yyyyMMddHHmmss"),
                this.tbInputTotal.Text,
                this.tbOutputTotal.Text,
                Convert.ToDouble(this.tbYield.Text).ToString("f2"),
                this.tbNgTotal.Text);
            try
            {
                if (!File.Exists(filename))
                {
                    using (StreamWriter sw = new StreamWriter(filename, false, Encoding.UTF8))
                    {
                        sw.WriteLine(title);
                        sw.WriteLine(data);
                    }
                }
                else
                {
                    using (StreamWriter sw = new StreamWriter(filename, true, Encoding.UTF8))
                    {
                        sw.WriteLine(data);
                    }
                }
                MessageBox.Show("文件写入完成！");
            }
            catch (Exception)
            {
                MessageBox.Show("文件写入失败！");
                return;
            }
        }
        #endregion

        #region 序列化保存
        private bool SaveToBina<T>(object data)
        {
            try
            {
                using (FileStream fileStream = new FileStream(tbFilePath.Text + "\\saveBina.config", FileMode.OpenOrCreate))
                {
                    BinaryFormatter bina = new BinaryFormatter();
                    bina.Serialize(fileStream, data);
                }
                MessageBox.Show("文件写入完成！");
            }
            catch (Exception)
            {
                MessageBox.Show("文件写入失败！");
                return false;
            }
            return true;
        }

        private void btnSerialSave_Click(object sender, EventArgs e)
        {
            my_ProduceData.InputTotal = Convert.ToInt32(this.tbInputTotal.Text);
            my_ProduceData.OutputTotal = Convert.ToInt32(this.tbOutputTotal.Text);
            my_ProduceData.NgTotal = Convert.ToInt32(this.tbNgTotal.Text);
            my_ProduceData.Yield = Convert.ToDouble(this.tbYield.Text);
            my_ProduceData.UPH = Convert.ToInt32(this.tbUPH.Text);
            my_ProduceData.CTData = Convert.ToDouble(this.tbCTData.Text);
            SaveToBina<ProduceData>(my_ProduceData);
        }
        #endregion

        #region 保存加载属性数据
        private void btnSave_Click(object sender, EventArgs e)
        {
            DataProperty.swVersion = swVersion.SwVersion;
            DataProperty.upDateTime = swVersion.UpDateTime;
            SaveToData(DataProperty.swVersion, DataProperty.upDateTime);
        }

        private bool SaveToData(string str1, string str2)
        {
            try
            {
                using (FileStream fileStream = new FileStream(tbFilePath.Text + "\\saveData.config", FileMode.OpenOrCreate))
                {
                    BinaryFormatter bina = new BinaryFormatter();
                    bina.Serialize(fileStream, str1 + "," + str2);
                }
                MessageBox.Show("属性文件写入完成！");
            }
            catch (Exception)
            {
                MessageBox.Show("属性文件写入失败！");
                return false;
            }
            return true;
        }

        private string LoadData()
        {
            string data = "";
            try
            {
                using (FileStream fileStream = new FileStream(tbFilePath.Text + "\\saveData.config", FileMode.OpenOrCreate))
                {
                    BinaryFormatter bina = new BinaryFormatter();
                    data = bina.Deserialize(fileStream).ToString();
                }
                MessageBox.Show("加载属性数据完成！");
            }
            catch (Exception)
            {
                MessageBox.Show("加载属性数据失败！");
                return data;
            }
            return data;
        }
        #endregion
    }



    [Serializable]
    public class ProduceData
    {
        public int InputTotal { get; set; }
        public int OutputTotal { get; set; }
        public int NgTotal { get; set; }
        public double Yield { get; set; }
        public int UPH { get; set; }
        public double CTData { get; set; }

    }

    [Serializable]
    public class DataProperty
    {
        public static string swVersion { get; set; }
        public static string upDateTime { get; set; }
    }

    [Serializable]
    public class MyProperty              //声明MyProperty类
    {
        private string _swVersion = DataProperty.swVersion;

        [DisplayName("软件版本号"), Category("软件版本管控"), Description("当前的软件版本")]
        public string SwVersion
        {
            get => _swVersion;
            set => _swVersion = value;
        }
        private string _upDateTime = DataProperty.upDateTime;
        [DisplayName("软件版本号"), Category("软件版本管控"), Description("当前的软件版本")]
        public string UpDateTime
        {
            get => _upDateTime;
            set => _upDateTime = value;
        }


    }

}
