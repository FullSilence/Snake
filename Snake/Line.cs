namespace Snake
{
    using System.Collections.Generic;

    class Line
    {
        protected List<Point> pointList = new List<Point>();

        public void draw()
        {
            foreach (Point i in pointList)
            {
                i.draw();
            }
        }
    }
    class LineHorisontal : Line
    {
        public LineHorisontal(int xFrom, int xTo, int y, char symbol)
        {
            for (int x = xFrom; x <= xTo; x++)
            {
                pointList.Add(new Point(x, y, symbol));
            }
        }
    }

    class LineVertical : Line
    {
        public LineVertical(int yFrom, int yTo, int x, char symbol)
        {
            for (int y = yFrom; y <= yTo; y++)
            {
                pointList.Add(new Point(x, y, symbol));
            }
        }
    }
}