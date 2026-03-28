namespace GroupPatientPortal
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            txtFullName = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            txtAddress = new System.Windows.Forms.TextBox();
            txtTelephone = new System.Windows.Forms.TextBox();
            cmbSex = new System.Windows.Forms.ComboBox();
            btnRegister = new System.Windows.Forms.Button();
            lblBackToLogin = new System.Windows.Forms.Label();
            lblText = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            lblName = new System.Windows.Forms.Label();
            lblDob = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            lblEmail = new System.Windows.Forms.Label();
            lblAddress = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            picLogo = new System.Windows.Forms.PictureBox();
            mtbDob = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // txtFullName
            // 
            txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtFullName.Location = new System.Drawing.Point(280, 191);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new System.Drawing.Size(209, 26);
            txtFullName.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtPassword.Location = new System.Drawing.Point(280, 287);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(209, 26);
            txtPassword.TabIndex = 7;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtEmail.Location = new System.Drawing.Point(280, 239);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(209, 26);
            txtEmail.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtAddress.Location = new System.Drawing.Point(280, 471);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new System.Drawing.Size(209, 26);
            txtAddress.TabIndex = 9;
            // 
            // txtTelephone
            // 
            txtTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtTelephone.Location = new System.Drawing.Point(280, 376);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new System.Drawing.Size(209, 26);
            txtTelephone.TabIndex = 10;
            // 
            // cmbSex
            // 
            cmbSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cmbSex.FormattingEnabled = true;
            cmbSex.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cmbSex.Location = new System.Drawing.Point(280, 421);
            cmbSex.Name = "cmbSex";
            cmbSex.Size = new System.Drawing.Size(209, 28);
            cmbSex.TabIndex = 11;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = System.Drawing.Color.FromArgb(65, 105, 225);
            btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnRegister.ForeColor = System.Drawing.Color.White;
            btnRegister.Location = new System.Drawing.Point(244, 518);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new System.Drawing.Size(169, 45);
            btnRegister.TabIndex = 12;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblBackToLogin
            // 
            lblBackToLogin.AutoSize = true;
            lblBackToLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            lblBackToLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblBackToLogin.Location = new System.Drawing.Point(389, 577);
            lblBackToLogin.Name = "lblBackToLogin";
            lblBackToLogin.Size = new System.Drawing.Size(44, 18);
            lblBackToLogin.TabIndex = 14;
            lblBackToLogin.Text = "Login";
            lblBackToLogin.Click += lblBackToLogin_Click;
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Cursor = System.Windows.Forms.Cursors.Hand;
            lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblText.Location = new System.Drawing.Point(217, 577);
            lblText.Name = "lblText";
            lblText.Size = new System.Drawing.Size(176, 18);
            lblText.TabIndex = 15;
            lblText.Text = "Already have an account?";
            lblText.Click += lblText_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.RoyalBlue;
            label1.Location = new System.Drawing.Point(186, 125);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(313, 42);
            label1.TabIndex = 16;
            label1.Text = "Registration Form";
            // 
            // lblName
            // 
            lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblName.Location = new System.Drawing.Point(150, 191);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(105, 22);
            lblName.TabIndex = 25;
            lblName.Text = "Full Name:";
            // 
            // lblDob
            // 
            lblDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblDob.Location = new System.Drawing.Point(152, 337);
            lblDob.Name = "lblDob";
            lblDob.Size = new System.Drawing.Size(88, 22);
            lblDob.TabIndex = 26;
            lblDob.Text = "D.O.B";
            // 
            // label4
            // 
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(152, 287);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(110, 38);
            label4.TabIndex = 27;
            label4.Text = "Password:";
            // 
            // lblEmail
            // 
            lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblEmail.Location = new System.Drawing.Point(152, 239);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(88, 22);
            lblEmail.TabIndex = 28;
            lblEmail.Text = "Email:";
            // 
            // lblAddress
            // 
            lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblAddress.Location = new System.Drawing.Point(150, 474);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new System.Drawing.Size(88, 22);
            lblAddress.TabIndex = 30;
            lblAddress.Text = "Address:";
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(150, 431);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(88, 22);
            label2.TabIndex = 31;
            label2.Text = "Sex:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(150, 381);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(108, 24);
            label3.TabIndex = 32;
            label3.Text = "Telephone:";
            // 
            // picLogo
            // 
            picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            picLogo.Image = (System.Drawing.Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new System.Drawing.Point(12, 12);
            picLogo.Name = "picLogo";
            picLogo.Size = new System.Drawing.Size(81, 66);
            picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 33;
            picLogo.TabStop = false;
            // 
            // mtbDob
            // 
            mtbDob.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            mtbDob.Location = new System.Drawing.Point(280, 332);
            mtbDob.Mask = "00/00/0000";
            mtbDob.Name = "mtbDob";
            mtbDob.Size = new System.Drawing.Size(209, 27);
            mtbDob.TabIndex = 35;
            mtbDob.ValidatingType = typeof(System.DateTime);
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            ClientSize = new System.Drawing.Size(700, 711);
            Controls.Add(mtbDob);
            Controls.Add(picLogo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblAddress);
            Controls.Add(lblEmail);
            Controls.Add(label4);
            Controls.Add(lblDob);
            Controls.Add(lblName);
            Controls.Add(label1);
            Controls.Add(lblText);
            Controls.Add(lblBackToLogin);
            Controls.Add(btnRegister);
            Controls.Add(cmbSex);
            Controls.Add(txtTelephone);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(txtFullName);
            Name = "RegisterForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.ComboBox cmbSex;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblBackToLogin;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.MaskedTextBox mtbDob;
    }
}