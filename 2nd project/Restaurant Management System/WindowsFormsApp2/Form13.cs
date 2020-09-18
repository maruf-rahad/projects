using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }
        MySqlConnection connection = new MySqlConnection(@"server=localhost;user id=root;database=restaurant management system");
        private void Log_in_Click(object sender, EventArgs e)
        {
            
                string user = textBox1.Text;
                string pass = textBox2.Text;
                
                MySqlDataAdapter sda = new MySqlDataAdapter("select count(*) from log where username = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "'", connection);
                DataTable t = new DataTable();
                sda.Fill(t);

                if (t.Rows[0][0].ToString() == "1")
                {
                Form1 f0 = new Form1();
                f0.Show();
                this.Hide();
            }
                else
                {
           
                MessageBox.Show("Check Your User Name & Password Again.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            

        }

        private void Change_password_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Click(object sender, EventArgs e)
        {

        }
    }
}
