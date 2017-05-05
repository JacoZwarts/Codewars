using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExesAndOhs
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "ooom";

            var list = new List<string>();
            foreach (var letter in input)
            {
                list.Add(letter.ToString().ToLower());
            }

            var xCount = list.Count(letter => letter == "x");
            var oCount = list.Count(letter => letter == "o");

            if(xCount == oCount)
                Console.Write("True");
            else
                Console.Write("False");

            Console.Read();
        }
    }
}
