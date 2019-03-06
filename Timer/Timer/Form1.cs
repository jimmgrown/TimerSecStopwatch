using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        double sec = 0;
        Stopwatch stopwatch = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //sec += 0.01;
            //label1.Text = sec.ToString();
            double znach = stopwatch.ElapsedTicks / (Stopwatch.Frequency / (1.0));
            label1.Text = string.Format("{0:d2}:{1:d2}:{2:f6}", (int)(znach / 3600),(int)(znach / 60 % 3600), znach % 60);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!stopwatch.IsRunning)
            {
                timer1.Start();
                stopwatch.Start();
                button1.Text = "Стоп";
                button2.Enabled = true;
            }
            else
            {
                timer1.Stop();
                stopwatch.Stop();
                button1.Text = "Старт";
                button2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
        }
    }
}
