namespace chat
{
    partial class FormVideo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVideo));
            this.pnl_Video = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.youBubble1 = new chat.YouBubble();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.youBubble2 = new chat.YouBubble();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnl_Video.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Video
            // 
            this.pnl_Video.AutoScrollMargin = new System.Drawing.Size(1000, 0);
            this.pnl_Video.AutoSize = true;
            this.pnl_Video.Controls.Add(this.panel1);
            this.pnl_Video.Controls.Add(this.pictureBox1);
            this.pnl_Video.Controls.Add(this.panel4);
            this.pnl_Video.Location = new System.Drawing.Point(0, 0);
            this.pnl_Video.Name = "pnl_Video";
            this.pnl_Video.Size = new System.Drawing.Size(412, 653);
            this.pnl_Video.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.AutoScrollMargin = new System.Drawing.Size(0, 1000);
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.youBubble1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 30);
            this.panel1.TabIndex = 12;
            // 
            // youBubble1
            // 
            this.youBubble1.BackColor = System.Drawing.Color.Transparent;
            this.youBubble1.Body = " This is a sample text message. This is a sample text message. This is a sample t" +
    "ext message. \n\nThis is a sample text message. ";
            this.youBubble1.ChatImageCursor = System.Windows.Forms.Cursors.Default;
            this.youBubble1.ChatTextCursor = System.Windows.Forms.Cursors.IBeam;
            this.youBubble1.Location = new System.Drawing.Point(-816, 134);
            this.youBubble1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.youBubble1.MinimumSize = new System.Drawing.Size(0, 162);
            this.youBubble1.MsgColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.youBubble1.MsgTextColor = System.Drawing.SystemColors.ControlDarkDark;
            this.youBubble1.Name = "youBubble1";
            this.youBubble1.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.youBubble1.Size = new System.Drawing.Size(373, 162);
            this.youBubble1.Status = chat.MessageStatus.Custom;
            this.youBubble1.StatusImage = ((System.Drawing.Image)(resources.GetObject("youBubble1.StatusImage")));
            this.youBubble1.TabIndex = 0;
            this.youBubble1.Time = "";
            this.youBubble1.TimeColor = System.Drawing.Color.White;
            this.youBubble1.UserImage = ((System.Drawing.Image)(resources.GetObject("youBubble1.UserImage")));
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 600);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.AutoScrollMargin = new System.Drawing.Size(0, 1000);
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel4.Controls.Add(this.youBubble2);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 600);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(412, 53);
            this.panel4.TabIndex = 11;
            // 
            // youBubble2
            // 
            this.youBubble2.BackColor = System.Drawing.Color.Transparent;
            this.youBubble2.Body = " This is a sample text message. This is a sample text message. This is a sample t" +
    "ext message. \n\nThis is a sample text message. ";
            this.youBubble2.ChatImageCursor = System.Windows.Forms.Cursors.Default;
            this.youBubble2.ChatTextCursor = System.Windows.Forms.Cursors.IBeam;
            this.youBubble2.Location = new System.Drawing.Point(-816, 134);
            this.youBubble2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.youBubble2.MinimumSize = new System.Drawing.Size(0, 162);
            this.youBubble2.MsgColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.youBubble2.MsgTextColor = System.Drawing.SystemColors.ControlDarkDark;
            this.youBubble2.Name = "youBubble2";
            this.youBubble2.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.youBubble2.Size = new System.Drawing.Size(373, 162);
            this.youBubble2.Status = chat.MessageStatus.Custom;
            this.youBubble2.StatusImage = ((System.Drawing.Image)(resources.GetObject("youBubble2.StatusImage")));
            this.youBubble2.TabIndex = 0;
            this.youBubble2.Time = "";
            this.youBubble2.TimeColor = System.Drawing.Color.White;
            this.youBubble2.UserImage = ((System.Drawing.Image)(resources.GetObject("youBubble2.UserImage")));
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::chat.Properties.Resources.chat;
            this.pictureBox2.Location = new System.Drawing.Point(157, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FormVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 654);
            this.Controls.Add(this.pnl_Video);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVideo";
            this.Text = "Form1";
            this.pnl_Video.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Video;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private YouBubble youBubble2;
        private System.Windows.Forms.Panel panel1;
        private YouBubble youBubble1;
    }
}