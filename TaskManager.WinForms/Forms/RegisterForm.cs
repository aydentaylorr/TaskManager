using System;
using System.Windows.Forms;
using TaskManager.Models.DTOs;
using TaskManager.WinForms.Services;

namespace TaskManager.WinForms.Forms
{
    public partial class RegisterForm : Form
    {
        private readonly AuthApiService _authService;
        public RegisterForm()
        {
            InitializeComponent();
            _authService = new AuthApiService();
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtPasswordConfirmation.Text)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }

            var dto = new RegisterUserDto
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text
            };

            bool success = await _authService.RegisterAsync(dto);

            if (success)
            {
                MessageBox.Show("Account created!");
                LoginForm login = new LoginForm();
                login.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Registration failed.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }
    }
}
