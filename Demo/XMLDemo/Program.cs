using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLDemo
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmXMLRead());
        }

    }
    public class Student
    {
        public string StuName { get; set; }
        public int StuAge { get; set; }
        public string StuSex { get; set; }
        public string Class { get; set; }
    }
}
