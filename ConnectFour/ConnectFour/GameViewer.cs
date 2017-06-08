using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSC150_ConsoleMenu;

namespace ConnectFour
{
    public class GameViewer
    {
        private static bool isComp1;
        private static bool isComp2;
        private static Player play1;
        private static Player play2;

        public static void MainMenu()
        {
            List<string> menu = new List<string>() { "Human vs Human", "Human vs Computer", "Computer vs Computer" };
            int choice = CIO.PromptForMenuSelection(menu, true);
            switch(choice)
            {
                case 0:
                    Console.WriteLine("Thank you for playing Connect Four!");
                    break;
                case 1:
                    Console.WriteLine("Human vs Human!");
                    isComp1 = false;
                    isComp2 = false;
                    GetPlayer1();
                    GetPlayer2();
                    break;
                case 2:
                    Console.WriteLine("Human vs Computer!");
                    isComp1 = false;
                    isComp2 = true;
                    GetPlayer1();
                    GetPlayer2();
                    break;
                case 3:
                    Console.WriteLine("Computer vs Computer!");
                    isComp1 = true;
                    isComp2 = true;
                    GetPlayer1();
                    GetPlayer2();
                    break;
                default:
                    break;
            }
            Game.gameStart(play1, play2);
        }

        public static Player GetPlayer1()
        {
            Console.Write("\nPlease Entre Player 1's Name: ");
            string p1 = Console.ReadLine();
            if (p1 == "" || p1 == null)
            {
                if (isComp1 == true)
                {
                    play1 = new Player("Computer 1", true);
                    return play1;
                }
                else
                {
                    play1 = new Player("Human 1", false);
                    return play1;
                }
            }
            else
            {
                play1 = new Player(p1, false);
                return play1;
            }
        }

        public static Player GetPlayer2()
        {
            Console.Write("\nPlease Entre Player 2's Name: ");
            string p2 = Console.ReadLine();
            if (p2 == "" || p2 == null)
            {
                if (isComp2 == true)
                {
                    play2 = new Player("Computer 2", true);
                    return play2;
                }
                else
                {
                    play2 = new Player("Human 2", false);
                    return play2;
                }
            }
            else
            {
                play2 = new Player(p2, false);
                return play2;
            }
        }

        public static void DisplayBoard(string[,] board)
        {
            Console.WriteLine($"|{board[0,0]}|{board[0, 1]}|{board[0, 2]}|{board[0, 3]}|{board[0, 4]}|{board[0, 5]}|{board[0, 6]}|");
            Console.WriteLine($"|{board[1, 0]}|{board[1, 1]}|{board[1, 2]}|{board[1, 3]}|{board[1, 4]}|{board[1, 5]}|{board[1, 6]}|");
            Console.WriteLine($"|{board[2, 0]}|{board[2, 1]}|{board[2, 2]}|{board[2, 3]}|{board[2, 4]}|{board[2, 5]}|{board[2, 6]}|");
            Console.WriteLine($"|{board[3, 0]}|{board[3, 1]}|{board[3, 2]}|{board[3, 3]}|{board[3, 4]}|{board[3, 5]}|{board[3, 6]}|");
            Console.WriteLine($"|{board[4, 0]}|{board[4, 1]}|{board[4, 2]}|{board[4, 3]}|{board[4, 4]}|{board[4, 5]}|{board[4, 6]}|");
            Console.WriteLine($"|{board[5, 0]}|{board[5, 1]}|{board[5, 2]}|{board[5, 3]}|{board[5, 4]}|{board[5, 5]}|{board[5, 6]}|");
        }

        public static int GetColumn()
        {
            int turn = CIO.PromptForInt("Please entre which column you'd like to place your token in (from 0-6): ", 0, 6);
            return turn;
        } 

        public static void CompMove()
        {

        }

        public static void InvalidMessage()
        {

        }

        public static void DisplayWin(bool isWinner)
        {

        }

        public static void ExitMenu()
        {

        }
    }
}
