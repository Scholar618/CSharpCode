using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            //stu["Math"] = null ;
            stu["Math"] = 90;
            var mathScore = stu["Math"];
            Console.WriteLine(mathScore);
            Console.ReadLine();
        }

        class Student
        {
            private Dictionary<string, int> score = new Dictionary<string, int>();

            // int? 表示int值可为null，如果没有？，则int值只能为0
            public int? this[string subject]
            {
                get 
                {
                    if (score.ContainsKey(subject))
                    {
                        return this.score[subject];
                    }
                    else
                    {
                        return null;
                    }
                    
                }
                set 
                { 
                    if(value.HasValue == false)
                    {
                        throw new Exception("Score cannot be null");
                    }

                    if(score.ContainsKey(subject))
                    {
                        this.score[subject] = value.Value;
                    }
                    else
                    {
                        this.score.Add(subject, value.Value);
                    }
                }
            }
        }
    }
}
