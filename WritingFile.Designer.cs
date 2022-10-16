namespace DigitalClock
{
    partial class WritingFile
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
            this.label1 = new System.Windows.Forms.Label();
            this.LblStart = new System.Windows.Forms.Button();
            this.LblStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(321, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Writing to file....";
            // 
            // LblStart
            // 
            this.LblStart.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblStart.Location = new System.Drawing.Point(216, 328);
            this.LblStart.Name = "LblStart";
            this.LblStart.Size = new System.Drawing.Size(215, 92);
            this.LblStart.TabIndex = 1;
            this.LblStart.Text = "Start";
            this.LblStart.UseVisualStyleBackColor = true;
            this.LblStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblStop
            // 
            this.LblStop.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblStop.Location = new System.Drawing.Point(476, 328);
            this.LblStop.Name = "LblStop";
            this.LblStop.Size = new System.Drawing.Size(215, 92);
            this.LblStop.TabIndex = 2;
            this.LblStop.Text = "Stop";
            this.LblStop.UseVisualStyleBackColor = true;
            this.LblStop.Click += new System.EventHandler(this.LblStop_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StopandStarttimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 514);
            this.Controls.Add(this.LblStop);
            this.Controls.Add(this.LblStart);
            this.Controls.Add(this.label1);
            this.Name = "StopandStarttimer";
            this.Text = "StopandStarttimer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button LblStart;
        private Button LblStop;
        private System.Windows.Forms.Timer timer1;
    }
}