using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sigup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Email = textBox1.Text;
            string Password = textBox2.Text;


            string cEmail = "asad";
            string cPassword = "12345";

            if(Email == cEmail && Password == cPassword)
            {
                MessageBox.Show("Sign Up successful", "successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sign Up Fail", "Fail", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }
    }
}
