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
        static List<Book> bookList = new List<Book>();
        static List<Reader> readerList = new List<Reader>();
        static List<Worker> workerList = new List<Worker>();

        public static List<Book> getBooks()
        {
            return bookList;
        }

        public static List<Reader> getReaders()
        {
            return readerList;
        }

        public static List<Worker> getWorkers()
        {
            return workerList;
        }

        public static bool AddorEditWorker(Worker worker)
        {
            if (worker.WorkerId == 0)
            {
                worker.WorkerId = workerList.Count > 0 ? workerList.Max(x => x.WorkerId) + 1 : 1;
                workerList.Add(worker);
            }
            else
            {
                Worker worker2 = workerList.FirstOrDefault(x => x.WorkerId == worker.WorkerId);
                if (worker2 != null)
                {
                    worker2.Firstname = worker.Firstname;
                    worker2.Lastname = worker.Lastname;
                    worker2.TelNumber = worker.TelNumber;
                    worker2.Hired = worker.Hired;
                }
            }
            return true;
        }

        public static bool AddorEditBook(Book book)
        {
            if (book.BookId == 0)
            {
                book.BookId = bookList.Count > 0 ? bookList.Max(x => x.BookId) + 1 : 1;
                bookList.Add(book);
            }
            else
            {
                Book book2 = bookList.FirstOrDefault(x => x.BookId == book.BookId);
                if (book2 != null)
                {
                    book2.Author = book.Author;
                    book2.Date = book.Date;
                    book2.Name = book.Name;
                    book2.Type = book.Type;
                    book2.Isbn = book.Isbn;
                }
            }
            return true;
        }

        public static bool AddorEditReader(Reader reader)
        {
            if (reader.ReaderId == 0)
            {
                reader.ReaderId = readerList.Count > 0 ? readerList.Max(x => x.ReaderId) + 1 : 1;
                readerList.Add(reader);
            }
            else
            {
                Reader reader2 = readerList.FirstOrDefault(x => x.ReaderId == reader.ReaderId);
                if (reader2 != null)
                {
                    reader2.Lastname = reader.Lastname;
                    reader2.TelNumber = reader.TelNumber;
                    reader2.Firstname = reader.Firstname;
                    reader2.Email = reader.Email;
                }
            }
            return true;
        }

    }

}