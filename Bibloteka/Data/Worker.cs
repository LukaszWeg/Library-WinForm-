using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteka.Data
{
    public class Worker
    {
        string firstname = "";
        string lastname = "";
        long telNumber = 0;
        DateTime hired = DateTime.Now;

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
