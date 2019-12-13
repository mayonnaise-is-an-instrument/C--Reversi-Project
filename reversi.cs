using System;

namespace reversi {

    public class Board {

        public char[,] rows;

        public Board() {
            rows = new char[8, 8]{
                                {'.', '.', '.', '.', '.', '.', '.', '.'},
                                {'.', '.', '.', '.', '.', '.', '.', '.'},
                                {'.', '.', '.', '.', '.', '.', '.', '.'},
                                {'.', '.', '.', 'w', 'b', '.', '.', '.'},
                                {'.', '.', '.', 'b', 'w', '.', '.', '.'},
                                {'.', '.', '.', '.', '.', '.', '.', '.'},
                                {'.', '.', '.', '.', '.', '.', '.', '.'},
                                {'.', '.', '.', '.', '.', '.', '.', '.'},
                            };
        }
        public void print() {
            Console.Write("  A B C D E F G H\n");
            for(int row=0; row<8; row++) {
                Console.Write(row + 1 + " ");
                for(int column=0; column<8; column++) {
                    Console.Write(rows[row, column] + " ");
                }
                Console.Write(row + 1 + "\n");
            }
            Console.Write("  A B C D E F G H\n");
        }

    }

    public class Game {

        public int board;
        public string player1;
        public string player2;
        public string userInput;

        public void play() {
            Player player = new Player();
            player.setColor();
        }
        public Point getMove() {
            int x;
            int y;

            while(true) {
                Console.WriteLine("Enter the space you would like to move.");
                userInput = Console.ReadLine();
                if(String.IsNullOrEmpty(userInput)) {
                    return null;
                }
                x = Char.ConvertToUtf32(userInput, 0);
                y = Char.ConvertToUtf32(userInput, 1);
                //x = userInput[0];
                //y = userInput[1];
                if((x>0) && (x<=8) && (y>0) && (y<=8)) {
                    return new Point(x, y);
                }
            }

        }
        public int setBoard() {
            return board;
        }
        public string setPlayer1() {
            return player1;
        }
        public string setPlayer2() {
            return player2;
        }
        public string setUserInput() {
            return userInput;
        }
    }

    public class Player {

        public string playerName;
        public char color;

        public string getName() {
            Console.WriteLine("Please enter your name.");
            playerName = Console.ReadLine();
            return playerName;
        }
        public char setColor() {
            return color;
        }

    }

    public class Point {

        public int x;
        public int y;

        public Point(int column, int row) {
            x = column;
            y = row;
        }

    }
}
