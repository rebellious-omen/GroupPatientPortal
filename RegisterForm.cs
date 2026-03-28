using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text.RegularExpressions;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Net.Mail;

namespace GroupPatientPortal;

public partial class RegisterForm : Form
{
    public RegisterForm()
    {
        InitializeComponent();
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
        string fullName = txtFullName.Text;
        string email = txtEmail.Text;
        string password = Crypto.Password.Hash(txtPassword.Text);
        string sex = cmbSex.Text;
        string address = txtAddress.Text;
        string telephone = txtTelephone.Text;
    
 
        if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
        {
            MessageBox.Show("Please fill all required fields");
            return;
        }

        if (MailAddress.TryCreate(email, out _))
        {
            MessageBox.Show("Invalid email");
            return;
        }

        if (!Regex.IsMatch(telephone, @"^[0-9+\-\s]{7,15}$"))
        {
            MessageBox.Show("Invalid telephone number");
            return;
        }

        if (address.Length < 5)
        {
            MessageBox.Show("Address is too short");
            return;
        }

        if (!DateTime.TryParse(mtbDob.Text, out var dob))
        {
            MessageBox.Show("Invalid date of birth, enter the valid date");
            return;
        }

        try {
            SqlConnection con = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=HospitalPortal;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;");
            SqlCommand cmd = new SqlCommand(
                "INSERT INTO HospitalPortalTable " +
                "(FullName, Email, Password, DateOfBirth, Sex, Address, Telephone) " +
                "VALUES (@FullName, @Email, @Password, @DateOfBirth, @Sex, @Address, @Telephone)", con);

            cmd.Parameters.AddWithValue("@FullName", fullName);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@DateOfBirth", dob);
            cmd.Parameters.AddWithValue("@Sex", sex);
            cmd.Parameters.AddWithValue("@Address", address);
            cmd.Parameters.AddWithValue("@Telephone", telephone);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
            return;
        }

        MessageBox.Show("Registration successful!");
        LoginForm login = new();
        login.Show();
        this.Hide();
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


