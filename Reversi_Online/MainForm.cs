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
    public partial class MainForm : Form
    {
        //private UserData profile_data;

        private Chessboard chessboard;

        public MainForm(/*UserData profile_data*/)
        {
            //this.profile_data = profile_data;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            duration_combobox.SelectedIndex = 0;
            opponent_combobox.SelectedIndex = 0;
            machine_level_trackbar.ValueChanged += (s, ea) =>
            {
                machine_level.Text = machine_level_trackbar.Value.ToString();
            };
            random_size_mode_radio.CheckedChanged += (s, ea) =>
            {
                board_size_settings_panel.Enabled = !random_size_mode_radio.Checked;
                if (random_size_mode_radio.Checked)
                {
                    board_size_label.Text = "Random";
                }
                else
                {
                    board_size_label.Text = $"{4 + board_width_trackbar.Value * 2}x{4 + board_height_trackbar.Value * 2}";
                }
            };
            board_width_trackbar.ValueChanged += (s, ea) =>
            {
                board_size_label.Text = $"{4 + board_width_trackbar.Value * 2}x{4 + board_height_trackbar.Value * 2}";
            };
            board_height_trackbar.ValueChanged += (s, ea) =>
            {
                board_size_label.Text = $"{4 + board_width_trackbar.Value * 2}x{4 + board_height_trackbar.Value * 2}";
            };
            add_friend_button.MouseHover += (s, ea) =>
            {
                add_friend_button.BackColor = Color.Orange;
            };
            add_friend_button.MouseLeave += (s, ea) =>
            {
                add_friend_button.BackColor = Color.White;
            };

            //Chessboard chessboard = new Chessboard(ref chessboard_panel, new Size(8, 8));
            //chessboard.Load(); 
            /*
            //profile settings
            profile_photo_picturebox.Image = this.profile_data.Profile_photo;
            username_label.Text = this.profile_data.Username;
            rating_label.Text = $"({this.profile_data.Rating})";
            games_played_label.Text = this.profile_data.Played_amount.ToString();
            won_amount_label.Text = this.profile_data.Won_amount.ToString();
            draw_amount_label.Text = this.profile_data.Draw_amount.ToString();
            lost_amount_label.Text = this.profile_data.Lost_amount.ToString();
            */
        }

        private void profile_photo_picturebox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Title = "Choose a new picture to change your profile photo",
                Filter = "BMP|*.bmp|GIF|*.gif|JPG|*.jpg;*.jpeg|PNG|*.png|TIFF|*.tif;*.tiff"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = new Bitmap(openFileDialog.FileName);
                profile_photo_picturebox.Image = bitmap;
            }
        }

        private void play_over_the_board_button_Click(object sender, EventArgs e)
        {
            before_game_panel.Hide();
            morilla_reversi_logo.Hide();
            offline_game_settings_panel.Show();
            submit_offline_game_settings_button.Click += Submit_offline_game_settings;
        }
        private void Submit_offline_game_settings(object sender, EventArgs ea)
        {
            user_table_username_label.Text = user_offline_username_textbox.Text;
            opponent_table_username_label.Text = opponent_offline_username_textbox.Text;
            submit_offline_game_settings_button.Click -= Submit_offline_game_settings;
            offline_game_settings_panel.Hide();

            this.chessboard = new Chessboard(ref chessboard_panel, GetBoardSize());
            chessboard.Load(); chessboard.PositionateStart();
            goback.Show();
           // OverTheBoardAlgorithm algorithm = new OverTheBoardAlgorithm(ref chessboard);
            //algorithm.Apply();
        }
        private Size GetBoardSize()
        {
            if (board_size_label.Text.Contains('x'))
            {
                string[] size_strings = board_size_label.Text.Split('x');
                return new Size(Convert.ToInt32(size_strings[0]), Convert.ToInt32(size_strings[1]));
            }
            else
            {
                Random rand = new Random();
                int width_level = rand.Next(0, 4);
                int height_level = rand.Next(0, 4);
                /*
                 * 0 -> 4
                 * 1 -> 6
                 * 2 -> 8
                 * 3 -> 10
                 * 4 -> 12
                */
                return new Size(4 + width_level * 2, 4 + height_level * 2);
            }
        }

        private void goback_Click(object sender, EventArgs e)
        {
            goback.Hide();
            morilla_reversi_logo.Show();
            before_game_panel.Show();
            chessboard.Unload();
        }
        private void goback_MouseHover(object sender, EventArgs e)
        {
            goback.BackColor = Color.Red;
        }
        private void goback_MouseLeave(object sender, EventArgs e)
        {
            goback.BackColor = Color.White;
        }

        private void random_playing_color_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (random_playing_color_radio.Checked)
            {
                playing_color_picturebox.Image = Properties.Resources.question_mark;
                playing_color_picturebox.Tag = PlayerColor.Random;
            }
        }

        private void white_playing_color_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (white_playing_color_radio.Checked)
            {
                playing_color_picturebox.Image = Properties.Resources.white;
                playing_color_picturebox.Tag = PlayerColor.White;
            }
        }

        private void black_playing_color_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (black_playing_color_radio.Checked)
            {
                playing_color_picturebox.Image = Properties.Resources.black;
                playing_color_picturebox.Tag = PlayerColor.Black;
            }
        }
    }
}
