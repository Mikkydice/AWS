using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string likes = "I like fruit";
            string[] fruit = { "Orange", "Apple", "Grapefruit", "Pear", "Pineapple", "Grapes", "Peach", "Melon", "Coconut" };
            int[] numbers = { 5, 6, 3, 8, 2, 9, 1, 6, 15, 66, 34, 23, 32, 45, 29, 30 };
            var getNumbers = from number
                             in numbers
                             where number < 10
                             select number;
            Console.WriteLine(string.Join(", ", getNumbers));


            Console.ReadLine();
        }
    }
}
