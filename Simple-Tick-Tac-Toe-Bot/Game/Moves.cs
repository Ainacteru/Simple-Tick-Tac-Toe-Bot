
public class Moves {

    private int[] allowedMoves = {1,2,3,4,5,6,7,8,9};

    public int[] LegalMoves() {
        for (int i = 0; i < Board.getSquares().Length; i++)
        {
            if(!isMoveLegal(i)) {
                allowedMoves[i] = 0;
            }
        }
        return allowedMoves;
    }

    public bool isMoveLegal(int move){
        if(Board.SquareValue(move) == "X" || Board.SquareValue(move) == "O") {
            return true;
        }
        return false;
    }
}