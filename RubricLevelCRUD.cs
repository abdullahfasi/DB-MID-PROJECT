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
    public partial class RubricLevelCRUD : Form
    {
        public RubricLevelCRUD()
        {
            InitializeComponent();
            FillRubricComboBox();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-LHN00FL;Initial Catalog=ProjectB;Integrated Security=True");
        public int id;

        private void FillRubricComboBox()
        {
            string query = "SELECT Id, Details FROM Rubric";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbRubric.DataSource = dt;
            cmbRubric.DisplayMember = "Details";
            cmbRubric.ValueMember = "Id";
        }

        private void GetRubricLevelRecords()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM RubricLevel", con);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            RubricLevelDataGridView.DataSource = dt;
        }

        private void ClearFields()
        {
            id = 0;
            txtDetails.Clear();
            txtMeasurementLevel.Clear();
            cmbRubric.SelectedIndex = -1;
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                // Check if Rubric ID already exists
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM RubricLevel WHERE RubricId = @RubricId", con);
                checkCmd.Parameters.AddWithValue("@RubricId", Convert.ToInt32(cmbRubric.SelectedValue));

                con.Open();
                int existingRubricCount = (int)checkCmd.ExecuteScalar();
                con.Close();

                if (existingRubricCount > 0)
                {
                    MessageBox.Show("Rubric with the same ID already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit the method without adding the Rubric Level
                }

                // Rubric ID does not exist, proceed with insertion
                SqlCommand cmd = new SqlCommand("INSERT INTO RubricLevel (Details, MeasurementLevel, RubricId) VALUES (@Details, @MeasurementLevel, @RubricId)", con);
                cmd.Parameters.AddWithValue("@Details", txtDetails.Text);
                cmd.Parameters.AddWithValue("@MeasurementLevel", Convert.ToInt32(txtMeasurementLevel.Text));
                cmd.Parameters.AddWithValue("@RubricId", Convert.ToInt32(cmbRubric.SelectedValue));

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("New Rubric Level added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetRubricLevelRecords();
                ClearFields();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (id > 0 && isValid())
            {
                SqlCommand cmd = new SqlCommand("UPDATE RubricLevel SET Details = @Details, MeasurementLevel = @MeasurementLevel, RubricId = @RubricId WHERE Id = @Id", con);
                cmd.Parameters.AddWithValue("@Details", txtDetails.Text);
                cmd.Parameters.AddWithValue("@MeasurementLevel", Convert.ToInt32(txtMeasurementLevel.Text));
                cmd.Parameters.AddWithValue("@RubricId", Convert.ToInt32(cmbRubric.SelectedValue));
                cmd.Parameters.AddWithValue("@Id", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Rubric Level updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetRubricLevelRecords();
                ClearFields();
            }
            else if(id == 0)
            {
                MessageBox.Show("Please select a Rubric Level to update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (id > 0 && isValid())
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM RubricLevel WHERE Id = @Id", con);
                cmd.Parameters.AddWithValue("@Id", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Rubric Level deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetRubricLevelRecords();
                ClearFields();
            }
            else if(id == 0)
            {
                MessageBox.Show("Please select a Rubric Level to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void RubricLevelDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = RubricLevelDataGridView.Rows[e.RowIndex];
                id = Convert.ToInt32(row.Cells["Id"].Value);
                txtDetails.Text = row.Cells["Details"].Value.ToString();
                txtMeasurementLevel.Text = row.Cells["MeasurementLevel"].Value.ToString();
                cmbRubric.SelectedValue = Convert.ToInt32(row.Cells["RubricId"].Value);
            }
        }

        private bool isValid()
        {
            if (string.IsNullOrWhiteSpace(txtDetails.Text))
            {
                MessageBox.Show("Please enter details for the Rubric Level!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(txtMeasurementLevel.Text, out _))
            {
                MessageBox.Show("Please enter a valid integer value for the measurement level!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cmbRubric.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Rubric!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void RubricLevelCRUD_Load(object sender, EventArgs e)
        {
            GetRubricLevelRecords();
        }
    }
}
