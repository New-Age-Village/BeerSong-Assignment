using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class BeerSong
    {
        public BeerSong(int num)
        {
            for (int i = 99; num < i; i--)
            {
                if (i == 1)
                {
                    Console.WriteLine(i + "  bottle of beer on the wall, " + i + " bottle of beer. Take one down and pass it around");
                }
                else
                {
                    Console.WriteLine(i + "  bottles of beer on the wall, " + i + " bottles of beer. Take one down and pass it around");
                }
            }
        }
    }
}
