namespace ShriGajananDairy
{
    partial class Registration
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
            lblFirstName = new Label();
            textBox1 = new TextBox();
            txtLastName = new TextBox();
            lblLastName = new Label();
            textBox3 = new TextBox();
            lblEmail = new Label();
            txtMobileNumber = new TextBox();
            lblMobileNumber = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUserNamr = new TextBox();
            lblUsername = new Label();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 12F);
            lblFirstName.Location = new Point(60, 79);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(106, 28);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(230, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(192, 34);
            textBox1.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 12F);
            txtLastName.Location = new Point(715, 73);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(216, 34);
            txtLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 12F);
            lblLastName.Location = new Point(543, 79);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(103, 28);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.Location = new Point(715, 156);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(216, 34);
            textBox3.TabIndex = 7;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F);
            lblEmail.Location = new Point(543, 162);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(59, 28);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // txtMobileNumber
            // 
            txtMobileNumber.Font = new Font("Segoe UI", 12F);
            txtMobileNumber.Location = new Point(230, 153);
            txtMobileNumber.Name = "txtMobileNumber";
            txtMobileNumber.Size = new Size(192, 34);
            txtMobileNumber.TabIndex = 5;
            // 
            // lblMobileNumber
            // 
            lblMobileNumber.AutoSize = true;
            lblMobileNumber.Font = new Font("Segoe UI", 12F);
            lblMobileNumber.Location = new Point(60, 162);
            lblMobileNumber.Name = "lblMobileNumber";
            lblMobileNumber.Size = new Size(151, 28);
            lblMobileNumber.TabIndex = 4;
            lblMobileNumber.Text = "Mobile Number";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(715, 245);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(216, 34);
            txtPassword.TabIndex = 11;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F);
            lblPassword.Location = new Point(543, 251);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(93, 28);
            lblPassword.TabIndex = 10;
            lblPassword.Text = "Password";
            // 
            // txtUserNamr
            // 
            txtUserNamr.Font = new Font("Segoe UI", 12F);
            txtUserNamr.Location = new Point(230, 242);
            txtUserNamr.Name = "txtUserNamr";
            txtUserNamr.Size = new Size(192, 34);
            txtUserNamr.TabIndex = 9;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F);
            lblUsername.Location = new Point(60, 251);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(108, 28);
            lblUsername.TabIndex = 8;
            lblUsername.Text = "User Name";
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 529);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUserNamr);
            Controls.Add(lblUsername);
            Controls.Add(textBox3);
            Controls.Add(lblEmail);
            Controls.Add(txtMobileNumber);
            Controls.Add(lblMobileNumber);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(textBox1);
            Controls.Add(lblFirstName);
            Name = "Registration";
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private TextBox textBox1;
        private TextBox txtLastName;
        private Label lblLastName;
        private TextBox textBox3;
        private Label lblEmail;
        private TextBox txtMobileNumber;
        private Label lblMobileNumber;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtUserNamr;
        private Label lblUsername;
    }
}