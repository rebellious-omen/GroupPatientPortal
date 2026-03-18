namespace GroupPatientPortal
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            txtPassword = new System.Windows.Forms.TextBox();
            btnSignIn = new System.Windows.Forms.Button();
            lblTitle = new System.Windows.Forms.Label();
            lblSubtitle = new System.Windows.Forms.Label();
            lblEmail = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            lblPassword = new System.Windows.Forms.Label();
            lblSignUp = new System.Windows.Forms.Label();
            picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtPassword.Location = new System.Drawing.Point(296, 321);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(182, 26);
            txtPassword.TabIndex = 0;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = System.Drawing.Color.FromArgb(65, 105, 225);
            btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSignIn.ForeColor = System.Drawing.Color.White;
            btnSignIn.Location = new System.Drawing.Point(270, 368);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new System.Drawing.Size(124, 50);
            btnSignIn.TabIndex = 2;
            btnSignIn.Text = "Sign in";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            lblTitle.Location = new System.Drawing.Point(221, 192);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(223, 37);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Patient Portal";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = System.Drawing.Color.RoyalBlue;
            lblSubtitle.Location = new System.Drawing.Point(204, 229);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new System.Drawing.Size(255, 20);
            lblSubtitle.TabIndex = 4;
            lblSubtitle.Text = "Appointment Management System";
            // 
            // lblEmail
            // 
            lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblEmail.Location = new System.Drawing.Point(157, 276);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(133, 23);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email Address:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtEmail.Location = new System.Drawing.Point(296, 273);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(182, 26);
            txtEmail.TabIndex = 7;
            // 
            // lblPassword
            // 
            lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblPassword.Location = new System.Drawing.Point(157, 324);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(105, 36);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password:";
            // 
            // lblSignUp
            // 
            lblSignUp.AutoSize = true;
            lblSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            lblSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblSignUp.Location = new System.Drawing.Point(257, 425);
            lblSignUp.Name = "lblSignUp";
            lblSignUp.Size = new System.Drawing.Size(150, 18);
            lblSignUp.TabIndex = 9;
            lblSignUp.Text = "No Account? Sign Up";
            lblSignUp.Click += lblSignUp_Click;
            // 
            // picLogo
            // 
            picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            picLogo.Image = (System.Drawing.Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new System.Drawing.Point(12, 12);
            picLogo.Name = "picLogo";
            picLogo.Size = new System.Drawing.Size(81, 66);
            picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 10;
            picLogo.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            ClientSize = new System.Drawing.Size(700, 711);
            Controls.Add(picLogo);
            Controls.Add(lblSignUp);
            Controls.Add(lblPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Controls.Add(btnSignIn);
            Controls.Add(txtPassword);
            Name = "LoginForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.PictureBox picLogo;
    }
}