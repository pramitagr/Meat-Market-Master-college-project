using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Bcrypt = BCrypt.Net.BCrypt;

using MailKit.Net.Smtp;
using MimeKit;
using Org.BouncyCastle.Cms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SmartFreshHouse
{
    public partial class ResetPasswordForm : Form
    {
        string GPassword = "qurq tpoc uhhr dkzh";
        public ResetPasswordForm()
        {
            InitializeComponent();
        }

        private void SendPasswordBtn_Click(object sender, EventArgs e)
        {
            string userEmail = UserEmailText.Text.Trim();

            using (var db = new SmartFreshHouseEntities())
            {
                var user = db.Users.SingleOrDefault(u => u.Email == userEmail);

                if (user != null)
                {
                    Random rand = new Random();
                    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                    var NewPassword = new string(Enumerable.Repeat(chars, 8)
                        .Select(s => s[rand.Next(s.Length)]).ToArray());


                    // Email sender and recipient details
                    string fromAddress = "pramitagrgotame75@gmail.com";
                    string toAddress = UserEmailText.Text.Trim();
                    string subject = "Password Reset - Meat Master";
                    string body = "You new password is as below\n Password : " + NewPassword;

                    // SMTP server details
                    string smtpServer = "smtp.gmail.com";
                    int smtpPort = 587;
                    string smtpUser = "pramitagrgotame75@gmail.com";
                    string smtpPass = GPassword;

                    //Create message
                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress("Meat Master", fromAddress));
                    message.To.Add(new MailboxAddress("", toAddress));
                    message.Subject = subject;

                    // Create the body of the email
                    message.Body = new TextPart("plain")
                    {
                        Text = body
                    };

                    // Use SmtpClient to send the email
                    using (var client = new SmtpClient())
                    {
                        try
                        {
                            SendPasswordBtn.Enabled = false;
                            SendPasswordBtn.Text = "Wait..";
                            // Connect to the SMTP server
                            client.Connect(smtpServer, smtpPort, MailKit.Security.SecureSocketOptions.StartTls);
                            // Authenticate with the SMTP server
                            client.Authenticate(smtpUser, smtpPass);

                            // Send the email
                            client.Send(message);

                            user.Password = Bcrypt.HashPassword(NewPassword);
                            db.Users.AddOrUpdate(user);
                            db.SaveChanges();

                            MessageBox.Show("New password is sent to your email.\n please cheack your email", "Check your email", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Failed to send email: {ex.Message}");
                        }
                        finally
                        {
                            client.Disconnect(true);
                            SendPasswordBtn.Enabled = true;
                            SendPasswordBtn.Text = "Submit";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No such email address found\ntry with registered email", "User not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
    }
}
