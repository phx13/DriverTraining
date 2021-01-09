using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DriverClient
{
    public partial class Option : Form
    {
        public Option()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams p = base.CreateParams;
                p.ExStyle |= 0 * 02000000;
                return p;
            }
        }

        private void RaintrackBar_Scroll(object sender, EventArgs e)
        {
            Rainlabel2.Text = (RaintrackBar.Value*10).ToString();
        }

        private void FogtrackBar_Scroll(object sender, EventArgs e)
        {
            Foglabel2.Text = (FogtrackBar.Value*10).ToString();
        }

        private void TimetrackBar_Scroll(object sender, EventArgs e)
        {
            Timelabel2.Text = TimetrackBar.Value.ToString() + ":00";
        }
    }
}
