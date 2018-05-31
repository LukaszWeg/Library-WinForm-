using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteka.Data
{
    public class Book
    {
        string name= "";
        string author = "";
        long isbn = 0;
        string type = "";
        int date = 0;

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
