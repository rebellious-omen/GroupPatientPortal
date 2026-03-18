using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupPatientPortal
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                // Get values from form
                string fullName = txtFullName.Text;
                string email = txtEmail.Text;
                string password = txtPassword.Text;
                DateTime dob;
                string sex = cmbSex.Text;
                string address = txtAddress.Text;
                string telephone = txtTelephone.Text;

                //Validation for the empty fields in full name, email and pass
                if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please fill all required fields");
                    return;
                }

                if (!email.Contains("@") || !email.Contains("."))
                {
                    MessageBox.Show("Invalid email");
                    return;
                }

                try 
                {
                    dob = DateTime.Parse(mtbDob.Text);
                }
                catch
                {
                    MessageBox.Show("Invalid date");
                    return;
                }


                // Create connection
                SqlConnection con = new SqlConnection(
                    @"Server=localhost\SQLEXPRESS;Database=HospitalPortal;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;");

                // SQL INSERT
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO HospitalPortalTable " +
                    "(FullName, Email, Password, DateOfBirth, Sex, Address, Telephone) " +
                    "VALUES (@FullName, @Email, @Password, @DateOfBirth, @Sex, @Address, @Telephone)", con);

                // Add parameters
                cmd.Parameters.AddWithValue("@FullName", fullName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@DateOfBirth", dob);
                cmd.Parameters.AddWithValue("@Sex", sex);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Telephone", telephone);

                // Execute
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Registration successful!");

                // Go back to login
                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void lblBackToLogin_Click(object sender, EventArgs e)
        {
            LoginForm login = new();
            login.Show();
            this.Hide();
        }

        private void lblText_Click(object sender, EventArgs e)
        {
            LoginForm login = new();
            login.Show();
            this.Hide();
        }
    }
}
    

