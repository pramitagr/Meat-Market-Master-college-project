using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bcrypt =  BCrypt.Net.BCrypt;

namespace SmartFreshHouse
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterUserBtn_Click(object sender, EventArgs e)
        {
            using(var db = new SmartFreshHouseEntities())
            {
                var user = new User();

                string hashedPassword = Bcrypt.HashPassword(PasswordText.Text);

                user.FullName = FullNameText.Text;
                user.Email = EmailText.Text;
                user.Password = hashedPassword;
                user.CreatedAt = DateTime.Now;
               
                db.Users.Add(user);
                db.SaveChanges();

                MessageBox.Show($"User: {user.FullName} is Created Successfully");
                this.Close();
                LoginForm login = new LoginForm();
                login.Show();

            }
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            new LoginForm().Show();
        }
    }
}
