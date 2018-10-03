using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reversi_Online
{
    public partial class GameVsMachine : ReversiForm
    {
        public abstract class MachineAlgorithm : ReversiGame
        {
            private class Clicker
            {
                private MachineAlgorithm machine_algorithm;
                private Point square_coordinates;
                public Clicker(Point square_coordinates, MachineAlgorithm machine_algorithm)
                {
                    this.machine_algorithm = machine_algorithm;
                    this.square_coordinates = square_coordinates;
                }
                public Clicker(int x, int y, MachineAlgorithm machine_algorithm) : this(new Point(x, y), machine_algorithm) { }

                public void React(object sender, EventArgs e)
                {
                    Move move = new Move(this.square_coordinates, this.machine_algorithm);
                    if (move.IsValid)
                    {
                        if (!this.machine_algorithm.game_started)
                        {
                            this.machine_algorithm.game_started = true;
                        }
                        this.machine_algorithm.MakeMove(move);
                    }
                }
                public Point SquareCoordinates
                {
                    get { return this.square_coordinates; }
                }
            }

            private bool game_started = false;

            private PictureBox black_moves_picturebox, white_moves_picturebox;
            private Label black_stones_amount_label, white_stones_amount_label;

            protected GameVsMachine gameVsMachine;

            public MachineAlgorithm(GameVsMachine gameVsMachine) : base(ref gameVsMachine.board)
            {
                this.gameVsMachine = gameVsMachine;
            }
            public abstract Move GetBestMove(ReversiGame reversiGame);
            
            public void Apply()
            {
                if (this.gameVsMachine.user_color == PlayerColor.White)
                {
                    this.white_moves_picturebox = this.gameVsMachine.user_moves_picturebox;
                    this.black_moves_picturebox = this.gameVsMachine.computer_moves_picturebox;
                    this.white_stones_amount_label = this.gameVsMachine.user_stones_amount_label;
                    this.black_stones_amount_label = this.gameVsMachine.computer_stones_amount_label;
                }
                else if (this.gameVsMachine.user_color == PlayerColor.Black)
                {
                    this.white_moves_picturebox = this.gameVsMachine.computer_moves_picturebox;
                    this.black_moves_picturebox = this.gameVsMachine.user_moves_picturebox;
                    this.white_stones_amount_label = this.gameVsMachine.computer_stones_amount_label;
                    this.black_stones_amount_label = this.gameVsMachine.user_stones_amount_label;
                }

                for (int x=0; x < this.gameVsMachine.board.Width; x++)
                {
                    for(int y=0; y<this.gameVsMachine.board.Height; y++)
                    {
                        Clicker clicker = new Clicker(x, y, this);
                        this.gameVsMachine.board.Squares[x, y].PictureBox.Click += clicker.React;
                    }
                }
                black_stones_amount_label.Text = this.BlackAmount.ToString();
                white_stones_amount_label.Text = this.WhiteAmount.ToString();
                
                this.FirstTurn();
            }
            protected Move GetExecutableMove(Move move)
            {
                return new Move(move.Coordinates, this);
            }
            private void MakeMove(Move move)
            {
                GameStatus gameStatus = move.Execute();
                black_stones_amount_label.Text = this.BlackAmount.ToString();
                white_stones_amount_label.Text = this.WhiteAmount.ToString();
                switch (gameStatus)
                {
                    case GameStatus.Normal:
                        ChangeTurn();
                        goto case GameStatus.BlackCombo;
                    case GameStatus.BlackCombo:
                    case GameStatus.WhiteCombo:
                        if (this.PlayerColor != gameVsMachine.user_color)
                        {
                            this.AnswerMove();
                        }
                        break;
                    case GameStatus.BlackWon:
                    case GameStatus.WhiteWon:
                    case GameStatus.Draw:
                        StopGame();
                        GameVsMachineResultAnnnouncement announcement = new GameVsMachineResultAnnnouncement(this.gameVsMachine);
                        announcement.Show();
                        break;
                    default:
                        break;
                }
            }
            private async void AnswerMove()
            {
                /*await Task.Run(new Action(() =>
                {
                    
                }));*/
                //MessageBox.Show(Thread.CurrentThread.Name);
                await Task.Run(new Action(delegate
                {
                    Thread.Sleep(1000);
                    this.gameVsMachine.Invoke((MethodInvoker)delegate
                    {
                        //MessageBox.Show("invoke");
                        
                        Move computer_answer_move = this.GetBestMove(this);
                        //computer_answer_move.Execute();
                        MakeMove(computer_answer_move);
                    });
                    
                }));
                
            }
            private void FirstTurn()
            {
                this.black_moves_picturebox.Image = Properties.Resources.moves;
                this.white_moves_picturebox.Image = null;
                if(this.gameVsMachine.user_color == PlayerColor.Black)
                {
                    this.gameVsMachine.board.Panel.Enabled = true;
                }
                else
                {
                    this.gameVsMachine.board.Panel.Enabled = false;
                    this.AnswerMove();
                    this.ChangeTurn();
                }
            }
            private void ChangeTurn()
            {
                //MessageBox.Show("change turn");
                if (this.PlayerColor==PlayerColor.White)
                {
                    this.white_moves_picturebox.Image = Properties.Resources.moves;
                    this.black_moves_picturebox.Image = null;
                }
                else if(this.PlayerColor==PlayerColor.Black)
                {
                    this.white_moves_picturebox.Image = null;
                    this.black_moves_picturebox.Image = Properties.Resources.moves;
                }
                this.gameVsMachine.board.Panel.Enabled = this.gameVsMachine.user_color == this.PlayerColor;
            }
            private void StopGame()
            {
                this.black_moves_picturebox.Image = null;
                this.white_moves_picturebox.Image = null;
                this.gameVsMachine.board.Panel.Enabled = false;
            }

        }

        private class Machine_LVL_0_Algorithm : MachineAlgorithm
        {
            public Machine_LVL_0_Algorithm(GameVsMachine gameVsMachine) : base(gameVsMachine) {
                
            }
            public override Move GetBestMove(ReversiGame reversiGame)
                ///<summary>
                ///
                /// This is the lvl 0 so the mashine is stupid and returns random, but correct move answers
                ///
                ///</summary>
            {
                List<Move> available_moves = new List<Move>();
                for(int x=0; x<gameVsMachine.board.Width; x++)
                {
                    for(int y=0; y<gameVsMachine.board.Height; y++)
                    {
                        Move move_candidate = new Move(x, y, reversiGame);
                        if (move_candidate.IsValid)
                        {
                            available_moves.Add(move_candidate);
                        }
                    }
                }
                return available_moves[new Random().Next(0, available_moves.Count)];
            }
        }
        private class Machine_LVL_1_Algorithm : MachineAlgorithm
        ///<summary>
        ///
        /// The algorithm returns the move that would be most profitable if the game ended after that move
        /// 
        /// </summary>
        {
            public Machine_LVL_1_Algorithm(GameVsMachine gameVsMachine) : base(gameVsMachine)
            {

            }
            public override Move GetBestMove(ReversiGame reversiGame)
            {
                List<Move> best_moves = new List<Move>();
                for (int x = 0; x < reversiGame.Matrix.GetLength(0); x++)
                {
                    for (int y = 0; y < reversiGame.Matrix.GetLength(1); y++)
                    {
                        Move candidate = new Move(x, y, reversiGame);
                        if (!candidate.IsValid) continue;
                        bool candidate_accepted = true;
                        List<Move> same_good_moves = new List<Move>();
                        for (int i = 0; i < best_moves.Count; i++)
                        {
                            if (candidate.ProfitPoints.Count < best_moves[i].ProfitPoints.Count)
                            {
                                candidate_accepted = false;
                                break;
                            }
                            else if (candidate.ProfitPoints.Count == best_moves[i].ProfitPoints.Count)
                            {
                                same_good_moves.Add(best_moves[i]);
                            }
                        }
                        if (candidate_accepted)
                        {
                            best_moves.Clear();
                            best_moves.AddRange(same_good_moves);
                            best_moves.Add(candidate);
                        }
                    }
                }
                return best_moves[new Random().Next(0, best_moves.Count)];
            }
 
        }
        private class Machine_LVL_2_Algorithm : Machine_LVL_1_Algorithm
        ///<summary>
        ///
        /// This algorithm checks each available move for the worst most-profitable opponent's move answer
        /// (The class inherits from the lower level machine
        /// 
        /// </summary>
        {
            public Machine_LVL_2_Algorithm(GameVsMachine gameVsMachine) : base(gameVsMachine)
            {
                
            }
            public override Move GetBestMove(ReversiGame reversiGame)
            { 
                //MessageBox.Show("Ctrl1: "+this.PlayerColor.ToString());
                //return base.GetBestMove();
                #region rubbish
                /*List<Move> less_most_profitable_for_opponent_moves = new List<Move>();
                for(int x=0; x<gameVsMachine.board.Width; x++)
                {
                    for(int y=0; y<gameVsMachine.board.Height; y++)
                    {
                        Chessboard.Square[,] test_matrix = gameVsMachine.board.Squares;
                        ReversiGame tester_game = new ReversiGame(ref test_matrix);
                        Move move = new Move(x, y, tester_game);
                        if (!move.IsValid) continue;
                        GameStatus testerGameStatus = tester_game.ExecuteMove(move);
                        
                        switch (testerGameStatus)
                        {
                            case GameStatus.Normal://checking the opponent's situation:
                                Move opponents_best_move = Machine_LVL_1_Algorithm.GetBestMove(tester_game);
                                for(int i=0; i<less_most_profitable_for_opponent_moves.Count; i++)
                                {
                                    if (opponents_best_move.ProfitPoints.Count > less_most_profitable_for_opponent_moves[i].ProfitPoints.Count) break;

                                    else
                                    {

                                        less_most_profitable_for_opponent_moves.Add(opponents_best_move);
                                    }
                                }
                                break;
                            case GameStatus.BlackWon:
                            case GameStatus.WhiteWon:
                            case GameStatus.Draw:
                                return base.GetBestMove();
                            default://combo:
                                break;
                        }
                        

                    }
                }*/
                #endregion
                //return GetBestMove(this);
                var move_with_user_best_answer_pairs = new List<Pair<Move>>();
                var winning_moves = new List<Move>();
                var losing_moves = new List<Move>();
                var drawing_moves = new List<Move>();
                var comboing_moves = new List<Move>();



                for (int x = 0; x < reversiGame.Matrix.GetLength(0); x++)
                {
                    for (int y = 0; y < reversiGame.Matrix.GetLength(1); y++)
                    {
                        //PlayerColor[,] experimental_matrix = gameVsMachine.board.FetchMatrix();
                        //ReversiGame experimental_game = new ReversiGame(ref experimental_matrix, this.PlayerColor);
                        ReversiGame experimental_game = reversiGame.Clone() as ReversiGame;
                        //MessageBox.Show(experimental_game.PlayerColor.ToString());
                        Move move = new Move(x, y, experimental_game);
                        if (move.IsValid)
                        {

                            switch (move.Execute())
                            {
                                case GameStatus.Normal:
                                    move_with_user_best_answer_pairs.Add(new Pair<Move>(new Move(x, y, experimental_game), new Machine_LVL_1_Algorithm(gameVsMachine).GetBestMove(experimental_game)));
                                    break;
                                case GameStatus.WhiteWon:
                                    if (experimental_game.PlayerColor == PlayerColor.Black)
                                    {//winning
                                        winning_moves.Add(move);
                                    }
                                    else if (experimental_game.PlayerColor == PlayerColor.White)
                                    {//lossing
                                        losing_moves.Add(move);
                                    }
                                    break;
                                case GameStatus.BlackWon:
                                    if (experimental_game.PlayerColor == PlayerColor.White)
                                    {//winning
                                        winning_moves.Add(move);
                                    }
                                    else if (experimental_game.PlayerColor == PlayerColor.Black)
                                    {//lossing
                                        losing_moves.Add(move);
                                    }
                                    break;
                                case GameStatus.Draw:
                                    drawing_moves.Add(move);
                                    break;
                                case GameStatus.BlackCombo:
                                case GameStatus.WhiteCombo:
                                    comboing_moves.Add(move);
                                    break;
                            }

                        }
                    }
                }
                //MessageBox.Show("Ctrl2: " + this.PlayerColor.ToString());
                Random random = new Random();
                if (winning_moves.Count > 0)
                {
                    return GetExecutableMove(winning_moves[random.Next(0, winning_moves.Count)]);
                }
                else if (comboing_moves.Count > 0)
                {
                    /*List<Move> best_moves = new List<Move>();

                    for (int i = 0; i < comboing_moves.Count; i++)
                    {
                        bool best = true;
                        List<Move> same_best_moves = new List<Move>();
                        for (int j = 0; j < best_moves.Count; j++)
                        {
                            if (comboing_moves[i].ProfitPoints.Count < best_moves[j].ProfitPoints.Count)
                            {
                                best = false;
                                break;
                            }
                            else if (comboing_moves[i].ProfitPoints.Count == best_moves[j].ProfitPoints.Count)
                            {
                                same_best_moves.Add(best_moves[j]);
                            }
                        }
                        if (best)
                        {
                            best_moves.Clear();
                            best_moves.AddRange(same_best_moves);
                            best_moves.Add(comboing_moves[i]);
                        }
                    }*/
                    List<Move> best_moves = comboing_moves.GetMaxProperties("ProfitPoints", "Count") as List<Move>;
                    return GetExecutableMove(best_moves[random.Next(0, best_moves.Count)]);
                }
                else if (move_with_user_best_answer_pairs.Count > 0)
                {
                    //MessageBox.Show("Ctrl3: " + this.PlayerColor.ToString());
                    /*var best_solutions = new List<Pair<Move>>();
                    for (int i = 0; i < move_with_user_best_answer_pairs.Count; i++)
                    {
                        bool best = true;
                        var same_best_solutions = new List<Pair<Move>>();
                        for (int j = 0; j < best_solutions.Count; j++)
                        {
                            if (move_with_user_best_answer_pairs[i].B.ProfitPoints.Count > best_solutions[j].B.ProfitPoints.Count)
                            {
                                best = false;
                                break;
                            }
                            else if (move_with_user_best_answer_pairs[i].B.ProfitPoints.Count == best_solutions[j].B.ProfitPoints.Count)
                            {
                                same_best_solutions.Add(best_solutions[j]);
                            }
                        }
                        if (best)
                        {
                            best_solutions.Clear();
                            best_solutions.AddRange(same_best_solutions);
                            best_solutions.Add(move_with_user_best_answer_pairs[i]);
                        }
                    }*/
                    List<Pair<Move>> best_solutions = move_with_user_best_answer_pairs.GetMinProperties("B", "ProfitPoints", "Count") as List<Pair<Move>>;
                    //Move choosen_move = best_solutions[random.Next(0, best_solutions.Count)].A;
                    //Move output = new Move(choosen_move.Coordinates, this);
                    return GetExecutableMove(best_solutions[random.Next(0, best_solutions.Count)].A);

                }
                else if (drawing_moves.Count > 0)
                {
                    return GetExecutableMove(drawing_moves[random.Next(0, drawing_moves.Count)]);
                }
                else if (losing_moves.Count > 0)
                {
                    return new Machine_LVL_1_Algorithm(gameVsMachine).GetBestMove(reversiGame);
                }
                else
                {
                    return null;
                }
            }
        }
        private class Machine_LVL_3_Algorithm : Machine_LVL_2_Algorithm
        {
            public Machine_LVL_3_Algorithm(GameVsMachine gameVsMachine) : base(gameVsMachine)
            {

            }
            public override Move GetBestMove(ReversiGame reversiGame)
            {
                #region rubish
                ////declare variables not war:

                //var winning = new List<Move>();
                //var next_winning = new List<Pair<Move>>();

                //var lossing = new List<Move>();
                //var next_lossing = new List<Pair<Move>>();

                //var drawing = new List<Move>();
                //var next_drawing = new List<Pair<Move>>();

                //var comboing = new List<Move>();
                //var next_comboing = new List<Pair<Move>>();

                //var normal = new List<Pair<Move>>();


                //for(int x=0; x<this.gameVsMachine.board.Width; x++)
                //{
                //    for(int y=0; y<this.gameVsMachine.board.Height; y++)
                //    {
                //        ReversiGame experiment = this.Clone() as ReversiGame;
                //        Move move = new Move(x, y, experiment);
                //        if (move.IsValid)
                //        {
                //            switch (move.Execute())
                //            {
                //                case GameStatus.Normal:

                //                    ReversiGame second_experimental = experiment.Clone() as ReversiGame;
                //                    Move opponents_move = Machine_LVL_2_Algorithm.GetBestMove(second_experimental);

                //                    switch (opponents_move.Execute())
                //                    {
                //                        case GameStatus.Normal:
                //                            Move next_machine_best_move = Machine_LVL_2_Algorithm.GetBestMove(second_experimental);
                //                            normal.Add(new Pair<Move>(move, next_machine_best_move));

                //                            break;
                //                        case GameStatus.BlackWon:
                //                            if (this.PlayerColor == PlayerColor.White)
                //                            {
                //                                next_lossing.Add(new Pair<Move>(move, opponents_move));
                //                            }
                //                            else if (this.PlayerColor == PlayerColor.Black)
                //                            {
                //                                next_winning.Add(new Pair<Move>(move, opponents_move));
                //                            }
                //                            break;
                //                        case GameStatus.WhiteWon:
                //                            if (this.PlayerColor == PlayerColor.Black)
                //                            {
                //                                next_lossing.Add(new Pair<Move>(move, opponents_move));
                //                            }
                //                            else if (this.PlayerColor == PlayerColor.White)
                //                            {
                //                                next_winning.Add(new Pair<Move>(move, opponents_move));
                //                            }
                //                            break;
                //                        case GameStatus.Draw:
                //                            next_drawing.Add(new Pair<Move>(move, opponents_move));
                //                            break;
                //                        case GameStatus.BlackCombo:
                //                        case GameStatus.WhiteCombo:
                //                            next_comboing.Add(new Pair<Move>(move, opponents_move));
                //                            break;
                //                        default:
                //                            break;
                //                    }


                //                    break;
                //                case GameStatus.BlackWon:
                //                    if (this.PlayerColor == PlayerColor.White)
                //                    {
                //                        winning.Add(move);
                //                    }
                //                    else if (this.PlayerColor == PlayerColor.Black)
                //                    {
                //                        lossing.Add(move);
                //                    }
                //                    break;
                //                case GameStatus.WhiteWon:
                //                    if (this.PlayerColor == PlayerColor.Black)
                //                    {
                //                        winning.Add(move);
                //                    }
                //                    else if (this.PlayerColor == PlayerColor.White)
                //                    {
                //                        lossing.Add(move);
                //                    }
                //                    break;
                //                case GameStatus.Draw:
                //                    drawing.Add(move);
                //                    break;
                //                case GameStatus.BlackCombo:
                //                case GameStatus.WhiteCombo:
                //                    comboing.Add(move);
                //                    break;
                //                default:
                //                    break;

                //            }
                //        }
                //    }
                //}
                //Move get_executable_move(Move move)
                //{
                //    return new Move(move.Coordinates, this);
                //}
                //if (winning.Count > 0)
                //{
                //    List<Move> best_moves = winning.GetMaxProperties("ProfitPoints", "Count") as List<Move>;
                //    return get_executable_move(best_moves[new Random().Next(0, best_moves.Count)]); 
                //}
                //else if (next_winning.Count > 0)
                //{
                //    List<Pair<Move>> best_solutions = next_winning.GetMaxProperties("A", "ProfitPoints", "Count") as List<Pair<Move>>;
                //    return get_executable_move(best_solutions[new Random().Next(0, best_solutions.Count)].A);
                //}
                //else if (comboing.Count > 0)
                //{
                //    List<Move> best_moves = comboing.GetMaxProperties("ProfitPoints", "Count") as List<Move>;
                //    return get_executable_move(best_moves[new Random().Next(0, best_moves.Count)]);
                //}
                //else if (normal.Count > 0)
                //{
                //    Dictionary<Move, int> moves_with_total_profits_count = new Dictionary<Move, int>();

                //    for(int i=0; i<normal.Count; i++)
                //    {
                //        moves_with_total_profits_count.Add(normal[i].A, normal[i].A.ProfitPoints.Count + normal[i].B.ProfitPoints.Count);
                //    }

                //    var best = moves_with_total_profits_count.ToList().GetMaxProperties("Value") as List<KeyValuePair<Move, int>>;
                //    return get_executable_move(best[new Random().Next(0, best.Count)].Key);
                //}
                //else if (next_drawing.Count > 0)
                //{
                //    List<Pair<Move>> best_solutions = next_drawing.GetMaxProperties("A", "ProfitPoints", "Count") as List<Pair<Move>>;
                //    return get_executable_move(best_solutions[new Random().Next(0, best_solutions.Count)].A);
                //}
                //else if (drawing.Count > 0)
                //{
                //   // List<Move> best_moves = drawing.GetMaxProperties("ProfitPoints", "Count") as List<Move>;
                //  //  return get_executable_move(best_moves[new Random().Next(0, best_moves.Count)]);
                //    return get_executable_move(drawing[new Random().Next(0, drawing.Count)]);
                //}
                //else if (next_comboing.Count > 0)
                //{
                //    List<Pair<Move>> best_solutions = next_comboing.GetMaxProperties("A", "ProfitPoints", "Count") as List<Pair<Move>>;
                //    return get_executable_move(best_solutions[new Random().Next(0, best_solutions.Count)].A);
                //}
                //else if (next_lossing.Count > 0)
                //{
                //    List<Pair<Move>> best_solutions = next_lossing.GetMaxProperties("A", "ProfitPoints", "Count") as List<Pair<Move>>;
                //    return get_executable_move(best_solutions[new Random().Next(0, best_solutions.Count)].A);
                //}
                //else if (lossing.Count > 0)
                //{
                //    List<Move> best_moves = lossing.GetMaxProperties("ProfitPoints", "Count") as List<Move>;
                //    return get_executable_move(best_moves[new Random().Next(0, best_moves.Count)]);
                //}
                //else
                //{
                //    return null;
                //}
                #endregion
                List<Move> winning, lossing, drawing, comboing;
                winning = lossing = drawing = comboing = new List<Move>();
                
                Dictionary<Move, int> moves_with_balances = new Dictionary<Move, int>();
                for(int x=0; x<this.gameVsMachine.board.Width; x++)
                {
                    for(int y=0; y<this.gameVsMachine.board.Height; y++)
                    {
                        ReversiGame experimental = reversiGame.Clone() as ReversiGame;
                        Move move = new Move(x, y, experimental);
                        int profit_count = move.ProfitPoints.Count;
                        if (move.IsValid)
                        {
                            switch (move.Execute())
                            {
                                case GameStatus.Normal:
                                    moves_with_balances.Add(move, profit_count - new Machine_LVL_1_Algorithm(gameVsMachine).GetBestMove(experimental).ProfitPoints.Count);
                                    break;
                                case GameStatus.BlackWon:
                                    if (this.PlayerColor == PlayerColor.White)
                                    {
                                        winning.Add(move);
                                    }
                                    else if (this.PlayerColor == PlayerColor.Black)
                                    {
                                        lossing.Add(move);
                                    }
                                    break;
                                case GameStatus.WhiteWon:
                                    if (this.PlayerColor == PlayerColor.White)
                                    {
                                        lossing.Add(move);
                                    }
                                    else if (this.PlayerColor == PlayerColor.Black)
                                    {
                                        winning.Add(move);
                                    }
                                    break;
                                case GameStatus.Draw:
                                    drawing.Add(move);
                                    break;
                                case GameStatus.BlackCombo:
                                case GameStatus.WhiteCombo:
                                    comboing.Add(move);
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                }
                if (winning.Count > 0)
                {
                    var best = winning.GetMaxProperties("ProfitPoints", "Count") as List<Move>;
                    return GetExecutableMove(best[new Random().Next(0, best.Count)]);
                }
                else if (comboing.Count > 0)
                {
                    var best = comboing.GetMaxProperties("ProfitPoints", "Count") as List<Move>;
                    return GetExecutableMove(best[new Random().Next(0, best.Count)]);

                }
                else if (moves_with_balances.Count > 0)
                {
                    var best_solutions = moves_with_balances.ToList().GetMaxProperties("Value") as List<KeyValuePair<Move, int>>;
                    return GetExecutableMove(best_solutions[new Random().Next(0, best_solutions.Count)].Key);
                }
                else if (drawing.Count > 0)
                {
                    return GetExecutableMove(drawing[new Random().Next(0, drawing.Count)]);
                }
                else if (lossing.Count > 0)
                {
                    var best = lossing.GetMaxProperties("ProfitPoints", "Count") as List<Move>;
                    return GetExecutableMove(best[new Random().Next(0, best.Count)]);
                }
                else return null;
            }
            

        }


        private int computer_level;
        private PlayerColor user_color;

        private MachineAlgorithm algorithm;

        private Chessboard board;

        public GameVsMachine(int computer_level, PlayerColor user_color)
        {
            this.computer_level = computer_level;
            this.user_color = user_color;
            
            InitializeComponent();
        }

        private void GameVsMachine_Load(object sender, EventArgs e)
        {
            
            computer_name_label.Text = $"Computer (lvl {this.computer_level}.)";
            if (user_color == PlayerColor.White)
            {
                user_stone_picturebox.Image = StoneStyleImage.FromIDAndColor(Properties.Settings.Default.board_white_stone_image_ID, PlayerColor.White);
                computer_stone_picturebox.Image = StoneStyleImage.FromIDAndColor(Properties.Settings.Default.board_black_stone_image_ID, PlayerColor.Black);
            }
            else
            {
                computer_stone_picturebox.Image = StoneStyleImage.FromIDAndColor(Properties.Settings.Default.board_white_stone_image_ID, PlayerColor.White);
                user_stone_picturebox.Image = StoneStyleImage.FromIDAndColor(Properties.Settings.Default.board_black_stone_image_ID, PlayerColor.Black);
            }
            this.board = new Chessboard(ref board_panel);
            board.Load();
            board.PositionateStart();
     

            switch (this.computer_level)
            {
                case 0:
                    this.algorithm = new Machine_LVL_0_Algorithm(this);
                    break;
                case 1:
                    this.algorithm = new Machine_LVL_1_Algorithm(this);
                    break;
                case 2:
                    this.algorithm = new Machine_LVL_2_Algorithm(this);
                    break;
                case 3:
                    this.algorithm = new Machine_LVL_3_Algorithm(this);
                    break;
                default:
                    this.algorithm = new Machine_LVL_3_Algorithm(this);
                    break;
            }
            algorithm.Apply();
        }
        
        private void GameVsMachine_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        public MachineAlgorithm Algorithm
        {
            get { return this.algorithm; }
        }
        public PlayerColor UserColor
        {
            get { return this.user_color; }
        }
        public int ComputerLevel
        {
            get { return this.computer_level; }
        }
        public Chessboard Board
        {
            get { return this.board; }
        }
    }
}
