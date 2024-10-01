using System;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace LogIn_form
{
    public partial class YozoLogInForm : Form
    {
        public YozoLogInForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            // Assume ValidateCredentials() checks the username and password
            if (ValidateCredentials(txtBoxUsername.Text, txtBoxPassword.Text))
            {
                // If credentials are valid, show the MainForm
                MainForm mainForm = new MainForm();
                mainForm.Show();

                // Hide the Login Form (or close it)
                this.Hide(); // or this.Close();
            }
            else
            {
                MessageBox.Show("Invalid credentials, please try again.");
            }
        }

        private bool ValidateCredentials(string username, string password)
        {
            // Your validation logic here
            return username == "admin" && password == "password"; // Example
        }


        private void YozoLogInForm_Load(object sender, EventArgs e)
        {

        }
        
        private void logIn_Click(object sender, EventArgs e)
        {

        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
            {
                txtBoxPassword.UseSystemPasswordChar = false;
            }
            else txtBoxPassword.UseSystemPasswordChar = true;
            
        }

        private void PanelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
