using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2DGame_FirstDraft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int elapsedTime = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            string mess = "CATCH THE GOLDEN SNITCH! " + Environment.NewLine + "Use the direction buttons.";
            MessageBox.Show(mess, "SEEKER", MessageBoxButtons.OK, MessageBoxIcon.Information);
            timer1.Start();
            timer1.Tick += Timer_Tick;
            if (player_box.Top == 409 &  player_box.Left == 50)
            {
                third_bttn.Enabled = false;
                fourth_bttn.Enabled = false;
                fifth_bttn.Enabled = false;
                sixth_bttn.Enabled = false;
                seventh_bttn.Enabled = false;
                eighth_bttn.Enabled = false;
                nineth_bttn.Enabled = false;
                tenth_bttn.Enabled = false;
                eleventh_bttn.Enabled = false;
                twelfth_bttn.Enabled = false;
                thirteenth_bttn.Enabled = false;
                fourteenth_bttn.Enabled = false;
            }
        }

        private void first_bttn_Click(object sender, EventArgs e)
        {
            player_box.Top = 240;
            player_box.Left = 124;

            if(player_box.Top == 240 & player_box.Left == 124)
            {
                first_bttn.Enabled = false;
                second_bttn.Enabled = false;
                third_bttn.Enabled = false;
                fourth_bttn.Enabled = false;
                fifth_bttn.Enabled = false;
                sixth_bttn.Enabled = true;
                seventh_bttn.Enabled = true;
            }
        }
        private void sixth_bttn_Click(object sender, EventArgs e)
        {
            player_box.Top = 118;
            player_box.Left = 175;

            if(player_box.Top == 118 & player_box.Left == 175)
            {
                sixth_bttn.Enabled = false;
                eighth_bttn.Enabled = true;
                seventh_bttn.Enabled = false;
                nineth_bttn.Enabled = false;
                eleventh_bttn.Enabled = false;
                twelfth_bttn.Enabled = false;
                thirteenth_bttn.Enabled = false;
                fourteenth_bttn.Enabled = false;
            }
        }

        private void eighth_bttn_Click(object sender, EventArgs e)
        {
            player_box.Top = 116;
            player_box.Left = 616;
            tenth_bttn.Enabled = true;
            eighth_bttn.Enabled = false;
        }

        private void tenth_bttn_Click(object sender, EventArgs e)
        {
            player_box.Top = 205;
            player_box.Left = 684;

            if (player_box.Top == 205 & player_box.Left == 684)
            {
                twelfth_bttn.Enabled = true;
            }
        }

        private void twelfth_bttn_Click(object sender, EventArgs e)
        {
            player_box.Top = 268;
            player_box.Left = 563;
            thirteenth_bttn.Enabled = true;
            twelfth_bttn.Enabled = false;
        }

        private void thirteenth_bttn_Click(object sender, EventArgs e)
        {
            player_box.Top = 217;
            player_box.Left = 453;
            fourteenth_bttn.Enabled = true;
            thirteenth_bttn.Enabled = false;
        }

        private void fourteenth_bttn_Click(object sender, EventArgs e)
        {
            player_box.Top = 240;
            player_box.Left = 305;
            fourteenth_bttn.Enabled = false;

            Rectangle rect1 = snitch_box.Bounds;
            Rectangle rect2 = player_box.Bounds;

            if (rect1.IntersectsWith(rect2))
            {
                timer1.Stop();
                string mess = "CONGRATULATIONS! You have caught the Golden Snitch." + Environment.NewLine + "Your Time Is : " + elapsedTime + " s";
                DialogResult res = MessageBox.Show(mess, "FINISHED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(res == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        private void second_bttn_Click(object sender, EventArgs e)
        {
            player_box.Top = 30;
            player_box.Left = 50;

            second_bttn.Enabled = false;
            first_bttn.Enabled = false;
            third_bttn.Enabled = true;
        }

        private void third_bttn_Click(object sender, EventArgs e)
        {
            player_box.Top = 30;
            player_box.Left = 803;

            third_bttn.Enabled = false;
            fourth_bttn.Enabled = true;
        }

        private void fourth_bttn_Click(object sender, EventArgs e)
        {
            player_box.Top = 456;
            player_box.Left = 803;

            fourth_bttn.Enabled = false;
            fifth_bttn.Enabled = true;
        }

        private void fifth_bttn_Click(object sender, EventArgs e)
        {
            player_box.Top = 409;
            player_box.Left = 50;

            fifth_bttn.Enabled = false;
            first_bttn.Enabled = true;
            second_bttn.Enabled = true;
        }

        private void seventh_bttn_Click(object sender, EventArgs e)
        {
            player_box.Top = 368;
            player_box.Left = 166;

            sixth_bttn.Enabled = false;
            seventh_bttn.Enabled = false;
            nineth_bttn.Enabled = true;
        }

        private void nineth_bttn_Click(object sender, EventArgs e)
        {
            player_box.Top = 370;
            player_box.Left = 616;

            nineth_bttn.Enabled = false;
            eleventh_bttn.Enabled = true;
        }

        private void eleventh_bttn_Click(object sender, EventArgs e)
        {
            player_box.Top = 205;
            player_box.Left = 684;

            eleventh_bttn.Enabled= false;
            twelfth_bttn.Enabled = true;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            elapsedTime++;
        }
    }
}
