using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMidProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form moreForm = new StudentCRUDForm();
            moreForm.Show();
        }

        private void assbtn_Click(object sender, EventArgs e)
        {
            Form moreForm = new AssessmentCRUDForm();
            moreForm.Show();
        }

        private void clobtn_Click(object sender, EventArgs e)
        {
            Form moreForm = new CLOForm();
            moreForm.Show();
        }

        private void rubbtn_Click(object sender, EventArgs e)
        {
            Form moreForm = new RubricCRUDForm();
            moreForm.Show();
        }

        private void lvlbtn_Click(object sender, EventArgs e)
        {
            Form moreForm = new RubricLevelCRUD();
            moreForm.Show();
        }
    }
}
