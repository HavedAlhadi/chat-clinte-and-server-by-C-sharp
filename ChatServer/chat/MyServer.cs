using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace chat
{
    public partial class Server : BeautyForm 
    {
        //======================================
        TcpListener myListen;
        Thread myThread;                                 //لاستقبال الاتصال القادمة من العميل
        List<Myclintes> myList = new List<Myclintes>();    //لحفظ الاتصالات من أجل التعامل معها
        List<Connection> Client_list = new List<Connection>();
        Thread ChangeClientsLeave;                          //للتحقق من مغادرة العميل
        Clints clint1;                                        // إنشاء كرت للعميل
        bool tagle = false; //  إنشاء مفتاح الاستماع 

        public Server()
        {
            InitializeComponent();
            OpenConected();
            chatHeader1.Cursor = Cursors.Hand;
        }

        public void OpenConected()
        {
            try
            {
                //فتح الاتصال              
                myListen = new TcpListener(IPAddress.Any, 5050);
                myListen.Start();
                //انشاء ثريد لمعالجة دالة استقبال البيانات من العميل
                myThread = new Thread(myAccept);
                myThread.Start();
                MessageBox.Show("تم فتح الاتصال... ");
            }
            catch { MessageBox.Show("خطأ في رقم البورت"); }
        }

        public bool chickIp(string ip)
        {
            foreach (Control i in listClinte.Controls)
            {
                if (i is Clints)
                    if (((Clints)i).Username == ip && ((Clints)i).UserStatus == Status.Online)
                        return true;
            }
            return false;
        }
        Myclintes myClient;
        void myAccept()
        {
            ChangeClientsLeave = new Thread(ChangeLeave);
            ChangeClientsLeave.Start();
            while (true)
            {
                //تعريف عميل جديد
                myClient = new Myclintes(myListen.AcceptSocket(), panelMessages);
                //للتحقق من تكرار الاي بي
                if (chickIp(myClient.IP))
                {
                    myClient.SendMessage("error");
                    myClient = null;
                }
                else
                {
                    if(!MakeClinte(myClient.IP))
                    {
                        myClient.StartTreead(); //بدأ استقبال الرسائل القادمة من العميل
                        //Client_list.Add(Newclinte);
                        myList.Add(myClient);//للتعامل معه (list) اضافة الاتصال الجديد الى                                        
                    }                    
                    myClient.SendMessage("Hi: "+myClient.IP);                    
                }
               
            }
        }

        public bool MakeClinte(string ip)
        {
            if (listClinte.Controls.Count >= 1)
            {
                foreach (Control i in listClinte.Controls)
                {
                    if (i is Clints)
                        if (((Clints)i).Username == ip )
                        {
                            Invoke((Action)(() =>
                            {
                                ((Clints)i).UserStatus = Status.Online;
                                ((Clints)i).StatusMessage = "Online";
                                if (this.chatHeader1.UserTitle == ip)
                                {
                                    this.chatHeader1.UserStatusText = "Online";
                                }
                            }));
                            return true;
                        }
                }
            }
            else
            {
                clint1 = new Clints();
                clint1.Dock = DockStyle.Top;
                clint1.Username = ip;                
                clint1.OnClick += OnUserClick;
                Invoke((Action)(() =>
                {
                    listClinte.Controls.Add(clint1);
                }));
                return false;
            }
            clint1 = new Clints();
            clint1.Dock = DockStyle.Top;
            clint1.Username = ip;
            clint1.OnClick += OnUserClick;
            Invoke((Action)(() =>
            {
                listClinte.Controls.Add(clint1);
            }));
            return false;
        }
        //التحقق من مغادرة العملاء
        void ChangeLeave()
        {
            Thread.Sleep(100);//تقوم بتأخير خيط المعالجة بوقت محدد 
            while (true)
            {
                if (myList.Count > 0)
                {
                    for (int i = 0; i < myList.Count; i++)
                        if (myList[i] != null && !myList[i].Connected)//اذا كان العميل غير متصل
                        {
                            foreach (Control u in listClinte.Controls)
                            {
                                if (u is Clints)
                                {
                                    if (((Clints)u).Username == myList[i].IP)
                                    {
                                        Invoke((Action)(() =>
                                        {
                                            ((Clints)u).UserStatus = Status.Offline;
                                            ((Clints)u).StatusMessage = "Offline";
                                            if (this.chatHeader1.UserTitle == myList[i].IP)
                                            {
                                                this.chatHeader1.UserStatusText = "Offline";
                                            }
                                        }));
                                    }
                                    else
                                    {
                                        Invoke((Action)(() =>
                                        {
                                            ((Clints)u).UserStatus = Status.Online;
                                            ((Clints)u).StatusMessage = "Online";
                                            if (this.chatHeader1.UserTitle == myList[i].IP)
                                            {
                                                this.chatHeader1.UserStatusText = "Online";
                                            }
                                        }));
                                    }
                                }

                            }
                            myList.RemoveAt(i);
                        }
                }
            }
        }

        //Move Form with the mouse. This method is available in BeautyForm that this form inherits
        protected override void OnMouseDownMoveForm(object sender, MouseEventArgs e)
        {
            base.OnMouseDownMoveForm(sender, e);
        }


        private void typingBox1_OnHitEnter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(typingBox1.Value))
            {

                //إرسال الرسالة لأكثر من عميل بشرط أن يكون محدد عليه

                foreach (Clints c in listClinte.Controls)
                {
                    if (c is Clints && c.Chick == true)
                    {
                        for (int i = 0; i < myList.Count; i++)
                            if (c.Username == myList[i].IP)
                            {
                                myList[i].SendMessage(typingBox1.Value);
                                break;
                            }
                    }
                }
                //if (myList.Count>0)
                //for (int i = 0; i < myList.Count; i++)
                //    if (chatHeader1.UserTitle == myList[i].IP)
                //    {
                //        myList[i].SendMessage(typingBox1.Value);
                //        break;
                //    }

                if (listClinte.Controls.Count > 0)
                {
                    MeBubble bubble = new MeBubble();
                    bubble.Dock = DockStyle.Bottom;
                    bubble.SendToBack();
                    bubble.Body = typingBox1.Value;
                    panelMessages.Invoke((Action)(() =>
                    {
                        panelMessages.Controls.Add(bubble);

                    }));
                }
            }
            else MessageBox.Show("ادخل الرسالة");
            typingBox1.Value = "";          

        }

        private void FunRecieving(String Messag)
        {
            YouBubble bubble = new YouBubble();
            bubble.Dock = DockStyle.Bottom;
            bubble.SendToBack();
            bubble.Body = Messag;
            panelMessages.Controls.Add(bubble);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (myListen != null)
                btn_stopConnection_Click(sender, e);            
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void OnUserClick(object sender, EventArgs e)
        {
            var ClickedUser = ((Clints)sender);
            string name = ClickedUser.Username;
            string statusText = ClickedUser.StatusMessage;
            Image profileImage = ClickedUser.UserImage;
            this.chatHeader1.UserTitle = name;
            this.chatHeader1.UserStatusText = statusText;
            this.chatHeader1.UserImage = profileImage;
        }

        private void typingBox1_OnAttachmentClicked(object sender, EventArgs e)
        {
            //OpenFileDialog ofd = new OpenFileDialog();
            //string file;
            //if (ofd.ShowDialog() == DialogResult.OK)
            //{
            //    file = ofd.FileName;

            //    for (int i = 0; i < myList.Count; i++)
            //        if (chatHeader1.UserTitle == myList[i].IP)
            //        {
            //            //myList[i].SendFile(file);

            //            break;
            //        }
            //    // BubImage mbubble = new BubImage();
            //    // mbubble.Dock = DockStyle.Bottom;
            //    //mbubble.Chatimage= Image.FromFile(ofd.FileName);
            //    // this.Invoke((Action)(() =>
            //    // {
            //    //     panelMessages.Controls.Add(mbubble);
            //    // }));
            //    //MessageBox.Show("sdf");
            //}
            MessageBox.Show("تحت التطوير   >_<");
        }

        void btn_stopConnection_Click(object s, EventArgs e)
        {
            myListen.Stop(); //ايقاف التنصت
            myThread.Abort(); //ايقاف استقبال الاتصالات
            ChangeClientsLeave.Abort();

            //اغلاق الاتصالات + حذف الاتصالات
            if (myList.Count > 0)
            {
                for (int i = 0; i < myList.Count; i++)
                       myList[i].Close();//اغلاق الاتصالات  

                //حذف الاتصالات المحفوظة   
                myList.Clear();
            }

        }

      
        private void typingBox1_OnImageAttachmentClicked(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.jpeg; *.png; *.bmp)|*.jpg; *.png; *.bmp";
            string flie=  ofd.FileName;
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                BubImage mbubble = new BubImage();
                mbubble.Dock = DockStyle.Bottom;
                mbubble.Chatimage = Image.FromFile(ofd.FileName);
                this.Invoke((Action)(() =>
                {
                    panelMessages.Controls.Add(mbubble);
                }));             
                //for (int i = 0; i < myList.Count; i++)
                //for (int i = 0; i < myList.Count; i++)
                //    if (chatHeader1.UserTitle == myList[i].IP)
                //    {
                //        myList[i].SendMessage(flie);

                //        break;
                //    }
            }
            MessageBox.Show("تحت التطوير   >_<");
        }

        private void typingBox1_Load(object sender, EventArgs e)
        {

        }
        public bool sendImg(Image img)
        {
            try
            {
                //img 2D -> 1D array of byte[]
                byte[] img_1D = IImage.StreamFromImage(img);
                //send size to server
                //NetworkStream ns = client.GetStream();
                myClient.MySocket = myListen.AcceptSocket();
                NetworkStream ns = new NetworkStream(myClient.MySocket);
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
        private void chatHeader1_OnVideoCallClick(object sender, EventArgs e)
        {
            try { 
            pnl_Video.Visible = true;
            panelMessages.Visible = false;
            myClient.receiveImg(this, received_img);
            }
            catch { }
        }
        public void received_img(Image img)
        {
            pictureBox1.Image = img;
            pictureBox1.Refresh();
            myClient.receiveImg(this, received_img);
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            pnl_Video.Visible = false;
            panelMessages.Visible = true;
        }

        private void chatHeader1_OnCallClick(object sender, EventArgs e)
        {
            if (tagle)
            {
                OpenConected();
                tagle = false;
            }
            else
            {
                btn_stopConnection_Click(sender, e);
                tagle = true;
            }
            OpenConected();
        }

        private void meBubble1_Load(object sender, EventArgs e)
        {

        }
    }
}
