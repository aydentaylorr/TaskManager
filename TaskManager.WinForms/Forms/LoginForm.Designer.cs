namespace TaskManager.WinForms
{
    partial class LoginForm
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
            pnlCenter = new Panel();
            lblTitle = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            lblEmail = new Label();
            lblPassword = new Label();
            btnLogin = new Button();
            btnRegister = new Button();
            pnlCenter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCenter
            // 
            pnlCenter.Anchor = AnchorStyles.None;
            pnlCenter.BorderStyle = BorderStyle.FixedSingle;
            pnlCenter.Controls.Add(btnRegister);
            pnlCenter.Controls.Add(btnLogin);
            pnlCenter.Controls.Add(lblPassword);
            pnlCenter.Controls.Add(lblEmail);
            pnlCenter.Controls.Add(txtPassword);
            pnlCenter.Controls.Add(txtEmail);
            pnlCenter.Controls.Add(lblTitle);
            pnlCenter.Location = new Point(227, 103);
            pnlCenter.Name = "pnlCenter";
            pnlCenter.Size = new Size(350, 300);
            pnlCenter.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(122, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(104, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Login";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(15, 100);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(320, 31);
            txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(15, 173);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(320, 31);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(15, 72);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 25);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(15, 145);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 25);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(55, 222);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(190, 222);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(112, 34);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(pnlCenter);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            pnlCenter.ResumeLayout(false);
            pnlCenter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCenter;
        private Label lblTitle;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Button btnRegister;
        private Button btnLogin;
        private Label lblPassword;
        private Label lblEmail;
    }
}
