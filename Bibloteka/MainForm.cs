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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void książkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookForm book = new BookForm();
            book.MdiParent = this;
            book.Show();
        }

        private void czytelnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReaderForm reader = new ReaderForm();
            reader.MdiParent = this;
            reader.Show();
        }

        private void pracownikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkerForm worker = new WorkerForm();
            worker.MdiParent = this;
            worker.Show();
        }

        private void uszeregujWPionieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void uszeregujWPoziomieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void uszegerujKaskadowoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void listaPracownikówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkerListForm worker = new WorkerListForm();
            worker.MdiParent = this;
            worker.Show();
        }
    }
}
