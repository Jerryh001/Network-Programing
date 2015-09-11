namespace server
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
            this.myip = new System.Windows.Forms.TextBox();
            this.myport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.B_GO = new System.Windows.Forms.Button();
            this.onlineuser = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "我的IP";
            // 
            // myip
            // 
            this.myip.Location = new System.Drawing.Point(14, 24);
            this.myip.Name = "myip";
            this.myip.Size = new System.Drawing.Size(100, 22);
            this.myip.TabIndex = 1;
            // 
            // myport
            // 
            this.myport.Location = new System.Drawing.Point(14, 64);
            this.myport.Name = "myport";
            this.myport.Size = new System.Drawing.Size(100, 22);
            this.myport.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "我的Port";
            // 
            // B_GO
            // 
            this.B_GO.Location = new System.Drawing.Point(14, 92);
            this.B_GO.Name = "B_GO";
            this.B_GO.Size = new System.Drawing.Size(75, 23);
            this.B_GO.TabIndex = 4;
            this.B_GO.Text = "啟動";
            this.B_GO.UseVisualStyleBackColor = true;
            this.B_GO.Click += new System.EventHandler(this.B_GO_Click);
            // 
            // onlineuser
            // 
            this.onlineuser.FormattingEnabled = true;
            this.onlineuser.ItemHeight = 12;
            this.onlineuser.Location = new System.Drawing.Point(120, 24);
            this.onlineuser.Name = "onlineuser";
            this.onlineuser.Size = new System.Drawing.Size(120, 196);
            this.onlineuser.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "線上使用者";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 230);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.onlineuser);
            this.Controls.Add(this.B_GO);
            this.Controls.Add(this.myport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.myip);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox myip;
        private System.Windows.Forms.TextBox myport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button B_GO;
        private System.Windows.Forms.ListBox onlineuser;
        private System.Windows.Forms.Label label3;
    }
}

