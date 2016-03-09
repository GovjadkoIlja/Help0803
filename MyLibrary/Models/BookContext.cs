using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MyLibrary.Models;

namespace MyLibrary.Models
{
    public class BookContext : DbContext
    {
        public BookContext()
            : base("DefaultConnection")
        { }


        public DbSet<Book> Books { get; set; }

        public static BookContext Create()
        {
            return new BookContext();
        }
    }
}