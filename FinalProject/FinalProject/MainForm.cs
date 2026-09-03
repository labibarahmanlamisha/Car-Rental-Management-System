using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Car car = new Car();
            car.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer customer = new Customer();
            customer.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rental rent = new Rental();
            rent.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Return ret = new Return();
            ret.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users user = new Users();
            user.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashBoard board = new DashBoard();
            board.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
