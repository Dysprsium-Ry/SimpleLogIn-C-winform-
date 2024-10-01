using System;
using System.Windows.Forms;

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

        private void YozoLogInForm_Load(object sender, EventArgs e)
        {

        }
        
        private void logIn_Click(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
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
