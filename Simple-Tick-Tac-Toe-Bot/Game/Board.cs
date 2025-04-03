public class Board {
    /*
        3x3 grid

          1 |  2 | 3
        --------------
          4 |  5 | 6
        --------------
          7 |  8 | 9 
    */

    private string[] squares = { "X", "2", "3", 
                                 "X", "5", "6", 
                                 "7", "8", "9"};

    public void ReplaceSquare(int square, string value) {
        squares[square - 1] = value;
        //Console.WriteLine(square + " was replaced with " + value);
    }

    public string[] GetSquares() {
        return squares;
    }

    public string SquareValue(int square) {

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