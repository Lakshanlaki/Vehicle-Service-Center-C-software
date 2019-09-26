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
    public partial class Sales : Form
    {

        SqlCommand cd;
        SqlConnection con1;
        SqlDataAdapter da;

        public Sales()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\SHENARA AUTO SERVICE\1.MDF;Integrated Security=True;Connect Timeout=30");
            con1.Open();
            cd = new SqlCommand("INSERT INTO Sales (Item_Code,Price,Date) VALUES(@Item_Code,@Price,@Date)", con1);
            cd.Parameters.Add("@Item_Code", textBox1.Text);
            cd.Parameters.Add("@Price", textBox2.Text);
            cd.Parameters.Add("@Date", textBox3.Text);
            MessageBox.Show("Details Added");
            cd.ExecuteNonQuery();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main nm = new Main();
            nm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sales_Table nm = new Sales_Table();
            nm.Show();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
