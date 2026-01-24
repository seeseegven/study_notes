using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qtxTutorialC_Part08._2048
{
    internal class moveAndMerge
    {
        internal static void PrintBoard(int[,] board)
        {
            int size = board.GetLength(0);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(board[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        internal static int[,] MoveUp(int[,] board)
        {
            int size = board.GetLength(0);
            for (int j = 0; j < size; j++)
            {
                int k = 0, i = 0;
                while (i < size)
                {
                    if (board[i, j] != 0)
                    {
                        board[k++, j] = board[i++, j];
                    }
                    else
                    {
                        i++;
                    }
                }
                for (; k < size; k++)
                {
                    board[k, j] = 0;
                }
                //PrintBoard(board);
                for (i = 0; i < size - 1; i++)
                {
                    if (board[i, j] == board[i + 1, j])
                    {
                        board[i, j] *= 2;
                        board[i + 1, j] = 0;
                    }
                }
                k = i = 0;
                while (i < size)
                {
                    if (board[i, j] != 0)
                    {
                        board[k++, j] = board[i++, j];
                    }
                    else
                    {
                        i++;
                    }
                }
                for (; k < size; k++)
                {
                    board[k, j] = 0;
                }
                //PrintBoard(board);
            }
            return board;
        }

        internal static int[,] MoveDown(int[,] board)
        {
            int size = board.GetLength(0);
            for (int j = 0; j < size; j++)
            {
                int k = size - 1, i = size - 1;
                while (i >= 0)
                {
                    if (board[i, j] != 0)
                    {
                        board[k--, j] = board[i--, j];
                    }
                    else
                    {
                        i--;
                    }
                }
                for (; k >= 0; k--)
                {
                    board[k, j] = 0;
                }
                for (i = size - 1; i > 0; i--)
                {
                    if (board[i, j] == board[i - 1, j])
                    {
                        board[i, j] *= 2;
                        board[i - 1, j] = 0;
                    }
                }
                k = size - 1; i = size - 1;
                while (i >= 0)
                {
                    if (board[i, j] != 0)
                    {
                        board[k--, j] = board[i--, j];
                    }
                    else
                    {
                        i--;
                    }
                }
                for (; k >= 0; k--)
                {
                    board[k, j] = 0;
                }
            }
            return board;
        }

        internal static int[,] MoveLeft(int[,] board)
        {
            int size = board.GetLength(0);
            for (int i = 0; i < size; i++)
            {
                int k = 0, j = 0;
                for (; k < size; k++)
                {
                    if (board[i, k] != 0)
                    {
                        board[i, j++] = board[i, k];
                    }
                }
                for (; j < size; j++)
                {
                    board[i, j] = 0;
                }
                for (j=0;j<size-1;j++)
                {
                    if (board[i, j] == board[i, j + 1])
                    {
                        board[i, j] *= 2;
                        board[i, j + 1] = 0;
                    }
                }
                k=j=0;
                for (; k < size; k++)
                {
                    if (board[i, k] != 0)
                    {
                        board[i, j++] = board[i, k];
                    }
                }
                for (; j < size; j++)
                {
                    board[i, j] = 0;
                }
            }
            return board;
        }

        internal static int[,] MoveRight(int[,] board)
        {
            int size = board.GetLength(0);
            for (int i = 0; i < size; i++)
            {
                int k = size - 1, j = size - 1;
                for (; k >= 0; k--)
                {
                    if (board[i, k] != 0)
                    {
                        board[i, j--] = board[i, k];
                    }
                }
                for (; j >= 0; j--)
                {
                    board[i, j] = 0;
                }
                for (j = size - 1; j > 0; j--)
                {
                    if (board[i, j] == board[i, j - 1])
                    {
                        board[i, j] *= 2;
                        board[i, j - 1] = 0;
                    }
                }
                k = j = size - 1;
                for (; k >= 0; k--)
                {
                    if (board[i, k] != 0)
                    {
                        board[i, j--] = board[i, k];
                    }
                }
                for (; j >= 0; j--)
                {
                    board[i, j] = 0;
                }
            }
            return board;
        }
    }
}
