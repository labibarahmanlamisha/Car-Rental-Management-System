using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class Rental : Form
    {
        public Rental()
        {
            InitializeComponent();
        }
       SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-QD2NICG\SQLEXPRESS;Initial Catalog=CarRent;Integrated Security=True");
        private void fillcombo()
        {
            Con.Open();
            string query = "select RegNum from CarTable where Available='"+"Yes"+"'";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            rdr=cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("RegNum", typeof(string));
            dt.Load(rdr);
            CarRegCb.ValueMember = "RegNum";
            CarRegCb.DataSource = dt;
            Con.Close();
        }
        private void fillCustomer()
        {
            Con.Open();
            string query = "select CustId from CustomerTable";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CustId", typeof(int));
            dt.Load(rdr);
            CustCb.ValueMember = "CustId";
            CustCb.DataSource = dt;
            Con.Close();
        }
        private void fetchCustName()
        {
            Con.Open();
            string query = "select * from CustomerTable where CustId=" + CustCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                CustNameTb.Text = dr["CustName"].ToString();
            }
            Con.Close();
        }
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
        private void UpdateonRent()
        {
            Con.Open();
            string query = "update CarTable set  Available ='" + "No" + "'  where RegNum='" + CarRegCb.SelectedValue.ToString() + "';";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            //MessageBox.Show("Car Successfully Updated");
            Con.Close();
        }
        private void UpdateonRentDelete(string regNum)
        {
            Con.Open();

            string query = "update CarTable set Available='Yes' where RegNum='" + regNum + "'";

            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();

            Con.Close();
        }
        private void Rental_Load(object sender, EventArgs e)
        {
            fillcombo();
            fillCustomer();
            populate();
        }

        private void CarRegCb_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void CustCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchCustName();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (IdTb.Text == "" || CustNameTb.Text == "" || FeesTb.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into RentalTable values(" + IdTb.Text + ",'" + CarRegCb.SelectedValue.ToString() + "','" + CustNameTb.Text + "','" + RentDate.Value.ToString("yyyy-MM-dd") + "','" + ReturnDate.Value.ToString("yyyy-MM-dd") + "','" + FeesTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Successfully Rented");
                    Con.Close();
                    UpdateonRent();
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
                    string regNum = RentDGV.Rows[RentDGV.CurrentCell.RowIndex].Cells[1].Value.ToString();

                    Con.Open();

                    string query = "delete from RentalTable where RentId=" + IdTb.Text;
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();

                    Con.Close();

                    UpdateonRentDelete(regNum);

                    MessageBox.Show("Rental Deleted Successfully");

                    populate();
                    fillcombo();
                }
                catch (Exception Myex)
                {
                    if (Con.State == ConnectionState.Open)
                        Con.Close();

                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void RentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                IdTb.Text = RentDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                CarRegCb.SelectedValue = RentDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                CustNameTb.Text = RentDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                RentDate.Value = Convert.ToDateTime(RentDGV.Rows[e.RowIndex].Cells[3].Value);
                ReturnDate.Value = Convert.ToDateTime(RentDGV.Rows[e.RowIndex].Cells[4].Value);
                FeesTb.Text = RentDGV.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IdTb.Text == "" || CustNameTb.Text == "" || FeesTb.Text == "")
            {
                MessageBox.Show("Missing Information");
                return;
            }

            try
            {
                Con.Open();

                string query = "update RentalTable set CarReg='" +
                    CarRegCb.SelectedValue.ToString() +
                    "', CustName='" + CustNameTb.Text +
                    "', RentDate='" + RentDate.Value.ToString("yyyy-MM-dd") +
                    "', ReturnDate='" + ReturnDate.Value.ToString("yyyy-MM-dd") +
                    "', Fees='" + FeesTb.Text +
                    "' where RentId=" + IdTb.Text;

                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();

                Con.Close();

                MessageBox.Show("Rental Updated Successfully");

                populate();
            }
            catch (Exception ex)
            {
                Con.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
