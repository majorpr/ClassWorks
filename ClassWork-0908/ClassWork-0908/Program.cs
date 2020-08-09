using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ClassWork_0908
{
    class Counter
    {
        public int Seconds { get; set; }
        public Counter(int sec = 0)
        {
            Seconds = sec;
        }
        public static implicit operator Counter(int x)
        {
            return new Counter(x);
        }
        public static explicit operator int (Counter cobj)
        {
            return cobj.Seconds; ;
        }
    }
    class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Person (string name = "Anonim")
        {
            Name = name;
        }
        public void Show()
        {
            WriteLine(Name);
        }
    }

    class Student : Person
    {
        public string Group { get; set; }
        public Student (string name = "", string group = "000") : base(name)
        {
            Group = group;
        }
        public new void Show()
        {
            base.Show();
            WriteLine(Group);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person user = new Person("Leonid");
            Student student = new Student("Vladimir");

            user.Show();
            student.Show();
        }
    }
}
