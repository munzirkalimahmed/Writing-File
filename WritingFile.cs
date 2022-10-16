using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DigitalClock
{
    public partial class WritingFile : Form
    {
        public WritingFile()
        {
            InitializeComponent();
        }

        TextWriter tsw;

        private void button1_Click(object sender, EventArgs e)
        {
            tsw = new StreamWriter(@"D:\timer.txt", true);
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void LblStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            tsw.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
            label1.Update();
            label1.Refresh();
            tsw.WriteLine(DateTime.Now.ToString());
        }
    }
}
