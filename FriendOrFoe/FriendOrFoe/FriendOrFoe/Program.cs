using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendOrFoe
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var result = new List<string>();
            string[] names =  new string[4];
            names[0] = "Ryan";
            names[1] = "Kieran";
            names[2] = "Mark";
            names[3] = "Jimmy";

            foreach (var name in names)
            {
                if(name.Length == 4)
                result.Add(name);
            }
            foreach (var friend in result)
            {
                Console.Write(friend+"\n");
            }
            Console.Read();

            /*result.AsEnumerable();*/
        }
    }
}
