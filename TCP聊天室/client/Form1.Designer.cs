namespace client
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
            this.serverip = new System.Windows.Forms.TextBox();
            this.serverport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.myname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.msgbox = new System.Windows.Forms.TextBox();
            this.onlineuser = new System.Windows.Forms.ListBox();
            this.BC = new System.Windows.Forms.RadioButton();
            this.sendmsg = new System.Windows.Forms.TextBox();
            this.B_SEND = new System.Windows.Forms.Button();
            this.myid = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "主機IP";
            // 
            // serverip
            // 
            this.serverip.Location = new System.Drawing.Point(14, 24);
            this.serverip.Name = "serverip";
            this.serverip.Size = new System.Drawing.Size(100, 22);
            this.serverip.TabIndex = 1;
            // 
            // serverport
            // 
            this.serverport.Location = new System.Drawing.Point(228, 24);
            this.serverport.Name = "serverport";
            this.serverport.Size = new System.Drawing.Size(100, 22);
            this.serverport.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "主機Port";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(334, 24);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 4;
            this.login.Text = "登入";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // myname
            // 
            this.myname.Location = new System.Drawing.Point(120, 24);
            this.myname.Name = "myname";
            this.myname.Size = new System.Drawing.Size(100, 22);
            this.myname.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "使用者名稱";
            // 
            // msgbox
            // 
            this.msgbox.Location = new System.Drawing.Point(14, 52);
            this.msgbox.Multiline = true;
            this.msgbox.Name = "msgbox";
            this.msgbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.msgbox.Size = new System.Drawing.Size(314, 342);
            this.msgbox.TabIndex = 7;
            // 
            // onlineuser
            // 
            this.onlineuser.FormattingEnabled = true;
            this.onlineuser.ItemHeight = 12;
            this.onlineuser.Location = new System.Drawing.Point(334, 53);
            this.onlineuser.Name = "onlineuser";
            this.onlineuser.Size = new System.Drawing.Size(131, 340);
            this.onlineuser.TabIndex = 8;
            this.onlineuser.SelectedIndexChanged += new System.EventHandler(this.onlineuser_SelectedIndexChanged);
            // 
            // BC
            // 
            this.BC.AutoSize = true;
            this.BC.Checked = true;
            this.BC.Location = new System.Drawing.Point(418, 27);
            this.BC.Name = "BC";
            this.BC.Size = new System.Drawing.Size(47, 16);
            this.BC.TabIndex = 9;
            this.BC.TabStop = true;
            this.BC.Text = "尬廣";
            this.BC.UseVisualStyleBackColor = true;
            this.BC.CheckedChanged += new System.EventHandler(this.BC_CheckedChanged);
            // 
            // sendmsg
            // 
            this.sendmsg.Location = new System.Drawing.Point(14, 432);
            this.sendmsg.Name = "sendmsg";
            this.sendmsg.Size = new System.Drawing.Size(370, 22);
            this.sendmsg.TabIndex = 11;
            // 
            // B_SEND
            // 
            this.B_SEND.Location = new System.Drawing.Point(390, 430);
            this.B_SEND.Name = "B_SEND";
            this.B_SEND.Size = new System.Drawing.Size(75, 23);
            this.B_SEND.TabIndex = 12;
            this.B_SEND.Text = "送出";
            this.B_SEND.UseVisualStyleBackColor = true;
            this.B_SEND.Click += new System.EventHandler(this.B_SEND_Click);
            // 
            // myid
            // 
            this.myid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.myid.FormattingEnabled = true;
            this.myid.Items.AddRange(new object[] {
            "發送："});
            this.myid.Location = new System.Drawing.Point(14, 399);
            this.myid.Name = "myid";
            this.myid.Size = new System.Drawing.Size(206, 20);
            this.myid.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 466);
            this.Controls.Add(this.myid);
            this.Controls.Add(this.B_SEND);
            this.Controls.Add(this.sendmsg);
            this.Controls.Add(this.BC);
            this.Controls.Add(this.onlineuser);
            this.Controls.Add(this.msgbox);
            this.Controls.Add(this.myname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.login);
            this.Controls.Add(this.serverport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.serverip);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox serverip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox serverport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox myname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox msgbox;
        private System.Windows.Forms.ListBox onlineuser;
        private System.Windows.Forms.RadioButton BC;
        private System.Windows.Forms.TextBox sendmsg;
        private System.Windows.Forms.Button B_SEND;
        private System.Windows.Forms.ComboBox myid;
    }
}

