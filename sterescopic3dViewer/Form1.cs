using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sterescopic3dViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x = 1;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (x == 1) { x = 0; }
            else { x = 1; }

            if (x == 1) { 
                
                this.BackColor = Color.Blue;
                this.TransparencyKey = Color.Blue;

            }
            if (x == 0)
            {

                this.BackColor = Color.Red;
                this.TransparencyKey = Color.Red;

            }
            

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                timer1.Interval += 10;
            }
            catch { }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
                timer1.Interval -= 10;
            }
            catch { }
            }
    }
}
