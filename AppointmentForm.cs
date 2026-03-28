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
using Microsoft.VisualBasic;

namespace GroupPatientPortal;

public partial class AppointmentForm : Form
{
    private int _patientId;
    private int _appointmentID = 0;

    public AppointmentForm(int patientId, int appointmentID) : this(patientId)
    {
        _appointmentID=appointmentID;
    }
    public AppointmentForm(int patientId)
    {
        InitializeComponent();
        _patientId = patientId;
        dtpDate.MinDate = DateTime.Today;
        Doctors();
    }
    private void Doctors()
    {
        try
        {
            using (SqlConnection con = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=HospitalPortal;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;"))
            using (SqlCommand cmd = new SqlCommand("SELECT DoctorID, FullName FROM Doctors", con))
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                cbDoctor.DataSource = dt;
                cbDoctor.DisplayMember = "FullName";
                cbDoctor.ValueMember = "DoctorID";
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
            return;
        }
    }
    private void btnConfirm_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtReason.Text))
        {
            MessageBox.Show("Please enter reason");
            return;
        }
        if (cbDoctor.SelectedIndex == -1)
        {
            MessageBox.Show("Select doctor");
            return;
        }

        using (SqlConnection con = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=HospitalPortal;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;"))
        {
            con.Open();
            SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Appointments WHERE AppointmentDate=@date AND AppointmentID<>@id", con);
            checkCmd.Parameters.AddWithValue("@date", dtpDate.Value.Date);
            checkCmd.Parameters.AddWithValue("@id", _appointmentID);
            int count = (int)checkCmd.ExecuteScalar();

            if (count > 0)
            {
                MessageBox.Show("This date is already booked");
                return;
            }
            SqlCommand cmd;

            if (_appointmentID == 0)
            {
                cmd = new SqlCommand( "INSERT INTO Appointments (DoctorID,PatientID, AppointmentDate, Reason) VALUES (@doc,@pid,@date,@reason)", con);
                cmd.Parameters.AddWithValue("@pid", _patientId);
            }
            else
            {
                cmd = new SqlCommand("UPDATE Appointments SET DoctorID=@doc,AppointmentDate=@date, Reason=@reason WHERE AppointmentID=@id", con);
                cmd.Parameters.AddWithValue("@id", _appointmentID);
            }
            cmd.Parameters.AddWithValue("@doc", cbDoctor.SelectedValue);
            cmd.Parameters.AddWithValue("@date", dtpDate.Value.Date);
            cmd.Parameters.AddWithValue("@reason", txtReason.Text);
            cmd.ExecuteNonQuery();
        }
        MessageBox.Show("Saved!");
        ListForm form = new ListForm(_patientId);
        form.Show();
        this.Hide();
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
        PatientPortal portal = new PatientPortal(_patientId);
        portal.Show();
        this.Hide();
    }
}
