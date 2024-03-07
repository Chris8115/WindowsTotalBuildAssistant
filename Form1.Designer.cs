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
            this.label2 = new System.Windows.Forms.Label();
            this.applicationsCheckbox = new System.Windows.Forms.CheckedListBox();
            this.confirmInstalls = new System.Windows.Forms.Button();
            this.mcafee = new System.Windows.Forms.Button();
            this.chromebtn = new System.Windows.Forms.Button();
            this.gsbackup = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Check For Updates";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxConsoleOutput
            // 
            this.textBoxConsoleOutput.Location = new System.Drawing.Point(12, 485);
            this.textBoxConsoleOutput.Multiline = true;
            this.textBoxConsoleOutput.Name = "textBoxConsoleOutput";
            this.textBoxConsoleOutput.Size = new System.Drawing.Size(717, 223);
            this.textBoxConsoleOutput.TabIndex = 1;
            this.textBoxConsoleOutput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(603, 711);
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
            this.panel1.Location = new System.Drawing.Point(52, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 365);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            "Steam"});
            this.applicationsCheckbox.Location = new System.Drawing.Point(21, 48);
            this.applicationsCheckbox.Name = "applicationsCheckbox";
            this.applicationsCheckbox.Size = new System.Drawing.Size(251, 246);
            this.applicationsCheckbox.TabIndex = 1;
            this.applicationsCheckbox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // confirmInstalls
            // 
            this.confirmInstalls.Location = new System.Drawing.Point(21, 303);
            this.confirmInstalls.Name = "confirmInstalls";
            this.confirmInstalls.Size = new System.Drawing.Size(247, 39);
            this.confirmInstalls.TabIndex = 2;
            this.confirmInstalls.Text = "Run Installers";
            this.confirmInstalls.UseVisualStyleBackColor = true;
            this.confirmInstalls.Click += new System.EventHandler(this.button2_Click);
            // 
            // mcafee
            // 
            this.mcafee.Location = new System.Drawing.Point(17, 216);
            this.mcafee.Name = "mcafee";
            this.mcafee.Size = new System.Drawing.Size(250, 50);
            this.mcafee.TabIndex = 4;
            this.mcafee.Text = "Remove McAfee";
            this.mcafee.UseVisualStyleBackColor = true;
            this.mcafee.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // chromebtn
            // 
            this.chromebtn.Location = new System.Drawing.Point(17, 104);
            this.chromebtn.Name = "chromebtn";
            this.chromebtn.Size = new System.Drawing.Size(250, 50);
            this.chromebtn.TabIndex = 5;
            this.chromebtn.Text = "Make Chrome Default";
            this.chromebtn.UseVisualStyleBackColor = true;
            this.chromebtn.Click += new System.EventHandler(this.chromebtn_Click);
            // 
            // gsbackup
            // 
            this.gsbackup.Location = new System.Drawing.Point(17, 272);
            this.gsbackup.Name = "gsbackup";
            this.gsbackup.Size = new System.Drawing.Size(250, 59);
            this.gsbackup.TabIndex = 6;
            this.gsbackup.Text = "Create GSBackup on Desktop";
            this.gsbackup.UseVisualStyleBackColor = true;
            this.gsbackup.Click += new System.EventHandler(this.gsbackup_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.gsbackup);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.mcafee);
            this.panel2.Controls.Add(this.chromebtn);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(410, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 365);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 736);
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
        private System.Windows.Forms.Button chromebtn;
        private System.Windows.Forms.Button gsbackup;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
    }
}

