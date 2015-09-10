using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace UDPMSN
{
    public partial class Form1 : Form
    {
        Thread[] LTh=new Thread[10];
        UdpClient UC;
        string[][] userip = new string[10][];
        string[] myports = new string[10];
        int usercount = 0;
        int portcount =0;
        public Form1()
        {
            InitializeComponent();
        }
        private void B_GO_Click(object sender, EventArgs e)
        {
            B_GO.Click -= B_GO_Click;
            B_GO.Click += B_GO_SEND;
            for (int i = 0; i < portcount;i++ )
            {
                LTh[i] = new Thread(listen);
                LTh[i].Start(i);
            }

                
            B_GO.Text = "傳送訊息";
            text_myport.ReadOnly = true;
            text_yourip.ReadOnly = true;
            text_yourport.ReadOnly = true;
            msg.Focus();

        }
        private void B_GO_SEND(object sender, EventArgs e)
        {
            UdpClient S = new UdpClient();
            byte[] B = Encoding.Default.GetBytes(msg.Text);
            S.Send(B, B.Length, text_yourip.Text, int.Parse(text_yourport.Text));
            text_msg.Text += "我說：" + Environment.NewLine + msg.Text + Environment.NewLine;
            msg.Text = "";
            S.Close();
        }
        private void listen(object arg)
        {
            int i = Convert.ToInt32(arg);
            int port = int.Parse(text_myport.Text);
            UC = new UdpClient(port);
            IPEndPoint EP = new IPEndPoint(IPAddress.Parse(text_myip.Text), port);
            while (true)
            {
                byte[] B = UC.Receive(ref EP);
                text_msg.Text += "對方說：" + Environment.NewLine + Encoding.Default.GetString(B) + Environment.NewLine;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                UC.Close();
                LTh.Abort();
            }
            catch
            {

            }
        }
        private String MYIP()
        {
            string hn = Dns.GetHostName();
            IPAddress[] ips = Dns.GetHostEntry(hn).AddressList;
            foreach (IPAddress it in ips)
            {
                if (it.AddressFamily == AddressFamily.InterNetwork)
                {
                    return it.ToString();
                }
            }
            return "127.0.0.1";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            text_myip.Text = MYIP();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void text_msg_TextChanged(object sender, EventArgs e)
        {
            text_msg.SelectionStart = text_msg.Text.Length;
            text_msg.ScrollToCaret();
        }

        private void new_user_Click(object sender, EventArgs e)
        {
            userip[usercount]=new string[2]{text_yourip.Text,text_yourport.Text};
            usercount++;
            user_online.Items.Clear();
            user_online.Items.Add("和你聊天的人：(上限十人)");
            for(int i=0;i<usercount;i++)
            {
                user_online.Items.Add(userip[i][0] + ":" + userip[i][1]);
            }
        }

        private void new_port_Click(object sender, EventArgs e)
        {
            myports[portcount] = text_myport.Text;
            portcount++;
            port_listen.Items.Clear();
            port_listen.Items.Add("監聽中的Port(上限十個)");
            for (int i = 0; i < portcount; i++)
            {
                port_listen.Items.Add(myports[i]);
            }
        }
    }
}
