using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Service_center
{
    public partial class Stocks : Form
    {
        SqlCommand cmdd;
        SqlConnection con2;
        SqlDataAdapter da;
        public Stocks()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            con2 = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =E:\SHENARA AUTO SERVICE\1.MDF; Integrated Security = True; Connect Timeout = 30");
            con2.Open();
            cmdd = new SqlCommand("INSERT INTO Stock (Item_ID,Item_Name,Storing_Date,Selling_Date,Selling_price,Number_of_Items) VALUES(@Item_ID,@Item_Name,@Storing_Date,@Selling_Date,@Selling_price,@Number_of_Items)", con2);
            cmdd.Parameters.Add("@Item_ID", textBox1.Text);
            cmdd.Parameters.Add("@Item_Name", textBox2.Text);
            cmdd.Parameters.Add("@Storing_Date", textBox3.Text);
            cmdd.Parameters.Add("@Selling_Date", textBox4.Text);
            cmdd.Parameters.Add("@Selling_price", textBox5.Text);
            cmdd.Parameters.Add("@Number_of_Items", textBox6.Text);
            cmdd.ExecuteNonQuery();
            MessageBox.Show("Stock Added");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main nm = new Main();
            nm.Show();
        }

        private void Stocks_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stock_Table nm = new Stock_Table();
            nm.Show();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }
    }
}
