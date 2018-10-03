using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reversi_Online
{
    public partial class GameVsMachineResultAnnnouncement : ReversiForm
    {
        private GameVsMachine gameVsMachine;
        public GameVsMachineResultAnnnouncement(GameVsMachine gameVsMachine)
        {
            this.gameVsMachine = gameVsMachine;

            InitializeComponent();
        }

        private void GameVsMachineResultAnnnouncement_Load(object sender, EventArgs e)
        {

            LoadGameResultAndDescription();

            LoadScores();

        }
        private void LoadGameResultAndDescription()
        {
            int white_over_black = this.gameVsMachine.Algorithm.WhiteAmount - this.gameVsMachine.Algorithm.BlackAmount;
            int user_over_computer = (int)this.gameVsMachine.UserColor * white_over_black;
            double user_better_percents = Convert.ToDouble(user_over_computer) / Convert.ToDouble(this.gameVsMachine.Board.Squares.Length) * 100;

            if (user_better_percents > 0)
            {
                game_result_label.Text = "You won!";
                game_result_label.ForeColor = Color.Green;
                game_result_picturebox.Image = Properties.Resources.broken_robot;
                if (user_better_percents < 25)
                {
                    description_label.Text = "*\n...but I almost beat you ;D";
                }
                else if (user_better_percents < 50)
                {
                    description_label.Text = "**\n...but I think you can do much better :P";
                }
                else if (user_better_percents < 75)
                {
                    description_label.Text = "***\nWell deserved victory, congrats B-)";
                }
                else if (user_better_percents < 100)
                {
                    description_label.Text = "****\nI'm too stupid to play with you";
                }
                else if (user_better_percents == 100)
                {
                    description_label.Text = "*****\nPlease don't compromit me, just skip to next level and don't annoy my anymore!";
                }
            }
            else if (user_better_percents < 0)
            {
                game_result_label.Text = "Ugh! I won with you.";
                game_result_label.ForeColor = Color.Red;
                game_result_picturebox.Image = Properties.Resources.strong_robot;
                if (user_better_percents > -25)
                {
                    description_label.Text = "x\n...but I was so scared... I thought you will win!";
                }
                else if (user_better_percents > -50)
                {
                    description_label.Text = "xx\nnext time I'll try to grab you more :P";
                }
                else if (user_better_percents > -75)
                {
                    description_label.Text = "xxx\nI'm so proud, I deserved it...";
                }
                else if (user_better_percents > -100)
                {
                    description_label.Text = "xxxx\nDid you think we are playing anti-othello?";
                }
                else if (user_better_percents == -100)
                {
                    description_label.Text = $"xxxxx\nLOL! You are a genius, it isn't so easy to clean the board from your stones. Please don't annoy me anymore and freak out like here with the machine at lvl {this.gameVsMachine.ComputerLevel - 1}. ";
                }
            }
            else if (user_better_percents == 0)
            {
                game_result_label.Text = "It's a draw...";
                game_result_label.ForeColor = Color.Blue;
                game_result_picturebox.Image = Properties.Resources.robot_vs_human_draw;
                description_label.Text = "... so I am as good as you!";
            }
        }

        private string GetScore(int stones_amount)
        {
            string score = $"{stones_amount} stone";
            if (stones_amount != 1) score += "s";
            return score;
        }

        private void LoadScores()
        {
            white_stone_picturebox.Image = this.gameVsMachine.Board.WhiteStoneStyle;
            black_stone_picturebox.Image = this.gameVsMachine.Board.BlackStoneStyle;

            if (this.gameVsMachine.UserColor == PlayerColor.White)
            {
                white_name_and_score_label.Text = $"You: {GetScore(this.gameVsMachine.Algorithm.WhiteAmount)}";
                black_name_and_score_label.Text = $"Computer (lvl {this.gameVsMachine.ComputerLevel}.) : {GetScore(this.gameVsMachine.Algorithm.BlackAmount)}";
            }
            else if (this.gameVsMachine.UserColor == PlayerColor.Black)
            {
                black_name_and_score_label.Text = $"You: {GetScore(this.gameVsMachine.Algorithm.BlackAmount)}";
                white_name_and_score_label.Text = $"Computer (lvl {this.gameVsMachine.ComputerLevel}.) : {GetScore(this.gameVsMachine.Algorithm.WhiteAmount)}";
            }
        }
    }
}
