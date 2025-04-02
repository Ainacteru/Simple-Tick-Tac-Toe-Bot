public abstract class Bots {
    Moves moves;
    Board board;

    public Bots() {
        moves = new Moves();
        board = new Board();
    }

    public abstract int Move();

    public void MakeMove(int move) {
        move = Move();

        if (moves.isMoveLegal()){
            board.replaceSquare(move);
        }
        else {
            throw new SquareIsFull("Square is full!");
        }
    }
}