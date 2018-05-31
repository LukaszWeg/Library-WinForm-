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
    public partial class WorkerForm : Form
    {
        private Worker worker = new Worker();
        public WorkerForm()
        {
            InitializeComponent();
            this.workerBindingSource.DataSource = worker;
        }

        public WorkerForm(Worker worker)
        {
            InitializeComponent();
            this.worker = worker;
            this.workerBindingSource.DataSource = this.worker;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataAccess.DataContext.AddorEditWorker(worker) == true)
                { this.Close(); }
            }
            catch (Exception x)
            { MessageBox.Show("Podczas zapisu wystąpił błąd: " + x.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
