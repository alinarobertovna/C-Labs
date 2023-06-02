namespace Lab2_301249589_Fadeeva_
{
    partial class PublishNotification
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
            this.content_lbl = new System.Windows.Forms.Label();
            this.content_txt = new System.Windows.Forms.TextBox();
            this.publish_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.subscribers_list = new System.Windows.Forms.ListBox();
            this.list = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // content_lbl
            // 
            this.content_lbl.AutoSize = true;
            this.content_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.content_lbl.Location = new System.Drawing.Point(118, 56);
            this.content_lbl.Name = "content_lbl";
            this.content_lbl.Size = new System.Drawing.Size(149, 20);
            this.content_lbl.TabIndex = 0;
            this.content_lbl.Text = "Notification Content";
            // 
            // content_txt
            // 
            this.content_txt.Location = new System.Drawing.Point(322, 56);
            this.content_txt.Name = "content_txt";
            this.content_txt.Size = new System.Drawing.Size(206, 20);
            this.content_txt.TabIndex = 1;
            // 
            // publish_btn
            // 
            this.publish_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publish_btn.Location = new System.Drawing.Point(137, 281);
            this.publish_btn.Name = "publish_btn";
            this.publish_btn.Size = new System.Drawing.Size(130, 46);
            this.publish_btn.TabIndex = 2;
            this.publish_btn.Text = "Publish";
            this.publish_btn.UseVisualStyleBackColor = true;
            this.publish_btn.Click += new System.EventHandler(this.publish_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.Location = new System.Drawing.Point(385, 281);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(130, 46);
            this.exit_btn.TabIndex = 3;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // subscribers_list
            // 
            this.subscribers_list.FormattingEnabled = true;
            this.subscribers_list.Location = new System.Drawing.Point(217, 151);
            this.subscribers_list.Name = "subscribers_list";
            this.subscribers_list.Size = new System.Drawing.Size(225, 95);
            this.subscribers_list.TabIndex = 4;
            // 
            // list
            // 
            this.list.AutoSize = true;
            this.list.Location = new System.Drawing.Point(205, 116);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(248, 13);
            this.list.TabIndex = 5;
            this.list.Text = "Notification will be sent to the following subscribers:";
            // 
            // PublishNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 386);
            this.Controls.Add(this.list);
            this.Controls.Add(this.subscribers_list);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.publish_btn);
            this.Controls.Add(this.content_txt);
            this.Controls.Add(this.content_lbl);
            this.Name = "PublishNotification";
            this.Text = "PublishNotification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label content_lbl;
        private System.Windows.Forms.TextBox content_txt;
        private System.Windows.Forms.Button publish_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.ListBox subscribers_list;
        private System.Windows.Forms.Label list;
    }
}