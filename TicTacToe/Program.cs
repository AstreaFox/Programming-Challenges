using System;

using System.Threading;


namespace TicTacToe{

    class Program{

        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;
        static int choice;
        static int flag = 0;

        static void Main(string[] args){

            do{


                Console.Clear();
                Console.WriteLine("Player 1: X\nPlayer 2: O\n");


                if (player % 2 == 0) { Console.WriteLine("Player 2's turn:\n"); }
                else{Console.WriteLine("Player 1's turn:\n");}


                CreateBoard();


                Console.Write("\nPlease enter your decision: ");
                choice = int.Parse(Console.ReadLine());
                

                if (arr[choice] != 'X' && arr[choice] != 'O'){


                    if (player % 2 == 0){arr[choice] = 'O';player++;}
                    else{arr[choice] = 'X';player++;}}


                else{


                    Console.WriteLine("Sorry the row {0} is already marked with {1}", choice, arr[choice]);
                    Console.WriteLine("\nPlease wait a second board is loading again.....");
                    Thread.Sleep(1000);


                }


                flag = CheckWin();


            } while (flag != 1 && flag != -1);


            Console.Clear();
            CreateBoard();


            if (flag == 1){Console.WriteLine("Player {0} has won", (player % 2) + 1);}else{Console.WriteLine("Draw");}


            Console.Write("Press any key to close this program: ");
            Console.ReadLine();


        }


        private static void CreateBoard(){


            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |      ");


        }


        private static int CheckWin(){


            if (arr[1] == arr[2] && arr[2] == arr[3]){return 1;}
            else if (arr[4] == arr[5] && arr[5] == arr[6]){return 1;}
            else if (arr[6] == arr[7] && arr[7] == arr[8]){return 1;}
            else if (arr[1] == arr[4] && arr[4] == arr[7]){return 1;}
            else if (arr[2] == arr[5] && arr[5] == arr[8]){return 1;}
            else if (arr[3] == arr[6] && arr[6] == arr[9]){return 1;}
            else if (arr[1] == arr[5] && arr[5] == arr[9]){return 1;}
            else if (arr[3] == arr[5] && arr[5] == arr[7]){return 1;}
            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9'){return -1;}else{return 0;}


        }


    }


}