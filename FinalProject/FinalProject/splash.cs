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
    public partial class splash : System.Windows.Forms.Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            Myprogress.Value = startpoint;
            parcentage.Text = "" + startpoint;
            if (Myprogress.Value == 100)
            {
                Myprogress .Value = 0;
                timer1.Stop();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
