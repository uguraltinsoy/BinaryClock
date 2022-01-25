using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace BinaryClock
{
    public partial class Form1 : Form
    {
        Panel[,] panels = new Panel[4, 6];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;

            panels[0, 0] = panel1;
            panels[0, 1] = panel2;
            panels[0, 2] = panel3;
            panels[0, 3] = panel4;
            panels[0, 4] = panel5;
            panels[0, 5] = panel6;
            panels[1, 0] = panel7;
            panels[1, 1] = panel8;
            panels[1, 2] = panel9;
            panels[1, 3] = panel10;
            panels[1, 4] = panel11;
            panels[1, 5] = panel12;
            panels[2, 0] = panel13;
            panels[2, 1] = panel14;
            panels[2, 2] = panel15;
            panels[2, 3] = panel16;
            panels[2, 4] = panel17;
            panels[2, 5] = panel18;
            panels[3, 0] = panel19;
            panels[3, 1] = panel20;
            panels[3, 2] = panel21;
            panels[3, 3] = panel22;
            panels[3, 4] = panel23;
            panels[3, 5] = panel24;

            Thread thread = new Thread(new ThreadStart(Work));
            thread.Start();        
        }

        public void Work()
        {
            while (true)
            {
                Thread.Sleep(1000);
                DateTime time = DateTime.Now;
                DateTime newDate = time.AddMinutes(10);
                string hour = newDate.ToString("HH");
                string minute = newDate.ToString("mm");
                string second = newDate.ToString("ss");

                panels[2, 0].BackColor = Color.FromArgb(64, 64, 64);
                panels[3, 0].BackColor = Color.FromArgb(64, 64, 64);

                panels[0, 1].BackColor = Color.FromArgb(64, 64, 64);
                panels[1, 1].BackColor = Color.FromArgb(64, 64, 64);
                panels[2, 1].BackColor = Color.FromArgb(64, 64, 64);
                panels[3, 1].BackColor = Color.FromArgb(64, 64, 64);

                panels[0, 2].BackColor = Color.FromArgb(64, 64, 64);
                panels[1, 2].BackColor = Color.FromArgb(64, 64, 64);
                panels[2, 2].BackColor = Color.FromArgb(64, 64, 64);
                panels[3, 2].BackColor = Color.FromArgb(64, 64, 64);

                panels[0, 3].BackColor = Color.FromArgb(64, 64, 64);
                panels[1, 3].BackColor = Color.FromArgb(64, 64, 64);
                panels[2, 3].BackColor = Color.FromArgb(64, 64, 64);
                panels[3, 3].BackColor = Color.FromArgb(64, 64, 64);

                panels[0, 4].BackColor = Color.FromArgb(64, 64, 64);
                panels[1, 4].BackColor = Color.FromArgb(64, 64, 64);
                panels[2, 4].BackColor = Color.FromArgb(64, 64, 64);
                panels[3, 4].BackColor = Color.FromArgb(64, 64, 64);

                panels[0, 5].BackColor = Color.FromArgb(64, 64, 64);
                panels[1, 5].BackColor = Color.FromArgb(64, 64, 64);
                panels[2, 5].BackColor = Color.FromArgb(64, 64, 64);
                panels[3, 5].BackColor = Color.FromArgb(64, 64, 64);


                Hour(hour);
                Min(minute);
                Sec(second);
            }
        }

        private void Hour(string hour)
        {
            int digi_1 = Convert.ToInt32(hour[0] - '0');
            int digi_2 = Convert.ToInt32(hour[1] - '0');
            label5.Text = digi_1.ToString();
            label6.Text = digi_2.ToString();

            if (digi_1 == 1) panels[3, 0].BackColor = Color.Blue;
            if (digi_1 == 2) panels[2, 0].BackColor = Color.Blue;

            if (digi_2 == 1)
            {
                panels[3, 1].BackColor = Color.Blue;
            }
            else if (digi_2 == 2)
            {
                panels[2, 1].BackColor = Color.Blue;
            }
            else if (digi_2 == 3)
            {
                panels[2, 1].BackColor = Color.Blue;
                panels[3, 1].BackColor = Color.Blue;
            }
            else if (digi_2 == 4)
            {
                panels[1, 1].BackColor = Color.Blue;
            }
            else if (digi_2 == 5)
            {
                panels[1, 1].BackColor = Color.Blue;
                panels[3, 1].BackColor = Color.Blue;
            }
            else if (digi_2 == 6)
            {
                panels[1, 1].BackColor = Color.Blue;
                panels[2, 1].BackColor = Color.Blue;
            }
            else if (digi_2 == 7)
            {
                panels[1, 1].BackColor = Color.Blue;
                panels[2, 1].BackColor = Color.Blue;
                panels[3, 1].BackColor = Color.Blue;
            }
            else if (digi_2 == 8)
            {
                panels[0, 1].BackColor = Color.Blue;
            }
            else if (digi_2 == 9)
            {
                panels[0, 1].BackColor = Color.Blue;
                panels[3, 1].BackColor = Color.Blue;
            }
        }

        private void Min(string min)
        {
            int digi_1 = Convert.ToInt32(min[0] - '0');
            int digi_2 = Convert.ToInt32(min[1] - '0');
            label7.Text = digi_1.ToString();
            label8.Text = digi_2.ToString();

            if (digi_1 == 1)
            {
                panels[3, 2].BackColor = Color.Red;
            }
            else if (digi_1 == 2)
            {
                panels[2, 2].BackColor = Color.Red;
            }
            else if (digi_1 == 3)
            {
                panels[2, 2].BackColor = Color.Red;
                panels[3, 2].BackColor = Color.Red;
            }
            else if (digi_1 == 4)
            {
                panels[1, 2].BackColor = Color.Red;
            }
            else if (digi_1 == 5)
            {
                panels[1, 2].BackColor = Color.Red;
                panels[3, 2].BackColor = Color.Red;
            }
            else if (digi_1 == 6)
            {
                panels[1, 2].BackColor = Color.Red;
                panels[2, 2].BackColor = Color.Red;
            }
            else if (digi_1 == 7)
            {
                panels[1, 2].BackColor = Color.Red;
                panels[2, 2].BackColor = Color.Red;
                panels[3, 2].BackColor = Color.Red;
            }
            else if (digi_1 == 8)
            {
                panels[0, 2].BackColor = Color.Red;
            }
            else if (digi_1 == 9)
            {
                panels[0, 2].BackColor = Color.Red;
                panels[3, 2].BackColor = Color.Red;
            }

            if (digi_2 == 1)
            {
                panels[3, 3].BackColor = Color.Red;
            }
            else if (digi_2 == 2)
            {
                panels[2, 3].BackColor = Color.Red;
            }
            else if (digi_2 == 3)
            {
                panels[2, 3].BackColor = Color.Red;
                panels[3, 3].BackColor = Color.Red;
            }
            else if (digi_2 == 4)
            {
                panels[1, 3].BackColor = Color.Red;
            }
            else if (digi_2 == 5)
            {
                panels[1, 3].BackColor = Color.Red;
                panels[3, 3].BackColor = Color.Red;
            }
            else if (digi_2 == 6)
            {
                panels[1, 3].BackColor = Color.Red;
                panels[2, 3].BackColor = Color.Red;
            }
            else if (digi_2 == 7)
            {
                panels[1, 3].BackColor = Color.Red;
                panels[2, 3].BackColor = Color.Red;
                panels[3, 3].BackColor = Color.Red;
            }
            else if (digi_2 == 8)
            {
                panels[0, 3].BackColor = Color.Red;
            }
            else if (digi_2 == 9)
            {
                panels[0, 3].BackColor = Color.Red;
                panels[3, 3].BackColor = Color.Red;
            }
        }

        private void Sec(string sec)
        {
            int digi_1 = Convert.ToInt32(sec[0] - '0');
            int digi_2 = Convert.ToInt32(sec[1] - '0');
            label9.Text = digi_1.ToString();
            label10.Text = digi_2.ToString();

            if (digi_1 == 1)
            {
                panels[3, 4].BackColor = Color.Orange;
            }
            else if (digi_1 == 2)
            {
                panels[2, 4].BackColor = Color.Orange;
            }
            else if (digi_1 == 3)
            {
                panels[2, 4].BackColor = Color.Orange;
                panels[3, 4].BackColor = Color.Orange;
            }
            else if (digi_1 == 4)
            {
                panels[1, 4].BackColor = Color.Orange;
            }
            else if (digi_1 == 5)
            {
                panels[1, 4].BackColor = Color.Orange;
                panels[3, 4].BackColor = Color.Orange;
            }
            else if (digi_1 == 6)
            {
                panels[1, 4].BackColor = Color.Orange;
                panels[2, 4].BackColor = Color.Orange;
            }
            else if (digi_1 == 7)
            {
                panels[1, 4].BackColor = Color.Orange;
                panels[2, 4].BackColor = Color.Orange;
                panels[3, 4].BackColor = Color.Orange;
            }
            else if (digi_1 == 8)
            {
                panels[0, 4].BackColor = Color.Orange;
            }
            else if (digi_1 == 9)
            {
                panels[0, 4].BackColor = Color.Orange;
                panels[3, 4].BackColor = Color.Orange;
            }

            if (digi_2 == 1)
            {
                panels[3, 5].BackColor = Color.Orange;
            }
            else if (digi_2 == 2)
            {
                panels[2, 5].BackColor = Color.Orange;
            }
            else if (digi_2 == 3)
            {
                panels[2, 5].BackColor = Color.Orange;
                panels[3, 5].BackColor = Color.Orange;
            }
            else if (digi_2 == 4)
            {
                panels[1, 5].BackColor = Color.Orange;
            }
            else if (digi_2 == 5)
            {
                panels[1, 5].BackColor = Color.Orange;
                panels[3, 5].BackColor = Color.Orange;
            }
            else if (digi_2 == 6)
            {
                panels[1, 5].BackColor = Color.Orange;
                panels[2, 5].BackColor = Color.Orange;
            }
            else if (digi_2 == 7)
            {
                panels[1, 5].BackColor = Color.Orange;
                panels[2, 5].BackColor = Color.Orange;
                panels[3, 5].BackColor = Color.Orange;
            }
            else if (digi_2 == 8)
            {
                panels[0, 5].BackColor = Color.Orange;
            }
            else if (digi_2 == 9)
            {
                panels[0, 5].BackColor = Color.Orange;
                panels[3, 5].BackColor = Color.Orange;
            }
        }
    }
}
