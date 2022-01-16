using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace quiz
{
    public partial class MathQuiz : Form
    {
        int timeLeft;
        Random Ran = new Random();
        static string ProgDire = Directory.GetCurrentDirectory().Replace("bin\\Debug", "");
        SoundPlayer FinalGame = new SoundPlayer(ProgDire + "final.wav");
        SoundPlayer Lost = new SoundPlayer(ProgDire + "loss.wav");
        SoundPlayer Won = new SoundPlayer(ProgDire + "win.wav");
        public MathQuiz()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (game_won())
            {
                timer1.Stop();
                MessageBox.Show("You Won!! \nthat took you only " + (30 - timeLeft) + " seconds", "You Won!!");
                Start.Enabled = true;
                return;
            }
            if (timeLeft > 0)
            {
                timeLeft--;
                if (timeLeft == 3) FinalGame.Play();
                TimeLab.Text = timeLeft + " seconds";
            }else
            {
                TimeLab.Text ="Time's Up";
                timer1.Stop();
                Lost.Play();
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                Start.Enabled = true;
            }
        }
        private bool game_won()
        {
            if ((Int32.Parse(plusLeft.Text)+Int32.Parse(plusRight.Text)) != sum.Value) return false;
            if ((Int32.Parse(divLeft.Text)/Int32.Parse(divRight.Text)) != div.Value) return false;
            if ((Int32.Parse(multiLeft.Text)*Int32.Parse(multiRight.Text))!=mult.Value) return false;
            if ((Int32.Parse(minLeft.Text)-Int32.Parse(minRight.Text)) != min.Value) return false;
            Won.Play();
            return true;
        }
        private void Start_Game()
        {
            timeLeft = 30;
            int temp;
            plusRight.Text = Ran.Next(50).ToString();
            plusLeft.Text = Ran.Next(50).ToString();
            temp = Ran.Next(25,50);
            minLeft.Text = temp.ToString();
            minRight.Text = Ran.Next(temp).ToString();
            multiRight.Text = Ran.Next(10).ToString();
            multiLeft.Text = Ran.Next(15).ToString();
            temp = Ran.Next(2, 14);
            divRight.Text =temp.ToString();
            divLeft.Text = (Ran.Next(5)*temp).ToString();
            TimeLab.Text = timeLeft + " seconds";
            sum.Value = 0;
            div.Value = 0;
            mult.Value = 0;
            min.Value = 0;
            timer1.Start();
        }
        private void Start_Click(object sender, EventArgs e)
        {
            Start_Game();
            Start.Enabled = false;
        }
    }
}
