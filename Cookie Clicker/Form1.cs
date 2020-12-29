using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WMPLib;

namespace Cookie_Clicker
{
    public partial class Form1 : Form
    {
        Timer t = new Timer();
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        int score, bestScore;
        string rank = "NOOB";

        public Form1()
        {
            player.URL = "button_click.mp3";
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Witaj w Cookie Clickerze!", "Cookie Clicker");
            t.Start();
            label1.Text = "CPS: " + Convert.ToString(score);
            label3.ForeColor = Color.White;
            label3.Text = "Rank: " + rank;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.controls.play();
            score++;
            label1.Text = "CPS: " + Convert.ToString(score);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your rank: " + rank);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (score > bestScore)
            {
                bestScore = score;
                label2.Text = "Best score CPS: " + bestScore + " CPS";
            }


            if (bestScore >= 3 && bestScore < 6)
            {
                rank = "Snail";
                label3.ForeColor = Color.Green;
                label3.Text = "Rank: " + rank;
            }
            else if (bestScore >= 6 && bestScore < 10)
            {
                rank = "Cookie";
                label3.ForeColor = Color.Brown;
                label3.Text = "Rank: " + rank;
            }
            else if (bestScore >= 10 && bestScore < 15)
            {
                rank = "Speedy";
                label3.ForeColor = Color.Yellow;
                label3.Text = "Rank: " + rank;
            }
            else if (bestScore >= 15 && bestScore < 20)
            {
                rank = "Master";
                label3.ForeColor = Color.Blue;
                label3.Text = "Rank: " + rank;
            }
            else if (bestScore >= 20 && bestScore < 25)
            {
                rank = "Legend";
                label3.ForeColor = Color.Red;
                label3.Text = "Rank: " + rank;
            }
            else if (bestScore >= 25)
            {
                rank = "God";
                label3.ForeColor = Color.Magenta;
                label3.Text = "Rank: " + rank;
            }

            score = 0;
            label1.Text = "CPS: " + Convert.ToString(score);
        }
    }
}
