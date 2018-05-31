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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
