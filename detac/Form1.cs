using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace databass_connect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-M561BCP\\SQLEXPRESS;Initial Catalog=mydp;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string Username = textBox1.Text;
            int Pass_word = int.Parse(textBox2.Text);
            string Query = "insert into customer(UserName,Pass_word)values('"+Username+"',"+Pass_word+")";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Data has been Saved", "saved", MessageBoxButtons.OK);
        }

    }
}
