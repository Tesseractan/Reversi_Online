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
    public partial class OverTheBoardSettings : ReversiForm
    {
        private PlayerColor user_playing_color;
        public OverTheBoardSettings()
        {
            InitializeComponent();
        }

        private void OverTheBoardSettings_Load(object sender, EventArgs e)
        {
            user_name_textbox.Text = Properties.Settings.Default.offline_user_name;
            opponents_name_textbox.Text = Properties.Settings.Default.offline_opponents_name;
            game_duration_combobox.SelectedItem = Properties.Settings.Default.offline_game_time_control.ToString();
            this.user_playing_color = Properties.Settings.Default.playing_color == "black" ? PlayerColor.Black : PlayerColor.White;
            if (user_playing_color == PlayerColor.White)
            {
                user_stone_picturebox.Image = StoneStyleImage.FromIDAndColor(Properties.Settings.Default.board_white_stone_image_ID, PlayerColor.White);
                opponents_stone_picturebox.Image = StoneStyleImage.FromIDAndColor(Properties.Settings.Default.board_black_stone_image_ID, PlayerColor.Black);
            }
            else if (user_playing_color == PlayerColor.Black)
            {
                user_stone_picturebox.Image = StoneStyleImage.FromIDAndColor(Properties.Settings.Default.board_black_stone_image_ID, PlayerColor.Black);
                opponents_stone_picturebox.Image = StoneStyleImage.FromIDAndColor(Properties.Settings.Default.board_white_stone_image_ID, PlayerColor.White);
            }
        }
        private void OverTheBoardSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.offline_game_time_control = game_duration_combobox.SelectedItem.ToString();
            Properties.Settings.Default.playing_color = this.user_playing_color == PlayerColor.Black ? "black" : "white";
            Properties.Settings.Default.offline_user_name = user_name_textbox.Text;
            Properties.Settings.Default.offline_opponents_name = opponents_name_textbox.Text;
            Properties.Settings.Default.Save();
            
            //this.Owner.Show();
        }

        private void user_stone_picturebox_Click(object sender, EventArgs e)
        {
            SwapPlayingColors();
        }

        private void opponents_stone_picturebox_Click(object sender, EventArgs e)
        {
            SwapPlayingColors();
        }

        private void SwapPlayingColors()
        {
            this.user_playing_color = (PlayerColor)(-(int)user_playing_color);
            Image temporary = user_stone_picturebox.Image;
            user_stone_picturebox.Image = opponents_stone_picturebox.Image;
            opponents_stone_picturebox.Image = temporary;
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            TimeSpan game_time_control;
            if(game_duration_combobox.SelectedItem.ToString()!= "∞")
            {
                game_time_control = new TimeSpan(0, Convert.ToInt32(game_duration_combobox.SelectedItem), 0);
            }
            else
            {
                game_time_control = new TimeSpan(0, 0, 0);
            }
            new OverTheBoardGame(user_name_textbox.Text, opponents_name_textbox.Text, user_playing_color, game_time_control).Show(this);
            this.Hide();
        }
    }
}
