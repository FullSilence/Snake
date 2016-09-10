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

            new LineHorisontal(3, 35, 8, '*').draw();
            new LineVertical(6, 20, 3, '#').draw();

            Console.ReadKey();
        }

    }
}
