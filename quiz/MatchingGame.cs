﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace quiz
{
    public partial class MatchingGame : Form
    {
        Label firstClicked = null,secondClicked=null;
        int timeSpent = 0;
        Random random = new Random();
        SoundPlayer Won = new SoundPlayer(MathQuiz.ProgDire + "win.wav");
        List<string> icons = new List<string>()
        {
            "!", "!", "N", "N", ",", ",", "k", "k",
            "b", "b", "v", "v", "w", "w", "z", "z"
        };
        public MatchingGame()
        {
            InitializeComponent();
            AssignIconsToSquares();
        }
        private void label_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;
            if (!timer2.Enabled)
            {
                timer2.Start();
            }
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                clickedLabel.ForeColor = Color.Black;
                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    return;
                }
                secondClicked = clickedLabel;
                if (firstClicked.Text == secondClicked.Text)
                {
                    CheckForWinner();
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;
            firstClicked = null;
            secondClicked = null;
        }

        private void AssignIconsToSquares()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timeSpent++;
        }
        private void CheckForWinner()
        {
           
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }
            timer2.Stop();
            Won.Play();
            MessageBox.Show(String.Format("You matched all the icons! \nthat took you {0} seconds", timeSpent), "Congratulations");
            Close();
        }
    }

}
