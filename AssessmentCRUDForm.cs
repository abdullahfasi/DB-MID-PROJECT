using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMidProject
{
    public partial class AssessmentCRUDForm : Form
    {
        public AssessmentCRUDForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-LHN00FL;Initial Catalog=ProjectB;Integrated Security=True");
        public int id;

        private void AssessmentCRUDForm_Load(object sender, EventArgs e)
        {
            GetAssessmentRecords();
            txtTitle.Focus();
        }
        private void GetAssessmentRecords()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Assessment", con);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            AssessmentDataGridView.DataSource = dt;
        }

        private void ClearFields()
        {
            id = 0;
            txtTitle.Clear();
            txtTotalMarks.Clear();
            txtTotalWeightage.Clear();
            txtTitle.Focus();
        }

        private void AssessmentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = AssessmentDataGridView.Rows[e.RowIndex];
                id = Convert.ToInt32(row.Cells["Id"].Value);
                txtTitle.Text = row.Cells["Title"].Value.ToString();
                txtTotalMarks.Text = row.Cells["TotalMarks"].Value.ToString();
                txtTotalWeightage.Text = row.Cells["TotalWeightage"].Value.ToString();
            }
        }

        private void buttonAddRubric_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Assessment (Title, DateCreated, TotalMarks, TotalWeightage) VALUES (@Title, GETDATE(), @TotalMarks, @TotalWeightage)", con);
                cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                cmd.Parameters.AddWithValue("@TotalMarks", Convert.ToInt32(txtTotalMarks.Text));
                cmd.Parameters.AddWithValue("@TotalWeightage", Convert.ToInt32(txtTotalWeightage.Text));

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("New Assessment added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetAssessmentRecords();
                ClearFields();
            }
        }

        private void buttonUpdateRubric_Click(object sender, EventArgs e)
        {
            if (id > 0 && isValid())
            {
                SqlCommand cmd = new SqlCommand("UPDATE Assessment SET Title = @Title, TotalMarks = @TotalMarks, TotalWeightage = @TotalWeightage WHERE Id = @Id", con);
                cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                cmd.Parameters.AddWithValue("@TotalMarks", Convert.ToInt32(txtTotalMarks.Text));
                cmd.Parameters.AddWithValue("@TotalWeightage", Convert.ToInt32(txtTotalWeightage.Text));
                cmd.Parameters.AddWithValue("@Id", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Assessment updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetAssessmentRecords();
                ClearFields();
            }
            else if(id == 0)
            {
                MessageBox.Show("Please select an assessment to update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDeleteRubric_Click(object sender, EventArgs e)
        {
            if (id > 0 && isValid())
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Assessment WHERE Id = @Id", con);
                cmd.Parameters.AddWithValue("@Id", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Assessment deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetAssessmentRecords();
                ClearFields();
            }
            else if(id == 0)
            {
                MessageBox.Show("Please select an assessment to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private bool isValid()
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Please enter a title for the assessment!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //ClearFields();
                return false;
            }
            else if (!txtTitle.Text.All(char.IsLetter))
            {
                MessageBox.Show("Title must contain only alphabets!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //ClearFields();
                return false;
            }

            if (!int.TryParse(txtTotalMarks.Text, out int totalMarks) || totalMarks < 0)
            {
                MessageBox.Show("Please enter a valid non-negative integer value for total marks!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return false;
            }

            if (!int.TryParse(txtTotalWeightage.Text, out int totalWeightage) || totalWeightage < 0)
            {
                MessageBox.Show("Please enter a valid non-negative integer value for total weightage!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form moreForm = new MainForm();
            moreForm.Show();
        }
    }
}
