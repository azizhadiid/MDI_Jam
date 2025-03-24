using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jam.GUI
{
    public partial class FormTimer: Form
    {
        int h;
        int m;
        int s;
        public FormTimer()
        {
            InitializeComponent();
            timer.Interval = 1000; 
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if (textBoxH.Text == "")
            {
                textBoxH.Text = "0";
            }
            if (textBoxM.Text == "")
            {
                textBoxM.Text = "0";
            }
            if (textBoxS.Text == "")
            {
                textBoxS.Text = "0";
            }

            h = Convert.ToInt32(textBoxH.Text);
            m = Convert.ToInt32(textBoxM.Text);
            s = Convert.ToInt32(textBoxS.Text);

            timer.Start();
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            timer.Stop();
            h = 0;
            m = 0;
            s = 0;
            labelH.Text = "00";
            labelM.Text = "00";
            labelS.Text = "00";
        }

        private void timer_Tick_1(object sender, EventArgs e)
        {
            s -= 1;

            if (s == -1)
            {
                m -= 1;
                s = 59;
            }

            if (m == -1)
            {
                h -= 1;
                m = 59;
            }

            if (h == 0 && m == 0 && s == 0)
            {
                timer.Stop();
                MessageBox.Show("Times Up", "Time");
            }

            string hh = Convert.ToString(h);
            string mm = Convert.ToString(m);
            string ss = Convert.ToString(s);

            labelH.Text = h.ToString("D2");
            labelM.Text = m.ToString("D2");
            labelS.Text = s.ToString("D2");
        }
    }
}
