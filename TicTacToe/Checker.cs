using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Checker
    {
        public bool Validate(char[,] board)
        {


            int verticalCount0O = 0;
            int verticalCount1O = 0;
            int verticalCount2O = 0;
            int verticalCount0X = 0;
            int verticalCount1X = 0;
            int verticalCount2X = 0;

            int horizontalCount0O = 0;
            int horizontalCount1O = 0;
            int horizontalCount2O = 0;
            int horizontalCount0X = 0;
            int horizontalCount1X = 0;
            int horizontalCount2X = 0;

            int topLeftX = 0;
            int topRightX = 0;
            int topLeftO = 0;
            int topRightO = 0;
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    //this code is for vertical checking
                    if (j == 0 && board[i, j] == 'X')
                    {

                        verticalCount0X++;
                        if (verticalCount0X == 3)
                        {
                            Console.WriteLine("\nFound Vertical X at row " + j);
                        }
                    }
                    else if (j == 0 && board[i, j] == 'O')
                    {

                        verticalCount0O++;
                        if (verticalCount0O == 3)
                        {
                            Console.WriteLine("\nFound Vertical O at row " + j);

                        }
                    }
                    else if (j == 1 && board[i, j] == 'X')
                    {

                        verticalCount1X++;
                        if (verticalCount1X == 3)
                        {
                            Console.WriteLine("\nFound Vertical X at row " + j);

                        }
                    }
                    else if (j == 1 && board[i, j] == 'O')
                    {

                        verticalCount1O++;
                        if (verticalCount1O == 3)
                        {
                            Console.WriteLine("\nFound Vertical O at row " + j);

                        }
                    }
                    else if (j == 2 && board[i, j] == 'X')
                    {

                        verticalCount2X++;
                        if (verticalCount2X == 3)
                        {
                            Console.WriteLine("\nFound Vertical X at row " + j);

                        }
                    }
                    else if (j == 2 && board[i, j] == 'O')
                    {

                        verticalCount2O++;
                        if (verticalCount2O == 3)
                        {
                            Console.WriteLine("\nFound Vertical O at row " + j);

                        }
                    }
                    //below is for horizontal
                    if (i == 0 && board[i, j] == 'X')
                    {

                        horizontalCount0X++;
                        if (horizontalCount0X == 3)
                        {
                            Console.WriteLine("\nFound Horizontal X at row " + i);

                        }
                    }
                    else if (i == 0 && board[i, j] == 'O')
                    {

                        horizontalCount0O++;
                        if (horizontalCount0O == 3)
                        {
                            Console.WriteLine("\nFound Horizontal O at row " + i);

                        }
                    }
                    else if (i == 1 && board[i, j] == 'X')
                    {

                        horizontalCount1X++;
                        if (horizontalCount1X == 3)
                        {
                            Console.WriteLine("\nFound Horizontal X at row " + i);

                        }
                    }
                    else if (i == 1 && board[i, j] == 'O')
                    {

                        horizontalCount1O++;
                        if (horizontalCount1O == 3)
                        {
                            Console.WriteLine("\nFound Horizontal O at row " + i);

                        }
                    }
                    else if (i == 2 && board[i, j] == 'X')
                    {

                        horizontalCount2X++;
                        if (horizontalCount2X == 3)
                        {
                            Console.WriteLine("\nFound Horizontal X at row " + i);

                        }
                    }
                    else if (i == 2 && board[i, j] == 'O')
                    {

                        horizontalCount2O++;
                        if (horizontalCount2O == 3)
                        {
                            Console.WriteLine("\nFound Horizontal O at row " + i);

                        }
                    }
                    if (i == j && board[i, j] == 'X')
                    {
                        topLeftX++;
                        if (topLeftX == 3)
                        {
                            Console.WriteLine("\nFound top left to bottom right diagonal with X");
                        }
                    }
                    else if (i == j && board[i, j] == 'O')
                    {
                        topLeftO++;
                        if (topLeftO == 3)
                        {
                            Console.WriteLine("\nFound top left to bottom right diagonal with O");
                        }
                    }
                    if (i + j == board.GetLength(1) - 1 && board[i, j] == 'X')
                    {
                        topRightX++;
                        if (topRightX == 3)
                        {
                            Console.WriteLine("\nFound top right to bottom left diagonal with X");
                        }
                    }

                    else if (i + j == board.GetLength(1) - 1 && board[i, j] == 'O')
                    {
                        topRightO++;
                        if (topRightO == 3)
                        {
                            Console.WriteLine("\nFound top right to bottom left diagonal with O");
                        }
                    }
                }

            }
            int counter = 0;
            for (int i = 0; i < board.GetLength(0); i++)
            {

                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == 'O' || board[i, j] == 'X')
                    {
                        counter++;
                       
                    }


                }
            }
            if (verticalCount0O == 3 || verticalCount1O == 3 ||
                verticalCount2O == 3 || verticalCount0X == 3 ||
                verticalCount1X == 3 || verticalCount2X == 3 ||
                horizontalCount0O == 3 || horizontalCount1O == 3 ||
                horizontalCount2O == 3 || horizontalCount0X == 3 ||
                horizontalCount1X == 3 || horizontalCount2X == 3 ||
                topLeftX == 3 || topRightX == 3 ||
                topLeftO == 3 || topRightO == 3)
            {
                //Console.WriteLine("TRUE");
                return true;
            }
            else if (counter == 9)
            {
                Console.WriteLine("\nITS A TIE!!!");
                return true;
            }
            else
            {
                //Console.WriteLine("FALSE");
                return false;
            }

        }
    }
}
