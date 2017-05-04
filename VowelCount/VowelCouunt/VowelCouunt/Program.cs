using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelCouunt
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "aeiou";
            str = str.ToLower();
            int a = str.Count(x => x == 'a');
            int e = str.Count(x => x == 'e');
            int i = str.Count(x => x == 'i');
            int o = str.Count(x => x == 'o');
            int u = str.Count(x => x == 'u');

            int count = a + e + i + o + u;
            Console.Write(count);
            Console.Read();
        }
    }
}
