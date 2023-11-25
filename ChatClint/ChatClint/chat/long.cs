using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace chat
{
    public partial class Formlong : Form
    {
        TcpClient myClient;

        public Formlong()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Form_myClint f;
        private void button1_Click(object sender, EventArgs e)
        {
            conected();


        }

        public void conected()
        {
            try
            {
                if (txt_ip.Text != "" && txt_port.Text != "")
                {
                    // قم بفحص توفر الخادم باستخدام Ping
                    Ping ping = new Ping();
                    PingReply reply = ping.Send(txt_ip.Text);
                    if (reply.Status == IPStatus.Success)
                    {
                        // إذا كان الخادم متوفرًا، قم بإنشاء العميل وعرض النافذة الجديدة
                        //myClient = new TcpClient(txt_ip.Text, Convert.ToInt32(txt_port.Text));
                        f = new Form_myClint(txt_ip.Text, Convert.ToInt32(txt_port.Text));
                        f.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("الخادم غير متوفر");
                    }
                }
                else
                {
                    MessageBox.Show("لا يمكن أن يكون البورت أو الآي بي فارغين!");
                }
            }
            catch
            {
                MessageBox.Show("لا يوجد اتصال بالخادم");
            }

        }

    }
}