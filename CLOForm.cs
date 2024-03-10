using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMidProject
{
    public partial class CLOForm : Form
    {
        public CLOForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-LHN00FL;Initial Catalog=ProjectB;Integrated Security=True");
        public int cloId;

        private void GetCLORecords()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Clo", con);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            CLODataGridView.DataSource = dt;
        }


        private bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(txtCLOName.Text))
            {
                MessageBox.Show("Please provide a CLO name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Regular expression pattern to allow only text or space characters
            string pattern = @"^[a-zA-Z\s]*$";

            if (!Regex.IsMatch(txtCLOName.Text, pattern))
            {
                MessageBox.Show("CLO name must contain only alphabets or spaces", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


        private void ResetFields()
        {
            cloId = 0;
            txtCLOName.Clear();
            txtCLOName.Focus();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetFields();
        }

        private void CLODataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cloId = Convert.ToInt32(CLODataGridView.SelectedRows[0].Cells["Id"].Value);
            txtCLOName.Text = CLODataGridView.SelectedRows[0].Cells["Name"].Value.ToString();
        }

        private void CLOForm_Load(object sender, EventArgs e)
        {
            GetCLORecords();
        }

        private void buttonAddCLO_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Clo (Name, DateCreated, DateUpdated) VALUES (@Name, GETDATE(), GETDATE())", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Name", txtCLOName.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("New CLO successfully added to the database", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetCLORecords();
                ResetFields();
            }
        }

        private void buttonUpdateCLO_Click(object sender, EventArgs e)
        {
            if (cloId > 0 && IsValid())
            {
                SqlCommand cmd = new SqlCommand("UPDATE Clo SET Name = @Name, DateUpdated = GETDATE() WHERE Id = @Id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Name", txtCLOName.Text);
                cmd.Parameters.AddWithValue("@Id", cloId);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("CLO details updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetCLORecords();
                ResetFields();
            }
            else if(cloId == 0)
            {
                MessageBox.Show("Please select a CLO to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDeleteCLO_Click(object sender, EventArgs e)
        {
            if (cloId > 0 && IsValid())
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Clo WHERE Id = @Id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", cloId);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("CLO deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetCLORecords();
                ResetFields();
            }
            else if (cloId == 0)
            {
                MessageBox.Show("Please select a CLO to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form moreForm = new MainForm();
            moreForm.Show();
        }
    }
}
