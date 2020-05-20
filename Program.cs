using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingClouds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert few clouds separated by space ' ' ex: '1 0 0 1 1 0 0' ");

            var input = Console.ReadLine();
            var jumps = new JumpingClouds();
            
            Console.WriteLine("Number of jumps to win: " + jumps.JumpingOnClouds(input));
        }

    }
}
