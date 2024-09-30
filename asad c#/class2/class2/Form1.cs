using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int val1 = int.Parse(textBox1.Text);
            int val2 = int.Parse(textBox2.Text);
            int result = val1 + val2;
            MessageBox.Show(result.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int val1 = int.Parse(textBox1.Text);
            int val2 = int.Parse(textBox2.Text);
            int result = val1 - val2;
            MessageBox.Show(result.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int val1 = int.Parse(textBox1.Text);
            int val2 = int.Parse(textBox2.Text);
            int result = val1 / val2;
            MessageBox.Show(result.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int val1 = int.Parse(textBox1.Text);
            int val2 = int.Parse(textBox2.Text);
            int result = val1 * val2;
            MessageBox.Show(result.ToString());
        }
    }
}
