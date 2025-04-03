public class Rules {

    private Board board;
    private bool? winner = null; //null = no one wins, true = x wins, false = o wins || basically using a nullable boolean as a tri-state boolean

    public Rules(Board board) {
        this.board = board;
    }

    public void win() {
        //TestHorizontalSquares();
        TestVerticalSquares();
    }

    private void TestHorizontalSquares() {
        int numberToTest = 3;

        string[] squares = board.GetSquares();

        for (int i = 0; i < 9; i++)
        {
            int num = 0;
            foreach (var values in squares.Take(numberToTest).ToArray()) { //tests if someone wins horizontally
                
                if (values == "X") {
                    string value = values.ToString();
                    num ++;
                    if (num == 3) {
                        winner = true;
                        return;
                    }
                }
                else if (values == "O") {
                    string value = values.ToString();
                    num --;
                    if (num == -3) {
                        winner = false;
                        return;
                    }
                }
            }

            numberToTest += 3;
        }
        winner = null;
        return;
    }
    private void TestVerticalSquares() {
        //vertical squares are all a difference/sum of 3
        int VertSquare = 0;
        int num = 0;
        for (int i = 0; i < 9; i++) {
            string[] squares = board.GetSquares();

            if (squares[VertSquare-1] == "X") {
                num++;
                if (num == 3) {
                    winner = true; return;
                }
            } else if (squares[VertSquare-1] == "O") {
                num--;
                if (num == -3) {
                    winner = false; return;
                }
            }
            if (i < 3) {
                VertSquare += 3;
                Console.WriteLine(i + "," + VertSquare);
            }
            else {
                Console.WriteLine("overflow!");
                return;
            }
        }
        winner = null;
        return;
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