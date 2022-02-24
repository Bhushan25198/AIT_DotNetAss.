using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DisconnectedAss11
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Char cont;
                int choice;
                do
                {


                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Server =DESKTOP-I6PLSFV\\SQLEXPRESS;database=HRMSDB;trusted_connection=true";
                    con.Open();

                    SqlCommand cmd = new SqlCommand("[SelectBookinformation", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    DataSet ds = new DataSet();

                    adapter.Fill(ds, "BookDetails");

                    DataTable tab = ds.Tables["BookDetails"];

                    Console.WriteLine("1.Select  ALL BookDetails");
                    Console.WriteLine("2.Select BookDetails Using Book_id");
                    Console.WriteLine("3.Insert BookDetails");
                    Console.WriteLine("4.Update BookDetails");
                    Console.WriteLine("5.Delete BookDetails");

                    Console.WriteLine("Enter Your choice");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("BookDetails Information");
                            foreach (DataRow row in tab.Rows)
                            {
                                Console.WriteLine(row[0] + "\t" + row[1] + "\t" + row[2] + "\t" + row[3]);
                            }
                            Console.WriteLine(ds.GetXml());
                            break;
                        case 2:
                            Console.WriteLine("Enter BookDetails to be selected");
                            int bookid = Convert.ToInt32(Console.ReadLine());

                            DataRow[] selrow = tab.Select("Book_id=" + bookid);

                            foreach (DataRow row in selrow)
                            {
                                Console.WriteLine(row[0] + "\t" + row[1] + "\t" + row[2] + "\t" + row[3]);


                            }
                            break;

                        case 3:
                            con.Open();
                            cmd.CommandText = "InsertBookinformation";
                            cmd.Connection = con;
                            cmd.CommandType = CommandType.StoredProcedure;

                            Console.WriteLine("Enter Book Id");
                            int bookid1 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter Book Name");
                            string bookname1 = Console.ReadLine();

                            Console.WriteLine("Enter Author Name");
                            int authorname1 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter Price");
                            int price1 = Convert.ToInt32(Console.ReadLine());

                            DataRow newrow = tab.NewRow();

                            newrow["Book_id"] = bookid1;
                            newrow["Book_name"] = bookname1;
                            newrow["Author_name"] = authorname1;
                            newrow["Price"] = price1;

                            tab.Rows.Add(newrow);
                            adapter.Update(ds.Tables[0]);
                            Console.WriteLine("Data Inserted");
                            con.Close();
                            break;

                        case 4:
                            con.Open();
                            cmd.CommandText = "UpdateBookinformation";
                            cmd.Connection = con;
                            cmd.CommandType = CommandType.StoredProcedure;
                            Console.WriteLine("Enter Book Id");
                            int bookid2 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter Book Name");
                            string bookname2 = Console.ReadLine();

                            Console.WriteLine("Enter Author Name");
                            int authorname2 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter Price");
                            int price2 = Convert.ToInt32(Console.ReadLine());

                            DataRow newrow2 = tab.NewRow();

                            newrow2["Book_id"] = bookid2;
                            newrow2["Book_name"] = bookname2;
                            newrow2["Author_name"] = authorname2;
                            newrow2["Price"] = price2;

                            tab.Rows.Add(newrow2);


                            adapter.Update(ds.Tables[0]);

                            break;

                        case 5:
                            Console.WriteLine("Enter BookDetails Number to be deleted"); ;
                            int bookid3 = Convert.ToInt32(Console.ReadLine());


                            DataRow[] delr = tab.Select("Book_id=" + bookid3);

                            DataRow delrow = delr[0];


                            delrow.Delete();

                            adapter.Update(ds, "BookDetails");

                            Console.WriteLine("BookDetails Deleted");

                            break;


                        default:
                            Console.WriteLine("Invalid case");
                            break;
                    }
                    Console.WriteLine("Enter Y to continue");
                    cont = Convert.ToChar(Console.ReadLine());
                }
                while (cont == 'Y');
                Console.ReadLine();


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
