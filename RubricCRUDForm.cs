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
    public partial class RubricCRUDForm : Form
    {
        public RubricCRUDForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-LHN00FL;Initial Catalog=ProjectB;Integrated Security=True");
        

        private void RubricCRUDForm_Load(object sender, EventArgs e)
        {
            GetRubricRecords();
        }

        private void GetRubricRecords()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Rubric", con);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            RubricDataGridView.DataSource = dt;
        }

        private void buttonAddRubric_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Rubric WHERE Id = @Id", con);
                checkCmd.Parameters.AddWithValue("@Id", txtRubricID.Text);

                con.Open();
                int existingRubricCount = (int)checkCmd.ExecuteScalar();
                con.Close();

                if (existingRubricCount > 0)
                {
                    MessageBox.Show("Rubric with the same ID already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO Rubric (Id, Details, CloId) VALUES (@Id, @Details, @CloId)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", txtRubricID.Text);
                cmd.Parameters.AddWithValue("@Details", txtRubricDetails.Text);
                cmd.Parameters.AddWithValue("@CloId", Convert.ToInt32(cmbCLO.SelectedValue));

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("New Rubric successfully added to the database", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetRubricRecords();
                ResetFields();
            }
        }


        private bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(txtRubricDetails.Text))
            {
                MessageBox.Show("Please provide Rubric details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtRubricID.Text))
            {
                MessageBox.Show("Please provide Rubric ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbCLO.Text))
            {
                MessageBox.Show("No CLO is entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Additional validation for txtRubricID to ensure it contains only digits
            if (!int.TryParse(txtRubricID.Text, out _))
            {
                MessageBox.Show("Rubric ID must be a valid integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


        private void ResetFields()
        {
            txtRubricID.Clear();
            txtRubricDetails.Clear();
            cmbCLO.SelectedIndex = -1;
            txtRubricID.Focus();
        }

        private void buttonUpdateRubric_Click(object sender, EventArgs e)
        {
            if (txtRubricID.Text != String.Empty && IsValid())
            {
                SqlCommand cmd = new SqlCommand("UPDATE Rubric SET Id = @Id, Details = @Details, CloId = @CloId WHERE Id = @Id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", txtRubricID.Text);
                cmd.Parameters.AddWithValue("@Details", txtRubricDetails.Text);
                cmd.Parameters.AddWithValue("@CloId", Convert.ToInt32(cmbCLO.SelectedValue));

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Rubric details updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetRubricRecords();
                ResetFields();
            }
            else if(txtRubricID.Text == String.Empty)
            {
                MessageBox.Show("Please select a Rubric to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDeleteRubric_Click(object sender, EventArgs e)
        {
            if (txtRubricID.Text != String.Empty && IsValid())
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Rubric WHERE Id = @Id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", txtRubricID.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Rubric deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetRubricRecords();
                ResetFields();
            }
            else if(txtRubricID.Text == String.Empty)
            {
                MessageBox.Show("Please select a Rubric to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetFields();
        }

        private void RubricCRUDForm_Load_1(object sender, EventArgs e)
        {
            GetRubricRecords();
            PopulateCLODropdown();
        }

        private void RubricDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (RubricDataGridView.SelectedRows.Count > 0)
            {
                object idValue = RubricDataGridView.SelectedRows[0].Cells["Id"].Value;
                object cloIdValue = RubricDataGridView.SelectedRows[0].Cells["CloId"].Value;

                if (idValue != null && cloIdValue != null)
                {
                    txtRubricID.Text = idValue.ToString();
                    txtRubricDetails.Text = RubricDataGridView.SelectedRows[0].Cells["Details"].Value.ToString();
                    cmbCLO.SelectedValue = Convert.ToInt32(cloIdValue);
                }
            }
        }
        private void PopulateCLODropdown()
        {
            SqlCommand cmd = new SqlCommand("SELECT Id, Name FROM Clo", con);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            cmbCLO.DataSource = dt;
            cmbCLO.DisplayMember = "Name";
            cmbCLO.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form moreForm = new MainForm();
            moreForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
