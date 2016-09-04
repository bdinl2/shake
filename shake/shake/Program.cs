using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            HorisontalLine upLine = new HorisontalLine(0, 78, 0, '+');
            HorisontalLine downLine = new HorisontalLine(0, 78, 24, '+');
            VertLine rightLine = new VertLine(0, 24, 0, '+');
            VertLine leftLine = new VertLine(0, 24, 78, '+');
            upLine.Drow();
            downLine.Drow();
            rightLine.Drow();
            leftLine.Drow();


            Console.ReadLine();

        }

    }
}
