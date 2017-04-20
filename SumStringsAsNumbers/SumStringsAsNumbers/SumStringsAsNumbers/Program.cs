using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;

namespace SumStringsAsNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string a = "-45633333333333333333333333";
            string b = "456333333333333333333333333";
            BigInteger result = 0;

            if (!string.IsNullOrWhiteSpace(a))
            {
                result += BigInteger.Parse(a);
            }

            if (!string.IsNullOrWhiteSpace(b))
            {
                result += BigInteger.Parse(b);
            }

            Console.Write(result);
            Console.Read();
        }
    }
}