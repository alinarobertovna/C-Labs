namespace Lab2_301249589_Fadeeva_
{
    partial class Manage_Subscription
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.email_txt = new System.Windows.Forms.TextBox();
            this.Email_check = new System.Windows.Forms.CheckBox();
            this.SMS_check = new System.Windows.Forms.CheckBox();
            this.SMS_txt = new System.Windows.Forms.TextBox();
            this.Subscribe_btn = new System.Windows.Forms.Button();
            this.Unsubscribe_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.error_msg_lbl = new System.Windows.Forms.Label();
            this.error_msg2_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(367, 62);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(220, 20);
            this.email_txt.TabIndex = 0;
            this.email_txt.TextChanged += new System.EventHandler(this.email_txt_TextChanged);
            // 
            // Email_check
            // 
            this.Email_check.AutoSize = true;
            this.Email_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_check.Location = new System.Drawing.Point(141, 59);
            this.Email_check.Name = "Email_check";
            this.Email_check.Size = new System.Drawing.Size(208, 24);
            this.Email_check.TabIndex = 1;
            this.Email_check.Text = "Notification Sent by Email";
            this.Email_check.UseVisualStyleBackColor = true;
            this.Email_check.CheckedChanged += new System.EventHandler(this.Email_check_CheckedChanged);
            // 
            // SMS_check
            // 
            this.SMS_check.AutoSize = true;
            this.SMS_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMS_check.Location = new System.Drawing.Point(141, 128);
            this.SMS_check.Name = "SMS_check";
            this.SMS_check.Size = new System.Drawing.Size(204, 24);
            this.SMS_check.TabIndex = 2;
            this.SMS_check.Text = "Notification Sent by SMS";
            this.SMS_check.UseVisualStyleBackColor = true;
            this.SMS_check.CheckedChanged += new System.EventHandler(this.SMS_check_CheckedChanged);
            // 
            // SMS_txt
            // 
            this.SMS_txt.Location = new System.Drawing.Point(367, 131);
            this.SMS_txt.Name = "SMS_txt";
            this.SMS_txt.Size = new System.Drawing.Size(220, 20);
            this.SMS_txt.TabIndex = 3;
            this.SMS_txt.TextChanged += new System.EventHandler(this.SMS_txt_TextChanged);
            this.SMS_txt.MouseEnter += new System.EventHandler(this.SMS_txt_MouseEnter);
            this.SMS_txt.MouseLeave += new System.EventHandler(this.SMS_txt_MouseLeave);
            // 
            // Subscribe_btn
            // 
            this.Subscribe_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subscribe_btn.Location = new System.Drawing.Point(103, 226);
            this.Subscribe_btn.Name = "Subscribe_btn";
            this.Subscribe_btn.Size = new System.Drawing.Size(166, 49);
            this.Subscribe_btn.TabIndex = 4;
            this.Subscribe_btn.Text = "Subscribe";
            this.Subscribe_btn.UseVisualStyleBackColor = true;
            this.Subscribe_btn.Click += new System.EventHandler(this.Subscribe_btn_Click);
            // 
            // Unsubscribe_btn
            // 
            this.Unsubscribe_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unsubscribe_btn.Location = new System.Drawing.Point(309, 226);
            this.Unsubscribe_btn.Name = "Unsubscribe_btn";
            this.Unsubscribe_btn.Size = new System.Drawing.Size(166, 49);
            this.Unsubscribe_btn.TabIndex = 5;
            this.Unsubscribe_btn.Text = "Unsubscribe";
            this.Unsubscribe_btn.UseVisualStyleBackColor = true;
            this.Unsubscribe_btn.Click += new System.EventHandler(this.Unsubscribe_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.Location = new System.Drawing.Point(539, 226);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(166, 49);
            this.cancel_btn.TabIndex = 6;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // error_msg_lbl
            // 
            this.error_msg_lbl.AutoSize = true;
            this.error_msg_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_msg_lbl.ForeColor = System.Drawing.Color.Red;
            this.error_msg_lbl.Location = new System.Drawing.Point(419, 94);
            this.error_msg_lbl.Name = "error_msg_lbl";
            this.error_msg_lbl.Size = new System.Drawing.Size(107, 13);
            this.error_msg_lbl.TabIndex = 7;
            this.error_msg_lbl.Text = "Invalid Email Address";
            this.error_msg_lbl.Visible = false;
            // 
            // error_msg2_lbl
            // 
            this.error_msg2_lbl.AutoSize = true;
            this.error_msg2_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_msg2_lbl.ForeColor = System.Drawing.Color.Red;
            this.error_msg2_lbl.Location = new System.Drawing.Point(419, 172);
            this.error_msg2_lbl.Name = "error_msg2_lbl";
            this.error_msg2_lbl.Size = new System.Drawing.Size(112, 13);
            this.error_msg2_lbl.TabIndex = 8;
            this.error_msg2_lbl.Text = "Invalid Phone Number";
            this.error_msg2_lbl.Visible = false;
            // 
            // Manage_Subscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 313);
            this.Controls.Add(this.error_msg2_lbl);
            this.Controls.Add(this.error_msg_lbl);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.Unsubscribe_btn);
            this.Controls.Add(this.Subscribe_btn);
            this.Controls.Add(this.SMS_txt);
            this.Controls.Add(this.SMS_check);
            this.Controls.Add(this.Email_check);
            this.Controls.Add(this.email_txt);
            this.Name = "Manage_Subscription";
            this.Text = "Manage_Subscription";
            this.Load += new System.EventHandler(this.Manage_Subscription_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.CheckBox Email_check;
        private System.Windows.Forms.CheckBox SMS_check;
        private System.Windows.Forms.TextBox SMS_txt;
        private System.Windows.Forms.Button Subscribe_btn;
        private System.Windows.Forms.Button Unsubscribe_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label error_msg_lbl;
        private System.Windows.Forms.Label error_msg2_lbl;
    }
}