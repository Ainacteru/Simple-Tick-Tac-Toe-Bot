using System;

class Program
{
    static void Main(string[] args)
    {
        Board board = new Board();
        Moves moves = new Moves(board);
        Rules rules= new Rules(board);
        SampleBot bot = new SampleBot(board);

        VisualizeBoard(board);
        rules.win();
        Console.WriteLine(rules.GetWinner());

        return;


        Console.WriteLine("This is a simple Tic-Tac-Toe Bot, type anything to continue");
        if (Console.ReadLine() != null) {
            SetUpGame(bot);

            bot.MakeMove();

            VisualizeBoard(board);
        }
    }

    public static void SetUpGame(Bots bots) {
        if(bots.GetInstances() > 2) {
            throw new Exception("Fatal Error: more than 2 bots running at the same time");
        }
    }

    public static void VisualizeBoard(Board board) {
        Console.WriteLine();

            var squares = board.GetSquares(); // Get the array
            for (int i = 0; i < squares.Length; i++)
            {
                Console.Write(squares[i] + " ");

                // Add a newline after every 3rd element
                if ((i + 1) % 3 == 0)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
    }

}

