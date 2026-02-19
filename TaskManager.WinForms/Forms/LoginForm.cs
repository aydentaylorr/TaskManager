using TaskManager.WinForms.Services;
using TaskManager.Models.DTOs;
using TaskManager.WinForms.Forms;

namespace TaskManager.WinForms
{
    public partial class LoginForm : Form
    {
        private readonly AuthApiService _authService = new AuthApiService();
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter email and password.");
                return;
            }

            var dto = new LoginDto
            {
                Email = txtEmail.Text,
                Password = txtPassword.Text
            };

            var userId = await _authService.LoginAsync(dto);

            if (userId != null)
            {
                MessageBox.Show("Login successful!");

                MainForm main = new MainForm(userId.Value);
                main.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid login details.");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();
            this.Hide();
        }
    }
}
