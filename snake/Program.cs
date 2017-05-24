using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorizontalLine hline = new HorizontalLine(5, 10, 8, '+');
            hline.Draw();

            VerticalLine vline = new VerticalLine(5, 10, 3, '-');
            vline.Draw();

			Console.ReadLine();
        }

    }
}
