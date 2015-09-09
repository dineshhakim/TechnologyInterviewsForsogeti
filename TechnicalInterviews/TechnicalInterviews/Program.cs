using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalInterviews.FizzBuzzs;

namespace TechnicalInterviews
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(FizzBuzz.GetFizzBuzzUpto(21));
            int i = 0;
            string word = "";
            Console.Write("\nPlease Give Me 1st Word\n");
            word = Console.ReadLine();
            Console.Write("Please Give Me 1st No\n");
            int.TryParse(Console.ReadLine(), out i);
            FizzBuzz.FIZZ = word;
            FizzBuzz.FIZZNUMBER = i;

            Console.Write("Please Give Me 2nd Word\n");
            word = Console.ReadLine();
            Console.Write("Please Give Me 2nd No\n");
            int.TryParse(Console.ReadLine(), out i);
            FizzBuzz.BUZZ = word;
            FizzBuzz.BUZZNUMBER = i;

            Console.Write("Please Give Me 3rd Word\n");
            word = Console.ReadLine();
            Console.Write("Please Give Me 3rd No\n");
            int.TryParse(Console.ReadLine(), out i);
            FizzBuzz.POP = word;
            FizzBuzz.POPNUMBER = i;

            Console.Write(FizzBuzz.GetFizzBuzzUpto(21));
            Console.Read();
        }
    }
}
