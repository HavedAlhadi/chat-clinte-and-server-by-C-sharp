using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Shaping;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;


namespace chat
{
    public partial class Form_myClint : BeautyForm //Inherited from Beauty, which a custom form.
    {
        ////////
        TcpClient myClient;
        Connection NewClient;
        List<Connection> client_list = new List<Connection>();
        Thread myThread;
        bool tagle=true;     
        private string ip ;
        private int port;
        public Form_myClint(string Ip, int Port)
        {
            ip = Ip;
            port = Port;
            InitializeComponent();
            conected();
            panelMessages.AutoScroll = false;
            panelMessages.HorizontalScroll.Enabled = false;
            panelMessages.HorizontalScroll.Maximum = 0;
            panelMessages.AutoScroll = true;
        }
         public void conected()
        {
            try
            {
                myClient = new TcpClient(ip, port);
                byte[] buffer = new byte[100];
                myClient.GetStream().Read(buffer, 0, buffer.Length);
                string msg = Encoding.UTF8.GetString(buffer);
                if (msg == "error")
                {
                    MessageBox.Show("يرجى استخدام عنوان مختلف");
                    myClient = null;
                }
                else
                {
                    myThread = new Thread(reciveMessage);
                    myThread.Start();                    
                }
                FunRecieving(Encoding.UTF8.GetString(buffer, 0, buffer.Length));
            }
            catch {
                //MessageBox.Show("لا يوجد إتصال بالخادم");
            }
            
        }

        void reciveMessage()
        {
            while (true)
            {
                byte[] data = new byte[1024];
                try
                {
                    myClient.GetStream().Read(data, 0, data.Length);
                    this.Invoke((Action)(() =>
                    {
                        FunRecieving(Encoding.UTF8.GetString(data, 0, data.Length));
                    }));
                }
                catch
                {
                    DisConnected();
                    return;
                }
            }
        }
        /*private void imageRecieving(Image image)
        {
            BubImage bubble = new BubImage();
            bubble.Dock = DockStyle.Bottom;
            bubble.SendToBack();
            bubble.Chatimage = image; 
            panelMessages.Controls.Add(bubble);
        }*/
        //Move Form with the mouse. This method is available in BeautyForm that this form inherits
        protected override void OnMouseDownMoveForm(object sender, MouseEventArgs e)
        {
            base.OnMouseDownMoveForm(sender, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void typingBox1_OnHitEnter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(typingBox1.Value))
            {
                MeBubble bubble = new MeBubble();
                bubble.SendToBack();//Send back so that it will be lowest control... Use bubble.BringToFront() if u r docking up.               
                bubble.Body = typingBox1.Value;
                bubble.Dock = DockStyle.Bottom;
                panelMessages.Controls.Add(bubble);
                byte[] myBuffer = Encoding.UTF8.GetBytes(typingBox1.Value);//تحويل النص الى بايتات لارساله عبر الشبكة
                try { 
                myClient.GetStream().Write(myBuffer, 0, myBuffer.Length); //لارسال البيانات الى السيرفر (بديلة عن ستريم)0
                }
                catch { MessageBox.Show("لا يوجد إتصال بالخادم"); }
                    typingBox1.Value = "";
                
            }
        }


        void DisConnected()
        {
            try
            {
                myThread.Abort();
                myClient.Client.Close();
                myClient.Close();

            }
            catch { }
        }
        private void FunRecieving(String Messang)
        {
            YouBubble bubble = new YouBubble();
            bubble.Dock = DockStyle.Bottom;
            bubble.SendToBack();
            bubble.Body = Messang;
            panelMessages.Invoke((Action)(() =>
            {
                panelMessages.Controls.Add(bubble);

            }));
            
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            DisConnected();
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void OnUserClick(object sender, EventArgs e)
        {
            var ClickedUser = ((Users)sender);

            string name = ClickedUser.Username;
            string statusText = ClickedUser.StatusMessage;
            Image profileImage = ClickedUser.UserImage;

            this.chatHeader1.UserTitle = name;
            this.chatHeader1.UserStatusText = statusText;
            this.chatHeader1.UserImage = profileImage;
        }

        private void typingBox1_OnAttachmentClicked(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.jpeg; *.png; *.bmp)|*.jpg; *.png; *.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                BubImage mbubble = new BubImage();
                mbubble.Dock = DockStyle.Bottom;
               mbubble.Chatimage= Image.FromFile(ofd.FileName);
               panelMessages.Controls.Add(mbubble);
                            }
        }

