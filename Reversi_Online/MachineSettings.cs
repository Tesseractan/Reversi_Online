using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Convert;

namespace Reversi_Online
{
    public partial class MachineSettings : ReversiForm
    {
        private PlayerColor user_color;

        private Image black_stone_style, white_stone_style;
        public MachineSettings()
        {
            InitializeComponent();
        }
        private void MachineSettings_Load(object sender, EventArgs e)
        {
            machine_level_trackbar.Value = Properties.Settings.Default.machine_level;

            if (Properties.Settings.Default.playing_color=="white")
            {
                this.user_color = PlayerColor.White;
                stone_picturebox.Image = this.white_stone_style = StoneStyleImage.FromIDAndColor(Properties.Settings.Default.board_white_stone_image_ID, PlayerColor.White);
                this.black_stone_style = StoneStyleImage.FromIDAndColor(Properties.Settings.Default.board_black_stone_image_ID, PlayerColor.Black);
            }
            else
            {
                this.user_color = PlayerColor.Black;
                stone_picturebox.Image = this.black_stone_style = StoneStyleImage.FromIDAndColor(Properties.Settings.Default.board_black_stone_image_ID, PlayerColor.Black);
                this.white_stone_style = StoneStyleImage.FromIDAndColor(Properties.Settings.Default.board_white_stone_image_ID, PlayerColor.White);
            }
        }
        private void MachineSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.machine_level = ToInt32(machine_level_label.Text);
            Properties.Settings.Default.playing_color = this.user_color == PlayerColor.White ? "white" : "black";
            Properties.Settings.Default.Save();
            
        }

        private void machine_level_trackbar_ValueChanged(object sender, EventArgs e)
        {
            machine_level_label.Text = machine_level_trackbar.Value.ToString();
            //   factor = (value-length/2)/length/2 = (value-length/2)2/length = 2value/length-1
            int length = machine_level_trackbar.Maximum - machine_level_trackbar.Minimum;
            // 2*value/length-1 = 2*value/length-length/length = (2*value-length)/length         <-------
            //double factor = 2* machine_level_trackbar.Value / length - 1;           
            double factor_nominator = 2 * machine_level_trackbar.Value - length, factor_denominator = length;
            // MessageBox.Show($"factor=2*{machine_level_trackbar.Value}/{length}-1");

            machine_level_label.ForeColor = Color.FromArgb(ToInt32(127.5 + factor_nominator * 127.5 / factor_denominator), ToInt32(127.5 - factor_nominator * 127.5 / factor_denominator), 0);
            //MessageBox.Show($"Value: {machine_level_trackbar.Value}, factor_nominator: {factor_nominator.ToString()}, factor_denominator: {factor_denominator}, trackbar minimum: {machine_level_trackbar.Minimum}, color: {robot_picturebox.BackColor}");
        }

        private void stone_picturebox_Click(object sender, EventArgs e)
        {
            if (this.user_color == PlayerColor.Black)
            {
                stone_picturebox.Image = white_stone_style;
            }
            else if (this.user_color == PlayerColor.White)
            {
                stone_picturebox.Image = black_stone_style;
            }
            this.user_color = (PlayerColor)(-(int)user_color);
        }

        private void play_vs_machine_button_Click(object sender, EventArgs e)
        {
            new GameVsMachine(ToInt32(machine_level_label.Text), this.user_color).Show(this);
            this.Hide();
        }
    }
}
