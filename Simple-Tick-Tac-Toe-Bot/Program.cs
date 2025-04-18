using System;

class Program
{
    static void Main(string[] args)
    {
        Moves moves = new Moves();
        Rules rules= new Rules();
        SampleBot bot = new SampleBot();

        rules.GetPlayer();

        Console.WriteLine("This is a simple Tic-Tac-Toe Bot, type anything to continue");
        if (Console.ReadLine() != null) {
            SetUpGame(bot);

            bot.MakeMove();

            VisualizeBoard();
        }
    }

    public static void SetUpGame(Bots bots) {
        if(bots.GetInstances() > 2) {
            throw new Exception("More than 2 bots running at the same time");
        }
    }

    public static void VisualizeBoard() {
        Console.WriteLine();

            var squares = Board.GetSquares(); // Get the array
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

