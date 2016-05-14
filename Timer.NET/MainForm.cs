using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer.NET
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            startTime = DateTime.Now;
            timer_Tick(null, null);
            UpdateButtonText();
        }

        private DateTime startTime;
        private bool plaing;

        private void StartStopButton_Click(object sender, EventArgs e)
        {
            if (plaing)
            {
                plaing = false;
                timer.Stop();
                timer_Tick(null, null);
            }
            else
            {
                plaing = true;
                timer.Start();
                startTime = DateTime.Now;
                timer_Tick(null, null);
            }
            UpdateButtonText();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Now.Subtract(startTime);
            timeLabel.Text = span.ToString("h':'mm':'ss''");
        }

        private void UpdateButtonText()
        {
            startStopButton.Text = plaing ? "Stop" : "Start";
        }
    }
}
