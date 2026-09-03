namespace FinalProject
{
    partial class Car
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Car));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CarsDGV = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.RegNumtb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Modeltb = new System.Windows.Forms.TextBox();
            this.Brandtb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Pricetb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Availablecb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarsDGV)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 2;
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
            this.label2.Location = new System.Drawing.Point(422, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Manage Cars";
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
            this.panel2.TabIndex = 9;
            // 
            // CarsDGV
            // 
            this.CarsDGV.BackgroundColor = System.Drawing.Color.White;
            this.CarsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarsDGV.Location = new System.Drawing.Point(365, 222);
            this.CarsDGV.Name = "CarsDGV";
            this.CarsDGV.RowHeadersWidth = 62;
            this.CarsDGV.RowTemplate.Height = 28;
            this.CarsDGV.Size = new System.Drawing.Size(674, 420);
            this.CarsDGV.TabIndex = 31;
            this.CarsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CarsDGV_CellContentClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(135, 498);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 37);
            this.button4.TabIndex = 30;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(251, 455);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 36);
            this.button3.TabIndex = 29;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(139, 455);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 37);
            this.button2.TabIndex = 28;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(23, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 37);
            this.button1.TabIndex = 27;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegNumtb
            // 
            this.RegNumtb.Location = new System.Drawing.Point(139, 169);
            this.RegNumtb.Name = "RegNumtb";
            this.RegNumtb.Size = new System.Drawing.Size(179, 26);
            this.RegNumtb.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "RegNo";
            // 
            // Modeltb
            // 
            this.Modeltb.Location = new System.Drawing.Point(139, 268);
            this.Modeltb.Name = "Modeltb";
            this.Modeltb.Size = new System.Drawing.Size(179, 26);
            this.Modeltb.TabIndex = 24;
            // 
            // Brandtb
            // 
            this.Brandtb.Location = new System.Drawing.Point(139, 216);
            this.Brandtb.Name = "Brandtb";
            this.Brandtb.Size = new System.Drawing.Size(179, 26);
            this.Brandtb.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Model";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Brand";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(634, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 26);
            this.label6.TabIndex = 20;
            this.label6.Text = "Cars List";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Pricetb
            // 
            this.Pricetb.Location = new System.Drawing.Point(139, 316);
            this.Pricetb.Name = "Pricetb";
            this.Pricetb.Size = new System.Drawing.Size(179, 26);
            this.Pricetb.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Price";
            // 
            // Availablecb
            // 
            this.Availablecb.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Availablecb.FormattingEnabled = true;
            this.Availablecb.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.Availablecb.Location = new System.Drawing.Point(139, 363);
            this.Availablecb.Name = "Availablecb";
            this.Availablecb.Size = new System.Drawing.Size(179, 28);
            this.Availablecb.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 366);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "Available";
            // 
            // Search
            // 
            this.Search.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Search.FormattingEnabled = true;
            this.Search.Items.AddRange(new object[] {
            "Available",
            "Rented"});
            this.Search.Location = new System.Drawing.Point(590, 167);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(179, 28);
            this.Search.TabIndex = 36;
            this.Search.SelectionChangeCommitted += new System.EventHandler(this.Search_SelectionChangeCommitted);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(794, 162);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 37);
            this.button5.TabIndex = 37;
            this.button5.Text = "Refresh";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Car
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 729);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Availablecb);
            this.Controls.Add(this.Pricetb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CarsDGV);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RegNumtb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Modeltb);
            this.Controls.Add(this.Brandtb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Car";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car";
            this.Load += new System.EventHandler(this.Car_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView CarsDGV;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox RegNumtb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Modeltb;
        private System.Windows.Forms.TextBox Brandtb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Pricetb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Availablecb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Search;
        private System.Windows.Forms.Button button5;
    }
}