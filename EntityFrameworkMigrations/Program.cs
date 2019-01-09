using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkMigrations
{
    class Program
    {
        static void Main(string[] args)
        {
            using (BooksContext db = new BooksContext())
            {
                Book book_1 = new Book { Name = "Ulysses ", Author = "James Joyce", PageQuantity = 190};
                Book book_2 = new Book { Name = " Moby Dick", Author = "Herman Melville", PageQuantity = 260};
                Book book_3 = new Book { Name = " Hamlet", Author = "William Shakespeare", PageQuantity = 320};
                db.BooksBooks.Add(book_1);
                db.BooksBooks.Add(book_2);
                db.BooksBooks.Add(book_3);
                db.SaveChanges();
                var books = db.BooksBooks;
                foreach (Book i in books)
                {
                    Console.WriteLine($"{i.ID}. {i.Name} {i.Author} {i.PageQuantity}");
                }
            }
            Console.ReadLine();
        }
    }
}
