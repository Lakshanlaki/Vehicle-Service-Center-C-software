using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service_center
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stocks nm = new Stocks();
            nm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sales nm = new Sales();
            nm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            orders nm = new orders();
            nm.Show();
        }

        private void packagebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Service_Packages nm = new Service_Packages();
            nm.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void paymentbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            payment nm = new payment();
            nm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Worker nm = new Worker();
            nm.Show();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
