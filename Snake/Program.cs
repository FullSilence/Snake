using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            new point(5, 3).draw();

            Console.ReadKey();
        }

    }

    class point
    {
        public int x;
        public int y;
        public char symbol;

        public point(int _x, int _y, char _symbol = '*')
        {
            x = _x;
            y = _y;
            symbol = _symbol;
        }

        public void draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
    }
}
