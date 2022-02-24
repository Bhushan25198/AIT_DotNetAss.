using System;

namespace BookConstructor3
{

    class Book
    {
        int book_id;
        string book_name;
        string author_name;
        int price, discount;

        public Book(int id,string name,string author_name,int price)
        {
            this.book_id = id;
            this.book_name = name;
            this.author_name = author_name;
            this.price = price;

        }

        public void CalculateDiscount()
        {
            price = price - (price * 10 / 100);
        }
        public override string ToString()
        {
            return "Book_id = " + book_id + "Book_Name = " + book_name + "Author_Name = " + author_name + "Price = "+ price;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book(101, "The Future Is Now","Shashi Tharoor",700);
            Book b2 = new Book(201,"The Shadow of The Crescent Moon","Fatima Bhutto",500);

            b1.CalculateDiscount();
            Console.WriteLine(b1);
            b2.CalculateDiscount();
            Console.WriteLine(b2);

        }
    }
}
