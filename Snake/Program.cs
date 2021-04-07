﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Point p1 = new Point(1,3,'*');
            p1.Draw();

            Point p2 = new Point(4,5,'#');
            p2.Draw();

            HorizontalLine line = new HorizontalLine(5,10,8,'+');
            line.Draw();

            VerticalLine vline = new VerticalLine(5, 5, 10, '+');
            vline.Draw();
           */
           Console.SetBufferSize(80,25);
           //HorizontalLine upLine = new HorizontalLine(0,78,0,'+');
           //HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
           //VerticalLine leftLine = new VerticalLine(0, 0, 24, '+');
           //VerticalLine rightLine = new VerticalLine(78, 0, 24, '+');
           //upLine.Draw();
           //downLine.Draw();
           //leftLine.Draw();
           //rightLine.Draw();
           Walls walls = new Walls(80,25);
           walls.Draw();


           
           //Drawing
           Point p = new Point(4,5,'*');
           Snake snake = new Snake(p,4,Direction.RIGHT);
           snake.Draw();

           FoodCreator foodCreator = new FoodCreator(80,25,'$');
           Point food = foodCreator.CreateFood();
           food.Draw();


           while (true)
           {
               if (walls.IsHit(snake) || snake.IsHitTail())
               {
                   break;
               }

               if (snake.Eat(food))
               {
                   food = foodCreator.CreateFood();
                   food.Draw();
               }
               else
               {
                   snake.Move();
               }
               Thread.Sleep(200);

               if (Console.KeyAvailable)
               {
                   ConsoleKeyInfo key = Console.ReadKey();
                   snake.HandleKey(key.Key);
               } 
               Thread.Sleep(200);
               snake.Move();
           }

        }
    }
}
