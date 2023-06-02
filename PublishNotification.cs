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
    public partial class PublishNotification : Form
    {
        public PublishNotification()
        {
            InitializeComponent();
            var subscribers = new List<string>();

            if (Publisher.sendViaEmail != null)
            {
                subscribers.AddRange(Publisher.sendViaEmail);
            }
            if (Publisher.sendViaMobile != null)
            {
                subscribers.AddRange(Publisher.sendViaMobile);
            }

            subscribers_list.DataSource = subscribers;
        }
        private void publish_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Notifications Sent!");
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Manage_Subscription mainForm = new Manage_Subscription();
            this.Hide();
            mainForm.ShowDialog();
            this.Close();
        }
    }
}
