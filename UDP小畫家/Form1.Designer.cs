namespace paint
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
            this.myip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.myport = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.yourip = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.yourport = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.run = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.linew = new System.Windows.Forms.TextBox();
            this.lineinv = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // myip
            // 
            this.myip.Location = new System.Drawing.Point(57, 12);
            this.myip.Name = "myip";
            this.myip.ReadOnly = true;
            this.myip.Size = new System.Drawing.Size(100, 22);
            this.myip.TabIndex = 0;
            this.myip.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "我的IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "我的Port";
            // 
            // myport
            // 
            this.myport.Location = new System.Drawing.Point(217, 12);
            this.myport.Name = "myport";
            this.myport.Size = new System.Drawing.Size(100, 22);
            this.myport.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "對方IP";
            // 
            // yourip
            // 
            this.yourip.Location = new System.Drawing.Point(368, 12);
            this.yourip.Name = "yourip";
            this.yourip.Size = new System.Drawing.Size(100, 22);
            this.yourip.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(474, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "對方Port";
            // 
            // yourport
            // 
            this.yourport.Location = new System.Drawing.Point(528, 12);
            this.yourport.Name = "yourport";
            this.yourport.Size = new System.Drawing.Size(100, 22);
            this.yourport.TabIndex = 3;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(14, 40);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 16);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.Text = "紅色";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(67, 40);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 16);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.Text = "綠色";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(120, 40);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(47, 16);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.Text = "藍色";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(173, 40);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(47, 16);
            this.radioButton4.TabIndex = 7;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "黑色";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(553, 40);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(75, 23);
            this.run.TabIndex = 8;
            this.run.Text = "啟動";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "粗細";
            // 
            // linew
            // 
            this.linew.Location = new System.Drawing.Point(261, 39);
            this.linew.Name = "linew";
            this.linew.Size = new System.Drawing.Size(100, 22);
            this.linew.TabIndex = 9;
            this.linew.Text = "5";
            // 
            // lineinv
            // 
            this.lineinv.AutoSize = true;
            this.lineinv.Location = new System.Drawing.Point(368, 42);
            this.lineinv.Name = "lineinv";
            this.lineinv.Size = new System.Drawing.Size(48, 16);
            this.lineinv.TabIndex = 11;
            this.lineinv.Text = "虛線";
            this.lineinv.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 538);
            this.Controls.Add(this.lineinv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linew);
            this.Controls.Add(this.run);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.yourport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yourip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.myport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox myip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox myport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox yourip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox yourport;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox linew;
        private System.Windows.Forms.CheckBox lineinv;
    }
}

