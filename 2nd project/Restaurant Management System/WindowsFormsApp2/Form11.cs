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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Form1 f0 = new Form1();
            f0.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;database=restaurant management system");

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO specialcustomer(`Name`, `PhoneNumbers`,`id`) VALUES('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Inserted successfully");
        }

        private void View_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from specialcustomer";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();

            MySqlDataAdapter SDA = new MySqlDataAdapter("select * from specialcustomer where Name like '%" + textBox2.Text + "%'", con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            con.Open();

            MySqlCommand SDA = new MySqlCommand("DELETE FROM `specialcustomer` WHERE Name= '" + textBox2.Text + "'", con);
            SDA.ExecuteNonQuery();
            MessageBox.Show("successfully deleted");
          
            con.Close();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand to = new MySqlCommand("DELETE FROM `specialcustomer`", con);
            to.ExecuteNonQuery();
            MessageBox.Show("successfully deleted");

            con.Close();
        }
    }
}
