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
    public partial class Jam_App : Form
    {
        FormStopWatch stp;
        FormTimer tmr;
        void stp_FormClosed(Object sender, FormClosedEventArgs e)
        {
            stp = null;
        }

        void tmr_FormCLosed(Object sender, FormClosedEventArgs e)
        {
            tmr = null;
        }

        public Jam_App()
        {
            InitializeComponent();
        }

        private void submenu_stopwatch_Click(object sender, EventArgs e)
        {
            if (stp == null)
            {
                stp = new FormStopWatch();
                stp.MdiParent = this;
                stp.FormClosed += stp_FormClosed;
                stp.Show();
            }
            else
            {
                stp.Activate();
            }
        }

        private void submenu_timer_Click(object sender, EventArgs e)
        {
            if (tmr == null)
            {
                tmr = new FormTimer();
                tmr.MdiParent = this;
                tmr.FormClosed += tmr_FormCLosed;
                tmr.Show();
            }
            else
            {
                tmr.Activate();
            }
        }
    }
}
