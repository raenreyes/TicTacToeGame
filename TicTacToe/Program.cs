namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] grid =
           {
                {'1', '2', '3'},
                {'4', '5', '6'},
                {'7', '8', '9'}
            };

            UserController boardGame = new UserController();
            Checker validateGame = new Checker();

            boardGame.MyProperty = grid;
            boardGame.MyChecker = validateGame;
            boardGame.StartItUp();
        }
    }
}