        private void typingBox1_OnAttachmentClicked_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string file;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                file = ofd.FileName;
                FileStream fs = new FileStream(file, FileMode.Open);
                byte[] buffer = new byte[1024];
                int read_by = 0;
                NetworkStream ns =myClient.GetStream();
                while ((read_by = fs.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ns.Write(buffer, 0, read_by);
                    ns.Read(buffer, 0, 1);
                    if (buffer[0] != 1)
                        break;

                }
                fs.Close();
                ns.Close();
                myClient.Close();     
            }
        }

        private void typingBox1_OnImageAttachmentClicked(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.jpeg; *.png; *.bmp)|*.jpg; *.png; *.bmp";
            string flie=ofd.FileName;
            BubImage mbubble;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                mbubble = new BubImage();
                mbubble.Dock = DockStyle.Bottom;
                mbubble.Chatimage= Image.FromFile(ofd.FileName);
                //byte[] myBuffer = Encoding.UTF8.GetBytes(flie);
                //NetworkStream myStream = myClient.GetStream();
                //BinaryWriter myWrite = new BinaryWriter(myStream);
                ////حفظ الصورة الى قناة اتصال الذاكرة
                //MemoryStream ms = new MemoryStream();
                //mbubble.Chatimage.Save(ms, mbubble.Chatimage.RawFormat);
                //myWrite.Write(ms.GetBuffer()); //ارسال الصورة على شكل بايتات
                //                               //تهيئة واغلاق التدفقات
                //ms.Flush(); ms.Close(); myWrite.Close(); myStream.Close();              
                panelMessages.Controls.Add(mbubble);
            }
            MessageBox.Show("تحت التطوير   >_<");
        }

        IWebCam webCam = null;
        private void chatHeader1_OnVideoCallClick(object sender, EventArgs e)
        {
            panelMessages.Visible = false; 
            pnl_Video.Visible = true;                        
            if (webCam == null)
            {
                webCam = new IWebCam(this.Handle);
                timer1.Start();
            }
        }
     
        private void timer1_Tick(object sender, EventArgs e)
        {
            Image img = webCam.iWebCam_Image;
            if (img != null)
            {
                pictureBox1.Image = img;
                //sendImg(img);
                return;
            }
        }

        public bool sendImg(Image img)
        {
            try
            {                
                //img 2D -> 1D array of byte[]
                byte[] img_1D = IImage.StreamFromImage(img);
                //send size to server
                NetworkStream ns = myClient.GetStream();
                byte[] size_of_img = BitConverter.GetBytes(img_1D.Length);//int -> 4byte
                ns.Write(size_of_img, 0, size_of_img.Length);
                //FileStream -> NetworkStream
                MemoryStream fs = new MemoryStream(img_1D);
                byte[] buffer = new byte[1024];
                int readbytes = 0;
                while ((readbytes = fs.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ns.Write(buffer, 0, readbytes);
                    ns.Read(buffer, 0, 1);
                    MessageBox.Show("HERE");
                    if (buffer[0] != 1)
                        break;
                }
                fs.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public delegate void pointer_to_funcation2(Image img);
        public void receiveImg(Form main, pointer_to_funcation2 f)
        {
            //Call Thread
            Thread t2 = new Thread(receiveImg2);
            t2.Start(new object[2] { main, f });//call the thread+params
        }

        private void receiveImg2(object obj)
        {
            //Thread Function
            object[] objs = (object[])obj;
            Form main = (Form)objs[0];
            pointer_to_funcation2 f = (pointer_to_funcation2)objs[1];
            try
            {
                NetworkStream ns = myClient.GetStream();
                byte[] size_buffer = new byte[4];
                ns.Read(size_buffer, 0, size_buffer.Length);
                int img_size = BitConverter.ToInt32(size_buffer, 0);

                byte[] img_1D = new byte[img_size];
                MemoryStream fs = new MemoryStream(img_1D);

                byte[] buffer = new byte[1400];
                int readbytes = 0;
                while (img_size > 0)
                {
                    readbytes = ns.Read(buffer, 0, buffer.Length);
                    img_size -= readbytes;
                    fs.Write(buffer, 0, readbytes);
                    buffer[0] = 1;
                    ns.Write(buffer, 0, 1);//msg to server [cont]
                }
                fs.Close();
                Image img = IImage.ImageFromStream(img_1D);
                main.Invoke(f, img);
            }
            catch
            {
                return;
            }
        }
        private void chatHeader1_OnConectClick(object sender, EventArgs e)
        {
            if (tagle)
            {
                conected();
                tagle = false;
            }
            else
            {
                DisConnected();
                tagle = true;
            }
        }
        
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            pnl_Video.Visible = false;
            panelMessages.Visible = true;
        }

        private void chatHeader1_Load(object sender, EventArgs e)
        {

        }
    }
}
