namespace FinalProject
{
    partial class Rental
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rental));
            this.RentDGV = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.IdTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.FeesTb = new System.Windows.Forms.TextBox();
            this.CustNameTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.CarRegCb = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.RentDate = new System.Windows.Forms.DateTimePicker();
            this.ReturnDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.CustCb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.RentDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RentDGV
            // 
            this.RentDGV.BackgroundColor = System.Drawing.Color.White;
            this.RentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentDGV.Location = new System.Drawing.Point(389, 179);
            this.RentDGV.Name = "RentDGV";
            this.RentDGV.RowHeadersWidth = 62;
            this.RentDGV.RowTemplate.Height = 28;
            this.RentDGV.Size = new System.Drawing.Size(645, 420);
            this.RentDGV.TabIndex = 63;
            this.RentDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RentDGV_CellContentClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(115, 519);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 37);
            this.button4.TabIndex = 62;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(231, 476);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 36);
            this.button3.TabIndex = 61;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(119, 476);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 37);
            this.button2.TabIndex = 60;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 37);
            this.button1.TabIndex = 59;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IdTb
            // 
            this.IdTb.Location = new System.Drawing.Point(134, 173);
            this.IdTb.Name = "IdTb";
            this.IdTb.Size = new System.Drawing.Size(179, 26);
            this.IdTb.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 20);
            this.label7.TabIndex = 57;
            this.label7.Text = "ID";
            // 
            // FeesTb
            // 
            this.FeesTb.Location = new System.Drawing.Point(134, 414);
            this.FeesTb.Name = "FeesTb";
            this.FeesTb.Size = new System.Drawing.Size(179, 26);
            this.FeesTb.TabIndex = 56;
            // 
            // CustNameTb
            // 
            this.CustNameTb.Location = new System.Drawing.Point(134, 307);
            this.CustNameTb.Name = "CustNameTb";
            this.CustNameTb.Size = new System.Drawing.Size(179, 26);
            this.CustNameTb.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 54;
            this.label4.Text = "Fees";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 53;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(656, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 26);
            this.label6.TabIndex = 52;
            this.label6.Text = "Cars On Rent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1020, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(457, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rental";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(361, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "CAR RENTAL SYSTEM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 687);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1051, 42);
            this.panel2.TabIndex = 51;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 100);
            this.panel1.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 67;
            this.label9.Text = "CarReg";
            // 
            // CarRegCb
            // 
            this.CarRegCb.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.CarRegCb.FormattingEnabled = true;
            this.CarRegCb.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.CarRegCb.Location = new System.Drawing.Point(134, 221);
            this.CarRegCb.Name = "CarRegCb";
            this.CarRegCb.Size = new System.Drawing.Size(179, 28);
            this.CarRegCb.TabIndex = 66;
            this.CarRegCb.SelectionChangeCommitted += new System.EventHandler(this.CarRegCb_SelectionChangeCommitted);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 275);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 68;
            this.label10.Text = "CusId";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 70;
            this.label8.Text = "Rental Date";
            // 
            // RentDate
            // 
            this.RentDate.Location = new System.Drawing.Point(134, 339);
            this.RentDate.Name = "RentDate";
            this.RentDate.Size = new System.Drawing.Size(179, 26);
            this.RentDate.TabIndex = 71;
            // 
            // ReturnDate
            // 
            this.ReturnDate.Location = new System.Drawing.Point(134, 371);
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.Size = new System.Drawing.Size(179, 26);
            this.ReturnDate.TabIndex = 73;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 376);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 20);
            this.label11.TabIndex = 72;
            this.label11.Text = "Return Date";
            // 
            // CustCb
            // 
            this.CustCb.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.CustCb.FormattingEnabled = true;
            this.CustCb.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.CustCb.Location = new System.Drawing.Point(134, 267);
            this.CustCb.Name = "CustCb";
            this.CustCb.Size = new System.Drawing.Size(179, 28);
            this.CustCb.TabIndex = 74;
            this.CustCb.SelectionChangeCommitted += new System.EventHandler(this.CustCb_SelectionChangeCommitted);
            // 
            // Rental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 729);
            this.Controls.Add(this.CustCb);
            this.Controls.Add(this.ReturnDate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.RentDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CarRegCb);
            this.Controls.Add(this.RentDGV);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IdTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FeesTb);
            this.Controls.Add(this.CustNameTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Rental";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rental";
            this.Load += new System.EventHandler(this.Rental_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RentDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView RentDGV;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox IdTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox FeesTb;
        private System.Windows.Forms.TextBox CustNameTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CarRegCb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker RentDate;
        private System.Windows.Forms.DateTimePicker ReturnDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CustCb;
    }
}