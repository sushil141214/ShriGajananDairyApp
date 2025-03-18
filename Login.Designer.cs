namespace ShriGajananDairy
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            btnLogin = new Button();
            btnUserCreate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(449, 103);
            label1.Name = "label1";
            label1.Size = new Size(108, 28);
            label1.TabIndex = 0;
            label1.Text = "User Name";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 12F);
            txtUserName.Location = new Point(666, 103);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(187, 34);
            txtUserName.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(666, 182);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(187, 34);
            txtPassword.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(449, 182);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogin.Location = new Point(742, 283);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(111, 53);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnUserCreate
            // 
            btnUserCreate.Font = new Font("Segoe UI", 8F);
            btnUserCreate.Location = new Point(449, 286);
            btnUserCreate.Name = "btnUserCreate";
            btnUserCreate.Size = new Size(251, 53);
            btnUserCreate.TabIndex = 5;
            btnUserCreate.Text = "Not Registered? Create an account ";
            btnUserCreate.UseVisualStyleBackColor = true;
            btnUserCreate.Click += btnUserCreate_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 598);
            Controls.Add(btnUserCreate);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUserName);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label label2;
        private Button btnLogin;
        private Button btnUserCreate;
    }
}
