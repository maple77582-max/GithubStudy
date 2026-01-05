using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            string str = input[0];
            int n = int.Parse(input[1]);
            for (int i = 0; i < n; i++)
            {
                Console.Write(str);
            }
        }
    }
}
