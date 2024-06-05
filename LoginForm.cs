using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bcrypt = BCrypt.Net.BCrypt;

namespace SmartFreshHouse
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void RgisterBtn_Click(object sender, EventArgs e)
        {
            new RegisterForm().Show();
            this.Hide();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(LoginEmailTextBox.Text == "" || LoginPasswordTextBox.Text == "") 
            {
                MessageBox.Show("Both email and password is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var db = new SmartFreshHouseEntities())
            {
                var user = db.Users.SingleOrDefault(u => u.Email == LoginEmailTextBox.Text);
                if (user == null) {
                    MessageBox.Show("user not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if(user != null)
                {
                    bool verified = Bcrypt.Verify(LoginPasswordTextBox.Text, user.Password);

                    if (verified)
                    {
                        this.Hide();
                        DashboardForm dash = new DashboardForm();
                        dash.Show();
                    }
                    else
                    {
                        MessageBox.Show("Email or password is wrong","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }

                }

            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ResetPasswordBtn_Click(object sender, EventArgs e)
        {
            new ResetPasswordForm().Show();
        }
    }
}
