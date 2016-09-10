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
            Console.SetBufferSize(120, 30);

            new LineHorisontal(0, 118, 0, '+').draw();
            new LineHorisontal(0, 118, 29, '+').draw();
            new LineVertical(0, 29, 0, '+').draw();
            new LineVertical(0, 29, 118, '+').draw();

            Console.ReadKey();
        }
    }
}
