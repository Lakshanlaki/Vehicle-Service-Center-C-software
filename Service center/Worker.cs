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
    public partial class Worker : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\SHENARA AUTO SERVICE\1.MDF;Integrated Security=True;Connect Timeout=30";
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        public Worker()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main nm = new Main();
            nm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashin\Desktop\Shenara Auto Service\1.MDF;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Worker(worker_ID,worker_name,Tel_no,Address) VALUES(@worker_ID,@worker_name,@Tel_no,@Address)", con);
            cmd.Parameters.Add("@worker_ID", textBox1.Text);
            cmd.Parameters.Add("@worker_name", textBox2.Text);
            cmd.Parameters.Add("@Tel_no", textBox3.Text);
            cmd.Parameters.Add("@Address", textBox4.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Worker Details Added");


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM Worker ", sqlcon);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);

                // showing the table inside the grid
                dataGridView1.DataSource = dtbl;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
