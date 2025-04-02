public class Board {
    /*
        3x3 grid

          1 |  2 | 3
        --------------
          4 |  5 | 6
        --------------
          7 |  8 | 9 
    */

    private string[] squares = { "1", "2", "3", "4", "5", "6", "7", "8", "9"};

    public void replaceSquare(int square, string value) {
        squares[square] = value;
    }

    public static string[] getSquares() {
        Board board = new Board();
        return board.squares;
    }

    public static string SquareValue(int square) {
        Board board = new Board();

        return board.squares[square]; // return if either an x or an o is on the square
    }
}

[Serializable]
class SquareIsFull : Exception
{
    public SquareIsFull() {  }

    public SquareIsFull(string square)
        : base("Square {" + name + "} is Full")
    {

    }
}