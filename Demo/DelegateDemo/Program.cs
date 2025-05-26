using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    // 委托是一种类，与Program同级别
    public delegate int Calc(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            Action action = new Action(cal.Report);
            action.Invoke();
            action();

            Func<int, int, int> func1 = new Func<int, int, int>(cal.Add);
            Func<int, int, int> func2 = new Func<int, int, int>(cal.Sub);
            func1.Invoke(5, 4);
            func2.Invoke(5, 4);
            func1(5, 4);
            func2(5, 4);

            // 自定义委托
            Calc calc1 = new Calc(cal.Add);
            Calc calc2 = new Calc(cal.Sub);
            calc1.Invoke(5, 4);
            calc2.Invoke(5, 4);
        }
    }

    class Calculator
    {
        public void Report()
        {
            Console.WriteLine("I have 3 method!");
        }

        public int Add(int a, int b)
        {
            Console.WriteLine("a + b = {0}", a+b);
            return a + b;
        }

        public int Sub(int a, int b)
        {
            Console.WriteLine("a - b = {0}", a - b);
            return a - b;
        }

    }
}
