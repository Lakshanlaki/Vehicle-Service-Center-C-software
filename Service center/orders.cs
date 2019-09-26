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
    public partial class orders : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        DataTable Orders = new DataTable();

        public orders()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\SHENARA AUTO SERVICE\1.MDF;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Orders (Vehicle_Reg_num,Customer_Name,Vehicle_Type,Mobile_Number) VALUES(@Vehicle_Reg_num,@Customer_Name,@Vehicle_Type,@Mobile_Number)", con);
            cmd.Parameters.Add("@Vehicle_Reg_num", textBox1.Text);
            cmd.Parameters.Add("@Customer_Name", textBox2.Text);
            cmd.Parameters.Add("@Vehicle_Type", textBox3.Text);
            cmd.Parameters.Add("@Mobile_Number", textBox4.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Details Saved");
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
            Orders_table nm = new Orders_table();
            nm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {

        }

        private void Orders_Load(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }
    }
}
