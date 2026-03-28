namespace GroupPatientPortal
{
    partial class ListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvAppointments = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            btnBack = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            btnReschedule = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            SuspendLayout();
            // 
            // dgvAppointments
            // 
            dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointments.Location = new System.Drawing.Point(97, 269);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.Size = new System.Drawing.Size(501, 293);
            dgvAppointments.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            label1.ForeColor = System.Drawing.Color.RoyalBlue;
            label1.Location = new System.Drawing.Point(184, 194);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(335, 42);
            label1.TabIndex = 1;
            label1.Text = "Your Appointments";
            // 
            // btnBack
            // 
            btnBack.BackColor = System.Drawing.Color.RoyalBlue;
            btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            btnBack.ForeColor = System.Drawing.Color.White;
            btnBack.Location = new System.Drawing.Point(12, 644);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(159, 55);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.RoyalBlue;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            btnCancel.ForeColor = System.Drawing.Color.White;
            btnCancel.Location = new System.Drawing.Point(529, 644);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(159, 54);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel Appointment";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnReschedule
            // 
            btnReschedule.BackColor = System.Drawing.Color.RoyalBlue;
            btnReschedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnReschedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            btnReschedule.ForeColor = System.Drawing.Color.White;
            btnReschedule.Location = new System.Drawing.Point(282, 644);
            btnReschedule.Name = "btnReschedule";
            btnReschedule.Size = new System.Drawing.Size(159, 55);
            btnReschedule.TabIndex = 4;
            btnReschedule.Text = "Reschedule";
            btnReschedule.UseVisualStyleBackColor = false;
            btnReschedule.Click += btnReschedule_Click;
            // 
            // ListForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            ClientSize = new System.Drawing.Size(700, 711);
            Controls.Add(btnReschedule);
            Controls.Add(btnCancel);
            Controls.Add(btnBack);
            Controls.Add(label1);
            Controls.Add(dgvAppointments);
            Name = "ListForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ListForm";
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReschedule;
    }
}