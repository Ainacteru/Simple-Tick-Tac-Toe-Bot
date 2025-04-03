public abstract class Bots {
    private Moves moves;
    private Board board;

    public Bots(Board board) {
        this.moves = new Moves(board);
        this.board = board;
    }

    public abstract int Move();

    public void MakeMove(string value) {
        int move = Move();

        if (moves.isMoveLegal(move)){
            Console.WriteLine("replacing " + move + " with " + value);
            board.replaceSquare(move, value);
        }
        else {
            throw new SquareIsFull("Square is full!");
        }
    }
}