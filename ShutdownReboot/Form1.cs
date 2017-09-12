using System;
using System.Text;
using System.Linq;
using System.Diagnostics;
using System.Windows.Forms;

namespace ShutdownReboot
{
    public partial class Form1 : Form
    {
        private Timer countdown = new Timer();
        private string action = "rebooting";
        private int secs = 5;
        private Boolean countdown_started = false;

        public Form1()
        {
            InitializeComponent();
            //window position
            var desktopWorkingArea = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea;
            this.Left = desktopWorkingArea.Left;
            this.Top = desktopWorkingArea.Bottom - this.Height;

            //uptime
            PerformanceCounter upTime = new PerformanceCounter("System", "System Up Time");
            upTime.NextValue();
            TimeSpan ts = TimeSpan.FromSeconds(upTime.NextValue());

            labelUptime.Text = "Uptime: " + String.Format("{0}d {1}h {2}m", ts.Days, ts.Hours, ts.Minutes);
        }

        private void init_countdown()
        {
            countdown.Tick += new EventHandler(countdown_Tick);
            countdown.Interval = (1000) * (1);
            countdown.Enabled = countdown_started = true;
            countdown.Start();
        }

        private void countdown_Tick(object sender, EventArgs e)
        {
            secs -= 1;
            labelTimeLeft.Text = action + " in " + secs + " seconds";
            labelTimeLeft.Visible = true;
            if (secs <= 0)
            {
                countdown.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            action = "Rebooting";
            buttonShutdown.Enabled = false;
            //System.Diagnostics.Process.Start("ShutDown", "-r -t 5"); //restart
            process_start_hidden("ShutDown", "-r -t 5");
            init_countdown();
        }

        private void buttonShutdown_Click(object sender, EventArgs e)
        {
            action = "Shutting down";
            buttonRestart.Enabled = false;
            //System.Diagnostics.Process.Start("ShutDown", "-s -t 5"); //shutdown
            process_start_hidden("ShutDown", "-s -t 5");
            init_countdown();
        }

        private void process_start_hidden(string processname, string param1)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(processname, param1);
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;

            Process.Start(startInfo);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (countdown_started)
            {
                //System.Diagnostics.Process.Start("ShutDown", "-a");
                process_start_hidden("ShutDown", "-a");
            }
            this.Close();
        }
    }
}