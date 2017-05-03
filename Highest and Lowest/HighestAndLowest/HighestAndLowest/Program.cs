using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighestAndLowest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string numbers = "8 3 -5 42 -1 0 0 -9 4 7 4 -4";

            var list = new List<int>();
            foreach (var number in numbers.Split(' '))
            {
                list.Add(Convert.ToInt32(number));
            }

            int highest = list.Max();
            int lowest = list.Min();

            string result = highest + " " + lowest;
            Console.Write(result);
            Console.Read();
        }
    }
}
