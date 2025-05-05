using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person();
            p1.name = "scholar";
            p2.name = "sjc";
            
            List<Person> notion = Person.GetMarry(p1, p2);
            List<Person> notion2 = p1 + p2;
            foreach (var p in notion)
            {
                Console.WriteLine(p.name);
            }
            foreach (var p in notion2)
            {
                Console.WriteLine(p.name);
            }
            Console.ReadLine();
        }
    }

    class Person
    {
        public string name;
        public static int count = 0;
        public static List<Person> GetMarry(Person p1, Person p2) 
        {
            List<Person> people = new List<Person>();
            people.Add(p1);
            people.Add(p2);
            count += 2;
            for (int i = 0; i < 3; i++)
            {
                Person child = new Person();
                child.name = i + p1.name + " And " + p2.name;
                people.Add(child);
                count++;
            }
            return people;
        }

        public static List<Person> operator +(Person p1, Person p2)
        {
            List<Person> people = new List<Person>();
            people.Add(p1);
            people.Add(p2);
            for (int i = 0; i < 3; i++)
            {
                Person child = new Person();
                child.name = i + p1.name + " And " + p2.name;
                people.Add(child);
            }
            return people;
        }
    }
}
