public class Rules {
    private string winner = "";

    private Board board;

    public Rules(Board board) {
        this.board = board;
    }

    public void win() {
        int numberToTest = 3;

        string[] squares = board.GetSquares();

        for (int i = 0; i < 9; i++) //testing 
        {
            int num = 0;
            foreach (var values in squares.Take(numberToTest).ToArray()) {
                
                if (values == "X") {
                    string value = values.ToString();
                    num ++;
                    if (num == 3) {
                        winner = value;
                    }
                }
                else if (values == "O") {
                    string value = values.ToString();
                    num ++;
                    if (num == 3) {
                        winner = value;
                    }
                }
            }

            numberToTest += 3;
        }
    }

    public string GetWinner() {
        return winner + " wins!";
    }

}