// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using qtxTutorialC_Part08;
using qtxTutorialC_Part08._2048;
//CaiPiao.Simulation();
int[,] board = new int[4, 4]
{
    {2, 2, 4, 8},
    {2, 0, 4, 8},
    {0, 0, 4, 0},
    {2, 2, 0, 0}
};
moveAndMerge.PrintBoard(board);
board = moveAndMerge.MoveUp(board);
moveAndMerge.PrintBoard(board);
board = moveAndMerge.MoveDown(board);
moveAndMerge.PrintBoard(board);
board = moveAndMerge.MoveLeft(board);
moveAndMerge.PrintBoard(board);
board = moveAndMerge.MoveRight(board);
moveAndMerge.PrintBoard(board);
moveAndMerge.Move(board, MoveDirection.Left);
moveAndMerge.Move(board, MoveDirection.Right);