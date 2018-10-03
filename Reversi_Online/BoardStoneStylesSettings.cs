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
    public partial class BoardStoneStylesSettings : ReversiForm
    {
        private int white_style_id;
        private int black_style_id;
        private Chessboard demo_board;

        public BoardStoneStylesSettings()
        {
            InitializeComponent();
        }

        private void BoardStoneStylesSettings_Load(object sender, EventArgs e)
        {
            this.white_style_id = Properties.Settings.Default.board_white_stone_image_ID;
            this.black_style_id = Properties.Settings.Default.board_black_stone_image_ID;
            white_stone_style_picturebox.Image = StoneStyleImage.FromIDAndColor(white_style_id, PlayerColor.White);
            black_stone_style_picturebox.Image = StoneStyleImage.FromIDAndColor(black_style_id, PlayerColor.Black);
            this.demo_board = new Chessboard(ref demo_board_panel, Properties.Settings.Default.board_size);
            demo_board.Load();
            demo_board.PositionateStart();
        }
        private void BoardStoneStylesSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.board_white_stone_image_ID = this.white_style_id;
            Properties.Settings.Default.board_black_stone_image_ID = this.black_style_id;
            Properties.Settings.Default.Save();
            this.Owner.Show();
        }

        private void white_stone_style_picturebox_Click(object sender, EventArgs e)
        {
            Image new_style_image = StoneStyleImage.FromIDAndColor(++white_style_id, PlayerColor.White);
            if (new_style_image == null)
            {
                new_style_image = StoneStyleImage.FromIDAndColor(white_style_id=0, PlayerColor.White);
            }
            white_stone_style_picturebox.Image = new_style_image;
            this.demo_board.WhiteStoneStyle = new_style_image;
        }

        private void black_stone_style_picturebox_Click(object sender, EventArgs e)
        {
            Image new_style_image = StoneStyleImage.FromIDAndColor(++black_style_id, PlayerColor.Black);
            if (new_style_image == null)
            {
                new_style_image = StoneStyleImage.FromIDAndColor(black_style_id = 0, PlayerColor.Black);
            }
            black_stone_style_picturebox.Image = new_style_image;
            this.demo_board.BlackStoneStyle = new_style_image;
        }
    }
}
