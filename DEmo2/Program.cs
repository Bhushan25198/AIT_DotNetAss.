using System;
using System.Collections.Generic;

namespace DEmo2
{
    class Student
    {
        int stuno;
        string sname, Batch;

        public Student(int sno,string snm,string batch)
        {
            stuno = sno;
            sname = snm;
            Batch = batch;
        }

        public override string ToString()
        {
            return stuno + "," + sname + "," + Batch;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> slist = new List<Student>();
            slist.Add(new Student(1, "bhushan", "a"));
            slist.Add(new Student(2, "rupesh", "b"));
            slist.Add(new Student(3, "mohit", "c"));
            slist.Add(new Student(4, "varun", "d"));
            slist.Add(new Student(5, "ankit", "e"));

            foreach(Student s in slist)
            {
                Console.WriteLine(s);
            }

        }
    }
}
