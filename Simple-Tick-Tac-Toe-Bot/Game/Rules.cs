public class Rules {

    private Board board;
    private bool? winner = null; //null = no one wins, true = x wins, false = o wins || basically using a nullable boolean as a tri-state boolean

    public Rules(Board board) {
        this.board = board;
    }

    public void TestForWin() {
        TestHorizontalSquares();
        TestVerticalSquares();
        TestDiagonalSquares();
    }

    private void TestHorizontalSquares() {
        string[] squares = board.GetSquares();

        for (int i = 0; i < 7; i += 3) { // uses 7 so no overflow error, and increments by 3 so that only 123 would work not 234 (not horizontal anymore)
            if (squares[i] == squares[i+1] && squares[i+1] == squares[i+2]) {
                SetWinner(squares[i]);
            }
        }
    }
    
    private void TestVerticalSquares() {
        string[] squares = board.GetSquares();

        for (int i = 0; i < 3; i++) {
            if(squares[i] == squares[i+3] && squares[i+3] == squares[i+6]) {
                SetWinner(squares[i]);
            }
        }
    }

    private void TestDiagonalSquares() {
        string[] squares = board.GetSquares();

        if (squares[0] == squares[4] && squares[4] == squares[8]) {
            SetWinner(squares[0]);
        }

        if (squares[2] == squares[4] && squares[4] == squares[6]) {
            SetWinner(squares[2]);
        }
    }

    private void SetWinner(string player) {
        if (player == "X") {
            winner = true;
        } else if (player == "O") {
            winner = false;
        } else {
            winner = null;
        }
    }

    public string GetWinner() {
        if (winner == true) {
            return "X won!";
        } else if (winner == false) {
            return "O won!";
        } else {
            return "No one won";
        }
    }

}