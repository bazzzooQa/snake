﻿using System;

namespace snake
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Point p1 = new Point(2, 4, '*');
            p1.Draw();
			
			HorizontalLine hline1 = new HorizontalLine(0, 78, 0, '#');
			HorizontalLine hline2 = new HorizontalLine(0, 78, 23, '#');
			VerticalLine vline1 = new VerticalLine(0, 23, 0, '#');
			VerticalLine vline2 = new VerticalLine(0, 23, 78, '#');
			
			hline1.Draw();
            hline2.Draw();
            vline1.Draw();
            vline2.Draw();
        }

    }
}
