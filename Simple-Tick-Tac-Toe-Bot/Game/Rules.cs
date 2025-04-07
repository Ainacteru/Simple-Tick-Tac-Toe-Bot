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
        string[] squares = board.GetSquares();
        int winnerCounter = 0;

        for (int i = 0; i < 3; i++)
        {
            string num = squares[i];
            
            if (num == "X") {
                num += 3;
                winnerCounter ++;

                if (num == "X") {
                    num += 3;
                    winnerCounter ++;
                }
            }
            else if (num == "O") {   
                num += 3;
                winnerCounter--;

                if (num == "O") {   
                    num += 3;
                    winnerCounter--;
                }
            }
            Console.WriteLine(num);
            //Console.WriteLine(winnera);
        }

        winner = null;
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