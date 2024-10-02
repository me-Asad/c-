using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label1.Text = "00:00:00";
        }
        int mili = 0;
        int second = 0;
        int minute = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            mili++;
            if (mili > 99)
            {
                mili = 0;
                second++;
            }
            if (second> 59)
            {
                second = 0;
                minute++;
            }
            label1.Text = minute.ToString()+":" + second.ToString() + ":" + mili.ToString();
        }
    }
}
