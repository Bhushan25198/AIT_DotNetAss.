using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstMvc.Models
{
    public class BookContext : DbContext
    {
        public BookContext() : base("server=DESKTOP-I6PLSFV\\SQLEXPRESS;database=Book;trusted_connection=true")
        {

        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasKey(s => new { s.Bookid });
        }
    }
}