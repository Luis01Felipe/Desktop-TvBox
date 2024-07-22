namespace Desktop_TvBox
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.btnYoutube = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbClock = new System.Windows.Forms.Label();
            this.timer1 = new System.Timers.Timer();
            this.lbDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYoutube
            // 
            this.btnYoutube.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYoutube.AutoSize = true;
            this.btnYoutube.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYoutube.BackgroundImage")));
            this.btnYoutube.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYoutube.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYoutube.Location = new System.Drawing.Point(405, 145);
            this.btnYoutube.Name = "btnYoutube";
            this.btnYoutube.Size = new System.Drawing.Size(150, 250);
            this.btnYoutube.TabIndex = 0;
            this.btnYoutube.UseVisualStyleBackColor = true;
            this.btnYoutube.Click += new System.EventHandler(this.btnYoutube_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(230, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 250);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(580, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 250);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lbClock
            // 
            this.lbClock.BackColor = System.Drawing.Color.Transparent;
            this.lbClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbClock.Location = new System.Drawing.Point(373, 9);
            this.lbClock.Name = "lbClock";
            this.lbClock.Size = new System.Drawing.Size(200, 50);
            this.lbClock.TabIndex = 3;
            this.lbClock.Text = "00:00";
            this.lbClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1D;
            this.timer1.SynchronizingObject = this;
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Elapsed);
            // 
            // lbDate
            // 
            this.lbDate.BackColor = System.Drawing.Color.Transparent;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDate.Location = new System.Drawing.Point(373, 59);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(200, 50);
            this.lbDate.TabIndex = 4;
            this.lbDate.Text = "quarta, 11, jul";
            this.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbClock);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnYoutube);
            this.Name = "MainScreen";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.MainScreen_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lbDate;

        private System.Timers.Timer timer1;

        private System.Windows.Forms.Label lbClock;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button btnYoutube;

        #endregion
    }
}