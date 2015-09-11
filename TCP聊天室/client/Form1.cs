using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace client
{
    public partial class Form1 : Form
    {
        Socket T;
        Thread th;
        string user;
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        private void login_Click(object sender, EventArgs e)
        {
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(serverip.Text), int.Parse(serverport.Text));
            T = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            user = myname.Text + "(" + MYIP() + ")";
            try
            {
                T.Connect(ep);
                login.Text = "登出";
                login.Click -= login_Click;
                login.Click += logout_Click;
                th = new Thread(listen);
                th.IsBackground = true;
                th.Start();
                send("0" + user);
                msgbox.Text += "已連線到" + serverip.Text + ":" + serverport.Text + "\r\n";
            }
            catch (Exception ex)
            {
                msgbox.Text += "發生錯誤：" + ex.Message + "\r\n";
                return;
            }
        }
        private void logout_Click(object sender, EventArgs e)
        {
            logout();
            login.Text = "登入";
            login.Click -= logout_Click;
            login.Click += login_Click;
        }
        private void send(String s)
        {
            Byte[] B = Encoding.Default.GetBytes(s);
            T.Send(B, 0, B.Length, SocketFlags.None);
        }
        private void logout()
        {
            try
            {
                send("9" + myname.Text + "(" + MYIP() + ")");
                T.Close();
                msgbox.Text += "與伺服器連線中斷\r\n";
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
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (login.Text == "登出")
            {
                logout();
            }
        }


        private void B_SEND_Click(object sender, EventArgs e)
        {
            string suser;
            if (sendmsg.Text == "") return;
            if (myid.SelectedIndex != 0)
            {
                suser = "F" + myid.SelectedItem.ToString().Substring(4);
                msgbox.Text += "你正" + myid.SelectedItem.ToString() + "發送訊息\r\n";
            }
            else
            {
                suser = "T" + user;
            }
            if (onlineuser.SelectedIndex < 0)
            {
                send("1" + suser + "：\r\n" + sendmsg.Text);
            }
            else
            {
                send("2" + suser + "：\r\n" + sendmsg.Text + "|" + onlineuser.SelectedItem);
                msgbox.Text += "你密" + onlineuser.SelectedItem + "說：\r\n" + sendmsg.Text + "\r\n";
            }
            sendmsg.Text = "";
        }

        private void BC_CheckedChanged(object sender, EventArgs e)
        {
            onlineuser.SelectedIndexChanged -= onlineuser_SelectedIndexChanged;
            onlineuser.ClearSelected();
            onlineuser.SelectedIndexChanged += onlineuser_SelectedIndexChanged;
        }

        private void onlineuser_SelectedIndexChanged(object sender, EventArgs e)
        {
            BC.CheckedChanged -= BC_CheckedChanged;
            BC.Checked = false;
            BC.CheckedChanged += BC_CheckedChanged;
        }
        private void listen()
        {
            EndPoint ep = (EndPoint)T.RemoteEndPoint;
            Byte[] B = new Byte[1024];
            int inlenth = 0;
            string msg;
            char cmd;
            string str;
            while (true)
            {
                try
                {
                    inlenth = T.ReceiveFrom(B, ref ep);
                }
                catch
                {
                    T.Close();
                    onlineuser.Items.Clear();
                    try
                    {
                        logout();
                        th.Abort();
                    }
                    catch
                    {

                    }
                }
                msg = Encoding.Default.GetString(B, 0, inlenth);
                cmd = msg[0];
                str = msg.Substring(1);
                switch (cmd)
                {
                    case 'L':
                        onlineuser.Items.Clear();
                        myid.Items.Clear();
                        myid.Items.Add("發送：");
                        string[] list = str.Split(',');
                        foreach (string i in list)
                        {
                            onlineuser.Items.Add(i);
                            myid.Items.Add("假冒成：" + i);
                        }
                        onlineuser.Items.Remove(user);
                        myid.Items.Remove("假冒成：" + user);
                        myid.SelectedIndex = 0;
                        break;
                    case '1':
                        msgbox.Text += "【廣】" + str + "\r\n";
                        msgbox.SelectionStart = msgbox.TextLength;
                        msgbox.ScrollToCaret();
                        break;
                    case '2':
                        msgbox.Text += "【私】" + str + "\r\n";
                        msgbox.SelectionStart = msgbox.TextLength;
                        msgbox.ScrollToCaret();
                        break;
                    case '-':
                        msgbox.Text += "已存在相同名稱，請輸入新名稱後重新連線\r\n";
                        logout();
                        break;
                    case 'S':
                        msgbox.Text += str + "\r\n";
                        break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myid.SelectedIndex = 0;
        }
    }
}
