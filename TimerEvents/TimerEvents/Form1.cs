using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerEvents
{
    public partial class Form1 : Form
    {

        System.Windows.Forms.Timer my_timer = new System.Windows.Forms.Timer();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            my_timer.Interval = 100;
            my_timer.Tick += new EventHandler(t_Tick);
            my_timer.Start();
        }

        void t_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;

            if (progressBar1.Value >= 100)
                my_timer.Stop();
        }
    }
}
