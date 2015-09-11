using System;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
namespace server
{
    public partial class Form1 : Form
    {
        TcpListener server;
        Socket clinet;
        Thread thserver;
        Thread thclinet;
        Hashtable ht = new Hashtable();
        Socket adms;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            myip.Text = MYIP();
        }

        private void B_GO_Click(object sender, EventArgs e)
        {
            B_GO.Enabled = false;
            myip.Enabled = false;
            myport.Enabled = false;
            thserver = new Thread(listen);
            thserver.IsBackground = true;
            thserver.Start();
        }
        private void listen()
        {
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(myip.Text), int.Parse(myport.Text));
            server = new TcpListener(ep);
            server.Start();
            while (true)
            {
                clinet = server.AcceptSocket();
                thclinet = new Thread(clilisten);
                thclinet.IsBackground = true;
                thclinet.Start();
            }
        }
        private void clilisten()
        {
            Socket s = clinet;
            Thread th = thclinet;
            while (true)
            {
                try
                {
                    byte[] B = new byte[1024];
                    int length = s.Receive(B);
                    String msg = Encoding.Default.GetString(B, 0, length);
                    char cmd = msg[0];
                    String text = msg.Substring(1);
                    switch (cmd)
                    {
                        case '0':
                            if (ht.ContainsKey(text))
                            {
                                byte[] B1 = Encoding.Default.GetBytes("-1");
                                s.Send(B1, 0, B1.Length, SocketFlags.None);
                            }
                            else
                            {
                                if (text.Substring(0, 5) == "admin")
                                {
                                    adms = s;
                                }
                                else
                                {
                                    ht.Add(text, s);
                                    onlineuser.Items.Add(text);
                                }
                                BCast(UserList());
                            }
                            break;
                        case '1':
                            isfake(text, s);
                            msg = cmd + text.Substring(1);
                            BCast(msg);
                            break;
                        case '9':
                            ht.Remove(text);
                            onlineuser.Items.Remove(text);
                            BCast(UserList());
                            th.Abort();
                            break;
                        default:
                            isfake(text, s);
                            text = text.Substring(1);
                            string[] C = text.Split('|');
                            sendto(cmd + C[0], C[1]);
                            break;
                    }
                }
                catch
                {

                }
            }
        }
        private void isfake(string text, Socket s)
        {
            if (text[0] == 'F')
            {
                byte[] B1 = Encoding.Default.GetBytes("S伺服器通知：請勿以他人身分發言");
                s.Send(B1, 0, B1.Length, SocketFlags.None);
                try
                {
                    B1 = Encoding.Default.GetBytes("S以下內容遭到假冒發言");
                    adms.Send(B1, 0, B1.Length, SocketFlags.None);
                }
                catch
                {

                }
            }
        }
        private void BCast(string msg)
        {
            byte[] B = Encoding.Default.GetBytes(msg);
            foreach (Socket user in ht.Values)
            {
                user.Send(B, 0, B.Length, SocketFlags.None);
            }
            try
            {
                adms.Send(B, 0, B.Length, SocketFlags.None);
            }
            catch
            {

            }
        }
        private void sendto(string msg, string user)
        {
            byte[] B = Encoding.Default.GetBytes(msg);
            ((Socket)ht[user]).Send(B, 0, B.Length, SocketFlags.None);
            try
            {
                adms.Send(B, 0, B.Length, SocketFlags.None);
            }
            catch
            {

            }

        }
        private String UserList()
        {
            String l = "";
            foreach (string i in onlineuser.Items)
            {
                l += "," + i;
            }
            l = "L" + l.Substring(1);
            return l;
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
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                adms.Close();
            }
            catch
            { }
            Application.ExitThread();
        }
    }
}
