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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(306, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "Check For Updates";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxConsoleOutput
            // 
            this.textBoxConsoleOutput.Location = new System.Drawing.Point(12, 541);
            this.textBoxConsoleOutput.Multiline = true;
            this.textBoxConsoleOutput.Name = "textBoxConsoleOutput";
            this.textBoxConsoleOutput.Size = new System.Drawing.Size(717, 167);
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
            this.panel1.Location = new System.Drawing.Point(230, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 337);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 3);
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
            this.applicationsCheckbox.Location = new System.Drawing.Point(21, 40);
            this.applicationsCheckbox.Name = "applicationsCheckbox";
            this.applicationsCheckbox.Size = new System.Drawing.Size(240, 246);
            this.applicationsCheckbox.TabIndex = 1;
            this.applicationsCheckbox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // confirmInstalls
            // 
            this.confirmInstalls.Location = new System.Drawing.Point(25, 292);
            this.confirmInstalls.Name = "confirmInstalls";
            this.confirmInstalls.Size = new System.Drawing.Size(236, 33);
            this.confirmInstalls.TabIndex = 2;
            this.confirmInstalls.Text = "Run Installers";
            this.confirmInstalls.UseVisualStyleBackColor = true;
            this.confirmInstalls.Click += new System.EventHandler(this.button2_Click);
            // 
            // mcafee
            // 
            this.mcafee.Location = new System.Drawing.Point(217, 390);
            this.mcafee.Name = "mcafee";
            this.mcafee.Size = new System.Drawing.Size(305, 68);
            this.mcafee.TabIndex = 4;
            this.mcafee.Text = "Remove McAfee";
            this.mcafee.UseVisualStyleBackColor = true;
            this.mcafee.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 736);
            this.Controls.Add(this.mcafee);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxConsoleOutput);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}

