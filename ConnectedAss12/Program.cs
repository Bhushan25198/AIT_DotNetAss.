using System;
using System.Data;
using System.Data.SqlClient;

namespace ConnectedAss12
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=DESKTOP-I6PLSFV\\SQLEXPRESS;database=HRMSDB;trusted_connection=true";

                SqlCommand cmd = new SqlCommand();
                char continueornot = 'y';
                SqlDataReader reader;
                int no;
                do
                {
                    Console.WriteLine("Enter Your Choice Following: ");

                    Console.WriteLine("1.Select Book Details");
                    Console.WriteLine("2.Insert Book Details");
                    Console.WriteLine("3.Update Book Details");
                    Console.WriteLine("4.Delete Book Details");

                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            con.Open();
                            cmd.CommandText = "SelectBookinformation";
                            cmd.Connection = con;
                            cmd.CommandType = CommandType.StoredProcedure;

                            reader = cmd.ExecuteReader();
                            Console.WriteLine("Bookinformation Details..........");
                            while (reader.Read())
                            {
                                Console.WriteLine(reader[0] + "\t" + reader[1] + "\t" + reader[2] + "\t" + reader[3] );

                            }
                            Console.WriteLine("------------------------------------------------------------------------------");
                            con.Close();
                              break;



                        case 2:
                            con.Open();
                            cmd.CommandText = "InsertBookinformation";
                            cmd.Connection = con;
                            cmd.CommandType = CommandType.StoredProcedure;

                            Console.WriteLine("Enter Book Id: ");
                            int book_id = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter Book Name : ");
                            String book_name = Console.ReadLine();

                            Console.WriteLine("Enter Author Name : ");
                            String author_name = Console.ReadLine();

                            Console.WriteLine("Enter Book Price : ");
                            int price = Convert.ToInt32(Console.ReadLine());

                            cmd.Parameters.AddWithValue("Book_Id", book_id);
                            cmd.Parameters.AddWithValue("Book_Name", book_name);
                            cmd.Parameters.AddWithValue("Author_Name", author_name);
                            cmd.Parameters.AddWithValue("Book_Price", price);

                           
                            Console.WriteLine("Book Information Details Inserted Successfull !!!");
                            Console.WriteLine("-------------------------------------------------");
                            con.Close();
                            break;

                        case 3:
                            con.Open();
                            cmd.CommandText = "UpdateBookinformation";
                            cmd.Connection = con;
                            cmd.CommandType = CommandType.StoredProcedure;

                            Console.WriteLine("Enter Book Id: ");
                            int book_id1 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter Book Name : ");
                            String book_name1 = Console.ReadLine();

                            Console.WriteLine("Enter Author Name : ");
                            string author_name1 = Console.ReadLine();

                            Console.WriteLine("Enter Book Price : ");
                            int price1 = Convert.ToInt32(Console.ReadLine());

                            cmd.Parameters.AddWithValue("Book_Id", book_id1);
                            cmd.Parameters.AddWithValue("Book_Name", book_name1);
                            cmd.Parameters.AddWithValue("Author_Name", author_name1);
                            cmd.Parameters.AddWithValue("Book_Price", price1);

                           
                            Console.WriteLine("Bookinformation Details Are Updated Successfull !!!");
                            Console.WriteLine("----------------------------------------------------------");
                            con.Close();
                            break;

                        case 4:
                            con.Open();
                            cmd.CommandText = "DeleteBookinformation";
                            cmd.Connection = con;
                            cmd.CommandType = CommandType.StoredProcedure;


                            Console.WriteLine("Enter Book_id :");
                            int book_id2 = Convert.ToInt32(Console.ReadLine());

                            cmd.Parameters.AddWithValue("Book_Id", book_id2);
                            

                            Console.WriteLine("Bookinformation Details Deleted Successfull !!!");
                            Console.WriteLine("---------------------------------------------------");
                            con.Close();
                            break;

                        default:
                            Console.WriteLine("Invalid Choise");
                            break;

                    }

                    Console.WriteLine("Do You Want To Continue Again y/n");
                    continueornot = Convert.ToChar(Console.ReadLine());
                }
                while (continueornot == 'y');



            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
