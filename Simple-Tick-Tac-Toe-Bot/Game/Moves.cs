
public class Moves {

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
        if(Board.SquareValue(move) == "X" || Board.SquareValue(move) == "O") {
            return false;
        }
        return true;
    }
}