namespace ShutdownReboot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonShutdown = new System.Windows.Forms.Button();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.labelTimeLeft = new System.Windows.Forms.Label();
            this.labelUptime = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // buttonShutdown
            // 
            this.buttonShutdown.Location = new System.Drawing.Point(23, 33);
            this.buttonShutdown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonShutdown.Name = "buttonShutdown";
            this.buttonShutdown.Size = new System.Drawing.Size(97, 37);
            this.buttonShutdown.TabIndex = 0;
            this.buttonShutdown.Text = "Shutdown";
            this.buttonShutdown.UseVisualStyleBackColor = true;
            this.buttonShutdown.Click += new System.EventHandler(this.buttonShutdown_Click);
            // 
            // buttonRestart
            // 
            this.buttonRestart.Location = new System.Drawing.Point(133, 33);
            this.buttonRestart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(97, 37);
            this.buttonRestart.TabIndex = 1;
            this.buttonRestart.Text = "Reboot";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // labelTimeLeft
            // 
            this.labelTimeLeft.AutoSize = true;
            this.labelTimeLeft.Location = new System.Drawing.Point(9, 105);
            this.labelTimeLeft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTimeLeft.Name = "labelTimeLeft";
            this.labelTimeLeft.Size = new System.Drawing.Size(70, 13);
            this.labelTimeLeft.TabIndex = 3;
            this.labelTimeLeft.Text = "labelTimeLeft";
            this.labelTimeLeft.Visible = false;
            // 
            // labelUptime
            // 
            this.labelUptime.AutoSize = true;
            this.labelUptime.Location = new System.Drawing.Point(9, 119);
            this.labelUptime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUptime.Name = "labelUptime";
            this.labelUptime.Size = new System.Drawing.Size(62, 13);
            this.labelUptime.TabIndex = 4;
            this.labelUptime.Text = "labelUptime";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.linkLabel1.Location = new System.Drawing.Point(207, 91);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(40, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Cancel";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 141);
            this.ControlBox = false;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.labelUptime);
            this.Controls.Add(this.labelTimeLeft);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.buttonShutdown);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShutdown;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Label labelTimeLeft;
        private System.Windows.Forms.Label labelUptime;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

