namespace WindowsTotalBuildAssistant
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxConsoleOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.confirmInstalls = new System.Windows.Forms.Button();
            this.applicationsCheckbox = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mcafee = new System.Windows.Forms.Button();
            this.ultraviewer = new System.Windows.Forms.Button();
            this.gsbackup = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DDU = new System.Windows.Forms.Button();
            this.cpuz = new System.Windows.Forms.Button();
            this.diskmark = new System.Windows.Forms.Button();
            this.oneLaunch = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bitlockerOff = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Check For Updates";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxConsoleOutput
            // 
            this.textBoxConsoleOutput.Location = new System.Drawing.Point(22, 577);
            this.textBoxConsoleOutput.Multiline = true;
            this.textBoxConsoleOutput.Name = "textBoxConsoleOutput";
            this.textBoxConsoleOutput.Size = new System.Drawing.Size(1026, 220);
            this.textBoxConsoleOutput.TabIndex = 1;
            this.textBoxConsoleOutput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(922, 800);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "WTBA Version 0.6.9";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.confirmInstalls);
            this.panel1.Controls.Add(this.applicationsCheckbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(36, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 500);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // confirmInstalls
            // 
            this.confirmInstalls.Location = new System.Drawing.Point(21, 427);
            this.confirmInstalls.Name = "confirmInstalls";
            this.confirmInstalls.Size = new System.Drawing.Size(247, 59);
            this.confirmInstalls.TabIndex = 2;
            this.confirmInstalls.Text = "Run Installers";
            this.confirmInstalls.UseVisualStyleBackColor = true;
            this.confirmInstalls.Click += new System.EventHandler(this.button2_Click);
            // 
            // applicationsCheckbox
            // 
            this.applicationsCheckbox.CheckOnClick = true;
            this.applicationsCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationsCheckbox.FormattingEnabled = true;
            this.applicationsCheckbox.Items.AddRange(new object[] {
            "Chrome",
            "Firefox",
            "OperaGx",
            "Office365",
            "Zoom",
            "Webroot",
            "Trend",
            "VLC",
            "Discord",
            "Steam",
            "iTunes",
            "Geforce Drivers"});
            this.applicationsCheckbox.Location = new System.Drawing.Point(21, 48);
            this.applicationsCheckbox.Name = "applicationsCheckbox";
            this.applicationsCheckbox.Size = new System.Drawing.Size(251, 356);
            this.applicationsCheckbox.TabIndex = 1;
            this.applicationsCheckbox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Application Installers";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // mcafee
            // 
            this.mcafee.Location = new System.Drawing.Point(17, 328);
            this.mcafee.Name = "mcafee";
            this.mcafee.Size = new System.Drawing.Size(250, 50);
            this.mcafee.TabIndex = 4;
            this.mcafee.Text = "Remove McAfee";
            this.mcafee.UseVisualStyleBackColor = true;
            this.mcafee.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // ultraviewer
            // 
            this.ultraviewer.Location = new System.Drawing.Point(17, 384);
            this.ultraviewer.Name = "ultraviewer";
            this.ultraviewer.Size = new System.Drawing.Size(250, 50);
            this.ultraviewer.TabIndex = 5;
            this.ultraviewer.Text = "Remove UltraViewer";
            this.ultraviewer.UseVisualStyleBackColor = true;
            this.ultraviewer.Click += new System.EventHandler(this.chromebtn_Click);
            // 
            // gsbackup
            // 
            this.gsbackup.Location = new System.Drawing.Point(15, 216);
            this.gsbackup.Name = "gsbackup";
            this.gsbackup.Size = new System.Drawing.Size(250, 50);
            this.gsbackup.TabIndex = 6;
            this.gsbackup.Text = "Create GSBackup on Desktop";
            this.gsbackup.UseVisualStyleBackColor = true;
            this.gsbackup.Click += new System.EventHandler(this.gsbackup_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.DDU);
            this.panel2.Controls.Add(this.cpuz);
            this.panel2.Controls.Add(this.diskmark);
            this.panel2.Controls.Add(this.oneLaunch);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.ultraviewer);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.mcafee);
            this.panel2.Location = new System.Drawing.Point(380, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 500);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // DDU
            // 
            this.DDU.Location = new System.Drawing.Point(17, 216);
            this.DDU.Name = "DDU";
            this.DDU.Size = new System.Drawing.Size(250, 50);
            this.DDU.TabIndex = 10;
            this.DDU.Text = "Display Driver Uninstaller";
            this.DDU.UseVisualStyleBackColor = true;
            this.DDU.Click += new System.EventHandler(this.DDU_Click);
            // 
            // cpuz
            // 
            this.cpuz.Location = new System.Drawing.Point(17, 104);
            this.cpuz.Name = "cpuz";
            this.cpuz.Size = new System.Drawing.Size(250, 50);
            this.cpuz.TabIndex = 9;
            this.cpuz.Text = "CPU-Z";
            this.cpuz.UseVisualStyleBackColor = true;
            this.cpuz.Click += new System.EventHandler(this.cpuz_Click);
            // 
            // diskmark
            // 
            this.diskmark.Location = new System.Drawing.Point(17, 160);
            this.diskmark.Name = "diskmark";
            this.diskmark.Size = new System.Drawing.Size(250, 50);
            this.diskmark.TabIndex = 8;
            this.diskmark.Text = "CrystalDiskMark";
            this.diskmark.UseVisualStyleBackColor = true;
            this.diskmark.Click += new System.EventHandler(this.diskmark_Click);
            // 
            // oneLaunch
            // 
            this.oneLaunch.Location = new System.Drawing.Point(17, 272);
            this.oneLaunch.Name = "oneLaunch";
            this.oneLaunch.Size = new System.Drawing.Size(250, 50);
            this.oneLaunch.TabIndex = 7;
            this.oneLaunch.Text = "Remove OneLaunch";
            this.oneLaunch.UseVisualStyleBackColor = true;
            this.oneLaunch.Click += new System.EventHandler(this.sfcscan_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Furmark";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tools and Utilities";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Orange;
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.bitlockerOff);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.gsbackup);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(721, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(287, 500);
            this.panel3.TabIndex = 8;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // bitlockerOff
            // 
            this.bitlockerOff.Location = new System.Drawing.Point(15, 272);
            this.bitlockerOff.Name = "bitlockerOff";
            this.bitlockerOff.Size = new System.Drawing.Size(250, 50);
            this.bitlockerOff.TabIndex = 7;
            this.bitlockerOff.Text = "Disable Bitlocker";
            this.bitlockerOff.UseVisualStyleBackColor = true;
            this.bitlockerOff.Click += new System.EventHandler(this.bitlockerOff_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 104);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(250, 50);
            this.button4.TabIndex = 2;
            this.button4.Text = "Open Control Panel Appwiz";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 50);
            this.button3.TabIndex = 1;
            this.button3.Text = "Ublock Origin (Chrome)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Additional Shortcuts";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(15, 328);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(250, 50);
            this.button5.TabIndex = 8;
            this.button5.Text = "Check Support.Client";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 825);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxConsoleOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxConsoleOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox applicationsCheckbox;
        private System.Windows.Forms.Button confirmInstalls;
        private System.Windows.Forms.Button mcafee;
        private System.Windows.Forms.Button ultraviewer;
        private System.Windows.Forms.Button gsbackup;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button oneLaunch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button diskmark;
        private System.Windows.Forms.Button cpuz;
        private System.Windows.Forms.Button DDU;
        private System.Windows.Forms.Button bitlockerOff;
        private System.Windows.Forms.Button button5;
    }
}

