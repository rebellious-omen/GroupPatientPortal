using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace GroupPatientPortal
{
    public partial class PatientPortal : Form
    {
        private int _patientId;

        public PatientPortal(int patientId)
        {
            InitializeComponent();
            _patientId = patientId;
            btnSaveEdit.Visible = false;
        }

        private void LoadPatientRecord(int patientId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=HospitalPortal;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;"))
                using (SqlCommand cmd = new SqlCommand("SELECT DateOfBirth, Sex, Address, Telephone, BloodType, Weight, Height, Medication, History, FullName " + "FROM HospitalPortalTable WHERE PatientID = @id", con))
                {
                    cmd.Parameters.AddWithValue("@id", patientId);

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        lblDobValue.Text = reader["DateOfBirth"] == DBNull.Value ? "N/A" : reader["DateOfBirth"].ToString();
                        lblSexValue.Text = reader["Sex"] == DBNull.Value ? "N/A" : reader["Sex"].ToString();
                        lblAddressValue.Text = reader["Address"] == DBNull.Value ? "N/A" : reader["Address"].ToString();
                        lblTelephoneValue.Text = reader["Telephone"] == DBNull.Value ? "N/A" : reader["Telephone"].ToString();
                        lblBloodTypeValue.Text = reader["BloodType"] == DBNull.Value ? "N/A" : reader["BloodType"].ToString();
                        lblWeightValue.Text = reader["Weight"] == DBNull.Value ? "N/A" : reader["Weight"].ToString();
                        lblHeightValue.Text = reader["Height"] == DBNull.Value ? "N/A" : reader["Height"].ToString();
                        lblMedicationValue.Text = reader["Medication"] == DBNull.Value ? "N/A" : reader["Medication"].ToString();
                        lblHistoryValue.Text = reader["History"] == DBNull.Value ? "N/A" : reader["History"].ToString();
                        lblWelcome.Text = "Welcome, " + (reader["FullName"] == DBNull.Value ? "Patient" : reader["FullName"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to sign out?",
                "Confirm Signing Out",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginForm portal = new();
                portal.Show();
                this.Hide();
            }
        }

        private void PatientPortal_Load(object sender, EventArgs e)
        {
            LoadPatientRecord(_patientId);
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            ListForm portal = new(_patientId);
            portal.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtBloodTypeEdit.Visible = true;
            txtTelephoneEdit.Visible = true;
            txtWeightEdit.Visible = true;
            txtHeightEdit.Visible = true;
            txtAddressEdit.Visible = true;
            txtHistoryEdit.Visible = true;
            btnSaveEdit.Visible = true;

            txtBloodTypeEdit.Text = lblBloodTypeValue.Text;
            txtWeightEdit.Text = lblWeightValue.Text;
            txtHeightEdit.Text = lblHeightValue.Text;
            txtAddressEdit.Text = lblAddressValue.Text;
            txtHistoryEdit.Text = lblHistoryValue.Text;
            txtTelephoneEdit.Text = lblTelephoneValue.Text;
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            //validations
            string[] ValidationBloodTypes = { "A+", "A-", "B+", "B-", "O-", "O+", "AB+", "AB-" };
            if (!ValidationBloodTypes.Contains(txtBloodTypeEdit.Text.ToUpper()))
            {
                MessageBox.Show("Invalid Blood Type");
                return;
            }

            if (!int.TryParse(txtWeightEdit.Text, out _))
            {
                MessageBox.Show("Weight must be a number");
                return;
            }

            if (!int.TryParse(txtHeightEdit.Text, out _))
            {
                MessageBox.Show("Height must be a number");
                return;
            }

            int weight = int.Parse(txtWeightEdit.Text);
            int height = int.Parse(txtHeightEdit.Text);
            //limit for the weight, there was people more than 500 kg 
            if (weight < 0 || weight > 600)
            {
                MessageBox.Show("Invalid Weight,please try again");
                return;
            }
            if (height < 0 || height > 300)
            {
                MessageBox.Show("Invalid Height,please try again");
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtTelephoneEdit.Text, @"^[0-9+\-\s]{7,15}$"))
            {
                MessageBox.Show("Invalid telephone number,please try again");
                return;
            }
            if (txtAddressEdit.Text.Length < 5)
            {
                MessageBox.Show("Address is too short");
                return;
            }

            using (SqlConnection con = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=HospitalPortal;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;"))
            using (SqlCommand cmd = new SqlCommand("UPDATE HospitalPortalTable SET BloodType=@b, Weight=@w, Height=@h, Address=@a, Telephone=@t, History=@his WHERE PatientID=@id", con))
            {
                cmd.Parameters.AddWithValue("@b", txtBloodTypeEdit.Text);
                cmd.Parameters.AddWithValue("@w", txtWeightEdit.Text);
                cmd.Parameters.AddWithValue("@h", txtHeightEdit.Text);
                cmd.Parameters.AddWithValue("@a", txtAddressEdit.Text);
                cmd.Parameters.AddWithValue("@his", txtHistoryEdit.Text);
                cmd.Parameters.AddWithValue("@t", txtTelephoneEdit.Text);
                cmd.Parameters.AddWithValue("@id", _patientId);

                con.Open();
                cmd.ExecuteNonQuery();
                btnSaveEdit.Visible = false;
            }

            lblBloodTypeValue.Text = txtBloodTypeEdit.Text;
            lblWeightValue.Text = txtWeightEdit.Text;
            lblHeightValue.Text = txtHeightEdit.Text;
            lblAddressValue.Text = txtAddressEdit.Text;
            lblHistoryValue.Text = txtHistoryEdit.Text;
            lblTelephoneValue.Text = txtTelephoneEdit.Text;

            txtBloodTypeEdit.Visible = false;
            txtTelephoneEdit.Visible = false;
            txtWeightEdit.Visible = false;
            txtHeightEdit.Visible = false;
            txtAddressEdit.Visible = false;
            txtHistoryEdit.Visible = false;
            MessageBox.Show("Saved!");
        }

        private void btnBookAppointment_Click(object sender, EventArgs e)
        {
            AppointmentForm portal = new(_patientId);
            portal.Show();
            this.Hide();
        }

        private void txtHistoryEdit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


