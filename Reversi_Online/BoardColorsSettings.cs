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
    public partial class BoardColorsSettings : ReversiForm
    {
        private Chessboard demo_board;
        public BoardColorsSettings()
        {
            InitializeComponent(); 
        }
        private void BoardColorsSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.board_colorA = color_a_picturebox.BackColor;
            Properties.Settings.Default.board_colorB = color_b_picturebox.BackColor;
        }

        private void BoardColorsSettings_Load(object sender, EventArgs e)
        {
            color_a_picturebox.BackColor = Properties.Settings.Default.board_colorA;
            color_b_picturebox.BackColor = Properties.Settings.Default.board_colorB;
            this.demo_board = new Chessboard(ref demo_board_panel, Properties.Settings.Default.board_size, new Pair<Color>(color_a_picturebox.BackColor, color_b_picturebox.BackColor));
            demo_board.Load();
            demo_board.PositionateStart();
        }

        private void color_a_picturebox_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = color_a_picturebox.BackColor;
            colorDialog.ShowDialog();
            color_a_picturebox.BackColor = colorDialog.Color;
            this.demo_board.ColorA = colorDialog.Color;
        }

        private void color_b_picturebox_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = color_b_picturebox.BackColor;
            colorDialog.ShowDialog();
            color_b_picturebox.BackColor = colorDialog.Color;
            this.demo_board.ColorB = colorDialog.Color;
        }
    }
}
