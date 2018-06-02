using Bibloteka.Data;
using Bibloteka.DataAccess;
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
    public partial class BookListForm : Form
    {
        public BookListForm()
        {
            InitializeComponent();
            this.bookBindingSource.DataSource = DataContext.getBooks();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BookForm book = new BookForm();
            book.MdiParent = this.ParentForm;
            book.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.bookBindingSource.DataSource = DataContext.getBooks();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                Book book = row.DataBoundItem as Book;
                if (book != null)
                {
                    BookForm bookForm = new BookForm(book);
                    bookForm.MdiParent = this.ParentForm;
                    bookForm.Show();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BookListForm_Load(object sender, EventArgs e)
        {

        }
    }
}
