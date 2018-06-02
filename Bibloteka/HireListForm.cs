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
    public partial class HireListForm : Form
    {
        public HireListForm()
        {
            InitializeComponent();
            this.hireBindingSource.DataSource = DataContext.getHires();
        }

        private void HireListForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HireForm hire = new HireForm();
            hire.MdiParent = this.ParentForm;
            hire.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.hireBindingSource.DataSource = DataContext.getHires();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                Hire hire = row.DataBoundItem as Hire;
                if (hire != null)
                {
                    HireForm hireForm = new HireForm(hire);
                    hireForm.MdiParent = this.ParentForm;
                    hireForm.Show();
                }
            }
        }
    }
}
