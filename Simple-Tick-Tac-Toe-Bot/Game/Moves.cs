
public class Moves {

    private int[] allowedMoves = {1,2,3,4,5,6,7,8,9};

    private Board board;

    public Moves(Board board) {
        this.board = board;
    }

    public int[] LegalMoves() {
        List<int> allowedMoves = new List<int>();

        for (int i = 1; i <= 9; i++) { // 1-based indexing
            if (isMoveLegal(i)) {
                allowedMoves.Add(i);
            }
        }

        return allowedMoves.ToArray();
    }

    public bool isMoveLegal(int move){
        if(board.SquareValue(move) == "X" || board.SquareValue(move) == "O") {
            return false;
        }
        return true;
    }
}