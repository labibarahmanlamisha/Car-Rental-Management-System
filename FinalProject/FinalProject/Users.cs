using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-QD2NICG\SQLEXPRESS;Initial Catalog=CarRent;Integrated Security=True");

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from UserTable";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da .Fill(ds);
            UserDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Uid.Text =="" ||  Uname.Text =="" || Upass.Text =="")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query="insert into UserTable values ("+Uid.Text+",'"+Uname.Text+"','"+Upass.Text+"')";
                    SqlCommand cmd = new SqlCommand(query,Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Successfully Added");
                    Con.Close();
                    populate();
                }
                catch(Exception MYex)
                {
                    MessageBox.Show(MYex.Message);
                }
            }
        }

        private void Users_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(Uid.Text =="")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from UserTable where Id=" + Uid.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Deleted Successfully");
                    Con.Close() ;
                    populate();
                }
                catch( Exception MYex)
                {
                    MessageBox.Show( MYex.Message);
                }
            }
        }

        private void UserDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Uid.Text = UserDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                Uname.Text = UserDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                Upass.Text = UserDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Uid.Text == "" || Uname.Text == "" || Upass.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update UserTable set UserName='" + Uname.Text + "',Password='" + Upass.Text + "' where ID=" + Uid.Text + ";";
        
            SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Successfully Updated");
                    Con.Close();
                    populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }
    }
}
