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
    public partial class WorkerListForm : Form
    {
        public WorkerListForm()
        {
            InitializeComponent();
            this.workerBindingSource.DataSource = DataContext.getWorkers();
        }

        private void WorkerListForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            WorkerForm worker = new WorkerForm();
            worker.MdiParent = this.ParentForm;
            worker.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.workerBindingSource.ResetBindings(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                Worker worker = row.DataBoundItem as Worker;
                if (worker != null)
                {
                    WorkerForm workerForm = new WorkerForm(worker);
                    workerForm.MdiParent = this.ParentForm;
                    workerForm.Show();
                }
            }
        }
    }
    }

