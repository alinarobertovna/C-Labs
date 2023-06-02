using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_301249589_Fadeeva_
{
    public partial class Manage_Subscription : Form
    {
        public Manage_Subscription()
        {
            InitializeComponent();
            
        }

        private void Email_check_CheckedChanged(object sender, EventArgs e)
        {
            email_txt.Enabled = Email_check.Checked;
            SMS_txt.Enabled = !Email_check.Checked;

            if (Email_check.Checked)
            {
                SMS_check.Checked = false;
            }
        }

        private void SMS_check_CheckedChanged(object sender, EventArgs e)
        {
            SMS_txt.Enabled = SMS_check.Checked;
            email_txt.Enabled = !SMS_check.Checked;

            if (SMS_check.Checked)
            {
                Email_check.Checked = false;
            }
        }

        private void email_txt_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$");

            if (regex.IsMatch(email_txt.Text))
            {
                error_msg_lbl.Visible = false;
                Subscribe_btn.Enabled = true;
                Unsubscribe_btn.Enabled = true;
            }
            else
            {
                error_msg_lbl.Visible = true;
                Subscribe_btn.Enabled = false;
                Unsubscribe_btn.Enabled = false;
            }
        }

        private void SMS_txt_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^^(?<code>\+?\d{1,3})[-\s]{0,}(?<number>\(?\d{3}\)?[-\s]{0,}\d{3}[-\s]{0,}\d{2}[-\s]{0,}\d{2})$");

            if (regex.IsMatch(SMS_txt.Text))
            {
                error_msg2_lbl.Visible = false;
                Subscribe_btn.Enabled = true;
                Unsubscribe_btn.Enabled = true;
            }
            else
            {
                error_msg2_lbl.Visible = true;
                Subscribe_btn.Enabled = false;
                Unsubscribe_btn.Enabled = false;
            }

            if (SMS_txt.Text == "+1-xxx-xxx-xx-xx" || SMS_txt.Text == null)
            {
                error_msg2_lbl.Visible = false;
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            NotificationManager mainForm = new NotificationManager();
            this.Hide();
            mainForm.ShowDialog();
            this.Close();
        }

        private void Subscribe_btn_Click(object sender, EventArgs e)
        {
            
            if (Email_check.Checked)
            {
                if (Publisher.sendViaEmail == null)
                {
                    Publisher.sendViaEmail = new List<string>();
                }
                if (!Publisher.sendViaEmail.Contains(email_txt.Text))
                {
                    Publisher.sendViaEmail.Add(email_txt.Text);
                }
                else
                {
                    MessageBox.Show("This email has already been subscribed!"); 
                    Subscribe_btn.Enabled = false;
                }
            }

            
            if (SMS_check.Checked)
            {
                if (Publisher.sendViaMobile == null)
                {
                    Publisher.sendViaMobile = new List<string>();
                }
                if (!Publisher.sendViaMobile.Contains(SMS_txt.Text))
                {
                    Publisher.sendViaMobile.Add(SMS_txt.Text);               
                }
                else
                {
                    MessageBox.Show("This phone number has already been subscribed!");
                    Subscribe_btn.Enabled = false;
                }
            }

            PublishNotification mainForm = new PublishNotification();
            this.Hide();
            mainForm.ShowDialog();
            this.Close();
        }

        private void Unsubscribe_btn_Click(object sender, EventArgs e)
        {
            if (Email_check.Checked)
            {
                if (email_txt.Text != null && Publisher.sendViaEmail.Contains(email_txt.Text))
                    {
                        Publisher.sendViaEmail.Remove(email_txt.Text);
                    }
            }
            if (SMS_check.Checked)
            {
                if (SMS_txt.Text != null && Publisher.sendViaMobile.Contains(SMS_txt.Text))
                {
                    Publisher.sendViaMobile.Remove(SMS_txt.Text);
                }
            }
            MessageBox.Show("Sorry to see you go...");
            PublishNotification mainForm = new PublishNotification();
            this.Hide();
            mainForm.ShowDialog();
            this.Close();
        }

        private void SMS_txt_MouseEnter(object sender, EventArgs e)
        {
            if (SMS_txt.Text == "+1-xxx-xxx-xx-xx")
            {
                SMS_txt.Text = "";
                SMS_txt.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void SMS_txt_MouseLeave(object sender, EventArgs e)
        {
            if (SMS_txt.Text == "")
            {
                SMS_txt.Text = "+1-xxx-xxx-xx-xx";
                SMS_txt.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void Manage_Subscription_Load(object sender, EventArgs e)
        {
            SMS_txt.Text = "+1-xxx-xxx-xx-xx";
            SMS_txt.ForeColor = System.Drawing.Color.Gray;
        }
    }
}