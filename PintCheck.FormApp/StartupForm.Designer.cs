namespace PintCheck.FormApp
{
    partial class StartupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartupForm));
            this.gb_Settings = new System.Windows.Forms.GroupBox();
            this.txb_interval = new System.Windows.Forms.MaskedTextBox();
            this.txb_loops = new System.Windows.Forms.MaskedTextBox();
            this.txb_timeout = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_file = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_url = new System.Windows.Forms.TextBox();
            this.btn_Execute = new System.Windows.Forms.Button();
            this.pgb_running = new System.Windows.Forms.ProgressBar();
            this.lbl_state = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nfi_tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.ckb_wifi = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txb_url2 = new System.Windows.Forms.TextBox();
            this.gb_Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Settings
            // 
            this.gb_Settings.Controls.Add(this.label9);
            this.gb_Settings.Controls.Add(this.txb_url2);
            this.gb_Settings.Controls.Add(this.ckb_wifi);
            this.gb_Settings.Controls.Add(this.txb_interval);
            this.gb_Settings.Controls.Add(this.txb_loops);
            this.gb_Settings.Controls.Add(this.txb_timeout);
            this.gb_Settings.Controls.Add(this.label7);
            this.gb_Settings.Controls.Add(this.txb_file);
            this.gb_Settings.Controls.Add(this.label6);
            this.gb_Settings.Controls.Add(this.label5);
            this.gb_Settings.Controls.Add(this.label4);
            this.gb_Settings.Controls.Add(this.label3);
            this.gb_Settings.Controls.Add(this.label2);
            this.gb_Settings.Controls.Add(this.label1);
            this.gb_Settings.Controls.Add(this.txb_url);
            this.gb_Settings.Location = new System.Drawing.Point(12, 12);
            this.gb_Settings.Name = "gb_Settings";
            this.gb_Settings.Size = new System.Drawing.Size(424, 190);
            this.gb_Settings.TabIndex = 0;
            this.gb_Settings.TabStop = false;
            this.gb_Settings.Text = "Settings";
            // 
            // txb_interval
            // 
            this.txb_interval.Location = new System.Drawing.Point(88, 133);
            this.txb_interval.Mask = "000";
            this.txb_interval.Name = "txb_interval";
            this.txb_interval.Size = new System.Drawing.Size(50, 22);
            this.txb_interval.TabIndex = 14;
            this.txb_interval.Text = "20";
            // 
            // txb_loops
            // 
            this.txb_loops.Location = new System.Drawing.Point(88, 105);
            this.txb_loops.Mask = "00";
            this.txb_loops.Name = "txb_loops";
            this.txb_loops.Size = new System.Drawing.Size(50, 22);
            this.txb_loops.TabIndex = 13;
            this.txb_loops.Text = "4";
            // 
            // txb_timeout
            // 
            this.txb_timeout.Location = new System.Drawing.Point(88, 163);
            this.txb_timeout.Mask = "0000";
            this.txb_timeout.Name = "txb_timeout";
            this.txb_timeout.Size = new System.Drawing.Size(50, 22);
            this.txb_timeout.TabIndex = 12;
            this.txb_timeout.Text = "2000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Output file";
            // 
            // txb_file
            // 
            this.txb_file.Location = new System.Drawing.Point(88, 77);
            this.txb_file.Name = "txb_file";
            this.txb_file.Size = new System.Drawing.Size(330, 22);
            this.txb_file.TabIndex = 10;
            this.txb_file.Text = "PingAnalystics.csv";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "seconds";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "milliseconds";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Timeout";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Interval";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loops";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Url";
            // 
            // txb_url
            // 
            this.txb_url.Location = new System.Drawing.Point(88, 21);
            this.txb_url.Name = "txb_url";
            this.txb_url.Size = new System.Drawing.Size(330, 22);
            this.txb_url.TabIndex = 0;
            this.txb_url.Text = "http://google-public-dns-a.google.com";
            // 
            // btn_Execute
            // 
            this.btn_Execute.Location = new System.Drawing.Point(451, 159);
            this.btn_Execute.Name = "btn_Execute";
            this.btn_Execute.Size = new System.Drawing.Size(119, 43);
            this.btn_Execute.TabIndex = 1;
            this.btn_Execute.Text = "Start";
            this.btn_Execute.UseVisualStyleBackColor = true;
            this.btn_Execute.Click += new System.EventHandler(this.btn_ExecuteClick);
            // 
            // pgb_running
            // 
            this.pgb_running.Location = new System.Drawing.Point(12, 230);
            this.pgb_running.Name = "pgb_running";
            this.pgb_running.Size = new System.Drawing.Size(558, 10);
            this.pgb_running.TabIndex = 2;
            // 
            // lbl_state
            // 
            this.lbl_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_state.Location = new System.Drawing.Point(71, 205);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(499, 23);
            this.lbl_state.TabIndex = 3;
            this.lbl_state.Text = "Stoped";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(9, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "State:";
            // 
            // nfi_tray
            // 
            this.nfi_tray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.nfi_tray.BalloonTipText = "Double click to open.";
            this.nfi_tray.BalloonTipTitle = "Pint Checker";
            this.nfi_tray.Icon = ((System.Drawing.Icon)(resources.GetObject("nfi_tray.Icon")));
            this.nfi_tray.Text = "Pint Checker";
            this.nfi_tray.Visible = true;
            this.nfi_tray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.nfi_tray_MouseDoubleClick);
            // 
            // ckb_wifi
            // 
            this.ckb_wifi.AutoSize = true;
            this.ckb_wifi.Location = new System.Drawing.Point(307, 165);
            this.ckb_wifi.Name = "ckb_wifi";
            this.ckb_wifi.Size = new System.Drawing.Size(109, 21);
            this.ckb_wifi.TabIndex = 15;
            this.ckb_wifi.Text = "Wifi strength";
            this.ckb_wifi.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Url (2)";
            // 
            // txb_url2
            // 
            this.txb_url2.Location = new System.Drawing.Point(88, 49);
            this.txb_url2.Name = "txb_url2";
            this.txb_url2.Size = new System.Drawing.Size(330, 22);
            this.txb_url2.TabIndex = 16;
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 243);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_state);
            this.Controls.Add(this.pgb_running);
            this.Controls.Add(this.gb_Settings);
            this.Controls.Add(this.btn_Execute);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 290);
            this.MinimumSize = new System.Drawing.Size(600, 290);
            this.Name = "StartupForm";
            this.Text = "Pint Checker";
            this.Resize += new System.EventHandler(this.StartupForm_Resize);
            this.gb_Settings.ResumeLayout(false);
            this.gb_Settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Settings;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_url;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Execute;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_file;
        private System.Windows.Forms.MaskedTextBox txb_interval;
        private System.Windows.Forms.MaskedTextBox txb_loops;
        private System.Windows.Forms.MaskedTextBox txb_timeout;
        private System.Windows.Forms.ProgressBar pgb_running;
        private System.Windows.Forms.Label lbl_state;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NotifyIcon nfi_tray;
        private System.Windows.Forms.CheckBox ckb_wifi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txb_url2;
    }
}