using System;
using Leetcode.Code;

namespace Leetcode
{
    public class Program
    {
        static void Main(string[] args)
        {

        }
        public void TwoBumsSum() 
        {
            int[] result = TwoNumbersSUM.Implementation_1();
            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
