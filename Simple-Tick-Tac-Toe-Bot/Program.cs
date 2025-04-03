using System;

class Program
{
    static void Main(string[] args)
    {
        Board board = new Board();
        Moves moves = new Moves(board);
        SampleBot bot = new SampleBot(board);

        Console.WriteLine("This is a simple Tic-Tac-Toe Bot, type anything to continue");
        if (Console.ReadLine() != null) {
            bot.MakeMove("X");
            Console.WriteLine();
            foreach (var square in board.getSquares()) {
                
                Console.WriteLine(square);
            } // return moves
        }
    }
}

