using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August18Contraian
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What do you like? ");
            var result = Console.ReadLine();
            var answer = result.StartsWith("I like");
            var dontanswer = result.StartsWith("I don't like");
            var solution = result.Replace("I like", "");
            var dontsolution = result.Replace("I don't like", "");

            if (answer == true)
            {
                Console.Write("I don't like" + solution);
            }
            else if (dontanswer == true)
            {
                Console.Write("I like" + dontsolution);
            }
            else
            {
                Console.Write("Please enter in 'I like or I don't like format'");
            }
            Console.ReadLine();
        }
    }
}
