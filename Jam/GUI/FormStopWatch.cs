using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Jam.GUI
{
    public partial class FormStopWatch: Form
    {
        System.Timers.Timer timer;
        int h, m, s, ms;

        public FormStopWatch()
        {
            InitializeComponent();
        }

        private void FormStopWatch_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1;
            timer.Elapsed += OnTimeEvent;
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {

                ms += 1;
                if (ms == 60)
                {
                    ms = 0;
                    s += 1;
                }

                if (s == 60)
                {
                    s = 0;
                    m += 1;
                }

                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }

                label1.Text = string.Format("{0}:{1}:{2}:{3}",
                    h.ToString().ToString().PadLeft(2, '0'),
                    m.ToString().ToString().PadLeft(2, '0'),
                    s.ToString().ToString().PadLeft(2, '0'),
                    ms.ToString().ToString().PadLeft(2, '0'));

            }));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_start_Click(object sender, EventArgs e)
        {
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
            ms = 0;
            label1.Text = "00:00:00:00";
        }
    }
}
