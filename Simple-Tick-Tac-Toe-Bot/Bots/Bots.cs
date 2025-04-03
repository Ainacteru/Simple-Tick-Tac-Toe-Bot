public abstract class Bots {
    private Moves moves;
    private Board board;

    private static List<Bots> Instances = new List<Bots>();

    public Bots(Board board) {
        this.moves = new Moves(board);
        this.board = board;
        Instances.Add(this);
    }

    public abstract int Move();

    public void MakeMove() {
        int move = Move();
        string value = "X";

        if (moves.isMoveLegal(move)){
            //Console.WriteLine("replacing " + move + " with " + value);
            board.ReplaceSquare(move, value);
        }
        else {
            throw new SquareIsFull("Square is full!");
        }
    }

    public int GetInstances() {
        return Instances.Count();
    }
}