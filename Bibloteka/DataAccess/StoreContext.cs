using Bibloteka.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteka.DataAccess
{
    class StoreContext : DbContext
    {
        public StoreContext() : base("BiblotekaDbContext")
        {

        }

        public DbSet<Worker> getWorkers { get; set; }
        public DbSet<Book> getBooks { get; set; }
        public DbSet<Reader> getReaders { get; set; }
    }
}
