using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkMigrations
{
    public class BooksContext : DbContext
    {
        public BooksContext() : base("DBConnection")
        {
        }
        public DbSet<Book> BooksBooks { get; set; }
    }
}
