using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFun_Rocks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double input = 100000000;
            int count = 0;

            for (double i = 1; i <= input; i++)
            {
                if (i.ToString().Length == 1)
                    count++;

                if (i.ToString().Length >= 2)
                    count += i.ToString().Length;
            }

            
            Console.Write(count);
            Console.ReadLine();

        }
    }
}
