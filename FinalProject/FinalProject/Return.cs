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
    public partial class Return : Form
    {
        public Return()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-QD2NICG\SQLEXPRESS;Initial Catalog=CarRent;Integrated Security=True");

        private void populate()
        {
            Con.Open();
            string query = "select * from RentalTable";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            RentDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void populateRet()
        {
            Con.Open();
            string query = "select * from ReturnTable";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ReturnDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Deleteonreturn()
        {
            int rentId;
            rentId= Convert.ToInt32(RentDGV.Rows[RentDGV.CurrentCell.RowIndex].Cells[0].Value.ToString());
            Con.Open();
            string query = "delete from RentalTable where RentId=" + rentId + ";";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
           // MessageBox.Show("Rental Deleted Successfully");
            Con.Close();
            // UpdateonRentDelelte();
            populate();
        }
        private void Return_Load(object sender, EventArgs e)
        {
            populate();
            populateRet();
        }

        private void RentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

            CarIdTb.Text = RentDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            CustNameTb.Text = RentDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            ReturnDate.Text = RentDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
            DateTime d1 = ReturnDate.Value.Date;
            DateTime d2 = DateTime.Now;
            TimeSpan t = d2 - d1;
            int NrOfDays = Convert.ToInt32(t.TotalDays);
            if (NrOfDays <= 0)
            {
                DelayTb.Text = "No Delay";
                FineTb.Text = "0";
            }
            else
            {
                DelayTb.Text = "" + NrOfDays;
                FineTb.Text = "" + (NrOfDays * 250);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IdTb.Text == "" || CustNameTb.Text == "" || FineTb.Text == "" || DelayTb.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into ReturnTable values(" + IdTb.Text + ",'" + CarIdTb.Text + "','" + CustNameTb.Text + "','" + ReturnDate.Value.ToString("yyyy-MM-dd") + "','" + DelayTb.Text + "'," + FineTb.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Dully Returned");
                    Con.Close();
                    //UpdateonRent();
                    populateRet();
                    Deleteonreturn();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (IdTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();

                    string query = "delete from ReturnTable where ReturnId=" + IdTb.Text;

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();

                    Con.Close();

                    MessageBox.Show("Return Deleted Successfully");

                    populateRet();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void ReturnDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdTb.Text = ReturnDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
