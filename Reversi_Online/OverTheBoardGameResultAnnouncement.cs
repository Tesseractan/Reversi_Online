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
    public partial class OverTheBoardGameResultAnnouncement : ReversiForm
    {
        private string game_result, optional_game_result_description, black_name_and_score, white_name_and_score;
        private Image game_result_image, black_stone_image, white_stone_image;

        public OverTheBoardGameResultAnnouncement(string game_result, string optional_game_result_description, string black_name_and_score, string white_name_and_score, Image game_result_image, Image black_stone_image, Image white_stone_image)
        {
            this.game_result = game_result;
            this.optional_game_result_description = optional_game_result_description;
            this.black_name_and_score = black_name_and_score;
            this.white_name_and_score = white_name_and_score;
            this.game_result_image = game_result_image;
            this.black_stone_image = black_stone_image;
            this.white_stone_image = white_stone_image;

            InitializeComponent();
        }

        private void OverTheBoardGameResultAnnouncement_Load(object sender, EventArgs e)
        {
            game_result_label.Text = this.game_result;
            optional_game_result_description_label.Text = this.optional_game_result_description;
            black_name_and_score_label.Text = this.black_name_and_score;
            white_name_and_score_label.Text = this.white_name_and_score;
            game_result_picturebox.Image = this.game_result_image;
            black_stone_picturebox.Image = this.black_stone_image;
            white_stone_picturebox.Image = this.white_stone_image;
        }
    }
}
