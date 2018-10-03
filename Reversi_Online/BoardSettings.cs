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
    public partial class BoardSettings : ReversiForm
    {
        public BoardSettings()
        {
            InitializeComponent();
        }
        private void BoardSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void set_size_button_Click(object sender, EventArgs e)
        {
            new BoardSizeSettings().Show(this);
            this.Hide();
        }

        private void set_colors_button_Click(object sender, EventArgs e)
        {
            new BoardColorsSettings().Show(this);
            this.Hide();
        }

        private void set_stone_styles_button_Click(object sender, EventArgs e)
        {
            new BoardStoneStylesSettings().Show(this);
            this.Hide();
        }

        private void reset_board_settings_button_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.board_size = new Size(8, 8);
            Properties.Settings.Default.board_colorA = Color.FromArgb(215, 188, 156);
            Properties.Settings.Default.board_colorB = Color.Green;
            Properties.Settings.Default.board_white_stone_image_ID = 0;
            Properties.Settings.Default.board_black_stone_image_ID = 0;
            Properties.Settings.Default.Save();
        }
    }
}
