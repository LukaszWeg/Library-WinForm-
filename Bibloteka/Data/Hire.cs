using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteka.Data
{
    [Table("Wypozyczenia")]
    public class Hire
    {
        int hireId;
        DateTime hireDate = DateTime.Now;
        DateTime readDate = DateTime.Now.AddMonths(3);

        [Key]
        public int HireId
        {
            get { return hireId; }
            set { hireId = value; }
        }

        public DateTime HireDate
        {
            get { return hireDate; }
            set { hireDate = value; }
        }

        public DateTime ReadDate
        {
            get { return readDate; }
            set { readDate = value; }
        }

        public virtual Book book { get; set; }
        public virtual Reader reader { get; set; }
        public virtual Worker worker { get; set; }

        [NotMapped]
        public string BookNameAndYear
        {
            get
            {
                if (book != null)
                {
                    return book.Name + "(" + book.Date + ")";
                }
                else
                {
                    return "";
                }
            }
        }

        [NotMapped]
        public string ReaderName
        {
            get
            {
                if (reader != null)
                {
                    return reader.Firstname + " " + reader.Lastname;
                }
                else
                {
                    return "";
                }
            }
        }

        [NotMapped]
        public string WorkerName
        {
            get
            {
                if (worker != null)
                {
                    return worker.Firstname + " " + reader.Lastname;
                }
                else
                {
                    return "";
                }
            }
        }
    }
}
