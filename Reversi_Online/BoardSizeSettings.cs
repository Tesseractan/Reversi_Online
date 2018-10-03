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
    public partial class BoardSizeSettings : ReversiForm
    {
        private Chessboard demo_chessboard;
        private Size board_size = new Size(8, 8);
        public BoardSizeSettings()
        {
            InitializeComponent();
        }

        private void BoardSizeSettings_Load(object sender, EventArgs e)
        {
            this.board_size = Properties.Settings.Default.board_size;
            this.demo_chessboard = new Chessboard(ref demo_chessboard_panel, this.board_size, new Pair<Color>(Properties.Settings.Default.board_colorA, Properties.Settings.Default.board_colorB));
            demo_chessboard.Load();
            demo_chessboard.PositionateStart();
            board_width_trackbar.Value = board_size.Width / 2 - 2;
            board_height_trackbar.Value = board_size.Height / 2 - 2;
            board_size_indicator_label.Text = $"{this.board_size.Width} x {this.board_size.Height}";
        }

        private void BoardSizeSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.board_size = this.board_size;
            Properties.Settings.Default.Save();
            this.Owner.Show();
        }

        private void board_width_trackbar_Scroll(object sender, EventArgs e)
        {
            this.board_size.Width = board_width_trackbar.Value * 2 + 4;
            board_size_indicator_label.Text = $"{board_size.Width} x {board_size.Height}";
            this.demo_chessboard.Width = this.board_size.Width;
            demo_chessboard.PositionateStart();
        }

        private void board_height_trackbar_Scroll(object sender, EventArgs e)
        {
            this.board_size.Height = board_height_trackbar.Value * 2 + 4;
            board_size_indicator_label.Text = $"{board_size.Width} x {board_size.Height}";
            this.demo_chessboard.Height = this.board_size.Height;
            demo_chessboard.PositionateStart();
        }

       
        private void BoardSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
