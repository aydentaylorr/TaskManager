namespace TaskManager.WinForms.Forms
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
            pnlCenter = new Panel();
            lblCreateAccount = new Label();
            firstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            textBox1 = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblPasswordConfirmation = new Label();
            txtPasswordConfirmation = new TextBox();
            btnRegister = new Button();
            btnBack = new Button();
            pnlCenter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCenter
            // 
            pnlCenter.Controls.Add(btnBack);
            pnlCenter.Controls.Add(btnRegister);
            pnlCenter.Controls.Add(txtPasswordConfirmation);
            pnlCenter.Controls.Add(lblPasswordConfirmation);
            pnlCenter.Controls.Add(txtPassword);
            pnlCenter.Controls.Add(lblPassword);
            pnlCenter.Controls.Add(txtEmail);
            pnlCenter.Controls.Add(lblEmail);
            pnlCenter.Controls.Add(textBox1);
            pnlCenter.Controls.Add(lblLastName);
            pnlCenter.Controls.Add(txtFirstName);
            pnlCenter.Controls.Add(firstName);
            pnlCenter.Controls.Add(lblCreateAccount);
            pnlCenter.Location = new Point(186, 41);
            pnlCenter.Name = "pnlCenter";
            pnlCenter.Size = new Size(400, 518);
            pnlCenter.TabIndex = 0;
            // 
            // lblCreateAccount
            // 
            lblCreateAccount.AutoSize = true;
            lblCreateAccount.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreateAccount.Location = new Point(73, 18);
            lblCreateAccount.Name = "lblCreateAccount";
            lblCreateAccount.Size = new Size(248, 45);
            lblCreateAccount.TabIndex = 0;
            lblCreateAccount.Text = "Create Account";
            // 
            // firstName
            // 
            firstName.AutoSize = true;
            firstName.Location = new Point(27, 82);
            firstName.Name = "firstName";
            firstName.Size = new Size(97, 25);
            firstName.TabIndex = 1;
            firstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(31, 108);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(333, 31);
            txtFirstName.TabIndex = 2;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(27, 153);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(95, 25);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "Last Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(31, 181);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(333, 31);
            textBox1.TabIndex = 4;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(27, 226);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 25);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(31, 254);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(333, 31);
            txtEmail.TabIndex = 6;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(27, 299);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 25);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(31, 327);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(333, 31);
            txtPassword.TabIndex = 8;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPasswordConfirmation
            // 
            lblPasswordConfirmation.AutoSize = true;
            lblPasswordConfirmation.Location = new Point(27, 375);
            lblPasswordConfirmation.Name = "lblPasswordConfirmation";
            lblPasswordConfirmation.Size = new Size(196, 25);
            lblPasswordConfirmation.TabIndex = 9;
            lblPasswordConfirmation.Text = "Password Confirmation";
            // 
            // txtPasswordConfirmation
            // 
            txtPasswordConfirmation.Location = new Point(31, 403);
            txtPasswordConfirmation.Name = "txtPasswordConfirmation";
            txtPasswordConfirmation.Size = new Size(333, 31);
            txtPasswordConfirmation.TabIndex = 10;
            txtPasswordConfirmation.UseSystemPasswordChar = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(73, 455);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(112, 34);
            btnRegister.TabIndex = 11;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(207, 455);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(135, 34);
            btnBack.TabIndex = 12;
            btnBack.Text = "Back to Login";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 604);
            Controls.Add(pnlCenter);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            pnlCenter.ResumeLayout(false);
            pnlCenter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCenter;
        private Label lblCreateAccount;
        private Label lblLastName;
        private TextBox txtFirstName;
        private Label firstName;
        private Label lblPasswordConfirmation;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox textBox1;
        private TextBox txtPasswordConfirmation;
        private Button btnBack;
        private Button btnRegister;
    }
}