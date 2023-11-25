using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace chat
{
    class Myclintes
    {
        Socket mySocket; //بيانات العميل الجديد
        string ip; //عنوان العميل الجديد       
        Thread myThread; //لاستقبال الرسائل من العميل
        Panel container; 
        public bool Connected = false; //للتحقق من اتصال العميل
        //دالة الباني
        public Myclintes(Socket mySoc, Panel p)
        {
            mySocket = mySoc; //استقبال بيانات الاتصال الجديد
            IPEndPoint ipep = (IPEndPoint)mySocket.LocalEndPoint; //لحفظ اي بي العميل الجديد + البورت
            ip = ipep.Address + ""; //لحفظ الاي بي فقط     
            container = p; //ربط الاداة الموجودة في الفورة الرئيسي
        }

        //بدأ استقبال الرسائل
        public void StartTreead()
        {
            Connected = true;
            // ثريد لمعالجة دالة استقبال الرسائل من العميل
            myThread = new Thread(reciveMessage);
            //myThreadFile= new Thread(resiveFile);
            //myThreadFile.Start();
            myThread.Start();
        }
        // استقبال الرسائل

        void reciveMessage1()
        {
            while (true)
            {
                byte[] data = new byte[1024*5000];
                try
                {
                    NetworkStream stream = new NetworkStream(mySocket);
                int bytesRead = stream.Read(data, 0, data.Length);
                if (bytesRead >= 3 && data[0] == 0xFF && data[1] == 0xD8 && data[2] == 0xFF) // Image
                {
                    Image image = Image.FromStream(new MemoryStream(data, 0, bytesRead));
                    imageRecieving(image);
                    MessageBox.Show("done");
                }
                else // Text
                {
                       mySocket.Receive(data);//استقبال البيانات القادمة من العميل (بديلة عن ستريم)0
                        string text = Encoding.UTF8.GetString(data, 0, data.Length);
                        FunRecieving(text);
                    }
                    
                }
                catch
                {
                    Connected = false;
                    return;
                }
            }
        }


        void reciveMessage()
        {
            while (true)
            {
                byte[] data = new byte[1024];
                try
                {                    
                    MySocket.Receive(data);   //استقبال البيانات القادمة من العميل (بديلة عن ستريم)0
                    string text = Encoding.UTF8.GetString(data, 0, data.Length);
                    FunRecieving(text);
                }
                catch
                {
                    Connected = false;
                    return;
                }
            }
        }
        private void FunRecieving(String Messag)
        {
            YouBubble bubble = new YouBubble();
            bubble.Dock = DockStyle.Bottom;
            bubble.SendToBack();
            bubble.Body = Messag;
            container.Invoke((Action)(() =>
            {
                container.Controls.Add(bubble);
            }));            
        }

        private void imageRecieving(Image image)
        {
            BubImage bubble = new BubImage();
            bubble.Dock = DockStyle.Bottom;
            bubble.SendToBack();
            bubble.Chatimage = image; ;
            container.Invoke((Action)(() =>
            {
                container.Controls.Add(bubble);
            }));
        }
        //ارسال رسالة الى العميل
        public void SendMessage(string msg)
        {
            
            byte[] myBuffer = Encoding.UTF8.GetBytes(msg);
            MySocket.Send(myBuffer);
        }

        public void SendFile(byte[] BF)
        {

            MySocket.Send(BF);
            MySocket.Close();
        }
        public void resiveFile()
        {
            while (true)
            {                
                try
                {                   
                    byte[] bf = new byte[1024 * 5000];
                    MySocket.Receive(bf);
                    MemoryStream MS = new MemoryStream(bf);
                    //imageRecieving(MS);
                    MS.Close();
                        //mySocket.Close();                  
                }
                catch
                {
                    //Log("غادر\n");
                    Connected = false;
                    return;
                }                
            }
            MessageBox.Show("sda");

        }

        // اغلاق التدفقات القادمة من العميل
        public void Close()
        {           
            MySocket.Close();
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
                NetworkStream ns = new NetworkStream(MySocket);
                byte[] size_buffer = new byte[4];
                ns.Read(size_buffer, 0, size_buffer.Length);
                int img_size = BitConverter.ToInt32(size_buffer, 0);

                byte[] img_1D = new byte[img_size];
                MemoryStream fs = new MemoryStream(img_1D);

                byte[] buffer = new byte[1024];
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
        //تغليف الاي بي
        public string IP
        {
            get { return ip; }
        }
        public Socket MySocket { get => mySocket; set => mySocket = value; }
    }
}
