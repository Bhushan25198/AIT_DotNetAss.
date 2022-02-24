using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConectArchi
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

                SqlDataReader reader;

                con.Open();
                cmd.CommandText = "SelectBookinformation";
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;

                reader = cmd.ExecuteReader();
                Console.WriteLine("Bookinformation Details..........");
                while (reader.Read())
                {
                    Console.WriteLine(reader[0] + "\t" + reader[1] + "\t" + reader[2] + "\t" + reader[3]);

                }
                con.Close();
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
