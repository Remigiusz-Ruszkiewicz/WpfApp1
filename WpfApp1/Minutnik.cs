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
    public partial class Minutnik : Form
    {
        bool isActive;
        public int min()
        {
            //int min = int.Parse(textBoxMin.Text);           
            //int min = Convert.ToInt32(textBoxMin.Text);

            int min;

            if (int.TryParse(textBoxMin.Text, out min))
            {
                //parsing successful 
                min = int.Parse(textBoxMin.Text);

            }
            else
            {
                //parsing failed. 
            }      
   
            return min;
        }
        public int sec()
        {
            //int sec = int.Parse(textBoxSec.Text);

            int sec;

            if (int.TryParse(textBoxSec.Text, out sec))
            {
                //parsing successful 
                sec = int.Parse(textBoxSec.Text);

            }
            else
            {
                //parsing failed. 
            }

            return sec;
        }
        public int mi()
        {
            return min();
        }
        public int se()
        {
            return sec();
        }
        public Minutnik()
        {
            InitializeComponent();
            
        }

        private void Minutnik_Load(object sender, EventArgs e)
        {

        }
        private void DrawTime()
        {
            
            //labelMin.Text = String.Format("{0:00}", min());
            //labelSec.Text = String.Format("{0:00}", sec());
            labelMin.Text = String.Format("{0:00}", mi());
            labelSec.Text = String.Format("{0:00}", se());
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            DrawTime();
            isActive = true;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            isActive = false;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            int min = int.Parse(textBoxMin.Text);
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            int sec = int.Parse(textBoxSec.Text);
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            isActive = false;

            
        }
      
        public void Timer1_Tick(object sender, EventArgs e)
        {
            var m = min();
            var s = sec();

            if (isActive == true)
            {
                s--;
                if (s == 0)
                {
                    m--;
                    s = 60;
                }
            }
            
            DrawTime();
        }
    }
}
