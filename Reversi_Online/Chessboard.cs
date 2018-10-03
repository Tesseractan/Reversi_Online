using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Reversi_Online
{

    public class Chessboard
    {
        public class Square
        {
            protected PlayerColor stone;
            public Square(PlayerColor stone)
            {
                this.stone = stone;
            }
            public virtual PlayerColor Stone
            {
                get { return this.stone; }
                set { this.stone = value; }
            }
        }
        public class InteractiveSquare : Square
        {
            private PictureBox pictureBox;

            private Chessboard chessboard;

            public InteractiveSquare(ref PictureBox pictureBox, PlayerColor stone, Chessboard chessboard) : base(stone)
            {
                this.chessboard = chessboard;
                this.pictureBox = pictureBox;
                Stone = stone;
            } 

            public PictureBox PictureBox
            {
                get { return this.pictureBox; }
            }
            public override PlayerColor Stone
            {
                get { return this.stone; }
                set
                {
                    this.stone = value;
                    switch ((int)value)
                    {
                        case 0:
                            pictureBox.Image = null;
                            break;
                        case 1:
                            pictureBox.Image = this.chessboard.stone_style_pair.A;
                            break;
                        case -1:
                            pictureBox.Image = this.chessboard.stone_style_pair.B;
                            break;
                    }
                }
            }
        }
        private Size size;
        private Pair<Color> color_pair;
        private Pair<Image> stone_style_pair;

        private InteractiveSquare[,] squares;
        private Panel panel;

        public Chessboard(ref Panel panel, Size size = new Size(), Pair<Color> color_pair = null, Pair<Image> stone_style_pair = null)
        {
            this.panel = panel;
            if (size.IsEmpty)
            {
                this.size = Properties.Settings.Default.board_size;
            }
            else
            {
                this.size = size;
            }
            //this.color_pair = color_pair ?? new Pair<Color>(Color.Green, Color.FromArgb(215, 188, 156));
            //this.stone_style_pair = stone_style_pair ?? new Pair<Image>(Properties.Resources.white, Properties.Resources.black);
            this.color_pair = color_pair ?? new Pair<Color>(Properties.Settings.Default.board_colorA, Properties.Settings.Default.board_colorB);
            this.stone_style_pair = stone_style_pair ?? new Pair<Image>(StoneStyleImage.FromIDAndColor(Properties.Settings.Default.board_white_stone_image_ID, PlayerColor.White), StoneStyleImage.FromIDAndColor(Properties.Settings.Default.board_black_stone_image_ID, PlayerColor.Black));
        }
        public static explicit operator Square[,](Chessboard chessboard)
        {
            return chessboard.squares;
        }
        
        public void Load()
        {

            squares = new InteractiveSquare[size.Width, size.Height];

            Size square_size = new Size(panel.Width / size.Width, panel.Height / size.Height);

            Color[] colors = new Color[2] { Color.Green, Color.FromArgb(215, 188, 156) };

            int y = 0;
            int delteY = 1;
            int counter = 0;
            for (int x = 0; x < squares.GetLength(0); x++)
            {
                for (; y < squares.GetLength(1) && y >= 0; y += delteY, counter++)
                {
                    ///MessageBox.Show($"x:{x}, y:{y}");
                    PictureBox pictureBox = new PictureBox()
                    {
                        Size = square_size,
                        Left = x * square_size.Width,
                        Top = y * square_size.Height,
                        BackColor = colors[counter % colors.Length],
                        BorderStyle = BorderStyle.FixedSingle,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Visible = true
                    };
                    panel.Controls.Add(pictureBox);
                    squares[x, y] = new InteractiveSquare(ref pictureBox, PlayerColor.None, this);
                }
                delteY *= -1;
                y += delteY;
            }
            this.PaintColors();
        }
        public void Unload()
        {
            foreach (InteractiveSquare square in squares)
            {
                panel.Controls.Remove(square.PictureBox);
            }
        }
        public void PositionateStart()
        {
            Point leftTopWhiteStoneCoordinates = new Point(size.Width / 2 - 1, size.Height / 2 - 1);
            int ltx = leftTopWhiteStoneCoordinates.X, lty = leftTopWhiteStoneCoordinates.Y;

            squares[ltx, lty].Stone = PlayerColor.White;
            squares[ltx + 1, lty].Stone = PlayerColor.Black;
            squares[ltx, lty + 1].Stone = PlayerColor.Black;
            squares[ltx + 1, lty + 1].Stone = PlayerColor.White;
        }
        private void PaintColors()
        {

            for (int x = 0; x < this.squares.GetLength(0); x++)
            {
                for (int y = 0; y < this.squares.GetLength(1); y++)
                {
                    this.squares[x, y].PictureBox.BackColor = (x + y) % 2 == 0 ? color_pair.A : color_pair.B;
                }
            }
        }
        private void PaintImages()
        {
            for (int x = 0; x < this.squares.GetLength(0); x++)
            {
                for (int y = 0; y < this.squares.GetLength(1); y++)
                {
                    squares[x, y].Stone = squares[x, y].Stone;
                }
            }
        }

        public PlayerColor[,] FetchMatrix()
        {
            PlayerColor[,] result = new PlayerColor[this.Width, this.Height];
            for(int x=0; x<this.Width; x++)
            {
                for(int y=0; y<this.Height; y++)
                {
                    result[x, y] = this.squares[x, y].Stone;
                }
            }
            return result;
        }

        public int Width///<summary>Get's the number of cells in the row of chessboard</summary>
        {
            get { return this.size.Width; }
            set
            {
                this.size.Width = value;
                this.Unload();
                this.Load();
            }
        }
        public int Height///<summary>Get's the number of cells in the column of chessboard</summary>
        {
            get { return this.size.Height; }
            set
            {
                this.size.Height = value;
                this.Unload();
                this.Load();
            }
        }
        public Color ColorA
        {
            get { return this.color_pair.A; }
            set
            {
                this.color_pair.A = value;
                this.PaintColors();
            }
        }
        public Color ColorB
        {
            get { return this.color_pair.B; }
            set
            {
                color_pair.B = value;
                this.PaintColors();
            }
        }
        public Image WhiteStoneStyle
        {
            get { return this.stone_style_pair.A; }
            set
            {
                this.stone_style_pair.A = value;
                PaintImages();
            }
        }
        public Image BlackStoneStyle
        {
            get { return this.stone_style_pair.B; }
            set
            {
                this.stone_style_pair.B = value;
                PaintImages();
            }
        }

        public InteractiveSquare[,] Squares
        {
            get { return this.squares; }
        }
        public Panel Panel
        {
            get { return this.panel; }
        }
    }
}
