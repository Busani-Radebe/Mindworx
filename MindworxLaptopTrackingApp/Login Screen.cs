using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;

namespace MindworxLaptopTrackingApp
{
    public partial class Login_Screen : Form
    {
        public Login_Screen()
        {
            InitializeComponent();

        }

        private void Login_Screen_Load(object sender, EventArgs e)
        {

        }

        private void panelLoginScreen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabelForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Forgot password functionality is not implemented yet.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            // Dummy login logic for demonstration
            if (username == "admin" && password == "password")
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Create and show the main form (Form1)
                selfieCapturePage mainForm = new selfieCapturePage();
                mainForm.Show();

                // Close the login screen
                this.Hide();

                // Proceed to next screen or dashboard
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
