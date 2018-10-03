using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Reversi_Online
{
    public enum PlayerColor
    {
        Black = -1, None, White, Random
    }
    public enum GameStatus
    {
        Normal, BlackWon, WhiteWon, Draw, BlackCombo, WhiteCombo//combo occurs when the opponent has no allowed move after your move, then you make another move
    }
    public class ReversiGame : ICloneable
    {
        private PlayerColor playerColor;
        private Chessboard.Square[,] matrix;

        private int white_amount = 0;
        private int black_amount = 0;

        private GameStatus status;

        private void Initialize(Chessboard.Square[,] matrix, PlayerColor playerColor)
        {
            this.playerColor = playerColor;
            this.matrix = matrix;
            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                for (int y = 0; y < matrix.GetLength(1); y++)
                {
                    if (matrix[x, y].Stone == PlayerColor.White) ++this.white_amount;
                    else if (matrix[x, y].Stone == PlayerColor.Black) ++this.black_amount;
                }
            }
        }
        public ReversiGame(ref Chessboard.Square[,] matrix, PlayerColor playerColor=PlayerColor.Black)
        {
            this.Initialize(matrix, playerColor);
        }
        public ReversiGame(ref Chessboard chessboard, PlayerColor playerColor=PlayerColor.Black)
        {
            this.Initialize(chessboard.Squares, playerColor);
        }
        public ReversiGame(ref PlayerColor[,] matrix, PlayerColor playerColor = PlayerColor.Black)
        {
            Chessboard.Square[,] squares = new Chessboard.Square[matrix.GetLength(0), matrix.GetLength(1)];
            for(int x=0; x<matrix.GetLength(0); x++)
            {
                for(int y=0; y<matrix.GetLength(1); y++)
                {
                    squares[x, y] = new Chessboard.Square(matrix[x, y]);
                }
            }
            this.Initialize(squares, playerColor);
        }
        public ReversiGame(PlayerColor[,] matrix, PlayerColor playerColor=PlayerColor.Black):this(ref matrix, playerColor) { }

        
        public class Move
        {
            private class ProfitPointsGetter
            {
                private Move move;


                public ProfitPointsGetter(Move move)
                {
                    this.move = move;
                }
                public List<Point> GetProfitPoints()
                {
                    List<Point>[] profitPointsLists = new List<Point>[8]
                    {
                        GetProfitPointsThroughVectorLine(new Vector(0, -1)), //N
                        GetProfitPointsThroughVectorLine(new Vector(1, -1)), //NE
                        GetProfitPointsThroughVectorLine(new Vector(1, 0)),  //E
                        GetProfitPointsThroughVectorLine(new Vector(1, 1)),  //SE
                        GetProfitPointsThroughVectorLine(new Vector(0, 1)),  //S
                        GetProfitPointsThroughVectorLine(new Vector(-1, 1)), //SW
                        GetProfitPointsThroughVectorLine(new Vector(-1, 0)), //W
                        GetProfitPointsThroughVectorLine(new Vector(-1, -1)) //NW
                    };
                    List<Point> profitPoints = new List<Point>();
                    for (int i = 0; i < profitPointsLists.Length; i++)
                    {
                        profitPoints.AddRange(profitPointsLists[i]);
                    }
                    return profitPoints;

                }
                private List<Point> GetProfitPointsThroughVectorLine(Vector vector)
                {
                    Point crosshair = this.move.Coordinates;
                    List<Point> profitPoints = new List<Point>();
                    while (true)
                    {
                        crosshair += vector;
                        if (crosshair.X > move.reversiGame.matrix.GetLength(0) - 1 || crosshair.X < 0 || crosshair.Y > move.reversiGame.matrix.GetLength(1) - 1 || crosshair.Y < 0)
                        {
                            profitPoints.Clear();
                            return profitPoints;
                        }
                        else
                        {
                            if (move.reversiGame.GetOpponent(move.reversiGame.matrix[crosshair.X, crosshair.Y].Stone) == move.reversiGame.PlayerColor)
                            {
                                profitPoints.Add(crosshair);
                            }
                            else if (move.reversiGame.matrix[crosshair.X, crosshair.Y].Stone == move.reversiGame.PlayerColor)
                            {
                                return profitPoints; //this causes a move is valid
                            }
                            else
                            {
                                profitPoints.Clear();
                                return profitPoints;
                            }
                        }
                    }
                }
            }
            private const string xSequence = "abcdefghijklmnopqrstuvwxyz";
            private string moveCode;
            private Point coordinates;
            private ReversiGame reversiGame;

            private List<Point> profitPoints;
            
            public Move(string moveCode, ReversiGame reversiGame)
            {
                this.moveCode = moveCode;
                this.coordinates = new Point(xSequence.IndexOf(this.moveCode[0]), Convert.ToInt32(this.moveCode.Substring(1))-1);
                this.reversiGame = reversiGame;
                //CalculateProfitPoints();
            }
            public Move(Point coordinates, ReversiGame reversiGame)
            {
                this.moveCode = xSequence[coordinates.X] + (coordinates.Y+1).ToString();
                this.coordinates = coordinates;
                this.reversiGame = reversiGame;
                //CalculateProfitPoints();
            }
            public Move(int x, int y, ReversiGame reversiGame)
            {
                this.moveCode = xSequence[x] + (y+1).ToString();
                this.coordinates = new Point(x, y);
                this.reversiGame = reversiGame;
                //CalculateProfitPoints();
            }
            
            private void CalculateProfitPoints()
            {
                ProfitPointsGetter profitPointsGetter = new ProfitPointsGetter(this);
                this.profitPoints = profitPointsGetter.GetProfitPoints();
            }
            public static implicit operator Point(Move move)
            {
                return move.Coordinates;
            }
            public GameStatus Execute()
            {
                if (this.IsValid)
                {
                    List<Point> profitPoints = this.ProfitPoints;
                    //capturing
                    for (int i = 0; i < profitPoints.Count; i++)
                    {
                        reversiGame.matrix[profitPoints[i].X, profitPoints[i].Y].Stone = reversiGame.playerColor;
                    }
                    if (reversiGame.playerColor == PlayerColor.Black)
                    {
                        reversiGame.black_amount += profitPoints.Count + 1;
                        reversiGame.white_amount -= profitPoints.Count;
                    }
                    else if (reversiGame.playerColor == PlayerColor.White)
                    {
                        reversiGame.white_amount += profitPoints.Count + 1;
                        reversiGame.black_amount -= profitPoints.Count;
                    }
                    //placing a new stone
                    reversiGame.matrix[this.Coordinates.X, this.Coordinates.Y].Stone = reversiGame.playerColor;
                    //checking the game status
                    reversiGame.ChangeTurn();//switching to the opponent's situation
                    

                    bool isCombo = true;
                    for (int x = 0; x < reversiGame.matrix.GetLength(0); x++)
                    {
                        for (int y = 0; y < reversiGame.matrix.GetLength(1); y++)
                        {

                            /*if (reversiGame.matrix[x, y].Stone == PlayerColor.None)
                            {
                                gameEnded = false;
                            }*/

                            if (new Move(x, y, reversiGame).IsValid) isCombo = false;
                        }
                    }

                    bool gameEnded = false;
                    //checking whether combo or a stalemate occurs
                    if (isCombo)
                    {
                        reversiGame.ChangeTurn(); //switching to the player that caused the combo and checking whether it's stalemate
                        bool isStalemate = true;
                        for (int x = 0; x < reversiGame.matrix.GetLength(0); x++)
                        {
                            for (int y = 0; y < reversiGame.matrix.GetLength(1); y++)
                            {
                                if (new Move(x, y, reversiGame).IsValid)
                                {
                                    isStalemate = false; break;
                                }
                            }
                            if (!isStalemate) break;
                        }
                        if (isStalemate) gameEnded = true;
                        else return reversiGame.status = reversiGame.playerColor == PlayerColor.White ? GameStatus.WhiteCombo : GameStatus.BlackCombo;
                    }

                    if (gameEnded)// not else if!
                    {
                        if (reversiGame.white_amount > reversiGame.black_amount) return reversiGame.status = GameStatus.WhiteWon;
                        else if (reversiGame.black_amount > reversiGame.white_amount) return reversiGame.status = GameStatus.BlackWon;
                        else return reversiGame.status = GameStatus.Draw;

                    }
                    else
                    {
                        return reversiGame.status = GameStatus.Normal;
                    }

                }
                else
                {
                    throw new MoveNotAllowedException();
                }
            }

            public bool IsValid
            {
                get
                {
                    CalculateProfitPoints();
                    return this.profitPoints.Count > 0 && reversiGame.matrix[this.Coordinates.X, this.Coordinates.Y].Stone == PlayerColor.None;
                }
            }
            public string MoveCode
            {
                get { return this.moveCode; }
            }
            public Point Coordinates
            {
                get { return this.coordinates; }
            }


            public List<Point> ProfitPoints
            {
                get
                {
                    CalculateProfitPoints();
                    return this.profitPoints;
                }
            }
            public GameStatus GameAffect
            {// throws a MoveNotAllowedException if this move is not allowed
                get
                {
                    ReversiGame test = this.reversiGame.Clone() as ReversiGame;
                    Move test_move = new Move(this.coordinates, test);
                    test_move.Execute();
                    return test.Status;
                }
            }
        }
        public class MoveNotAllowedException : Exception
        {
            private string message;
            public MoveNotAllowedException()
            {
                this.message = "The specified move is invalid in the current othello position";
            }
            public override string Message
            {
                get { return this.message; }
            }
        }
        
        public object Clone()
        {
            return new ReversiGame(this.FetchMatrix(), this.PlayerColor);
        }
        public PlayerColor[,] FetchMatrix()
        {
            PlayerColor[,] result = new PlayerColor[this.matrix.GetLength(0), this.matrix.GetLength(1)];
            for(int x=0; x<result.GetLength(0); x++)
            {
                for(int y=0; y<result.GetLength(1); y++)
                {
                    result[x, y] = this.matrix[x, y].Stone;
                }
            }
            return result;
        }
        
        public PlayerColor GetOpponent(PlayerColor playerColor)
        {
            return (PlayerColor)(-(int)playerColor);
        }
        private PlayerColor ChangeTurn()
        {
            return this.playerColor = (PlayerColor)((int)this.playerColor * -1);
        }
        public PlayerColor PlayerColor
        {
            get { return this.playerColor; }
            set { this.playerColor = value; }
        }
        public GameStatus Status
        {
            get { return this.status; }
        }
        public int WhiteAmount
        {
            get {
                return this.white_amount;
            }
        }
        public int BlackAmount
        {
            get {
                return this.black_amount;
            }
        }

        public Chessboard.Square[,] Matrix
        {
            get { return this.matrix; }
        }
    }
    
}
