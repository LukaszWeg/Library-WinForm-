using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteka.Data
{
    [Table("Czytelnicy")]
    public class Reader
    {
        int readerId;
        string firstname="";
        string lastname="";
        long telNumber=0;
        string email="";

        [Key]
        public int ReaderId
        {
            get { return readerId; }
            set { readerId = value; }
        }

        public string Fullname
        {
            get { return firstname + " " + lastname; }
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

        public long TelNumber
        {
            get { return telNumber; }
            set { telNumber = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
