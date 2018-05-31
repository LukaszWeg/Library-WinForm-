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
    public partial class ReaderListForm : Form
    {
        public ReaderListForm()
        {
            InitializeComponent();
            this.readerBindingSource.DataSource = DataContext.getReaders();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.readerBindingSource.ResetBindings(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReaderForm reader = new ReaderForm();
            reader.MdiParent = this.ParentForm;
            reader.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                Reader reader = row.DataBoundItem as Reader ;
                if (reader != null)
                {
                    ReaderForm readerForm = new ReaderForm(reader);
                    readerForm.MdiParent = this.ParentForm;
                    readerForm.Show();
                }
            }
        }
    }
}
