public class Board {
    /*
        3x3 grid

          1 |  2 | 3
        --------------
          4 |  5 | 6
        --------------
          7 |  8 | 9 
    */

    private static string[] squares = { "1", "2", "3", 
                                 "4", "5", "6", 
                                 "7", "8", "9"};

    //    private string[] squares = { "1", "2", "3", 
    //                                 "4", "5", "6", 
    //                                 "7", "8", "9"};

    public static void ReplaceSquare(int square, string value) {
        squares[square - 1] = value;
        //Console.WriteLine(square + " was replaced with " + value);
    }

    public static string[] GetSquares() {
        return squares;
    }

    public static string SquareValue(int square) {

        return squares[square]; // return if either an x or an o is on the square
    }
}

[Serializable]
class SquareIsFull : Exception
{
    public SquareIsFull() {  }

    public SquareIsFull(string square)
        : base("Square {" + square + "} is Full")
    {

    }
}