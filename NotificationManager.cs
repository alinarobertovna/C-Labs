using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_301249589_Fadeeva_
{
    public partial class NotificationManager : Form
    {
        public NotificationManager()
        {
            InitializeComponent();

            if (Publisher.sendViaEmail != null || Publisher.sendViaMobile != null)
            {
                PublishSub_btn.Enabled = true;
            }
            else
            {
                PublishSub_btn.Enabled = false;
            }
        }

        private void ManageSub_btn_Click(object sender, EventArgs e)
        {
            Manage_Subscription mainForm = new Manage_Subscription();
            this.Hide();
            mainForm.ShowDialog();
            this.Close();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PublishSub_btn_Click(object sender, EventArgs e)
        {
            PublishNotification mainForm = new PublishNotification();
            this.Hide();
            mainForm.ShowDialog();
            this.Close();
        }
    }
}
