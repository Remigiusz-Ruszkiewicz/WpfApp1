using System;
using System.Windows.Forms;
using System.Windows.Input;
using KeyEventArgs = System.Windows.Input.KeyEventArgs;

namespace WpfApp1
{
    public partial class Minutnik : Form
    {
        private bool isActive = false;



        //public int min()

        //{
        //    //int min = int.Parse(textBoxMin.Text);           
        //    //int min = Convert.ToInt32(textBoxMin.Text);

        //    int min;

        //    if (int.TryParse(textBoxMin.Text, out min))
        //    {
        //        //parsing successful 
        //        min = int.Parse(textBoxMin.Text);

        //    }
        //    else
        //    {
        //        //parsing failed. 
        //    }

        //    return min;
        //}
        //public int sec()
        //{
        //    //int sec = int.Parse(textBoxSec.Text);

        //    int sec;

        //    if (int.TryParse(textBoxSec.Text, out sec))
        //    {
        //        //parsing successful 
        //        sec = int.Parse(textBoxSec.Text);

        //    }
        //    else
        //    {
        //        //parsing failed. 
        //    }

        //    return sec;
        //}
        //public int mi()
        //{
        //    return min();
        //}
        //public int se()
        //{
        //    return sec();
        //}
        //    public int min()
        //{
        //    ConsoleKeyInfo key = Console.ReadKey();
        //    if (key.Key == ConsoleKey.Enter)
        //    {
        //        int text1 = Convert.ToInt32(textBoxMin.Text);
        //        int text2 = Convert.ToInt32(textBoxSec.Text);
        //    }
        //    return text1;
        //}
        public string listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string min = listBox1.Text;
            return min;
        }

        public string listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sec = listBox2.Text;
            return sec;
        }
        public Minutnik()
        {
            InitializeComponent();

        }
        private void Minutnik_Load(object sender, EventArgs e)
        {

        }
        int mii
        private void DrawTime()
        {

            //labelMin.Text = String.Format("{0:00}", min());
            //labelSec.Text = String.Format("{0:00}", sec());
            labelMin.Text = string.Format("{0:00}", min);
            labelSec.Text = string.Format("{0:00}", sec);
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            isActive = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            isActive = false;
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            isActive = false;
            DrawTime();


        }

        public void Timer1_Tick(object sender, EventArgs e)
        {
            int minu = min;
            int sek = sec;

            if (isActive == true)
            {
                sek--;
                if (sek == 0)
                {
                    minu--;
                    sek = 60;
                }
            }

            DrawTime();
        }

        private void textBoxMin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {

            }
        }
    }
}
