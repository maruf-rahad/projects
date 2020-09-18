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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

       

 

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Form1 f0 = new Form1();
            f0.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void purchased_Click(object sender, EventArgs e)
        {

        }

        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;database=restaurant management system");
        

        private void View_Click(object sender, EventArgs e)
        {
            con.Open();
            
           MySqlDataAdapter SDA = new MySqlDataAdapter ("SELECT * FROM `menu`;", con);
            //SDA.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
              
        }

        

        private void search_Click_1(object sender, EventArgs e)
        {
     
            
                con.Open();
           
            MySqlDataAdapter SDA = new MySqlDataAdapter("select * from menu where Purchased like '%"+comboBox1.Text+"%'", con);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            
          
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand to = new MySqlCommand("DELETE FROM `menu`", con);
            to.ExecuteNonQuery();
            MessageBox.Show("successfully deleted");

            con.Close();
        }

        private void b_Click(object sender, EventArgs e)
        {
            Form14 f12 = new Form14();
            f12.Show();
            this.Hide();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ss;
            ss = comboBox2.Text;
            if (ss == "All")
            {
                MySqlDataAdapter My = new MySqlDataAdapter("select SUM(Bill) from menu where Date between '" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "' and '" + dateTimePicker2.Value.ToString("dd/MM/yyyy") + "'", con);
                // MySqlDataAdapter My = new MySqlDataAdapter("select * from transaction",con);
                DataTable dTable = new DataTable();
                My.Fill(dTable);
                dataGridView1.DataSource = dTable;
            }
            else
            {
                MySqlDataAdapter My = new MySqlDataAdapter("select SUM(Bill) from menu where (Date between '" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "' and '" + dateTimePicker2.Value.ToString("dd/MM/yyyy") + "')AND (Purchased like '%" + comboBox2.Text + "%' )", con);
                // MySqlDataAdapter My = new MySqlDataAdapter("select * from transaction",con);
                DataTable dTable = new DataTable();
                My.Fill(dTable);
                dataGridView1.DataSource = dTable;
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
