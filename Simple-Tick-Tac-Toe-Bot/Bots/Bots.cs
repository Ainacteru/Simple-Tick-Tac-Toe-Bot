public abstract class Bots {
    private Moves moves;

    private static List<Bots> Instances = new List<Bots>();

    string playerType = "";

    public Bots(string playerType) {
        Instances.Add(this);
        moves = new Moves();
        playerType = this.playerType;
    }

    public abstract int Move();

    public void MakeMove() {
        int move = Move();

        if (moves.isMoveLegal(move)){
            //Console.WriteLine("replacing " + move + " with " + value);
            Board.ReplaceSquare(move, playerType);
        }
        else {
            throw new SquareIsFull("Square is full!");
        }
    }

    public int GetInstances() {
        return Instances.Count();
    }
}