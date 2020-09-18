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
    
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }
        decimal pp;
        int x = 0;
        int a = 25;
        int b = 25;
        decimal sum = 0;
        string s, s1,s2,s3,s4,s5,s6,s7,d1,d2,d3,d4,d5,d6,d7,p1,p2,p3,p4,p5,p6,p7,q1,q2,q3,q4,q5,q6,q7,s8;

        private void iteamcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            s8 = iteamcomboBox.Text;
            if (s8 == "classic beef burger")
            {
                pp = 120;
                pricetextBox.Text = pp.ToString();
            }
            
            else if(s8 == "smash burger")
            {
                pp = 180;
                pricetextBox.Text = pp.ToString();
            }
            else if (s8 == "the gangstar burger")
            {
                pp = 300;
                pricetextBox.Text = pp.ToString();
            }
            else if (s8 == "classic chicken burger")
            {
                pp = 110;
                pricetextBox.Text = pp.ToString();
            }
            else if (s8 == "super big mac ham burger")
            {
                pp = 350;
                pricetextBox.Text = pp.ToString();
            }
            else if (s8 == "twilight beef burger")
            {
                pp = 450;
                pricetextBox.Text = pp.ToString();
            }
            else if (s8 == "Batman Pizza")
            {
                pp = 999;
                pricetextBox.Text = pp.ToString();
            }
            else if (s8 == "Macaroni Pizza")
            {
                pp = 250;
                pricetextBox.Text = pp.ToString();
            }
            else if (s8 == "classic Pizza")
            {
                pp = 180;
                pricetextBox.Text = pp.ToString();
            }
            else if (s8 == "Dominos Pizza")
            {
                pp = 1100;
                pricetextBox.Text = pp.ToString();
            }
            else if (s8 == "Spanky Pizza")
            {
                pp = 649;
                pricetextBox.Text = pp.ToString();
            }
            else if (s8 == "Super Egg Pizza")
            {
                pp = 320;
                pricetextBox.Text = pp.ToString();
            }
            else if (s8 == "Regular Fried Chicken")
            {
                pp = 180;
                pricetextBox.Text = pp.ToString();
            }
            else if (s8 == "Mango BBQ Chicken")
            {
                pp = 360;
                pricetextBox.Text = pp.ToString();
            }
            else if (s8 == "Korean Chicken")
            {
                pp = 260;
                pricetextBox.Text = pp.ToString();
            }
            else if (s8 == "Chicken Souvlaki Kebab")
            {
                pp = 300;
                pricetextBox.Text = pp.ToString();
            }
            else if (s8 == "Crispy Fried chicken")
            {
                pp = 420;
                pricetextBox.Text = pp.ToString();
            }
            else if (s8 == "Chicken Marsala")
            {
                pp = 320;
                pricetextBox.Text = pp.ToString();
            }
            else if (s8 == "Mineral Water")
            {
                pp = 30;
                pricetextBox.Text = pp.ToString();
            }
            else if (s8 == "Cocacola")
            {
                pp = 20;
                pricetextBox.Text = pp.ToString();
            }
            else if (s8 == "7up")
            {
                pp = 20;
                pricetextBox.Text = pp.ToString();
            }
            else if (s8 == "Pepsi")
            {
                pp = 20;
                pricetextBox.Text = pp.ToString();
            }
            else if (s8 == "Milk Shake")
            {
                pp = 120;
                pricetextBox.Text = pp.ToString();
            }
            else if (s8 == "Lemon Juice")
            {
                pp = 70;
                pricetextBox.Text = pp.ToString();
            }
            else if (s8 == "Banana Juice")
            {
                pp = 90;
                pricetextBox.Text = pp.ToString();
            }
            else if (s8 == "Lacchi")
            {
                pp = 90;
                pricetextBox.Text = pp.ToString();
            }
           


        }

        private void pricetextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form14_Load(object sender, EventArgs e)
        {
            s = "  Welcome ";
            totaltextBox.Text = s;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


           
           
            iteamcomboBox.SelectedIndex = 0;
            dcomboBox.SelectedIndex = 0;
            qcombobox.SelectedIndex = 0;
            pricetextBox.Clear();
            pricetextBox2.Clear();



            rcomboBox.SelectedIndex = 0;


        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Form12 f11 = new Form12();
            f11.Show();
            this.Hide();
        }
        MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;database=restaurant management system");

        private void Save_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO menu(`Name`, `Purchased`, `Quantity`, `Discount`, `Bill`, `Rating`, `Date`) VALUES('" + clienttextBox.Text + "','" + iteamcomboBox.Text + "','" + qcombobox.Text + "','" + dcomboBox.Text + "','" + pricetextBox2.Text + "','" + rcomboBox.Text + "','" + dateTimePicker1.Text + "')";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            if (x == 0)
            {
                s1 = iteamcomboBox.Text;
                q1 = qcombobox.Text;
                d1 = dcomboBox.Text;
                p1 = pricetextBox2.Text;
            }
            if(x==1)
            {
                s2 = iteamcomboBox.Text;
                q2 = qcombobox.Text;
                d2 = dcomboBox.Text;
                p2 = pricetextBox2.Text;
            }
            if (x == 2)
            {
                s3 = iteamcomboBox.Text;
                q3 = qcombobox.Text;
                d3 = dcomboBox.Text;
                p3 = pricetextBox2.Text;
            }
            if (x == 3)
            {
                s4 = iteamcomboBox.Text;
                q4 = qcombobox.Text;
                d4 = dcomboBox.Text;
                p4 = pricetextBox2.Text;
            }
            if (x == 4)
            {
                s5 = iteamcomboBox.Text;
                q5 = qcombobox.Text;
                d5 = dcomboBox.Text;
                p5 = pricetextBox2.Text;
            }
            if (x == 5)
            {
                s6 = iteamcomboBox.Text;
                q6 = qcombobox.Text;
                d6 = dcomboBox.Text;
                p6 = pricetextBox2.Text;
            }
            if (x == 6)
            {
                s7 = iteamcomboBox.Text;
                q7 = qcombobox.Text;
                d7 = dcomboBox.Text;
                p7 = pricetextBox2.Text;
            }

            MessageBox.Show("Inserted successfully");
            x++;


        }

        private void equal_Click(object sender, EventArgs e)
        {
            decimal total = Convert.ToInt32(qcombobox.Text) * Convert.ToInt32(pricetextBox.Text);
            decimal dis = Convert.ToInt32(dcomboBox.Text);
            total = total - ((total * dis) / 100);
            sum += total;
            pricetextBox2.Text = total.ToString();
            totaltextBox.Text = sum.ToString();


        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void pricetextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void printpre_Click(object sender, EventArgs e)
        {
            printPreview.Document = pDocument;
            printPreview.ShowDialog();
        }
        
        private void pDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            e.Graphics.DrawString("Different Taste", new Font("Arial", 50, FontStyle.Regular), Brushes.Black, new Point(150, 25));
            e.Graphics.DrawString("Banani,Block H,Rd no: 4,Dhaka 1213", new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(115, 100));
            e.Graphics.DrawString("Phone : 01521333***", new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(220, 150));
            e.Graphics.DrawString("Date : " + DateTime.Now, new Font("Arial", 25), Brushes.Black, new Point(170, 200));
            e.Graphics.DrawString("Client name    : " + clienttextBox.Text, new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(80, 250));

            e.Graphics.DrawString("Item", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(10, 300));
            e.Graphics.DrawString("Quantity", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(420, 300));
            e.Graphics.DrawString("Discount", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(550, 300));
            e.Graphics.DrawString("Price", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(700, 300));

            e.Graphics.DrawString(label6.Text, new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(30, 340));

            if (x > 0)
            {
                e.Graphics.DrawString(s1.ToString(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(10, 380));
                e.Graphics.DrawString(q1.ToString(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(460, 380));
                e.Graphics.DrawString(d1.ToString(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(580, 380));
                e.Graphics.DrawString(p1.ToString(), new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(700, 380));
            }
            if(x>1)
            {
                e.Graphics.DrawString(s2.ToString(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(10, 420));
                e.Graphics.DrawString(q2.ToString(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(460, 420));
                e.Graphics.DrawString(d2.ToString(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(580, 420));
                e.Graphics.DrawString(p2.ToString(), new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(700, 420));
            }
            if (x > 2)
            {
                e.Graphics.DrawString(s3.ToString(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(10, 460));
                e.Graphics.DrawString(q3.ToString(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(460, 460));
                e.Graphics.DrawString(d3.ToString(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(580, 460));
                e.Graphics.DrawString(p3.ToString(), new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(700, 460));
            }
            if (x > 3)
            {
                e.Graphics.DrawString(s4.ToString(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(10, 500));
                e.Graphics.DrawString(q4.ToString(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(460, 500));
                e.Graphics.DrawString(d4.ToString(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(580, 500));
                e.Graphics.DrawString(p4.ToString(), new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(700, 500));
            }
            if (x > 4)
            {
                e.Graphics.DrawString(s5.ToString(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(10, 540));
                e.Graphics.DrawString(q5.ToString(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(460, 540));
                e.Graphics.DrawString(d5.ToString(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(580, 540));
                e.Graphics.DrawString(p5.ToString(), new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(700, 540));
            }
            if (x > 5)
            {
                e.Graphics.DrawString(s6.ToString(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(10, 580));
                e.Graphics.DrawString(q6.ToString(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(460, 580));
                e.Graphics.DrawString(d6.ToString(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(580, 580));
                e.Graphics.DrawString(p6.ToString(), new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(700, 580));
            }
            if (x > 6)
            {
                e.Graphics.DrawString(s7.ToString(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(10, 620));
                e.Graphics.DrawString(q7.ToString(), new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(460, 620));
                e.Graphics.DrawString(d7.ToString(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(580, 620));
                e.Graphics.DrawString(p7.ToString(), new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(700, 620));
            }
            e.Graphics.DrawString(label6.Text, new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(30, 650));
            e.Graphics.DrawString("Total", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(50, 700));
            e.Graphics.DrawString(totaltextBox.Text, new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(700, 700));

            e.Graphics.DrawString("Thank You", new Font("Arial", 40, FontStyle.Regular), Brushes.Black, new Point(250, 850));






        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            x = 0;
            sum = 0;
            clienttextBox.Clear();
            iteamcomboBox.SelectedIndex = 0;
            dcomboBox.SelectedIndex = 0;
            qcombobox.SelectedIndex = 0;
            pricetextBox.Clear();
            totaltextBox.Clear();
            clienttextBox.Focus();
            rcomboBox.SelectedIndex = 0;
            pricetextBox2.Clear();

        }

        private void print_Click(object sender, EventArgs e)
        {

        }

        private void printPreview_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }
    }
}
