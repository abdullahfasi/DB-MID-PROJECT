using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;
using System.Text.RegularExpressions;

namespace DBMidProject
{
    public partial class StudentCRUDForm : Form
    {
        public StudentCRUDForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-LHN00FL;Initial Catalog=ProjectB;Integrated Security=True");
        public int id;

        private void StudentCRUDForm_Load(object sender, EventArgs e)
        {
            GetStudentRecord();
            
        }

        private void GetStudentRecord()
        {

            SqlCommand cmd = new SqlCommand("Select * from Student WHERE Status = 1", con);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            SrudentRecordDataGridView.DataSource = dt;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                SqlCommand regNumberCmd = new SqlCommand("SELECT COUNT(*) FROM Student WHERE RegistrationNumber = @RegistrationNumber", con);
                regNumberCmd.Parameters.AddWithValue("@RegistrationNumber", txtRNumber.Text);

                SqlCommand contactCmd = new SqlCommand("SELECT COUNT(*) FROM Student WHERE Contact = @Contact", con);
                contactCmd.Parameters.AddWithValue("@Contact", txtContact.Text);

                con.Open();
                int existingRegNumberCount = (int)regNumberCmd.ExecuteScalar();
                int existingContactCount = (int)contactCmd.ExecuteScalar();
                con.Close();

                if (existingRegNumberCount > 0)
                {
                    MessageBox.Show("Registration Number already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }

                if (existingContactCount > 0)
                {
                    MessageBox.Show("Contact already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO Student (FirstName, LastName, Contact, Email, RegistrationNumber, Status) VALUES (@FirstName, @LastName, @Contact, @Email, @RegistrationNumber, 1)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                cmd.Parameters.AddWithValue("@Contact", txtContact.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@RegistrationNumber", txtRNumber.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("New Student's Data successfully saved in the database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetStudentRecord();
                ResetFields();
            }
        }

        private bool isValid()
        {
            if (!validateRegistrationNumber(txtRNumber.Text))
            {
                return false;
            }

            if (!validateEmail(txtEmail.Text))
            {
                return false;
            }

            return true;
        }

        private bool validateRegistrationNumber(string regNumber)
        {
            string regNumberPattern = @"^\d{4}-[A-Za-z]{2}-\d{1,5}$";

            if (string.IsNullOrWhiteSpace(regNumber))
            {
                MessageBox.Show("Registration Number is not provided", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(regNumber, regNumberPattern))
            {
                MessageBox.Show("Invalid Registration Number format. Please use the format 'yyyy-DD-rr' (rr can be 1 to 5 digits).", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (regNumber.StartsWith("-"))
            {
                MessageBox.Show("Registration number cannot contain negative values.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (regNumber.Length > 2 && regNumber[2] == '0' && regNumber[1] == '0')
            {
                MessageBox.Show("Registration number cannot start with leading zeros (e.g., 0012).", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool validateEmail(string email)
        {
            string emailPattern = @"^[\w!#$%&'*+/=?^`{|}~-]+(?:\.[\w!#$%&'*+/=?^`{|}~-]+)*@\w+\.\w+$";

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Email is not provided", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Invalid Email format. Please use a valid email address format.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }




        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetFields();
        }
        private void ResetFields()
        {
            id = 0;
            txtRNumber.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtContact.Clear();
            txtRNumber.Focus();
        }

        private void SrudentRecordDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(SrudentRecordDataGridView.SelectedRows[0].Cells[0].Value);
            txtFirstName.Text = SrudentRecordDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtLastName.Text = SrudentRecordDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            txtContact.Text = SrudentRecordDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            txtEmail.Text = SrudentRecordDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            txtRNumber.Text = SrudentRecordDataGridView.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (id > 0 && isValid())
            {
                SqlCommand cmd = new SqlCommand("UPDATE Student SET FirstName = @FirstName, LastName = @LastName, Contact = @Contact, Email = @Email, RegistrationNumber = @RegistrationNumber, Status = 1 WHERE ID = @ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                cmd.Parameters.AddWithValue("@Contact", txtContact.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@RegistrationNumber", txtRNumber.Text);
                cmd.Parameters.AddWithValue("@ID", this.id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("New Student's Data successfully updated in the database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetStudentRecord();
                ResetFields();
            }
            else if(id == 0)
            {
                MessageBox.Show("Please Select Student Data to update", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (id > 0 && isValid())
            {
                SqlCommand cmd = new SqlCommand("UPDATE Student SET Status = NULL WHERE ID = @ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", this.id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Student Data has been deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetStudentRecord();
                ResetFields();
            }
            else if(id == 0)
            {
                MessageBox.Show("Please Select Student Data to delete", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form moreForm = new MainForm();
            moreForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
