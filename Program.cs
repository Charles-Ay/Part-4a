using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_4a
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand;
            int ten;
            int eleven;
            int max;
            int min;
            int both;

            rand = new Random();
            ten = rand.Next(11);
            eleven = rand.Next(10,21);
            Console.WriteLine($"A random number between 0 - 10 is {ten} and random number between 10 - 20 is {eleven}");
            max = 10;
            min = 0;
            both = rand.Next(min, max);
            Console.WriteLine($"A random number between 0 - 10 inclusive is {both}");
            //if min is bigger than max prgram crashes
            // works noramly if you use negitives

        }
    }
}
