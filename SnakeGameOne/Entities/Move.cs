//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Threading;

//namespace SnakeGameOne.Entities
//{
//    static void Move()
//    static readonly int gridW = 90;
//    static readonly int gridH = 25;
//    static Cell[,] grid = new Cell[gridH, gridW];
//    static Cell currentCell;
//    static Cell food;
//    static int FoodCount;
//    static int direction; //0=Up 1=Right 2=Down 3=Left
//    static readonly int speed = 1;
//    static bool Populated = false;
//    static bool Lost = false;
//    static int snakeLength;
//    {

//        if (direction == 0)
//        {
//            //up
//            if (grid[currentCell.y - 1, currentCell.x].val == "*")
//            {
//                Lose();
//                return;
//            }
//            visitCell(grid[currentCell.y - 1, currentCell.x]);
//        }
//        else if (direction == 1)
//        {
//            //right
//            if (grid[currentCell.y, currentCell.x - 1].val == "*")
//            {
//                Lose();
//                return;
//            }
//            visitCell(grid[currentCell.y, currentCell.x - 1]);
//        }
//        else if (direction == 2)
//        {
//            //down
//            if (grid[currentCell.y + 1, currentCell.x].val == "*")
//            {
//                Lose();
//                return;
//            }
//            visitCell(grid[currentCell.y + 1, currentCell.x]);
//        }
//        else if (direction == 3)
//        {
//            //left
//            if (grid[currentCell.y, currentCell.x + 1].val == "*")
//            {
//                Lose();
//                return;
//            }
//            visitCell(grid[currentCell.y, currentCell.x + 1]);
//        }
//        Thread.Sleep(speed * 100);
//    }
//}
