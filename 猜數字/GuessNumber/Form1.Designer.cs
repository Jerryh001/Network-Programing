namespace GuessNumber
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
            this.myport = new System.Windows.Forms.TextBox();
            this.mynumber = new System.Windows.Forms.TextBox();
            this.yourport = new System.Windows.Forms.TextBox();
            this.yourip = new System.Windows.Forms.TextBox();
            this.guessnumber = new System.Windows.Forms.TextBox();
            this.myip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_GO = new System.Windows.Forms.Button();
            this.myguess = new System.Windows.Forms.ListBox();
            this.yourguess = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button_com = new System.Windows.Forms.Button();
            this.button_player = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myport
            // 
            this.myport.Location = new System.Drawing.Point(212, 12);
            this.myport.Name = "myport";
            this.myport.ReadOnly = true;
            this.myport.Size = new System.Drawing.Size(100, 22);
            this.myport.TabIndex = 0;
            // 
            // mynumber
            // 
            this.mynumber.Location = new System.Drawing.Point(212, 40);
            this.mynumber.Name = "mynumber";
            this.mynumber.ReadOnly = true;
            this.mynumber.Size = new System.Drawing.Size(100, 22);
            this.mynumber.TabIndex = 3;
            this.mynumber.Visible = false;
            // 
            // yourport
            // 
            this.yourport.Location = new System.Drawing.Point(212, 40);
            this.yourport.Name = "yourport";
            this.yourport.Size = new System.Drawing.Size(100, 22);
            this.yourport.TabIndex = 2;
            this.yourport.Visible = false;
            // 
            // yourip
            // 
            this.yourip.Location = new System.Drawing.Point(52, 40);
            this.yourip.Name = "yourip";
            this.yourip.Size = new System.Drawing.Size(100, 22);
            this.yourip.TabIndex = 1;
            this.yourip.Visible = false;
            // 
            // guessnumber
            // 
            this.guessnumber.Location = new System.Drawing.Point(66, 67);
            this.guessnumber.Name = "guessnumber";
            this.guessnumber.ReadOnly = true;
            this.guessnumber.Size = new System.Drawing.Size(100, 22);
            this.guessnumber.TabIndex = 4;
            this.guessnumber.Visible = false;
            // 
            // myip
            // 
            this.myip.Location = new System.Drawing.Point(52, 12);
            this.myip.Name = "myip";
            this.myip.Size = new System.Drawing.Size(100, 22);
            this.myip.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "我的IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "我的Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "主機IP";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "主機Port";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "我的數字";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "猜測數字";
            this.label6.Visible = false;
            // 
            // button_GO
            // 
            this.button_GO.Enabled = false;
            this.button_GO.Location = new System.Drawing.Point(172, 68);
            this.button_GO.Name = "button_GO";
            this.button_GO.Size = new System.Drawing.Size(140, 23);
            this.button_GO.TabIndex = 12;
            this.button_GO.Text = "啟動遊戲";
            this.button_GO.UseVisualStyleBackColor = true;
            this.button_GO.Click += new System.EventHandler(this.button_GO_Click);
            // 
            // myguess
            // 
            this.myguess.FormattingEnabled = true;
            this.myguess.ItemHeight = 12;
            this.myguess.Location = new System.Drawing.Point(9, 120);
            this.myguess.Name = "myguess";
            this.myguess.Size = new System.Drawing.Size(148, 184);
            this.myguess.TabIndex = 13;
            // 
            // yourguess
            // 
            this.yourguess.FormattingEnabled = true;
            this.yourguess.ItemHeight = 12;
            this.yourguess.Location = new System.Drawing.Point(165, 120);
            this.yourguess.Name = "yourguess";
            this.yourguess.Size = new System.Drawing.Size(152, 184);
            this.yourguess.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "我的猜測";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(163, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "玩家猜測";
            // 
            // button_com
            // 
            this.button_com.Location = new System.Drawing.Point(212, 38);
            this.button_com.Name = "button_com";
            this.button_com.Size = new System.Drawing.Size(75, 23);
            this.button_com.TabIndex = 17;
            this.button_com.Text = "當電腦主機";
            this.button_com.UseVisualStyleBackColor = true;
            this.button_com.Click += new System.EventHandler(this.button_com_Click);
            // 
            // button_player
            // 
            this.button_player.Location = new System.Drawing.Point(77, 38);
            this.button_player.Name = "button_player";
            this.button_player.Size = new System.Drawing.Size(75, 23);
            this.button_player.TabIndex = 18;
            this.button_player.Text = "當玩家";
            this.button_player.UseVisualStyleBackColor = true;
            this.button_player.Click += new System.EventHandler(this.button_player_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.button_GO;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 317);
            this.Controls.Add(this.button_player);
            this.Controls.Add(this.button_com);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.yourguess);
            this.Controls.Add(this.myguess);
            this.Controls.Add(this.button_GO);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myip);
            this.Controls.Add(this.guessnumber);
            this.Controls.Add(this.yourip);
            this.Controls.Add(this.yourport);
            this.Controls.Add(this.mynumber);
            this.Controls.Add(this.myport);
            this.Name = "Form1";
            this.Text = "猜數字";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox myport;
        private System.Windows.Forms.TextBox mynumber;
        private System.Windows.Forms.TextBox yourport;
        private System.Windows.Forms.TextBox yourip;
        private System.Windows.Forms.TextBox guessnumber;
        private System.Windows.Forms.TextBox myip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_GO;
        private System.Windows.Forms.ListBox myguess;
        private System.Windows.Forms.ListBox yourguess;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_com;
        private System.Windows.Forms.Button button_player;
    }
}

