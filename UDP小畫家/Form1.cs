using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Microsoft.VisualBasic.PowerPacks;
namespace paint
{
    public partial class Form1 : Form
    {
        Thread th;
        UdpClient U;
        ShapeContainer C = new ShapeContainer();
        ShapeContainer D = new ShapeContainer();
        Point startpoint;
        int color = 3;
        string points;
        public Form1()
        {
            InitializeComponent();
        }
        private string MYIP()
        {
            string name = Dns.GetHostName();
            IPAddress[] ip = Dns.GetHostEntry(name).AddressList;
            foreach (IPAddress it in ip)
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
            CheckForIllegalCrossThreadCalls = false;
            myip.Text = MYIP();
            this.Controls.Add(C);
            this.Controls.Add(D);
        }

        private void run_Click(object sender, EventArgs e)
        {
            run.Enabled = false;
            myport.ReadOnly = true;
            yourip.ReadOnly = true;
            yourport.ReadOnly = true;
            th = new Thread(listen);
            th.Start();
            this.MouseDown += Form1_MouseDown;
        }
        private void listen(object obj)
        {
            int port = int.Parse(myport.Text);
            U = new UdpClient(port);
            IPEndPoint pt = new IPEndPoint(IPAddress.Parse(myip.Text), port);
            while (true)
            {
                byte[] b = U.Receive(ref pt);
                string msg = Encoding.Default.GetString(b);
                string[] info = msg.Split('@');
                string[] att = info[0].Split('_');
                Point[] Ps = new Point[info.Length - 1];
                for (int i = 0; i < Ps.Length; i++)
                {
                    string[] xy = info[i + 1].Split('_');
                    Ps[i].X = int.Parse(xy[0]);
                    Ps[i].Y = int.Parse(xy[1]);
                }
                for (int i = 0; i < Ps.Length - 1; i++)
                {
                    LineShape line = new LineShape();
                    line.StartPoint = Ps[i];
                    line.EndPoint = Ps[i + 1];
                    line.BorderWidth = int.Parse(att[1]);
                    if (att[2] == "T")
                    {
                        line.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                    }
                    switch (int.Parse(att[0]))
                    {
                        case 0:
                            line.BorderColor = Color.Red;
                            break;
                        case 1:
                            line.BorderColor = Color.Green;
                            break;
                        case 2:
                            line.BorderColor = Color.Blue;
                            break;
                        case 3:
                            line.BorderColor = Color.Black;
                            break;
                    }
                    line.Parent = D;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                U.Close();
                th.Abort();
            }
            catch
            {

            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            startpoint = e.Location;
            points = color.ToString() + "_" + linew.Text + "_";
            if (lineinv.Checked)
            {
                points += "T@";
            }
            else
            {
                points += "F@";
            }
            points += startpoint.X.ToString() + "_" + startpoint.Y.ToString();
            this.MouseMove += Form1_MouseMove;
            this.MouseUp += Form1_MouseUp;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                LineShape line = new LineShape();
                line.StartPoint = startpoint;
                line.EndPoint = e.Location;
                line.BorderWidth = int.Parse(linew.Text);
                if (lineinv.Checked)
                {
                    line.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                }
                switch (color)
                {
                    case 0:
                        line.BorderColor = Color.Red;
                        break;
                    case 1:
                        line.BorderColor = Color.Green;
                        break;
                    case 2:
                        line.BorderColor = Color.Blue;
                        break;
                    case 3:
                        line.BorderColor = Color.Black;
                        break;
                }
                line.Parent = C;
                startpoint = e.Location;
                points += "@" + startpoint.X.ToString() + "_" + startpoint.Y.ToString();
            }
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                color = 0;
            }
            else if (radioButton2.Checked)
            {
                color = 1;
            }
            else if (radioButton3.Checked)
            {
                color = 2;
            }
            else if (radioButton4.Checked)
            {
                color = 3;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            this.MouseMove -= Form1_MouseMove;
            this.MouseUp -= Form1_MouseUp;
            int port = int.Parse(yourport.Text);
            UdpClient S = new UdpClient(yourip.Text, port);
            byte[] b = Encoding.Default.GetBytes(points);
            S.Send(b, b.Length);
            S.Close();
        }
    }
}
