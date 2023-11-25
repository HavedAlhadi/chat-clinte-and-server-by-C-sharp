namespace chat
{
    partial class Server
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.paneltxtsend = new System.Windows.Forms.Panel();
            this.typingBox1 = new chat.TypingBox();
            this.pnl_Video = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.youBubble2 = new chat.YouBubble();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.youBubble3 = new chat.YouBubble();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelMessages = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.youBubble4 = new chat.YouBubble();
            this.meBubble1 = new chat.MeBubble();
            this.youBubble1 = new chat.YouBubble();
            this.label3 = new System.Windows.Forms.Label();
            this.listClinte = new System.Windows.Forms.Panel();
            this.searchBox1 = new chat.SearchBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chatHeader1 = new chat.ChatHeader();
            this.panel1.SuspendLayout();
            this.paneltxtsend.SuspendLayout();
            this.pnl_Video.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelMessages.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 24);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDownMoveForm);
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(562, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 11);
            this.label2.Size = new System.Drawing.Size(35, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "__";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(597, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label1.Size = new System.Drawing.Size(35, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // paneltxtsend
            // 
            this.paneltxtsend.Controls.Add(this.typingBox1);
            this.paneltxtsend.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paneltxtsend.Location = new System.Drawing.Point(3, 690);
            this.paneltxtsend.Name = "paneltxtsend";
            this.paneltxtsend.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.paneltxtsend.Size = new System.Drawing.Size(632, 51);
            this.paneltxtsend.TabIndex = 3;
            // 
            // typingBox1
            // 
            this.typingBox1.AutoSize = true;
            this.typingBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.typingBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typingBox1.Location = new System.Drawing.Point(5, 0);
            this.typingBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.typingBox1.Name = "typingBox1";
            this.typingBox1.Size = new System.Drawing.Size(622, 46);
            this.typingBox1.TabIndex = 0;
            this.typingBox1.Value = "  إكتب هنا..";
            this.typingBox1.OnAttachmentClicked += new chat.TypingBox.AttachmentClicked(this.typingBox1_OnAttachmentClicked);
            this.typingBox1.OnHitEnter += new chat.TypingBox.HitEnter(this.typingBox1_OnHitEnter);
            this.typingBox1.OnImageAttachmentClicked += new chat.TypingBox.imageClicked(this.typingBox1_OnImageAttachmentClicked);
            // 
            // pnl_Video
            // 
            this.pnl_Video.AutoScrollMargin = new System.Drawing.Size(1000, 0);
            this.pnl_Video.AutoSize = true;
            this.pnl_Video.Controls.Add(this.panel3);
            this.pnl_Video.Controls.Add(this.pictureBox1);
            this.pnl_Video.Controls.Add(this.panel4);
            this.pnl_Video.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Video.Location = new System.Drawing.Point(312, 80);
            this.pnl_Video.Name = "pnl_Video";
            this.pnl_Video.Size = new System.Drawing.Size(323, 610);
            this.pnl_Video.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.AutoScrollMargin = new System.Drawing.Size(0, 1000);
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel3.Controls.Add(this.youBubble2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(323, 30);
            this.panel3.TabIndex = 12;
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
            this.youBubble2.MinimumSize = new System.Drawing.Size(0, 204);
            this.youBubble2.MsgColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.youBubble2.MsgTextColor = System.Drawing.SystemColors.ControlDarkDark;
            this.youBubble2.Name = "youBubble2";
            this.youBubble2.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.youBubble2.Size = new System.Drawing.Size(373, 204);
            this.youBubble2.Status = chat.MessageStatus.Read;
            this.youBubble2.StatusImage = ((System.Drawing.Image)(resources.GetObject("youBubble2.StatusImage")));
            this.youBubble2.TabIndex = 0;
            this.youBubble2.Time = "";
            this.youBubble2.TimeColor = System.Drawing.Color.White;
            this.youBubble2.UserImage = ((System.Drawing.Image)(resources.GetObject("youBubble2.UserImage")));
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 557);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.AutoScrollMargin = new System.Drawing.Size(0, 1000);
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel4.Controls.Add(this.youBubble3);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 557);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(323, 53);
            this.panel4.TabIndex = 11;
            // 
            // youBubble3
            // 
            this.youBubble3.BackColor = System.Drawing.Color.Transparent;
            this.youBubble3.Body = " This is a sample text message. This is a sample text message. This is a sample t" +
    "ext message. \n\nThis is a sample text message. ";
            this.youBubble3.ChatImageCursor = System.Windows.Forms.Cursors.Default;
            this.youBubble3.ChatTextCursor = System.Windows.Forms.Cursors.IBeam;
            this.youBubble3.Location = new System.Drawing.Point(-816, 134);
            this.youBubble3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.youBubble3.MinimumSize = new System.Drawing.Size(0, 204);
            this.youBubble3.MsgColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.youBubble3.MsgTextColor = System.Drawing.SystemColors.ControlDarkDark;
            this.youBubble3.Name = "youBubble3";
            this.youBubble3.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.youBubble3.Size = new System.Drawing.Size(373, 204);
            this.youBubble3.Status = chat.MessageStatus.Read;
            this.youBubble3.StatusImage = ((System.Drawing.Image)(resources.GetObject("youBubble3.StatusImage")));
            this.youBubble3.TabIndex = 0;
            this.youBubble3.Time = "";
            this.youBubble3.TimeColor = System.Drawing.Color.White;
            this.youBubble3.UserImage = ((System.Drawing.Image)(resources.GetObject("youBubble3.UserImage")));
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::chat.Properties.Resources.chat;
            this.pictureBox2.Location = new System.Drawing.Point(176, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // panelMessages
            // 
            this.panelMessages.AutoScroll = true;
            this.panelMessages.AutoScrollMargin = new System.Drawing.Size(1000, 0);
            this.panelMessages.AutoSize = true;
            this.panelMessages.Controls.Add(this.panel5);
            this.panelMessages.Controls.Add(this.meBubble1);
            this.panelMessages.Controls.Add(this.youBubble1);
            this.panelMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMessages.Location = new System.Drawing.Point(312, 80);
            this.panelMessages.Name = "panelMessages";
            this.panelMessages.Size = new System.Drawing.Size(323, 610);
            this.panelMessages.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.AutoScrollMargin = new System.Drawing.Size(0, 1000);
            this.panel5.Controls.Add(this.youBubble4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(323, 11);
            this.panel5.TabIndex = 8;
            // 
            // youBubble4
            // 
            this.youBubble4.BackColor = System.Drawing.Color.Transparent;
            this.youBubble4.Body = " This is a sample text message. This is a sample text message. This is a sample t" +
    "ext message. \n\nThis is a sample text message. ";
            this.youBubble4.ChatImageCursor = System.Windows.Forms.Cursors.Default;
            this.youBubble4.ChatTextCursor = System.Windows.Forms.Cursors.IBeam;
            this.youBubble4.Location = new System.Drawing.Point(-816, 134);
            this.youBubble4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.youBubble4.MinimumSize = new System.Drawing.Size(0, 204);
            this.youBubble4.MsgColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.youBubble4.MsgTextColor = System.Drawing.SystemColors.ControlDarkDark;
            this.youBubble4.Name = "youBubble4";
            this.youBubble4.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.youBubble4.Size = new System.Drawing.Size(373, 204);
            this.youBubble4.Status = chat.MessageStatus.Read;
            this.youBubble4.StatusImage = ((System.Drawing.Image)(resources.GetObject("youBubble4.StatusImage")));
            this.youBubble4.TabIndex = 0;
            this.youBubble4.Time = "";
            this.youBubble4.TimeColor = System.Drawing.Color.White;
            this.youBubble4.UserImage = ((System.Drawing.Image)(resources.GetObject("youBubble4.UserImage")));
            // 
            // meBubble1
            // 
            this.meBubble1.AutoSize = true;
            this.meBubble1.BackColor = System.Drawing.Color.Transparent;
            this.meBubble1.Body = "مرحبا بك في الشات التجريبي ...";
            this.meBubble1.ChatImageCursor = System.Windows.Forms.Cursors.Default;
            this.meBubble1.ChatTextCursor = System.Windows.Forms.Cursors.IBeam;
            this.meBubble1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.meBubble1.Location = new System.Drawing.Point(0, 468);
            this.meBubble1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.meBubble1.MinimumSize = new System.Drawing.Size(0, 71);
            this.meBubble1.MsgColor = System.Drawing.Color.DodgerBlue;
            this.meBubble1.MsgTextColor = System.Drawing.SystemColors.ControlLightLight;
            this.meBubble1.Name = "meBubble1";
            this.meBubble1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.meBubble1.Size = new System.Drawing.Size(323, 71);
            this.meBubble1.Status = chat.MessageStatus.Delivered;
            this.meBubble1.StatusImage = ((System.Drawing.Image)(resources.GetObject("meBubble1.StatusImage")));
            this.meBubble1.TabIndex = 4;
            this.meBubble1.Time = "11:52 PM";
            this.meBubble1.TimeColor = System.Drawing.Color.White;
            this.meBubble1.UserImage = ((System.Drawing.Image)(resources.GetObject("meBubble1.UserImage")));
            this.meBubble1.Load += new System.EventHandler(this.meBubble1_Load);
            // 
            // youBubble1
            // 
            this.youBubble1.BackColor = System.Drawing.Color.Transparent;
            this.youBubble1.Body = "Welcom to this chat......";
            this.youBubble1.ChatImageCursor = System.Windows.Forms.Cursors.Default;
            this.youBubble1.ChatTextCursor = System.Windows.Forms.Cursors.IBeam;
            this.youBubble1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.youBubble1.Location = new System.Drawing.Point(0, 539);
            this.youBubble1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.youBubble1.MinimumSize = new System.Drawing.Size(0, 71);
            this.youBubble1.MsgColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.youBubble1.MsgTextColor = System.Drawing.SystemColors.ControlDarkDark;
            this.youBubble1.Name = "youBubble1";
            this.youBubble1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.youBubble1.Size = new System.Drawing.Size(323, 71);
            this.youBubble1.Status = chat.MessageStatus.Read;
            this.youBubble1.StatusImage = ((System.Drawing.Image)(resources.GetObject("youBubble1.StatusImage")));
            this.youBubble1.TabIndex = 1;
            this.youBubble1.Time = "11:46 PM";
            this.youBubble1.TimeColor = System.Drawing.Color.White;
            this.youBubble1.UserImage = global::chat.Properties.Resources._2_32;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Cairo", 14.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(2, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label3.Size = new System.Drawing.Size(305, 42);
            this.label3.TabIndex = 0;
            this.label3.Text = "العملاء";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listClinte
            // 
            this.listClinte.Dock = System.Windows.Forms.DockStyle.Top;
            this.listClinte.Location = new System.Drawing.Point(2, 42);
            this.listClinte.Name = "listClinte";
            this.listClinte.Padding = new System.Windows.Forms.Padding(0, 5, 0, 10);
            this.listClinte.Size = new System.Drawing.Size(305, 578);
            this.listClinte.TabIndex = 1;
            // 
            // searchBox1
            // 
            this.searchBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.searchBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searchBox1.FocusedColor = System.Drawing.Color.WhiteSmoke;
            this.searchBox1.Location = new System.Drawing.Point(2, 576);
            this.searchBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchBox1.Name = "searchBox1";
            this.searchBox1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.searchBox1.Size = new System.Drawing.Size(305, 29);
            this.searchBox1.TabIndex = 2;
            this.searchBox1.TextColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.searchBox1.UnFocusedColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.searchBox1.Value = "Search...";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.searchBox1);
            this.panel2.Controls.Add(this.listClinte);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(3, 80);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(2, 0, 2, 5);
            this.panel2.Size = new System.Drawing.Size(309, 610);
            this.panel2.TabIndex = 11;
            // 
            // chatHeader1
            // 
            this.chatHeader1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.chatHeader1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.chatHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.chatHeader1.Location = new System.Drawing.Point(3, 27);
            this.chatHeader1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chatHeader1.Name = "chatHeader1";
            this.chatHeader1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.chatHeader1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chatHeader1.Size = new System.Drawing.Size(632, 53);
            this.chatHeader1.TabIndex = 10;
            this.chatHeader1.UserImage = global::chat.Properties.Resources._3_32;
            this.chatHeader1.UserStatusText = "Online";
            this.chatHeader1.UserTitle = "Haved";
            this.chatHeader1.UseWaitCursor = true;
            this.chatHeader1.OnVideoCallClick += new chat.ChatHeader.VideoCallClick(this.chatHeader1_OnVideoCallClick);
            this.chatHeader1.OnCallClick += new chat.ChatHeader.CallClick(this.chatHeader1_OnCallClick);
            // 
            // Server
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(638, 744);
            this.Controls.Add(this.panelMessages);
            this.Controls.Add(this.pnl_Video);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chatHeader1);
            this.Controls.Add(this.paneltxtsend);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Server";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.paneltxtsend.ResumeLayout(false);
            this.paneltxtsend.PerformLayout();
            this.pnl_Video.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelMessages.ResumeLayout(false);
            this.panelMessages.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel paneltxtsend;
        private TypingBox typingBox1;
        private System.Windows.Forms.Panel pnl_Video;
        private System.Windows.Forms.Panel panel3;
        private YouBubble youBubble2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private YouBubble youBubble3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelMessages;
        private MeBubble meBubble1;
        private YouBubble youBubble1;
        private System.Windows.Forms.Panel panel5;
        private YouBubble youBubble4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel listClinte;
        private SearchBox searchBox1;
        private System.Windows.Forms.Panel panel2;
        private ChatHeader chatHeader1;
    }
}