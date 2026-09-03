namespace FinalProject
{
    partial class splash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splash));
            this.car = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.parcentage = new System.Windows.Forms.Label();
            this.Myprogress = new CircularProgressBar.CircularProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            this.SuspendLayout();
            // 
            // car
            // 
            this.car.Image = ((System.Drawing.Image)(resources.GetObject("car.Image")));
            this.car.Location = new System.Drawing.Point(460, 201);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(141, 92);
            this.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.car.TabIndex = 0;
            this.car.TabStop = false;
            this.car.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // parcentage
            // 
            this.parcentage.AutoSize = true;
            this.parcentage.Location = new System.Drawing.Point(505, 316);
            this.parcentage.Name = "parcentage";
            this.parcentage.Size = new System.Drawing.Size(51, 20);
            this.parcentage.TabIndex = 4;
            this.parcentage.Text = "label2";
            // 
            // Myprogress
            // 
            this.Myprogress.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.Myprogress.AnimationSpeed = 500;
            this.Myprogress.BackColor = System.Drawing.Color.Transparent;
            this.Myprogress.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.Myprogress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Myprogress.InnerColor = System.Drawing.Color.Empty;
            this.Myprogress.InnerMargin = 2;
            this.Myprogress.InnerWidth = -1;
            this.Myprogress.Location = new System.Drawing.Point(371, 101);
            this.Myprogress.MarqueeAnimationSpeed = 2000;
            this.Myprogress.Name = "Myprogress";
            this.Myprogress.OuterColor = System.Drawing.Color.Gray;
            this.Myprogress.OuterMargin = -25;
            this.Myprogress.OuterWidth = 26;
            this.Myprogress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Myprogress.ProgressWidth = 25;
            this.Myprogress.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.Myprogress.Size = new System.Drawing.Size(320, 320);
            this.Myprogress.StartAngle = 270;
            this.Myprogress.SubscriptColor = System.Drawing.Color.Empty;
            this.Myprogress.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.Myprogress.SubscriptText = ".23";
            this.Myprogress.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Myprogress.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.Myprogress.SuperscriptText = "°C";
            this.Myprogress.TabIndex = 5;
            this.Myprogress.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.Myprogress.Value = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(365, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "CAR RENTAL SYSTEM";
            // 
            // splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1036, 589);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.parcentage);
            this.Controls.Add(this.car);
            this.Controls.Add(this.Myprogress);
            this.Name = "splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox car;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label parcentage;
        private CircularProgressBar.CircularProgressBar Myprogress;
        private System.Windows.Forms.Label label1;
    }
}

