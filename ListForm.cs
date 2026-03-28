using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace GroupPatientPortal;

public partial class ListForm : Form
{
    private int _patientId;
    public ListForm(int patientId)
    {
        InitializeComponent();
        _patientId = patientId;
        LoadAppointments();
    }
    private void LoadAppointments()
    {
        using (SqlConnection con = new SqlConnection(
            @"Server=localhost\SQLEXPRESS;Database=HospitalPortal;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;"))
        using (SqlCommand cmd = new SqlCommand("SELECT a.AppointmentID, d.FullName AS Doctor, a.AppointmentDate, a.Reason " +"FROM Appointments a " +"LEFT JOIN Doctors d ON a.DoctorID = d.DoctorID " + "WHERE a.PatientID=@id " + "ORDER BY a.AppointmentDate", con))
        {
            cmd.Parameters.AddWithValue("@id", _patientId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvAppointments.DataSource = dt;
        }
    }
    private void btnBack_Click(object sender, EventArgs e)
    {
        PatientPortal portal = new PatientPortal(_patientId);
        portal.Show();
        this.Hide();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {

        if (dgvAppointments.SelectedRows.Count == 0)
        {
            MessageBox.Show("Select appointment first");
            return;
        }
        int appointmentId = Convert.ToInt32(dgvAppointments.SelectedRows[0].Cells["AppointmentID"].Value);
        using (SqlConnection con = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=HospitalPortal;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;"))
        using (SqlCommand cmd = new SqlCommand("DELETE FROM Appointments WHERE AppointmentID=@id", con))
        {
            cmd.Parameters.AddWithValue("@id", appointmentId);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Appointment cancelled");
            LoadAppointments();
        }
    }

    private void btnReschedule_Click(object sender, EventArgs e)
    {
        if (dgvAppointments.SelectedRows.Count == 0)
        {
            MessageBox.Show("Select appointment first");
            return;
        }
        int appointmentId = Convert.ToInt32(dgvAppointments.SelectedRows[0].Cells["AppointmentID"].Value);
        AppointmentForm form = new AppointmentForm(_patientId, appointmentId);
        form.Show();
        this.Hide();
    }
}
