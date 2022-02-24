using System;

namespace InterfaceAss6
{
    interface IPrintable
    {
        void Printer();

    }
    public class Student:IPrintable
    {
        int id;
        string name;

        public void insert(int i,string n)
        {
            id = i;
            name = n;
        }
        public void Printer()
        {
            Console.WriteLine(id + " " + name);
        }

    }

    public class Employee:IPrintable
    {
        public int eid;
        public string ename;
       public  float salary;

        public void insert(int ei,string en,float sl)
        {
           eid = ei;
            ename = en;
            salary = sl;

        }

        public void Printer()
        {
            Console.WriteLine(eid + " " + ename + " " + salary);
        }
    }
    class Program
    {
            static void Main(string[] args)
            {
                Student s1 = new Student();
                s1.insert(101, "Bhushan");
                s1.Printer();
                Employee e1 = new Employee();
                e1.insert(201, "Ankit", 54000f);
                e1.Printer();

            }     }
    
}
