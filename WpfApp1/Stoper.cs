using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WpfApp1
{
    public partial class Stoper : Form
    {
        int timeCs, timeSec, timeMin,timeHr;
        bool isActive;

        

        private void button1_Click(object sender, EventArgs e)
        {
            isActive = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isActive = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            isActive = false;
            ResetTime();
        }

        private void ResetTime()
        {
            timeCs = 0;
            timeSec = 0;
            timeMin = 0;
            timeHr = 0;
        }
        private void DrawTime()
        {

            LabelCs.Text = String.Format("{0:00}",timeCs);
            LabelSec.Text = String.Format("{0:00}", timeSec);
            LabelMin.Text = String.Format("{0:00}", timeMin);
            LabelHr.Text = String.Format("{0:00}", timeHr);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isActive == true)
            {
                timeCs++;
                if (timeCs >= 60)
                {
                    timeSec++;
                    timeCs = 0;
                    if (timeSec >= 60)
                    {
                        timeMin++;
                        timeSec = 0;
                        if (timeHr >=60)
                        {
                            timeHr++;
                            timeMin = 0;
                        }
                    }
                }
            }
            DrawTime();
            
        }

       
        public Stoper()
        {
            InitializeComponent();
        }
        private void Stoper_Load(object sender, EventArgs e)
        {

            ResetTime();
            IsAccessible = false;
        }
    }
}
