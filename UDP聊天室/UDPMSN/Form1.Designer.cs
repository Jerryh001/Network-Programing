namespace UDPMSN
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text_msg = new System.Windows.Forms.TextBox();
            this.text_myip = new System.Windows.Forms.TextBox();
            this.text_myport = new System.Windows.Forms.TextBox();
            this.text_yourip = new System.Windows.Forms.TextBox();
            this.text_yourport = new System.Windows.Forms.TextBox();
            this.msg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.B_GO = new System.Windows.Forms.Button();
            this.new_user = new System.Windows.Forms.Button();
            this.user_online = new System.Windows.Forms.ListBox();
            this.port_listen = new System.Windows.Forms.ListBox();
            this.new_port = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(480, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "我的IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(491, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "我的Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(475, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "對方IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(466, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "對方Port";
            // 
            // text_msg
            // 
            this.text_msg.BackColor = System.Drawing.Color.White;
            this.text_msg.Location = new System.Drawing.Point(12, 12);
            this.text_msg.Multiline = true;
            this.text_msg.Name = "text_msg";
            this.text_msg.ReadOnly = true;
            this.text_msg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_msg.Size = new System.Drawing.Size(451, 397);
            this.text_msg.TabIndex = 4;
            this.text_msg.TextChanged += new System.EventHandler(this.text_msg_TextChanged);
            // 
            // text_myip
            // 
            this.text_myip.Location = new System.Drawing.Point(525, 378);
            this.text_myip.Name = "text_myip";
            this.text_myip.ReadOnly = true;
            this.text_myip.Size = new System.Drawing.Size(95, 22);
            this.text_myip.TabIndex = 5;
            // 
            // text_myport
            // 
            this.text_myport.Location = new System.Drawing.Point(545, 321);
            this.text_myport.Name = "text_myport";
            this.text_myport.Size = new System.Drawing.Size(75, 22);
            this.text_myport.TabIndex = 6;
            // 
            // text_yourip
            // 
            this.text_yourip.Location = new System.Drawing.Point(520, 142);
            this.text_yourip.Name = "text_yourip";
            this.text_yourip.Size = new System.Drawing.Size(100, 22);
            this.text_yourip.TabIndex = 7;
            // 
            // text_yourport
            // 
            this.text_yourport.Location = new System.Drawing.Point(520, 170);
            this.text_yourport.Name = "text_yourport";
            this.text_yourport.Size = new System.Drawing.Size(100, 22);
            this.text_yourport.TabIndex = 8;
            // 
            // msg
            // 
            this.msg.Location = new System.Drawing.Point(67, 415);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(447, 22);
            this.msg.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "輸入訊息";
            // 
            // B_GO
            // 
            this.B_GO.Location = new System.Drawing.Point(520, 413);
            this.B_GO.Name = "B_GO";
            this.B_GO.Size = new System.Drawing.Size(99, 23);
            this.B_GO.TabIndex = 11;
            this.B_GO.Text = "啟動程式";
            this.B_GO.UseVisualStyleBackColor = true;
            this.B_GO.Click += new System.EventHandler(this.B_GO_Click);
            // 
            // new_user
            // 
            this.new_user.Location = new System.Drawing.Point(545, 198);
            this.new_user.Name = "new_user";
            this.new_user.Size = new System.Drawing.Size(75, 23);
            this.new_user.TabIndex = 13;
            this.new_user.Text = "新增";
            this.new_user.UseVisualStyleBackColor = true;
            this.new_user.Click += new System.EventHandler(this.new_user_Click);
            // 
            // user_online
            // 
            this.user_online.FormattingEnabled = true;
            this.user_online.ItemHeight = 12;
            this.user_online.Items.AddRange(new object[] {
            "和你聊天的人：(上限十人)"});
            this.user_online.Location = new System.Drawing.Point(469, 12);
            this.user_online.Name = "user_online";
            this.user_online.Size = new System.Drawing.Size(151, 124);
            this.user_online.TabIndex = 14;
            // 
            // port_listen
            // 
            this.port_listen.FormattingEnabled = true;
            this.port_listen.ItemHeight = 12;
            this.port_listen.Items.AddRange(new object[] {
            "監聽中的Port(上限十個)"});
            this.port_listen.Location = new System.Drawing.Point(469, 227);
            this.port_listen.Name = "port_listen";
            this.port_listen.Size = new System.Drawing.Size(151, 88);
            this.port_listen.TabIndex = 15;
            // 
            // new_port
            // 
            this.new_port.Location = new System.Drawing.Point(545, 349);
            this.new_port.Name = "new_port";
            this.new_port.Size = new System.Drawing.Size(75, 23);
            this.new_port.TabIndex = 17;
            this.new_port.Text = "新增";
            this.new_port.UseVisualStyleBackColor = true;
            this.new_port.Click += new System.EventHandler(this.new_port_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.B_GO;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 446);
            this.Controls.Add(this.new_port);
            this.Controls.Add(this.port_listen);
            this.Controls.Add(this.user_online);
            this.Controls.Add(this.new_user);
            this.Controls.Add(this.B_GO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.text_yourport);
            this.Controls.Add(this.text_yourip);
            this.Controls.Add(this.text_myport);
            this.Controls.Add(this.text_myip);
            this.Controls.Add(this.text_msg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "聊天室 專業土豪加強豪華版(試用版)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_msg;
        private System.Windows.Forms.TextBox text_myip;
        private System.Windows.Forms.TextBox text_myport;
        private System.Windows.Forms.TextBox text_yourip;
        private System.Windows.Forms.TextBox text_yourport;
        private System.Windows.Forms.TextBox msg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button B_GO;
        private System.Windows.Forms.Button new_user;
        private System.Windows.Forms.ListBox user_online;
        private System.Windows.Forms.ListBox port_listen;
        private System.Windows.Forms.Button new_port;
    }
}

