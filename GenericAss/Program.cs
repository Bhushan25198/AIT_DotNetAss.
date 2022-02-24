using System;
using System.Collections.Generic;

namespace GenericAss7
{
    public class Book
    {
        public int Book_id;
        public string Book_name;
        public string Book_authorname;
        public int Book_price;

        public Book(int id,string name,string authorname,int price)
        {
            Book_id = id;
            Book_name = name;
            Book_authorname = authorname;
            Book_price = price;
        }

        public override string ToString()
        {
            return Book_id + " , " + Book_name + " , " + Book_authorname + " , " + Book_price;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> blist = new List<Book>();
            blist.Add(new Book(101, "Battle Ready For 21st Century", "Anant vijay", 500));
            blist.Add(new Book(102, "The Bench", "Meghan Markle", 600));
            blist.Add(new Book(103, "Home in The World", "Amartya Sen", 800));
            

            foreach(Book b in blist)
            {
                Console.WriteLine(b);
            }
           
        }
    }
}
