using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-QD2NICG\SQLEXPRESS;Initial Catalog=CarRent;Integrated Security=True");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            string querycar = "select count(*) from CarTable";
            SqlDataAdapter sda= new SqlDataAdapter(querycar,Con);
            DataTable dt= new DataTable();
            sda.Fill(dt);
            CarLbl.Text= dt.Rows[0][0].ToString();

            string querycust = "select count(*) from CustomerTable";
            SqlDataAdapter sda1 = new SqlDataAdapter(querycust, Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            Custlbl.Text = dt1.Rows[0][0].ToString();

            string queryusers = "select count(*) from UserTable";
            SqlDataAdapter sda2 = new SqlDataAdapter(queryusers, Con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            userlbl.Text = dt2.Rows[0][0].ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }
    }
}
