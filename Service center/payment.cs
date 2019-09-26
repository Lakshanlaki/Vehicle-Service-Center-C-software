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
using System.Data.Sql;


namespace Service_center
{
    public partial class payment : Form
    {
        SqlCommand cdddd;
        SqlConnection con5;
        SqlDataAdapter da;
        public payment()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void payment_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main nm = new Main();
            nm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con5 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\SHENARA AUTO SERVICE\1.MDF;Integrated Security=True;Connect Timeout=30");
            con5.Open();
            cdddd = new SqlCommand("INSERT INTO payment (Customer_id_no,Customer_name,payment) VALUES (@Customer_id_no,@Customer_name,@payment)", con5);
            cdddd.Parameters.Add("@Customer_id_no", textBox1.Text);
            cdddd.Parameters.Add("@Customer_name", textBox2.Text);
            cdddd.Parameters.Add("@payment", textBox3.Text);
            MessageBox.Show("Payment Added");
            
            
            
           

            cdddd.ExecuteNonQuery();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            payment_table nm = new payment_table();
            nm.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox4.Text);
            int num2 = int.Parse(textBox5.Text);
            int sum = num + num2;
            textBox6.Text = sum.ToString();
        }

        private void TextBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
