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
    public partial class HireForm : Form
    {
        private Hire hire = new Hire();
        public HireForm()
        {
            InitializeComponent();
            this.hireBindingSource.DataSource = hire;
        }

        public HireForm(Hire hire)
        {
            
            InitializeComponent();
            this.hire = hire;
            this.bookBindingSource.DataSource = this.hire;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int bookId = (int)this.comboBox1.SelectedValue;
                hire.book = DataContext.getBooks().Find(o => o.BookId == bookId);
                if (hire.book == null)
                {
                    MessageBox.Show("Wybierz książke");
                    return;
                }
                int workerId = (int)this.comboBox2.SelectedValue;
                hire.worker = DataContext.getWorkers().Find(o => o.WorkerId == workerId);
                if (hire.worker == null)
                { MessageBox.Show("Wybierz pracownika który obsługuje!"); return; }
                int readerId = (int)this.comboBox3.SelectedValue;
                hire.reader = DataContext.getReaders().Find(o => o.ReaderId == readerId);
                if (hire.reader == null)
                { MessageBox.Show("Wybierz czytelnika któremu wypożyczasz!"); return; }

                if (DataContext.AddorEditHire(hire) == true)
                { this.Close(); }
            }
            catch (Exception x) { MessageBox.Show("Podczas zapisu wystąpił błąd: " + x.Message); }
        }

        private void HireForm_Load(object sender, EventArgs e)
        {
            this.hireBindingSource.DataSource = hire;
            this.bookBindingSource.DataSource = DataContext.getBooks();
            this.readerBindingSource.DataSource = DataContext.getReaders();
            this.workerBindingSource.DataSource = DataContext.getWorkers();

            if (hire != null)
            {
                if (hire.book != null)
                {
                    this.comboBox1.SelectedValue = hire.book.BookId;

                }
                if (hire.worker != null)
                {
                    this.comboBox2.SelectedValue = hire.worker.WorkerId;
                }
                if (hire.reader != null)
                {
                    this.comboBox3.SelectedValue = hire.reader.ReaderId;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
