using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
namespace chat
{
    class Connection
    {
        private TcpClient clinte;
        private byte[] buffer;
        public event StringReceivedModler StringReived;
        public delegate void StringReceivedModler(Connection sender, string data);
        private sealed class Packet
        {
            public const int Size = 1400;

            public sealed class Prefix
            {
                public const int length = 4;
            }

        }
        private sealed class Tag
        {
            public const int length = 3;
            public const string STRING = "STR";
        }

        public Connection(TcpClient incomClient)
        {
            clinte = incomClient;
            buffer = new byte[1400];
            read_Packet(Packet.Prefix.length, receive_tag_Prefix);
        }

        public void send_String(string data)
        {
            lock (clinte.GetStream())
            {
                clinte.GetStream().Write(StringToByte(creat_prefix(Tag.length)), 0, Packet.Prefix.length);
                clinte.GetStream().Write(StringToByte(Tag.STRING), 0, Tag.length);
                byte[] data_byte = StringToByte(data);
                clinte.GetStream().Write(StringToByte(creat_prefix(data_byte.Length)), 0, Packet.Prefix.length);
                clinte.GetStream().Write(data_byte, 0, data_byte.Length);
                clinte.GetStream().Flush();
            }
        }
        //دالة الاستقبال Packet 
        public void read_Packet(int incoming_byte_length, AsyncCallback callback)
        {
            lock (clinte.GetStream())
            {
                try
                {
                    clinte.GetStream().BeginRead(buffer, 0, incoming_byte_length, callback, null);
                }
                catch { }
            }
        }

        //دالة الاستخدام
        public void receive_tag_Prefix(IAsyncResult ar)
        {
            int receive_byte_length = 0;
            lock (clinte.GetStream())
            {
                receive_byte_length = clinte.GetStream().EndRead(ar);
            }
            string result = Encoding.UTF8.GetString(buffer, 0, receive_byte_length);
            int PREFIX = Convert.ToInt32(result);
            if (PREFIX == Tag.length)
            {
                read_Packet(PREFIX, receive_tag);
            }
            else
            {
                read_Packet(Packet.Prefix.length, receive_tag_Prefix);
            }
        }

        public void receive_tag(IAsyncResult ar)
        {
            int receive_byte_length = 0;
            lock (clinte.GetStream())
            {
                receive_byte_length = clinte.GetStream().EndRead(ar);
            }
            string result = Encoding.UTF8.GetString(buffer, 0, receive_byte_length);

            switch (result)
            {
                case Tag.STRING:
                    read_Packet(Packet.Prefix.length, receive_STRING_PREFIX);
                    break;

                default:
                    read_Packet(Packet.Prefix.length, receive_tag_Prefix);
                    break;

            }

        }

        private void receive_STRING_PREFIX(IAsyncResult ar)
        {
            int receive_byte_length = 0;
            lock (clinte.GetStream())
            {
                receive_byte_length = clinte.GetStream().EndRead(ar);
            }
            string result = Encoding.UTF8.GetString(buffer, 0, receive_byte_length);
            int PREFIX = Convert.ToInt32(result);
            read_Packet(PREFIX, receive_STRING);
        }

        //دالة إستقبال النص الأصلي
        private void receive_STRING(IAsyncResult ar)
        {
            int receive_byte_length = 0;
            lock (clinte.GetStream())
            {
                receive_byte_length = clinte.GetStream().EndRead(ar);
            }
            string result = Encoding.UTF8.GetString(buffer, 0, receive_byte_length);
            StringReived(this, result);
            //إعادة الإرسال
            read_Packet(Packet.Prefix.length, receive_tag_Prefix);
        }
        public byte[] StringToByte(String text)
        {
            return Encoding.UTF8.GetBytes(text);
        }

        public string creat_prefix(int number)
        {
            string str = number.ToString();
            int diffranc = Packet.Prefix.length - str.Length;
            string zeros = "";
            for (int i = 1; i <= diffranc; i++)
            {
                zeros += "0";
            }
            return zeros + str;

        }
        public string IPAddress
        {
            get
            {
                try
                {
                    IPEndPoint ip = (IPEndPoint)clinte.Client.LocalEndPoint;
                    if (ip != null)
                    {
                        return ip.Address.ToString();
                    }
                    else
                    {
                        return "";
                    }
                }
                catch (Exception ex) { return ""; }
                return "";
            }
        }


        public int PORT
        {
            get
            {
                try
                {
                    IPEndPoint port = (IPEndPoint)clinte.Client.LocalEndPoint;
                    if (port != null)
                    {
                        return port.Port;
                    }
                    else
                    {
                        return 0;
                    }
                }
                catch (Exception ex) { return 0; }
                return 0;
            }
        }

        public string TypeIPAddress
        {
            get
            {
                try
                {
                    IPEndPoint ip = (IPEndPoint)clinte.Client.LocalEndPoint;
                    if (ip != null)
                    {
                        return ip.AddressFamily.ToString();
                    }
                    else
                    {
                        return "";
                    }
                }
                catch (Exception ex) { return ""; }
                return "";
            }
        }

        public void DisConnect()
        {
            clinte.GetStream().Close();
            clinte.Close();
        }

        public bool isConnect
        {
            get { return !(clinte.Client.Poll(1, SelectMode.SelectRead) && clinte.Available == 0); }
        }



    }
}
