using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace Reversi_Online
{
    public partial class OnlineGameSettings : ReversiForm
    {
        public OnlineGameSettings()
        {
            InitializeComponent();
            
        }

        private void OnlineGameSettings_Load(object sender, EventArgs e)
        {
            opponents_username_combobox.SelectedItem = "Random";
            rating_range_combobox.SelectedItem = "Open";
            playing_color_combobox.SelectedItem = "Random";
            
        }

        private void opponents_username_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (opponents_username_combobox.SelectedItem.ToString() == "Random")
            {
                rating_range_combobox.Enabled = true;
                opponents_username_combobox.BackColor = Color.DarkKhaki;
            }
            else
            {
                rating_range_combobox.Enabled = false;
                opponents_username_combobox.BackColor = SystemColors.Window;
            }
        }

        private void playing_color_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (playing_color_combobox.SelectedItem.ToString())
            {
                case "Black":
                    playing_color_picturebox.Image = StoneStyleImage.FromIDAndColor(Properties.Settings.Default.board_black_stone_image_ID, PlayerColor.Black);
                    break;
                case "White":
                    playing_color_picturebox.Image = StoneStyleImage.FromIDAndColor(Properties.Settings.Default.board_white_stone_image_ID, PlayerColor.White);
                    break;
                case "Random":
                    playing_color_picturebox.Image = Properties.Resources.unknown;
                    break;
            }
        }

        private void create_challenge_button_Click(object sender, EventArgs e)
        {

        }
    }
}
