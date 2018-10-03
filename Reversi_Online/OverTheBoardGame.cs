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
    public partial class OverTheBoardGame : ReversiForm
    {
        private class OverTheBoardAlgorithm : ReversiGame
        {
            private Label black_timer_label, white_timer_label, black_score_label, white_score_label;
            private string black_name, white_name;
            private TimeSpan black_remaining_time, white_remaining_time;
            private OverTheBoardGame overTheBoardGame;

            private bool using_clocks;


            //private ReversiGame reversiGame;

            private Timer black_timer, white_timer;

            private bool game_started = false;

            public OverTheBoardAlgorithm(OverTheBoardGame overTheBoardGame) : base(ref overTheBoardGame.board)
            {
                this.overTheBoardGame = overTheBoardGame;

                if (overTheBoardGame.user_color == PlayerColor.White)
                {
                    this.black_name = overTheBoardGame.opponents_name;
                    this.white_name = overTheBoardGame.user_name;
                    this.black_timer_label = overTheBoardGame.opponents_timer_label;
                    this.white_timer_label = overTheBoardGame.user_timer_label;
                    this.black_score_label = overTheBoardGame.opponents_stones_amount_label;
                    this.white_score_label = overTheBoardGame.user_stones_amount_label;
                }
                else if (overTheBoardGame.user_color == PlayerColor.Black)
                {
                    this.black_name = overTheBoardGame.user_name;
                    this.white_name = overTheBoardGame.opponents_name;
                    this.black_timer_label = overTheBoardGame.user_timer_label;
                    this.white_timer_label = overTheBoardGame.opponents_timer_label;
                    this.black_score_label = overTheBoardGame.user_stones_amount_label;
                    this.white_score_label = overTheBoardGame.opponents_stones_amount_label;
                }
                this.using_clocks = overTheBoardGame.time_control.TotalSeconds > 0;
            }
            public void Apply()
            {
                //this.reversiGame = new ReversiGame(overTheBoardGame.board);
                black_score_label.Text = base.BlackAmount.ToString();
                white_score_label.Text = base.WhiteAmount.ToString();
                for (int x = 0; x < overTheBoardGame.board.Squares.GetLength(0); x++)
                {
                    for (int y = 0; y < overTheBoardGame.board.Squares.GetLength(1); y++)
                    {
                        overTheBoardGame.board.Squares[x, y].PictureBox.Click += new Clicker(x, y, this).React;
                    }
                }
                if (using_clocks)
                {
                    this.black_remaining_time = overTheBoardGame.time_control;
                    this.white_remaining_time = overTheBoardGame.time_control;
                    this.black_timer_label.Text = black_remaining_time.ToString("g");
                    this.white_timer_label.Text = white_remaining_time.ToString("g");
                    this.black_timer = new Timer() { Interval = 1000 };
                    this.white_timer = new Timer() { Interval = 1000 };
                    black_timer.Tick += (s, e) =>
                    {
                        black_remaining_time = new TimeSpan(black_remaining_time.Hours, black_remaining_time.Minutes, black_remaining_time.Seconds - 1);
                        black_timer_label.Text = black_remaining_time.ToString("g");
                        if (black_remaining_time.TotalSeconds <= 0)
                        {
                            //white won on time
                            this.StopGame();
                            new OverTheBoardGameResultAnnouncement($"{white_name} wins on time...", null, $"{black_name}: {GetScore(base.BlackAmount)}", $"{white_name}: {GetScore(base.WhiteAmount)}", Properties.Resources.clock, overTheBoardGame.board.BlackStoneStyle, overTheBoardGame.board.WhiteStoneStyle).Show();
                        }
                    };
                    white_timer.Tick += (s, e) =>
                    {
                        white_remaining_time = new TimeSpan(white_remaining_time.Hours, white_remaining_time.Minutes, white_remaining_time.Seconds - 1);
                        white_timer_label.Text = white_remaining_time.ToString("g");
                        if (white_remaining_time.TotalSeconds <= 0)
                        {
                            //black won on time
                            this.StopGame();
                            new OverTheBoardGameResultAnnouncement($"{black_name} wins on time...", null, $"{black_name}: {GetScore(base.BlackAmount)}", $"{white_name}: {GetScore(base.WhiteAmount)}", Properties.Resources.clock, overTheBoardGame.board.BlackStoneStyle, overTheBoardGame.board.WhiteStoneStyle).Show();
                        }
                    };
                }
                else
                {
                    this.black_timer_label.Text = "∞";
                    this.white_timer_label.Text = "∞";
                }
                this.black_timer_label.BackColor = Color.Maroon;
            }
            private void ChangeTimers()
            {
                if (base.PlayerColor == PlayerColor.White)
                {
                    black_timer.Stop();
                    black_timer_label.BackColor = Color.Black;
                    white_timer.Start();
                    white_timer_label.BackColor = Color.Maroon;
                }
                else if (base.PlayerColor == PlayerColor.Black)
                {
                    white_timer.Stop();
                    white_timer_label.BackColor = Color.Black;
                    black_timer.Start();
                    black_timer_label.BackColor = Color.Maroon;
                }
            }
            private void ChangeTimersOnlyColors()
            {
                if (base.PlayerColor == PlayerColor.White)
                {
                    black_timer_label.BackColor = Color.Black;
                    white_timer_label.BackColor = Color.Maroon;
                }
                else if (base.PlayerColor == PlayerColor.Black)
                {
                    white_timer_label.BackColor = Color.Black;
                    black_timer_label.BackColor = Color.Maroon;
                }
            }
            public void StopGame()
            {
                overTheBoardGame.board.Panel.Enabled = false;
                black_timer.Stop();
                black_timer_label.BackColor = Color.Black;
                white_timer.Stop();
                white_timer_label.BackColor = Color.Black;
            }
            private string GetScore(int stones_amount)
            {
                string score = $"{stones_amount} stone";
                if (stones_amount != 1) score += "s";
                return score;
            }
            private class Clicker
            {
                private Point squareCoordinates;
                private OverTheBoardAlgorithm algorithm;
                public Clicker(Point squareCoordinates, OverTheBoardAlgorithm algorithm)
                {
                    this.squareCoordinates = squareCoordinates;
                    this.algorithm = algorithm;
                }
                public Clicker(int x, int y, OverTheBoardAlgorithm algorithm)
                {
                    this.squareCoordinates = new Point(x, y);
                    this.algorithm = algorithm;
                }
                public void React(object sender, EventArgs ea)
                {
                    //MessageBox.Show($"X: {squareCoordinates.X}, Y: {squareCoordinates.Y}");
                    ReversiGame.Move move = new ReversiGame.Move(squareCoordinates.X, squareCoordinates.Y, this.algorithm);
                    if (move.IsValid)
                    {
                        if (!this.algorithm.game_started && algorithm.using_clocks)
                        {
                            algorithm.black_timer.Start();
                        }

                        GameStatus gameStatus = move.Execute();

                        algorithm.black_score_label.Text = algorithm.BlackAmount.ToString();
                        algorithm.white_score_label.Text = algorithm.WhiteAmount.ToString();

                        switch (gameStatus)
                        {
                            case GameStatus.Normal:
                                if(algorithm.using_clocks) algorithm.ChangeTimers();
                                else { algorithm.ChangeTimersOnlyColors(); }
                                break;
                            case GameStatus.BlackCombo:
                                break;
                            case GameStatus.WhiteCombo:
                                break;
                            case GameStatus.BlackWon:
                                if(algorithm.using_clocks) algorithm.StopGame();
                                new OverTheBoardGameResultAnnouncement($"{algorithm.black_name} wins!", null, $"{algorithm.black_name}: {algorithm.GetScore(algorithm.BlackAmount)}", $"{algorithm.white_name}: {algorithm.GetScore(algorithm.WhiteAmount)}", Properties.Resources.winner_cup, algorithm.overTheBoardGame.board.BlackStoneStyle, algorithm.overTheBoardGame.board.WhiteStoneStyle).Show();
                                break;
                            case GameStatus.WhiteWon:
                                if (algorithm.using_clocks) algorithm.StopGame();
                                new OverTheBoardGameResultAnnouncement($"{algorithm.white_name} wins!", null, $"{algorithm.black_name}: {algorithm.GetScore(algorithm.BlackAmount)}", $"{algorithm.white_name}: {algorithm.GetScore(algorithm.WhiteAmount)}", Properties.Resources.winner_cup, algorithm.overTheBoardGame.board.BlackStoneStyle, algorithm.overTheBoardGame.board.WhiteStoneStyle).Show();
                                break;
                            case GameStatus.Draw:
                                if (algorithm.using_clocks) algorithm.StopGame();
                                new OverTheBoardGameResultAnnouncement($"It's a draw!", null, $"{algorithm.black_name}: {algorithm.GetScore(algorithm.BlackAmount)}", $"{algorithm.white_name}: {algorithm.GetScore(algorithm.WhiteAmount)}", Properties.Resources.draw_pic, algorithm.overTheBoardGame.board.BlackStoneStyle, algorithm.overTheBoardGame.board.WhiteStoneStyle).Show();
                                break;
                        }
                    }
                }
                public Point SquareCoordinates
                {
                    get { return this.squareCoordinates; }
                }
            }

            public bool UsingClocks
            {
                get { return this.using_clocks; }
            }
        }


        private string user_name;
        private string opponents_name;
        private TimeSpan time_control;
        private PlayerColor user_color;
        private OverTheBoardAlgorithm overTheBoardAlgorithm;

        private Chessboard board;
        public OverTheBoardGame(string user_name, string opponents_name, PlayerColor user_color, TimeSpan time_control)
        {
            this.user_name = user_name;
            this.opponents_name = opponents_name;
            this.user_color = user_color;
            this.time_control = time_control;

            InitializeComponent();
        }

        private void OverTheBoardGame_Load(object sender, EventArgs e)
        {
            user_name_label.Text = /*Properties.Settings.Default.offline_user_name*/this.user_name;
            opponents_name_label.Text = /*Properties.Settings.Default.offline_opponents_name*/this.opponents_name;
            this.board = new Chessboard(ref board_panel);
            board.Load();
            board.PositionateStart();
            //user_stone_picturebox.Image =
            if (this.user_color == PlayerColor.White)
            {
                user_stone_picturebox.Image = this.board.WhiteStoneStyle;
                opponents_stone_picturebox.Image = this.board.BlackStoneStyle;
            }
            else if (this.user_color == PlayerColor.Black)
            {
                user_stone_picturebox.Image = this.board.BlackStoneStyle;
                opponents_stone_picturebox.Image = this.board.WhiteStoneStyle;
            }
            
            /*TimeSpan time_control = new TimeSpan(0, Properties.Settings.Default.offline_game_time_control, 0);*/
            
            this.overTheBoardAlgorithm = new OverTheBoardAlgorithm(this);
            
            overTheBoardAlgorithm.Apply();
        }
        private void OverTheBoardGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(this.overTheBoardAlgorithm.UsingClocks) this.overTheBoardAlgorithm.StopGame();
            this.Owner.Show();
        }

       /* public string UserName
        {
            get { return this.user_name; }
        }
        public string OponentsName
        {
            get { return this.opponents_name; }
        }
        public TimeSpan TimeControl
        {
            get { return this.time_control; }
        }
        public PlayerColor UserColor
        {
            get { return this.user_color; }
        }
        public Chessboard Board
        {
            get { return this.board; }
        }
        public Label UserTimerLabel
        {
            get { return this.user_timer_label; }
        }
        public Label OpponentsTimerLabel {
            get { return this.opponents_timer_label; }
        }*/
    }

}
