using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
		    //making a box
            HorizontalLine hline1 = new HorizontalLine(0, 78, 0, '#');
            HorizontalLine hline2 = new HorizontalLine(0, 78, 23, '#');
            VerticalLine vline1 = new VerticalLine(0, 23, 0, '#');
            VerticalLine vline2 = new VerticalLine(0, 23, 78, '#');
            hline1.Draw();
            hline2.Draw();
            vline1.Draw();
            vline2.Draw();

			Point p = new Point(2, 4, '*');
			Snake snk = new Snake(p, 4, Direction.RIGHT);
			snk.Draw();

			FoodCreator foodCreator = new FoodCreator(80, 25, '+');
			Point food = foodCreator.CreateFood();
			food.Draw();

			while (true)
			{
				if (snk.Eat(food))
				{
					food = foodCreator.CreateFood();
					food.Draw();
				}
				else
				{
					snk.Move();
				}

				Thread.Sleep(100);

				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snk.HandleKey(key.Key);
				}
			}
        }
    }
}
