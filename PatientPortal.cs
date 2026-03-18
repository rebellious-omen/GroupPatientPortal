using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        private void LoadPatientRecord(int patientId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(
                    @"Server=localhost\SQLEXPRESS;Database=HospitalPortal;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;"))
                using (SqlCommand cmd = new SqlCommand(
                    "SELECT DateOfBirth, Sex, Address, Telephone, BloodType, Weight, Height, Medication, History, FullName " +
                    "FROM HospitalPortalTable WHERE PatientID = @id", con))
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
    }
}


