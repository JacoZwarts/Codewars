using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRepeatKata
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = 5;
            string s = "Hello";
            List<string> list = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                list.Add(s);
            }

            Console.Write(string.Join("",list));
            Console.Read();
        }
    }
}
