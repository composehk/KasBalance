namespace KasBalance
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabMain = new TabControl();
            tabPage1 = new TabPage();
            label3 = new Label();
            llCheck = new LinkLabel();
            txtBalance = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtAddress = new TextBox();
            tabPage2 = new TabPage();
            txtPort = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtIP = new TextBox();
            label4 = new Label();
            tabMain.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabPage1);
            tabMain.Controls.Add(tabPage2);
            tabMain.Dock = DockStyle.Fill;
            tabMain.Location = new Point(0, 0);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(800, 283);
            tabMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(llCheck);
            tabPage1.Controls.Add(txtBalance);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtAddress);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 253);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Balance";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(341, 58);
            label3.Name = "label3";
            label3.Size = new Size(29, 17);
            label3.TabIndex = 10;
            label3.Text = "Kas";
            // 
            // llCheck
            // 
            llCheck.AutoSize = true;
            llCheck.Location = new Point(513, 55);
            llCheck.Name = "llCheck";
            llCheck.Size = new Size(132, 17);
            llCheck.TabIndex = 8;
            llCheck.TabStop = true;
            llCheck.Text = "Check Kaspa Balance";
            llCheck.LinkClicked += llCheck_LinkClicked;
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(149, 52);
            txtBalance.Name = "txtBalance";
            txtBalance.ReadOnly = true;
            txtBalance.Size = new Size(186, 23);
            txtBalance.TabIndex = 9;
            txtBalance.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 55);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 7;
            label2.Text = "Balance:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 23);
            label1.Name = "label1";
            label1.Size = new Size(108, 17);
            label1.TabIndex = 6;
            label1.Text = "Kaspa Address：";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(149, 20);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(496, 23);
            txtAddress.TabIndex = 5;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(txtPort);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(txtIP);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 253);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Settings";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtPort
            // 
            txtPort.Location = new Point(162, 46);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(186, 23);
            txtPort.TabIndex = 14;
            txtPort.Text = "16110";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(121, 46);
            label5.Name = "label5";
            label5.Size = new Size(35, 17);
            label5.TabIndex = 13;
            label5.Text = "Port:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 20);
            label6.Name = "label6";
            label6.Size = new Size(120, 17);
            label6.TabIndex = 12;
            label6.Text = "Kaspa Net IP(host):";
            // 
            // txtIP
            // 
            txtIP.Location = new Point(162, 17);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(360, 23);
            txtIP.TabIndex = 11;
            txtIP.Text = "localhost";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(152, 233);
            label4.Name = "label4";
            label4.Size = new Size(570, 17);
            label4.TabIndex = 15;
            label4.Text = "Donate address: kaspa:qpje7d7x4w0hme7yzxtvas0qmj5h946p3vpxhag56wqwrkamfshxq4ev0kczz";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 283);
            Controls.Add(tabMain);
            Name = "frmMain";
            Text = "Kaspa Balance Check";
            tabMain.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabMain;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label3;
        private LinkLabel llCheck;
        private TextBox txtBalance;
        private Label label2;
        private Label label1;
        private TextBox txtAddress;
        private TextBox txtPort;
        private Label label5;
        private Label label6;
        private TextBox txtIP;
        private Label label4;
    }
}