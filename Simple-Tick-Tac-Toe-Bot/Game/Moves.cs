
public class Moves {



    public int[] LegalMoves() {
        return new int[] { 1,};
    }

    private bool isMoveLegal(){
        if(Board.square() != null) {
            return false;
        }
        return true;
    }
}