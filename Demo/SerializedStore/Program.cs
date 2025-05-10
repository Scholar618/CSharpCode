using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

namespace SerializedStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] stu = CreateStu();

            // 二进制序列化（已过时）
            BinarySerialized(stu);

            // Json序列化
            JsonSerialized(stu);
            
            Console.ReadLine();
        }

        public static Student[] CreateStu()
        {
            Student stu1 = new Student()
            {
                Name = "小米",
                Age = 20,
                Sex = 'W',
                Birthday = "2003-02-13"
            };
            Student stu2 = new Student()
            {
                Name = "小红",
                Age = 22,
                Sex = 'M',
                Birthday = "2003-05-20"
            };
            Student[] stu = new Student[2];
            stu[0] = stu1;
            stu[1] = stu2;

            return stu;
        }

        public static void BinarySerialized(Student[] stu)
        {

            //[1]创建文件流
            FileStream fs = new FileStream("obj.stu", FileMode.Create);
            //[2]创建二进制序列化器
            BinaryFormatter bf = new BinaryFormatter();
            //[3]调用序列化方法
            bf.Serialize(fs, stu);
            //[4]关闭文件流
            fs.Close();

            //[1]创建文件流
            FileStream fs2 = new FileStream("obj.stu", FileMode.Open);
            //[2]创建二进制序列化器
            BinaryFormatter bf2 = new BinaryFormatter();
            //[3]调用反序列化方法
            Student[] stu3 = (Student[])bf2.Deserialize(fs2);
            //[4]关闭文件流
            fs.Close();

            Console.WriteLine(stu3[1].Name + " " + stu3[1].Age + " " + stu3[1].Sex + " " + stu3[1].Birthday);
        }

        public static void JsonSerialized(Student[] stu)
        {

            //[1]创建文件流
            FileStream fs = new FileStream("obj2.stu", FileMode.Create);
            //2、创建写入器
            StreamWriter sw = new StreamWriter(fs);
            //[2]创建Json序列化器
            string json = JsonSerializer.Serialize(stu);
            //[3]存入文件
            sw.Write(json);
            //[4]关闭文件流
            sw.Close();
            fs.Close();

            //[1]创建文件流
            FileStream fs2 = new FileStream("obj2.stu", FileMode.Open);
            // 创建读取器并以流的形式读取
            StreamReader sr = new StreamReader(fs2);
            string json2 = sr.ReadToEnd();
            Student[] stu3 = JsonSerializer.Deserialize<Student[]>(json2);
            sr.Close();
            fs2.Close();
            Console.WriteLine(stu3[1].Name + " " + stu3[1].Age + " " + stu3[1].Sex + " " + stu3[1].Birthday);
        }
    }

    [Serializable]
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public char Sex { get; set; }
        public String Birthday { get; set; }
    }
}
