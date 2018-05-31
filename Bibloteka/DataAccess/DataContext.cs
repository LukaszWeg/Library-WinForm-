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
            if(worker.WorkerId == 0 )
            {
                worker.WorkerId = workerList.Count > 0 ? workerList.Max(x => x.WorkerId) + 1 : 1;
                workerList.Add(worker);
            }
            else
            {
                Worker worker2 = workerList.FirstOrDefault(x => x.WorkerId == worker.WorkerId);
                if(worker2 != null)
                {
                    worker2.Firstname = worker.Firstname;
                    worker2.Lastname = worker.Lastname;
                    worker2.TelNumber = worker.TelNumber;
                    worker2.Hired = worker.Hired;
                }
            }
            return true;
        }
    }
}
