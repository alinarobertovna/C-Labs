namespace Lab2_301249589_Fadeeva_
{
    partial class NotificationManager
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
            this.ManageSub_btn = new System.Windows.Forms.Button();
            this.PublishSub_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ManageSub_btn
            // 
            this.ManageSub_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageSub_btn.Location = new System.Drawing.Point(84, 96);
            this.ManageSub_btn.Name = "ManageSub_btn";
            this.ManageSub_btn.Size = new System.Drawing.Size(166, 55);
            this.ManageSub_btn.TabIndex = 0;
            this.ManageSub_btn.Text = "Manage Subscription";
            this.ManageSub_btn.UseVisualStyleBackColor = true;
            this.ManageSub_btn.Click += new System.EventHandler(this.ManageSub_btn_Click);
            // 
            // PublishSub_btn
            // 
            this.PublishSub_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublishSub_btn.Location = new System.Drawing.Point(307, 96);
            this.PublishSub_btn.Name = "PublishSub_btn";
            this.PublishSub_btn.Size = new System.Drawing.Size(166, 55);
            this.PublishSub_btn.TabIndex = 1;
            this.PublishSub_btn.Text = "Publish Subscription";
            this.PublishSub_btn.UseVisualStyleBackColor = true;
            this.PublishSub_btn.Click += new System.EventHandler(this.PublishSub_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.Location = new System.Drawing.Point(548, 86);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(189, 75);
            this.exit_btn.TabIndex = 2;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // NotificationManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 250);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.PublishSub_btn);
            this.Controls.Add(this.ManageSub_btn);
            this.Name = "NotificationManager";
            this.Text = "Notification Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ManageSub_btn;
        private System.Windows.Forms.Button PublishSub_btn;
        private System.Windows.Forms.Button exit_btn;
    }
}

