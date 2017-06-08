using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSC150_ConsoleMenu;

namespace ConnectFour
{
    public class Game
    {

        public static string[,] board = new string[6, 7];
        private static Random rand = new Random();
        private static int playerTurn;

        public static int checkTurn()
        {
            return 0;
        }

        public static bool checkColumn()
        {
            return false;
        }

        public static void compTurn()
        {

        }

        public static void checkWin()
        {

        }

        public static void gameStart(Player p1, Player p2)
        {
            Console.WriteLine();
            int randChoice = rand.Next(2);
            if (randChoice == 0)
            {
                Console.WriteLine("You'll be going first, " + p1);
                playerTurn = 1;
            }
            else
            {
                Console.WriteLine("You'll be going first, " + p2);
                playerTurn = 2;
            }
            if (playerTurn == 1)
            {
                GameViewer.DisplayBoard(board);
                int place = GameViewer.GetColumn();
                if (board[5, place] == "")
                {
                    board[5, place] += "R";
                }
                playerTurn++;
            }
            else
            {
                GameViewer.DisplayBoard(board);
                int place = GameViewer.GetColumn();
                if (board[5, place] == "")
                {
                    board[5, place] += "Y";
                }
                playerTurn = 1;
            }
            GameViewer.DisplayBoard(board);
            nextTurn(playerTurn);
        }

        public static void nextTurn(int turn)
        {
            int place = GameViewer.GetColumn();
            string token;
            if (turn == 1)
            {
                token = "R";
            } else
            {
                token = "Y";
            } 

            if (board[5, place] == "")
            {
                board[5, place] += token;
            }
            else if (board[4, place] == "")
            {
                board[4, place] += token;
            }
            else if (board[3, place] == "")
            {
                board[3, place] += token;
            }
            else if (board[2, place] == "")
            {
                board[2, place] += token;
            }
            else if (board[1, place] == "")
            {
                board[1, place] += token;
            }
            else if (board[0, place] == "")
            {
                board[0, place] += token;
            }
        }
    }
}
