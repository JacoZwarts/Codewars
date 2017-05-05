using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHiddenWord
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 637;

            var List = new List<string>();
            var result = new List<string>();
            foreach (var number in num.ToString())
            {
                List.Add(number.ToString());

                
            }
            foreach (var item in List)
            {
                if (item.Contains("6"))
                   result.Add("a");
                if(item.Contains("1"))
                    result.Add("b");
                if (item.Contains("7"))
                    result.Add("d");
                if (item.Contains("4"))
                    result.Add("e");
                if (item.Contains("3"))
                    result.Add("i");
                if (item.Contains("2"))
                    result.Add("l");
                if (item.Contains("9"))
                    result.Add("m");
                if (item.Contains("8"))
                    result.Add("n");
                if (item.Contains("0"))
                    result.Add("o");
                if (item.Contains("5"))
                    result.Add("t");
            }

            string word = String.Join(string.Empty, result);


                Console.Write(word);

            Console.Read();
        }
    }
}
