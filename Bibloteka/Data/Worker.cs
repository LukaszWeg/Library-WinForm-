using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteka.Data
{
    [Table("Pracownicy")]
    public class Worker
    {
        
        int workerId;
        string firstname = "";
        string lastname = "";
        long telNumber = 0;
        DateTime hired = DateTime.Now;

        [Key]
        public int WorkerId
        {
            get { return workerId; }
            set { workerId = value; }
        }

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public string Fullname
        {
            get { return firstname + " " + lastname; }
        }

        public long TelNumber
        {
            get { return telNumber; }
            set { telNumber = value; }
        }

        public DateTime Hired
        {
            get { return hired; }
            set { hired = value; }
        }
    }
}
