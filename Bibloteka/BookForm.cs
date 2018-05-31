using Bibloteka.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibloteka
{
    public partial class BookForm : Form
    {
        private Book book = new Book();

        public BookForm()
        {
            InitializeComponent();
            this.bookBindingSource.DataSource = book;
        }

        public BookForm(Book book)
        {
            InitializeComponent();
            this.book = book;
            this.bookBindingSource.DataSource = this.book;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BookForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataAccess.DataContext.AddorEditBook(book) == true)
                { this.Close(); }
            }
            catch (Exception x)
            { MessageBox.Show("Podczas zapisu wystąpił błąd: " + x.Message); }
        }
    }
}
