using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class UserController
    {
        private char[,] grid;
        private Checker checker;

        public Checker MyChecker
        {
            get { return checker; }
            set { checker = value; }
        }
        
        public char[,] MyProperty
        {
            get { return grid; }
            set { grid = value; }
        }

        public void StartItUp()
        {
            int playerNum = 1;

            while (checker.Validate(MyProperty) == false)
            {
                DisplayGrid();

                Console.WriteLine("Player " + playerNum + " pick your number! ");
                char input1 = Console.ReadKey().KeyChar;

                if (input1 == 'Q' || input1 == 'q')
                {
                    break;
                }

                ReplaceNumberWithLetter(input1, playerNum);
                //checker.Validate(MyProperty); // Call the Validate method after each move
               

                playerNum = (playerNum % 2) + 1;

                
            }
            DisplayGrid();
        }

        public void DisplayGrid()
        {
            Console.WriteLine("\nCurrent Grid:");
            Console.WriteLine("-------------");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("| ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(MyProperty[i, j] + " | ");
                }
                Console.WriteLine("\n-------------");
            }
        }

        public void ReplaceNumberWithLetter(char selectedNumber, int playerNum)
        {

            for (int i = 0; i < MyProperty.GetLength(0); i++)
            {
                for (int j = 0; j < MyProperty.GetLength(1); j++)
                {
                    if (MyProperty[i, j] == selectedNumber)
                    {
                        if (playerNum == 1)
                        {
                            MyProperty[i, j] = 'O';

                        }
                        else
                        {
                            MyProperty[i, j] = 'X';

                        }

                    }

                }
            }
           

        }
       
    }
}

