using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clickergame
{
    public partial class Form1 : Form
    {
        int clicks = 1;
        double _ticks;
        int cpm;
        int upgrade;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clicks++;
            label1.Text = "clicks: " + clicks;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks++;
            label3.Text = "time: " + _ticks.ToString();
            if (_ticks == 600)
            {
                clicks = clicks + cpm;
                timer1.Stop();
                timer1.Start();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (clicks >= 100)
            {
                upgrade = upgrade + 10;
                clicks = clicks - 100;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (clicks >= 1000)
            {
                upgrade = upgrade + 100;
                clicks = clicks - 1000;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (clicks >= 10000)
            {
                 upgrade = upgrade + 1000;
                 clicks = clicks - 10000;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

            int tick = Convert.ToInt32(_ticks);
            cpm = tick / clicks;
            cpm = cpm + upgrade;
            label2.Text = "clicks bonus " + cpm;
        }
    }
}
