using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDeepStudy
{
    // 委托的定义
    delegate void MyDel(int value1, int value2);

    class Program
    {
        static void Main(string[] args)
        {
            /* 多播委托
             建议使用在无返回类型的委托中，
             如果有返回类型，将会返回委托中最后一个方法的结果
             */
            int value1 = 20, value2 = 10;
            MyDel myDel = new MyDel(Add);
            myDel += new MyDel(Del);
            myDel += new MyDel(Mul);
            myDel(value1, value2);

            myDel -= new MyDel(Del);
            myDel(value1, value2);

        }

        public static void Add(int value1, int value2)
        { 
            Console.WriteLine("Add is {0}", value1 + value2);
        }

        public static void Del(int value1, int value2)
        {
            Console.WriteLine("Del is {0}", value1 - value2);
        }

        public static void Mul(int value1, int value2)
        {
            Console.WriteLine("Mul is {0}", value1 / value2);
        }


    }
}
