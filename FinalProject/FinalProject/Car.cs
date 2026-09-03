using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FinalProject
{
    public partial class Car : Form
    {
        public Car()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-QD2NICG\SQLEXPRESS;Initial Catalog=CarRent;Integrated Security=True");
        private void populate()
        {
            Con.Open();
            string query = "select * from CarTable";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            CarsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (RegNumtb.Text == "" || Brandtb.Text == "" || Modeltb.Text == "" || Pricetb.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into CarTable values('" + RegNumtb.Text + "','" + Brandtb.Text + "','" + Modeltb.Text + "','" + Availablecb.SelectedItem.ToString() + "','" + Pricetb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Successfully Added");
                    Con.Close();
                    populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }
        

        private void Car_Load(object sender, EventArgs e)
        {
            populate();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (RegNumtb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from CarTable where RegNum='" + RegNumtb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Deleted Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception MYex)
                {
                    MessageBox.Show(MYex.Message);
                }
            }
        }

        private void CarsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                RegNumtb.Text = CarsDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                Brandtb.Text = CarsDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                Modeltb.Text = CarsDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                Availablecb.SelectedItem = CarsDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
                Pricetb.Text = CarsDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (RegNumtb.Text == "" || Brandtb.Text == "" || Modeltb.Text == "" || Pricetb.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update CarTable set Brand='" + Brandtb.Text + "',Model='" + Modeltb.Text + "', Available ='" + Availablecb.SelectedItem.ToString() + "',Price=" + Pricetb.Text + " where RegNum='" + RegNumtb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Successfully Updated");
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

        private void button5_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void Search_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string flag = "";
            if (Search.SelectedItem.ToString() == "Available")
            {
                flag = "Yes";

            }
            else
            {
                flag = "No";
            }
            Con.Open();
            string query = "select * from CarTable where Available ='"+flag+"' ";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            CarsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
    }
}
