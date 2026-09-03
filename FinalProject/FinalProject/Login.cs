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
    public partial class Login : System.Windows.Forms.Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Uname.Text = "";
            PassTb.Text = "";
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-QD2NICG\SQLEXPRESS;Initial Catalog=CarRent;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select count(*) from UserTable where UserName='" + Uname.Text + "' and Password='" + PassTb.Text + "'";
            Con.Open();
            SqlDataAdapter sda= new SqlDataAdapter(query,Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MainForm mainform= new MainForm();
                mainform.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
            Con.Close();
        }
    }
}
