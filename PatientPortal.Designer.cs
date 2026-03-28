namespace GroupPatientPortal
{
    partial class PatientPortal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientPortal));
            panelMain = new System.Windows.Forms.Panel();
            btnSaveEdit = new System.Windows.Forms.Button();
            txtHistoryEdit = new System.Windows.Forms.TextBox();
            txtHeightEdit = new System.Windows.Forms.TextBox();
            txtTelephoneEdit = new System.Windows.Forms.TextBox();
            txtAddressEdit = new System.Windows.Forms.TextBox();
            txtWeightEdit = new System.Windows.Forms.TextBox();
            txtBloodTypeEdit = new System.Windows.Forms.TextBox();
            btnEdit = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            lblAddressValue = new System.Windows.Forms.Label();
            lblMedicationValue = new System.Windows.Forms.Label();
            lblHistoryValue = new System.Windows.Forms.Label();
            lblWeightValue = new System.Windows.Forms.Label();
            lblBloodTypeValue = new System.Windows.Forms.Label();
            lblTelephoneValue = new System.Windows.Forms.Label();
            lblHeightValue = new System.Windows.Forms.Label();
            lblDobValue = new System.Windows.Forms.Label();
            lblSexValue = new System.Windows.Forms.Label();
            lblWelcome = new System.Windows.Forms.Label();
            btnAppointments = new System.Windows.Forms.Button();
            btnSignOut = new System.Windows.Forms.Button();
            btnBookAppointment = new System.Windows.Forms.Button();
            lblHistory = new System.Windows.Forms.Label();
            lblMedication = new System.Windows.Forms.Label();
            lblHeight = new System.Windows.Forms.Label();
            lblWeight = new System.Windows.Forms.Label();
            lblBloodType = new System.Windows.Forms.Label();
            lblTelephone = new System.Windows.Forms.Label();
            lblAddress = new System.Windows.Forms.Label();
            lblDob = new System.Windows.Forms.Label();
            lblSex = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            picLogo = new System.Windows.Forms.PictureBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            panelMain.Controls.Add(btnSaveEdit);
            panelMain.Controls.Add(txtHistoryEdit);
            panelMain.Controls.Add(txtHeightEdit);
            panelMain.Controls.Add(txtTelephoneEdit);
            panelMain.Controls.Add(txtAddressEdit);
            panelMain.Controls.Add(txtWeightEdit);
            panelMain.Controls.Add(txtBloodTypeEdit);
            panelMain.Controls.Add(btnEdit);
            panelMain.Controls.Add(btnExit);
            panelMain.Controls.Add(lblAddressValue);
            panelMain.Controls.Add(lblMedicationValue);
            panelMain.Controls.Add(lblHistoryValue);
            panelMain.Controls.Add(lblWeightValue);
            panelMain.Controls.Add(lblBloodTypeValue);
            panelMain.Controls.Add(lblTelephoneValue);
            panelMain.Controls.Add(lblHeightValue);
            panelMain.Controls.Add(lblDobValue);
            panelMain.Controls.Add(lblSexValue);
            panelMain.Controls.Add(lblWelcome);
            panelMain.Controls.Add(btnAppointments);
            panelMain.Controls.Add(btnSignOut);
            panelMain.Controls.Add(btnBookAppointment);
            panelMain.Controls.Add(lblHistory);
            panelMain.Controls.Add(lblMedication);
            panelMain.Controls.Add(lblHeight);
            panelMain.Controls.Add(lblWeight);
            panelMain.Controls.Add(lblBloodType);
            panelMain.Controls.Add(lblTelephone);
            panelMain.Controls.Add(lblAddress);
            panelMain.Controls.Add(lblDob);
            panelMain.Controls.Add(lblSex);
            panelMain.Controls.Add(label1);
            panelMain.Controls.Add(lblTitle);
            panelMain.Controls.Add(picLogo);
            panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.ForeColor = System.Drawing.Color.Black;
            panelMain.Location = new System.Drawing.Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new System.Drawing.Size(700, 711);
            panelMain.TabIndex = 0;
            // 
            // btnSaveEdit
            // 
            btnSaveEdit.BackColor = System.Drawing.Color.RoyalBlue;
            btnSaveEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSaveEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            btnSaveEdit.ForeColor = System.Drawing.Color.White;
            btnSaveEdit.Location = new System.Drawing.Point(297, 613);
            btnSaveEdit.Name = "btnSaveEdit";
            btnSaveEdit.Size = new System.Drawing.Size(136, 41);
            btnSaveEdit.TabIndex = 51;
            btnSaveEdit.Text = "Save Edit";
            btnSaveEdit.UseVisualStyleBackColor = false;
            btnSaveEdit.Click += btnSaveEdit_Click;
            // 
            // txtHistoryEdit
            // 
            txtHistoryEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            txtHistoryEdit.Location = new System.Drawing.Point(268, 443);
            txtHistoryEdit.Name = "txtHistoryEdit";
            txtHistoryEdit.Size = new System.Drawing.Size(420, 26);
            txtHistoryEdit.TabIndex = 50;
            txtHistoryEdit.Visible = false;
            txtHistoryEdit.TextChanged += txtHistoryEdit_TextChanged;
            // 
            // txtHeightEdit
            // 
            txtHeightEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtHeightEdit.Location = new System.Drawing.Point(98, 253);
            txtHeightEdit.Name = "txtHeightEdit";
            txtHeightEdit.Size = new System.Drawing.Size(110, 26);
            txtHeightEdit.TabIndex = 49;
            txtHeightEdit.Visible = false;
            // 
            // txtTelephoneEdit
            // 
            txtTelephoneEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            txtTelephoneEdit.Location = new System.Drawing.Point(140, 290);
            txtTelephoneEdit.Name = "txtTelephoneEdit";
            txtTelephoneEdit.Size = new System.Drawing.Size(100, 26);
            txtTelephoneEdit.TabIndex = 48;
            txtTelephoneEdit.Visible = false;
            // 
            // txtAddressEdit
            // 
            txtAddressEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            txtAddressEdit.Location = new System.Drawing.Point(115, 403);
            txtAddressEdit.Name = "txtAddressEdit";
            txtAddressEdit.Size = new System.Drawing.Size(573, 26);
            txtAddressEdit.TabIndex = 47;
            txtAddressEdit.Visible = false;
            // 
            // txtWeightEdit
            // 
            txtWeightEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            txtWeightEdit.Location = new System.Drawing.Point(103, 367);
            txtWeightEdit.Name = "txtWeightEdit";
            txtWeightEdit.Size = new System.Drawing.Size(100, 26);
            txtWeightEdit.TabIndex = 46;
            txtWeightEdit.Visible = false;
            // 
            // txtBloodTypeEdit
            // 
            txtBloodTypeEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            txtBloodTypeEdit.Location = new System.Drawing.Point(145, 330);
            txtBloodTypeEdit.Name = "txtBloodTypeEdit";
            txtBloodTypeEdit.Size = new System.Drawing.Size(100, 26);
            txtBloodTypeEdit.TabIndex = 45;
            txtBloodTypeEdit.Visible = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = System.Drawing.Color.RoyalBlue;
            btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            btnEdit.ForeColor = System.Drawing.Color.White;
            btnEdit.Location = new System.Drawing.Point(297, 660);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(136, 41);
            btnEdit.TabIndex = 44;
            btnEdit.Text = "Edit Records";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = System.Drawing.Color.RoyalBlue;
            btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnExit.ForeColor = System.Drawing.Color.White;
            btnExit.Location = new System.Drawing.Point(16, 662);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(138, 37);
            btnExit.TabIndex = 43;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblAddressValue
            // 
            lblAddressValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblAddressValue.Location = new System.Drawing.Point(115, 403);
            lblAddressValue.Name = "lblAddressValue";
            lblAddressValue.Size = new System.Drawing.Size(574, 22);
            lblAddressValue.TabIndex = 42;
            // 
            // lblMedicationValue
            // 
            lblMedicationValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblMedicationValue.Location = new System.Drawing.Point(268, 447);
            lblMedicationValue.Name = "lblMedicationValue";
            lblMedicationValue.Size = new System.Drawing.Size(410, 22);
            lblMedicationValue.TabIndex = 40;
            // 
            // lblHistoryValue
            // 
            lblHistoryValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblHistoryValue.Location = new System.Drawing.Point(268, 478);
            lblHistoryValue.Name = "lblHistoryValue";
            lblHistoryValue.Size = new System.Drawing.Size(346, 22);
            lblHistoryValue.TabIndex = 39;
            // 
            // lblWeightValue
            // 
            lblWeightValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblWeightValue.Location = new System.Drawing.Point(103, 366);
            lblWeightValue.Name = "lblWeightValue";
            lblWeightValue.Size = new System.Drawing.Size(105, 21);
            lblWeightValue.TabIndex = 38;
            // 
            // lblBloodTypeValue
            // 
            lblBloodTypeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblBloodTypeValue.Location = new System.Drawing.Point(145, 330);
            lblBloodTypeValue.Name = "lblBloodTypeValue";
            lblBloodTypeValue.Size = new System.Drawing.Size(105, 21);
            lblBloodTypeValue.TabIndex = 37;
            // 
            // lblTelephoneValue
            // 
            lblTelephoneValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblTelephoneValue.Location = new System.Drawing.Point(140, 293);
            lblTelephoneValue.Name = "lblTelephoneValue";
            lblTelephoneValue.Size = new System.Drawing.Size(105, 21);
            lblTelephoneValue.TabIndex = 36;
            // 
            // lblHeightValue
            // 
            lblHeightValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblHeightValue.Location = new System.Drawing.Point(98, 255);
            lblHeightValue.Name = "lblHeightValue";
            lblHeightValue.Size = new System.Drawing.Size(105, 21);
            lblHeightValue.TabIndex = 35;
            // 
            // lblDobValue
            // 
            lblDobValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblDobValue.Location = new System.Drawing.Point(151, 189);
            lblDobValue.Name = "lblDobValue";
            lblDobValue.Size = new System.Drawing.Size(105, 21);
            lblDobValue.TabIndex = 34;
            // 
            // lblSexValue
            // 
            lblSexValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblSexValue.Location = new System.Drawing.Point(74, 224);
            lblSexValue.Name = "lblSexValue";
            lblSexValue.Size = new System.Drawing.Size(105, 21);
            lblSexValue.TabIndex = 33;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = System.Drawing.Color.RoyalBlue;
            lblWelcome.Location = new System.Drawing.Point(535, 53);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new System.Drawing.Size(79, 20);
            lblWelcome.TabIndex = 29;
            lblWelcome.Text = "Welcome,";
            // 
            // btnAppointments
            // 
            btnAppointments.BackColor = System.Drawing.Color.RoyalBlue;
            btnAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnAppointments.ForeColor = System.Drawing.Color.White;
            btnAppointments.Location = new System.Drawing.Point(550, 615);
            btnAppointments.Name = "btnAppointments";
            btnAppointments.Size = new System.Drawing.Size(138, 41);
            btnAppointments.TabIndex = 27;
            btnAppointments.Text = "Appointments";
            btnAppointments.UseVisualStyleBackColor = false;
            btnAppointments.Click += btnAppointments_Click;
            // 
            // btnSignOut
            // 
            btnSignOut.BackColor = System.Drawing.Color.RoyalBlue;
            btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSignOut.ForeColor = System.Drawing.Color.White;
            btnSignOut.Location = new System.Drawing.Point(18, 618);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Size = new System.Drawing.Size(136, 38);
            btnSignOut.TabIndex = 26;
            btnSignOut.Text = "Sign Out";
            btnSignOut.UseVisualStyleBackColor = false;
            btnSignOut.Click += btnSignOut_Click;
            // 
            // btnBookAppointment
            // 
            btnBookAppointment.BackColor = System.Drawing.Color.RoyalBlue;
            btnBookAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBookAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnBookAppointment.ForeColor = System.Drawing.Color.White;
            btnBookAppointment.Location = new System.Drawing.Point(550, 662);
            btnBookAppointment.Name = "btnBookAppointment";
            btnBookAppointment.Size = new System.Drawing.Size(139, 37);
            btnBookAppointment.TabIndex = 25;
            btnBookAppointment.Text = "Book an appointment";
            btnBookAppointment.UseVisualStyleBackColor = false;
            btnBookAppointment.Click += btnBookAppointment_Click;
            // 
            // lblHistory
            // 
            lblHistory.AutoSize = true;
            lblHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            lblHistory.ForeColor = System.Drawing.Color.Black;
            lblHistory.Location = new System.Drawing.Point(16, 444);
            lblHistory.Name = "lblHistory";
            lblHistory.Size = new System.Drawing.Size(246, 24);
            lblHistory.TabIndex = 22;
            lblHistory.Text = "Previous Medical History:";
            // 
            // lblMedication
            // 
            lblMedication.AutoSize = true;
            lblMedication.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            lblMedication.ForeColor = System.Drawing.Color.Black;
            lblMedication.Location = new System.Drawing.Point(16, 478);
            lblMedication.Name = "lblMedication";
            lblMedication.Size = new System.Drawing.Size(257, 24);
            lblMedication.TabIndex = 20;
            lblMedication.Text = "Medication / Prescriptions:";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            lblHeight.ForeColor = System.Drawing.Color.Black;
            lblHeight.Location = new System.Drawing.Point(16, 252);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new System.Drawing.Size(77, 24);
            lblHeight.TabIndex = 18;
            lblHeight.Text = "Height:";
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            lblWeight.ForeColor = System.Drawing.Color.Black;
            lblWeight.Location = new System.Drawing.Point(16, 363);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new System.Drawing.Size(81, 24);
            lblWeight.TabIndex = 16;
            lblWeight.Text = "Weight:";
            // 
            // lblBloodType
            // 
            lblBloodType.AutoSize = true;
            lblBloodType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            lblBloodType.ForeColor = System.Drawing.Color.Black;
            lblBloodType.Location = new System.Drawing.Point(16, 327);
            lblBloodType.Name = "lblBloodType";
            lblBloodType.Size = new System.Drawing.Size(123, 24);
            lblBloodType.TabIndex = 14;
            lblBloodType.Text = "Blood Type:";
            // 
            // lblTelephone
            // 
            lblTelephone.AutoSize = true;
            lblTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            lblTelephone.ForeColor = System.Drawing.Color.Black;
            lblTelephone.Location = new System.Drawing.Point(16, 290);
            lblTelephone.Name = "lblTelephone";
            lblTelephone.Size = new System.Drawing.Size(118, 24);
            lblTelephone.TabIndex = 11;
            lblTelephone.Text = "Telephone:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            lblAddress.ForeColor = System.Drawing.Color.Black;
            lblAddress.Location = new System.Drawing.Point(16, 403);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new System.Drawing.Size(93, 24);
            lblAddress.TabIndex = 7;
            lblAddress.Text = "Address:";
            // 
            // lblDob
            // 
            lblDob.AutoSize = true;
            lblDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            lblDob.ForeColor = System.Drawing.Color.Black;
            lblDob.Location = new System.Drawing.Point(16, 189);
            lblDob.Name = "lblDob";
            lblDob.Size = new System.Drawing.Size(129, 24);
            lblDob.TabIndex = 4;
            lblDob.Text = "Date of Birth:";
            // 
            // lblSex
            // 
            lblSex.AutoSize = true;
            lblSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            lblSex.ForeColor = System.Drawing.Color.Black;
            lblSex.Location = new System.Drawing.Point(16, 221);
            lblSex.Name = "lblSex";
            lblSex.Size = new System.Drawing.Size(52, 24);
            lblSex.TabIndex = 3;
            lblSex.Text = "Sex:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(16, 143);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(167, 24);
            label1.TabIndex = 2;
            label1.Text = "Medical Records";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            lblTitle.Location = new System.Drawing.Point(242, 53);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(191, 31);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Patient Portal";
            // 
            // picLogo
            // 
            picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            picLogo.Image = (System.Drawing.Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new System.Drawing.Point(10, 11);
            picLogo.Name = "picLogo";
            picLogo.Size = new System.Drawing.Size(81, 66);
            picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // PatientPortal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(700, 711);
            Controls.Add(panelMain);
            ForeColor = System.Drawing.Color.Teal;
            Name = "PatientPortal";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "PatientPortal";
            Load += PatientPortal_Load;
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblBloodType;
        private System.Windows.Forms.Label lblMedication;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.Button btnAppointments;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnBookAppointment;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblDobValue;
        private System.Windows.Forms.Label lblSexValue;
        private System.Windows.Forms.Label lblMedicationValue;
        private System.Windows.Forms.Label lblHistoryValue;
        private System.Windows.Forms.Label lblWeightValue;
        private System.Windows.Forms.Label lblBloodTypeValue;
        private System.Windows.Forms.Label lblTelephoneValue;
        private System.Windows.Forms.Label lblHeightValue;
        private System.Windows.Forms.Label lblAddressValue;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEdit;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.TextBox txtTelephoneEdit;
        private System.Windows.Forms.TextBox txtAddressEdit;
        private System.Windows.Forms.TextBox txtWeightEdit;
        private System.Windows.Forms.TextBox txtBloodTypeEdit;
        private System.Windows.Forms.TextBox txtHistoryEdit;
        private System.Windows.Forms.TextBox txtHeightEdit;
        private System.Windows.Forms.Button btnSaveEdit;
    }
}

