using Bibloteka.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteka.DataAccess
{
    class DataContext
    {
        static StoreContext context = new StoreContext();

        public static StoreContext Context { get { return context; } }

        public static List<Book> getBooks()
        {
            return context.getBooks.ToList();
        }

        public static List<Reader> getReaders()
        {
            return context.getReaders.ToList();
        }

        public static List<Worker> getWorkers()
        {
            return context.getWorkers.ToList();
        }

        public static bool AddorEditWorker(Worker worker)
        {
            if (worker.WorkerId == 0)
            {
                worker.WorkerId = context.getWorkers.Count() > 0 ? context.getWorkers.Max(x => x.WorkerId) + 1 : 1;
                context.getWorkers.Add(worker);
            }
            else
            {
                Worker worker2 = context.getWorkers.FirstOrDefault(x => x.WorkerId == worker.WorkerId);
                if (worker2 != null)
                {
                    worker2.Firstname = worker.Firstname;
                    worker2.Lastname = worker.Lastname;
                    worker2.TelNumber = worker.TelNumber;
                    worker2.Hired = worker.Hired;
                }
            }
            context.SaveChanges();
            return true;
        }

        public static bool AddorEditBook(Book book)
        {
            if (book.BookId == 0)
            {
                book.BookId = context.getBooks.Count() > 0 ? context.getBooks.Max(x => x.BookId) + 1 : 1;
                context.getBooks.Add(book);
            }
            else
            {
                Book book2 = context.getBooks.FirstOrDefault(x => x.BookId == book.BookId);
                if (book2 != null)
                {
                    book2.Author = book.Author;
                    book2.Date = book.Date;
                    book2.Name = book.Name;
                    book2.Type = book.Type;
                    book2.Isbn = book.Isbn;
                }
            }
            context.SaveChanges();
            return true;
        }

        public static bool AddorEditReader(Reader reader)
        {
            if (reader.ReaderId == 0)
            {
                reader.ReaderId = context.getReaders.Count() > 0 ? context.getReaders.Max(x => x.ReaderId) + 1 : 1;
                context.getReaders.Add(reader);
            }
            else
            {
                Reader reader2 = context.getReaders.FirstOrDefault(x => x.ReaderId == reader.ReaderId);
                if (reader2 != null)
                {
                    reader2.Lastname = reader.Lastname;
                    reader2.TelNumber = reader.TelNumber;
                    reader2.Firstname = reader.Firstname;
                    reader2.Email = reader.Email;
                }
            }
            context.SaveChanges();
            return true;
        }

    }

}