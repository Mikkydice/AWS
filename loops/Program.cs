using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double count = 0;
            do
            {
                sum = sum + Math.Pow(count, 2.0);
                Console.WriteLine("count: {0}  sum:  {1}", count, sum);
                count++;
            } while (count != 10);
            Console.ReadLine();
        }
    }
}
