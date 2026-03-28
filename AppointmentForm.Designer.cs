namespace GroupPatientPortal
{
    partial class AppointmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentForm));
            lblTitle = new System.Windows.Forms.Label();
            lblDate = new System.Windows.Forms.Label();
            dtpDate = new System.Windows.Forms.DateTimePicker();
            label1 = new System.Windows.Forms.Label();
            txtReason = new System.Windows.Forms.TextBox();
            btnBack = new System.Windows.Forms.Button();
            Confirm = new System.Windows.Forms.Button();
            picLogo = new System.Windows.Forms.PictureBox();
            cbDoctor = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            lblTitle.Location = new System.Drawing.Point(206, 90);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(291, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Book an Appointment";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            lblDate.Location = new System.Drawing.Point(65, 212);
            lblDate.Name = "lblDate";
            lblDate.Size = new System.Drawing.Size(134, 24);
            lblDate.TabIndex = 1;
            lblDate.Text = "Booking Date";
            // 
            // dtpDate
            // 
            dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpDate.Location = new System.Drawing.Point(65, 251);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new System.Drawing.Size(179, 22);
            dtpDate.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(65, 287);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(192, 24);
            label1.TabIndex = 3;
            label1.Text = "Reason for booking";
            // 
            // txtReason
            // 
            txtReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            txtReason.Location = new System.Drawing.Point(65, 330);
            txtReason.Multiline = true;
            txtReason.Name = "txtReason";
            txtReason.Size = new System.Drawing.Size(497, 120);
            txtReason.TabIndex = 4;
            // 
            // btnBack
            // 
            btnBack.BackColor = System.Drawing.Color.RoyalBlue;
            btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            btnBack.ForeColor = System.Drawing.Color.White;
            btnBack.Location = new System.Drawing.Point(12, 624);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(109, 36);
            btnBack.TabIndex = 5;
            btnBack.Text = "Go Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // Confirm
            // 
            Confirm.BackColor = System.Drawing.Color.RoyalBlue;
            Confirm.Cursor = System.Windows.Forms.Cursors.IBeam;
            Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            Confirm.ForeColor = System.Drawing.Color.White;
            Confirm.Location = new System.Drawing.Point(563, 624);
            Confirm.Name = "Confirm";
            Confirm.Size = new System.Drawing.Size(109, 36);
            Confirm.TabIndex = 6;
            Confirm.Text = "Confirm";
            Confirm.UseVisualStyleBackColor = false;
            Confirm.Click += btnConfirm_Click;
            // 
            // picLogo
            // 
            picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            picLogo.Image = (System.Drawing.Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new System.Drawing.Point(12, 12);
            picLogo.Name = "picLogo";
            picLogo.Size = new System.Drawing.Size(81, 66);
            picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 7;
            picLogo.TabStop = false;
            // 
            // cbDoctor
            // 
            cbDoctor.FormattingEnabled = true;
            cbDoctor.Location = new System.Drawing.Point(376, 250);
            cbDoctor.Name = "cbDoctor";
            cbDoctor.Size = new System.Drawing.Size(121, 23);
            cbDoctor.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(376, 212);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(184, 24);
            label2.TabIndex = 9;
            label2.Text = "Chose your Doctor";
            // 
            // AppointmentForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            ClientSize = new System.Drawing.Size(684, 672);
            Controls.Add(label2);
            Controls.Add(cbDoctor);
            Controls.Add(picLogo);
            Controls.Add(Confirm);
            Controls.Add(btnBack);
            Controls.Add(txtReason);
            Controls.Add(label1);
            Controls.Add(dtpDate);
            Controls.Add(lblDate);
            Controls.Add(lblTitle);
            Name = "AppointmentForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "AppointmentForm";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.ComboBox cbDoctor;
        private System.Windows.Forms.Label label2;
    }
}