using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GuessNumber
{
    public partial class Form1 : Form
    {
        const int digit = 6;
        const int playernum = 4;
        char[] num;
        char[] ans;
        Thread th;
        UdpClient U;
        enum usertype { player, com };
        usertype mytype;
        Random rd = new Random(Guid.NewGuid().GetHashCode());
        int playerid = 0;
        int turnid = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myip.Text = MYIP();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void button_GO_Click(object sender, EventArgs e)
        {
            int range = Convert.ToInt32(Math.Pow(10, digit - 1) + 1);
            if (mytype == usertype.com)
            {
                rollagain:
                mynumber.Text = Convert.ToString(rd.Next(range, range * 10));
                num = mynumber.Text.ToCharArray();
                for (int i = 0; i < digit; i++)
                {
                    for (int j = i + 1; j < digit; j++)
                    {
                        if (num[i] == num[j])
                        {
                            goto rollagain;
                        }
                    }
                }
            }
            ans = mynumber.Text.ToCharArray();
            myip.ReadOnly = true;
            myport.ReadOnly = true;
            yourip.ReadOnly = true;
            yourport.ReadOnly = true;
            mynumber.ReadOnly = true;
            button_GO.Text = "等待玩家";
            button_GO.Click -= button_GO_Click;
            button_GO.Click += button_GO_Send;
            button_GO.Enabled = false;
            th = new Thread(listen);
            th.Start();
            if (mytype == usertype.player)
            {
                send(myip.Text + ":" + myport.Text, yourip.Text, yourport.Text);
            }
        }
        private void button_GO_Send(object sender, EventArgs e)
        {
            num = guessnumber.Text.ToCharArray();
            if (num.Length != digit)
            {
                MessageBox.Show(guessnumber.Text + "並不是一個" + digit.ToString() + "位數字");
                return;
            }
            else
            {
                for (int i = 0; i < digit; i++)
                {
                    for (int j = i + 1; j < digit; j++)
                    {
                        if (num[i] == num[j])
                        {
                            MessageBox.Show(guessnumber.Text + "中有數字重複了");
                            return;
                        }
                    }
                }
            }
            guessnumber.ReadOnly = true;
            send("G" + playerid.ToString() + guessnumber.Text, yourip.Text, yourport.Text);
            button_GO.Text = "對方回合";
            button_GO.Enabled = false;
        }
        private void listen()
        {
            int port = int.Parse(myport.Text);
            U = new UdpClient(port);
            IPEndPoint EP = new IPEndPoint(IPAddress.Parse(myip.Text), port);
            while (true)
            {
                byte[] B;
                string R;
                if (mytype == usertype.com)
                {
                    string[] dest;
                    if (myguess.Items.Count < playernum)
                    {
                        B = U.Receive(ref EP);
                        R = Encoding.Default.GetString(B);
                        dest = R.Split(':');
                        myguess.Items.Add(R);
                        Thread.Sleep(100);
                        send("Player" + Convert.ToString(myguess.Items.Count), dest[0], dest[1]);
                    }
                    if (myguess.Items.Count == playernum)
                    {
                        turnid++;
                        turnid %= playernum;
                        button_GO.Text = "目前：Player" + Convert.ToString(turnid + 1);
                        dest = myguess.Items[turnid].ToString().Split(':');
                        Thread.Sleep(100);
                        send("Player" + Convert.ToString(turnid + 1), dest[0], dest[1]);
                        do
                        {
                            B = U.Receive(ref EP);
                            R = Encoding.Default.GetString(B);
                        } while (R[0] != 'G' && R[1].ToString() != Convert.ToString(turnid + 1));
                        string AB = chk(R.Substring(2));
                        yourguess.Items.Add("Player" + Convert.ToString(turnid + 1) + " " + R.Substring(2) + " " + AB);
                        for (int i = 0; i < myguess.Items.Count; i++)
                        {
                            dest = myguess.Items[i].ToString().Split(':');
                            send("BPlayer" + Convert.ToString(turnid + 1) + " " + R.Substring(2) + " " + AB, dest[0], dest[1]);
                        }
                        dest = myguess.Items[(turnid + 1) % playernum].ToString().Split(':');
                        send("Player" + Convert.ToString(turnid + 1), dest[0], dest[1]);
                        if (AB[0].ToString() == digit.ToString())
                        {
                            button_GO.Text = "Player" + Convert.ToString(turnid + 1) + "猜到了";
                            for (int i = 0; i < myguess.Items.Count; i++)
                            {
                                dest = myguess.Items[i].ToString().Split(':');
                                send("W" + Convert.ToString(turnid + 1), dest[0], dest[1]);
                            }
                            U.Close();
                            th.Abort();
                            return;
                        }
                    }
                }
                else
                {
                    B = U.Receive(ref EP);
                    R = Encoding.Default.GetString(B);
                    if (R[0] == 'P')
                    {
                        if (playerid == 0)
                        {
                            playerid = int.Parse(R[6].ToString());
                            this.Text += " " + R;
                        }
                        else
                        {
                            button_GO.Enabled = true;
                            button_GO.Text = "確定";
                            guessnumber.ReadOnly = false;
                        }
                    }
                    else if (R[0] == 'B')
                    {
                        yourguess.Items.Add(R.Substring(1));
                        if (R[7].ToString() == playerid.ToString())
                        {
                            myguess.Items.Add(R.Substring(1));
                        }
                    }
                    else if (R[0] == 'W')
                    {
                        U.Close();
                        guessnumber.ReadOnly = true;
                        button_GO.Enabled = false;
                        if (R[1].ToString() == playerid.ToString())
                        {
                            button_GO.Text = "答對了!";
                            MessageBox.Show("你贏了!");
                        }
                        else
                        {
                            button_GO.Text = "Player " + R[1] + " 猜到了";
                            MessageBox.Show("Player " + R[1] + " 贏了!");
                        }
                        th.Abort();
                        return;
                    }
                }
            }
        }
        private void send(string s, string ip, string port)
        {
            UdpClient us = new UdpClient();
            byte[] B = Encoding.Default.GetBytes(s.ToCharArray());
            us.Send(B, B.Length, ip, int.Parse(port));
            us.Close();
        }
        private string chk(string s)
        {
            int A = 0;
            int B = 0;
            for (int i = 0; i < digit; i++)
            {
                for (int j = 0; j < digit; j++)
                {
                    if (s[i] == ans[j])
                    {
                        if (i == j)
                        {
                            A++;
                        }
                        else
                        {
                            B++;
                        }
                        break;
                    }
                }
            }
            return A.ToString() + "A" + B.ToString() + "B";
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
                th.Abort();
                U.Close();
            }
            catch
            {

            }
        }

        private void button_com_Click(object sender, EventArgs e)
        {
            mytype = usertype.com;
            button_com.Visible = false;
            button_player.Visible = false;
            label5.Visible = true;
            label7.Text = "連線玩家";
            this.Text += " 主機端";
            myport.ReadOnly = false;
            mynumber.Visible = true;
            button_GO.Enabled = true;
        }

        private void button_player_Click(object sender, EventArgs e)
        {
            mytype = usertype.player;
            button_com.Visible = false;
            button_player.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            label6.Visible = true;
            myport.ReadOnly = false;
            yourip.Visible = true;
            yourport.Visible = true;
            guessnumber.Visible = true;
            button_GO.Enabled = true;
        }
    }
}
