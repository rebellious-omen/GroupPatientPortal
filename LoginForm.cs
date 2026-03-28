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

namespace GroupPatientPortal;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }

    private void lblSignUp_Click(object sender, EventArgs e)
    {
        RegisterForm register = new RegisterForm();
        register.Show();
        this.Hide();
    }

        private void btnSignIn_Click(object sender, EventArgs e)
    {
        try
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            using (SqlConnection con = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=HospitalPortal;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;"))
            using (SqlCommand cmd = new SqlCommand("SELECT PatientID,Password FROM HospitalPortalTable WHERE Email = @Email", con))
            {
                cmd.Parameters.AddWithValue("@Email", email);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string storedHash = reader["Password"].ToString();

                    if (Crypto.Password.Verify(password, storedHash))
                    {
                        int patientId = Convert.ToInt32(reader["PatientID"]);
                        PatientPortal portal = new PatientPortal(patientId);
                        portal.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid email or password");
                }
            }
        }

        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
    }
}

