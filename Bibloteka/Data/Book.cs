using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteka.Data
{
    [Table("Ksiazka")]
    public class Book
    {
        int bookId;
        string name= "";
        string author = "";
        long isbn = 0;
        string type = "";
        int date = 0;

        [Key]
        public int BookId
        {
            get { return bookId; }
            set { bookId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Author
        {
            get { return author;}
            set { author = value; }
        }

        public long Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public string NameandYear
        {
            get { return name + "(" + date + ")"; }
        }

        public string Type
        {
            get { return type;}
            set { type = value; }
        }

        public int Date
        {
            get { return date; }
            set { date = value; }
        }
    }
}
